using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DataAccess.Native.Sql.QueryBuilder;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraRichEdit.Model;
using iTextSharp.text.pdf.qrcode;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.ViewModel;
using MOEN_ERP.Models.ViewModel.VehicleConsider;
using MOEN_ERP.Services;
using Newtonsoft.Json;
using QRCoder;
using SkiaSharp;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;



namespace MOEN_ERP.Controllers
{
    public class AssetController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly SettingsModel _settingsModels;
        public AssetController(HttpClient httpClient, IOptions<SettingsModel> option)
        {
            _httpClient = httpClient;
            _settingsModels = option.Value;
        }

        #region หน้าจอคลังวัสดุส่วนกลาง
        public async Task<IActionResult> AssetMaterialCentralList()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterMaterialGroupCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterMaterialGroup = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            ViewBag.success = TempData["success"];
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetTableVMaterialStock(int? warehouseId, string? materialName, string? gpscCode, bool noVat = true)
        {
            var data = new List<VMaterialStock>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVMaterialStock?materialName={materialName}&warehouseId={warehouseId}&gpscCode={gpscCode}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialStock>>(json) ?? new List<VMaterialStock>();
            }
            ViewBag.Novat = noVat;
            return PartialView("_tableVMaterialStock", data);
        }

        public async Task<IActionResult> AssetParcelReceiveDetail(int? materialInId, bool? success, string? error, bool history = false)
        {
            var data = new MaterialInDetailModel { materialIn = new MaterialIn(), lstVMaterialInItems = new List<VMaterialInItem>() };
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouse");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.VMasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            if (materialInId != null && materialInId != 0)
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialInDetailModel?id={materialInId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MaterialInDetailModel>(json) ?? data;
                }
            }

            if (success != null)
            {
                if (success == true) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = error;
            }

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.lstVMaterialInItems));
            ViewBag.History = history;
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetMaterialInItem(int? id, int materialInId, string guidPage)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterMaterial");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.VMasterMaterial = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterUnit");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterUnit = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterMaterial");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.lstVMasterMaterial = JsonConvert.DeserializeObject<List<VMasterMaterial>>(json) ?? new List<VMasterMaterial>();
            }

            var data = new VMaterialInItem();

            if (id != null)
            {
                var jsonList = HttpContext.Session.GetString(guidPage);
                var list = JsonConvert.DeserializeObject<List<VMaterialInItem>>(jsonList) ?? new List<VMaterialInItem>();
                data = list.Where(x => x.Id == id).FirstOrDefault();
            }
            ViewBag.guidPage = guidPage;
            data.MaterialInId = materialInId;
            return PartialView("_modalMaterialInItem", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMaterialInItem(VMaterialInItem data, string chkIncludeVat, string guidPage)
        {

            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VMaterialInItem>>(jsonList) ?? new List<VMaterialInItem>();

            data.IncludeVat = chkIncludeVat == "Y" ? "Y" : "N";
            var user = new Appz(HttpContext).CurrentSignInUser;

            if (data.CreateBy == null)
            {
                data.CreateBy = user.User.Id;
                data.CreateOn = DateTime.Now;
                list.Add(data);
            }
            else
            {
                var item = list.Where(x => x.CreateOn?.ToString() == data.CreateOn.ToString()).FirstOrDefault();
                item.MaterialId = data.MaterialId;
                item.Gpsccode = data.Gpsccode;
                item.UnitPriceNoVat = data.UnitPriceNoVat;
                item.IncludeVat = data.IncludeVat;
                item.Vat = data.Vat;
                item.UnitPrice = data.UnitPrice;
                item.ReceiveAmount = data.ReceiveAmount;
                item.UnitId = data.UnitId;
                item.TotalPrice = data.TotalPrice;
                item.UpdateBy = user.User.Id;
                item.UpdateOn = DateTime.Now;
            }

            var VMasterMaterial = new List<SelectListItem>();
            var MasterUnit = new List<SelectListItem>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterMaterial");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                VMasterMaterial = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterUnit");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                MasterUnit = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            foreach (var item in list)
            {
                item.MaterialName = VMasterMaterial.Where(x => x.Value == item.MaterialId.ToString()).FirstOrDefault()?.Text;
                item.UnitName = MasterUnit.Where(x => x.Value == item.UnitId.ToString()).FirstOrDefault()?.Text;
            }

            var model = new MaterialInDetailModel { materialIn = new MaterialIn(), lstVMaterialInItems = list, guidPage = guidPage };

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(model.lstVMaterialInItems));
            ViewBag.success = "เพิ่มรายการสำเร็จ";

            return PartialView("_tableVMaterialInItems", model);

        }

        [HttpPost]
        public async Task<IActionResult> DeleteMaterialInItem(List<DateTime> createOn, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VMaterialInItem>>(jsonList) ?? new List<VMaterialInItem>();

            foreach (var item in createOn)
            {
                list = list.Where(x => x.CreateOn.ToString() != item.ToString()).ToList();
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(list));
            var model = new MaterialInDetailModel { materialIn = new MaterialIn(), lstVMaterialInItems = list, guidPage = guidPage };
            ViewBag.success = "ลบข้อมูลสำเร็จ";
            return PartialView("_tableVMaterialInItems", model);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMaterialIn(MaterialInDetailModel data, string status)
        {
            var model = data.materialIn;
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (status == "A")
            {
                model.Status = "A";
                model.ApproveDate = DateTime.Now;
            }
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;
                model.MaterialInType = 1;
                model.WarehouseId = 1;
                model.WarehouseLevel = "1";
            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var jsonList = HttpContext.Session.GetString(data.guidPage);
            data.lstVMaterialInItems = JsonConvert.DeserializeObject<List<VMaterialInItem>>(jsonList) ?? new List<VMaterialInItem>();

            HttpContext.Session.Remove(data.guidPage);

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveMaterialIn", content);

            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();

                data.materialIn.Id = apiResults?.Id ?? 0;
            }

            if (model.Status == "A")
            {
                TempData["success"] = "ยืนยันสำเร็จ";
                return RedirectToAction("AssetMaterialCentralList", "Asset");
            }
            else
            {
                return RedirectToAction("AssetParcelReceiveDetail", "Asset", new { materialInId = data.materialIn.Id, success = apiResults.Success, error = apiResults.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetTableVSupplier(string? nameThai)
        {
            var data = new List<VSupplier>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetTableVSupplier?nameThai={nameThai}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VSupplier>>(json) ?? new List<VSupplier>();
            }
            return PartialView("_tableVSupplier", data);
        }
        [HttpPost]
        public async Task<IActionResult> GetTableVProcurement(int? pmcBudgetYear, string? pmcCode, DateTime? pmcContractDateFrom, DateTime? pmcContractDateTo, string? pmcSupplierName)
        {
            var data = new List<VProcurement>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetTableVProcurement?pmcBudgetYear={pmcBudgetYear}&pmcCode={pmcCode}&pmcContractDateFrom={pmcContractDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&pmcContractDateTo={pmcContractDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&pmcSupplierName={pmcSupplierName}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VProcurement>>(json) ?? new List<VProcurement>();
            }
            return PartialView("_tableVProcurement", data);
        }

        #endregion

        #region คลังวัสดุหน่วยงาน
        public async Task<IActionResult> AssetMaterialOrganizationList()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouse");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.VMasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return View();
        }

        #endregion

        #region หน้าจอทะเบียนคุมวัสดุจังหวัด
        public async Task<IActionResult> AssetMaterialProvinceList()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouse");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.VMasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            ViewBag.success = TempData["success"];
            return View();
        }

        public async Task<IActionResult> AssetParcelReceiveProvinceDetail(int? materialInId, bool? success, string? error, bool history = false)
        {
            var data = new MaterialInDetailModel { materialIn = new MaterialIn(), lstVMaterialInItems = new List<VMaterialInItem>() };
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouse");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.VMasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            if (materialInId != null && materialInId != 0)
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialInDetailModel?id={materialInId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MaterialInDetailModel>(json) ?? data;
                }
            }

            if (success != null)
            {
                if (success == true) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = error;
            }

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.lstVMaterialInItems));
            ViewBag.History = history;
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAssetParcelReceiveProvinceDetail(MaterialInDetailModel data, string status)
        {
            var model = data.materialIn;
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (status == "A")
            {
                model.Status = "A";
                model.ApproveDate = DateTime.Now;
            }
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;
                model.MaterialInType = 2;
                model.WarehouseLevel = "3";
            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var jsonList = HttpContext.Session.GetString(data.guidPage);
            data.lstVMaterialInItems = JsonConvert.DeserializeObject<List<VMaterialInItem>>(jsonList) ?? new List<VMaterialInItem>();

            HttpContext.Session.Remove(data.guidPage);

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveMaterialIn", content);
            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();

                data.materialIn.Id = apiResults?.Id ?? 0;
            }

            if (model.Status == "A")
            {
                TempData["success"] = "ยืนยันสำเร็จ";
                return RedirectToAction("AssetMaterialProvinceList", "Asset");
            }
            else
            {
                return RedirectToAction("AssetParcelReceiveProvinceDetail", "Asset", new { materialInId = data.materialIn.Id, success = apiResults.Success, error = apiResults.Message });
            }
        }

        #endregion

        #region ประวัติการรับพัสดุ
        public IActionResult AssetParcelReceiveHistory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetParcelReceiveHistory(string? code, DateTime? receiveDate, string? supplierName)
        {
            var data = new List<VMaterialIn>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVMaterialIn?code={code}&receiveDate={receiveDate?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&supplierName={supplierName}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialIn>>(json) ?? new List<VMaterialIn>();
            }
            return PartialView("_tableAssetParcelReceiveHistory", data);
        }

        [HttpPost]
        public async Task<IActionResult> DelMaterialInHistory(int? id)
        {
            var result = new ApiResultsModel();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DelMaterialInHistory?id={id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();

                if (result.Success)
                {
                    ViewBag.success = "ลบรายการสำเร็จ";
                }
                else
                {
                    ViewBag.error = result.Message;
                }
            }

            return PartialView("_tableAssetParcelReceiveHistory", new List<VMaterialIn>());
        }


        #endregion

        #region หน้าจอรายการยืม-คืนวัสดุ
        public async Task<IActionResult> AssetBorrowMaterialList()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStatus");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterStatus = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            ViewBag.success = TempData["success"];

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetBorrowMaterialList(DateTime? BorrowerDateFrom, DateTime? BorrowerDateTo, int? SourceOrganizationId, int? StatusId)
        {
            var data = new List<VMaterialBorrow>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVMaterialBorrow?BorrowerDateFrom={BorrowerDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&BorrowerDateTo={BorrowerDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&StatusId={StatusId}&SourceOrganizationId={SourceOrganizationId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialBorrow>>(json) ?? new List<VMaterialBorrow>();
            }
            return PartialView("_tableVMaterialBorrow", data);
        }
        public async Task<IActionResult> AssetBorrowMaterialDetail(int? mbId)
        {
            var data = new MaterialDetailModel { materialBorrow = new MaterialBorrow(), vMaterialBorrowItems = new List<VMaterialBorrowItem>() };
            var user = new Appz(HttpContext).CurrentSignInUser;

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVOfficer");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var listOfficer = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                ViewBag.Officer = listOfficer;
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            if (mbId == null)
            {
                data.materialBorrow.BorrowerBy = user.User?.Id;
            }
            else
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetBorrowMaterialDetail?mbId={mbId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MaterialDetailModel>(json) ?? new MaterialDetailModel();
                }
            }

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.vMaterialBorrowItems));
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> SearchVMaterialStock(string? MaterialName, string? GPSCCode, string guidPage, int? sourceOrganizationId)
        {
            var data = new List<VMaterialStock>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVMaterialStockCheck?MaterialName={MaterialName}&GPSCCode={GPSCCode}&sourceOrganizationId={sourceOrganizationId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialStock>>(json) ?? new List<VMaterialStock>();
            }
            ViewBag.guidPage = guidPage;
            return PartialView("_tableVMaterialStockCheckList", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveVMaterialStockSelect(List<int> lstId, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VMaterialBorrowItem>>(jsonList) ?? new List<VMaterialBorrowItem>();

            var data = new MaterialDetailModel { materialBorrow = new MaterialBorrow(), vMaterialBorrowItems = list, guidPage = guidPage, changeData = true };
            var lst = new List<VMaterialStock>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVMaterialStockCheck");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                lst = JsonConvert.DeserializeObject<List<VMaterialStock>>(json) ?? new List<VMaterialStock>();
                lst = lst.Where(x => x.Id != null).ToList();

                lst = lst.Where(x => lstId.Contains(x.Id.Value)).ToList();
            }
            var user = new Appz(HttpContext).CurrentSignInUser;

            foreach (var item in lst)
            {
                data.vMaterialBorrowItems.Add(new VMaterialBorrowItem
                {
                    CreateBy = user.User?.Id,
                    CreateOn = DateTime.Now,
                    MaterialName = item.MaterialName,
                    MaterialId = item.MaterialId,
                    UnitName = item.UnitName,
                    UnitId = item.UnitId,
                    StatusName = "",
                });
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vMaterialBorrowItems));
            return PartialView("_tableAssetBorrowMaterialDetailTab1", data);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveVMaterialStockSelect(List<int> lstNo, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VMaterialBorrowItem>>(jsonList) ?? new List<VMaterialBorrowItem>();

            var filteredList = list.Where((item, index) => !lstNo.Contains(index)).ToList();

            var data = new MaterialDetailModel { materialBorrow = new MaterialBorrow(), vMaterialBorrowItems = filteredList, guidPage = guidPage, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vMaterialBorrowItems));

            return PartialView("_tableAssetBorrowMaterialDetailTab1", data);

        }
        [HttpPost]
        public async Task<IActionResult> GetVMaterialBorrowItemDetai(int mbId, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VMaterialBorrowItem>>(jsonList) ?? new List<VMaterialBorrowItem>();
            return PartialView("_modalVMaterialBorrowItemDetail ", list.Where(x => x.Id == mbId).FirstOrDefault());
        }
        [HttpPost]
        public async Task<IActionResult> SaveReturnTab2(string lstSelectedIds, string guidPage, int ReturnBy, DateTime? ReturnDate)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VMaterialBorrowItem>>(jsonList) ?? new List<VMaterialBorrowItem>();

            List<int> selectedIdsList = lstSelectedIds.Split(',')
                                             .Select(int.Parse)
                                             .ToList();

            var filteredList = list.Where(x => selectedIdsList.Contains(x.Id)).ToList();

            var user = new Appz(HttpContext).CurrentSignInUser;

            var returnByName = "";
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVOfficer");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var listOfficer = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                returnByName = listOfficer.Where(x => x.Value == ReturnBy.ToString()).FirstOrDefault()?.Text;
            }

            foreach (var item in filteredList)
            {
                item.UpdateBy = user.User?.Id;
                item.UpdateOn = DateTime.Now;
                item.StatusId = 2;
                item.ReturnBy = ReturnBy;
                item.ReturnByName = returnByName;
                item.ReturnDate = ReturnDate;
            }

            var data = new MaterialDetailModel { materialBorrow = new MaterialBorrow(), vMaterialBorrowItems = list, guidPage = guidPage, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vMaterialBorrowItems));
            ViewBag.Mdl = "mdlTab2Detail3";
            return PartialView("_tableAssetBorrowMaterialDetailTab2", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveReceiveTab2(string lstSelectedIds, string guidPage, int ReturneeBy, DateTime? ReturnReceiveDate)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VMaterialBorrowItem>>(jsonList) ?? new List<VMaterialBorrowItem>();

            List<int> selectedIdsList = lstSelectedIds.Split(',')
                                             .Select(int.Parse)
                                             .ToList();

            var filteredList = list.Where(x => selectedIdsList.Contains(x.Id)).ToList();

            var user = new Appz(HttpContext).CurrentSignInUser;

            var returnByName = "";
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVOfficer");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var listOfficer = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                returnByName = listOfficer.Where(x => x.Value == ReturneeBy.ToString()).FirstOrDefault()?.Text;
            }

            foreach (var item in filteredList)
            {
                item.UpdateBy = user.User?.Id;
                item.UpdateOn = DateTime.Now;
                item.StatusId = 3;
                item.ReturneeBy = ReturneeBy;
                item.ReturneeByName = returnByName;
                item.ReturnReceiveDate = ReturnReceiveDate;
            }

            var data = new MaterialDetailModel { materialBorrow = new MaterialBorrow(), vMaterialBorrowItems = list, guidPage = guidPage, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vMaterialBorrowItems));
            ViewBag.Mdl = "mdlTab2Detail2";
            return PartialView("_tableAssetBorrowMaterialDetailTab2", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAssetAssetBorrowMaterialDetail(MaterialDetailModel data, string status)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            var jsonList = HttpContext.Session.GetString(data.guidPage);
            var list = JsonConvert.DeserializeObject<List<VMaterialBorrowItem>>(jsonList) ?? new List<VMaterialBorrowItem>();
            data.vMaterialBorrowItems = list;

            if (data.materialBorrow.Id == 0)
            {
                data.materialBorrow.CreateBy = user.User?.Id;
                data.materialBorrow.CreateOn = DateTime.Now;
            }
            else
            {
                data.materialBorrow.UpdateBy = user.User?.Id;
                data.materialBorrow.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAssetAssetBorrowMaterialDetail", content);

            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            }
            HttpContext.Session.Remove(data.guidPage);
            TempData["success"] = "บันทึกสำเร็จ";
            return RedirectToAction("AssetBorrowMaterialList", "Asset");

        }
        #endregion

        #region หน้าจอรายการยืม-คืนครุภัณฑ์
        public async Task<IActionResult> AssetBorrowList()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStatus");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var listMasterStatus = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                ViewBag.GetMasterStatus = listMasterStatus;
            }

            ViewBag.success = TempData["success"];

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetBorrowList(string? AssetBorrowType, int? StatusId, DateTime? DocumentDateFrom, DateTime? DocumentDateTo, string? IsReturn)
        {
            var data = new List<VAssetBorrow>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVAssetBorrowList?DocumentDateFrom={DocumentDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&DocumentDateTo={DocumentDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}" +
                $"&IsReturn={IsReturn}&AssetBorrowType={AssetBorrowType}&StatusId={StatusId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAssetBorrow>>(json) ?? new List<VAssetBorrow>();
            }
            return PartialView("_tableVAssetBorrow", data);
        }

        public async Task<IActionResult> AssetBorrowDetail(int? abId)
        {
            var data = new AssetBorrowDetailModel { assetBorrow = new AssetBorrow(), vAssetBorrowItem = new List<VAssetBorrowItem>() };

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVOfficer");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var listOfficer = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                ViewBag.Officer = listOfficer;
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.OrganizationId = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            if (abId != null)
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetBorrowDetail?abId={abId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<AssetBorrowDetailModel>(json) ?? new AssetBorrowDetailModel();
                }
            }

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.vAssetBorrowItem));

            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> SearchVAsset(string? AssetNumberGFMIS, string? Code, string guidPage)
        {
            var data = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVAsset?Code={Code}&AssetNumberGFMIS={AssetNumberGFMIS}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
            }
            ViewBag.guidPage = guidPage;
            ViewBag.transfer = false;
            return PartialView("_tableVAssetCheckList", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveVAssetSelect(List<int> lstId, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetBorrowItem>>(jsonList) ?? new List<VAssetBorrowItem>();

            var data = new AssetBorrowDetailModel { assetBorrow = new AssetBorrow(), vAssetBorrowItem = list, guidPage = guidPage, changeData = true };

            var lst = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVAsset");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                lst = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
                lst = lst.Where(x => lstId.Contains(x.Id)).ToList();
            }
            var user = new Appz(HttpContext).CurrentSignInUser;

            foreach (var item in lst)
            {
                data.vAssetBorrowItem.Add(new VAssetBorrowItem
                {
                    CreateBy = user.User?.Id,
                    CreateOn = DateTime.Now,
                    AssetId = item.Id,
                    IsUsable = item.IsUsable,
                    AssetName = item.AssetName,
                    Code = item.Code,
                    SerialNumber = item.SerialNumber,
                    AssetBorrowStatusName = "",
                });
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetBorrowItem));
            return PartialView("_tableAssetBorrowDetailTab1", data);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveVAssetBorrowItem(List<int> lstNo, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetBorrowItem>>(jsonList) ?? new List<VAssetBorrowItem>();

            var filteredList = list.Where((item, index) => !lstNo.Contains(index)).ToList();

            var data = new AssetBorrowDetailModel { assetBorrow = new AssetBorrow(), vAssetBorrowItem = filteredList, guidPage = guidPage, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetBorrowItem));
            return PartialView("_tableAssetBorrowDetailTab1", data);

        }
        [HttpPost]
        public async Task<IActionResult> SaveAssetBorrowItemReturnTab2(string lstSelectedIds, string guidPage, int ReturnBy, DateTime? ReturnDate)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetBorrowItem>>(jsonList) ?? new List<VAssetBorrowItem>();

            List<int> selectedIdsList = lstSelectedIds.Split(',')
                                             .Select(int.Parse)
                                             .ToList();

            var filteredList = list.Where(x => selectedIdsList.Contains(x.Id)).ToList();

            var user = new Appz(HttpContext).CurrentSignInUser;

            var returnByName = "";
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVOfficer");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var listOfficer = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                returnByName = listOfficer.Where(x => x.Value == ReturnBy.ToString()).FirstOrDefault()?.Text;
            }

            foreach (var item in filteredList)
            {
                item.UpdateBy = user.User?.Id;
                item.UpdateOn = DateTime.Now;
                item.AssetBorrowStatus = "R";
                item.ReturnOfficerId = ReturnBy;
                item.ReturnOfficerName = returnByName;
                item.ReturnDate = ReturnDate;
            }

            var data = new AssetBorrowDetailModel { assetBorrow = new AssetBorrow(), vAssetBorrowItem = list, guidPage = guidPage, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetBorrowItem));
            ViewBag.Mdl = "mdlTab2Detail3";
            return PartialView("_tableAssetBorrowDetailTab2", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAssetBorrowItemReceiveTab2(string lstSelectedIds, string guidPage, int ReturneeBy, DateTime? ReturnReceiveDate)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetBorrowItem>>(jsonList) ?? new List<VAssetBorrowItem>();

            List<int> selectedIdsList = lstSelectedIds.Split(',')
                                             .Select(int.Parse)
                                             .ToList();

            var filteredList = list.Where(x => selectedIdsList.Contains(x.Id)).ToList();

            var user = new Appz(HttpContext).CurrentSignInUser;

            var returnByName = "";
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVOfficer");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var listOfficer = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                returnByName = listOfficer.Where(x => x.Value == ReturneeBy.ToString()).FirstOrDefault()?.Text;
            }

            foreach (var item in filteredList)
            {
                item.UpdateBy = user.User?.Id;
                item.UpdateOn = DateTime.Now;
                item.AssetBorrowStatus = "C";
                item.ReceiveOfficerId = ReturneeBy;
                item.ReceiveOfficerName = returnByName;
                item.ReceiveDate = ReturnReceiveDate;
            }

            var data = new AssetBorrowDetailModel { assetBorrow = new AssetBorrow(), vAssetBorrowItem = list, guidPage = guidPage, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetBorrowItem));
            ViewBag.Mdl = "mdlTab2Detail2";
            return PartialView("_tableAssetBorrowDetailTab2", data);
        }
        [HttpPost]
        public async Task<IActionResult> GetVAssetBorrowItemDetai(int abId, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetBorrowItem>>(jsonList) ?? new List<VAssetBorrowItem>();
            return PartialView("_modalVAssetBorrowItemDetail", list.Where(x => x.Id == abId).FirstOrDefault());
        }

        [HttpPost]
        public async Task<IActionResult> SaveAssetBorrowDetail(AssetBorrowDetailModel data, string status)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            var jsonList = HttpContext.Session.GetString(data.guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetBorrowItem>>(jsonList) ?? new List<VAssetBorrowItem>();

            data.vAssetBorrowItem = list;

            if (data.assetBorrow.Id == 0)
            {
                data.assetBorrow.CreateBy = user.User?.Id;
                data.assetBorrow.CreateOn = DateTime.Now;
            }
            else
            {
                data.assetBorrow.UpdateBy = user.User?.Id;
                data.assetBorrow.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAssetBorrowDetail", content);

            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            }

            HttpContext.Session.Remove(data.guidPage);
            TempData["success"] = "บันทึกสำเร็จ";
            return RedirectToAction("AssetBorrowList", "Asset");

        }

        #endregion

        #region หน้าจอทะเบียนคุมทรัพย์สิน
        public async Task<IActionResult> AssetDurableArticlesList()
        {
            await LoadDropDownMasterDataAsset();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AssetDurableArticlesList(SearchAssetModel model)
        {
            if (model.IsBelow != "Y") model.IsBelow = "N";
            return await GetAssetList(model);
        }

        public async Task<IActionResult> AssetDurableArticlesDetail(int? asId)
        {
            var data = new AssetDetailModel { asset = new Asset { AssetCategory = "D" } };
            await LoadDropDownMasterDataAsset(true);

            if (asId != null && asId != 0) data = await GetAssetDetail(asId ?? 0, "D");

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data));

            if(data.asset.Code != null)
            {
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(data.asset.Code, QRCodeGenerator.ECCLevel.Q))
                using (PngByteQRCode qrCode = new PngByteQRCode(qrCodeData))
                {
                    byte[] qrCodeImage = qrCode.GetGraphic(20, drawQuietZones: false);
                    string base64Image = Convert.ToBase64String(qrCodeImage);
                    ViewBag.QRCodeImage = "data:image/png;base64," + base64Image;
                }
            }

        

            return View(data);
        }
        public async Task<IActionResult> AssetCarList()
        {
            await LoadDropDownMasterDataAsset();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetCarList(SearchAssetModel model) => await GetAssetList(model);
        public async Task<IActionResult> AssetCarDetail(int? asId)
        {
            var data = new AssetDetailModel { asset = new Asset { AssetCategory = "C" } };
            await LoadDropDownMasterDataAsset(true);

            if (asId != null && asId != 0) data = await GetAssetDetail(asId ?? 0, "C");

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data));

            return View("AssetDurableArticlesDetail", data);
        }
        public async Task<IActionResult> AssetBuildingList()
        {
            await LoadDropDownMasterDataAsset();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetBuildingList(SearchAssetModel model) => await GetAssetList(model);
        public async Task<IActionResult> AssetBuildingDetail(int? asId)
        {
            var data = new AssetDetailModel { asset = new Asset { AssetCategory = "B" } };
            await LoadDropDownMasterDataAsset(true);

            if (asId != null && asId != 0) data = await GetAssetDetail(asId ?? 0, "B");

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data));

            return View("AssetDurableArticlesDetail", data);
        }
        public async Task<IActionResult> AssetIntangibleList()
        {
            await LoadDropDownMasterDataAsset();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetIntangibleList(SearchAssetModel model)
        {
            if (model.IsBelow != "Y") model.IsBelow = "N";
            return await GetAssetList(model);
        }
        public async Task<IActionResult> AssetIntangibleDetail(int? asId)
        {
            var data = new AssetDetailModel { asset = new Asset { AssetCategory = "I" } };
            await LoadDropDownMasterDataAsset(true);

            if (asId != null && asId != 0) data = await GetAssetDetail(asId ?? 0, "I");

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data));

            return View("AssetDurableArticlesDetail", data);
        }

        [HttpPost]
        public async Task<IActionResult> DelAsset(int asId)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DeleteAsset?asId={asId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
                if (result.Success) ViewBag.success = "ลบรายการสำเร็จ";
                else ViewBag.error = result.Message;
            }

            ViewBag.submitForm = true;
            return PartialView("_tableVAsset", new List<VAsset>());
        }
        private async Task LoadDropDownMasterDataAsset(bool detail = false)
        {
            ViewBag.MasterAssetType = await GetMasterData("/CMB/GetMasterAssetType");
            ViewBag.MasterAssetClass = await GetMasterData("/CMB/GetMasterAssetClass");
            ViewBag.MasterOrganization = await GetMasterData("/CMB/GetMasterOrganization");
            ViewBag.MasterCostCenter = await GetMasterData("/CMB/GetMasterCostCenter");
            ViewBag.MasterStorePlace = await GetMasterData("/CMB/GetMasterStorePlace");

            if (detail)
            {
                ViewBag.MasterUnit = await GetMasterData("/CMB/GetMasterUnit");
                ViewBag.MasterAssetBudgetType = await GetMasterData("/CMB/GetMasterAssetBudgetType");
                ViewBag.MasterProcurementMethod = await GetMasterData("/CMB/GetMasterProcurementMethod");
                ViewBag.MasterAssetAcquisitionType = await GetMasterData("/CMB/GetMasterAssetAcquisitionType");
                ViewBag.MasterDocumentType = await GetMasterData("/CMB/GetMasterDocumentType?documentGroup=1");
                ViewBag.VOfficer = await GetMasterData("/CMB/GetVOfficer");
                ViewBag.MasterFuelType = await GetMasterData("/CMB/GetMasterFuelType");
                ViewBag.MasterLandType = await GetMasterData("/CMB/GetMasterLandType");
            }


            ViewBag.success = TempData["success"];
            ViewBag.error = TempData["error"];
        }
        private async Task<List<SelectListItem>> GetMasterData(string endpoint)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + endpoint);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return new List<SelectListItem>();
        }
        private async Task<IActionResult> GetAssetList(SearchAssetModel model)
        {
            model.IsExpire ??= "N";
            model.IsAssetNumberGFMIS ??= "N";

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/GetListVAsset", content);
            var data = new List<VAsset>();

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAsset>>(result) ?? new List<VAsset>();
            }

            return PartialView("_tableVAsset", data);
        }
        private async Task<AssetDetailModel> GetAssetDetail(int asId, string type)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetDetail?asId={asId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AssetDetailModel>(json) ?? new AssetDetailModel { asset = new Asset { AssetCategory = type } };
            }
            return new AssetDetailModel { asset = new Asset { AssetCategory = type } };
        }
        [HttpPost]
        public async Task<IActionResult> GetDepreciation(DateTime? DateDepreciation, int asId, bool reset)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            var data = new AssetDetailModel();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi +
                $"/Asset/GetDepreciation?asId={asId}&DateDepreciation={DateDepreciation?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&reset={reset}&userId={user.User.Id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<AssetDetailModel>(json);
            }
            return PartialView("_tableAssetDetailTab2", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAssetDetail(AssetDetailModel model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            var jsonList = HttpContext.Session.GetString(model.guidPage);
            var list = JsonConvert.DeserializeObject<AssetDetailModel>(jsonList) ?? new AssetDetailModel();

            model.vAssetMaintenances = list.vAssetMaintenances ?? new List<VAssetMaintenance>();
            model.vAssetRelations = list.vAssetRelations ?? new List<VAssetRelation>();
            model.userId = user.User.Id;
            if (model.asset.Id == 0)
            {
                model.asset.CreateBy = user.User?.Id;
                model.asset.CreateOn = DateTime.Now;
            }
            else
            {
                model.asset.UpdateBy = user.User?.Id;
                model.asset.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAsset", content);

            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();

                if (apiResults.Success == false && apiResults.Id != null)
                {
                    TempData["error"] = apiResults.Message;
                    if (model.asset.AssetCategory == "D") return RedirectToAction("AssetDurableArticlesDetail", "Asset", new { asId = apiResults.Id });
                    if (model.asset.AssetCategory == "C") return RedirectToAction("AssetCarDetail", "Asset", new { asId = apiResults.Id });
                    if (model.asset.AssetCategory == "B") return RedirectToAction("AssetBuildingDetail", "Asset", new { asId = apiResults.Id });
                    else return RedirectToAction("AssetIntangibleDetail", "Asset", new { asId = apiResults.Id });
                }
            }

            HttpContext.Session.Remove(model.guidPage);
            TempData["success"] = "บันทึกสำเร็จ";

            if (model.asset.AssetCategory == "D") return RedirectToAction("AssetDurableArticlesList", "Asset");
            if (model.asset.AssetCategory == "C") return RedirectToAction("AssetCarList", "Asset");
            if (model.asset.AssetCategory == "B") return RedirectToAction("AssetBuildingList", "Asset");
            else return RedirectToAction("AssetIntangibleList", "Asset");
        }
        [HttpPost]
        public async Task<IActionResult> DelAssetDetail(int asId, string type, string guidPage)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DeleteAsset?asId={asId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
            }

            HttpContext.Session.Remove(guidPage);
            TempData["success"] = "ลบรายการสำเร็จ";

            if (type == "D") return RedirectToAction("AssetDurableArticlesList", "Asset");
            if (type == "C") return RedirectToAction("AssetCarList", "Asset");
            if (type == "B") return RedirectToAction("AssetBuildingList", "Asset");
            else return RedirectToAction("AssetIntangibleList", "Asset");
        }
        [HttpPost]
        public IActionResult AssetMaintenanceDetail(int? rowId, string guidPage, bool read)
        {
            var vam = new VAssetMaintenance();
            if (rowId != null)
            {
                var jsonList = HttpContext.Session.GetString(guidPage);
                var list = JsonConvert.DeserializeObject<AssetDetailModel>(jsonList) ?? new AssetDetailModel();
                var listVam = list.vAssetMaintenances ?? new List<VAssetMaintenance>();
                vam = listVam[rowId ?? 0];
            }

            ViewBag.guidPage = guidPage;
            ViewBag.rowId = rowId;
            ViewBag.read = read;
            return PartialView("_modalVAssetMaintenance", vam);
        }
        [HttpPost]
        public IActionResult SaveVAssetMaintenance(VAssetMaintenance data, string guidPage, int? rowId)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<AssetDetailModel>(jsonList) ?? new AssetDetailModel();

            var user = new Appz(HttpContext).CurrentSignInUser;

            var listVam = list.vAssetMaintenances ?? new List<VAssetMaintenance>();
            if (rowId != null && list.vAssetMaintenances.Count != 0)
            {
                var vam = list.vAssetMaintenances[rowId ?? 0];
                vam.Code = data.Code;
                vam.RequestDate = data.RequestDate;
                vam.ReceiveDate = data.ReceiveDate;
                vam.MaintenanceDetail = data.MaintenanceDetail;
                vam.SupplierName = data.SupplierName;
                vam.SupplierId = data.SupplierId;
                vam.Cost = data.Cost;
                vam.Amount = data.Amount;
                vam.TotalCost = data.TotalCost;
                vam.ApproveDate = data.ApproveDate;
                vam.AccountingDate = data.AccountingDate;
                vam.UpdateBy = user.User.Id;
                vam.UpdateOn = DateTime.Now;
            }
            else
            {
                data.CreateBy = user.User.Id;
                data.CreateOn = DateTime.Now;
                listVam.Add(data);
            }

            var model = new AssetDetailModel { guidPage = guidPage, vAssetMaintenances = listVam, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(model));

            ViewBag.guidPage = guidPage;
            return PartialView("_tableAssetDetailTab3", model);
        }
        [HttpPost]
        public IActionResult RemoveVAssetMaintenance(List<int> lstNo, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<AssetDetailModel>(jsonList) ?? new AssetDetailModel();

            var listVam = list.vAssetMaintenances ?? new List<VAssetMaintenance>();

            var filteredList = listVam.Where((item, index) => !lstNo.Contains(index)).ToList();


            var model = new AssetDetailModel { guidPage = guidPage, vAssetMaintenances = filteredList, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(model));

            ViewBag.guidPage = guidPage;
            return PartialView("_tableAssetDetailTab3", model);
        }
        [HttpPost]
        public async Task<IActionResult> GetTableVAssetGroup(string? vasAssetNumberGFMIS, string? vasCode, int vasAid)
        {
            var data = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVAssetGroup?Code={vasCode}&AssetNumberGFMIS={vasAssetNumberGFMIS}&AsId={vasAid}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
            }
            ViewBag.transfer = false;
            return PartialView("_tableVAssetCheckList", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveVAssetGroupSelect(List<int> lstId, string guidPage, int asId)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var data = JsonConvert.DeserializeObject<AssetDetailModel>(jsonList) ?? new AssetDetailModel();
            data.guidPage = guidPage;
            data.vAssetRelations ??= new List<VAssetRelation>();
            data.changeData = true;
            int? OlaGroup = null;

            var lst = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVAssetGroup?AsId={0}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                lst = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();

                if (asId != 0) OlaGroup = lst.Where(x => x.Id == asId).FirstOrDefault()?.GroupRunning;

                lst = lst.Where(x => lstId.Contains(x.Id)).ToList();
            }
            var user = new Appz(HttpContext).CurrentSignInUser;

            var Grup = true;

            foreach (var item in lst)
            {
                if ((OlaGroup != null && item.GroupRunning != null) && OlaGroup != item.GroupRunning)
                {
                    Grup = false;
                    ViewBag.error = "ไม่สามารถเพิ่มรายการได้ เนื่องจากรายการครุภัณฑ์ที่เลือกถูกจับกลุ่มแล้ว";
                    HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data));
                    return PartialView("_tableAssetDetailTab5", data);
                }

                if (item.GroupRunning != null) OlaGroup = item.GroupRunning;

                data.vAssetRelations.Add(new VAssetRelation
                {
                    CreateBy = user.User?.Id,
                    CreateOn = DateTime.Now,
                    AssetId = item.Id,
                    AssetName = item.AssetName,
                    Code = item.Code,
                    AssetNumberGfmis = item.AssetNumberGfmis,
                });
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data));
            return PartialView("_tableAssetDetailTab5", data);
        }
        [HttpPost]
        public IActionResult RemoveVAssetGroupSelect(List<int> lstNo, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<AssetDetailModel>(jsonList) ?? new AssetDetailModel();

            var lseRl = list.vAssetRelations ?? new List<VAssetRelation>();

            var filteredList = lseRl.Where((item, index) => !lstNo.Contains(index)).ToList();

            var model = new AssetDetailModel { guidPage = guidPage, vAssetRelations = filteredList, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(model));

            ViewBag.guidPage = guidPage;
            return PartialView("_tableAssetDetailTab5", model);
        }


        #endregion

        #region หน้าจอโอนครุภัณฑ์

        public async Task<IActionResult> AssetTransferList()
        {
            ViewBag.MasterStatus = await GetMasterData("/CMB/GetMasterStatus");
            ViewBag.MasterOrganization = await GetMasterData("/CMB/GetMasterOrganization");

            ViewBag.success = TempData["success"];

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AssetTransferList(string? Code, int? StatusId, DateTime? DocumentDateFrom, DateTime? DocumentDateTo, int? TransferOrganizationId, int? DestinationOrganizationId)
        {
            var data = new List<VAssetTransfer>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi +
                $"/Asset/GetListVAssetTransfer?Code={Code}&StatusId={StatusId}&DocumentDateFrom={DocumentDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&DocumentDateTo={DocumentDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&TransferOrganizationId={TransferOrganizationId}&DestinationOrganizationId={DestinationOrganizationId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAssetTransfer>>(json) ?? new List<VAssetTransfer>();
            }
            return PartialView("_tableVAssetTransfer", data);
        }

        [HttpPost]
        public async Task<IActionResult> DelAssetTransfer(int atId)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DeleteAssetTransfer?atId={atId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
                if (result.Success) ViewBag.success = "ลบรายการสำเร็จ";
                else ViewBag.error = result.Message;
            }

            ViewBag.submitForm = true;
            return PartialView("_tableVAssetTransfer", new List<VAssetTransfer>());
        }

        public async Task<IActionResult> AssetTransferDetail(int atId)
        {
            ViewBag.MasterOrganization = await GetMasterData("/CMB/GetMasterOrganization");
            ViewBag.VOfficer = await GetMasterData("/CMB/GetVOfficer");
            ViewBag.MasterStatus = await GetMasterData("/CMB/GetMasterStatus");
            ViewBag.MasterAssetType = await GetMasterData("/CMB/GetMasterAssetType");
            ViewBag.MasterAssetClass = await GetMasterData("/CMB/GetMasterAssetClass");

            var data = new AssetTransferDetailModel { assetTransfer = new AssetTransfer(), vAssetTransferItems = new List<VAssetTransferItem>() };

            if (atId != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetTransferDetail?atId={atId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<AssetTransferDetailModel>(json) ?? new AssetTransferDetailModel();
                }
            }


            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.vAssetTransferItems));
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetListVAssetTransfer(string? AssetNumberGFMIS, string? Code, int? vasAssetTypeId, int? vasAssetClassId)
        {
            var data = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVAssetItemTransfer?Code={Code}&AssetNumberGFMIS={AssetNumberGFMIS}&AssetTypeId={vasAssetTypeId}&AssetClassId={vasAssetClassId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
            }
            ViewBag.transfer = true;
            return PartialView("_tableVAssetCheckList", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveVAssetTransferSelect(List<int> lstId, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetTransferItem>>(jsonList) ?? new List<VAssetTransferItem>();

            var data = new AssetTransferDetailModel { assetTransfer = new AssetTransfer(), vAssetTransferItems = list, guidPage = guidPage, changeData = true };

            var lst = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetListVAsset");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                lst = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
                lst = lst.Where(x => lstId.Contains(x.Id)).ToList();
            }
            var user = new Appz(HttpContext).CurrentSignInUser;

            foreach (var item in lst)
            {
                data.vAssetTransferItems.Add(new VAssetTransferItem
                {
                    CreateBy = user.User?.Id,
                    CreateOn = DateTime.Now,
                    AssetId = item.Id,
                    OldAssetCode = item.Code,
                    OldAssetNumberGfmis = item.AssetNumberGfmis,
                    OldOrganizationId = item.OrganizationId,
                    OldCostCenterId = item.CostCenterId,
                    OldReceiveDate = item.ReceiveDate,
                    OldAssetAcquisitionTypeId = item.Id,
                    OldCurrentBorrowerOfficerId = item.CurrentBorrowerOfficerId,
                    OldCurrentResponsibleOfficerId = item.CurrentResponsibleOfficerId,
                    Code = item.Code,
                    AssetNumberGfmis = item.AssetNumberGfmis,
                    AssetName = item.AssetName,
                    NewAssetAcquisitionTypeId = 5
                });
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetTransferItems));
            return PartialView("_tableAssetTransferDetailTab1", data);
        }

        [HttpPost]
        public IActionResult RemoveVAssetTransferItem(List<int> lstNo, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetTransferItem>>(jsonList) ?? new List<VAssetTransferItem>();

            var filteredList = list.Where((item, index) => !lstNo.Contains(index)).ToList();

            var data = new AssetTransferDetailModel { assetTransfer = new AssetTransfer(), vAssetTransferItems = filteredList, guidPage = guidPage, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetTransferItems));
            return PartialView("_tableAssetTransferDetailTab1", data);

        }

        [HttpPost]
        public async Task<IActionResult> SaveAssetTransferList(AssetTransferDetailModel model, List<string>? TransferDetail)
        {
            var jsonList = HttpContext.Session.GetString(model.guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetTransferItem>>(jsonList) ?? new List<VAssetTransferItem>();
            var user = new Appz(HttpContext).CurrentSignInUser;

            var no = 0; foreach (var item in list)
            {
                item.TransferDetail = TransferDetail[no]; no++;
                if (item.Id != 0)
                {
                    item.UpdateBy = user.User.Id;
                    item.UpdateOn = DateTime.Now;
                }
            }

            if (model.assetTransfer.Id != 0)
            {
                model.assetTransfer.UpdateBy = user.User.Id;
                model.assetTransfer.UpdateOn = DateTime.Now;
            }
            else
            {
                model.assetTransfer.CreateBy = user.User.Id;
                model.assetTransfer.CreateOn = DateTime.Now;
            }

            model.vAssetTransferItems = list;

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAssetTransfer", content);

            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            }

            TempData["success"] = "บันทึกสำเร็จ";
            HttpContext.Session.Remove(model.guidPage);
            return RedirectToAction("AssetTransferList", "Asset");
        }

        public async Task<IActionResult> DelAssetTransferDetail(int atId, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DeleteAssetTransfer?atId={atId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
                if (result.Success) TempData["success"] = "ลบรายการสำเร็จ";
            }

            HttpContext.Session.Remove(guidPage);
            return RedirectToAction("AssetTransferList", "Asset");
        }

        #endregion

        #region หน้าจอส่งคืนครุภัณฑ์
        public async Task<IActionResult> AssetReturnList()
        {
            ViewBag.MasterStatus = await GetMasterData("/CMB/GetMasterStatus");
            ViewBag.success = TempData["success"];

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetReturnList(string? Code, DateTime? ReturnDate, int? StatusId)
        {
            var data = new List<VAssetReturn>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi +
                $"/Asset/GetListVAssetReturn?Code={Code}&StatusId={StatusId}&ReturnDate={ReturnDate?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAssetReturn>>(json) ?? new List<VAssetReturn>();
            }
            return PartialView("_tableVAssetReturn", data);

        }
        [HttpPost]
        public async Task<IActionResult> DelAssetReturn(int arId)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DeleteAssetReturn?arId={arId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
                if (result.Success) ViewBag.success = "ลบรายการสำเร็จ";
                else ViewBag.error = result.Message;
            }

            ViewBag.submitForm = true;
            return PartialView("_tableVAssetReturn", new List<VAssetTransfer>());
        }
        public async Task<IActionResult> AssetReturnDetail(int arId)
        {
            ViewBag.VOfficer = await GetMasterData("/CMB/GetVOfficer");
            ViewBag.MasterStatus = await GetMasterData("/CMB/GetMasterStatus");
            ViewBag.MasterOrganization = await GetMasterData("/CMB/GetMasterOrganization");

            var data = new AssetReturnDetailModel { assetReturn = new AssetReturn(), vAssetReturnItems = new List<VAssetReturnItem>() };

            if (arId != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetReturnDetail?arId={arId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<AssetReturnDetailModel>(json) ?? new AssetReturnDetailModel();
                }
            }

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.vAssetReturnItems));
            return View(data);
        }
        public async Task<IActionResult> GetAssetReturnItem(string guidPage, int? rowId)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var vAssetReturnItems = JsonConvert.DeserializeObject<List<VAssetReturnItem>>(jsonList) ?? new List<VAssetReturnItem>();

            var data = rowId != null ? vAssetReturnItems[rowId.Value] : new VAssetReturnItem();

            ViewBag.guidPage = guidPage;
            ViewBag.rowId = rowId;
            return PartialView("_modalAssetReturnItem", data);
        }
        public async Task<IActionResult> GetTableVAssetItem(string? vasCode, string? vasAssetNumberGFMIS)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            var data = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi +
                $"/Asset/GetListVAssetCurrentResponsible?Code={vasCode}&AssetNumberGFMIS={vasAssetNumberGFMIS}&OfficerId={user.User.Id}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
            }


            return PartialView("_tableMdlAssetReturnItem", data);
        }
        public async Task<IActionResult> SaveAssetReturnItem(VAssetReturnItem model, string guidPage, int? rowId)
        {
            var data = new AssetReturnDetailModel { assetReturn = new AssetReturn(), guidPage = guidPage, changeData = true };
            var jsonList = HttpContext.Session.GetString(guidPage);
            data.vAssetReturnItems = JsonConvert.DeserializeObject<List<VAssetReturnItem>>(jsonList) ?? new List<VAssetReturnItem>();

            var asset = new VAsset();

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetVAssetById?Id={model.AssetId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                asset = JsonConvert.DeserializeObject<VAsset>(json) ?? new VAsset();
            }

            if (rowId == null)
            {
                data.vAssetReturnItems.Add(new VAssetReturnItem
                {
                    AssetId = model.AssetId,
                    Code = model.Code,
                    AssetNumberGfmis = model.AssetNumberGfmis,
                    Amount = model.Amount,
                    Cost = model.Cost,
                    IsUsable = model.IsUsable,
                    ReturnDetail = model.ReturnDetail,
                    AssetName = asset.AssetName,
                    UnitName = asset.UnitName,
                    Usable = model.IsUsable.Value ? "ใช้งานได้แต่หมดความจำเป็นใช้งาน" : "ชำรุด",
                    UnitId = asset.UnitId
                });
            }
            else
            {
                var newdata = data.vAssetReturnItems[rowId.Value];
                newdata.AssetId = model.AssetId;
                newdata.Code = model.Code;
                newdata.AssetNumberGfmis = model.AssetNumberGfmis;
                newdata.Amount = model.Amount;
                newdata.Cost = model.Cost;
                newdata.IsUsable = model.IsUsable;
                newdata.ReturnDetail = model.ReturnDetail;
                newdata.Usable = model.IsUsable.Value ? "ใช้งานได้แต่หมดความจำเป็นใช้งาน" : "ชำรุด";
                newdata.UnitId = asset.UnitId;
            }

            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.vAssetReturnItems));
            return PartialView("_tableAssetReturnDetailTab1", data);
        }
        [HttpPost]
        public IActionResult RemoveVAssetReturnItem(List<int> lstNo, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetReturnItem>>(jsonList) ?? new List<VAssetReturnItem>();

            var filteredList = list.Where((item, index) => !lstNo.Contains(index)).ToList();

            var data = new AssetReturnDetailModel { assetReturn = new AssetReturn(), vAssetReturnItems = filteredList, guidPage = guidPage, changeData = true };
            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetReturnItems));
            return PartialView("_tableAssetReturnDetailTab1", data);

        }
        [HttpPost]
        public async Task<IActionResult> SaveAssetReturn(AssetReturnDetailModel model, List<bool> lstIscheck)
        {
            var jsonList = HttpContext.Session.GetString(model.guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetReturnItem>>(jsonList) ?? new List<VAssetReturnItem>();
            var user = new Appz(HttpContext).CurrentSignInUser;

            var no = 0; foreach (var item in list)
            {
                item.Ischeck = lstIscheck[no]; no++;
                if (item.Id != 0)
                {
                    item.UpdateBy = user.User.Id;
                    item.UpdateOn = DateTime.Now;
                }
            }

            if (model.assetReturn.Id != 0)
            {
                model.assetReturn.UpdateBy = user.User.Id;
                model.assetReturn.UpdateOn = DateTime.Now;
            }
            else
            {
                model.assetReturn.CreateBy = user.User.Id;
                model.assetReturn.CreateOn = DateTime.Now;
            }

            model.vAssetReturnItems = list;

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAssetReturn", content);

            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            }

            TempData["success"] = "บันทึกสำเร็จ";
            HttpContext.Session.Remove(model.guidPage);
            return RedirectToAction("AssetReturnList", "Asset");
        }
        public async Task<IActionResult> DelAssetReturnDetail(int arId, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DeleteAssetReturn?arId={arId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
                if (result.Success) TempData["success"] = "ลบรายการสำเร็จ";
            }

            HttpContext.Session.Remove(guidPage);
            return RedirectToAction("AssetReturnList", "Asset");
        }

        #endregion

        #region หน้าจอตัดจำหน่ายทรัพย์สิน
        public IActionResult AssetWriteOffList()
        {
            ViewBag.success = TempData["success"];

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetWriteOffList(int? BudgetYear, string? Code, DateTime? WriteOffDateFrom, DateTime? WriteOffDateTo, string? WriteOffType, string? StatusId)
        {
            var data = new List<VAssetWriteOff>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi +
                $"/Asset/GetListVAssetWriteOff" +
                $"?BudgetYear={BudgetYear}" +
                $"&Code={Code}" +
                $"&WriteOffDateFrom={WriteOffDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}" +
                $"&WriteOffDateTo={WriteOffDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}" +
                $"&StatusId={StatusId}" +
                $"&WriteOffType={WriteOffType}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAssetWriteOff>>(json) ?? new List<VAssetWriteOff>();
            }
            return PartialView("_tableVAssetWriteOff", data);

        }

        [HttpPost]
        public async Task<IActionResult> DelAssetWriteOff(int awId)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DelAssetWriteOff?awId={awId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
                if (result.Success) ViewBag.success = "ลบรายการสำเร็จ";
                else ViewBag.error = result.Message;
            }

            ViewBag.submitForm = true;
            return PartialView("_tableVAssetWriteOff", new List<VAssetWriteOff>());
        }

        public async Task<IActionResult> AssetWriteOffDetail(int awId)
        {
            ViewBag.MasterWriteOffType = await GetMasterData("/CMB/GetMasterWriteOffType");
            ViewBag.MasterOrganization = await GetMasterData("/CMB/GetMasterOrganization");

            var data = new AssetWriteOffDetailModel { assetWriteOff = new AssetWriteOff(), vAssetWriteOffItems = new List<VAssetWriteOffItem>() };

            if (awId != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetWriteOffDetail?awId={awId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<AssetWriteOffDetailModel>(json) ?? new AssetWriteOffDetailModel();
                }
            }

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.vAssetWriteOffItems));
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> GetTableWriteOffVAsset(string? vasAssetNumberGFMIS, string? vasCode, DateTime? vasApproveDateFrom, DateTime? vasApproveDateTo, string? vasIsExpire)
        {
            var data = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetTableWriteOffVAsset" +
                $"?Code={vasCode}" +
                $"&AssetNumberGFMIS={vasAssetNumberGFMIS}" +
                $"&vasApproveDateFrom={vasApproveDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}" +
                $"&vasApproveDateTo={vasApproveDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}" +
                $"&vasIsExpire={vasIsExpire}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
            }
            ViewBag.writeOff = true;
            return PartialView("_tableVAssetCheckList", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveVAssetWriteOffVAssetSelect(List<int> lstId, string guidPage)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            var jsonList = HttpContext.Session.GetString(guidPage);
            var data = new AssetWriteOffDetailModel { assetWriteOff = new AssetWriteOff(), changeData = true, guidPage = guidPage, vAssetWriteOffItems = JsonConvert.DeserializeObject<List<VAssetWriteOffItem>>(jsonList) ?? new List<VAssetWriteOffItem>() };
            data.guidPage = guidPage;
            data.changeData = true;

            var lst = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetTableWriteOffVAsset");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                lst = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
                lst = lst.Where(x => lstId.Contains(x.Id)).ToList();
            }

            foreach (var item in lst)
            {
                data.vAssetWriteOffItems.Add(new VAssetWriteOffItem
                {
                    CreateBy = user.User?.Id,
                    CreateOn = DateTime.Now,
                    AssetId = item.Id,
                    AssetName = item.AssetName,
                    Code = item.Code,
                    AssetNumberGfmis = item.AssetNumberGfmis,
                });
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetWriteOffItems));
            return PartialView("_tableAssetWriteOffListTab1", data);
        }

        [HttpPost]
        public IActionResult RemoveVAssetWriteOffVAssetSelect(List<int> lstNo, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var data = new AssetWriteOffDetailModel { assetWriteOff = new AssetWriteOff(), changeData = true, guidPage = guidPage, vAssetWriteOffItems = JsonConvert.DeserializeObject<List<VAssetWriteOffItem>>(jsonList) ?? new List<VAssetWriteOffItem>() };

            var lseRl = data.vAssetWriteOffItems ?? new List<VAssetWriteOffItem>();

            var filteredList = lseRl.Where((item, index) => !lstNo.Contains(index)).ToList();

            data.vAssetWriteOffItems = filteredList;

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetWriteOffItems));

            ViewBag.guidPage = guidPage;
            return PartialView("_tableAssetWriteOffListTab1", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveAssetWriteOff(AssetWriteOffDetailModel model)
        {
            var jsonList = HttpContext.Session.GetString(model.guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetWriteOffItem>>(jsonList) ?? new List<VAssetWriteOffItem>();

            var user = new Appz(HttpContext).CurrentSignInUser;
            model.userId = user.User.Id;

            if (model.assetWriteOff.Id != 0)
            {
                model.assetWriteOff.UpdateBy = user.User.Id;
                model.assetWriteOff.UpdateOn = DateTime.Now;
            }
            else
            {
                model.assetWriteOff.CreateBy = user.User.Id;
                model.assetWriteOff.CreateOn = DateTime.Now;
            }

            var n = 0;
            foreach (var item in list)
            {
                item.IsUsable = model.vAssetWriteOffItems[n].IsUsable;
                item.UnusableDetail = model.vAssetWriteOffItems[n].UnusableDetail;
                item.Remark = model.vAssetWriteOffItems[n].Remark;
                n++;
            }

            model.vAssetWriteOffItems = list;

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAssetWriteOff", content);

            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            }

            TempData["success"] = model.assetWriteOff.WriteOffStatus == "C" ? "ยืนยันสำเร็จ" : "บันทึกสำเร็จ";
            HttpContext.Session.Remove(model.guidPage);
            return RedirectToAction("AssetWriteOffList", "Asset");
        }


        #endregion

        #region หน้าจอรายการเบิกจ่ายครุภัณฑ์
        public async Task<IActionResult> AssetRequisitionDurableArticlesList()
        {
            ViewBag.MasterStatus = await GetMasterData("/CMB/GetMasterStatus");
            ViewBag.MasterOrganization = await GetMasterData("/CMB/GetMasterOrganization");

            ViewBag.success = TempData["success"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetRequisitionDurableArticlesList(string? Code, DateTime? RequestDateFrom, DateTime? RequestDateTo, int? StatusId, int? RequestOrganizationId)
        {
            var data = new List<VAssetRequisition>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi +
                $"/Asset/GetListVAssetRequisition?Code={Code}" +
                $"&StatusId={StatusId}" +
                $"&RequestOrganizationId={RequestOrganizationId}" +
                $"&RequestDateFrom={RequestDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}" +
                $"&RequestDateTo={RequestDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAssetRequisition>>(json) ?? new List<VAssetRequisition>();
            }
            return PartialView("_tableAssetRequisition", data);

        }
        [HttpPost]
        public async Task<IActionResult> DelAssetRequisition(int arId)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DelAssetRequisition?arId={arId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
                if (result.Success) ViewBag.success = "ลบรายการสำเร็จ";
                else ViewBag.error = result.Message;
            }

            ViewBag.submitForm = true;
            return PartialView("_tableAssetRequisition", new List<VAssetRequisition>());
        }
        public async Task<IActionResult> AssetRequisitionDurableArticlesDetail(int? arId)
        {
            ViewBag.MasterStatus = await GetMasterData("/CMB/GetMasterStatus");
            ViewBag.VOfficer = await GetMasterData("/CMB/GetVOfficer");
            ViewBag.MasterOrganization = await GetMasterData("/CMB/GetMasterOrganization");

            var data = new AssetRequisitionDetailModel { assetRequisition = new AssetRequisition(), vAssetRequisitionItems = new List<VAssetRequisitionItem>() };

            if (arId != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetRequisitionDetail?arId={arId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<AssetRequisitionDetailModel>(json) ?? new AssetRequisitionDetailModel();
                }
            }

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.vAssetRequisitionItems));
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> GetTableRequisitionVAsset(string? vasAssetNumberGFMIS, string? vasCode, DateTime? vasReceiveDateFrom, DateTime? vasReceiveDateTo, int? vasOrganizationId)
        {
            var data = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetTableRequisitionVAsset" +
                $"?Code={vasCode}" +
                $"&AssetNumberGFMIS={vasAssetNumberGFMIS}" +
                $"&vasReceiveDateFrom={vasReceiveDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}" +
                $"&vasReceiveDateTo={vasReceiveDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}" +
                $"&vasOrganizationId={vasOrganizationId}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
            }
            ViewBag.requisition = true;
            return PartialView("_tableVAssetCheckList", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveVAssetRequisitionVAssetSelect(List<int> lstId, string guidPage)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            var jsonList = HttpContext.Session.GetString(guidPage);
            var data = new AssetRequisitionDetailModel { assetRequisition = new AssetRequisition(), changeData = true, guidPage = guidPage, vAssetRequisitionItems = JsonConvert.DeserializeObject<List<VAssetRequisitionItem>>(jsonList) ?? new List<VAssetRequisitionItem>() };
            data.guidPage = guidPage;
            data.changeData = true;

            var lst = new List<VAsset>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetTableRequisitionVAsset");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                lst = JsonConvert.DeserializeObject<List<VAsset>>(json) ?? new List<VAsset>();
                lst = lst.Where(x => lstId.Contains(x.Id)).ToList();
            }

            foreach (var item in lst)
            {
                data.vAssetRequisitionItems.Add(new VAssetRequisitionItem
                {
                    CreateBy = user.User?.Id,
                    CreateOn = DateTime.Now,
                    AssetId = item.Id,
                    AssetName = item.AssetName,
                    Code = item.Code,
                    AssetNumberGfmis = item.AssetNumberGfmis,
                });
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetRequisitionItems));
            return PartialView("_tableAssetRequisitionListTab1", data);
        }
        [HttpPost]
        public IActionResult RemoveVAssetRequisitionVAssetSelect(List<int> lstNo, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var data = new AssetRequisitionDetailModel { assetRequisition = new AssetRequisition(), changeData = true, guidPage = guidPage, vAssetRequisitionItems = JsonConvert.DeserializeObject<List<VAssetRequisitionItem>>(jsonList) ?? new List<VAssetRequisitionItem>() };

            var lseRl = data.vAssetRequisitionItems ?? new List<VAssetRequisitionItem>();

            var filteredList = lseRl.Where((item, index) => !lstNo.Contains(index)).ToList();

            data.vAssetRequisitionItems = filteredList;

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.vAssetRequisitionItems));

            ViewBag.guidPage = guidPage;
            return PartialView("_tableAssetRequisitionListTab1", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAssetRequisition(AssetRequisitionDetailModel model, List<string> lstRemark)
        {
            var jsonList = HttpContext.Session.GetString(model.guidPage);
            var list = JsonConvert.DeserializeObject<List<VAssetRequisitionItem>>(jsonList) ?? new List<VAssetRequisitionItem>();

            var user = new Appz(HttpContext).CurrentSignInUser;
            model.userId = user.User.Id;

            if (model.assetRequisition.Id != 0)
            {
                model.assetRequisition.UpdateBy = user.User.Id;
                model.assetRequisition.UpdateOn = DateTime.Now;
            }
            else
            {
                model.assetRequisition.CreateBy = user.User.Id;
                model.assetRequisition.CreateOn = DateTime.Now;
            }

            var n = 0;
            foreach (var item in list) { item.Remark = lstRemark[n]; n++; }

            model.vAssetRequisitionItems = list;

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAssetRequisition", content);

            var apiResults = new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            }

            TempData["success"] = "บันทึกสำเร็จ";
            HttpContext.Session.Remove(model.guidPage);
            return RedirectToAction("AssetRequisitionDurableArticlesList", "Asset");
        }
        public async Task<IActionResult> DelAssetRequisitionDetail(int arId, string guidPage)
        {
            var jsonList = HttpContext.Session.GetString(guidPage);
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DelAssetRequisition?arId={arId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();
                if (result.Success) TempData["success"] = "ลบรายการสำเร็จ";
            }

            HttpContext.Session.Remove(guidPage);
            return RedirectToAction("AssetRequisitionDurableArticlesList", "Asset");
        }
        #endregion

        #region รายการตรวจสอบประจำปี
        public IActionResult AssetInspectionList()
        {
            ViewBag.success = TempData["success"];

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssetInspectionList(string? Code, int? BudgetYear, string? AnnualCheckStatus)
        {
            var data = new List<VAnnualCheck>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi +
                $"/Asset/GetListVAnnualCheck" +
                $"?BudgetYear={BudgetYear}" +
                $"&Code={Code}" +
                $"&WriteOffType={AnnualCheckStatus}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAnnualCheck>>(json) ?? new List<VAnnualCheck>();
            }
            return PartialView("_tableVAnnualCheck", data);
        }
        public IActionResult AssetInspectionCentralDetail()
        {
            return View();
        }
        public IActionResult AssetInspectionOrganizationDetail()
        {
            return View();
        }
        public IActionResult AssetInspectionOrganizationDurableArticlesDetail()
        {
            return View();
        }

        public IActionResult AssetParcelReceiveOrganizationDetail()
        {
            return View();
        }
        #endregion

        #region หน้าจอทะเบียนคุมทรัพย์สิน
        public async Task<IActionResult> AssetRepairList()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStatus");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterStatus = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            ViewBag.success = TempData["success"];

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AssetRepairList(string? Code, int? StatusId, DateTime? DocumentDateFrom, DateTime? DocumentDateTo, int? TransferOrganizationId, int? DestinationOrganizationId)
        {
            var data = new List<VAssetTransfer>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi +
                $"/Asset/GetListVAssetMaintenanceForm?Code={Code}&StatusId={StatusId}&DocumentDateFrom={DocumentDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&DocumentDateTo={DocumentDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&TransferOrganizationId={TransferOrganizationId}&DestinationOrganizationId={DestinationOrganizationId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VAssetTransfer>>(json) ?? new List<VAssetTransfer>();
            }
            return PartialView("_tableVAssetTransfer", data);
        }

        public IActionResult AssetRepairDetail()
        {
            return View();
        }
        #endregion










        #region 1.หน้าจอรายการเบิกจ่ายวัสดุจากหน่วยจัดซื้อ [AssetRequisitionMaterialCentralList]      
        public async Task<IActionResult> AssetRequisitionMaterialCentralList()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStatus");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterStatus = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            if (TempData["success"] != "")
            {
                ViewBag.success = TempData["success"];
                ViewBag.error = null;
            }
            else if (TempData["error"] != "")
            {
                ViewBag.error = TempData["error"];
                ViewBag.success = null;
            }


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AssetRequisitionMaterialCentralList(string? Code, int? StatusId, DateTime? RequestDateFrom, DateTime? RequestDateTo, int? OrganizationId)
        {
            int RequestType = 1;
            var data = new List<VMaterialRequisition>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialRequisitionMaterialCentral?requestType={RequestType}&code={Code}&statusId={StatusId}&requestDateFrom={RequestDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&RequestDateTo={RequestDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&organizationId={OrganizationId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialRequisition>>(json) ?? new List<VMaterialRequisition>();
            }
            return PartialView("_tableAssetRequisitionMaterialCentral", data.OrderByDescending(x => x.CreateOn).ToList());
        }
        public async Task<IActionResult> AssetRequisitionMaterialCentralDetail(int? materialRId, bool? success, string? error)
        {
            var data = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition(), lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>() };


            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVOfficer");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.Officer = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            int? organizationId = 0;
            if (materialRId != null && materialRId != 0)
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetRequisitionMaterialCentralDetailModel?id={materialRId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<AssetRequisitionMaterialCentralDetailModel>(json) ?? data;

                    if (data.materialRequisition.OrganizationId != null && data.materialRequisition.OrganizationId != 0)
                    {
                        organizationId = data.materialRequisition.OrganizationId;
                    }
                }
            }
            else
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouse");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    ViewBag.MasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                }

                // Set New materialRequisition
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/SetNewAssetRequisitionMaterialCentralDetailModel");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<AssetRequisitionMaterialCentralDetailModel>(json) ?? data;
                }
            }

            if (organizationId != 0)
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouseByOrganizationId?organizationId={organizationId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    ViewBag.MasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                }
            }
            else
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouse");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    ViewBag.MasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                }
            }

            if (success != null)
            {
                if (success == true) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = error;
            }

            data.guidPage = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(data.guidPage, JsonConvert.SerializeObject(data.lstVMaterialRequisitionItem));

            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> SelectMaterialStockToTableItem(string[] arrayRMItem, int requisitionId, string guidPage)
        {

            int Id;
            int MaterialStockId;
            int RequestAmount;
            int ReceiveAmount;
            string Remark;
            string str1Row = string.Empty;
            string[] arrSplit;
            bool chkInDB;

            var data = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition(), lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>() };

            var dataMatStock = new VMaterialStock();
            if (arrayRMItem != null && arrayRMItem.Length > 0)
            {
                for (var i = 0; i < arrayRMItem.Length; i++)
                {
                    str1Row = arrayRMItem[i];
                    arrSplit = str1Row.Split(',');
                    if (arrSplit != null && arrSplit.Length > 0)
                    {
                        chkInDB = false;
                        Id = Convert.ToInt32(arrSplit[0]);
                        MaterialStockId = Convert.ToInt32(arrSplit[1]);
                        RequestAmount = Convert.ToInt32(arrSplit[2]);
                        ReceiveAmount = Convert.ToInt32(arrSplit[3]);
                        Remark = arrSplit[4];

                        var dataMatRItem = new VMaterialRequisitionItem();

                        if (Id != 0)
                        {
                            //get from MaterialRequisitionItem
                            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialRequisitionItem?id={Id}");
                            if (response1.IsSuccessStatusCode)
                            {
                                var json = await response1.Content.ReadAsStringAsync();
                                dataMatRItem = JsonConvert.DeserializeObject<VMaterialRequisitionItem>(json) ?? dataMatRItem;
                                dataMatRItem.RequestAmount = RequestAmount;
                                dataMatRItem.ReceiveAmount = ReceiveAmount;
                                dataMatRItem.Remark = Remark;
                                data.lstVMaterialRequisitionItem.Add(dataMatRItem);
                            }
                        }
                        else
                        {
                            //check MaterialRequisitionItem ว่าที่เพิ่มมาใหม่จาก MaterialStcok Popup มีในDBอยู่แล้ว (แต่ถูกRemoveไประหว่าง Process) มั้ย ถ้ามีก็เอาค่าเก่าที่บันทึกแล้วจาก DB มาแสดงให้ User
                            var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialRequisitionItemByConditions?requisitionId={requisitionId}&materialStockId={MaterialStockId}");
                            if (response2.IsSuccessStatusCode)
                            {
                                var json = await response2.Content.ReadAsStringAsync();
                                dataMatRItem = JsonConvert.DeserializeObject<VMaterialRequisitionItem>(json) ?? dataMatRItem;
                                if (dataMatRItem.Id != 0)
                                {
                                    chkInDB = true;
                                    if (dataMatRItem.RequestAmount == null)
                                    {
                                        dataMatRItem.RequestAmount = 0;
                                    }
                                    if (dataMatRItem.ReceiveAmount == null)
                                    {
                                        dataMatRItem.ReceiveAmount = 0;
                                    }

                                    data.lstVMaterialRequisitionItem.Add(dataMatRItem);
                                }
                            }

                            if (chkInDB == false)
                            {
                                //get from MaterialStock                       
                                var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetVMaterialStock?id={MaterialStockId}");
                                if (response1.IsSuccessStatusCode)
                                {
                                    var json = await response1.Content.ReadAsStringAsync();
                                    dataMatStock = JsonConvert.DeserializeObject<VMaterialStock>(json) ?? dataMatStock;

                                    dataMatRItem.RequisitionId = requisitionId;
                                    dataMatRItem.MaterialId = dataMatStock.MaterialId;
                                    dataMatRItem.MaterialStockId = dataMatStock.Id;
                                    dataMatRItem.Gpsccode = dataMatStock.Gpsccode;
                                    dataMatRItem.UnitId = dataMatStock.UnitId;
                                    dataMatRItem.UnitPrice = dataMatStock.UnitPrice;
                                    dataMatRItem.TotalPrice = dataMatStock.TotalPrice;
                                    dataMatRItem.MaterialInItemId = dataMatStock.MaterialInItemId;
                                    dataMatRItem.MaterialName = dataMatStock.MaterialName;
                                    dataMatRItem.UnitName = dataMatStock.UnitName;
                                    dataMatRItem.Available = dataMatStock.Available;
                                    dataMatRItem.RequestAmount = RequestAmount;
                                    dataMatRItem.ReceiveAmount = ReceiveAmount;
                                    dataMatRItem.Remark = Remark;

                                    data.lstVMaterialRequisitionItem.Add(dataMatRItem);
                                }
                            }
                        }
                    }
                }
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.lstVMaterialRequisitionItem));
            ViewBag.guidPage = guidPage;
            ViewBag.hideModal = "mdlMaterialStock";
            return PartialView("_tableAssetRequisitionMaterialCentralItem", data);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveSelctMaterialStock(string[] arrayRMItem, int requisitionId, string guidPage)
        {
            int Id;
            int MaterialStockId;
            int RequestAmount;
            int ReceiveAmount;
            string Remark;
            string str1Row = string.Empty;
            string[] arrSplit;

            var data = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition(), lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>() };

            var dataMatStock = new VMaterialStock();
            if (arrayRMItem != null && arrayRMItem.Length > 0)
            {
                for (var i = 0; i < arrayRMItem.Length; i++)
                {
                    str1Row = arrayRMItem[i];
                    arrSplit = str1Row.Split(',');
                    if (arrSplit != null && arrSplit.Length > 0)
                    {
                        Id = Convert.ToInt32(arrSplit[0]);
                        MaterialStockId = Convert.ToInt32(arrSplit[1]);
                        RequestAmount = Convert.ToInt32(arrSplit[2]);
                        ReceiveAmount = Convert.ToInt32(arrSplit[3]);
                        Remark = arrSplit[4];

                        var dataMatRItem = new VMaterialRequisitionItem();

                        if (Id != 0)
                        {
                            //get from MaterialRequisitionItem
                            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialRequisitionItem?id={Id}");
                            if (response1.IsSuccessStatusCode)
                            {
                                var json = await response1.Content.ReadAsStringAsync();
                                dataMatRItem = JsonConvert.DeserializeObject<VMaterialRequisitionItem>(json) ?? dataMatRItem;
                                dataMatRItem.RequestAmount = RequestAmount;
                                dataMatRItem.ReceiveAmount = ReceiveAmount;
                                dataMatRItem.Remark = Remark;
                                data.lstVMaterialRequisitionItem.Add(dataMatRItem);
                            }
                        }
                        else
                        {
                            //get from MaterialStock                       
                            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetVMaterialStock?id={MaterialStockId}");
                            if (response1.IsSuccessStatusCode)
                            {
                                var json = await response1.Content.ReadAsStringAsync();
                                dataMatStock = JsonConvert.DeserializeObject<VMaterialStock>(json) ?? dataMatStock;

                                dataMatRItem.RequisitionId = requisitionId;
                                dataMatRItem.MaterialId = dataMatStock.MaterialId;
                                dataMatRItem.MaterialStockId = dataMatStock.Id;
                                dataMatRItem.Gpsccode = dataMatStock.Gpsccode;
                                dataMatRItem.UnitId = dataMatStock.UnitId;
                                dataMatRItem.UnitPrice = dataMatStock.UnitPrice;
                                dataMatRItem.TotalPrice = dataMatStock.TotalPrice;
                                dataMatRItem.MaterialInItemId = dataMatStock.MaterialInItemId;
                                dataMatRItem.MaterialName = dataMatStock.MaterialName;
                                dataMatRItem.UnitName = dataMatStock.UnitName;
                                dataMatRItem.Available = dataMatStock.Available;
                                dataMatRItem.RequestAmount = RequestAmount;
                                dataMatRItem.ReceiveAmount = ReceiveAmount;
                                dataMatRItem.Remark = Remark;

                                data.lstVMaterialRequisitionItem.Add(dataMatRItem);
                            }
                        }
                    }
                }
            }

            HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(data.lstVMaterialRequisitionItem));
            ViewBag.guidPage = guidPage;
            ViewBag.hideModal = "mdlMaterialStock";
            return PartialView("_tableAssetRequisitionMaterialCentralItem", data);

        }

        [HttpPost]
        public async Task<IActionResult> OpenSelctMaterialStock(int MaterialRequisitionId, string[] arrayRMItem, string guidPage)
        {
            int Id;
            int MaterialStockId;
            string str1Row = string.Empty;
            string[] arrSplit;
            var data3 = new AssetRequisitionMaterialCentralMatStockModel { lstVMaterialStock = new List<VMaterialStock>() };

            //int materialRequisitionId = 1;
            int warehouseId = 1;
            var data = new List<VMaterialStock>();

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/SearchListMaterialStock?warehouseId={warehouseId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialStock>>(json) ?? data;
            }

            //Remove some MaterialStock
            var data1 = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition(), lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>() };
            if (data != null && data.Count > 0)
            {

                //Remove new Item
                if (arrayRMItem != null && arrayRMItem.Length > 0)
                {
                    for (var i = 0; i < arrayRMItem.Length; i++)
                    {
                        str1Row = arrayRMItem[i];
                        arrSplit = str1Row.Split(',');

                        if (arrSplit != null && arrSplit.Length > 0)
                        {
                            Id = Convert.ToInt32(arrSplit[0]);
                            MaterialStockId = Convert.ToInt32(arrSplit[1]);

                            //if (Id == 0)
                            //{
                            var itemToRemove = data.Single(r => r.Id == MaterialStockId);
                            data.Remove(itemToRemove);
                            //}
                        }
                    }
                }
            }

            data3.lstVMaterialStock = data;
            data3.arrayRequisitionMaterialItem = arrayRMItem;
            data3.RequisitionId = MaterialRequisitionId;

            ViewBag.guidPage = guidPage;
            return PartialView("_modalAssetRMCentralMaterialStock", data3);
        }


        [HttpPost]
        public async Task<IActionResult> SearchListMaterialStockByconditions(string? MaterialName, string? Gpsccode, string[] arrayRMItem, int requisitionId)
        {
            int Id;
            int MaterialStockId;
            string str1Row = string.Empty;
            string[] arrSplit;
            var data = new List<VMaterialStock>();
            var data3 = new AssetRequisitionMaterialCentralMatStockModel { lstVMaterialStock = new List<VMaterialStock>() };

            int warehouseId = 1;
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/SearchListMaterialStock?warehouseId={warehouseId}&materialName={MaterialName}&gpsccode={Gpsccode}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialStock>>(json) ?? new List<VMaterialStock>();
            }

            var data1 = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition(), lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>() };
            if (data != null && data.Count > 0)
            {
                //Remove new Item
                if (arrayRMItem != null && arrayRMItem.Length > 0)
                {
                    for (var i = 0; i < arrayRMItem.Length; i++)
                    {
                        str1Row = arrayRMItem[i];
                        arrSplit = str1Row.Split(',');

                        if (arrSplit != null && arrSplit.Length > 0)
                        {
                            Id = Convert.ToInt32(arrSplit[0]);
                            MaterialStockId = Convert.ToInt32(arrSplit[1]);

                            //if (Id == 0)
                            //{
                            var itemToRemove = data.Single(r => r.Id == MaterialStockId);
                            data.Remove(itemToRemove);
                            //}
                        }
                    }
                }
            }

            data3.lstVMaterialStock = data;
            data3.arrayRequisitionMaterialItem = arrayRMItem;
            data3.RequisitionId = requisitionId;

            ViewBag.hideModal = "mdlMaterialStock";
            return PartialView("_tableAssetRMCentralMaterialStock", data3);
        }

        [HttpPost]
        public async Task<IActionResult> SaveAssetRequisitionMaterialCentral(AssetRequisitionMaterialCentralDetailModel data)
        {
            //1.Save Button
            //1.1 Save Update Mode
            //1.1.1 Update MaterialRequisition
            //1.1.1.1 SetOfficerName
            //1.1.2 Update MaterialRequisitionItem 
            //1.1.3 Update AttachFile 

            //1.2 Save Insert Mode
            //1.2.1 Insert MaterialRequisition
            //1.2.1.1 SetOfficerName
            //1.2.2 Insert MaterialRequisitionItem 
            //1.2.3 Insert AttachFile 

            //3. Go to API-Save
            //3.1 API-Save Button

            var user = new Appz(HttpContext).CurrentSignInUser;

            //1.Save Button           

            //1.1.1.1 SetOfficerName
            //1.2.1.1 SetOfficerName
            //Get OfficerName ------------(+)
            var lstOfficer = new List<VOfficer>();
            var response9 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetActiveOfficer");
            if (response9.IsSuccessStatusCode)
            {
                var json = await response9.Content.ReadAsStringAsync();
                lstOfficer = JsonConvert.DeserializeObject<List<VOfficer>>(json) ?? lstOfficer;
                int index;
                if (lstOfficer != null && lstOfficer.Count > 0)
                {
                    index = -1;
                    data.materialRequisition.DeliverApproveOfficerName = "";
                    data.materialRequisition.DeliverOfficerName = "";
                    data.materialRequisition.ReceiveOfficerName = "";

                    if (data.materialRequisition.DeliverApproveOfficerId == 0)
                    {
                        data.materialRequisition.DeliverApproveOfficerId = null;
                    }
                    else
                    {
                        index = lstOfficer.FindIndex(a => a.Id.Equals(data.materialRequisition.DeliverApproveOfficerId));
                        if (index >= 0)
                        {
                            data.materialRequisition.DeliverApproveOfficerName = lstOfficer[index].FullName;
                        }
                    }
                    index = -1;
                    if (data.materialRequisition.DeliverOfficerId == 0)
                    {
                        data.materialRequisition.DeliverOfficerId = null;
                    }
                    else
                    {
                        index = lstOfficer.FindIndex(a => a.Id.Equals(data.materialRequisition.DeliverOfficerId));
                        if (index >= 0)
                        {
                            data.materialRequisition.DeliverOfficerName = lstOfficer[index].FullName;
                        }
                    }
                    index = -1;
                    if (data.materialRequisition.ReceiveOfficerId == 0)
                    {
                        data.materialRequisition.ReceiveOfficerId = null;
                    }
                    else
                    {
                        index = lstOfficer.FindIndex(a => a.Id.Equals(data.materialRequisition.ReceiveOfficerId));
                        if (index >= 0)
                        {
                            data.materialRequisition.ReceiveOfficerName = lstOfficer[index].FullName;
                        }
                    }
                }
            }
            //Get OfficerName ------------(-)

            //1.1.2 Update MaterialRequisitionItem                 
            //1.2.2 Insert MaterialRequisitionItem
            ////MaterialRequisitionItem ---------------(+)            
            if (data.guidPage != null)
            {
                var jsonList = HttpContext.Session.GetString(data.guidPage);
                var list = JsonConvert.DeserializeObject<List<VMaterialRequisitionItem>>(jsonList) ?? new List<VMaterialRequisitionItem>();

                if (list != null && list.Count > 0)
                {
                    data.lstVMaterialRequisitionItem = list;
                }
            }
            //    //MaterialRequisitionItem ---------------(-)

            //    //1.1.3 Update AttachFile 
            //    //1.2.3 Insert AttachFile 
            //}        


            //3. Go to API-Save            
            int materialRIdSaved = 0;
            //if (type == "btnSave")
            //{
            //3.1 API-Save Button               
            if (data.materialRequisition.Id == 0)
            {
                data.materialRequisition.CreateBy = user.User.Id;
                data.materialRequisition.CreateOn = DateTime.Now;
            }
            else
            {
                data.materialRequisition.UpdateBy = user.User.Id;
                data.materialRequisition.UpdateOn = DateTime.Now;
            }

            var json1 = JsonConvert.SerializeObject(data);
            var content = new StringContent(json1, Encoding.UTF8, "application/json");
            var response5 = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAssetRequisitionMaterial", content);
            var result = await response5.Content.ReadAsStringAsync();
            var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            if (response5.IsSuccessStatusCode)
            {
                //data.materialRequisition.Id = apiResults?.Id ?? 0;
                materialRIdSaved = apiResults?.Id ?? 0;
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

                if (apiResults.Success)
                {
                    TempData["success"] = "บันทึกสำเร็จ";
                    TempData["error"] = "";
                }
                else
                {
                    TempData["success"] = "";
                    TempData["error"] = apiResults.Message;
                }
            }
            else
            {
                materialRIdSaved = 0;
            }

            return RedirectToAction("AssetRequisitionMaterialCentralList", "Asset");

        }

        [HttpPost]
        public async Task<IActionResult> ApproveAssetRequisitionMaterialCentral(AssetRequisitionMaterialCentralDetailModel data)
        {

            //2.Approve Button
            //2.1 Update MaterialRequisition
            //2.2 Update MaterialStock Stockเดิม
            //2.3 Insert MaterialStock Stockรายการใหม่
            //2.4 Insert MaterialStockMovement

            //3. Go to API-Save         
            //3.2 API-Approve Button

            var user = new Appz(HttpContext).CurrentSignInUser;
            //var newData = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition(), lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>() };
            var dataApprove = new AssetRequisitionMaterialCentralDetailApprove { lstMaterialStockUpdate = new List<MaterialStock>(), lstMaterialStockInsert = new List<MaterialStock>(), lstMaterialStockMovement = new List<MaterialStockMovement>() };

            if (data.guidPage != null)
            {
                var jsonList = HttpContext.Session.GetString(data.guidPage);
                var list = JsonConvert.DeserializeObject<List<VMaterialRequisitionItem>>(jsonList) ?? new List<VMaterialRequisitionItem>();
                if (list != null && list.Count > 0)
                {
                    data.lstVMaterialRequisitionItem = list;
                }
            }

            if (data.materialRequisition.Id != null && data.materialRequisition.Id != 0)
            {
                //2.1 Update MaterialRequisition                        
                data.materialRequisition.ApproveRequestBy = user.User.Id;
                data.materialRequisition.StatusApprove = "Y";
                data.materialRequisition.ApproveDate = DateTime.Now;
                data.materialRequisition.StatusId = 6; //ยังไม่ Confirm Spec  

                if (data.lstVMaterialRequisitionItem != null && data.lstVMaterialRequisitionItem.Count > 0)
                {
                    int? intMatStock = 0;
                    var dataMatStock = new MaterialStock();
                    var dataMatMovement = new MaterialStockMovement();
                    int? oldAvailable = 0;
                    int? newAvailable = 0;
                    foreach (var itemRItem in data.lstVMaterialRequisitionItem)
                    {
                        //2.2 Update MaterialStock Stockเดิม
                        intMatStock = itemRItem.MaterialStockId;
                        //get from MaterialStock                       
                        var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialStock?id={intMatStock}");
                        if (response1.IsSuccessStatusCode)
                        {
                            var json1 = await response1.Content.ReadAsStringAsync();
                            dataMatStock = JsonConvert.DeserializeObject<MaterialStock>(json1) ?? dataMatStock;
                            oldAvailable = dataMatStock.Available;
                            dataMatStock.UpdateBy = user.User.Id;
                            dataMatStock.UpdateOn = DateTime.Now;
                            dataMatStock.MaterialId = itemRItem.MaterialId;
                            dataMatStock.StockOut = itemRItem.ReceiveAmount;
                            newAvailable = oldAvailable - itemRItem.ReceiveAmount;
                            dataMatStock.Available = newAvailable;
                            dataMatStock.RequisitionId = itemRItem.RequisitionId;
                            dataMatStock.RequisitionItemId = itemRItem.Id;
                            dataApprove.lstMaterialStockUpdate.Add(dataMatStock);

                            //2.3 Insert MaterialStock Stockรายการใหม่
                            dataMatStock = new MaterialStock();
                            dataMatStock.CreateBy = user.User.Id;
                            dataMatStock.CreateOn = DateTime.Now;
                            dataMatStock.MaterialId = itemRItem.MaterialId;
                            dataMatStock.ReceiveDate = data.materialRequisition.ApproveDate;
                            dataMatStock.StockIn = itemRItem.ReceiveAmount;
                            dataMatStock.StockOut = null;
                            dataMatStock.Available = itemRItem.ReceiveAmount;
                            dataMatStock.UnitId = itemRItem.UnitId;
                            dataMatStock.WarehouseId = data.materialRequisition.WarehouseId;
                            dataMatStock.RequisitionId = null;
                            dataMatStock.RequisitionItemId = null;
                            dataMatStock.WarehouseLevel = "2";
                            dataMatStock.UnitPriceNoVat = null;
                            dataMatStock.UnitPrice = itemRItem.UnitPrice;
                            dataMatStock.TotalPrice = itemRItem.TotalPrice;
                            dataApprove.lstMaterialStockInsert.Add(dataMatStock);

                            //2.4 Insert MaterialStockMovement
                            dataMatMovement = new MaterialStockMovement();
                            dataMatMovement.CreateBy = user.User.Id;
                            dataMatMovement.CreateOn = DateTime.Now;
                            dataMatMovement.MaterialId = itemRItem.MaterialId;
                            dataMatMovement.TransactionType = "O";
                            dataMatMovement.ReferenceTable = "MaterialRequisitionItem";
                            dataMatMovement.ReferenceId = itemRItem.Id;
                            dataMatMovement.SourceWareHouseId = 1;
                            dataMatMovement.TargetWareHouseId = data.materialRequisition.WarehouseId;
                            dataMatMovement.SourceMaterialStockId = itemRItem.MaterialStockId;
                            dataMatMovement.TargetMaterialStockId = 0; //MaterialStock.Id ของรายการที่ insert ใหม่จากข้อ 2.ด้านบน
                            dataMatMovement.BeforeSourceMaterial = oldAvailable;
                            dataMatMovement.AfterSourceMaterial = newAvailable;
                            dataMatMovement.BeforeTargetMaterial = null;
                            dataMatMovement.AfterTargetMaterial = itemRItem.ReceiveAmount;
                            dataMatMovement.ProcessDate = DateTime.Now;
                            dataMatMovement.Amount = itemRItem.ReceiveAmount;
                            dataMatMovement.Price = itemRItem.UnitPrice;
                            dataApprove.lstMaterialStockMovement.Add(dataMatMovement);
                        }
                    }
                }
            }
            //}


            //3. Go to API-Save            
            int materialRIdSaved = 0;
            //3.1 API-Save Button               
            if (data.materialRequisition.Id == 0)
            {
                data.materialRequisition.CreateBy = user.User.Id;
                data.materialRequisition.CreateOn = DateTime.Now;
            }
            else
            {
                data.materialRequisition.UpdateBy = user.User.Id;
                data.materialRequisition.UpdateOn = DateTime.Now;
            }

            var blnPass = false;
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/ApproveAssetRMCentralMaterialRequisition", content);
            var result = await response.Content.ReadAsStringAsync();
            var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            if (response.IsSuccessStatusCode)
            {
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

                if (apiResults.Success) blnPass = true;
            }

            if (blnPass == true)
            {
                //ApproveAssetRMCentralMaterialStockMovement
                json = JsonConvert.SerializeObject(dataApprove);
                content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/ApproveAssetRMCentralMaterialStockMovement", content);
                result = await response.Content.ReadAsStringAsync();
                apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (response.IsSuccessStatusCode)
                {
                    if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                    else ViewBag.error = apiResults.Message;

                    if (apiResults.Success) blnPass = true;
                }
            }


            return RedirectToAction("AssetRequisitionMaterialCentralList", "Asset");

        }

        [HttpPost]
        public async Task<IActionResult> DeleteAssetRequisitionMaterialCentral(int materialRId)
        {

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DeleteAssetRequisitionMaterialCentral?Id={materialRId}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "ลบข้อมูลสำเร็จ";
                else ViewBag.error = apiResults.Message;
            }

            int RequestType = 1;
            var data = new List<VMaterialRequisition>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialRequisitionMaterialCentral?requestType={RequestType}");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialRequisition>>(json) ?? new List<VMaterialRequisition>();
            }

            ViewBag.hideModal = "mdlMaterialStock";
            return PartialView("_tableAssetRequisitionMaterialCentral", data.OrderByDescending(x => x.CreateOn).ToList());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAssetRequisitionMaterialCentralDetailView(int asId, string guidPage)
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/DeleteAssetRequisitionMaterialCentral?Id={asId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResultsModel>(json) ?? new ApiResultsModel();

                if (result.Success) ViewBag.success = "ลบข้อมูลสำเร็จ";
                else ViewBag.error = result.Message;

                if (result.Success)
                {
                    TempData["success"] = "ลบข้อมูลสำเร็จ";
                    TempData["error"] = "";
                }
                else
                {
                    TempData["success"] = "";
                    TempData["error"] = result.Message;
                }
            }

            HttpContext.Session.Remove(guidPage);
            TempData["success"] = "ลบรายการสำเร็จ";
            return RedirectToAction("AssetRequisitionMaterialCentralList", "Asset");
        }

        [HttpPost]
        public async Task<IActionResult> SetCMBWarehouse(int organizationId)
        {
            var listItemMasterWarehouse = new List<SelectListItem>();

            if (organizationId != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouseByOrganizationId?organizationId={organizationId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    listItemMasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                }
            }
            else
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetVMasterWarehouse");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    listItemMasterWarehouse = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                }
            }

            return Json(listItemMasterWarehouse);
        }

        [HttpPost]
        public async Task<IActionResult> GetMaterialRequisitionItemInput(int pId, string[] arrayRMItem, string guidPage)
        {
            var lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>();
            if (guidPage != null)
            {
                var jsonList = HttpContext.Session.GetString(guidPage);
                var list = JsonConvert.DeserializeObject<List<VMaterialRequisitionItem>>(jsonList) ?? new List<VMaterialRequisitionItem>();

                if (list != null && list.Count > 0)
                {
                    int index = -1;
                    string str1Row = string.Empty;
                    string[] arrSplit;
                    int MaterialStockId;
                    int RequestAmount;
                    int ReceiveAmount;
                    string Remark;
                    var dataMatStock = new VMaterialStock();
                    if (arrayRMItem != null && arrayRMItem.Length > 0)
                    {
                        for (var i = 0; i < arrayRMItem.Length; i++)
                        {
                            str1Row = arrayRMItem[i];
                            arrSplit = str1Row.Split(',');

                            if (arrSplit != null && arrSplit.Length > 0)
                            {
                                pId = Convert.ToInt32(arrSplit[0]);
                                MaterialStockId = Convert.ToInt32(arrSplit[1]);
                                RequestAmount = Convert.ToInt32(arrSplit[2]);
                                ReceiveAmount = Convert.ToInt32(arrSplit[3]);
                                Remark = arrSplit[4];

                                index = list.FindIndex(a => a.MaterialStockId.Equals(MaterialStockId));
                                if (index > -1)
                                {
                                    list[index].RequestAmount = RequestAmount;
                                    list[index].ReceiveAmount = ReceiveAmount;
                                    list[index].Remark = Remark;
                                }
                            }

                        }
                    }

                    lstVMaterialRequisitionItem = list;
                    HttpContext.Session.SetString(guidPage, JsonConvert.SerializeObject(list));
                    ViewBag.guidPage = guidPage;
                }
            }

            return Json(lstVMaterialRequisitionItem);
        }

        [HttpPost]
        public async Task<IActionResult> OpenModalSendBack(int pId)
        {
            var data = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition(), lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>() };

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetAssetRequisitionMaterialCentralDetailModel?id={pId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<AssetRequisitionMaterialCentralDetailModel>(json) ?? data;
            }

            return PartialView("_modalAssetRMCentralSendBack", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAssetRMCentralSendBack(AssetRequisitionMaterialCentralDetailModel data)
        {

            var user = new Appz(HttpContext).CurrentSignInUser;

            int materialRIdSaved = 0;
            if (data.materialRequisition.Id == 0)
            {
                data.materialRequisition.CreateBy = user.User.Id;
                data.materialRequisition.CreateOn = DateTime.Now;
            }
            else
            {
                data.materialRequisition.UpdateBy = user.User.Id;
                data.materialRequisition.UpdateOn = DateTime.Now;
            }

            var json1 = JsonConvert.SerializeObject(data);
            var content = new StringContent(json1, Encoding.UTF8, "application/json");
            var response5 = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Asset/SaveAssetRMCentralSendBack", content);
            var result = await response5.Content.ReadAsStringAsync();
            var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
            if (response5.IsSuccessStatusCode)
            {
                //data.materialRequisition.Id = apiResults?.Id ?? 0;
                materialRIdSaved = apiResults?.Id ?? 0;
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

                if (apiResults.Success)
                {
                    TempData["success"] = "บันทึกสำเร็จ";
                    TempData["error"] = "";
                }
                else
                {
                    TempData["success"] = "";
                    TempData["error"] = apiResults.Message;
                }
            }
            else
            {
                materialRIdSaved = 0;
            }

            return RedirectToAction("AssetRequisitionMaterialCentralList", "Asset");

        }
        #endregion

        #region 2.หน้าจอรายการเบิกจ่ายวัสดุจากหน่วยงาน [AssetRequisitionMaterialOrganizationList]      
        public async Task<IActionResult> AssetRequisitionMaterialOrganizationList()
        {
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStatus");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterStatus = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response2.IsSuccessStatusCode)
            {
                var json = await response2.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AssetRequisitionMaterialOrganizationList(string? Code, int? StatusId, DateTime? RequestDateFrom, DateTime? RequestDateTo, int? OrganizationId)
        {
            int RequestType = 2;
            var data = new List<VMaterialRequisition>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Asset/GetMaterialRequisitionMaterialOrganization?requestType={RequestType}&code={Code}&statusId={StatusId}&requestDateFrom={RequestDateFrom?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&RequestDateTo={RequestDateTo?.ToString("M/d/yyyy", CultureInfo.InvariantCulture)}&organizationId={OrganizationId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMaterialRequisition>>(json) ?? new List<VMaterialRequisition>();
            }

            return PartialView("_tableAssetRequisitionMaterialOrganization", data.OrderByDescending(x => x.CreateOn).ToList());
        }


        public IActionResult AssetRequisitionMaterialOrganizationDetail()
        {
            return View();
        }
        #endregion

    }

}
