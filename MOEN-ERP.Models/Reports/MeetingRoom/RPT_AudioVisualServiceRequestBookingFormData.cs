using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.MeetingRoom
{
    public class RPT_AudioVisualServiceRequestBookingFormData
    {    
        public string BookingDate { get; set; }
        public string BookingTime { get; set; }
        public string Detail_1 { get; set; }
        public string Detail_2 { get; set; }

        public bool IsConferenceCamRequest { get; set; }
        public string SetupTime { get; set; }
        public bool IsMonitorRequest { get; set; }
        public bool IsSpeakerRequest { get; set; }
        public bool IsMicrophoneRequest { get; set; }
        public bool IsOtherWork { get; set; }
        public string BookerName { get; set; }

        public string Director1ActorName { get; set; }
        public string Director2ActorName { get; set; }
    }

    public class SUB_AudioVisualServiceRequestListData
    {
        public int AudioVisualServiceId { get; set; }
        public string AudioVisualServiceName { get; set; }
        public bool AudioVisualServiceCheck { get; set; }

    }

}
