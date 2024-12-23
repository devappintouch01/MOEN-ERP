using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.MeetingRoom
{
    public class RPT_MeetingRoomBookingFormData
    {
        public string BookingCode { get; set; }
        public string BookingDate { get; set; }
        public string BookerDetail { get; set; }
        public string Detail_1 { get; set; }
        public string Detail_2 { get; set; }
        //public string RoomFormatName { get; set; }

        public bool IsSnackMorning { get; set; }
        public bool IsSnackAfternoon { get; set; }
        public string SnackServeInsideTime { get; set; }
        public string SnackServeOutsideTime { get; set; }

        public bool IsLunchOneDish { get; set; }
        public bool IsLunchBuffet { get; set; }
        public string LunchServeTime { get; set; }

        public bool IsDinnerOneDish { get; set; }
        public bool IsDinnerBuffet { get; set; }
        public string DinnerServeTime { get; set; }

        public string BookerName { get; set; }
        public string BookerPosName { get; set; }
        public string ApproveName { get; set; }

    }
}
