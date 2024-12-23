using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class RMeetingRoomBookingForm
    {
        public int? MeetingRoomBookingId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? LastBookingDetailId { get; set; }

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

        public int? MeetingRoomId { get; set; }

        public string? RoomName { get; set; }

        public string? Location { get; set; }

        public string? Floor { get; set; }

        public string? RoomNumber { get; set; }

        public string? Hexcode { get; set; }

        public DateTime? BookingDate { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public bool? IsDailyBooking { get; set; }

        public int? Participants { get; set; }

        public int? BookingTypeId { get; set; }

        public string? BookingTypeName { get; set; }

        public string? Topic { get; set; }

        public int? RealUserId { get; set; }

        public string? RealUserName { get; set; }

        public int? RealUserPosId { get; set; }

        public string? RealUserPosName { get; set; }

        public int? RealUserOrgId { get; set; }

        public string? RealUserOrgName { get; set; }

        public string? BookerPhone { get; set; }

        public string? Remark { get; set; }

        public string? ChairmanGroupName { get; set; }

        public string? ChairmanOutsiderName { get; set; }

        public bool? IsEnableFormatChange { get; set; }

        public bool? IsFormatChange { get; set; }

        public int? RoomFormatId { get; set; }

        public string? RoomFormatName { get; set; }

        public string? RoomFormatRemark { get; set; }

        public bool? IsAudioVisualServiceRequest { get; set; }

        public int? LastAudioVisualServiceRequestId { get; set; }

        public bool? IsCateringServiceRequest { get; set; }

        public int? LastCateringServiceRequestId { get; set; }

        public bool? IsSnackMorning { get; set; }

        public bool? IsSnackAfternoon { get; set; }

        public DateTime? SnackServeInsideTime { get; set; }

        public DateTime? SnackServeOutsideTime { get; set; }

        public bool? IsLunchOneDish { get; set; }

        public DateTime? LunchServeTime { get; set; }

        public bool? IsDinnerOneDish { get; set; }

        public DateTime? DinnerServeTime { get; set; }

        public string? ApproveName { get; set; }

        public int? LastHistoryId { get; set; }

        public int? LastWorkProcessId { get; set; }

        public string? LastWorkProcessName { get; set; }

        public int? LastActorId { get; set; }

        public string? LastActorName { get; set; }

        public int? LastActorPosId { get; set; }

        public string? LastActorPosName { get; set; }

        public int? LastActorOrgId { get; set; }

        public string? LastActorOrgName { get; set; }

        public int? LastActionId { get; set; }

        public string? LastActionName { get; set; }

        public int? LastStatusId { get; set; }

        public string? LastStatusName { get; set; }

        public bool? IsFinish { get; set; }
    }
}
