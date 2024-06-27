using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs
{
    public class AgentOtherRatesRM
    {
        public Guid SubCategoryID { get; set; }
        public string RateName { get; set; }
        public string Description { get; set; }

        public string RateDescription { get; set; }

        public int MinPreceptionRate { get; set; }
        public int RatePerKG { get; set; }
        public int FixRate { get; set; }
        public int TrancheRate { get; set; }
        public string IATACode { get; set; }
    }
}
