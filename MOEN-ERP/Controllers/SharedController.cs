using AspNetCore;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
using DevExpress.PivotGrid.QueryMode;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraRichEdit.Model;
using MOEN_ERP.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel;
using MOEN_ERP.Models.ViewModel.AudioVisualServiceRequest;
using MOEN_ERP.Models.ViewModel.CateringServiceRequest;
using MOEN_ERP.Models.ViewModel.ConferenceBooking;
using MOEN_ERP.Models.ViewModel.ExpensesRequest;
using MOEN_ERP.Models.ViewModel.MeetingRoomBooking;
using MOEN_ERP.Models.ViewModel.VehicleBooking;
using MOEN_ERP.Models.ViewModel.VehicleGatePassTicket;
using MOEN_ERP.Models.ViewModel.VehicleQueueData;
using MOEN_ERP.Models.ViewModel.VehicleRecord;
using MOEN_ERP.Models.ViewModel.VideoConferenceBooking;
using MOEN_ERP.Services;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Ocsp;
using SkiaSharp;
using System.Net.Http.Headers;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Controllers
{
    [Authorize]
    public class SharedController : Controller
    {
        private readonly IMasterService _masterData;
        private readonly IRawDataService _rawData;
        private readonly IDataService _data;
        //private readonly ILogger _logger;
        private readonly IAttachFileService _attachFile;
        private readonly IDropdowns _dropdowns;
        private readonly IVehicleNotificationsService _vehicleNoti;
        private readonly IMeetingNotificationsService _meetingNoti;
        public SharedController(IMasterService masterData,
            IRawDataService rawData,
            IDataService data,
            IAttachFileService attachFile,
            IDropdowns dropdowns,
            IVehicleNotificationsService vehicleNoti,
             IMeetingNotificationsService meetingNoti
            )
        {
            //_logger = logger;
            _masterData = masterData;
            _rawData = rawData;
            _data = data;
            _attachFile = attachFile;
            _dropdowns = dropdowns;
            _vehicleNoti = vehicleNoti;
            _meetingNoti = meetingNoti;
        }

        #region Json Results
        [HttpGet]
        public async Task<IActionResult> GetVehicle(int pVehicleId)
        {
            var res = await _rawData.GetViewVehicleAsync(pVehicleId);
            return Json(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetOfficer(int pId)
        {
            var res = await _rawData.GetViewOfficerAsync(pId);
            return Json(res);
        }

        [HttpPost]
        public async Task<IActionResult> GetViewMeetingRoomDevice(VMeetingRoomDevice sch)
        {
            var res = await _rawData.GetViewMeetingRoomDeviceListAsync(sch);
            return Json(res);
        }

        [HttpPost]
        public async Task<IActionResult> GetViewMeetingRoomDeviceGroup(VMeetingRoomDevice sch)
        {
            var dataRoomDeviceList = await _rawData.GetViewMeetingRoomDeviceListAsync(sch);
            var res = (from t in dataRoomDeviceList
                       group t by new
                       {
                           t.MeetingRoomId,
                           t.DeviceId,
                       }
                                      into grp
                       select new VMeetingRoomDevice
                       {
                           MeetingRoomId = grp.Key.MeetingRoomId,
                           DeviceId = grp.Key.DeviceId,
                           DeviceName = grp?.FirstOrDefault()?.DeviceName,
                           Detail = grp?.FirstOrDefault()?.Detail,
                           UsedPerRoom = grp?.FirstOrDefault()?.UsedPerRoom,
                           TotalAll = grp?.FirstOrDefault()?.TotalAll,
                           TotalRemain = grp?.FirstOrDefault()?.TotalRemain,
                           TotalUsedAll = grp?.FirstOrDefault()?.TotalUsedAll,
                           StatusName = string.Join(", ", grp.Select(x => x.StatusName)),
                       }).FirstOrDefault();
            //--Return 1 Data
            if (res == null)
            {
                var deviceRoom = await _data.GetMeetingRoomDeviceListAsync(new MeetingRoomDevice { DeviceId = sch.DeviceId });
                if (deviceRoom.Count() > 0)
                {
                    res = new VMeetingRoomDevice()
                    {
                        MeetingRoomId = sch.MeetingRoomId,
                        DeviceId = sch.DeviceId,
                        
                        TotalUsedAll = deviceRoom.Count(),
                        UsedPerRoom = 0,
                        TotalAll = (await _data.GetAudioVisualDeviceAsync(sch.DeviceId ?? 0)).TotalAll ?? 0,
                    };
                    res.TotalRemain = res.TotalAll - res.TotalUsedAll;

                }

            }
            return Json(res);
        }

        [HttpPost]
        public async Task<IActionResult> GetAudioVisualDevice(AudioVisualDevice sch)
        {
            var res = await _data.GetAudioVisualDeviceAsync((int)sch?.Id);
            return Json(res);
        }
        #endregion

        public IActionResult VehicalModalEventPreviewBooking(MockupViewModel sch)
        {
            MockupViewModel data = new MockupViewModel();
            data.FormType = sch.FormType;
            data.ActionType = sch.ActionType;
            return PartialView("Partialviews/Vehicle/_ModalEventPreviewBooking", data);
        }

        public IActionResult VehicalModalEventPreviewBookingConfirm()
        {
            return PartialView("Partialviews/Vehicle/_ModalEventPreviewBookingConfirm");
        }

        public IActionResult VehicalModalEventPreviewBookingRefuse()
        {
            return PartialView("Partialviews/Vehicle/_ModalEventPreviewBookingRefuse");
        }


        #region Vehicle
        public async Task<IActionResult> RelateVehicleBrand()
        {
            MasterVehicleBrand sch = new MasterVehicleBrand()
            {
                Active = true,
            };
            return Json(await _masterData.GetMasterVehicleBrandList(sch));
        }

        public async Task<IActionResult> RelateVehicleModel(int vehicleBrandId)
        {
            var results = new List<SelectListItem>();
            MasterVehicleModel sch = new MasterVehicleModel();

            sch.Active = true;
            if (vehicleBrandId > 0) sch.VehicleBrandId = vehicleBrandId;

            return Json(await _masterData.GetMasterVehicleModelList(sch));
        }

        public async Task<IActionResult> RelateConferenceLicense(int conferenceId)
        {
            MasterVideoConferenceLicense sch = new MasterVideoConferenceLicense();
            sch.Active = true;
            if (conferenceId > 0) sch.ConferenceId = conferenceId;

            return Json(await _masterData.GetMasterVideoConferenceLicenseListAsync(sch));

        }



        //public async Task<IActionResult> RelateVehicleForAssign(int VehicleBookingId, int VehicleTypeId)
        //{
        //    var res = await _rawData.GetSPVehicleForAssignListAsync(VehicleBookingId);
        //    var data = JsonConvert.DeserializeObject<List<Vehicle>>((string)res.Data);
        //    if (VehicleTypeId > 0)
        //    {
        //        data = data.Where(x => x.VehicleTypeId == VehicleTypeId).ToList();
        //    }

        //    return Json(data);
        //}

        [HttpGet]
        public async Task<IActionResult> RelateDriverForAssign(string travelFromDateValue, string travelToDateValue)
        {
            DateTime fromDate = new DateTime(1, 1, 1);
            DateTime toDate = new DateTime(1, 1, 1);
            if (!string.IsNullOrEmpty(travelFromDateValue))
            {
                string[] fromDateArg = travelFromDateValue.Split('/');
                fromDate = new DateTime(Convert.ToInt32(fromDateArg[2]) - 543, Convert.ToInt32(fromDateArg[1]), Convert.ToInt32(fromDateArg[0]));
            }
            if (!string.IsNullOrEmpty(travelToDateValue))
            {
                string[] toDateArg = travelToDateValue.Split('/');
                toDate = new DateTime(Convert.ToInt32(toDateArg[2]) - 543, Convert.ToInt32(toDateArg[1]), Convert.ToInt32(toDateArg[0]));
            }

            SearchDriverListForAssign shc = new SearchDriverListForAssign
            {
                TravelFromDate = fromDate,
                TravelToDate = toDate,
            };

            var res = new List<VOfficer>();
            var resData = await _rawData.GetDriverListForAssignAsync(shc);
            if (resData.Type == ApiResultsType.success.ToString())
            {
                res = JsonConvert.DeserializeObject<List<VOfficer>>((string)resData.Data);
            }
            return Json(res);
        }




        [HttpGet]
        public async Task<IActionResult> RelateVehicleForAssign(string travelFromDateValue, string travelToDateValue, int vehicleTypeValue)
        {
            DateTime fromDate = new DateTime(1, 1, 1);
            DateTime toDate = new DateTime(1, 1, 1);
            if (!string.IsNullOrEmpty(travelFromDateValue))
            {
                string[] fromDateArg = travelFromDateValue.Split('/');
                fromDate = new DateTime(Convert.ToInt32(fromDateArg[2]) - 543, Convert.ToInt32(fromDateArg[1]), Convert.ToInt32(fromDateArg[0]));
            }
            if (!string.IsNullOrEmpty(travelToDateValue))
            {
                string[] toDateArg = travelToDateValue.Split('/');
                toDate = new DateTime(Convert.ToInt32(toDateArg[2]) - 543, Convert.ToInt32(toDateArg[1]), Convert.ToInt32(toDateArg[0]));
            }

            SearchVehicleListForAssign shc = new SearchVehicleListForAssign
            {
                TravelFromDate = fromDate,
                TravelToDate = toDate,
                VehicleType = vehicleTypeValue,
            };

            var res = new List<Vehicle>();
            var resData = await _rawData.GetVehicleListForAssignAsync(shc);
            if (resData.Type == ApiResultsType.success.ToString())
            {
                res = JsonConvert.DeserializeObject<List<Vehicle>>((string)resData.Data);
            }
            return Json(res);
        }



        [HttpGet]
        public async Task<IActionResult> RelateLicenseForVideoConferenceBooking(string useFromDateValue, string useToDateValue, string useFromDateTimeValue, string useToDateTimeValue, int conferenceIdValue)
        {
            DateTime fromDate = new DateTime(1, 1, 1);
            DateTime toDate = new DateTime(1, 1, 1);
            if (!string.IsNullOrEmpty(useFromDateValue))
            {
                string[] fromDateArg = useFromDateValue.Split('/');
                if (!string.IsNullOrEmpty(useFromDateTimeValue))
                {
                    string[] fromTimeArg = useFromDateTimeValue.Split(':');
                    fromDate = new DateTime(Convert.ToInt32(fromDateArg[2]) - 543, Convert.ToInt32(fromDateArg[1]), Convert.ToInt32(fromDateArg[0]), Convert.ToInt32(fromTimeArg[0]), Convert.ToInt32(fromTimeArg[1]), 00);
                }
                else
                {
                    fromDate = new DateTime(Convert.ToInt32(fromDateArg[2]) - 543, Convert.ToInt32(fromDateArg[1]), Convert.ToInt32(fromDateArg[0]));
                }

            }
            if (!string.IsNullOrEmpty(useToDateValue))
            {
                string[] toDateArg = useToDateValue.Split('/');
                if (!string.IsNullOrEmpty(useToDateTimeValue))
                {
                    string[] toTimeArg = useToDateTimeValue.Split(':');
                    toDate = new DateTime(Convert.ToInt32(toDateArg[2]) - 543, Convert.ToInt32(toDateArg[1]), Convert.ToInt32(toDateArg[0]), Convert.ToInt32(toTimeArg[0]), Convert.ToInt32(toTimeArg[1]), 00);
                }
                else
                {
                    toDate = new DateTime(Convert.ToInt32(toDateArg[2]) - 543, Convert.ToInt32(toDateArg[1]), Convert.ToInt32(toDateArg[0]));
                }
            }

            SearchLicenseForVideoConferenceBooking shc = new SearchLicenseForVideoConferenceBooking
            {
                UseDateFrom = fromDate,
                UseDateTo = toDate,
                ConferenceId = conferenceIdValue,
            };

            var res = new List<VVideoConferenceLicense>();
            var resData = await _rawData.GetLicenseForVideoConferenceBookingAsync(shc);
            if (resData.Type == ApiResultsType.success.ToString())
            {
                res = JsonConvert.DeserializeObject<List<VVideoConferenceLicense>>((string)resData.Data);
            }
            return Json(res);
        }



        [HttpGet]
        public async Task<IActionResult> ViewVehicleDetail(int pVehicleId)
        {
            var data = new MOEN_ERP.Models.ViewModel.VehicleDetail();
            data.VVehicle = await _rawData.GetViewVehicleAsync(pVehicleId);
            data.AttachFileList = await _attachFile.GetAttachFileNoDataListAsync(new AttachFile { ReferenceId = pVehicleId, ReferenceTable = "Vehicle", ReferenceGroup = "Vehicle" });
            return PartialView("Partialviews/Vehicle/_ModalViewVehicleDetail", data);
        }

        [HttpGet]
        public async Task<IActionResult> ViewVehicleDriverDetail(int pOfficerId)
        {
            var data = new MOEN_ERP.Models.ViewModel.VehicleDriverDetail();
            data.VOfficer = await _rawData.GetViewOfficerAsync(pOfficerId);
            var AttachData = await _attachFile.GetAttachFileNoDataListAsync(new AttachFile { ReferenceId = pOfficerId, ReferenceTable = "Officer", ReferenceGroup = "Officer" });
            data.AttachFile = AttachData.FirstOrDefault();
            return PartialView("Partialviews/Vehicle/_ModalViewVehicleDriverDetail", data);
        }

        [HttpGet]
        public async Task<IActionResult> PreviewVehicleQueue(DateTime pQueueDate)
        {
            var data = new VehicleQueueManagement();
            data.CurrentQueueDate = pQueueDate;

            return PartialView("Partialviews/Vehicle/_ModalEventPreviewVehicleQueue", data);
        }


        [HttpGet]
        public async Task<IActionResult> PreviewFile(PreviewFile data)
        {
            return PartialView("Partialviews/Vehicle/_ModalPreviewFile", data);
        }

        [HttpGet]
        public async Task<IActionResult> ViewVehicleQueue()
        {
            return PartialView("Partialviews/Vehicle/_ModalViewVehicleQueue");
        }


        [HttpGet]
        public async Task<IActionResult> EventPreviewVehicleGatePassTicket(EventPreviewVehicleGatePassTicketParameter sch)
        {



            var data = new EventPreviewVehicleGatePassTicket();

            try
            {

                data.VehicleBooking = await _rawData.GetViewVehicleBookingAsync(sch.VehicleBookingId ?? 0);

                return PartialView("Partialviews/Vehicle/_ModalPreviewVehicleGatePassTicket", data);

            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error", new { errorMassage = ex.Message });

            }

        }


        [HttpPost]
        public async Task<IActionResult> SearchVehicleQueue(SearchVehicleQueueView sch)
        {
            var data = new VehicleQueueDetailView();
            if (sch.SearchAction == "PreviousPage")
            {
                data.CurrentQueueDate = sch.SearchQueueDate.Value.AddDays(-1);
            }
            else if (sch.SearchAction == "NextPage")
            {
                data.CurrentQueueDate = sch.SearchQueueDate.Value.AddDays(+1);
            }
            else
            {
                data.CurrentQueueDate = sch.SearchQueueDate;
            }

            data.VehicleQueueList = await _rawData.GetViewVehicleQueueListAsync(new VVehicleQueue { QueueDate = data.CurrentQueueDate });
            return PartialView("Partialviews/Vehicle/_ViewVehicleQueueResults", data);
        }


        [HttpGet]
        public async Task<IActionResult> EventRecordVehicleBookingFormConsider(int pBookingId, string pActionType)
        {

            var data = new VehicleRecordBookingFormEvent();
            data.ActionType = pActionType;

            var res = await _rawData.GetViewVehicleBookingRecordByBookingAsync(pBookingId);
            if (res.Type == ApiResultsType.success.ToString())
            {
                var resData = JsonConvert.DeserializeObject<VVehicleBookingRecord>((string)res.Data);
                if (resData != null)
                {
                    data.VehicleBookingId = resData.VehicleBookingId;
                    data.VehicleBookingRecordId = resData.VehicleBookingRecordId;
                    data.TravelFromDate = resData.TravelFromDate;
                    data.TravelToDate = resData.TravelToDate;
                    data.BookingTravelFromDate = resData.TravelFromDate;
                    data.BookingTravelToDate = resData.TravelToDate;
                    data.TravelFromDateTime = resData.TravelFromDate;
                    data.TravelToDateTime = resData.TravelToDate;
                    data.StartCarMileage = resData.StartCarMileage;
                    data.FinishCarMileage = resData.FinishCarMileage;
                    data.TravelDistance = resData.TravelDistance;
                    data.CarInspectionStatus = resData.CarInspectionStatus;
                    data.Remark = resData.Remark;
                    data.VehicleId = resData.VehicleId;
                    data.VehicleBookingCode = resData.VehicleBookingCode;
                    data.VehicleRegistration = resData.VehicleRegistration;

                }
                return PartialView("Partialviews/Vehicle/_ModalEventRecordVehicleBooking", data);
            }
            else
            {
                return RedirectToAction("Index", "Error", new { errorMassage = res.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EventRecordVehicleBookingForm(int pVehicleBookingAssignId, string pActionType)
        {

            var data = new VehicleRecordBookingFormEvent();
            data.ActionType = pActionType;

            //var res = await _rawData.GetViewVehicleBookingRecordByBookingAsync(pBookingId);
            //if (res.Type == ApiResultsType.success.ToString())
            //{
            //    var resData = JsonConvert.DeserializeObject<VVehicleBookingRecord>((string)res.Data);
            //    if (resData != null)
            //    {
            //        data.VehicleBookingId = resData.VehicleBookingId;
            //        data.VehicleBookingRecordId = resData.VehicleBookingRecordId;
            //        data.TravelFromDate = resData.TravelFromDate;
            //        data.TravelToDate = resData.TravelToDate;
            //        data.TravelFromDateTime = resData.TravelFromDate;
            //        data.TravelToDateTime = resData.TravelToDate;
            //        data.StartCarMileage = resData.StartCarMileage;
            //        data.FinishCarMileage = resData.FinishCarMileage;
            //        data.TravelDistance = resData.TravelDistance;
            //        data.CarInspectionStatus = resData.CarInspectionStatus;
            //        data.Remark = resData.Remark;
            //        data.VehicleId = resData.VehicleId;

            //    }
            //    return PartialView("Partialviews/Vehicle/_ModalEventRecordVehicleBooking", data);
            //}
            //else
            //{
            // return RedirectToAction("Index", "Error", new { errorMassage = res.Message });
            // }

            var res = await _rawData.GetViewVehicleBookingAssignAsync(pVehicleBookingAssignId);
            if (res.Type == ApiResultsType.success.ToString())
            {

                var resData = JsonConvert.DeserializeObject<VVehicleBookingAssign>((string)res.Data);
                if (resData != null)
                {

                    data.VehicleBookingId = resData.VehicleBookingId;
                    data.VehicleBookingAssignId = resData.VehicleBookingAssignId;
                    data.VehicleBookingRecordId = resData.VehicleBookingRecordId;
                    data.TravelFromDate = resData.TravelFromDate;
                    data.TravelToDate = resData.TravelToDate;
                    data.TravelFromDateTime = resData.TravelFromDate;
                    data.TravelToDateTime = resData.TravelToDate;
                    data.StartCarMileage = resData.StartCarMileage;
                    data.FinishCarMileage = resData.FinishCarMileage;
                    data.TravelDistance = resData.TravelDistance;
                    data.CarInspectionStatus = resData.CarInspectionStatus;
                    data.Remark = resData.Remark;
                    data.VehicleId = resData.VehicleId;
                    data.BookingTravelFromDate = resData.BookingTravelFromDate;
                    data.BookingTravelToDate = resData.BookingTravelToDate;
                    data.VehicleBookingCode = resData.BookingCode;
                    data.VehicleRegistration = resData.VehicleRegistration;

                }

                return PartialView("Partialviews/Vehicle/_ModalEventRecordVehicleBooking", data);
            }
            else
            {
                return RedirectToAction("Index", "Error", new { errorMassage = res.Message });
            }

        }

        


        #region จัดการรถ
        [HttpGet]
        public async Task<IActionResult> EventVehicleManagementBooking(int pBookingId, string pActionType)
        {


            var data = new VehicleManagementBooking();
            //data.VehicelBookingId = pBookingId;
            data.ActionType = pActionType;
            data.VehicleBookingAssignList = new List<VVehicleBookingAssign>();
            data.VehicleBooking = await _rawData.GetViewVehicleBookingAsync(pBookingId);
            data.LastStatus12 = data?.VehicleBooking?.LastStatusId == 12 ? true : false;

            var AssignListRes = await _rawData.GetViewVehicleBookingAssignListAsync(new VVehicleBookingAssign { VehicleBookingId = pBookingId });
            if (AssignListRes.Type == ApiResultsType.success.ToString())
            {
                data.VehicleBookingAssignList = JsonConvert.DeserializeObject<List<VVehicleBookingAssign>>((string)AssignListRes.Data);
            }

            return PartialView("Partialviews/Vehicle/_ModalEventVehicleManagementBooking", data);
        }

        
        #endregion


        #region จัดการรถ


        [HttpPost]
        public async Task<IActionResult> EventVehicleManagementBookingAssign(int pAssignId, int pVehicleBookingId, string pActionType, DateTime? dateTo, DateTime? dateForm)
        {
            if (pActionType == "new")
            {

                ViewBag.DropdownVehicleTypeModal = await _dropdowns.DropdownVehicleType();
                ViewBag.DropdownVehicleTypeRegistrationModal = await _dropdowns.DropdownVehicleTypeRegistration();
                ViewBag.DropdownOfficerDriverModal = await _dropdowns.DropdownOfficer(148);



                var data = new VehicleManagementBookingAssign();

                data.BookingAssign = new VehicleBookingAssign();
                data.BookingAssign.VehicleBookingId = pVehicleBookingId;

                var evt = new EventsModel();
                evt.ActionType = pActionType;
                data.EventModel = evt;
                data.BookingAssign.TravelFromDate = dateForm;
                data.BookingAssign.TravelToDate = dateTo;

                return PartialView("Partialviews/Vehicle/_ModalEventVehicleManagementBookingAssign", data);

            }
            else if (pActionType == "edit")
            {

                ViewBag.DropdownVehicleTypeModal = await _dropdowns.DropdownVehicleType();
                ViewBag.DropdownVehicleTypeRegistrationModal = await _dropdowns.DropdownVehicleTypeRegistration();
                ViewBag.DropdownOfficerDriverModal = await _dropdowns.DropdownOfficer(148);


                var data = new VehicleManagementBookingAssign();

                data.BookingAssign = new VehicleBookingAssign();

                var assignRes = await _data.GetVehicleBookingAssignAsync(pAssignId);
                if (assignRes.Type == ApiResultsType.success.ToString())
                {
                    data.BookingAssign = JsonConvert.DeserializeObject<VehicleBookingAssign>((string)assignRes.Data);
                }

                var evt = new EventsModel();
                evt.ActionType = pActionType;
                data.EventModel = evt;

                return PartialView("Partialviews/Vehicle/_ModalEventVehicleManagementBookingAssign", data);

            }
            //else if (pActionType == "remove")
            //{




            //    var data = new VehicleManagementBooking();
            //    data.ActionType = pActionType;
            //    data.VehicleBookingAssignList = new List<VVehicleBookingAssign>();
            //    data.VehicleBooking = await _rawData.GetViewVehicleBookingAsync(pVehicleBookingId);
            //    data.LastStatus12 = data?.VehicleBooking?.LastStatusId == 12 ? true : false;

            //    var AssignListRes = await _rawData.GetViewVehicleBookingAssignListAsync(new VVehicleBookingAssign { VehicleBookingId = pVehicleBookingId });
            //    if (AssignListRes.Type == ApiResultsType.success.ToString())
            //    {
            //        data.VehicleBookingAssignList = JsonConvert.DeserializeObject<List<VVehicleBookingAssign>>((string)AssignListRes.Data);
            //    }





            //    return PartialView("Partialviews/Vehicle/_TableManageVehicleManagementBookingListResults", data);
            //}
            else
            {
                return null;
            }

        }


        [HttpPost]
        public async Task<IActionResult> EventDeleteVehicleManagementBookingAssign(int pAssignId)
        {
            var res = new ApiResultsModel();

            try
            {
                res = await _data.DeleteVehicleBookingAssignAsync(pAssignId);
            }
            catch (Exception ex)
            {
                res.Type = ApiResultsType.error.ToString();
                res.Message = ex.Message;
            }

            return Json(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetVehicleManagementBookingAssignList(int pVehicleBookingId)
        {

            var data = new VehicleManagementBooking();
            data.VehicleBookingAssignList = new List<VVehicleBookingAssign>();
            data.VehicleBooking = await _rawData.GetViewVehicleBookingAsync(pVehicleBookingId);
            data.LastStatus12 = data?.VehicleBooking?.LastStatusId == 12 ? true : false;

            var AssignListRes = await _rawData.GetViewVehicleBookingAssignListAsync(new VVehicleBookingAssign { VehicleBookingId = pVehicleBookingId });
            if (AssignListRes.Type == ApiResultsType.success.ToString())
            {
                data.VehicleBookingAssignList = JsonConvert.DeserializeObject<List<VVehicleBookingAssign>>((string)AssignListRes.Data);
            }

            return PartialView("Partialviews/Vehicle/_TableManageVehicleManagementBookingListResults", data);
        }

        [HttpPost]
        public async Task<IActionResult> EventManageVehicleManagementBookingAssign(VehicleManagementBookingAssign data)
        {
            var res = new ApiResultsModel();

            try
            {
                var userCur = new Appz(HttpContext)?.CurrentSignInUser;


                if (data.EventModel.ActionType == "new")
                {

                    data.BookingAssign.CreateBy = userCur.User.Id;

                    res = await _data.AddVehicleBookingAssignAsync(data.BookingAssign);

                }
                else if (data.EventModel.ActionType == "edit")
                {

                    data.BookingAssign.UpdateBy = userCur.User.Id;

                    res = await _data.UpdateVehicleBookingAssignAsync(data.BookingAssign);

                }
                else
                {
                    throw new Exception("ActionType ไม่ถูกต้อง");
                }


            }
            catch (Exception ex)
            {
                res.Type = ApiResultsType.error.ToString();
                res.Message = ex.Message;
            }

            return Json(res);
        }
        #endregion


        

        #endregion


        #region Meeting
        [HttpGet]
        public async Task<IActionResult> MeetingRoomBookingEventPreview(MeetingRoomBookingEventPreviewParameter sch)
        {
            var data = new MeetingRoomBookingEventPreview();
            data.MeetingRoomBookingHistoryList = await _rawData.GetViewMeetingRoomBookingHistoryListAsync(new VMeetingRoomBookingHistory { MeetingRoomBookingId = sch.MeetingRoomBookingId });
            data.MeetingRoomBooking = await _rawData.GetViewMeetingRoomBookingAsync(sch.MeetingRoomBookingId ?? 0);

            data.AudioVisualServiceRequest = new VAudioVisualServiceRequest();
            var dataAuList = await _rawData.GetViewAudioVisualServiceRequestListAsync(new VAudioVisualServiceRequest { MeetingRoomBookingId = sch.MeetingRoomBookingId });  //await _rawData.GetViewAudioVisualServiceRequestAsync(data.MeetingRoomBooking.MeetingRoomBookingId ?? 0);
            if (dataAuList.Any())
            {
                data.AudioVisualServiceRequest = dataAuList.FirstOrDefault(x => x.LastStatusId != 6);
            }

            var evt = new EventsModel();
            evt.ActionType = sch.ActionType;

            data.EventsModel = evt;

            return PartialView("Partialviews/Meeting/_ModalEventPreviewMeetingRoomBooking", data);
        }


        #region Approve
        

        
        #endregion

        #region Disapproved
        

        
        #endregion

        #region SendBackEdit
        

        
        #endregion

        #region ApproveCancel
        

        
        #endregion

        #region รายละเอียดห้องประชุม
        [HttpGet]
        public async Task<IActionResult> EventConferenceBookingDetail(int pVideoConferenceBookingId, string pActionType)
        {
            var data = new ConferenceMeetingRoomDetails
            {
                VideoConferenceBookingId = pVideoConferenceBookingId,
                ActionType = pActionType
            };

            if (pActionType == "view")
            {
                var book = await _rawData.GetViewVideoConferenceBookingAsync(pVideoConferenceBookingId);

                if (book != null && book.VideoConferenceBookingId > 0)
                {
                    data.ConferenceLink = book.ConferenceLink;
                    data.ConferenceDetail = book.ConferenceDetail;

                    data.IsHost = book.IsHost;


                }
            }
            else
            {
                var book = await _rawData.GetViewVideoConferenceBookingAsync(pVideoConferenceBookingId);
                if (book != null && book.VideoConferenceBookingId > 0)
                {
                    data.IsHost = book.IsHost;
                    if (book.IsHost == false)
                    {
                        data.ConferenceDetail = "ConferenceDetail";
                    }
                }
            }
            return PartialView("Partialviews/Meeting/_ModalEventConferenceBookingDetail", data);
        }

        

        [HttpGet]
        public async Task<IActionResult> EventDisapprovedConferenceBookingDetail(int pVideoConferenceBookingId)
        {
            var data = new VideoConferenceBookingFormEvent();
            data.VideoConferenceBookingId = pVideoConferenceBookingId;
            data.ActionRemark = "ไม่เห็นควรดำเนินการ";
            return PartialView("Partialviews/Meeting/_ModalEventDisapprovedConferenceBookingDetail", data);
        }

       
        #endregion


        #endregion

        #region AudioVisualService
        [HttpGet]
        public async Task<IActionResult> EventPreviewAudioVisualServiceRequestBooking(EventPreviewAudioVisualServiceRequestBookingParameter sch)
        {

            var resApi = new ApiResultsModel();
            resApi.Type = ApiResultsType.success.ToString();

            var data = new EventPreviewAudioVisualServiceRequestBooking();

            try
            {

                var audioHisData = await _rawData.GetViewAudioVisualServiceRequestHistoryListAsync(new VAudioVisualServiceRequestHistory { AudioVisualServiceRequestId = sch.AudioVisualServiceRequestId });
                if (audioHisData.Type == ApiResultsType.success.ToString())
                {
                    data.AudioVisualServiceRequestHistory = (JsonConvert.DeserializeObject<List<VAudioVisualServiceRequestHistory>>((string)audioHisData.Data)).OrderBy(x => x.CreateOn).ToList();
                }
                else
                {
                    throw new Exception(audioHisData.Message);
                }

                var audioData = await _rawData.GetViewAudioVisualServiceRequestAsync(sch.AudioVisualServiceRequestId ?? 0);
                if (audioData.Type == ApiResultsType.success.ToString())
                {
                    data.AudioVisualServiceRequestBooking = JsonConvert.DeserializeObject<VAudioVisualServiceRequest>((string)audioData.Data);
                }
                else
                {
                    throw new Exception(audioData.Message);
                }

                var evt = new EventsModel();
                evt.ActionType = sch.ActionType;
                data.EventsModel = evt;

            }
            catch (Exception ex)
            {
                resApi.Message = ex.Message;
                resApi.Type = ApiResultsType.error.ToString();

            }


            if (resApi.Type == ApiResultsType.success.ToString())
                return PartialView("Partialviews/Meeting/_ModalEventPreviewAudioVisualServiceRequestBooking", data);
            else
                return RedirectToAction("Index", "Error", new { errorMassage = resApi.Message });

        }



        #region Approve
        [HttpGet]
        public async Task<IActionResult> EventApproveConsiderAudioVisualServiceRequestBooking(int pAudioVisualServiceRequestId)
        {
            var data = new AudioVisualServiceRequestBookingFormEvent();
            data.AudioVisualServiceRequestId = pAudioVisualServiceRequestId;
            data.ActionRemark = "อนุมัติ";
            data.ActionType = "approve-consider";
            return PartialView("Partialviews/Meeting/_ModalEventApproveConsiderAudioVisualServiceRequestBooking", data);


        }

        
        #endregion

        #region Disapproved
        [HttpGet]
        public async Task<IActionResult> EventDisapprovedConsiderAudioVisualServiceRequestBooking(int pAudioVisualServiceRequestId)
        {
            var data = new AudioVisualServiceRequestBookingFormEvent();
            data.AudioVisualServiceRequestId = pAudioVisualServiceRequestId;
            data.ActionRemark = "ไม่เห็นควรดำเนินการ";
            data.ActionType = "disapprove-consider";
            return PartialView("Partialviews/Meeting/_ModalEventDisapprovedConsiderAudioVisualServiceRequestBooking", data);


        }

       
        #endregion

        #region SendBackEdit
        [HttpGet]
        public async Task<IActionResult> EventSendBackEditConsiderAudioVisualServiceRequestBooking(int pAudioVisualServiceRequestId)
        {
            var data = new AudioVisualServiceRequestBookingFormEvent();
            data.AudioVisualServiceRequestId = pAudioVisualServiceRequestId;
            data.ActionRemark = "กรุณาตรวจสอบรายละเอียดคำขออีกครั้ง";
            data.ActionType = "sendbackedit-consider";
            return PartialView("Partialviews/Meeting/_ModalEventSendBackEditConsiderAudioVisualServiceRequestBooking", data);


        }

        
        #endregion

        #region ApproveCancel
        [HttpGet]
        public async Task<IActionResult> EventApproveCancelConsiderAudioVisualServiceRequestBooking(int pAudioVisualServiceRequestId)
        {
            var data = new AudioVisualServiceRequestBookingFormEvent();
            data.AudioVisualServiceRequestId = pAudioVisualServiceRequestId;
            data.ActionRemark = "ยกเลิกการขอใช้บริการโสตทัศน์";
            data.ActionType = "cancel-consider";
            return PartialView("Partialviews/Meeting/_ModalEventApproveCancelConsiderAudioVisualServiceRequestBooking", data);


        }

        
        #endregion


        #region Approve Confirm
        [HttpGet]
        public async Task<IActionResult> EventApproveConfirmAudioVisualServiceRequestBooking(int pAudioVisualServiceRequestId)
        {
            var data = new AudioVisualServiceRequestBookingFormEvent();
            data.AudioVisualServiceRequestId = pAudioVisualServiceRequestId;
            data.ActionRemark = "ดำเนินการแล้ว";
            data.ActionType = "approve-confirm";
            return PartialView("Partialviews/Meeting/_ModalEventApproveConfirmAudioVisualServiceRequestBooking", data);


        }

        
        #endregion

        #endregion


        #region CateringServiceRequest
        [HttpGet]
        public async Task<IActionResult> EventPreviewCateringServiceRequestBooking(EventPreviewCateringServiceRequestBookingParameter sch)
        {

            var resApi = new ApiResultsModel();
            resApi.Type = ApiResultsType.success.ToString();

            var data = new EventPreviewCateringServiceRequestBooking();

            try
            {

                var audioHisData = await _rawData.GetViewCateringServiceRequestHistoryListAsync(new VCateringServiceRequestHistory { CateringServiceRequestId = sch.CateringServiceRequestId });
                if (audioHisData.Type == ApiResultsType.success.ToString())
                {
                    data.CateringServiceRequestHistoryList = (JsonConvert.DeserializeObject<List<VCateringServiceRequestHistory>>((string)audioHisData.Data)).OrderBy(x => x.CreateOn).ToList();
                }
                else
                {
                    throw new Exception(audioHisData.Message);
                }

                var audioData = await _rawData.GetViewCateringServiceRequestAsync(sch.CateringServiceRequestId ?? 0);
                if (audioData.Type == ApiResultsType.success.ToString())
                {
                    data.CateringServiceRequestBooking = JsonConvert.DeserializeObject<VCateringServiceRequest>((string)audioData.Data);
                }
                else
                {
                    throw new Exception(audioData.Message);
                }

                var evt = new EventsModel();
                evt.ActionType = sch.ActionType;
                data.EventsModel = evt;

            }
            catch (Exception ex)
            {
                resApi.Message = ex.Message;
                resApi.Type = ApiResultsType.error.ToString();

            }


            if (resApi.Type == ApiResultsType.success.ToString())
                return PartialView("Partialviews/Catering/_ModalEventPreviewCateringServiceRequestBooking", data);
            else
                return RedirectToAction("Index", "Error", new { errorMassage = resApi.Message });

        }


        #region Approve
        [HttpGet]
        public async Task<IActionResult> EventApproveConsiderCateringServiceRequestBooking(int pCateringServiceRequestId)
        {
            var data = new CateringServiceRequestBookingFormEvent();
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.ActionRemark = "อนุมัติ";
            data.ActionType = "approve-consider";
            return PartialView("Partialviews/Catering/_ModalEventApproveConsiderCateringServiceRequestBooking", data);


        }

        
        #endregion

        #region Disapproved
        [HttpGet]
        public async Task<IActionResult> EventDisapprovedConsiderCateringServiceRequestBooking(int pCateringServiceRequestId)
        {
            var data = new CateringServiceRequestBookingFormEvent();
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.ActionRemark = "ไม่เห็นควรดำเนินการ";
            data.ActionType = "disapprove-consider";
            return PartialView("Partialviews/Catering/_ModalEventDisapprovedConsiderCateringServiceRequestBooking", data);


        }

        
        #endregion

        #region SendBackEdit
        [HttpGet]
        public async Task<IActionResult> EventSendBackEditConsiderCateringServiceRequestBooking(int pCateringServiceRequestId)
        {
            var data = new CateringServiceRequestBookingFormEvent();
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.ActionRemark = "กรุณาตรวจสอบรายละเอียดคำขออีกครั้ง";
            data.ActionType = "sendbackedit-consider";
            return PartialView("Partialviews/Catering/_ModalEventSendBackEditConsiderCateringServiceRequestBooking", data);


        }

        
        #endregion

        #region ApproveCancel
        [HttpGet]
        public async Task<IActionResult> EventApproveCancelConsiderCateringServiceRequestBooking(int pCateringServiceRequestId)
        {
            var data = new CateringServiceRequestBookingFormEvent();
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.ActionRemark = "ยกเลิกการขอใช้บริการจัดเลี้ยง";
            data.ActionType = "approvecancel-consider";
            return PartialView("Partialviews/Catering/_ModalEventApproveCancelConsiderAudioVisualServiceRequestBooking", data);


        }

        
        #endregion


        #region Approve Confirm
        [HttpGet]
        public async Task<IActionResult> EventApproveConfirmCateringServiceRequestBooking(int pCateringServiceRequestId)
        {
            var data = new CateringServiceRequestBookingFormEvent();
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.ActionRemark = "ดำเนินการแล้ว";
            data.ActionType = "approve-confirm";
            return PartialView("Partialviews/Catering/_ModalEventApproveConfirmCateringServiceRequestBooking", data);


        }

        
        #endregion

        #endregion

        #region VehicleNotifications
        [HttpPost]
        public async Task<IActionResult> OpenVehicleNotifications()
        {
            var res = new ApiResultsModel();
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            res = await _vehicleNoti.OpenVehicleNotificationsAsync((int)userCur.User.Id, (int)userCur.Officer.Id);

            return Json(res);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteVehicleNotifications(int NotiId)
        {
            var res = new ApiResultsModel();
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            res = await _vehicleNoti.DeleteVehicleNotificationsAsync(NotiId, (int)userCur.Officer.Id);
            return Json(res);
        }




        [HttpGet]
        public async Task<IActionResult> RedirectVehicleNotifications(int pId)
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            var data = new VSystemNotificationVehicle();
            //--
            try
            {


                var notiRes = await _vehicleNoti.GetVehicleNotificationsAsync(pId);
                if (notiRes.Type == ApiResultsType.success.ToString())
                {
                    data = JsonConvert.DeserializeObject<VSystemNotificationVehicle>((string)notiRes.Data);

                    if (data?.Status == "N")
                    {
                        //--อัพเดท Open
                        await _vehicleNoti.ReadVehicleNotificationsAsync(data?.Id ?? 0, userCur?.User?.Id ?? 0);
                    }


                    if (data.NotificationDetailId == 1 || data.NotificationDetailId == 11 || data.NotificationDetailId == 8)
                    {
                        return RedirectToAction("ConsiderVehicleBookingDetail", "VehicleConsider", new { pBookingId = data.ReferenceId, pActionType = "consider", ReturnUrl = Url.Action("ConsiderVehicleBookingList", "VehicleConsider") });
                    }
                    else if (data.NotificationDetailId == 2)
                    {
                        return RedirectToAction("ConsiderVehicleBookingDetail", "VehicleConsider", new { pBookingId = data.ReferenceId, pActionType = "consider", ReturnUrl = Url.Action("ConsiderVehicleBookingList", "VehicleConsider") });
                    }
                    else if (data.NotificationDetailId == 12 || data.NotificationDetailId == 3)
                    {
                        return RedirectToAction("ConsiderVehicleBookingDetail", "VehicleConsider", new { pBookingId = data.ReferenceId, pActionType = "assign", ReturnUrl = Url.Action("AssignVehicleBookingList", "VehicleConsider") });
                    }
                    else if (data.NotificationDetailId == 4 || data.NotificationDetailId == 5 || data.NotificationDetailId == 6 || data.NotificationDetailId == 9 || data.NotificationDetailId == 10 || data.NotificationDetailId == 7)
                    {
                        return RedirectToAction("VehicleBookingDetail", "VehicleBooking", new { pBookingId = data.ReferenceId, pActionType = "edit", ReturnUrl = Url.Action("VehicleBookingList", "VehicleBooking") });
                    }
                    else
                    {
                        throw new Exception("ไม่พบข้อมูล NotificationDetailId");
                    }

                }
                else
                {
                    throw new Exception(notiRes.Message);
                }

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { errorMassage = ex.Message });
            }
            //--

        }
        #endregion

        #region MeetingNotifications
        [HttpPost]
        public async Task<IActionResult> OpenMeetingNotifications()
        {
            var res = new ApiResultsModel();
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            res = await _meetingNoti.OpenMeetingNotificationsAsync((int)userCur.User.Id, (int)userCur.Officer.Id);

            //if (res.Type == ApiResultsType.success.ToString())
            //{
            //    //var notiResList = await _vehicleNoti.GetVehicleNotificationsListAsync((int)userCur.Officer.Id);
            //    //if (notiResList.Type == ApiResultsType.success.ToString())
            //    //{
            //    //    var dataList = JsonConvert.DeserializeObject<List<VSystemNotificationVehicle>>((string)notiResList.Data);
            //    //    res.Type = ApiResultsType.success.ToString();
            //    //    res.Data = 0;//dataList.Where(x => x.Status == "N").Count();
            //    //}
            //}

            return Json(res);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMeetingNotifications(int NotiId)
        {
            var res = new ApiResultsModel();
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            res = await _meetingNoti.DeleteMeetingNotificationsAsync(NotiId, (int)userCur.Officer.Id);
            return Json(res);
        }




        [HttpGet]
        public async Task<IActionResult> RedirectMeetingNotifications(int pId)
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            var data = new VSystemNotificationVehicle();
            //--
            try
            {


                var notiRes = await _meetingNoti.GetMeetingNotificationsAsync(pId, (int)userCur.User.Id);
                if (notiRes.Type == ApiResultsType.success.ToString())
                {
                    data = JsonConvert.DeserializeObject<VSystemNotificationVehicle>((string)notiRes.Data);


                    if (data?.Status == "N")
                    {
                        //--อัพเดท Open
                        await _meetingNoti.ReadMeetingNotificationsAsync(data?.Id ?? 0, userCur?.User?.Id ?? 0);
                    }


                    if (data.NotificationDetailId == 1011 || data.NotificationDetailId == 1031 || data.NotificationDetailId == 1042 || data.NotificationDetailId == 1051)
                    {
                        return RedirectToAction("MeetingRoomBookingDetail", "MeetingRoomBooking", new { pBookingId = data.ReferenceId, pActionType = "consider", ReturnUrl = Url.Action("ConsiderMeetingRoomBookingList", "MeetingRoomConsider") });
                    }
                    else if (data.NotificationDetailId == 1021 || data.NotificationDetailId == 1061 || data.NotificationDetailId == 1023 || data.NotificationDetailId == 1062 || data.NotificationDetailId == 1022 || data.NotificationDetailId == 1024 || data.NotificationDetailId == 1041)
                    {
                        return RedirectToAction("MeetingRoomBookingDetail", "MeetingRoomBooking", new { pBookingId = data.ReferenceId, pActionType = "view", ReturnUrl = Url.Action("MeetingRoomBookingList", "MeetingRoomBooking") });
                    }
                    else if (data.NotificationDetailId == 2041 || data.NotificationDetailId == 2051 || data.NotificationDetailId == 2052 || data.NotificationDetailId == 2061 || data.NotificationDetailId == 2081)
                    {
                        return RedirectToAction("AudioVisualServiceRequestDetail", "AudioVisualServiceRequest", new { pAudioVisualServiceRequestId = data.ReferenceId, pActionType = "consider", ReturnUrl = Url.Action("ConsiderAudioVisualServiceRequestList", "AudioVisualServiceConsider") });
                    }
                    else if (data.NotificationDetailId == 2011)
                    {
                        if (userCur?.UserRole?.Id == 17)
                        {
                            return RedirectToAction("AudioVisualServiceRequestDetail", "AudioVisualServiceRequest", new { pAudioVisualServiceRequestId = data.ReferenceId, pActionType = "confirm", ReturnUrl = Url.Action("ConsiderAudioVisualServiceRequestList", "AudioVisualServiceConsider") });
                        }
                        else
                        {
                            return RedirectToAction("AudioVisualServiceRequestDetail", "AudioVisualServiceRequest", new { pAudioVisualServiceRequestId = data.ReferenceId, pActionType = "consider", ReturnUrl = Url.Action("ConsiderAudioVisualServiceRequestList", "AudioVisualServiceConsider") });
                        }
                    }
                    else if (data.NotificationDetailId == 2021 || data.NotificationDetailId == 2071 || data.NotificationDetailId == 2072)
                    {
                        return RedirectToAction("AudioVisualServiceRequestDetail", "AudioVisualServiceRequest", new { pAudioVisualServiceRequestId = data.ReferenceId, pActionType = "confirm", ReturnUrl = Url.Action("ConfirmAudioVisualServiceRequestList", "AudioVisualServiceConsider") });
                    }
                    else if (data.NotificationDetailId == 2023 || data.NotificationDetailId == 2022 || data.NotificationDetailId == 2024 || data.NotificationDetailId == 2082 || data.NotificationDetailId == 2083 || data.NotificationDetailId == 2084)
                    {
                        return RedirectToAction("AudioVisualServiceRequestDetail", "AudioVisualServiceRequest", new { pAudioVisualServiceRequestId = data.ReferenceId, pActionType = "edit", ReturnUrl = Url.Action("AudioVisualServiceRequestList", "AudioVisualServiceConsider") });
                    }
                    else if (data.NotificationDetailId == 2031)
                    {
                        return RedirectToAction("AudioVisualServiceRequestDetail", "AudioVisualServiceRequest", new { pAudioVisualServiceRequestId = data.ReferenceId, pActionType = "view", ReturnUrl = Url.Action("AudioVisualServiceRequestList", "AudioVisualServiceRequest") });
                    }
                    else if (data.NotificationDetailId == 3041 || data.NotificationDetailId == 3051 || data.NotificationDetailId == 3052 || data.NotificationDetailId == 3061)
                    {
                        return RedirectToAction("CateringServiceRequestDetail", "CateringServiceRequest", new { pCateringServiceRequestId = data.ReferenceId, pActionType = "consider", ReturnUrl = Url.Action("ConsiderCateringServiceRequestList", "CateringServiceConsider") });
                    }
                    else if (data.NotificationDetailId == 3011)
                    {
                        if (userCur?.UserRole?.Id == 16)
                        {
                            return RedirectToAction("CateringServiceRequestDetail", "CateringServiceRequest", new { pCateringServiceRequestId = data.ReferenceId, pActionType = "confirm", ReturnUrl = Url.Action("ConsiderCateringServiceRequestList", "CateringServiceConsider") });
                        }
                        else
                        {
                            return RedirectToAction("CateringServiceRequestDetail", "CateringServiceRequest", new { pCateringServiceRequestId = data.ReferenceId, pActionType = "consider", ReturnUrl = Url.Action("ConsiderCateringServiceRequestList", "CateringServiceConsider") });
                        }
                    }
                    else if (data.NotificationDetailId == 3031)
                    {
                        return RedirectToAction("CateringServiceRequestDetail", "CateringServiceRequest", new { pCateringServiceRequestId = data.ReferenceId, pActionType = "view", ReturnUrl = Url.Action("ConfirmCateringServiceRequestList", "CateringServiceConsider") });
                    }
                    else if (data.NotificationDetailId == 3021 || data.NotificationDetailId == 3071 || data.NotificationDetailId == 3072 || data.NotificationDetailId == 3081)
                    {
                        return RedirectToAction("CateringServiceRequestDetail", "CateringServiceRequest", new { pCateringServiceRequestId = data.ReferenceId, pActionType = "confirm", ReturnUrl = Url.Action("ConfirmCateringServiceRequestList", "CateringServiceConsider") });
                    }
                    else if (data.NotificationDetailId == 3023 || data.NotificationDetailId == 3022 || data.NotificationDetailId == 3024 || data.NotificationDetailId == 3083 || data.NotificationDetailId == 3084)
                    {
                        return RedirectToAction("CateringServiceRequestDetail", "CateringServiceRequest", new { pCateringServiceRequestId = data.ReferenceId, pActionType = "view", ReturnUrl = Url.Action("CateringServiceRequestList", "CateringServiceRequest") });
                    }
                    else if (data.NotificationDetailId == 3082)
                    {
                        return RedirectToAction("CateringServiceRequestDetail", "CateringServiceRequest", new { pCateringServiceRequestId = data.ReferenceId, pActionType = "edit", ReturnUrl = Url.Action("CateringServiceRequestList", "CateringServiceRequest") });
                    }
                    else if (data.NotificationDetailId == 4011)
                    {
                        return RedirectToAction("ConsiderVideoConferenceBookingList", "ConferenceConsider");
                    }
                    else if (data.NotificationDetailId == 4041 || data.NotificationDetailId == 4021 || data.NotificationDetailId == 4023 || data.NotificationDetailId == 4024)
                    {
                        return RedirectToAction("VideoConferenceBookingList", "ConferenceBooking");
                    }
                    else if (data.NotificationDetailId == 5011 || data.NotificationDetailId == 6011 || data.NotificationDetailId == 5091 || data.NotificationDetailId == 6031 || data.NotificationDetailId == 5101 || data.NotificationDetailId == 6041)
                    {
                        return RedirectToAction("ConsiderExpensesRequestList", "ExpensesConsider");
                    }
                    else if (data.NotificationDetailId == 5021 || data.NotificationDetailId == 5051 || data.NotificationDetailId == 5061 || data.NotificationDetailId == 5071 || data.NotificationDetailId == 5081 || data.NotificationDetailId == 6021 || data.NotificationDetailId == 5022 || data.NotificationDetailId == 5052 || data.NotificationDetailId == 5062 || data.NotificationDetailId == 5023 || data.NotificationDetailId == 5053 || data.NotificationDetailId == 6022 || data.NotificationDetailId == 6023)
                    {
                        return RedirectToAction("ExpensesRequestList", "ExpensesRequest");
                    }
                    else
                    {
                        throw new Exception("ไม่พบข้อมูล NotificationDetailId");
                    }

                }
                else
                {
                    throw new Exception(notiRes.Message);
                }

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { errorMassage = ex.Message });
            }
            //--

        }
        #endregion


        #region เบิกค่าใช้จ่าย

        [HttpGet]
        public async Task<IActionResult> EventPreviewExpensesRequest(EventPreviewExpensesRequestParameter sch)
        {

            var resApi = new ApiResultsModel();
            resApi.Type = ApiResultsType.success.ToString();

            var data = new EventPreviewExpensesRequest();
            data.CateringServiceExpensesHistoryList = new List<VCateringServiceExpensesHistory>();



            try
            {

                var expenseRes = await _rawData.GetViewCateringServiceExpenseAsync(sch.CateringServiceExpensesId ?? 0);
                if (expenseRes.Type == ApiResultsType.success.ToString())
                {
                    data.CateringServiceExpense = JsonConvert.DeserializeObject<VCateringServiceExpense>((string)expenseRes.Data);
                }
                else
                {
                    throw new Exception(expenseRes.Message);
                }

                var expenseHisRes = await _rawData.GetViewCateringServiceExpensesHistoryListAsync(new VCateringServiceExpensesHistory { CateringServiceExpensesId = sch.CateringServiceExpensesId });
                if (expenseHisRes.Type == ApiResultsType.success.ToString())
                {
                    data.CateringServiceExpensesHistoryList = JsonConvert.DeserializeObject<List<VCateringServiceExpensesHistory>>((string)expenseHisRes.Data);
                }
                else
                {
                    throw new Exception(expenseRes.Message);
                }

                var evt = new EventsModel();
                evt.ActionType = sch.ActionType;
                data.EventsModel = evt;

            }
            catch (Exception ex)
            {
                resApi.Message = ex.Message;
                resApi.Type = ApiResultsType.error.ToString();

            }


            if (resApi.Type == ApiResultsType.success.ToString())
                return PartialView("Partialviews/Expenses/_ModalEventPreviewExpensesRequest", data);
            else
                return RedirectToAction("Index", "Error", new { errorMassage = resApi.Message });

        }


        

        [HttpGet]
        public async Task<IActionResult> EventCancelExpenseReimbursementDetails(int pMeetingRoomBookingId, int pCateringServiceRequestId, int pCateringServiceExpensesId)
        {
            var data = new ExpenseReimbursementDetailsFormEvent();
            data.MeetingRoomBookingId = pMeetingRoomBookingId;
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.CateringServiceExpensesId = pCateringServiceExpensesId;
            return PartialView("Partialviews/Expenses/_ModalCancelExpenseReimbursementDetails", data);
        }

        #region Cancel
        
        #endregion

        #region Consider Pass
        [HttpGet]
        public async Task<IActionResult> EventConsiderPassExpenseReimbursementDetails(int pMeetingRoomBookingId, int pCateringServiceRequestId, int pCateringServiceExpensesId)
        {
            var data = new ExpenseReimbursementDetailsFormEvent();
            data.MeetingRoomBookingId = pMeetingRoomBookingId;
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.CateringServiceExpensesId = pCateringServiceExpensesId;
            data.ActionRemark = "เห็นควรดำเนินการ";
            return PartialView("Partialviews/Expenses/_ModalConsiderPassExpenseReimbursementDetails", data);
        }

        
        #endregion

        #region Consider DisPass
        [HttpGet]
        public async Task<IActionResult> EventConsiderDisPassExpenseReimbursementDetails(int pMeetingRoomBookingId, int pCateringServiceRequestId, int pCateringServiceExpensesId)
        {
            var data = new ExpenseReimbursementDetailsFormEvent();
            data.MeetingRoomBookingId = pMeetingRoomBookingId;
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.CateringServiceExpensesId = pCateringServiceExpensesId;
            data.ActionRemark = "ไม่เห็นควรดำเนินการ";
            return PartialView("Partialviews/Expenses/_ModalConsiderDisPassExpenseReimbursementDetails", data);
        }

        
        #endregion

        #region Consider Approve
        [HttpGet]
        public async Task<IActionResult> EventConsiderApproveExpenseReimbursementDetails(int pMeetingRoomBookingId, int pCateringServiceRequestId, int pCateringServiceExpensesId)
        {
            var data = new ExpenseReimbursementDetailsFormEvent();
            data.MeetingRoomBookingId = pMeetingRoomBookingId;
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.CateringServiceExpensesId = pCateringServiceExpensesId;
            data.ActionRemark = "เห็นควรดำเนินการ";
            return PartialView("Partialviews/Expenses/_ModalConsiderApproveExpenseReimbursementDetails", data);
        }

        
        #endregion


        #region Consider DisApprove
        [HttpGet]
        public async Task<IActionResult> EventConsiderDisApproveExpenseReimbursementDetails(int pMeetingRoomBookingId, int pCateringServiceRequestId, int pCateringServiceExpensesId)
        {
            var data = new ExpenseReimbursementDetailsFormEvent();
            data.MeetingRoomBookingId = pMeetingRoomBookingId;
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.CateringServiceExpensesId = pCateringServiceExpensesId;
            data.ActionRemark = "ไม่เห็นควรดำเนินการ";
            return PartialView("Partialviews/Expenses/_ModalConsiderDisApproveExpenseReimbursementDetails", data);
        }

        
        #endregion

        #region Consider SendBackEdit
        [HttpGet]
        public async Task<IActionResult> EventConsiderSendBackEditExpenseReimbursementDetails(int pMeetingRoomBookingId, int pCateringServiceRequestId, int pCateringServiceExpensesId)
        {
            var data = new ExpenseReimbursementDetailsFormEvent();
            data.MeetingRoomBookingId = pMeetingRoomBookingId;
            data.CateringServiceRequestId = pCateringServiceRequestId;
            data.CateringServiceExpensesId = pCateringServiceExpensesId;
            data.ActionRemark = "กรุณาตรวจสอบรายะเอียดคำขออีกครั้ง";
            return PartialView("Partialviews/Expenses/_ModalConsiderSendBackEditExpenseReimbursementDetails", data);
        }

        
        #endregion


        [HttpGet]
        public async Task<IActionResult> SelectBudgetItems()
        {
            ViewBag.DropdownOrganizationModal = await _dropdowns.DropdownOrganization(null, new string[] { "2" });
            ViewBag.DropdownBudgetExpenseTypeModal = await _dropdowns.DropdownBudgetExpenseType("N");
            return PartialView("Partialviews/Expenses/_ModalBudgetItems");
        }

        

        #endregion


        [HttpGet]
        public async Task<IActionResult> GetAssetApproveDate(int AssetId)
        {
            var res = await _data.GetAssetAsync(AssetId);
            var approveDateString = "";
            if (res.ApproveDate.HasValue)
            {
                approveDateString = res.ApproveDate.Value.ToString("dd/MM/yyyy");
            }
            return Json(approveDateString);
        }


        [HttpGet]
        public async Task<IActionResult> GetAttachFileListByRef(int ReferenceId, string ReferenceTable, string ReferenceGroup)
        {
            var data = await _attachFile.GetAttachFileListAsync(new AttachFile { ReferenceId = ReferenceId, ReferenceTable = ReferenceTable, ReferenceGroup = ReferenceGroup });
            return PartialView("Partialviews/_DisplayAttachFileListByRefResults", data);
        }


    }
}
