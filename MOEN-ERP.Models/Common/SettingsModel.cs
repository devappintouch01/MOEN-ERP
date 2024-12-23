using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Common
{
    public class SettingsModel
    {
        public string? BaseUrl { get; set; }
        public string? BaseUrlApi { get; set; }
        public string? BaseUrlERP { get; set; }
        public string? IntranetUrl { get; set; }
    }
}
