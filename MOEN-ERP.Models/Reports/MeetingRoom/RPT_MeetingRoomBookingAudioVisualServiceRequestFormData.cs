using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.MeetingRoom
{
    public class RPT_MeetingRoomBookingAudioVisualServiceRequestFormData
    {
        public int BookingId { get; set; }
        public int BookingDay { get; set; }
        public string BookingMonth { get; set; }
        public int BookingYear { get; set; }
        public string BookingDateTime { get; set; }
        public string BookerName { get; set; }
        public string BookerOrgName { get; set; }
        public string DivisionName { get; set;}
        public string BookerPhone { get; set; }
        public bool IsConferenceCamRequest { get; set; }
        public string SetupTime { get; set; }
        public bool IsMonitorRequest { get; set; }
        public bool IsSpeakerRequest { get; set; }
        public bool IsMicrophoneRequest { get; set; }
        public bool IsOtherWork {get; set; }
        public string WorkDetail { get; set; }
        public string UseDate { get; set; }
        public string UseDateTime { get; set; }
        public string Location { get; set; }    

    }


    public class SUB_MeetingRoomBookingAudioVisualServiceRequestListData
    {
        public int AudioVisualServiceId { get; set; }
        public string AudioVisualServiceName { get; set; }
        public bool AudioVisualServiceCheck { get; set; }

    }



}
