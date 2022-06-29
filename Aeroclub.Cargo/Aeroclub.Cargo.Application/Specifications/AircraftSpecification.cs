using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AircraftSpecification : BaseSpecification<Aircraft>
    {
        public AircraftSpecification(AircraftValidationQM query)
            : base(x => !string.IsNullOrEmpty(query.RegNo) &&  x.RegNo.ToLower() == query.RegNo.ToLower())
        {

        }

        public AircraftSpecification(AircraftQM query)
          : base(x => query.Id != Guid.Empty && x.Id == query.Id)
        {

        }

   
        public AircraftSpecification(AircraftListQM query, bool isCount = false)
            : base(x => (string.IsNullOrEmpty(query.RegNo) || x.RegNo.ToLower() == query.RegNo.ToLower()) &&
            (query.AircraftType == AircraftTypes.None || x.AircraftType == query.AircraftType) &&
            (query.ActiveType == AircraftActiveTypes.None || (query.ActiveType == AircraftActiveTypes.Active)?x.IsActive : !x.IsActive) && 
            !x.IsDeleted)
        {
            if (!isCount)
            {
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
            }
        }


    }
}
