using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMeetingRoomBookingParticipant
    {
        public int? Id { get; set; }

        public int? MeetingRoomBookingId { get; set; }

        public int? MeetingRoomBookingDetailId { get; set; }

        public int? OfficerId { get; set; }

        public string? OfficerName { get; set; }

        public int? OfficerOrgId { get; set; }

        public string? OfficerOrgName { get; set; }

        public string? OfficerEmail { get; set; }

        public int? PositionId { get; set; }

        public string? PositionName { get; set; }

        public string? ParticipantName { get; set; }

        public string? ParticipantOrgName { get; set; }

        public string? ParticipantEmail { get; set; }
    }
}
