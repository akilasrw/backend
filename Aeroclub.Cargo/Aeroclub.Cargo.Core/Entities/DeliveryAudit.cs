using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class DeliveryAudit : BaseEntity
    {
        public DateTime CollectedDate { get; set; }
        public int BookingMade { get; set; }
        public int AWBs { get; set; }
        public int ParcellsCollected {  get; set; }
        public int ParcellsRetured { get; set; }
        public int ParcellsOnHold { get; set; }
        public int WhRec { get; set; }
        public int ULDPacked { get; set; }
        public int OnRoute {  get; set; }
        public int ParcellsDeliverd { get; set; }
        public int OneDay {  get; set; }
        public int OneDayToOneAndHalf { get; set; }
        public int AfterOneAndHalf { get; set; }

    }
}
