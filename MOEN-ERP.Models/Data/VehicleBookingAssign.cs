using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class VehicleBookingAssign
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? VehicleBookingId { get; set; }
        public DateTime? TravelFromDate { get; set; }
        public DateTime? TravelToDate { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? VehicleId { get; set; }
        public int? DriverId { get; set; }
    }
}
