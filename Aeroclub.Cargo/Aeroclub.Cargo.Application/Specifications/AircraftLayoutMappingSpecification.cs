﻿using Aeroclub.Cargo.Application.Models.Queries.AircrftLayoutMappingQM;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AircraftLayoutMappingSpecification : BaseSpecification<AircraftLayoutMapping>
    {
        public AircraftLayoutMappingSpecification(AircraftLayoutMappingQM query)
            : base(x => (query.AircraftTypeId != Guid.Empty && x.AircraftTypeId == query.AircraftTypeId) &&
            (query.AircraftSubTypeId != Guid.Empty && x.AircraftSubTypeId == query.AircraftSubTypeId))
        {

        }
    }
}