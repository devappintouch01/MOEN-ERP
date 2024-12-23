using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVehicleBrandModel
    {
        public int? BrandId { get; set; }

        public string? BrandName { get; set; }

        public bool? BrandActive { get; set; }    

        public int? BrandCreateName { get; set; }

        public DateTime? BrandCreateOn { get; set; }

        public int? BrandUpdateBy { get; set; }

        public DateTime? BrandUpdateOn { get; set; }

        public int? ModelId { get; set; }

        public string? ModelName { get; set; }

        public bool? ModelActive { get; set; }     

        public int? ModelCreateName { get; set; }

        public DateTime? ModelCreateOn { get; set; }

        public int? ModelUpdateBy { get; set; }

        public DateTime? ModelUpdateOn { get; set; }

    }
}
