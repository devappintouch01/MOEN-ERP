using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.Vehicle
{
    public class RPT_VehicleQueueData
    {
        public int VehicleQueueId { get; set; }
        public string QueueDate { get; set; }
        public string VehicleRegistration { get; set; }
        public string DriverName { get; set;}
        public string GoTime { get; set;}
        public string TravelToLocation { get; set;}
        public string BackTime { get; set; }
        public string OrganizationName { get; set; }
        public string BookerName { get; set; }
    }

}
