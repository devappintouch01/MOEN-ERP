using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.MeetingRoomBookingAssetChange
{
    public class SearchMeetingRoomBookingAssetChange
    {
        public string? SearchAssetChangeFormCode { get; set; }
        public int? SearchAssetChangeType { get; set; }
        public string? SearchMeetingRoomBookingCode { get; set; }
        public int? SearchMeetingRoom { get; set; }
        public DateTime? SearchAssetChangeFormDateFrom { get; set; }
        public DateTime? SearchAssetChangeFormDateTo { get; set; }
        public DateTime? SearchMeetingRoomBookingDateFrom { get; set; }
        public DateTime? SearchMeetingRoomBookingDateTo { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }
    }
}
