using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VCateringServiceRequestParticipant
    {
        public int? Id { get; set; }

        public int? CateringServiceRequestId { get; set; }

        public int? CateringServiceParticipantTypeId { get; set; }

        public string? ParticipantTypeName { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
    }
}
