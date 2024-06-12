﻿using Aeroclub.Cargo.Application.Models.Queries.AirportQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;


namespace Aeroclub.Cargo.Application.Specifications
{
    public class AirportSpecification : BaseSpecification<Airport>
    {
        public AirportSpecification(AirportListQM query, bool isCount = false)
            : base(x =>(string.IsNullOrEmpty(query.AirportName) || x.Name.Contains(query.AirportName) ) && 
            (string.IsNullOrEmpty(query.CountryName) || x.Country.Name.Contains(query.CountryName)) &&
            (string.IsNullOrEmpty(query.AirportCode) || x.Code.Contains(query.AirportCode)) && !x.IsDeleted)
        {
            if (!isCount)
            {
                if (query.IsCountryInclude)
                {
                    AddInclude(x => x.Include(y => y.Country));
                }
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
                AddOrderByDescending(x => x.Created);
            }
        }

        public AirportSpecification(AirportQM query)
            : base(x => x.Id == query.Id && !x.IsDeleted)
        {
            if (query.IsCountryInclude)
            {
                AddInclude(x => x.Include(y => y.Country));
            }
        }

        public AirportSpecification(AirportValidationQM query)
            : base(x => !string.IsNullOrEmpty(query.AirportCode) && x.Code.ToLower() == query.AirportCode.ToLower() && x.IsDeleted == false)
        {

        }
    }
}