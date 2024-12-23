using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVehicleBookingRecord
    {
        public int? VehicleBookingRecordId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int VehicleBookingId { get; set; }

        public string? VehicleBookingCode { get; set; }

        public DateTime? TravelFromDate { get; set; }

        public DateTime? TravelToDate { get; set; }

        public int? VehicleBookingAssignId { get; set; }

        public int? VehicleId { get; set; }

        public string? VehicleRegistration { get; set; }

        public string? VtypeAndRegistration { get; set; }

        public int? DriverId { get; set; }

        public string? DriverName { get; set; }

        public decimal? StartCarMileage { get; set; }

        public decimal? FinishCarMileage { get; set; }

        public decimal? TravelDistance { get; set; }

        public int? CarInspectionStatus { get; set; }

        public string? Remark { get; set; }
        public string? IsEditable { get; set; }
    }
}
