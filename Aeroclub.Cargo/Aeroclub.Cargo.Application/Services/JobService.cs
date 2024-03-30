using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using System;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class JobService : IJob
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public JobService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                // Now you can use the unitOfWork within this scope
                // For example:
                var list = await unitOfWork.Repository<DeliveryAudit>().GetListAsync();

                Console.WriteLine("Done");
            }
        }
    }
}
