using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMasterFuelCode
    {
        public int? FuelCardId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public bool? Active { get; set; }

        public string? Code { get; set; }

        public int? VehicleId { get; set; }

        public string? VehicleRegistration { get; set; }

        public double? FuelQuantityQuota { get; set; }
    }
}
