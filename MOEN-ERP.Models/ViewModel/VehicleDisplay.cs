using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel.MeetingDisplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleDisplay
{

    public class VehicleDisplayScreenSearch
    { 
        public DateTime? CurrentDate { get; set; }
    }

    public class VehicleDisplayScreenDetail
    {
        /// <summary>
        /// การเดินทางวันนี้
        /// </summary>
        public bool? IsTravelDay { get; set; }   
        public List<VehicleDisplayScreenBookingDetail>? DetailList { get; set; }
       
    }
    public class VehicleDisplayScreenBookingDetail
    {  
        public string? VehicleRegistration { get; set; }
        public string? DriverName { get; set; }    
        public DateTime? TravelFromDate { get; set; }
        public string? TravelToLocation { get; set; }
        public DateTime? TravelToDate { get; set; }
        public string? OrgDivisionShortName { get; set; }
        public string? BookerPhone { get; set; }
    }


}
