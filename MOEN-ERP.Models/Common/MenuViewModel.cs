using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Common
{
    public class MenuViewModel
    {
        public int? MenuId { get; set; }
        public string? MenuName { get; set; }
        public string? ControllerMainName { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? Icon { get; set; }
        public bool? IsParent { get; set; }
        public int? ParentId { get; set; }
       // public int? Seq { get; set; }
    }
}
