using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.MeetingRoom
{
    public class RPT_CateringServiceRequestBookingFormData
    {
        public string Detail_1 { get; set; }
        public string Detail_2 { get; set; }     
        public string BookerName { get; set; }        
        public string BookingDate { get; set; }
        public string BookingTime { get; set; }

        public bool IsSnackRequest { get; set; }
        public bool IsSnackMorning { get; set; }
        public bool IsSnackAfternoon { get; set; }
        public string SnackServeInsideTime { get; set; }
        public string SnackServeOutsideTime { get; set; }
        public string SnackRestaurantName { get; set; }

        public bool IsLunchRequest { get; set; }
        public bool IsLunchOneDish { get; set; }
        public bool IsLunchBuffet { get; set; }
        public string LunchServeTime { get; set; }
        public string LunchRestaurantName { get; set; }

        public bool IsDinnerRequest { get; set; }
        public bool IsDinnerOneDish { get; set; }
        public bool IsDinnerBuffet { get; set; }
        public string DinnerServeTime { get; set; }
        public string DinnerRestaurantName { get; set; }

        public string Director1ActorName { get; set; }
        public string Director2ActorName { get; set; }
    }


    public class SUB_CateringServiceRequestParticipantTypeListData
    {
        public int ParticipantTypeId { get; set; }
        public string ParticipantTypeName { get; set; }
        public bool ParticipantTypeCheck { get; set; }

    }

}
