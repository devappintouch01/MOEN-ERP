using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.Vehicle
{
    public class RPT_DriverReportsData
    {
        public string TravelDate { get; set; }
        public string TravelTime { get; set; }
        public string DriverName { get; set; }
        public string TravelToLocation { get; set; }
        public string VehicleType { get; set; }
        public int Passengers { get; set; }
        public string BookingFormat { get; set; }
        public string Abbreviation { get; set; }
    }
}
