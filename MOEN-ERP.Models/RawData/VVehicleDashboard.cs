using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVehicleDashboard
    {
        public int VehicleBookingAssignId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? VehicleBookingId { get; set; }

        public DateTime? BookingDate { get; set; }

        public string? BookingCode { get; set; }

        public bool? IsFinish { get; set; }

        public int? LastStatusId { get; set; }

        public int? SystemUserId { get; set; }

        public int? BookerId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerPosId { get; set; }

        public string? BookerPosName { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }

        public string? BookerPhone { get; set; }

        public int? DivisionName { get; set; }

        public string OrgDivisionShortName { get; set; } = null!;

        public int? BookingFormatId { get; set; }

        public string? BookingFormatName { get; set; }

        public int? Vehicles { get; set; }

        public int? Passengers { get; set; }

        public DateTime? BookingTravelFromDate { get; set; }

        public DateTime? BookingTravelToDate { get; set; }

        public string? TravelDetail { get; set; }

        public string? BookingPurpose { get; set; }

        public string? TravelFromLocation { get; set; }

        public string? TravelToLocation { get; set; }

        public DateTime? TravelFromDate { get; set; }

        public DateTime? TravelToDate { get; set; }

        public int? VehicleTypeId { get; set; }

        public string? VehicleTypeName { get; set; }

        public int? VehicleId { get; set; }

        public string? VehicleRegistration { get; set; }

        public string? VtypeName { get; set; }

        public int? VbrandId { get; set; }

        public string? VbrandName { get; set; }

        public int? VmodelId { get; set; }

        public string? VmodelName { get; set; }

        public string? Hexcode { get; set; }

        public int? DriverId { get; set; }

        public string? DriverName { get; set; }

        public string? DriverPhone { get; set; }
    }
}
