using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.MeetingManagement
{

    #region AudioVisualDevice
    public class AudioVisualDeviceListViewModel
    {
        public List<VAudioVisualDevice>? AudioVisualDeviceList { get; set; }
    }
    public class AudioVisualDeviceViewModel
    {
        public VAudioVisualDevice? AudioVisualDevice { get; set; }
        public EventsModel EventsModel { get; set; }

    }
    #endregion


    #region ManageMeetingRoomDetail
    public class ManageMeetingRoomDetailViewModel
    {
        public VMeetingRoom? VMeetingRoom { get; set; }
        public string[]? FileGuidId { get; set; }
        public ManageMeetingRoomFormatListViewModel RoomFormatList { get; set; }
        public List<int>? RoomFormatSelectList { get; set; }
    }

    public class ManageMeetingRoomFormatListViewModel
    {
        public List<MasterMeetingRoomFormat>? MasterMeetingRoomFormat { get; set; }
        public List<AttachFile>? AttachFileList { get; set; }
        public PaginationModel? PaginationResultModel { get; set; }
        public List<MeetingRoomFormat>? MeetingRoomFormat { get; set; }
        public int? MeetingRoomId { get; set; }
    }
    #endregion

    #region ManageMeetingRoomList
    public class ManageMeetingRoomListViewModel
    {
        public List<VMeetingRoom>? VMeetingRoomList { get; set; }
        public EventsModel? EventsModel { get; set; }
    }
    #endregion

    #region ManageRestaurantList
    public class ManageRestaurantViewModel
    {
        public VRestaurant? VRestaurant { get; set; }
        // public List<int?> CateringRestaurantFoodList { get; set; }

        public List<int>? CateringRestaurantFoodList { get; set; }
        //public int[]? CateringRestaurantFoodList { get; set; }
        public string[]? FileGuidId { get; set; }
        public EventsModel? EventsModel { get; set; }
    }
    public class ManageRestaurantListViewModel
    {
        public List<VRestaurant>? VRestaurantList { get; set; }
        public List<AttachFile>? AttachFileList { get; set; }
    }
    #endregion

    #region
    public class ManageAudioVisualServiceViewModel
    {
        public VAudioVisualService? VAudioVisualService { get; set; }
        public List<int>? FormTypeList { get; set; }
        //public int FormType1 { get; set; }
        //public int FormType2 { get; set; }
        public EventsModel? EventsModel { get; set; }
    }
    public class ManageAudioVisualServiceListViewModel
    {
        public List<VAudioVisualService>? VAudioVisualServiceList { get; set; }
    }
    #endregion

    #region ManageMeetingRoomDeviceList
    public class ManageMeetingRoomDeviceListViewModel
    {
        public List<VMeetingRoom>? VMeetingRoomList { get; set; }
    }

    public class ManageMeetingRoomDeviceViewModel
    {
        public VMeetingRoom? VMeetingRoom { get; set; }

    }
    #endregion

    #region
    public class ManageMeetingRoomDeviceDetaillViewModel
    {
        public VMeetingRoomDevice? VMeetingRoomDevice { get; set; }
        public List<VMeetingRoomDevice>? VMeetingRoomDeviceList { get; set; }
        public EventsModel? EventsModel { get; set; }
        public List<int>? MeetingRoomDeviceIdList { get; set; }
        public List<int>? MeetingRoomStatusIdList { get; set; }
        public List<string>? MeetingRoomDetailList { get; set; }
    }
    public class ManageMeetingRoomDeviceDetaillListViewModel
    {
        public List<VMeetingRoomDevice>? VMeetingRoomDeviceList { get; set; }
        //public EventsModel? EventsModel { get; set; }
    }
    #endregion


    #region ManageDisplayScreenList
    public class ManageDisplayScreenListViewModel
    {
        public List<VMeetingRoom>? VMeetingRoomList { get; set; }
    }
    #endregion

    #region ManageDisplayScreenDetail
    public class ManageDisplayScreenDetailViewModel
    {
        public VMeetingRoom? VMeetingRoom { get; set; }
        public string[]? FileGuidId { get; set; }
    }
    #endregion

}
