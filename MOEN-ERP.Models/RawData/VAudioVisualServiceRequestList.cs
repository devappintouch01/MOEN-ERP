using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VAudioVisualServiceRequestList
    {
        public int? Id { get; set; }

        public int? AudioVisualServiceRequestId { get; set; }

        public int? AudioVisualServiceId { get; set; }

        public string? Name { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
    }
}
