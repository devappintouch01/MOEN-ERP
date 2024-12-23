using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class MeetingRoomBooking
    {
    
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? BookingFormatId { get; set; }
        public string? BookingCode { get; set; }
        public int? BookerId { get; set; }
        public int? DivisionId { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? LastBookingDetailId { get; set; }
        public int? LastHistoryId { get; set; }
        public int? LastActorId { get; set; }
        public int? LastActionId { get; set; }
        public int? LastStatusId { get; set; }
        public int? LastWorkProcessId { get; set; }
        public bool? IsFinish { get; set; }
    }
}
