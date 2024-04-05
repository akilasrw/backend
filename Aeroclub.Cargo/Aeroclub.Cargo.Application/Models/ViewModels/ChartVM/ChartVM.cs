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
        public int Deliverd { get; set; }

        public int OneDay { get; set; }
        public double OneAndHalf { get; set; }

        public double AfterOneAndHalf { get; set; }


    }
}
