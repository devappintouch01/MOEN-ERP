using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Common
{
    public class SystemInfo
    {
        public int? SystemInfoId { get; set; }
        public string? SystemInfoName { get; set; }
        public static SystemInfo MasterManagementSystem { get { return new SystemInfo { SystemInfoId = 1, SystemInfoName = "MasterManagementSystem" }; } }
        public static SystemInfo BudgetingSystem { get { return new SystemInfo { SystemInfoId = 2, SystemInfoName = "BudgetingSystem" }; } }
        public static SystemInfo ProjectMonitoringSystem { get { return new SystemInfo { SystemInfoId = 3, SystemInfoName = "ProjectMonitoringSystem" }; } }
        public static SystemInfo InventoryManagementSystem { get { return new SystemInfo { SystemInfoId = 4, SystemInfoName = "InventoryManagementSystem" }; } }
        public static SystemInfo ExecutiveReportingSystem { get { return new SystemInfo { SystemInfoId = 5, SystemInfoName = "ExecutiveReportingSystem" }; } }

    }
}
