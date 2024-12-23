using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class VehicleManagementBookingAssign
    {
        public VehicleBookingAssign? BookingAssign {get;set;}
        //public List<VVehicleBookingAssign>? VehicleBookingAssignList { get; set; }
        public EventsModel? EventModel { get; set; }
    }
}
