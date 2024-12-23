using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.ConferenceConsider
{
    public class SearchConsiderVideoConferenceBooking
    {
        public string? BookingCode { get; set; }
        public int? BookingPriorityId { get; set; }
        public string? BookerName { get; set; }
        public int? BookerOrgId { get; set; }
        public DateTime? BookingDateFrom { get; set; }
        public DateTime? BookingDateTo { get; set; }
        public DateTime? UseDateFrom { get; set; }
        public DateTime? UseDateTo { get; set; }
        public bool? IsFinish { get; set; }
        public int? SystemUserId { get; set; }
        public int? StatusId { get; set; }
        public int? SystemUserRoleId { get; set; }
        /// <summary>
        /// แสดงรายการที่พิจารณาแล้ว
        /// </summary>
        public bool? IsConsider { get; set; }
    }


    public class ConsiderVideoConferenceBooking
    {
        public List<VVideoConferenceBooking>? VideoConferenceBookingList { get; set; }
    }


}
