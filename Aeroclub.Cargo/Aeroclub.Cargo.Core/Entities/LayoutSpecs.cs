using Aeroclub.Cargo.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Core.Entities
{
    public class LayoutSpecs : AuditableEntity
    {
        public Guid LayoutSpectID { get; set; }
        
        public string CargoPositionID { get; set; }
        public int Default_max_weight { get; set; }

        public int Default_height { get; set; }

        public int Default_length { get; set;}

        public int Default_breadth { get; set;}

        public int Default_volume { get; set; }

        public int Fit_Max_Input_max_weight { get; set; }

        public int Fit_Max_Input_height { get; set; }

        public int Fit_Max_Input_length { get; set; }

        public int Fit_Max_Input_breadth { get; set; }

        public int Fit_Max_Input_volume { get; set; }

        public int Calculated_max_weight { get; set; }

        public int Calculated_height { get; set; }

        public int Calculated_length { get; set; }

        public int Calculated_breadth { get; set; }

        public int Calculated_volume { get; set; }

        public int Priority { get; set; }

        // Foreign Key
        public Guid AircraftSubTypeId { get; set; }

        // Navigation Property
        public virtual AircraftSubType AircraftSubType { get; set; }

    }
}
