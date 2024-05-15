using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.GetAWBbyUldAndFlightScheduleRM;
using Aeroclub.Cargo.Application.Models.RequestModels.GetPackagesByAWBandULDRM;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class ULDContainerSpecification : BaseSpecification<ULDContainer>
    {
        public ULDContainerSpecification(ULDContainerQM query)
            :base(x=>x.Id == query.Id)
        {
            AddInclude(y => y.Include(y => y.PackageULDContainers).ThenInclude(z=>z.PackageItem));
        }

        public ULDContainerSpecification(Guid uldId)
            :base(x => x.ULDId == uldId)
        {
            AddInclude(y => y.Include(x => x.ULD));
        }

        public ULDContainerSpecification(GetAWBbyUldAndFlightScheduleRM query)
           : base(x => x.ULD.SerialNumber == query.uld)
        {

        }

        public ULDContainerSpecification(GetPackageByAwbAndUldRM query)
            : base(x => x.ULD.SerialNumber == query.uld && x.PackageULDContainers.Any((x) => x.PackageItem.CargoBooking.AWBInformation.AwbTrackingNumber == query.AwbNumber))
        {
            AddInclude(y => y.Include(y => y.PackageULDContainers).ThenInclude(z => z.PackageItem));
        }
    }
}
