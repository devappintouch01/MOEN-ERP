using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class VehicleManagementBooking
    {
        //public int? VehicelBookingId { get; set; }
        public bool? LastStatus12 { get; set; }
        public string? ActionType { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
        public VVehicleBooking? VehicleBooking { get; set; }
        public List<VVehicleBookingAssign>? VehicleBookingAssignList { get; set; }
    }

}
