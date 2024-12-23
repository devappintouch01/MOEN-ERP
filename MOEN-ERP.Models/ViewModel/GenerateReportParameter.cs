using MOEN_ERP.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class GenerateReportParameter
    {
        public string? ReportName { get; set; }
        public int? ReportId { get; set; }
        public string? ReportType { get; set; }
        public bool? MergeAttachments { get; set; }
    }

    public class VehicleReportParameter
    {
        public string? ReportName { get; set; }
        public int? ReportId { get; set; }
        public int? VehicleBookingAssignId { get; set; }
        public string? ReportType { get; set; }
        public bool? MergeAttachments { get; set; }
    }


    //public class GenerateReportType
    //{
    //    public int? ReportTypeId { get; set; }
    //    public string? ReportTypeName { get; set; }
    //    public static GenerateReportType pdf { get { return new GenerateReportType { ReportTypeId = 1, ReportTypeName = "pdf" };  } }
    //    public static GenerateReportType excel { get { return new GenerateReportType { ReportTypeId = 2, ReportTypeName = "excel" }; } }
    //}

}
