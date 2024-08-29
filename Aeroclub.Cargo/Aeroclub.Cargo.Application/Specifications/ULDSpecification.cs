using Aeroclub.Cargo.Application.Models.Queries.AirportQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class ULDSpecification: BaseSpecification<ULD>
    {
        public ULDSpecification(ULDQM query)
            :base(x=> (query.Id == Guid.Empty || x.Id == query.Id) &&
                query.PositionId == Guid.Empty || x.ULDCargoPosition.CargoPositionId == query.PositionId)
        {
            AddInclude(y => y.Include(z => z.ULDCargoPosition).ThenInclude(c => c.CargoPosition));
            AddInclude(y => y.Include(z => z.ULDMetaData));
        }

        public ULDSpecification(ULDListQM query, bool isCount = false)
            :base(x => (string.IsNullOrEmpty(query.ULDNumber) || x.SerialNumber.Contains(query.ULDNumber) ) && !x.IsDeleted)
        {
            if (!isCount)
            {
                AddInclude(x => x.Include(y => y.ULDMetaData));
                AddInclude(x => x.Include(y => y.Airport));
                AddInclude(x => x.Include(y => y.ULDTrackings));
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }
        }

        public ULDSpecification(ULDLocateStatus? ULDLocateStatus)
            : base(x => (ULDLocateStatus == null || x.ULDLocateStatus == ULDLocateStatus) && !x.IsDeleted)
        {
            AddInclude(x => x.Include(y => y.ULDMetaData));
        }

        public ULDSpecification(string ULDNumber)
            :base(x => (string.IsNullOrEmpty(ULDNumber) || x.SerialNumber.Contains(ULDNumber) ) && !x.IsDeleted)
        {

        }

        public ULDSpecification()
            : base(x => !x.IsDeleted)
        {

        }
    }
}
