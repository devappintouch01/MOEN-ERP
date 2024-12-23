using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VAudioVisualServiceRequestDetail
    {
        public int? AudioVisualServiceRequestDetailId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? AudioVisualServiceRequestId { get; set; }

        public string? BookerPhone { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public string? Location { get; set; }

        public bool? IsMonitorRequest { get; set; }

        public bool? IsSpeakerRequest { get; set; }

        public bool? IsMicrophoneRequest { get; set; }

        public bool? IsConferenceCamRequest { get; set; }

        public int? LastVideoConferenceBookingId { get; set; }

        public bool? IsOtherWork { get; set; }

        public string? WorkDetail { get; set; }

        public DateTime? SetupTime { get; set; }

        public string? EditRemark { get; set; }

        public DateTime? ApproveDate { get; set; }

        public bool? IsApprove { get; set; }

        public string? ApproveStatusName { get; set; }
        public int? DirectorApproveId1 { get; set; }

        public int? DirectorApproveId2 { get; set; }
    }
}
