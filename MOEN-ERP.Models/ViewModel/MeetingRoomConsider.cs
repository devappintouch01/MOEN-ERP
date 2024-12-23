using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.MeetingRoomConsider
{
    
    public class SearchMeetingRoomConsider
    {
        public string? BookingCode { get; set; }
        public int? MeetingRoomId { get; set; }
        public string? BookerName { get; set; }
        public int? BookerOrgId { get; set; }
        public DateTime? BookingDateFrom { get; set; }
        public DateTime? BookingDateTo { get; set; }
        public DateTime? UseDateFrom { get; set; }
        public DateTime? UseDateTo { get; set; }
        public bool? IsFinish { get; set; }
        public int? SystemUserId { get; set; }
        public int? SystemUserRoleId { get; set; }
        /// <summary>
        /// แสดงรายการที่พิจารณาแล้ว
        /// </summary>
        public bool? IsConsider { get; set; }
    }

    public class MeetingRoomConsiderBooking
    {      
        public List<VMeetingRoomBooking>? MeetingRoomBookingList { get; set; }
    }

   


}
