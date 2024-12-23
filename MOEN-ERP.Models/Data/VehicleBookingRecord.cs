using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class VehicleBookingRecord
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? VehicleBookingId { get; set; }
        public int? VehicleId { get; set; }
        public decimal? StartCarMileage { get; set; }
        public decimal? FinishCarMileage { get; set; }
        public decimal? TravelDistance { get; set; }
        public int? CarInspectionStatus { get; set; }
        public string? Remark { get; set; }
    }
}
