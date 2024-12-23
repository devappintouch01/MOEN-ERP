using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.RawData;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.AudioVisualServiceRequest
{
    //internal class AudioVisualServiceRequest
    //{
    //}
    public class SearchAudioVisualServiceRequest
    {
        public string? SearchBookingCode { get; set; }
        public string? SearchLocation { get; set; }
        public int? SearchLastStatusId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchUseDateFrom { get; set; }
        public DateTime? SearchUseDateTo { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }

    }


    public class AudioVisualServiceRequestDetailForm
    {
        public int? AudioVisualServiceRequestId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public string? BookingCode { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? BookerId { get; set; }
        public string? BookerName { get; set; }
        public int? BookerOrgId { get; set; }
        public string? BookerOrgName { get; set; }
        public int? DivisionId { get; set; }
        public string? BookerPhone { get; set; }
        public DateTime? UseDateFrom { get; set; }
        public DateTime? UseDateTo { get; set; }
        public DateTime? UseDateFromTime { get; set; }
        public DateTime? UseDateToTime { get; set; }
        public int? MeetingRoomId { get; set; }
        public string? Location { get; set; }
        public bool? IsMonitorRequest { get; set; }
        public bool? IsSpeakerRequest { get; set; }
        public bool? IsMicrophoneRequest { get; set; }
        public bool? IsConferenceCamRequest { get; set; }
        /// <summary>
        /// งานอื่นๆ
        /// </summary>
        public bool? IsOtherWork { get; set; }
        public string? WorkDetail { get; set; }
        public DateTime? SetupTime { get; set; }
        public string? ActionRemark { get; set; }
        public List<int>? AudioVisualServiceRequestList { get; set; }
        public int? AudioVisualServiceRequestLastStatusId { get; set; }
        public string? LastWorkProcessActorType { get; set; }
        public int? NextActorUserId { get; set; }
        public int? LastWorkProcessRoleId { get; set; }
        public int? VideoConferenceBookingId { get; set; }
        public string[]? FileGuidId { get; set; }
        public string? SubmitType { get; set; }

        public int? VideoConferenceBoookingId { get; set; }
        public int? VideoConferenceBoookingLastStatusId { get; set; }

        public string? RequestEditActionRemark { get; set; }

        public int? DirectorApproveId1 { get; set; }
        public int? DirectorApproveId2 { get; set; }

        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
    }



    public class EventPreviewAudioVisualServicePreviewForm
    {
        //public VAudioVisualServiceRequest? AudioVisualServiceRequestBooking { get; set; }
        public int? AudioVisualServiceRequestId { get; set; }
        public string? SubmitType { get; set; }

    }

    public class EventPreviewAudioVisualServiceRequestBookingParameter
    {
        public int? AudioVisualServiceRequestId { get; set; }
        public string? ActionType { get; set; }
    }


    public class EventPreviewAudioVisualServiceRequestBooking
    {
        public VAudioVisualServiceRequest? AudioVisualServiceRequestBooking { get; set; }
        public List<VAudioVisualServiceRequestHistory>? AudioVisualServiceRequestHistory { get; set; }
        public EventsModel? EventsModel { get; set; }

    }


    public class AudioVisualServiceRequestBookingFormEvent
    {
        public int? AudioVisualServiceRequestId { get; set; }
        public int? AudioVisualServiceRequestStatusId { get; set; }
        //public string? ActionSubmitFormType { get; set; }
        public string? ActionType { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }


    public class RequestVideoConferenceBoookingForAudioVisualService
    {
        public int? AudioVisualServiceRequestId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        //public bool? IsRequestByAudioVisualService { get; set; }
    }


}
