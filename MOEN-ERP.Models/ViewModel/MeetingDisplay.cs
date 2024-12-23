using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.MeetingDisplay
{
    public class DisplayScreenPreviewViewModel
    {
        public VMeetingRoom? VMeetingRoom { get; set; }
        public AttachFile? AttachFile { get; set; }
    }

    public class MeetingDisplayScreenSearch
    {
        public int? MeetingRoomId { get; set; }
        public DateTime? CurrentDate { get; set; }
    }


    public class MeetingDisplayScreenDetail
    {
        /// <summary>
        /// การประชุมสำหรับวันนี้
        /// </summary>
        public bool? IsCurrentMeetingDay { get; set; }
        /// <summary>
        /// กำลังมีการประชุม
        /// </summary>
        public bool? IsCurrentMeeting { get; set; }
        public string? CurrentTime { get; set; }
        public string? CurrentTopic { get; set; }
        public string? CurrentOrganizationName { get; set;}
        public List<MeetingDisplayScreenDetailNext>? DetailNext { get; set; }
    }

    public class MeetingDisplayScreenDetailNext
    {
        public string? NextTime { get; set; }
        public string? NextTopic { get; set; }
        public string? NextOrganizationName { get; set; }
    }

}
