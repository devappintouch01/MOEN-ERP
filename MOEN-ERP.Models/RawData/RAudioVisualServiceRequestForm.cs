using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class RAudioVisualServiceRequestForm
    {
        public int? BookingId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? RoomBookingId { get; set; }

        public string? RoomBookingCode { get; set; }

        public DateTime? RoomBookingDate { get; set; }

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

        public string? BookerPhone { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }
        public int? MeetingRoomId { get; set; }

        public string? MeetingRoomName { get; set; }

        public string? Location { get; set; }

        public bool? IsMonitorRequest { get; set; }

        public bool? IsSpeakerRequest { get; set; }

        public bool? IsMicrophoneRequest { get; set; }

        public bool? IsConferenceCamRequest { get; set; }

        public bool? IsOtherWork { get; set; }

        public string? WorkDetail { get; set; }

        public DateTime? SetupTime { get; set; }

        public int? LastHistoryId { get; set; }

        public int? LastWorkProcessId { get; set; }

        public string? LastWorkProcessName { get; set; }

        public int? LastActorId { get; set; }

        public string? ActorName { get; set; }

        public string? Director1ActorName { get; set; }

        public DateTime? Director1CreateOn { get; set; }

        public string? Director2ActorName { get; set; }

        public DateTime? Director2CreateOn { get; set; }

        public int? ActorPosId { get; set; }

        public string? ActorPosName { get; set; }

        public int? ActorOrgId { get; set; }

        public string? ActorOrgName { get; set; }

        public int? LastActionId { get; set; }

        public string? ActionName { get; set; }

        public int? LastStatusId { get; set; }

        public string? StatusName { get; set; }

        public bool? IsFinish { get; set; }
    }
}
