using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.ChartVM
{

    public class BarData
    {
        public DateTime date { get; set; }
        public int count { get; set; }

    }
    public class ChartVM
    {
        public double Collected { get; set; }
        public int Returned { get; set; }

        public int OnHold { get; set; }
        public double SuccessRate { get; set; }

        public List<BarData> BarData { get; set; }


    }
}
