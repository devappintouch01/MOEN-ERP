using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class MeetingRoomBookingParticipant
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public int? MeetingRoomBookingDetailId { get; set; }
        public int? OfficerId { get; set; }
        public int? PositionId { get; set; }
        public string? ParticipantName { get; set; }
        public string? ParticipantOrgName { get; set; }
        public string? ParticipantEmail { get; set; }
    }
}
