using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleGatePassTicket
{

    public class EventPreviewVehicleGatePassTicketParameter
    {
        public int? VehicleBookingId { get; set; }

    }

    public class EventPreviewVehicleGatePassTicket
    {
        public VVehicleBooking? VehicleBooking { get; set; }

    }


}
