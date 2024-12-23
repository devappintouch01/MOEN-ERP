using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMasterReportDetail
    {
        public int? ReportId { get; set; }

        public string? ReportName { get; set; }

        public int? SystemId { get; set; }

        public int? ReportDetailId { get; set; }

        public string? ReportDetail { get; set; }

        public int? Sequence { get; set; }
    }
}
