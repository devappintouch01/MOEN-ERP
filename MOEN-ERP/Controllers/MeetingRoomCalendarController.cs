using DevExpress.XtraRichEdit.Import.Html;
using MOEN_ERP.Components;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel.MeetingRoomCalendar;
using MOEN_ERP.Models.ViewModel.VehicleCalendar;
using MOEN_ERP.Services;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Controllers
{
    public class MeetingRoomCalendarController : Controller
    {
        private readonly IDropdowns _dropdowns;
        private readonly IDataService _dataService;
        private readonly IRawDataService _rawData;
        private readonly IMasterService _masterData;
        private readonly IAttachFileService _attachFile;

        private readonly ITokenService _tokenService;
        private readonly SettingsModel _settings;
        private readonly HttpClient _httpClient;

        private readonly ISystemService _systemService;


        public MeetingRoomCalendarController(IDropdowns dropdowns, IDataService dataService, IRawDataService rawData, IMasterService masterData, IAttachFileService attachFile,
            IOptions<SettingsModel> options, HttpClient httpClient, ITokenService tokenService
            , ISystemService systemService)
        {
            //Logz.AddLog("Start meeting room calendar class");
            _dropdowns = dropdowns;
            _dataService = dataService;
            _rawData = rawData;
            _masterData = masterData;
            _attachFile = attachFile;

            _tokenService = tokenService;
            _settings = options.Value;

            _httpClient = httpClient;
            string contentType = "application/json";
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var userAgent = "d-fens HttpClient";
            _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
            _systemService = systemService;
            //Logz.AddLog("Finish start meeting room calendar class");
        }
        public async Task<IActionResult> MeetingRoomDashboard()
        {
           
            #region Check SystemInfoName 
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            if (userCur?.SystemInfo?.SystemInfoName != "MeetingRoomBooking")
            {
                return RedirectToAction("SignIn", "Authen");
            }
            #endregion

            var model = new List<VMeetingRoom>();

           
            var meetingDetailList = new List<MeetingRoomCalendarSlideImage>();
            var dataMeetingRoom = await _rawData.GetViewMeetingRoomListAsync(new VMeetingRoom { Active = true });
            if(dataMeetingRoom.Count() > 0)
            {
                
                foreach (var itm in dataMeetingRoom.OrderBy(x => x.Floor).ToList())
                {
                    var att = await _attachFile.GetAttachFileImageByRef("MeetingRoom", (int)itm.RoomId);
                    meetingDetailList.Add(new MeetingRoomCalendarSlideImage { MeetingRoomId = itm.RoomId, MeetingRoomDetail = itm.RoomName, MeetingRoomColor = itm.Hexcode, RowGuid = att != null && att.Id != 0 ? att.RowGuid : null });
                }
            }

           
            ViewBag.MeetingRoomDetailList = meetingDetailList;

           
            return View(model);
        }

        #region MeetingRoom

        public async Task<IActionResult> GetEventsMeetingRoom()
        {
            var data = await _dataService.GetEventsMeetingRoom();

            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetEventsTimelineMeetingRoom(DateTime dateStart)
        {
            var data = await _dataService.GetEventsTimelineMeetingRoom(dateStart);

            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetEventsTimelineResourcesMeetingRoom(DateTime dateStart)
        {

            var data = await _dataService.GetEventsTimelineResourcesMeetingRoom(dateStart);
            return Json(data);
        }

        #endregion



        [HttpGet]
        public async Task<IActionResult> GetMeetingRoomDetail(int pMeetingRoomId)
        {
            var data = new MeetingRoomCalendarDetail
            {
                AttachFileList = new List<AttachFile>(),
                MeetingRoom = await _rawData.GetViewMeetingRoomAsync(pMeetingRoomId)
            };

            data.AttachFileList = await _attachFile.GetAttachFileNoDataListAsync(new AttachFile
            {
                ReferenceId = pMeetingRoomId,
                ReferenceTable = "MeetingRoom",
                ReferenceGroup = "MeetingRoom"
            });


            data.DeviceList = new List<MeetingRoomCalendarDevice>();
            var deviceList = await _rawData.GetViewMeetingRoomDeviceListAsync(new VMeetingRoomDevice { MeetingRoomId = pMeetingRoomId });

            var groupDevice = (from d in deviceList.Where(x => x.DeviceId != null)
                               group d by new
                               {
                                   d.DeviceId
                               }
                               into grpd
                               select new VMeetingRoomDevice
                               {
                                   DeviceName = grpd.FirstOrDefault()?.DeviceName,
                                   UsedPerRoom = grpd.FirstOrDefault()?.UsedPerRoom,
                                   DeviceStatusGroup = grpd.FirstOrDefault()?.DeviceStatusGroup,
                               }
                               );

            if (groupDevice.Count() > 0)
            {
                foreach (var itm in groupDevice)
                {
                    var newItm = new MeetingRoomCalendarDevice();
                    newItm.DeviceName = $"{itm.DeviceName} {itm.UsedPerRoom} ({itm.DeviceStatusGroup})";

                    data.DeviceList.Add(newItm);
                }
            }

            return PartialView("_MeetingRoomDetail", data);
        }


    }
}
