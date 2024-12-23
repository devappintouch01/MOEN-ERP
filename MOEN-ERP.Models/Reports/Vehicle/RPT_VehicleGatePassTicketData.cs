using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.Vehicle
{
    public class RPT_VehicleGatePassTicketData
    {
        /// <summary>
        /// ชื่อ-นามสกุลพนักงานขับรถ
        /// </summary>
        public string VehicleRegistration { get; set; }
        /// <summary>
        /// เลขทะเบียนยานพาหนะ
        /// </summary>
        public string DriverName { get; set; }
    }
}
