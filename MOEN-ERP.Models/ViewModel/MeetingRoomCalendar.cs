using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.MeetingRoomCalendar
{
    //internal class MeetingRoomCalendar
    //{
    //}
    public class MeetingRoomCalendarSlideImage
    {
        public int? MeetingRoomId { get; set; }
        public string? MeetingRoomDetail { get; set; }
        public string? MeetingRoomColor { get; set; }
        public Guid? RowGuid { get; set; }
        //public string? ReferenceTable { get; set; }
    }

    public class MeetingRoomCalendarDetail
    {
        public VMeetingRoom? MeetingRoom { get; set; }
        public List<AttachFile>? AttachFileList { get; set; }
        public List<MeetingRoomCalendarDevice>? DeviceList { get; set; }
    }


    public class MeetingRoomCalendarDevice
    {
        public string? DeviceName { get; set; }
    }


}
