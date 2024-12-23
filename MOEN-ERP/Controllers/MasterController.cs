using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraRichEdit.Import.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MOEN_ERP.Controllers
{
    public class MasterController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly SettingsModel _settingsModels;
        public MasterController(HttpClient httpClient, IOptions<SettingsModel> option)
        {
            _httpClient = httpClient;
            _settingsModels = option.Value;
        }


        #region 1.MasterAssetType
        public IActionResult MasterAssetType()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MasterAssetType(string? NameThai, bool? Active)
        {
            var data = new List<VMasterAssetType>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetType?nameThai={NameThai}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterAssetType>>(json) ?? new List<VMasterAssetType>();
            }
            return PartialView("_tableMasterAssetType", data.OrderBy(x=>x.SequenceNumber).ToList());
        }

        [HttpPost]
        public async Task<IActionResult> MasterAssetTypeDetail(int? AssetTypeId, bool? success, string? error)
        {
            var data = new MasterAssetTypeDetailModel();
            data.MasterAssetType = new MasterAssetType();
            data.ListMasterAssetTypeSub = new List<MasterAssetTypeSub>();
           
            if (AssetTypeId != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterAssetType?Id={AssetTypeId}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterAssetTypeDetailModel>(json) ?? new MasterAssetTypeDetailModel();
                }
              
            }
            if (success != null)
            {
                if (success == true) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = error;
            }

            data.listDelSubId = "0";
            return PartialView("_modalMasterAssetType", data);
        }


        [HttpPost]
        public async Task<IActionResult> SaveNewAssetTypeNotHideModal(string pCode, Boolean pActive, string pNameThai, int pLifeTimeDepreciation, Decimal pDepreciation, int pLifeTimeUse, int pSequenceNumber, DateTime pEffectiveFromDate, DateTime pEffectiveToDate) 
        {
            MasterAssetTypeDetailModel newData = new MasterAssetTypeDetailModel();
            newData.MasterAssetType = new MasterAssetType();
            newData.ListMasterAssetTypeSub = new List<MasterAssetTypeSub>();

            newData.MasterAssetType.Id = 0;
            newData.MasterAssetType.Code = pCode;
            newData.MasterAssetType.Active = pActive;
            newData.MasterAssetType.NameThai = pNameThai;
            newData.MasterAssetType.LifeTimeDepreciation = pLifeTimeDepreciation;
            newData.MasterAssetType.Depreciation = pDepreciation;
            newData.MasterAssetType.LifeTimeUse = pLifeTimeUse;
            newData.MasterAssetType.SequenceNumber = pSequenceNumber;            
            newData.MasterAssetType.EffectiveFromDate = pEffectiveFromDate;                
            newData.MasterAssetType.EffectiveToDate = pEffectiveToDate;           

            var user = new Appz(HttpContext).CurrentSignInUser;
            if (newData.MasterAssetType.Active == null) newData.MasterAssetType.Active = false;
            if (newData.MasterAssetType.Id == 0)
            {
                newData.MasterAssetType.CreateBy = user.User.Id;
                newData.MasterAssetType.CreateOn = DateTime.Now;

            }
            else
            {
                newData.MasterAssetType.UpdateBy = user.User.Id;
                newData.MasterAssetType.UpdateOn = DateTime.Now;
            }

            //Check Duplicate : Code
            var data = new List<VMasterAssetType>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetType?");
            Boolean checkDuplicate = false;
            if (response1.IsSuccessStatusCode)
            {
                var json1 = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterAssetType>>(json1) ?? new List<VMasterAssetType>();

                if (newData.MasterAssetType.Code != null)
                {
                    string? codeData = newData.MasterAssetType.Code;
                    checkDuplicate = data.Exists(x => x.Code == codeData);

                    if (checkDuplicate == true)
                    {
                        checkDuplicate = false;
                        if (newData.MasterAssetType.Id != 0) // Edit Mode
                        {
                            var item = new VMasterAssetType();
                            item = data.FirstOrDefault(x => x.Code == codeData);
                            if (item != null && item.Id != newData.MasterAssetType.Id)
                            {
                                checkDuplicate = true;
                                ViewBag.error = "Code is duplicated.";
                            }
                        }
                        else
                        {
                            checkDuplicate = true;
                            ViewBag.error = "Code is duplicated.";
                        }
                    }
                }

            }

            //Check Duplicate : SequenceNumber       
            if (checkDuplicate == false)
            {
                if (response1.IsSuccessStatusCode)
                {
                    var json1 = await response1.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<List<VMasterAssetType>>(json1) ?? new List<VMasterAssetType>();

                    if (newData.MasterAssetType.SequenceNumber != null)
                    {
                        int? seqData = newData.MasterAssetType.SequenceNumber;
                        checkDuplicate = data.Exists(x => x.SequenceNumber == seqData);

                        if (checkDuplicate == true)
                        {
                            checkDuplicate = false;
                            if (newData.MasterAssetType.Id != 0) // Edit Mode
                            {
                                var item = new VMasterAssetType();
                                item = data.FirstOrDefault(x => x.SequenceNumber == seqData);
                                if (item != null && item.Id != newData.MasterAssetType.Id)
                                {
                                    checkDuplicate = true;
                                    ViewBag.error = "SequenceNumber is duplicated.";
                                }
                            }
                            else
                            {
                                checkDuplicate = true;
                                ViewBag.error = "SequenceNumber is duplicated.";
                            }
                        }
                    }

                }
            }

            int? pAssetTypeId = 0;
            Boolean pSuccess = false;
            string pMessage = string.Empty;

            if (checkDuplicate == false)
            {
                var objMasterAssetType = new MasterAssetType();
                objMasterAssetType = newData.MasterAssetType;
                var json = JsonConvert.SerializeObject(objMasterAssetType);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterAssetType", content);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success)
                    {
                        ViewBag.success = "บันทึกสำเร็จ";
                        pAssetTypeId = apiResults.Id;
                        pSuccess = apiResults.Success;
                        pMessage = apiResults.Message;
                    }
                       
                    else ViewBag.error = apiResults.Message;
                }
            }

            MasterAssetTypeDetailModel newResult = new MasterAssetTypeDetailModel();
            newResult.MasterAssetType = new MasterAssetType();
           

            var resultdata = new MasterAssetTypeDetailModel();
            if (pAssetTypeId != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterAssetType?Id={pAssetTypeId}");
                if (response2.IsSuccessStatusCode)
                {
                    var json1 = await response2.Content.ReadAsStringAsync();
                    resultdata = JsonConvert.DeserializeObject<MasterAssetTypeDetailModel>(json1) ?? new MasterAssetTypeDetailModel();
                }
            }

            //newResult.ListMasterAssetTypeSub = new List<MasterAssetTypeSub>();
            //ViewBag.hideModal = "mdlMasterAssetType";
            //return PartialView("mdlMasterAssetType", resultdata);
            //return PartialView("_tableMasterAssetType", new List<VMasterAssetType>());
            //ViewBag.hideModal = "";
            //return View("_modalMasterAssetType", resultdata);

            //ยังแก้เรื่อง save วันที่ , เปิด popup ค้างหลัง save
            ViewBag.hideModal = "mdlMasterAssetType";
            return PartialView("_tableMasterAssetType", new List<VMasterAssetType>());

        }

        [HttpPost]
        public async Task<IActionResult> SaveMasterAssetType(MasterAssetTypeDetailModel model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.MasterAssetType.Active == null) model.MasterAssetType.Active = false;
            if (model.MasterAssetType.Id == 0)
            {
                model.MasterAssetType.CreateBy = user.User.Id;
                model.MasterAssetType.CreateOn = DateTime.Now;

            }
            else
            {
                model.MasterAssetType.UpdateBy = user.User.Id;
                model.MasterAssetType.UpdateOn = DateTime.Now;
            }

            //Check Duplicate : Code
            var data = new List<VMasterAssetType>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetType?");
            Boolean checkDuplicate = false;
            if (response1.IsSuccessStatusCode)
            {
                var json1 = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterAssetType>>(json1) ?? new List<VMasterAssetType>();

                if (model.MasterAssetType.Code != null)
                {
                    string? codeData = model.MasterAssetType.Code;
                    checkDuplicate = data.Exists(x => x.Code == codeData);

                    if (checkDuplicate == true)
                    {
                        checkDuplicate = false;
                        if (model.MasterAssetType.Id != 0) // Edit Mode
                        {
                            var item = new VMasterAssetType();
                            item = data.FirstOrDefault(x => x.Code == codeData);
                            if (item != null && item.Id != model.MasterAssetType.Id)
                            {
                                checkDuplicate = true;
                                ViewBag.error = "Code is duplicated.";
                            }
                        }
                        else
                        {
                            checkDuplicate = true;
                            ViewBag.error = "Code is duplicated.";
                        }
                    }
                }

            }

            //Check Duplicate : SequenceNumber
            //var data = new List<VMasterAssetType>();
            //var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetType?");
            //Boolean checkDuplicate = false;
            if (checkDuplicate == false)
            {
                if (response1.IsSuccessStatusCode)
                {
                    var json1 = await response1.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<List<VMasterAssetType>>(json1) ?? new List<VMasterAssetType>();

                    if (model.MasterAssetType.SequenceNumber != null)
                    {
                        int? seqData = model.MasterAssetType.SequenceNumber;
                        checkDuplicate = data.Exists(x => x.SequenceNumber == seqData);

                        if (checkDuplicate == true)
                        {
                            checkDuplicate = false;
                            if (model.MasterAssetType.Id != 0) // Edit Mode
                            {
                                var item = new VMasterAssetType();
                                item = data.FirstOrDefault(x => x.SequenceNumber == seqData);
                                if (item != null && item.Id != model.MasterAssetType.Id)
                                {
                                    checkDuplicate = true;
                                    ViewBag.error = "SequenceNumber is duplicated.";
                                }
                            }
                            else
                            {
                                checkDuplicate = true;
                                ViewBag.error = "SequenceNumber is duplicated.";
                            }
                        }
                    }

                }
            }         


            if (checkDuplicate == false)
            {
                var objMasterAssetType = new MasterAssetType();
                objMasterAssetType = model.MasterAssetType;
                var json = JsonConvert.SerializeObject(objMasterAssetType);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterAssetType", content);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }               
            }
      
                ViewBag.hideModal = "mdlMasterAssetType";
                return PartialView("_tableMasterAssetType", new List<VMasterAssetType>());             
                  

        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterAssetType(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            // 8 ปุ่มลบ
            //ถ้ารายการที่เลือกมีการนำ MasterAssetType.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ โดย Check รายการจากตาราง Asset 
            //ถ้าพบรายการ MasterAssetType.Id = Asset.AssetTypeId ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;
            //- Asset
            var dataAsset = new List<Asset>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAssetByAssetTypeId?assetTypeId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataAsset = JsonConvert.DeserializeObject<List<Asset>>(json) ?? new List<Asset>();

                    if (dataAsset != null && dataAsset.Count > 0)
                    {
                        blnChkPass = false;
                    }

                }
            }

            var data = new List<VMasterAssetType>();
            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterAssetType?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }            
                
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";
            }

            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetType?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterAssetType>>(json) ?? new List<VMasterAssetType>();
            }

            return PartialView("_tableMasterAssetType", data.OrderBy(x => x.SequenceNumber).ToList());

        }

        [HttpPost]
        public async Task<IActionResult> MasterAssetTypeSub(int AssetTypeId)        {          

            var data = new MasterAssetTypeDetailModel();
            data.MasterAssetTypeSub = new MasterAssetTypeSub();
            data.MasterAssetTypeSub.AssetTypeId = AssetTypeId;
            data.listDelSubId = "";

            return PartialView("_modalMasterAssetTypeSubDetail", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMasterAssetTypeSub(MasterAssetTypeDetailModel model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            //if (model.Active == null) model.Active = false;
            model.MasterAssetTypeSub.Active = true;
            
            if (model.MasterAssetTypeSub.Id == 0)
            {
                model.MasterAssetTypeSub.CreateBy = user.User.Id;
                model.MasterAssetTypeSub.CreateOn = DateTime.Now;
            }
            else
            {
                model.MasterAssetTypeSub.UpdateBy = user.User.Id;
                model.MasterAssetTypeSub.UpdateOn = DateTime.Now;
            }

            var datSub = new MasterAssetTypeSub();
            datSub = model.MasterAssetTypeSub;

            var json = JsonConvert.SerializeObject(datSub);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterAssetTypeSub", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }                           

            var data = new MasterAssetTypeDetailModel();
            if (model.MasterAssetTypeSub.AssetTypeId != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterAssetType?Id={model.MasterAssetTypeSub.AssetTypeId}");
                if (response2.IsSuccessStatusCode)
                {
                    var json1 = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterAssetTypeDetailModel>(json1) ?? new MasterAssetTypeDetailModel();
                }
            }                     

            ViewBag.hideModal = "mdlMasterAssetTypeSub";         
            return PartialView("_tableMasterAssetTypeSub", data);

        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterAssetTypeSub(int AssetTypeId, string listDelSubId)

        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            //listDelSubId = "2125";
            if (listDelSubId != null && listDelSubId != "")
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterAssetTypeSub?listDelSubId={listDelSubId}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }

            //var data = new List<VMasterAssetType>();
            //var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetTypeSub?");
            //if (response1.IsSuccessStatusCode)
            //{
            //    var json = await response1.Content.ReadAsStringAsync();
            //    data = JsonConvert.DeserializeObject<List<VMasterAssetType>>(json) ?? new List<VMasterAssetType>();
            //}
            var data = new MasterAssetTypeDetailModel();
            if (AssetTypeId != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterAssetType?Id={AssetTypeId}");
                if (response2.IsSuccessStatusCode)
                {
                    var json1 = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterAssetTypeDetailModel>(json1) ?? new MasterAssetTypeDetailModel();
                }
            }
            ViewBag.hideModal = "mdlMasterAssetTypeSub";           
            return PartialView("_tableMasterAssetTypeSub", data);

        }
        #endregion

        #region 2.MasterAssetClass
        public async Task<IActionResult> MasterAssetClass()
        {
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterAssetType");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterAssetType = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MasterAssetClass(string? NameThai, int? AssetTypeId, bool? Active)
        {
            var data = new List<VMasterAssetClass>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetClass?nameThai={NameThai}&assetTypeId={AssetTypeId}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterAssetClass>>(json) ?? new List<VMasterAssetClass>();
            }
            return PartialView("_tableMasterAssetClass", data);
        }

        [HttpPost]
        public async Task<IActionResult> MasterAssetClassDetail(int Id)
        {
            var data = new MasterAssetClass();

            var response3 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterAssetTypeSub");
            if (response3.IsSuccessStatusCode)
            {
                var json = await response3.Content.ReadAsStringAsync();
                ViewBag.MasterAssetTypeSub = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterAssetType");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterAssetType = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
           
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterAssetClass?Id={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterAssetClass>(json) ?? new MasterAssetClass();
                }
            }

            return PartialView("_modalMasterAssetClass", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMasterAssetClass(MasterAssetClass model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;

            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            //Check Duplicate : SequenceNumber
            var data = new List<VMasterAssetClass>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetClass?");
            Boolean checkDuplicate = false;
            if (response1.IsSuccessStatusCode)
            {
                var json1 = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterAssetClass>>(json1) ?? new List<VMasterAssetClass>();

                if (model.SequenceNumber != null)
                {
                    int? seqData = model.SequenceNumber;
                    checkDuplicate = data.Exists(x => x.SequenceNumber == seqData);

                    if (checkDuplicate == true)
                    {
                        checkDuplicate = false;
                        if (model.Id != 0) // Edit Mode
                        {
                            var item = new VMasterAssetClass();
                            item = data.FirstOrDefault(x => x.SequenceNumber == seqData);
                            if (item != null && item.Id != model.Id)
                            {
                                checkDuplicate = true;
                                ViewBag.error = "SequenceNumber is duplicated.";
                            }
                        }
                        else
                        {
                            checkDuplicate = true;
                            ViewBag.error = "SequenceNumber is duplicated.";
                        }
                    }
                }

            }
            if (checkDuplicate == false)
            {
                var json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterAssetClass", content);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            ViewBag.hideModal = "mdlMasterAssetClass";
            return PartialView("_tableMasterAssetClass", new List<VMasterAssetClass>());           
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterAssetClass(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

                //ถ้ารายการที่เลือกมีการนำ MasterAssetClass.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ 
                //โดย Check รายการจากตาราง Asset ถ้าพบรายการ MasterAssetClass.Id = Asset.AssetClassId 
                //ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;
            //- Asset
            var dataAsset = new List<Asset>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAssetByAssetClassId?assetClassId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataAsset = JsonConvert.DeserializeObject<List<Asset>>(json) ?? new List<Asset>();

                    if (dataAsset != null && dataAsset.Count > 0)
                    {
                        blnChkPass = false;
                    }

                }
            }

            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterAssetClass?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";
            }
           

            var data = new List<VMasterAssetClass>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterAssetClass?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterAssetClass>>(json) ?? new List<VMasterAssetClass>();
            }
            return PartialView("_tableMasterAssetClass", data);           
        }

        #endregion

        #region 3.MasterUnit
        public IActionResult MasterUnit()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MasterUnit(string? NameTh, bool? Active)
        {
            var data = new List<VMasterUnit>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterUnit?nameTh={NameTh}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterUnit>>(json) ?? new List<VMasterUnit>();
            }
            return PartialView("_tableMasterUnit", data);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteMasterUnit(int Id)
        {

            var user = new Appz(HttpContext).CurrentSignInUser;

            //  ถ้ารายการที่เลือกมีการนำ MasterUnit.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ โดย Check รายการจากตาราง
            //- 1.Asset
            //- 2.AssetReturnItem
            //- 3.MasterMaterial
            //- 4.MaterialBorrowItem
            //- 5.MaterialInItem
            //- 6.MaterialRequisitionItem
            //- 7.MaterialStock
            //- 8.AnnualCheckMaterial
            //- 9.BudgetGovernmentItem
            //ถ้าพบรายการ MasterUnit.Id = UnitId จากตารางที่เกี่ยวข้อง ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;            
           
            if (Id != 0)
            {//- 1.Asset
                var dataAsset = new List<Asset>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAssetByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataAsset = JsonConvert.DeserializeObject<List<Asset>>(json) ?? new List<Asset>();

                    if (dataAsset != null && dataAsset.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            {//- 2.AssetReturnItem
                var dataAssetReturnItem = new List<AssetReturnItem>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAssetReturnItemByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataAssetReturnItem = JsonConvert.DeserializeObject<List<AssetReturnItem>>(json) ?? new List<AssetReturnItem>();

                    if (dataAssetReturnItem != null && dataAssetReturnItem.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            {//- 3.MasterMaterial
                var dataMasterMaterial = new List<MasterMaterial>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterMaterialByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMasterMaterial = JsonConvert.DeserializeObject<List<MasterMaterial>>(json) ?? new List<MasterMaterial>();

                    if (dataMasterMaterial != null && dataMasterMaterial.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            { //- 4.MaterialBorrowItem
                var dataMaterialBorrowItem = new List<MaterialBorrowItem>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMaterialBorrowItemByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMaterialBorrowItem = JsonConvert.DeserializeObject<List<MaterialBorrowItem>>(json) ?? new List<MaterialBorrowItem>();

                    if (dataMaterialBorrowItem != null && dataMaterialBorrowItem.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            { //- 5.MaterialInItem
                var dataMaterialInItem = new List<MaterialInItem>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMaterialInItemByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMaterialInItem = JsonConvert.DeserializeObject<List<MaterialInItem>>(json) ?? new List<MaterialInItem>();

                    if (dataMaterialInItem != null && dataMaterialInItem.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            { //- 6.MaterialRequisitionItem
                var dataMaterialRequisitionItem = new List<MaterialRequisitionItem>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMaterialRequisitionItemByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMaterialRequisitionItem = JsonConvert.DeserializeObject<List<MaterialRequisitionItem>>(json) ?? new List<MaterialRequisitionItem>();

                    if (dataMaterialRequisitionItem != null && dataMaterialRequisitionItem.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            { //- 7.MaterialStock
                var dataMaterialStock = new List<MaterialStock>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMaterialStockByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMaterialStock = JsonConvert.DeserializeObject<List<MaterialStock>>(json) ?? new List<MaterialStock>();

                    if (dataMaterialStock != null && dataMaterialStock.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            { //- 8.AnnualCheckMaterial
                var dataAnnualCheckMaterial = new List<AnnualCheckMaterial>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAnnualCheckMaterialByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataAnnualCheckMaterial = JsonConvert.DeserializeObject<List<AnnualCheckMaterial>>(json) ?? new List<AnnualCheckMaterial>();

                    if (dataAnnualCheckMaterial != null && dataAnnualCheckMaterial.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            { //- 9.BudgetGovernmentItem
                var dataBudgetGovernmentItem = new List<BudgetGovernmentItem>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetBudgetGovernmentItemByUnitId?unitId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataBudgetGovernmentItem = JsonConvert.DeserializeObject<List<BudgetGovernmentItem>>(json) ?? new List<BudgetGovernmentItem>();

                    if (dataBudgetGovernmentItem != null && dataBudgetGovernmentItem.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }


            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterUnit?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";
            }

            var data = new List<VMasterUnit>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterUnit");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterUnit>>(json) ?? new List<VMasterUnit>();
            }
            return PartialView("_tableMasterUnit", data);

        }
        [HttpPost]
        public async Task<IActionResult> MasterUnitDetail(int Id)
        {
            var data = new MasterUnit();
            if (Id != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterUnit?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterUnit>(json) ?? new MasterUnit();
                }
            }
            return PartialView("_modalMasterUnit", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveMasterUnit(MasterUnit model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;
            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterUnit", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterUnit";

            return PartialView("_tableMasterUnit", new List<VMasterUnit>());
        }
        #endregion

        #region 4.MasterMaterial
        public async Task<IActionResult> MasterMaterial()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterMaterialGroupIdCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterMaterialGroup = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MasterMaterial(string? NameTh, int? GroupId, bool? Active)
        {

            var data = new List<VMasterMaterial>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterMaterial?NameTh={NameTh}&groupId={GroupId}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterMaterial>>(json) ?? new List<VMasterMaterial>();
            }
            return PartialView("_tableMasterMaterial", data);
          
        }
        [HttpPost]
        public async Task<IActionResult> DeleteMasterMaterial(int Id)
        {
            //ถ้ารายการที่เลือกมีการนำ MasterMaterial.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ โดย Check รายการจากตาราง
            //MaterialInItem ถ้าพบรายการ MasterMaterial.Id = MaterialInItem.MaterialId
            //ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;
            //- MaterialInItem
            var dataMaterialInItem = new List<MaterialInItem>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMaterialInItemByMaterialId?materialId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMaterialInItem = JsonConvert.DeserializeObject<List<MaterialInItem>>(json) ?? new List<MaterialInItem>();

                    if (dataMaterialInItem != null && dataMaterialInItem.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }


            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterMaterial?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";

            }


            var data = new List<VMasterMaterial>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterMaterial?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterMaterial>>(json) ?? new List<VMasterMaterial>();
            }

            return PartialView("_tableMasterMaterial", data);
        }
        [HttpPost]
        public async Task<IActionResult> MasterMaterialDetail(int Id)
        {
            var data = new MasterMaterial();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterMaterialGroupIdCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterMaterialGroup = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterUnit");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterUnit = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            if (Id != 0)
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterMaterial?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterMaterial>(json) ?? new MasterMaterial();
                }
            }
            return PartialView("_modalMasterMaterial", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveMasterMaterial(MasterMaterial model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;
            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterMaterial", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterMaterial";

            return PartialView("_tableMasterMaterial", new List<VMasterMaterial>());
        }
        #endregion

        #region 5.MasterMaterialGroup
        public IActionResult MasterMaterialGroup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MasterMaterialGroup(string? Code, string? NameTh, bool? Active)
        {
            var data = new List<VMasterMaterialGroup>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterMaterialGroup?nameTh={NameTh}&code={Code}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterMaterialGroup>>(json) ?? new List<VMasterMaterialGroup>();
            }
            return PartialView("_tableMasterMaterialGroup", data);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteMasterMaterialGroup(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            //ถ้ารายการที่เลือกมีการนำ MasterMaterialGroup.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ 
            //โดย Check รายการจากตาราง MasterMaterial ถ้าพบรายการ MasterMaterialGroup.Id = MasterMaterial.MaterialGroupId 
            //ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’


            var blnChkPass = true;
            //- MasterMaterial
            var dataMasterMaterial = new List<MasterMaterial>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetdataMasterMaterialByMaterialGroupId?materialGroupId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMasterMaterial = JsonConvert.DeserializeObject<List<MasterMaterial>>(json) ?? new List<MasterMaterial>();

                    if (dataMasterMaterial != null && dataMasterMaterial.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterMaterialGroup?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";
            }


            var data = new List<VMasterMaterialGroup>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterMaterialGroup?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterMaterialGroup>>(json) ?? new List<VMasterMaterialGroup>();
            }
            return PartialView("_tableMasterMaterialGroup", data);
        }
        [HttpPost]
        public async Task<IActionResult> MasterMaterialGroupDetail(int Id)
        {
            var data = new MasterMaterialGroup();
            if (Id != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterMaterialGroup?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterMaterialGroup>(json) ?? new MasterMaterialGroup();
                }
            }
            return PartialView("_modalMasterMaterialGroup", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveMasterMaterialGroup(MasterMaterialGroup model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;
            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterMaterialGroup", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterMaterialGroup";

            return PartialView("_tableMasterMaterialGroup", new List<VMasterMaterialGroup>());
        }
        #endregion       

        #region 6.MasterStrategyCode
        public IActionResult MasterStrategyCode()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MasterStrategyCode(string? NameTh)
        {
            var data = new List<VMasterStrategyCode>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterStrategyCode?name={NameTh}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterStrategyCode>>(json) ?? new List<VMasterStrategyCode>();
            }
            return PartialView("_tableMasterStrategyCode", data);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteMasterStrategyCode(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            //MasterStrategyCode ถ้ารายการที่เลือกมีการนำ MasterStrategyCode.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ โดย Check รายการจากตาราง
            //- MasterBudgetExpenseType
            //- MasterStrategicPlanCode
            //ถ้าพบรายการ MasterStrategyCode.Id = StrategyCodeId จากตารางที่เกี่ยวข้อง
            //ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’


            var blnChkPass = true;
            //- MasterBudgetExpenseType
            var dataMasterBudgetExpenseType = new List<MasterBudgetExpenseType>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterBudgetExpenseTypeByStrategyCodeId?strategyCodeId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMasterBudgetExpenseType = JsonConvert.DeserializeObject<List<MasterBudgetExpenseType>>(json) ?? new List<MasterBudgetExpenseType>();

                    if (dataMasterBudgetExpenseType != null && dataMasterBudgetExpenseType.Count > 0)
                    {
                        blnChkPass = false;
                    }

                }
            }

            if (blnChkPass == true)
            {//- MasterStrategicPlanCode
                var dataMasterStrategicPlanCode = new List<MasterStrategicPlanCode>();
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterStrategicPlanCodeByStrategyCodeId?strategyCodeId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMasterStrategicPlanCode = JsonConvert.DeserializeObject<List<MasterStrategicPlanCode>>(json) ?? new List<MasterStrategicPlanCode>();

                    if (dataMasterStrategicPlanCode != null && dataMasterStrategicPlanCode.Count > 0)
                    {
                        blnChkPass = false;
                    }

                }
            }

            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterStrategyCode?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            } 
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";

            }

            var data = new List<VMasterStrategyCode>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterStrategyCode?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterStrategyCode>>(json) ?? new List<VMasterStrategyCode>();
            }

            return PartialView("_tableMasterStrategyCode", data);
        }
        [HttpPost]
        public async Task<IActionResult> MasterStrategyCodeDetail(int Id)
        {
            var data = new MasterStrategyCode();
            if (Id != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterStrategyCode?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterStrategyCode>(json) ?? new MasterStrategyCode();
                }
            }
            return PartialView("_modalMasterStrategyCode", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveMasterStrategyCode(MasterStrategyCode model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;
            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterStrategyCode", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterStrategyCode";

            return PartialView("_tableMasterStrategyCode", new List<VMasterStrategyCode>());
        }
        #endregion

        #region 7.MasterStrategicPlanCode
        public async Task<IActionResult> MasterStrategicPlanCode()
        {
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategyCode");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterStrategyCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MasterStrategicPlanCode(string? Name, int? StrategyCodeId, bool? Active)
        {
            var data = new List<VMasterStrategicPlanCode>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterStrategicPlanCode?name={Name}&strategyCodeId={StrategyCodeId}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterStrategicPlanCode>>(json) ?? new List<VMasterStrategicPlanCode>();
            }
            return PartialView("_tableMasterStrategicPlanCode", data);
        }

        [HttpPost]
        public async Task<IActionResult> MasterStrategicPlanCodeDetail(int Id)
        {
            var data = new MasterStrategicPlanCode();
         
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategyCode");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterStrategyCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterStrategicPlanCode?Id={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterStrategicPlanCode>(json) ?? new MasterStrategicPlanCode();
                }
            }

            return PartialView("_modalMasterStrategicPlanCode", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMasterStrategicPlanCode(MasterStrategicPlanCode model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;

            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterStrategicPlanCode", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterStrategicPlanCode";

            return PartialView("_tableMasterStrategicPlanCode", new List<VMasterStrategicPlanCode>());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterStrategicPlanCode(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            //MasterStrategicPlanCode ถ้ารายการที่เลือกมีการนำ MasterStrategicPlanCode.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ โดย Check รายการจากตาราง
            //- MasterBudgetExpenseType
            //- MasterOutputCode
            //ถ้าพบรายการ MasterStrategicPlanCode.Id = StrategicPlanCodeId จากตารางที่เกี่ยวข้อง
            //ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;
         
            var dataMasterBudgetExpenseType = new List<MasterBudgetExpenseType>();
            if (Id != 0)
            {//- MasterBudgetExpenseType
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterBudgetExpenseTypeByStrategicPlanCodeId?strategicPlanCodeId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMasterBudgetExpenseType = JsonConvert.DeserializeObject<List<MasterBudgetExpenseType>>(json) ?? new List<MasterBudgetExpenseType>();

                    if (dataMasterBudgetExpenseType != null && dataMasterBudgetExpenseType.Count > 0)
                    {
                        blnChkPass = false;
                    }

                }

                if (blnChkPass == true)
                {
                    //- MasterOutputCode
                    var dataMasterOutputCode = new List<MasterOutputCode>();
                    response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterOutputCodeByStrategicPlanCodeId?strategicPlanCodeId={Id}");
                    if (response2.IsSuccessStatusCode)
                    {
                        var json = await response2.Content.ReadAsStringAsync();
                        dataMasterOutputCode = JsonConvert.DeserializeObject<List<MasterOutputCode>>(json) ?? new List<MasterOutputCode>();

                        if (dataMasterOutputCode != null && dataMasterOutputCode.Count > 0)
                        {
                            blnChkPass = false;
                        }

                    }
                }
                
            }


            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterStrategicPlanCode?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";

            }


            var data = new List<VMasterStrategicPlanCode>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterStrategicPlanCode?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterStrategicPlanCode>>(json) ?? new List<VMasterStrategicPlanCode>();
            }
            return PartialView("_tableMasterStrategicPlanCode", data);
          
        }
        #endregion

        #region 8.MasterOutputCode
        public async Task<IActionResult> MasterOutputCode()
        {
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategyCode");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterStrategyCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategicPlanCode");
            if (response2.IsSuccessStatusCode)
            {
                var json = await response2.Content.ReadAsStringAsync();
                ViewBag.MasterStrategicPlanCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MasterOutputCode(string? Name, int? StrategyCodeId, int? StrategicPlanCodeId, bool? Active)
        {
            var data = new List<VMasterOutputCode>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterOutputCode?name={Name}&strategyCodeId={StrategyCodeId}&strategicPlanCodeId={StrategicPlanCodeId}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterOutputCode>>(json) ?? new List<VMasterOutputCode>();
            }
            return PartialView("_tableMasterOutputCode", data);
        }

        [HttpPost]
        public async Task<IActionResult> MasterOutputCodeDetail(int Id)
        {
            var data = new MasterOutputCode();

            //MasterStrategicPlanCode
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategicPlanCode");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterStrategicPlanCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterOutputCode?Id={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterOutputCode>(json) ?? new MasterOutputCode();
                }
            }

            return PartialView("_modalMasterOutputCode", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMasterOutputCode(MasterOutputCode model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;

            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterOutputCode", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterOutputCode";

            return PartialView("_tableMasterOutputCode", new List<VMasterOutputCode>());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterOutputCode(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            //  MasterOutputCode ถ้ารายการที่เลือกมีการนำ MasterOutputCode.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ โดย Check รายการจากตาราง
            //- MasterBudgetExpenseType
            //- MasterActivityCode
            //ถ้าพบรายการ MasterOutputCode.Id = OutputCodeId จากตารางที่เกี่ยวข้อง ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว’

            var blnChkPass = true;
            //- MasterBudgetExpenseType
            var dataMasterBudgetExpenseType = new List<MasterBudgetExpenseType>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterBudgetExpenseTypeByOutputCodeId?outputCodeId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMasterBudgetExpenseType = JsonConvert.DeserializeObject<List<MasterBudgetExpenseType>>(json) ?? new List<MasterBudgetExpenseType>();

                    if (dataMasterBudgetExpenseType != null && dataMasterBudgetExpenseType.Count > 0)
                    {
                        blnChkPass = false;
                    }

                }

                if (blnChkPass == true)
                {//- MasterActivityCode
                    var dataMasterActivityCode = new List<MasterActivityCode>();
                    response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterActivityCodeByOutputCodeId?outputCodeId={Id}");
                    if (response2.IsSuccessStatusCode)
                    {
                        var json = await response2.Content.ReadAsStringAsync();
                        dataMasterActivityCode = JsonConvert.DeserializeObject<List<MasterActivityCode>>(json) ?? new List<MasterActivityCode>();

                        if (dataMasterActivityCode != null && dataMasterActivityCode.Count > 0)
                        {
                            blnChkPass = false;
                        }

                    }
                }
            }

            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterOutputCode?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";

            }


            var data = new List<VMasterOutputCode>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterOutputCode?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterOutputCode>>(json) ?? new List<VMasterOutputCode>();
            }
            return PartialView("_tableMasterOutputCode", data);
          
        }
        #endregion

        #region 9.MasterActivityCode
        public async Task<IActionResult> MasterActivityCode()
        {
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategyCode");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterStrategyCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategicPlanCode");
            if (response2.IsSuccessStatusCode)
            {
                var json = await response2.Content.ReadAsStringAsync();
                ViewBag.MasterStrategicPlanCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            var response3 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOutputCode");
            if (response3.IsSuccessStatusCode)
            {
                var json = await response3.Content.ReadAsStringAsync();
                ViewBag.MasterOutputCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MasterActivityCode(string? Name, int? StrategyCodeId, int? StrategicPlanCodeId, int? OutputCodeId, bool? Active)
        {
            var data = new List<VMasterActivityCode>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterActivityCode?name={Name}&strategyCodeId={StrategyCodeId}&strategicPlanCodeId={StrategicPlanCodeId}&outputCodeId={OutputCodeId}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterActivityCode>>(json) ?? new List<VMasterActivityCode>();
            }
            return PartialView("_tableMasterActivityCode", data);
        }

        [HttpPost]
        public async Task<IActionResult> MasterActivityCodeDetail(int Id)
        {
            var data = new MasterActivityCode();

            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOutputCode");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterOutputCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterActivityCode?Id={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterActivityCode>(json) ?? new MasterActivityCode();
                }
            }

            return PartialView("_modalMasterActivityCode", data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMasterActivityCode(MasterActivityCode model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;

            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterActivityCode", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterActivityCode";

            return PartialView("_tableMasterActivityCode", new List<VMasterActivityCode>());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterActivityCode(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            //MasterActivityCode ถ้ารายการที่เลือกมีการนำ MasterActivityCode.Id ไปใช้แล้วจะไม่สามารถลบรายการได้
            //โดย Check รายการจากตาราง BudgetGovernmentItem ถ้าพบรายการ MasterActivityCode.Id = BudgetGovernmentItem.ActivityCodeId
            //ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;
            //- BudgetGovernmentItem
            var dataBudgetGovernmentItem = new List<BudgetGovernmentItem>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetBudgetGovernmentItemByActivityCodeId?activityCodeId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataBudgetGovernmentItem = JsonConvert.DeserializeObject<List<BudgetGovernmentItem>>(json) ?? new List<BudgetGovernmentItem>();

                    if (dataBudgetGovernmentItem != null && dataBudgetGovernmentItem.Count > 0)
                    {
                        blnChkPass = false;
                    }

                }
            }

            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterActivityCode?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";
            }
            

            var data = new List<VMasterActivityCode>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterActivityCode?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterActivityCode>>(json) ?? new List<VMasterActivityCode>();
            }
            return PartialView("_tableMasterActivityCode", data);
            //return PartialView("_tableMasterActivityCode", new List<VMasterActivityCode>());
        }

        #endregion

        #region 10.MasterStorePlace
        public async Task<IActionResult> MasterStorePlace()
        {
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MasterStorePlace(string? Name, int? OrganizationId, bool? Active)
        {
            var data = new List<VMasterStorePlace>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterStorePlace?name={Name}&organizationId={OrganizationId}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterStorePlace>>(json) ?? new List<VMasterStorePlace>();
            }
            return PartialView("_tableMasterStorePlace", data);
        }

        [HttpPost]
        public async Task<IActionResult> MasterStorePlaceDetail(int Id)
        {
            var data = new MasterStorePlace();           

            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterStorePlace?Id={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterStorePlace>(json) ?? new MasterStorePlace();
                }
            }

            return PartialView("_modalMasterStorePlace", data);
        }

        public async Task<IActionResult> SaveMasterStorePlace(MasterStorePlace model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;

            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterStorePlace", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterStorePlace";

            return PartialView("_tableMasterStorePlace", new List<VMasterStorePlace>());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterStorePlace(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            // MasterStorePlace ถ้ารายการที่เลือกมีการนำ MasterStorePlace.Id ไปใช้แล้วจะไม่สามารถลบรายการได้
            // โดย Check รายการจากตาราง Asset ถ้าพบรายการ MasterStorePlace.Id = Asset.StorePlaceId
            // ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;
            //- Asset
            var dataAsset = new List<Asset>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAssetByStorePlaceId?storePlaceId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataAsset = JsonConvert.DeserializeObject<List<Asset>>(json) ?? new List<Asset>();

                    if (dataAsset != null && dataAsset.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterStorePlace?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";
            }

            var data = new List<VMasterStorePlace>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterStorePlace?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterStorePlace>>(json) ?? new List<VMasterStorePlace>();
            }
            return PartialView("_tableMasterStorePlace", data);
           
        }
        #endregion

        #region 11.MasterBudgetExpenseType 

        public async Task<IActionResult> MasterBudgetExpenseType()
        {
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategyCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterStrategyCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
             response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategicPlanCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterStrategicPlanCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOutputCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterOutputCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterExpenseType");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterExpenseType = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MasterBudgetExpenseType(int? StrategyCodeId, int? StrategicPlanCodeId, int? OutputCodeId, int? ExpenseTypeId)
        {
            var data = new List<VMasterBudgetExpenseType>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterBudgetExpenseType?strategyCodeId={StrategyCodeId}&strategicPlanCodeId={StrategicPlanCodeId}&outputCodeId={OutputCodeId}&expenseTypeId={ExpenseTypeId}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterBudgetExpenseType>>(json) ?? new List<VMasterBudgetExpenseType>();
            }

            return PartialView("_tableMasterBudgetExpenseType", data);

            //var dataView = new List<MasterBudgetExpenseTypeModel>();
            //var dataN = new MasterBudgetExpenseTypeModel();

            //if (data != null && data.Count > 0)
            //{
            //    for (int i = 0; i < data.Count; i++)
            //    {
            //        //intNodeId += 1;
            //        //intParentId = data[i].Id;
            //        dataN = new MasterBudgetExpenseTypeModel();
            //        dataN.Id = data[i].Id; ;
            //        dataN.Active = data[i].Active;
            //        dataN.Name = data[i].Name;
            //        dataN.BudgetTypeId = data[i].BudgetTypeId;
            //        dataN.ExpenseTypeId = data[i].ExpenseTypeId;
            //        dataN.StrategyCodeId = data[i].StrategyCodeId;
            //        dataN.StrategicPlanCodeId = data[i].StrategicPlanCodeId;
            //        dataN.OutputCodeId = data[i].OutputCodeId;
            //        dataN.BudgetExpenseLevel = data[i].BudgetExpenseLevel;
            //        dataN.ParentId = data[i].ParentId;
            //        dataN.IsParent = data[i].IsParent;
            //        dataN.MoneySourceId = data[i].MoneySourceId;
            //        dataN.ActiveName = data[i].ActiveName;
            //        dataN.StrategicName = data[i].StrategicName;
            //        dataN.StrategicPlanName = data[i].StrategicPlanName;
            //        dataN.OutputCodeName = data[i].OutputCodeName;
            //        dataN.ExpenseTypeName = data[i].ExpenseTypeName;

            //        switch (i)
            //        {
            //            case 0:
            //                dataN.NodeId = "1";                           
            //                break;
            //            case 1:
            //                dataN.NodeId = "1.1";
            //                dataN.NodePId = "1";
            //                break;
            //            case 2:
            //                dataN.NodeId = "1.2";
            //                dataN.NodePId = "1";
            //                break;
            //            case 3:
            //                dataN.NodeId = "1.3";
            //                dataN.NodePId = "1";
            //                break;
            //            case 4:
            //                dataN.NodeId = "1.4";
            //                dataN.NodePId = "1";
            //                break;
            //            default:
            //                // code block
            //                break;
            //        }

            //        dataView.Add(dataN);

            //        //dataChild = data.Where(x => x.ParentId == intParentId).ToList();
            //    }
            //}

        }

        [HttpPost]
        public async Task<IActionResult> MasterBudgetExpenseTypeDetail(int Id, int pId)
        {
            var data = new MasterBudgetExpenseType();

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategyCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterStrategyCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterStrategicPlanCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterStrategicPlanCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOutputCode");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterOutputCode = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterExpenseType");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterExpenseType = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterMoneySource");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterMoneySource = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterBudgetFormType");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterBudgetFormType = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterBudgetExpenseType?Id={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterBudgetExpenseType>(json) ?? new MasterBudgetExpenseType();
                }
            }
            else
            {
                if (pId != 0)
                {
                    data.ParentId = pId;
                }
            }

            //Bind ParentName
            string strParentName = string.Empty;
            if (data.ParentId != null && data.ParentId > 0)            {
                
                var dataP = new MasterBudgetExpenseType();
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterBudgetExpenseType?Id={data.ParentId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    dataP = JsonConvert.DeserializeObject<MasterBudgetExpenseType>(json) ?? new MasterBudgetExpenseType();

                    strParentName = dataP.Name;
                }
                ViewBag.ParentName = strParentName;
            }

            return PartialView("_modalMasterBudgetExpenseType", data);
        }

        public async Task<IActionResult> SaveMasterBudgetExpenseType(MasterBudgetExpenseType model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Active == null) model.Active = false;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;

            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterBudgetExpenseType", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterBudgetExpenseType";
            return PartialView("_tableMasterBudgetExpenseType", new List<VMasterBudgetExpenseType>());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterBudgetExpenseType(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            //ถ้ารายการที่เลือกมีการนำ MasterBudgetExpenseType.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ 
            //โดย Check รายการจากตาราง BudgetGovernmentItem ถ้าพบรายการ MasterBudgetExpenseType.Id = BudgetGovernmentItem.BudgetExpenseTypeId 
            //ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;
            //- BudgetGovernmentItem
            var dataBudgetGovernmentItem = new List<BudgetGovernmentItem>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetBudgetGovernmentItemByBudgetExpenseTypeId?budgetExpenseTypeId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataBudgetGovernmentItem = JsonConvert.DeserializeObject<List<BudgetGovernmentItem>>(json) ?? new List<BudgetGovernmentItem>();

                    if (dataBudgetGovernmentItem != null && dataBudgetGovernmentItem.Count > 0)
                    {
                        blnChkPass = false;
                    }
                }
            }

            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterBudgetExpenseType?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";
            }

            var data = new List<VMasterBudgetExpenseType>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterBudgetExpenseType?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterBudgetExpenseType>>(json) ?? new List<VMasterBudgetExpenseType>();
            }
            return PartialView("_tableMasterBudgetExpenseType", data);

        }

        #endregion               

        #region 12.MasterWarehouse
        public async Task<IActionResult> MasterWarehouse()
        {
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MasterWarehouse(string? Name, int? OrganizationId, bool? Active)
        {
            var data = new List<VMasterWarehouse>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterWarehouse?name={Name}&organizationId={OrganizationId}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterWarehouse>>(json) ?? new List<VMasterWarehouse>();
            }
            return PartialView("_tableMasterWarehouse", data);
        }

        [HttpPost]
        public async Task<IActionResult> MasterWarehouseDetail(int Id)
        {
            var data = new MasterWarehouseDetail();

            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterOrganization");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                ViewBag.MasterOrganization = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterMaterialGroupIdCode");
            if (response2.IsSuccessStatusCode)
            {
                var json = await response2.Content.ReadAsStringAsync();
                ViewBag.MasterMaterialGroup = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            if (Id != 0)
            {//Edit Mode
                var response3 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterWarehouse?Id={Id}");
                if (response3.IsSuccessStatusCode)
                {
                    var json = await response3.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterWarehouseDetail>(json) ?? new MasterWarehouseDetail();
                }

            }
            else
            {//Add Mode
                var objMasterWarehouse = new MasterWarehouse();
                var arrlistVMaterialSafetyStock = new List<VMaterialSafetyStock>();
                data.MasterWarehouse = objMasterWarehouse;
                data.listVMaterialSafetyStock = arrlistVMaterialSafetyStock;

            }

            return PartialView("_modalMasterWarehouse", data);
        }

        public async Task<IActionResult> SavelistVMaterialSafetyStock(int masterWarehouseId, string[] dataArrMat)
        {

            var dataWareHouseDetail = new MasterWarehouseDetail();
            var listNewsafetyStock = new List<VMaterialSafetyStock>();
            if (masterWarehouseId != 0)
            {//Edit Mode
                var response3 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterWarehouse?Id={masterWarehouseId}");
                if (response3.IsSuccessStatusCode)
                {
                    var json = await response3.Content.ReadAsStringAsync();
                    dataWareHouseDetail = JsonConvert.DeserializeObject<MasterWarehouseDetail>(json) ?? new MasterWarehouseDetail();
                    if (dataWareHouseDetail != null && dataWareHouseDetail.listVMaterialSafetyStock != null && dataWareHouseDetail.listVMaterialSafetyStock.Count > 0)
                    {
                        listNewsafetyStock = dataWareHouseDetail.listVMaterialSafetyStock;
                    }
                }
            }

            string strIdMatValue;
            string[] splitIdMatValue;
            int safetyStockId;
            string strMatValue;
            int MaxStock;
            int MinStock;
            int DrawableAmount;
            string[] arrMatValue;
            if (dataArrMat != null && dataArrMat.Length > 0)
            {
                for (int i = 0; i < dataArrMat.Length; i++)
                {
                    strIdMatValue = dataArrMat[i].ToString().Trim();
                    splitIdMatValue = strIdMatValue.Split(':');

                    safetyStockId = Convert.ToInt16(splitIdMatValue[0].ToString().Trim());
                    strMatValue = splitIdMatValue[1].ToString().Trim();
                    arrMatValue = strMatValue.ToString().Split(",");
                    if (arrMatValue != null && arrMatValue.Length > 0)
                    {
                        MaxStock = Convert.ToInt16(arrMatValue[0].ToString().Trim());
                        MinStock = Convert.ToInt16(arrMatValue[1].ToString().Trim());
                        DrawableAmount = Convert.ToInt16(arrMatValue[2].ToString().Trim());


                        for (int index = 0; index < listNewsafetyStock.Count; index++)
                        {
                            if (listNewsafetyStock[index].Id == safetyStockId)
                            {
                                listNewsafetyStock[index].MaxStock = MaxStock;
                                listNewsafetyStock[index].MinStock = MinStock;
                                listNewsafetyStock[index].DrawableAmount = DrawableAmount;
                            }
                           
                        }
                    }
                }
            }


            var json1 = JsonConvert.SerializeObject(listNewsafetyStock);
            var content = new StringContent(json1, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/UpdateListMaterialSafetyStock", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;
            }

            ViewBag.hideModal = "mdlMasterWarehouse";
            return PartialView("_tableMasterWarehouse", new List<VMasterWarehouse>());

        }

        public async Task<IActionResult> SaveMasterWarehouse(MasterWarehouseDetail model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;          
            if (model.MasterWarehouse.Active == null) model.MasterWarehouse.Active = false;
            if (model.MasterWarehouse.Id == 0)
            {
                model.MasterWarehouse.CreateBy = user.User.Id;
                model.MasterWarehouse.CreateOn = DateTime.Now;

            }
            else
            {
                model.MasterWarehouse.UpdateBy = user.User.Id;
                model.MasterWarehouse.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveMasterWarehouse", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlMasterWarehouse";

            return PartialView("_tableMasterWarehouse", new List<VMasterWarehouse>());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMasterWarehouse(int Id)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;

            //ถ้ารายการที่เลือกมีการนำ MasterWarehouse.Id ไปใช้แล้วจะไม่สามารถลบรายการได้
            //โดย Check รายการจากตาราง MaterialIn ถ้าพบรายการ MasterWarehouse.Id = MaterialIn.WarehouseId
            //ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’

            var blnChkPass = true;
            //- MaterialIn
            var dataMaterialIn = new List<MaterialIn>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMaterialInByWarehouseId?warehouseId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataMaterialIn = JsonConvert.DeserializeObject<List<MaterialIn>>(json) ?? new List<MaterialIn>();

                    if (dataMaterialIn != null && dataMaterialIn.Count > 0)
                    {
                        blnChkPass = false;
                    }

                }
            }

            if (blnChkPass == true)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteMasterWarehouse?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";
            }           

            var data = new List<VMasterWarehouse>();
            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVMasterWarehouse?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VMasterWarehouse>>(json) ?? new List<VMasterWarehouse>();
            }
            return PartialView("_tableMasterWarehouse", data);

        }

        [HttpPost]
        public async Task<IActionResult> GetlistVMaterialSafetyStockByMaterialGroup(int masterWarehouseId, int materialGroupId)
        {
            var data = new MasterWarehouseDetail();

            if (materialGroupId == 0 && masterWarehouseId != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterWarehouse?Id={masterWarehouseId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterWarehouseDetail>(json) ?? new MasterWarehouseDetail();
                }

            }
            else if (materialGroupId != 0)
            {
                ////Get by masterMaterialGroupId
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMaterialSafetyStockByMaterialGroupId?Id={masterWarehouseId}&materialGroupId={materialGroupId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<MasterWarehouseDetail>(json) ?? new MasterWarehouseDetail();
                }
            }

            return PartialView("_tableMaterialSafetyStock", data);

        }

        #endregion

        #region 13.Supplier
        public IActionResult Supplier()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Supplier(string? NameThai, string? TaxId, string SupplierCode, bool? Active)
        {
            var data = new List<VSupplier>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVSupplier?nameThai={NameThai}&taxId={TaxId}&supplierCode={SupplierCode}&Active={Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VSupplier>>(json) ?? new List<VSupplier>();
            }
            return PartialView("_tableSupplier", data);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSupplier(int Id)
        {
            //Check condition : MOEN_ERP67_Spec_Master_v.0.8
            //  ถ้ารายการที่เลือกมีการนำ Supplier.Id ไปใช้แล้วจะไม่สามารถลบรายการได้ โดย Check รายการจากตาราง
            //- Asset
            //- AssetMaintenance
            //- AssetMaintenanceForm
            //- MaterialIn
            //- Procurement
            //ถ้าพบรายการ Supplier.Id = SupplierId จากตารางที่เกี่ยวข้อง ให้แสดงแจ้งเตือนว่า ‘ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว ’
            var blnChkPass = true;
            //- Asset
            var dataAsset = new List<Asset>();
            if (Id != 0)
            {
                var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAssetBysupplierId?supplierId={Id}");
                if (response2.IsSuccessStatusCode)
                {
                    var json = await response2.Content.ReadAsStringAsync();
                    dataAsset = JsonConvert.DeserializeObject<List<Asset>>(json) ?? new List<Asset>();

                    if (dataAsset != null && dataAsset.Count > 0)
                    {
                        blnChkPass = false;
                    }
                    
                }
            }
            //- AssetMaintenance
            if (blnChkPass == true)
            {
                var dataAssetM = new List<AssetMaintenance>();
                if (Id != 0)
                {
                    var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAssetMBySupplierId?supplierId={Id}");
                    if (response2.IsSuccessStatusCode)
                    {
                        var json = await response2.Content.ReadAsStringAsync();
                        dataAssetM = JsonConvert.DeserializeObject<List<AssetMaintenance>>(json) ?? new List<AssetMaintenance>();
                        if (dataAssetM != null && dataAssetM.Count > 0)
                        {
                            blnChkPass = false;
                        }
                    }
                }
            }

            //- AssetMaintenanceForm
            if (blnChkPass == true)
            {
                var dataAssetMF = new List<AssetMaintenanceForm>();
                if (Id != 0)
                {
                    var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetAssetMFBySupplierId?supplierId={Id}");
                    if (response2.IsSuccessStatusCode)
                    {
                        var json = await response2.Content.ReadAsStringAsync();
                        dataAssetMF = JsonConvert.DeserializeObject<List<AssetMaintenanceForm>>(json) ?? new List<AssetMaintenanceForm>();
                        if (dataAssetMF != null && dataAssetMF.Count > 0)
                        {
                            blnChkPass = false;
                        }
                    }
                }
            }

            //- MaterialIn
            if (blnChkPass == true)
            {
                var dataMaterialIn = new List<MaterialIn>();
                if (Id != 0)
                {
                    var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMaterialInBySupplierId?supplierId={Id}");
                    if (response2.IsSuccessStatusCode)
                    {
                        var json = await response2.Content.ReadAsStringAsync();
                        dataMaterialIn = JsonConvert.DeserializeObject<List<MaterialIn>>(json) ?? new List<MaterialIn>();
                        if (dataMaterialIn != null && dataMaterialIn.Count > 0)
                        {
                            blnChkPass = false;
                        }
                    }
                }
            }

            //- Procurement
            if (blnChkPass == true)
            {
                var dataProcurement = new List<Procurement>();
                if (Id != 0)
                {
                    var response2 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetProcurementBySupplierId?supplierId={Id}");
                    if (response2.IsSuccessStatusCode)
                    {
                        var json = await response2.Content.ReadAsStringAsync();
                        dataProcurement = JsonConvert.DeserializeObject<List<Procurement>>(json) ?? new List<Procurement>();
                        if (dataProcurement != null && dataProcurement.Count > 0)
                        {
                            blnChkPass = false;
                        }
                    }
                }
            }
                

            var data = new List<VSupplier>();
            if (blnChkPass == true)
            {
                var user = new Appz(HttpContext).CurrentSignInUser;
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/DeleteSupplier?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลรายการสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }

            }
            else
            {
                ViewBag.success = null;
                ViewBag.error = null;
                ViewBag.warning = "ไม่สามารถลบรายการได้เนื่องจาก รายการนี้ถูกนำไปใช้แล้ว";

            }

            var response1 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListVSupplier?");
            if (response1.IsSuccessStatusCode)
            {
                var json = await response1.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VSupplier>>(json) ?? new List<VSupplier>();
            }
            return PartialView("_tableSupplier", data);

        }
        [HttpPost]
        public async Task<IActionResult> SupplierDetail(int Id)
        {
            //var dataSModel = new SupplierModel();
            var data = new Supplier();
            var dataSModel = new SupplierModel { Supplier = new Supplier() };

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterBank");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterBank = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            if (Id != 0)
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetSupplier?Id={Id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Supplier>(json) ?? new Supplier();
                    dataSModel.Supplier = data;
                }
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterProvince");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.MasterProvince = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            if (dataSModel.Supplier.ProvinceId != null && dataSModel.Supplier.ProvinceId > 0)
            {
                //Set CMB Amphur                  
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemAmphur?provinceId={dataSModel.Supplier.ProvinceId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    ViewBag.MasterAmphur = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                }
            }
            else
            {
                 response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterAmphur");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    ViewBag.MasterAmphur = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                }
            }

            if (dataSModel.Supplier.AmphurId != null && dataSModel.Supplier.AmphurId > 0)
            {
                //Set CMB Tambon          
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemTambon?provinceId=0&amphurId={dataSModel.Supplier.AmphurId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    ViewBag.MasterTambon = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                }
            }
            else
            {
                if (dataSModel.Supplier.ProvinceId != null && dataSModel.Supplier.ProvinceId > 0)
                {                  
                    response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemTambon?provinceId={dataSModel.Supplier.ProvinceId}&amphurId=0");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        ViewBag.MasterTambon = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                    }
                }
                else
                {
                    var response3 = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterTambon");
                    if (response3.IsSuccessStatusCode)
                    {
                        var json = await response3.Content.ReadAsStringAsync();
                        ViewBag.MasterTambon = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                    }
                }
                
            }

            if(Id == 0)
            {
                //Set Default
                dataSModel.Supplier.PersonType = "P";
                dataSModel.Supplier.Active = true;
            }
               
            return PartialView("_modalSupplier", dataSModel);
        }
        [HttpPost]
        public async Task<IActionResult> SaveSupplier(SupplierModel model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Supplier.Active == null) model.Supplier.Active = false;
            if (model.Supplier.Id == 0)
            {
                model.Supplier.CreateBy = user.User.Id;
                model.Supplier.CreateOn = DateTime.Now;
            }
            else
            {
                model.Supplier.UpdateBy = user.User.Id;
                model.Supplier.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/Master/SaveSupplier", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success) ViewBag.success = "บันทึกสำเร็จ";
                else ViewBag.error = apiResults.Message;

            }
            ViewBag.hideModal = "mdlSupplier";
            return PartialView("_tableSupplier", new List<VSupplier>());
        }

        [HttpPost]
        public async Task<IActionResult> SetCMBProvinceAmphurTambon(int provinceId, int amphurId, int tambonId, string cmbType)
        {
            var data = new SupplierModel { Supplier = new Supplier() };
          
            data.blnSetCMBAmphur = false;
            data.blnSetCMBTambon = false;

            data.setProvinceId = -1;
            data.setAmphurId = -1;
            data.setTambonId = -1;

            data.setZipCode = "";
            if (cmbType == "cmbProvince")
            {
                if (provinceId <= 0)
                {                  
                    var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterAmphur");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        data.listItemMasterAmphur = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                    }
                    response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetMasterTambon");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        data.listItemMasterTambon = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                    }
                  
                    data.blnSetCMBAmphur = true;
                    data.blnSetCMBTambon = true;
                    tambonId = 0;
                }
                else
                {
                    //Set CMB Tambon
                    amphurId = 0;
                    var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemTambon?provinceId={provinceId}&amphurId={amphurId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        data.listItemMasterTambon = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                    }

                    //Set CMB Amphur                  
                     response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemAmphur?provinceId={provinceId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        data.listItemMasterAmphur = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                    }

                    data.blnSetCMBAmphur = true;
                    data.blnSetCMBTambon = true;
                    tambonId = 0;
                }

            }
            else if (cmbType == "cmbAmphur")
            {
                //Set Select ProvinceId
                if (amphurId > 0)
                {
                    //Set CMB Tambon
                    var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemTambon?provinceId={provinceId}&amphurId={amphurId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        data.listItemMasterTambon = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                        data.blnSetCMBTambon = true;
                        tambonId = 0;
                    }

                    //Set Select ProvinceId
                    var dataA = new MasterAmphur();
                    response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterAmphur?Id={amphurId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        dataA = JsonConvert.DeserializeObject<MasterAmphur>(json) ?? new MasterAmphur();
                        data.setProvinceId = dataA.ProvinceId;
                    }

                    //Set CMB Amphur : All Amphur by ProvinceId                                  
                    response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemAmphur?provinceId={data.setProvinceId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        data.listItemMasterAmphur = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                        data.blnSetCMBAmphur = true;
                        data.setAmphurId = amphurId;
                    }                   

                }
                else
                {
                    // Get AllTambon in ProvinceId
                    //Set CMB Tambon
                    amphurId = 0;
                    var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemTambon?provinceId={provinceId}&amphurId={amphurId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        data.listItemMasterTambon = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                    }
                    data.blnSetCMBTambon = true;
                    tambonId = 0;
                }                

            }
            else if (cmbType == "cmbTambon")
            {               

                //Set Select AmphurId
                if (tambonId > 0)
                {
                    var dataT = new MasterTambon();
                    var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterTambon?Id={tambonId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        dataT = JsonConvert.DeserializeObject<MasterTambon>(json) ?? new MasterTambon();
                        data.setAmphurId = dataT.AmphurId;
                        data.setZipCode = dataT.ZipCode;

                        //Set CMB Tambon : By AmphurId  
                        response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemTambon?provinceId=0&amphurId={data.setAmphurId}");
                        if (response.IsSuccessStatusCode)
                        {
                            json = await response.Content.ReadAsStringAsync();
                            data.listItemMasterTambon = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                            data.blnSetCMBTambon = true;
                            data.setTambonId = tambonId;
                        }                      

                    }
                }

                //Set Select ProvinceId
                if (data.setAmphurId > 0)
                {
                    var dataA = new MasterAmphur();
                    var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetMasterAmphur?Id={data.setAmphurId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        dataA = JsonConvert.DeserializeObject<MasterAmphur>(json) ?? new MasterAmphur();
                        data.setProvinceId = dataA.ProvinceId;
                    }

                    //Set CMB Amphur : By ProvinceId                                     
                    response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/Master/GetListItemAmphur?provinceId={data.setProvinceId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        data.listItemMasterAmphur = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
                        data.blnSetCMBAmphur = true;
                    }
                }

            }
            //return PartialView("_modalSupplier", data);
            //data.message = "Test";
            return Json(data);
        }



        #endregion
    }
}
