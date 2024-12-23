using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class VideoConferenceBooking
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public int? AudioVisualServiceRequestId { get; set; }
        public string? BookingCode { get; set; }
        public int? BookerId { get; set; }
        public int? DivisionId { get; set; }
        public DateTime? BookingDate { get; set; }
        public string? BookerEmail { get; set; }
        public string? BookerPhone { get; set; }
        public DateTime? UseDateFrom { get; set; }
        public DateTime? UseDateTo { get; set; }
        public int? BookingTypeId { get; set; }
        public string? Topic { get; set; }
        public int? ConferenceId { get; set; }
        public int? LicenseId { get; set; }
        public bool? IsHost { get; set; }
        public int? Participants { get; set; }
        public int? BookingPriorityId { get; set; }
        public string? Remark { get; set; }
        public int? LastHistoryId { get; set; }
        public int? LastActorId { get; set; }
        public int? LastActionId { get; set; }
        public int? LastStatusId { get; set; }
        public int? LastWorkProcessId { get; set; }
        public bool? IsFinish { get; set; }
    }
}
