using Aeroclub.Cargo.Application.Models.Queries.DeliveryAuditQM;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class DeliveryAuditSpecification : BaseSpecification<DeliveryAudit>
    {
        public DeliveryAuditSpecification(DeliveryAuditQM query)
        : base(x => x.CollectedDate.Date >= query.start.Date && x.CollectedDate.Date <= query.end.Date ){ 
            
        
        
        }
    }
}
