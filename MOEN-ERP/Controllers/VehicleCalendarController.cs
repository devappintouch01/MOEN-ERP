using DevExpress.Internal;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel.VehicleCalendar;
using MOEN_ERP.Services;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Controllers
{
    public class VehicleCalendarController : Controller
    {
        private readonly IDropdowns _dropdowns;
        private readonly IDataService _dataService;
        private readonly IRawDataService _rawData;
        private readonly IMasterService _masterData;
        private readonly IAttachFileService _attachFile;
        public VehicleCalendarController(IDropdowns dropdowns, IDataService dataService, IRawDataService rawData, IMasterService masterData, IAttachFileService attachFile)
        {
            _dropdowns = dropdowns;
            _dataService = dataService;
            _rawData = rawData;
            _masterData = masterData;
            _attachFile = attachFile;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> VehicleDashboard()
        {        
            var dataVehicle = await _rawData.GetViewVehicleListAsync(new VVehicle { VehicleActive = true });
            // ใช้ LINQ เพื่อดึงข้อมูลรถและข้อมูลภาพมาในรูปแบบ IEnumerable
            var carDetailList = dataVehicle.Select(async itm =>
            {
                var att = await _attachFile.GetAttachFileImageByRef("Vehicle", (int)itm.VehicleId);
                return new VehicleCalendarSlideImage
                {
                    VehicleId = itm.VehicleId,
                    VehicleDetail = $"{itm.VtypeName} {itm.VehicleRegistration}",
                    VehicleColor = itm.Hexcode,
                    RowGuid = att != null && att.Id != 0 ? att.RowGuid : null
                };
            }).Select(task => task.Result).ToList(); // เรียก Task.Result เพื่อรอการดึงข้อมูลเสร็จสิ้น

            ViewBag.CarDetailList = carDetailList;
            return View();
        }

        #region Car

        public async Task<IActionResult> GetEventsCars()
        {
            var data = await _dataService.GetEventsCars();

            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetEventsTimelineCars(DateTime dateStart)
        {
            var data = await _dataService.GetEventsTimelineCars(dateStart);

            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetEventsTimelineResourcesCars(DateTime dateStart)
        {

            var data = await _dataService.GetEventsTimelineResourcesCars(dateStart);
            return Json(data);
        }

        #endregion


        [HttpGet]
        public async Task<IActionResult> GetVehicleDetail(int pVehicleId)
        {            
            var data = new VehicleCalendarCarDetail
            {
                AttachFileList = new List<AttachFile>(),
                Vehicle = await _rawData.GetViewVehicleAsync(pVehicleId)
            };

            data.AttachFileList = await _attachFile.GetAttachFileNoDataListAsync(new AttachFile
            {
                ReferenceId = pVehicleId,
                ReferenceTable = "Vehicle",
                ReferenceGroup = "Vehicle"
            });

            return PartialView("_VehicleDetail", data);
        }

        [HttpGet]
        public async Task<IActionResult> GetVehicleHistory(int pVehicleId)
        {
            var data = new VehicleCalendarCarHistory
            {
                VehicleBookingList = new List<VVehicleDashboard>(),
                Vehicle = await _rawData.GetViewVehicleAsync(pVehicleId)
            };

            data.VehicleBookingList = await _rawData.GetViewVehicleBookingListAsync(new VVehicleDashboard
            {
                VehicleId = pVehicleId,
                IsFinish = true,
                LastStatusId = 4
            });

            return PartialView("_ModalVehicleHistory", data);
        }


        [HttpGet]
        public async Task<IActionResult> GetVehicleTaxPaymentHistory(int pVehicleId)
        {
            var data = new VehicleCalendarCarTaxPaymentHistory
            {
                VehicleTaxPaymentList = new List<VVehicleTaxPaymentHistoryDetail>(),
                Vehicle = await _rawData.GetViewVehicleAsync(pVehicleId)
            };

            data.VehicleTaxPaymentList = await _rawData.GetViewVehicleTaxPaymentHistoryDetailListAsync(new VVehicleTaxPaymentHistoryDetail
            {
                VehicleId = pVehicleId
            });

            return PartialView("_ModalVehicleTaxPaymentHistoryDetail", data);
        }

        [HttpGet]
        public async Task<IActionResult> GetVehicleMaintenanceHistory(int pVehicleId)
        {
            var data = new VehicleCalendarCarMaintenanceHistory
            {
                VehicleMaintenanceList = new List<VVehicleMaintenanceHistoryDetail>(),
                Vehicle = await _rawData.GetViewVehicleAsync(pVehicleId)
            };

            data.VehicleMaintenanceList = await _rawData.GetViewVehicleMaintenanceHistoryDetailListAsync(new VVehicleMaintenanceHistoryDetail
            {
                VehicleId = pVehicleId
            });
            return PartialView("_ModalVehicleMaintenanceHistoryDetail", data);
        }

       
    }
}
