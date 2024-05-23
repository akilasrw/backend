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

                           
                            i.WhRec = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.Cargo_Received).Count();
                            i.ParcellsOnHold = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.Offloaded).Count();
                            i.ULDPacked = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.AcceptedForFLight).Count();
                            i.BookingMade = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.Booking_Made).Count();
                            i.OnRoute = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.FlightDispatched || x.PackageItemStatus == PackageItemStatus.Arrived || x.PackageItemStatus == PackageItemStatus.IndestinationWarehouse).Count();
                            i.ParcellsDeliverd = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd).Count();
                            i.OneDay = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 1, 0)).Count();
                            i.AfterOneAndHalf = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 10, 1.5)).Count();
                            i.OneDayToOneAndHalf = packageOldList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 1.5, 1)).Count();

                        }

                       
                    }



                    var awbSpec = new AWBNumberStackSpecification(DateTime.Today.AddDays(-1));

                    var packageSpec = new PackageItemSpecification(DateTime.Today.AddDays(-1));

                    var packageList = await unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(packageSpec);

                    var awbList = await unitOfWork.Repository<AWBNumberStack>().GetListWithSpecAsync(awbSpec);





                    await unitOfWork.Repository<DeliveryAudit>().CreateAsync(new DeliveryAudit
                    {
                        CollectedDate = DateTime.Now.AddDays(-1),
                        AWBs = awbList.Count,
                        ParcellsCollected = packageList.Count,
                        BookingMade = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Booking_Made).Count(),
                        ParcellsRetured = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Returned).Count(),
                        ParcellsOnHold = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Offloaded).Count(),
                        ULDPacked = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.AcceptedForFLight).Count(),
                        WhRec = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Cargo_Received).Count(),
                        OnRoute = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.FlightDispatched || x.PackageItemStatus == PackageItemStatus.Arrived || x.PackageItemStatus == PackageItemStatus.IndestinationWarehouse).Count(),
                        ParcellsDeliverd = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd).Count(),
                        OneDay = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 1, 0)).Count(),
                        AfterOneAndHalf = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 10, 1.5)).Count(),
                        OneDayToOneAndHalf = packageList.Where((x) => x.PackageItemStatus == PackageItemStatus.Deliverd && CalculateDifferenceInDays(x.Created, (DateTime)x.LastModified, 1.5, 1)).Count()
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
