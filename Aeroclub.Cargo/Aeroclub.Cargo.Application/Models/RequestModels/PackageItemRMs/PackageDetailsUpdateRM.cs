using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs
{
    public class PackageDetailsUpdateRM
    {
        public int width { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public int length { get; set; }
        public string refNo {  get; set; }
        
    }
}
