using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VideoConferenceBooking
{

    public class VideoConferenceBookingForm
    {
        public int? VideoConferenceBookingId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public int? AudioVisualServiceRequestId { get; set; }
        public string? VideoConferenceBookingCode { get; set; }
        public DateTime? VideoConferenceBookingDate { get; set; }
        public int? VideoConferenceBookerId { get; set; }
        public string? VideoConferenceBookerName { get; set; }
        public string? VideoConferenceBookerEmail { get; set; }
        public string? VideoConferenceBookerPhone { get; set; }
        public DateTime? VideoConferenceUseDateFrom { get; set; }
        public DateTime? VideoConferenceUseDateTo { get; set; }
        public DateTime? VideoConferenceUseDateFromTime { get; set; }
        public DateTime? VideoConferenceUseDateToTime { get; set; }
        public string? VideoConferenceTopic { get; set; }
        public int? VideoConferenceConferenceId { get; set; }
        public int? VideoConferenceLicenseId { get; set; }
        public int? VideoConferenceBookingTypeId { get; set; }
        public bool? VideoConferenceIsHost { get; set; }
        public bool? VideoConferenceIsLicense { get; set; }
        public int? VideoConferenceParticipants { get; set; }
        public int? VideoConferenceBookingPriorityId { get; set; }
        public string? VideoConferenceRemark { get; set; }
        public int? VideoConferenceDivisionId { get; set; }
        public bool? VideoConferenceIsFinish { get; set; }
        public int? VideoConferenceLastStatusId { get; set; }
        public string? VideoConferenceLastStatusName { get; set; }
        public string? VideoConferenceSubmitForm { get; set; }
        public string? VideoConferenceSubmitType { get; set; }
        public string? VideoConferenceActionType { get; set; }
        public bool? IsRequestByAudioVisualService { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
    }


    public class VideoConferenceBookingFormEvent
    {
        public int? VideoConferenceBookingId { get; set; }
        public int? AudioVisualServiceRequestId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }


}
