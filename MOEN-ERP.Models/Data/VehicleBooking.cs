using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class VehicleBooking
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string? BookingCode { get; set; }
        public int? BookerId { get; set; }
        public int? DivisionId { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? VehicleId { get; set; }
        public int? DriverId { get; set; }
        public int? BookingFormatId { get; set; }
        public DateTime? TravelFromDate { get; set; }
        public DateTime? TravelToDate { get; set; }
        public int? Passengers { get; set; }
        public string? TravelFromLocation { get; set; }
        public string? TravelToLocation { get; set; }
        public string? BookingPurpose { get; set; }
        public string? BookerPhone { get; set; }
        public int? BookingTypeId { get; set; }
        public bool? IsSpecialCase { get; set; }
        public string? SpecialCaseRemark { get; set; }
        public string? Remark { get; set; }
        public int? DirectorApproveId { get; set; }
        public int? LastHistoryId { get; set; }
        public int? LastActorId { get; set; }
        public int? LastWorkProcessId { get; set; }
        public int? LastActionId { get; set; }
        public int? LastStatusId { get; set; }
        public bool? IsFinish { get; set; }
    }
}
