using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.ConferenceBooking
{
    public class SearchVideoConferenceBooking
    {
        public string? SearchBookingCode { get; set; }
        public int? SearchConferenceId { get; set; }
        public int? SearchBookingTypeId { get; set; }
        public int? SearchLastStatusId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchUseDateFrom { get; set; }
        public DateTime? SearchUseDateTo { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }

    }


    public class VideoConferenceBookingDetail
    { 
        public int? VideoConferenceBookingId { get; set; }
        /// <summary>
        /// เลขที่การจอง
        /// </summary>
        public string? BookingCode { get; set; }
        /// <summary>
        /// วันที่จอง
        /// </summary>
        public DateTime? BookingDate { get; set; }
        public int? BookerId { get; set; }
        /// <summary>
        /// ชื่อ – นามสกุล
        /// </summary>      
        public string? BookerName { get; set; }
        /// <summary>
        /// รหัสสำนัก
        /// </summary>
        public int? BookerOrgId { get; set; }
        /// <summary>
        /// ชื่อสำนัก
        /// </summary>
        public string? BookerOrgName { get; set; }
        /// <summary>
        /// ส่วน
        /// </summary>
        public int? DivisionId { get; set; }
        /// <summary>
        /// เบอรโทรศัพท์
        /// </summary>
        public string? BookerPhone { get; set; }
        /// <summary>
        /// อีเมล
        /// </summary>
        public string? BookerEmail { get; set; }
        /// <summary>
        /// วันที่ใช้ห้องประชุม
        /// </summary>
        public DateTime? UseDateFrom { get; set; }

        /// <summary>
        /// ถึง วันที่ใช้ห้องประชุม
        /// </summary>
        public DateTime? UseDateTo { get; set; }
        public DateTime? UseDateFromTime { get; set; }
        public DateTime? UseDateToTime { get; set; }
        /// <summary>
        /// เรื่อง/คณะที่ประชุม
        /// </summary>
        public string? Topic { get; set; }
        /// <summary>
        /// Application
        /// </summary>
        public int? ConferenceId { get; set; }
        /// <summary>
        /// License
        /// </summary>
        public int? LicenseId { get; set; }
        /// <summary>
        /// ประเภทการจอง
        /// </summary>
        public int? BookingTypeId { get; set; }
        public int? Participants { get; set; }
        public int? BookingPriorityId { get; set; }
        public bool? IsHost { get; set; }
        public bool? IsLicense { get; set; }
        
        public string? Remark { get; set; }
        public bool? IsFinish { get; set; }
        public int? LastStatusId { get; set; }
        public string? ActionType { get; set; }
        public string? SubmitType { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }

    //public class VideoConferenceBookingFormEvent
    //{
    //    public int? VideoConferenceBookingId { get; set; }
    //    public string? ActionType { get; set; }
    //    public string? ActionRemark { get; set; }
    //    public int? CurrentSystemUserId { get; set; }
    //    public int? CurrentOfficerId { get; set; }

    //}

    public class ConferenceMeetingRoomDetails
    {
        public int? VideoConferenceBookingId { get; set; }
        public string? ConferenceLink { get; set; }
        public string? ConferenceDetail { get; set; }
        public bool? IsHost { get; set; }
        public string? ActionType { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }
}
