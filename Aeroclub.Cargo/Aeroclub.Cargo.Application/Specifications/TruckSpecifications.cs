using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class TruckSpecifications : BaseSpecification<Truck>
    {
        public TruckSpecifications(string truckId) 
        :base(x => x.truckNumber == truckId){
        
        }
    }
}
