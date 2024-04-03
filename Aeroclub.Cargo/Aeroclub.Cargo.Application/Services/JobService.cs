using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using Google.Protobuf.WellKnownTypes;
using Google.Type;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DateTime = System.DateTime;

namespace Aeroclub.Cargo.Application.Services
{
    public class JobService : IJob
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public JobService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public static bool CalculateDifferenceInDays(DateTime date1, DateTime date2, double x, double y )
        {
            var days = (date2 - date1).TotalDays;

            if(days<=x && days > y)
            {
                return true;
            }

            return false;
        }

        public async Task Execute(IJobExecutionContext context)
        {

            using (var scope = _serviceScopeFactory.CreateScope())
            {
                try
                {



                    var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

                    var prevRecords = await unitOfWork.Repository<DeliveryAudit>().GetListAsync();

                    var lastRecods = prevRecords.Take(10).ToList();

                    foreach (var i in lastRecods)
                    {
                        if(i.ParcellsCollected != (i.ParcellsRetured + i.ParcellsDeliverd))
                        {
                            var awbListSpec = new AWBNumberStackSpecification(i.CollectedDate.Date);

                            var packageListSpec = new PackageItemSpecification(i.CollectedDate.Date);

                            var packageOldList = await unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(packageListSpec);

                            var awbOldList = await unitOfWork.Repository<AWBNumberStack>().GetListWithSpecAsync(awbListSpec);

                         if(i.ParcellsOnHold != 0)
                            {
                                i.ParcellsOnHold = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.Offloaded).Count();
                            }

                            if (i.ULDPacked != 0)
                            {
                                i.ULDPacked = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.AcceptedForFLight).Count();
                            }

                            if (i.OnRoute != 0)
                            {
                                i.OnRoute = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.FlightDispatched || x.PackageItemStatus == PackageItemStatus.Arrived || x.PackageItemStatus == PackageItemStatus.IndestinationWarehouse).Count();
                            }
                        }
                    }



                    var awbSpec = new AWBNumberStackSpecification(DateTime.Today);

                    var packageSpec = new PackageItemSpecification(DateTime.Today);

                    var packageList = await unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(packageSpec);

                    var awbList = await unitOfWork.Repository<AWBNumberStack>().GetListWithSpecAsync(awbSpec);





                    await unitOfWork.Repository<DeliveryAudit>().CreateAsync(new DeliveryAudit
                    {
                        CollectedDate = DateTime.Now,
                        AWBs = awbList.Count,
                        ParcellsCollected = packageList.Count,
                        ParcellsRetured = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Returned).Count(),
                        ParcellsOnHold = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Offloaded).Count(),
                        ULDPacked = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.AcceptedForFLight).Count(),
                        OnRoute = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.FlightDispatched || x.PackageItemStatus == PackageItemStatus.Arrived || x.PackageItemStatus == PackageItemStatus.IndestinationWarehouse).Count(),
                        ParcellsDeliverd = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd).Count(),
                        OneDay = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 1, 0)).Count(),
                        AfterOneAndHalf = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 1.5, 1)).Count(),
                        OneDayToOneAndHalf = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 1.5, 10)).Count()
                    });

                    await unitOfWork.SaveCronChangesAsync();
                }
                catch (Exception ex)
                {

                }
            

                Console.WriteLine("Done");
            }
        }
    }
}
