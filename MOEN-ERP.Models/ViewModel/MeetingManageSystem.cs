using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.MeetingManageSystem
{
    public class MeetingManageSystem
    {
    }

    #region MasterVideoConference
    public class MasterVideoConferenceViewModel
    {
        public MasterVideoConference? MasterVideoConference { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    public class MasterVideoConferenceListViewModel
    {
        public List<MasterVideoConference>? MasterVideoConferenceList { get; set; }

    }
    #endregion

    #region MasterFoodCategory
    public class MasterFoodCategoryViewModel
    {
        public MasterFoodCategory? MasterFoodCategory { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    public class MasterFoodCategoryListViewModel
    {
        public List<VMasterFoodCategory>? MasterFoodCategoryList { get; set; }

    }
    #endregion

    #region MasterVideoConferenceLicense
    public class MasterVideoConferenceLicenseViewModel
    {
        public MasterVideoConferenceLicense? MasterVideoConferenceLicense { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    public class ViewVideoConferenceLicenseListViewModel
    {
        public List<VVideoConferenceLicense>? ViewVideoConferenceLicenseList { get; set; }

    }
    #endregion

    #region ManageMeetingRoomFormat
    public class ManageMeetingRoomFormatSearchViewModel
    {
        public PaginationModel? PaginationModel { get; set; }      
    }
    public class ManageMeetingRoomFormatListViewModel
    {
        public List<MasterMeetingRoomFormat>? MeetingRoomFormatList { get; set; }
        public List<AttachFile>? AttachFileList { get; set; }
        public PaginationModel? PaginationResultModel { get; set; }
    }

    public class ManageMeetingRoomFormatViewModel
    {
        public MasterMeetingRoomFormat? MeetingRoomFormat { get; set; }
        public EventsModel EventsModel { get; set; }
        public string[]? FileGuidId { get; set; }
    }
    #endregion

}
