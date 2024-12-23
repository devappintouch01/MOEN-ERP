using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVideoConferenceBooking
    {
        public int? VideoConferenceBookingId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? MeetingRoomBookingId { get; set; }

        public string? MeetingRoomBookingCode { get; set; }

        public DateTime? MeetingRoomBookingDate { get; set; }

        public int? AudioVisualServiceRequestId { get; set; }

        public string? AudioVisualServiceRequestCode { get; set; }

        public DateTime? AudioVisualServiceRequestDate { get; set; }

        public int? BookingFormatId { get; set; }

        public string? BookingFormatName { get; set; }

        public int? FirstWorkProcessId { get; set; }

        public string? FirstWorkProcessName { get; set; }

        public string? BookingCode { get; set; }

        public int? BookerUserId { get; set; }

        public int? BookerId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerPosId { get; set; }

        public string? BookerPosName { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }

        public int? DivisionId { get; set; }

        public string? DivisionName { get; set; }

        public DateTime? BookingDate { get; set; }

        public string? BookerEmail { get; set; }

        public string? BookerPhone { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public int? BookingTypeId { get; set; }

        public string? BookingTypeName { get; set; }

        public string? Topic { get; set; }

        public int? ConferenceId { get; set; }

        public string? ConferenceName { get; set; }

        public int? LicenseId { get; set; }

        public string? LicenseName { get; set; }

        public bool? IsHost { get; set; }

        public int? Participants { get; set; }

        public int? BookingPriorityId { get; set; }

        public string? BookingPriorityName { get; set; }

        public string? Remark { get; set; }

        public string? ConferenceLink { get; set; }

        public string? ConferenceDetail { get; set; }

        public int? LastHistoryId { get; set; }

        public int? LastWorkProcessId { get; set; }

        public string? LastWorkProcessName { get; set; }

        public int? LastWorkProcessRoleId { get; set; }

        public string? LastWorkProcessActorType { get; set; }

        public int? LastActorId { get; set; }

        public int? LastActorUserId { get; set; }

        public string? LastActorName { get; set; }

        public int? NextActorId { get; set; }

        public int? NextActorUserId { get; set; }

        public string? NextActorName { get; set; }

        public int? LastActionId { get; set; }

        public string? LastActionName { get; set; }

        public string? ActionRemark { get; set; }

        public int? LastStatusId { get; set; }

        public string? LastStatusName { get; set; }

        public bool? IsFinish { get; set; }
    }
}
