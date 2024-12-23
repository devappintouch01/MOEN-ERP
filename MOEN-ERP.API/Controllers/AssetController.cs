using LinqKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.ViewModel;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly MOENDBContext _context;
        private readonly MOENDOCSContext _contextDoc;
        public AssetController(MOENDBContext context, MOENDOCSContext contextDoc)
        {
            _context = context;
            _contextDoc = contextDoc;

        }

        #region Asset 
        [HttpPost("GetListVAsset")]
        public async Task<IActionResult> GetListVAsset(SearchAssetModel model)
        {
            var whr = PredicateBuilder.True<VAsset>();

            bool isbelow = model.IsBelow == "Y" ? true : false;
            whr = whr.And(x => x.IsBelow == isbelow);

            if (model.AssetCategory != null) whr = whr.And(x => x.AssetCategory == model.AssetCategory);
            if (model.Code != null) whr = whr.And(x => x.Code.Contains(model.Code));
            if (model.AssetNumberGFMIS != null) whr = whr.And(x => x.AssetNumberGfmis.Contains(model.AssetNumberGFMIS));
            if (model.AssetTypeId != null) whr = whr.And(x => x.AssetTypeId == model.AssetTypeId);
            if (model.AssetClassId != null) whr = whr.And(x => x.AssetClassId == model.AssetClassId);
            if (model.OrganizationId != null) whr = whr.And(x => x.OrganizationId == model.OrganizationId);
            if (model.CostCenterId != null) whr = whr.And(x => x.CostCenterId == model.CostCenterId);
            if (model.ReceiveDateFrom != null) whr = whr.And(x => x.ReceiveDate >= model.ReceiveDateFrom);
            if (model.ReceiveDateTo != null) whr = whr.And(x => x.ReceiveDate <= model.ReceiveDateTo);
            if (model.AssetName != null) whr = whr.And(x => x.AssetName.Contains(model.AssetName));
            if (model.StorePlaceId != null) whr = whr.And(x => x.StorePlaceId == model.StorePlaceId);
            if (model.AssetStatus != null) whr = whr.And(x => x.AssetStatus == model.AssetStatus);
            if (model.BudgetYear != null) whr = whr.And(x => x.BudgetYear == model.BudgetYear);
            if (model.IsExpire != null) whr = whr.And(x => x.IsExpire == model.IsExpire);
            if (model.IsAssetNumberGFMIS != null) whr = whr.And(x => x.IsAssetNumberGfmis == model.IsAssetNumberGFMIS);

            var res = await _context.VAssets.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetVAssetById")]
        public async Task<IActionResult> GetVAssetById(int Id)
        {
            var res = await _context.VAssets.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return Ok(res);
        }

        [HttpGet("DeleteAsset")]
        public async Task<IActionResult> DeleteAsset(int asId)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.Assets.Where(x => x.Id == asId).FirstOrDefaultAsync();
                _context.Assets.Remove(item);
                await _context.SaveChangesAsync();

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }

        [HttpGet("GetAssetDetail")]
        public async Task<IActionResult> GetAssetDetail(int asId)
        {
            var data = new AssetDetailModel();

            data.asset = await _context.Assets.Where(x => x.Id == asId).FirstOrDefaultAsync() ?? new Asset();
            data.vAssetMaintenances = await _context.VAssetMaintenances.Where(x => x.AssetId == asId).ToListAsync();
            data.vAssetRelations = await _context.VAssetRelations.Where(x => x.AssetId == asId).ToListAsync();
            data.assetDepreciation = await _context.Database.SqlQueryRaw<FN_GetAssetDepreciation>($"select * from dbo.FN_GetAssetDepreciation({asId},null)").ToListAsync();
            data.vAssetChanges = await _context.VAssetChanges.Where(x => x.AssetId == asId).ToListAsync();
            data.vAsset = await _context.VAssets.Where(x => x.MainAssetId == asId).ToListAsync();

            if (data.asset.Id == 0) data = null;

            return Ok(data);
        }

        [HttpPost("SaveAsset")]
        public async Task<IActionResult> SaveAsset(AssetDetailModel data)
        {
            var result = new ApiResultsModel();
            try
            {
                result.Success = true;


                var model = data.asset;
                bool first = false;

                model.IsBelow ??= false;

                if (model.Id == 0)
                {
                    var masertCostCode = _context.MasterCostCenters.Where(x => x.Id == model.CostCenterId).FirstOrDefault()?.Code;
                    var masertTypeCode = _context.MasterAssetTypes.Where(x => x.Id == model.AssetTypeId).FirstOrDefault()?.Code;
                    var masertClassCode = _context.MasterAssetClasses.Where(x => x.Id == model.AssetClassId).FirstOrDefault()?.Code;

                    string costCenterPart = masertCostCode.Length >= 3 ? masertCostCode[^3..] : masertCostCode;

                    int buddhistYear = model.ReceiveDate == null ? model.CreateOn.Value.Year + 543 : model.ReceiveDate.Value.Year + 543;
                    string yearPart = buddhistYear.ToString()[^2..];

                    string typeCodePart = masertTypeCode.Length >= 3 ? masertTypeCode[^3..] : masertTypeCode;
                    string classCodePart = masertClassCode.Length >= 3 ? masertClassCode[^3..] : masertClassCode;

                    var running = _context.Assets.Where(x => x.CostCenterId == model.CostCenterId && x.ReceiveDate.Value.Year == buddhistYear && x.AssetTypeId == model.AssetTypeId && x.AssetClassId == model.AssetClassId).OrderByDescending(x => x.Running).FirstOrDefault();
                    model.Running = running == null ? 1 : (running.Running ?? 0) + 1;

                    model.Code = costCenterPart + "-" + yearPart + "-" + typeCodePart + "-" + classCodePart + "-" + model.Running?.ToString("D4");

                    var bYear = model.DocumentDate?.Year;
                    if (model.DocumentDate?.Month >= 10) bYear++;
                    model.BudgetYear = bYear + 543;
                    model.AssetStatus = "A";
                    _context.Assets.Add(model);
                    await _context.SaveChangesAsync();
                    first = true;
                }
                else
                {
                    var at = _context.Assets.FirstOrDefault(x => x.Id == model.Id);
                    at.UpdateBy = model.UpdateBy;
                    at.UpdateOn = model.UpdateOn;
                    at.CodeOld = model.CodeOld;
                    at.AssetNumberGfmis = model.AssetNumberGfmis;
                    at.OrganizationId = model.OrganizationId;
                    at.CostCenterId = model.CostCenterId;
                    at.AssetClassId = model.AssetClassId;
                    at.AssetTypeId = model.AssetTypeId;
                    at.AssetName = model.AssetName;
                    at.LifeTimeUse = model.LifeTimeUse;
                    at.LifeTimeDepreciation = model.LifeTimeDepreciation;
                    at.Cost = model.Cost;
                    at.ScrapValue = model.ScrapValue;
                    at.ApproveDate = model.ApproveDate;
                    at.ReceiveDate = model.ReceiveDate;
                    at.UnitId = model.UnitId;
                    at.Brand = model.Brand;
                    at.Model = model.Model;
                    at.Spec = model.Spec;
                    at.AssetDetail = model.AssetDetail;
                    at.SerialNumber = model.SerialNumber;
                    at.IsBelow = model.IsBelow;
                    at.AssetAcquisitionTypeId = model.AssetAcquisitionTypeId;
                    at.AssetBudgetTypeId = model.AssetBudgetTypeId;
                    at.BudgetYear = model.BudgetYear;
                    at.DocumentTypeId = model.DocumentTypeId;
                    at.DocumentNumber = model.DocumentNumber;
                    at.DocumentDate = model.DocumentDate;
                    at.SupplierId = model.SupplierId;
                    at.WarrantyStartDate = model.WarrantyStartDate;
                    at.WarrantyEndDate = model.WarrantyEndDate;
                    at.WarrantyTime = model.WarrantyTime;
                    at.WarrantyPeriod = model.WarrantyPeriod;
                    at.Remark = model.Remark;
                    at.StorePlaceId = model.StorePlaceId;
                    at.StorePlaceDetail = model.StorePlaceDetail;
                    at.IsInMa = model.IsInMa;
                    at.ProcurementId = model.ProcurementId;
                    at.ProcurementStartDate = model.ProcurementStartDate;
                    at.ProcurementEndDate = model.ProcurementEndDate;
                    at.CurrentResponsibleOfficerId = model.CurrentResponsibleOfficerId;
                    at.CurrentBorrowerOfficerId = model.CurrentBorrowerOfficerId;
                    at.SupplierName = model.SupplierName;
                    at.SupplierFullAddress = model.SupplierFullAddress;
                    at.SupplierPhone = model.SupplierPhone;
                    at.ProcurementCode = model.ProcurementCode;
                    at.ProcurementMethodId = model.ProcurementMethodId;
                    at.CarSeats = model.CarSeats;
                    at.FuelTypeId = model.FuelTypeId;
                    at.EngineNumber = model.EngineNumber;
                    at.ChassisNumber = model.ChassisNumber;
                    at.BuildingName = model.BuildingName;
                    at.LandTypeId = model.LandTypeId;
                    at.Ipaddress = model.Ipaddress;
                    at.ProviderName = model.ProviderName;

                    _context.Assets.Update(at);
                    await _context.SaveChangesAsync();

                    model = at;
                }

                if (data.copy > 0)
                {
                    for (int i = 0; i < data.copy; i++)
                    {
                        var newAsset = new Asset
                        {
                            CodeOld = model.CodeOld,
                            AssetNumberGfmis = model.AssetNumberGfmis,
                            OrganizationId = model.OrganizationId,
                            CostCenterId = model.CostCenterId,
                            AssetCategory = model.AssetCategory,
                            AssetClassId = model.AssetClassId,
                            AssetTypeId = model.AssetTypeId,
                            AssetName = model.AssetName,
                            AssetStatus = model.AssetStatus,
                            LifeTimeUse = model.LifeTimeUse,
                            LifeTimeDepreciation = model.LifeTimeDepreciation,
                            Depreciation = model.Depreciation,
                            ScrapValue = model.ScrapValue,
                            ApproveDate = model.ApproveDate,
                            ReceiveDate = model.ReceiveDate,
                            UnitId = model.UnitId,
                            Brand = model.Brand,
                            Model = model.Model,
                            Spec = model.Spec,
                            AssetDetail = model.AssetDetail,
                            SerialNumber = model.SerialNumber,
                            LicenseNumber = model.LicenseNumber,
                            EngineNumber = model.EngineNumber,
                            ChassisNumber = model.ChassisNumber,
                            CarSeats = model.CarSeats,
                            FuelTypeId = model.FuelTypeId,
                            LandTypeId = model.LandTypeId,
                            BuildingName = model.BuildingName,
                            Ipaddress = model.Ipaddress,
                            ProviderName = model.ProviderName,
                            IsBelow = model.IsBelow,
                            Running = model.Running,
                            AssetAcquisitionTypeId = model.AssetAcquisitionTypeId,
                            AssetBudgetTypeId = model.AssetBudgetTypeId,
                            BudgetYear = model.BudgetYear,
                            DocumentTypeId = model.DocumentTypeId,
                            DocumentNumber = model.DocumentNumber,
                            DocumentDate = model.DocumentDate,
                            SupplierId = model.SupplierId,
                            SupplierName = model.SupplierName,
                            SupplierFullAddress = model.SupplierFullAddress,
                            SupplierPhone = model.SupplierPhone,
                            WarrantyStartDate = model.WarrantyStartDate,
                            WarrantyEndDate = model.WarrantyEndDate,
                            WarrantyTime = model.WarrantyTime,
                            WarrantyPeriod = model.WarrantyPeriod,
                            Remark = model.Remark,
                            StorePlaceId = model.StorePlaceId,
                            StorePlaceDetail = model.StorePlaceDetail,
                            RfidtagNumber = model.RfidtagNumber,
                            IsUsable = model.IsUsable,
                            UnusableDetail = model.UnusableDetail,
                            IsInMa = model.IsInMa,
                            ProcurementId = model.ProcurementId,
                            ProcurementAssetItemId = model.ProcurementAssetItemId,
                            ProcurementCode = model.ProcurementCode,
                            ProcurementStartDate = model.ProcurementStartDate,
                            ProcurementEndDate = model.ProcurementEndDate,
                            ProcurementMethodId = model.ProcurementMethodId,
                            CurrentResponsibleOfficerId = model.CurrentResponsibleOfficerId,
                            CurrentBorrowerOfficerId = model.CurrentBorrowerOfficerId,

                            CreateBy = data.userId,
                            CreateOn = DateTime.Now,

                        };

                        if (data.asset.AssetCategory == "D")
                        {
                            newAsset.MainAssetId = model.Id;
                            newAsset.IsChild = true;
                            newAsset.Cost = 0;
                            newAsset.IsSet = true;
                            var checkCopy = _context.Assets.Where(x => x.MainAssetId == model.Id).ToList().Count() + 1;
                            newAsset.Code = model.Code + "-" + checkCopy.ToString() + "/" + data.copy.ToString();
                        }
                        else
                        {
                            int buddhistYear = model.ReceiveDate == null ? newAsset.CreateOn.Value.Year + 543 : newAsset.ReceiveDate.Value.Year + 543;
                            string yearPart = buddhistYear.ToString()[^2..];

                            var running = _context.Assets.Where(x => x.CostCenterId == model.CostCenterId && x.ReceiveDate.Value.Year == buddhistYear && x.AssetTypeId == model.AssetTypeId && x.AssetClassId == model.AssetClassId).OrderByDescending(x => x.Running).FirstOrDefault();
                            newAsset.Running = running == null ? 1 : (running.Running ?? 0) + 1;

                            string newCode = model.Code.Substring(0, model.Code.Length - 4);
                            newAsset.Code = newAsset.Code + newAsset.Running?.ToString("D4");
                        }

                        _context.Assets.Add(newAsset);
                        await _context.SaveChangesAsync();
                    }
                }


                var no = 1;
                foreach (var item in data.FileGuidId ?? new List<string>())
                {
                    var file = _contextDoc.AssetImages.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                    if (file != null)
                    {
                        file.AssetId = model.Id;
                        file.Sequence = no;
                        _contextDoc.AssetImages.Update(file);
                        await _contextDoc.SaveChangesAsync();
                        no++;
                    }
                }

                foreach (var item in data.vAssetMaintenances ?? new List<VAssetMaintenance>())
                {
                    var am = new AssetMaintenance
                    {
                        Id = item.Id,
                        CreateBy = item.CreateBy,
                        CreateOn = item.CreateOn,
                        UpdateBy = item.UpdateBy,
                        UpdateOn = item.UpdateOn,
                        AssetId = model.Id,
                        ReceiveDate = item.ReceiveDate,
                        RequestDate = item.RequestDate,
                        MaintenanceDetail = item.MaintenanceDetail,
                        Cost = item.Cost,
                        Remark = item.Remark,
                        SupplierName = item.SupplierName,
                        SupplierId = item.SupplierId,
                        ApproveDate = item.ApproveDate,
                        AccountingDate = item.AccountingDate,
                        Amount = item.Amount,
                        TotalCost = item.TotalCost,
                    };
                    _context.AssetMaintenances.Update(am);
                    await _context.SaveChangesAsync();
                }

                if (first)
                {
                    var cad = await _context.Database.SqlQueryRaw<FN_CreateAssetDepreciation>($"select * from dbo.FN_CreateAssetDepreciation({model.Id})").FirstOrDefaultAsync();
                    var adt = new AssetDepreciation
                    {
                        CreateBy = model.CreateBy,
                        CreateOn = model.CreateOn,
                        AssetId = model.Id,
                        DayNumber = cad.DayNumber,
                        YearRunning = cad.YearRunning,
                        YearDepreciation = cad.YearDepreciation,
                        AccumDepreciation = cad.AccumDepreciation,
                        NetValue = cad.NetValue,
                        DepreciationDate = cad.DepreciationDate
                    };
                    _context.AssetDepreciations.Update(adt);
                    await _context.SaveChangesAsync();
                }

                result.Id = model.Id;

                if (data.vAssetRelations.Count > 0)
                {
                    foreach (var item in data.vAssetRelations ?? new List<VAssetRelation>())
                    {
                        var checkRelation = _context.AssetRelations.FirstOrDefault(x => x.AssetId == model.Id);
                        var checkRelation2 = _context.AssetRelations.FirstOrDefault(x => x.AssetId == item.AssetId);

                        if (checkRelation == null && checkRelation2 == null)
                        {
                            var checkRunning = _context.VAssetRelations.OrderByDescending(x => x.GroupRunning).FirstOrDefault();
                            var groupRunning = checkRunning == null ? 1 : checkRunning.GroupRunning + 1;

                            _context.AssetRelations.Add(new AssetRelation { AssetId = model.Id, GroupRunning = groupRunning, CreateBy = model.CreateBy, CreateOn = model.CreateOn });
                            _context.AssetRelations.Add(new AssetRelation { AssetId = item.AssetId, GroupRunning = groupRunning, CreateBy = model.CreateBy, CreateOn = model.CreateOn });
                        }
                        else if (checkRelation == null && checkRelation2 != null)
                        {
                            _context.AssetRelations.Add(new AssetRelation { AssetId = model.Id, GroupRunning = checkRelation2.GroupRunning, CreateBy = model.CreateBy, CreateOn = model.CreateOn });
                        }
                        else if (checkRelation != null && checkRelation2 == null)
                        {
                            _context.AssetRelations.Add(new AssetRelation { AssetId = item.AssetId, GroupRunning = checkRelation.GroupRunning, CreateBy = model.CreateBy, CreateOn = model.CreateOn });
                        }
                        else if (checkRelation != null && checkRelation2 != null)
                        {
                            if (checkRelation.GroupRunning == checkRelation2.GroupRunning)
                            {
                                result.Message = "ครุภัณฑ์ทั้งสองมีความเกี่ยวข้องกันอยู่แล้ว";
                                result.Success = false;
                            }
                            else
                            {
                                result.Message = "ไม่สามารถเพิ่มความเกี่ยวข้องระหว่างครุภัณฑ์ทั้งสองได้";
                                result.Success = false;
                            }
                        }
                        _context.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }
        [HttpGet("GetDepreciation")]
        public async Task<IActionResult> GetDepreciation(DateTime? DateDepreciation, int asId, bool reset, int userId)
        {
            var data = new AssetDetailModel();

            if (reset)
            {
                var olddata = await _context.AssetDepreciations.Where(x => x.AssetId == asId).FirstOrDefaultAsync();
                if (olddata != null)
                {
                    _context.Remove(olddata);
                    await _context.SaveChangesAsync();
                }

                var cad = await _context.Database.SqlQueryRaw<FN_CreateAssetDepreciation>($"select * from dbo.FN_CreateAssetDepreciation({asId})").FirstOrDefaultAsync();
                var adt = new AssetDepreciation
                {
                    CreateBy = userId,
                    CreateOn = DateTime.Now,
                    AssetId = asId,
                    DayNumber = cad.DayNumber,
                    YearRunning = cad.YearRunning,
                    YearDepreciation = cad.YearDepreciation,
                    AccumDepreciation = cad.AccumDepreciation,
                    NetValue = cad.NetValue,
                    DepreciationDate = cad.DepreciationDate
                };
                _context.AssetDepreciations.Update(adt);
                await _context.SaveChangesAsync();
            }


            data.asset = await _context.Assets.Where(x => x.Id == asId).FirstOrDefaultAsync() ?? new Asset();
            data.assetDepreciation = await _context.Database.SqlQueryRaw<FN_GetAssetDepreciation>($"select * from dbo.FN_GetAssetDepreciation({asId},{DateDepreciation?.ToString("dd/MM/yyyy") ?? "null"})").ToListAsync();

            if (data.asset.Id == 0) data = null;

            return Ok(data);
        }

        #endregion

        #region AssetMaterialCentralList AssetMaterialOrganizationList AssetMaterialProvinceList
        [HttpGet("GetListVMaterialStock")]
        public async Task<IActionResult> GetListVMaterialStock(string? gpscCode, string? materialName, int? warehouseId)
        {
            var whr = PredicateBuilder.True<VMaterialStock>();

            if (gpscCode != null && gpscCode != "") whr = whr.And(x => x.Gpsccode == gpscCode);
            if (materialName != null && materialName != "") whr = whr.And(x => x.MaterialName.Contains(materialName));
            if (warehouseId != null && warehouseId != 0) whr = whr.And(x => x.WarehouseId == warehouseId);

            var res = await _context.VMaterialStocks.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetTableVSupplier")]
        public async Task<IActionResult> GetTableVSupplier(string? nameThai)
        {
            var whr = PredicateBuilder.True<VSupplier>();

            if (nameThai != null && nameThai != "") whr = whr.And(x => x.NameThai.Contains(nameThai));

            var res = await _context.VSuppliers.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetTableVProcurement")]
        public async Task<IActionResult> GetTableVProcurement(int? pmcBudgetYear, string? pmcCode, DateTime? pmcContractDateFrom, DateTime? pmcContractDateTo, string? pmcSupplierName)
        {
            var whr = PredicateBuilder.True<VProcurement>();

            if (pmcBudgetYear != null && pmcBudgetYear != 0) whr = whr.And(x => x.BudgetYear == pmcBudgetYear);
            if (pmcCode != null && pmcCode != "") whr = whr.And(x => x.Code.Contains(pmcCode));
            if (pmcContractDateFrom != null) whr = whr.And(x => x.ContractDate >= pmcContractDateFrom);
            if (pmcContractDateTo != null) whr = whr.And(x => x.ContractDate <= pmcContractDateTo);
            if (pmcSupplierName != null && pmcSupplierName != "") whr = whr.And(x => x.SupplierName.Contains(pmcSupplierName));

            var res = await _context.VProcurements.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMaterialInDetailModel")]
        public async Task<IActionResult> GetMaterialInDetailModel(int id)
        {
            var data = new MaterialInDetailModel();
            data.materialIn = await _context.MaterialIns.FirstOrDefaultAsync(x => x.Id == id) ?? new MaterialIn();
            data.lstVMaterialInItems = await _context.VMaterialInItems.Where(x => x.MaterialInId == id).ToListAsync();
            return Ok(data);
        }

        [HttpPost("SaveMaterialIn")]
        public async Task<IActionResult> SaveMaterialIn(MaterialInDetailModel data)
        {
            var result = new ApiResultsModel();
            try
            {
                var currentYear = DateTime.Now.Year;
                var currentMonth = DateTime.Now.Month;

                var fiscalYearStart = new DateTime(currentYear - 1, 10, 1);

                if (currentMonth >= 10)
                {
                    fiscalYearStart = new DateTime(currentYear, 10, 1);
                }

                var model = data.materialIn;

                if (model.Id == 0)
                {
                    var running = _context.MaterialIns.Where(x => x.CreateOn >= fiscalYearStart).OrderByDescending(x => x.Running).FirstOrDefault();
                    model.Running = running == null ? 1 : running.Running + 1;
                    model.Code = model.Running.ToString() + "/" + (model.CreateOn.Value.Year + 543).ToString();
                    model.ReceiveDate = DateTime.Now;
                    model.Status = "N";

                    _context.MaterialIns.Add(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var mti = _context.MaterialIns.FirstOrDefault(x => x.Id == model.Id);
                    mti.UpdateBy = model.UpdateBy;
                    mti.UpdateOn = model.UpdateOn;
                    mti.PurchaseDate = model.PurchaseDate;
                    mti.ProcurementNumber = model.ProcurementNumber;
                    mti.SupplierId = model.SupplierId;
                    mti.SupplierName = model.SupplierName;
                    mti.Status = model.Status;
                    mti.ReceiveDate = model.ReceiveDate;
                    mti.WarehouseId = model.WarehouseId;
                    mti.PurchasingWareHouseId = model.PurchasingWareHouseId;

                    _context.MaterialIns.Update(mti);
                    await _context.SaveChangesAsync();

                    model = mti;
                }

                var datenow = DateTime.Now;

                foreach (var item in data.lstVMaterialInItems ?? new List<VMaterialInItem>())
                {
                    var mtii = new MaterialInItem
                    {
                        CreateBy = item.CreateBy,
                        CreateOn = item.CreateOn,
                        Gpsccode = item.Gpsccode,
                        IncludeVat = item.IncludeVat,
                        MaterialInId = model.Id,
                        ReceiveAmount = item.ReceiveAmount,
                        TotalPrice = item.TotalPrice,
                        UnitId = item.UnitId,
                        UnitPrice = item.UnitPrice,
                        UnitPriceNoVat = item.UnitPriceNoVat,
                        Vat = item.Vat,
                        UpdateBy = item.UpdateBy,
                        UpdateOn = datenow,
                        Id = item.Id,
                    };
                    _context.MaterialInItems.Update(mtii);
                    await _context.SaveChangesAsync();
                }

                var removeMtii = _context.MaterialInItems.Where(x => x.MaterialInId == model.Id).ToList();
                removeMtii = removeMtii.Where(x => x.UpdateOn.ToString() != datenow.ToString()).ToList();
                _context.MaterialInItems.RemoveRange(removeMtii);
                await _context.SaveChangesAsync();

                if (model.Status == "A")
                {

                    var mtrId = 0;
                    var warehouseId = model.MaterialInType == 1 ? 1 : model.WarehouseId;


                    if (model.MaterialInType == 1)
                    {
                        var checkrunning = _context.MaterialRequisitions.Where(x => x.CreateOn >= fiscalYearStart).OrderByDescending(x => x.Running).FirstOrDefault();
                        var running = checkrunning == null ? 1 : checkrunning.Running + 1;

                        var mtr = new MaterialRequisition
                        {
                            CreateBy = model.UpdateBy,
                            CreateOn = datenow,
                            Running = running,
                            Code = running.ToString() + "/" + (datenow.Year + 543).ToString(),
                            RequestDate = model.ReceiveDate,
                            RequestType = 1,
                            WarehouseId = model.WarehouseId,
                            StatusId = 1,
                        };
                        _context.MaterialRequisitions.Add(mtr);
                        await _context.SaveChangesAsync();
                        mtrId = mtr.Id;
                    }

                    var lstMri = _context.MaterialInItems.Where(x => x.MaterialInId == model.Id).ToList();
                    foreach (var item in lstMri)
                    {
                        if (model.MaterialInType == 1)
                        {
                            var mtri = new MaterialRequisitionItem
                            {
                                CreateBy = model.UpdateBy,
                                CreateOn = datenow,
                                RequisitionId = mtrId,
                                MaterialId = item.MaterialId,
                                Gpsccode = item.Gpsccode,
                                RequestAmount = item.ReceiveAmount,
                                UnitId = item.UnitId,
                                UnitPrice = item.UnitPrice,
                                TotalPrice = item.TotalPrice,
                                MaterialInItemId = item.Id
                            };
                            _context.MaterialRequisitionItems.Add(mtri);
                            await _context.SaveChangesAsync();
                        }
                        var ms = new MaterialStock
                        {
                            CreateBy = model.UpdateBy,
                            CreateOn = datenow,
                            MaterialId = item.MaterialId,
                            ReceiveDate = model.ReceiveDate,
                            StockIn = item.ReceiveAmount,
                            Available = item.ReceiveAmount,
                            UnitId = item.UnitId,
                            WarehouseId = warehouseId,
                            MaterialInItemId = item.Id,
                            WarehouseLevel = model.WarehouseLevel,
                            UnitPrice = item.UnitPrice,
                            UnitPriceNoVat = item.UnitPriceNoVat,
                            TotalPrice = item.TotalPrice
                        };
                        _context.MaterialStocks.Add(ms);
                        await _context.SaveChangesAsync();

                        var msm = new MaterialStockMovement
                        {
                            CreateBy = model.UpdateBy,
                            CreateOn = datenow,
                            MaterialId = item.MaterialId,
                            TransactionType = "I",
                            ReferenceTable = "MaterialInItem",
                            ReferenceId = item.Id,
                            TargetWareHouseId = warehouseId,
                            TargetMaterialStockId = ms.Id,
                            AfterTargetMaterial = item.ReceiveAmount,
                            ProcessDate = datenow,
                            Amount = item.ReceiveAmount,
                            Price = item.UnitPrice
                        };
                        _context.MaterialStockMovements.Add(msm);
                        await _context.SaveChangesAsync();
                    }

                }

                await _context.SaveChangesAsync();
                result.Success = true;
                result.Id = model.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return Ok(result);
        }

        #endregion

        #region AssetParcelReceiveHistory
        [HttpGet("GetListVMaterialIn")]
        public async Task<IActionResult> GetListVMaterialIn(string? code, DateTime? receiveDate, string? supplierName)
        {
            var whr = PredicateBuilder.True<VMaterialIn>();

            if (code != null && code != "") whr = whr.And(x => x.Code.Contains(code));
            if (receiveDate != null) whr = whr.And(x => x.ReceiveDate.Value.Date == receiveDate.Value.Date);
            if (supplierName != null && supplierName != "") whr = whr.And(x => x.SupplierName.Contains(supplierName));

            var res = await _context.VMaterialIns.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("DelMaterialInHistory")]
        public async Task<IActionResult> DelMaterialInHistory(int? id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MaterialIns.FirstOrDefaultAsync(x => x.Id == id);
                if (item != null)
                {
                    _context.MaterialIns.Remove(item);
                    await _context.SaveChangesAsync();
                }

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }

        #endregion

        #region AssetBorrowMaterialList
        [HttpGet("GetListVMaterialBorrow")]
        public async Task<IActionResult> GetListVMaterialBorrow(DateTime? BorrowerDateFrom, DateTime? BorrowerDateTo, int? SourceOrganizationId, int? StatusId)
        {
            var whr = PredicateBuilder.True<VMaterialBorrow>();

            if (BorrowerDateFrom != null) whr = whr.And(x => x.BorrowDate >= BorrowerDateFrom);
            if (BorrowerDateTo != null) whr = whr.And(x => x.BorrowDate <= BorrowerDateFrom);
            if (SourceOrganizationId != null) whr = whr.And(x => x.SourceOrganizationId == SourceOrganizationId);
            if (StatusId != null) whr = whr.And(x => x.StatusId == StatusId);

            var res = await _context.VMaterialBorrows.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetAssetBorrowMaterialDetail")]
        public async Task<IActionResult> GetAssetBorrowMaterialDetail(int? mbId)
        {
            var data = new MaterialDetailModel();

            data.materialBorrow = await _context.MaterialBorrows.Where(x => x.Id == mbId).FirstOrDefaultAsync() ?? new MaterialBorrow();
            data.vMaterialBorrowItems = await _context.VMaterialBorrowItems.Where(x => x.MaterialBorrowId == mbId).ToListAsync();

            return Ok(data);
        }

        [HttpGet("GetListVMaterialStockCheck")]
        public async Task<IActionResult> GetListVMaterialStockCheck(string? MaterialName, string? GPSCCode, int? sourceOrganizationId)
        {
            var whr = PredicateBuilder.True<VMaterialStock>();

            if (MaterialName != null) whr = whr.And(x => x.MaterialName.Contains(MaterialName));
            if (GPSCCode != null) whr = whr.And(x => x.Gpsccode.Contains(GPSCCode));
            if (sourceOrganizationId != null) whr = whr.And(x => x.OrganizationId == sourceOrganizationId);
            whr = whr.And(x => x.Id != null);
            var data = await _context.VMaterialStocks.Where(whr).ToListAsync();
            return Ok(data);
        }

        [HttpPost("SaveAssetAssetBorrowMaterialDetail")]
        public async Task<IActionResult> SaveAssetAssetBorrowMaterialDetail(MaterialDetailModel data)
        {
            var result = new ApiResultsModel();
            try
            {
                var currentYear = DateTime.Now.Year;
                var currentMonth = DateTime.Now.Month;

                var fiscalYearStart = new DateTime(currentYear - 1, 10, 1);

                if (currentMonth >= 10)
                {
                    fiscalYearStart = new DateTime(currentYear, 10, 1);
                }

                var model = data.materialBorrow;
                if (model.Id == 0)
                {
                    var running = _context.MaterialBorrows.Where(x => x.CreateOn >= fiscalYearStart).OrderByDescending(x => x.Running).FirstOrDefault();
                    model.Running = running == null ? 1 : running.Running + 1;
                    model.Code = model.Running.ToString() + "/" + (model.CreateOn.Value.Year + 543).ToString();

                    var bYear = model.BorrowDate?.Year;
                    if (model.BorrowDate?.Month >= 10) bYear++;
                    model.BudgetYear = bYear + 543;

                    _context.MaterialBorrows.Add(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var mtb = _context.MaterialBorrows.FirstOrDefault(x => x.Id == model.Id);
                    mtb.UpdateBy = model.UpdateBy;
                    mtb.UpdateOn = model.UpdateOn;
                    mtb.BorrowerBy = model.BorrowerBy;
                    mtb.SourceOrganizationId = model.SourceOrganizationId;
                    mtb.TargetOrganizationId = model.TargetOrganizationId;
                    mtb.ApproveBy = model.ApproveBy;
                    mtb.BorrowerBy = mtb.BorrowerBy;

                    _context.MaterialBorrows.Update(mtb);
                    await _context.SaveChangesAsync();

                    model = mtb;
                }

                foreach (var item in data.vMaterialBorrowItems ?? new List<VMaterialBorrowItem>())
                {
                    var mtbi = new MaterialBorrowItem
                    {
                        CreateBy = item.CreateBy,
                        CreateOn = item.CreateOn,
                        UpdateBy = item.UpdateBy,
                        UpdateOn = item.UpdateOn,
                        MaterialId = item.MaterialId,
                        MaterialBorrowId = model.Id,
                        Remark = item.Remark,
                        BorrowAmount = item.BorrowAmount,
                        ReceiveAmount = item.ReceiveAmount,
                        UnitId = item.UnitId,
                        Id = item.Id,
                        ReturnBy = item.ReturnBy,
                        ReturneeBy = item.ReturneeBy,
                        ReturnReceiveDate = item.ReturnReceiveDate,
                        StatusId = item.StatusId,
                        ReturnDate = item.ReturnDate
                    };
                    _context.MaterialBorrowItems.Update(mtbi);
                    await _context.SaveChangesAsync();
                }

                var MaterialBorrowItem = await _context.MaterialBorrowItems.Where(x => x.MaterialBorrowId == model.Id).ToListAsync();
                var lstNo = data.vMaterialBorrowItems?.Select(x => x.Id);
                var filteredList = MaterialBorrowItem.Where(x => !lstNo.Contains(x.Id)).ToList();
                _context.MaterialBorrowItems.RemoveRange(filteredList);
                await _context.SaveChangesAsync();

                foreach (var item in data.FileGuidId ?? new List<string>())
                {
                    var file = _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                    file.ReferenceId = model.Id;
                    file.Sequence = 1; //แนบได้ไฟล์เดียว

                    _contextDoc.AttachFiles.Update(file);
                    await _contextDoc.SaveChangesAsync();
                }
                result.Success = true;
                result.Id = model.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return Ok(result);
        }

        #endregion

        #region AssetBorrow

        [HttpGet("GetAssetBorrowDetail")]
        public async Task<IActionResult> GetAssetBorrowDetail(int? abId)
        {
            var data = new AssetBorrowDetailModel();

            data.assetBorrow = await _context.AssetBorrows.Where(x => x.Id == abId).FirstOrDefaultAsync() ?? new AssetBorrow();
            data.vAssetBorrowItem = await _context.VAssetBorrowItems.Where(x => x.AssetBorrowId == abId).ToListAsync();

            return Ok(data);
        }

        [HttpGet("GetListVAssetBorrowList")]
        public async Task<IActionResult> GetListVAssetBorrowList(string? AssetBorrowType, int? StatusId, DateTime? DocumentDateFrom, DateTime? DocumentDateTo, string? IsReturn)
        {
            var whr = PredicateBuilder.True<VAssetBorrow>();

            if (DocumentDateFrom != null) whr = whr.And(x => x.DocumentDate >= DocumentDateFrom);
            if (DocumentDateTo != null) whr = whr.And(x => x.DocumentDate <= DocumentDateTo);
            if (AssetBorrowType != null) whr = whr.And(x => x.AssetBorrowType == AssetBorrowType);
            if (StatusId != null) whr = whr.And(x => x.StatusId == StatusId);
            if (IsReturn != null) whr = whr.And(x => x.IsReturn == IsReturn);

            var res = await _context.VAssetBorrows.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetListVAsset")]
        public async Task<IActionResult> GetListVAsset(string? AssetNumberGFMIS, string? Code)
        {
            var whr = PredicateBuilder.True<VAsset>();

            if (AssetNumberGFMIS != null) whr = whr.And(x => x.AssetNumberGfmis.Contains(AssetNumberGFMIS));
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));
            whr = whr.And(x => x.AssetStatus == "A" && x.CurrentBorrowerOfficerId == null);
            var res = await _context.VAssets.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetListVAssetCurrentResponsible")]
        public async Task<IActionResult> GetListVAssetCurrentResponsible(string? AssetNumberGFMIS, string? Code, int OfficerId)
        {
            var whr = PredicateBuilder.True<VAsset>();

            if (AssetNumberGFMIS != null) whr = whr.And(x => x.AssetNumberGfmis.Contains(AssetNumberGFMIS));
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));

            whr = whr.And(x => x.CurrentResponsibleOfficerId == OfficerId && x.CurrentBorrowerOfficerId == null);
            var res = await _context.VAssets.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetListVAssetGroup")]
        public async Task<IActionResult> GetListVAssetGroup(string? AssetNumberGFMIS, string? Code, int AsId)
        {
            var whr = PredicateBuilder.True<VAsset>();

            if (AssetNumberGFMIS != null) whr = whr.And(x => x.AssetNumberGfmis.Contains(AssetNumberGFMIS));
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));
            whr = whr.And(x => x.Id != AsId);

            if (AsId != 0)
            {
                var checkGrup = await _context.VAssets.Where(x => x.Id == AsId).FirstOrDefaultAsync();
                if (checkGrup?.GroupRunning != null)
                {
                    whr = whr.And(x => x.GroupRunning == null);
                }
            }

            var res = await _context.VAssets.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpPost("SaveAssetBorrowDetail")]
        public async Task<IActionResult> SaveAssetBorrowDetail(AssetBorrowDetailModel data)
        {
            var result = new ApiResultsModel();
            try
            {
                var currentYear = DateTime.Now.Year;
                var currentMonth = DateTime.Now.Month;

                var fiscalYearStart = new DateTime(currentYear - 1, 10, 1);

                if (currentMonth >= 10)
                {
                    fiscalYearStart = new DateTime(currentYear, 10, 1);
                }

                var model = data.assetBorrow;

                var lstofficer = _context.VOfficers.ToList();

                if (model.BorrowerOfficerId != null) model.BorrowerOfficerName = lstofficer.Where(x => x.Id == model.BorrowerOfficerId).FirstOrDefault()?.FullName;
                if (model.BorrowApproveOfficerId != null) model.BorrowApproveOfficerName = lstofficer.Where(x => x.Id == model.BorrowApproveOfficerId).FirstOrDefault()?.FullName;
                if (model.LenderOfficerId != null)
                {
                    var lender = lstofficer.Where(x => x.Id == model.LenderOfficerId).FirstOrDefault();
                    model.LenderOfficerName = lender?.FullName;
                    model.LenderOrganizationId = lender?.OrganizationId;
                }
                if (model.LendApproveOfficerId != null) model.LendApproveOfficerName = lstofficer.Where(x => x.Id == model.LendApproveOfficerId).FirstOrDefault()?.FullName;


                if (model.Id == 0)
                {
                    var running = _context.AssetBorrows.Where(x => x.CreateOn >= fiscalYearStart).OrderByDescending(x => x.Running).FirstOrDefault();
                    model.Running = running == null ? 1 : running.Running + 1;
                    model.Code = model.Running.ToString() + "/" + (model.CreateOn.Value.Year + 543).ToString();

                    var bYear = model.DocumentDate?.Year;
                    if (model.DocumentDate?.Month >= 10) bYear++;
                    model.BudgetYear = bYear + 543;

                    _context.AssetBorrows.Add(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var ab = _context.AssetBorrows.FirstOrDefault(x => x.Id == model.Id);
                    ab.UpdateBy = model.UpdateBy;
                    ab.UpdateOn = model.UpdateOn;
                    ab.DocumentDate = model.DocumentDate;
                    ab.AssetBorrowType = model.AssetBorrowType;
                    ab.BorrowApproveOfficerId = model.BorrowApproveOfficerId;
                    ab.BorrowApproveOfficerName = model.BorrowApproveOfficerName;
                    ab.BorrowerPositionName = model.BorrowerPositionName;
                    ab.BorrowerOrganizationId = model.BorrowerOrganizationId;
                    ab.BorrowerDivisionName = model.BorrowerDivisionName;
                    ab.BorrowerOfficerType = model.BorrowerOfficerType;
                    ab.BorrowerPhoneExtension = model.BorrowerPhoneExtension;
                    ab.BorrowerMobile = model.BorrowerMobile;
                    ab.BorrowerEmail = model.BorrowerEmail;
                    ab.Detail = model.Detail;
                    ab.BorrowFromDate = model.BorrowFromDate;
                    ab.DueDate = model.DueDate;
                    ab.BorrowerType = model.BorrowerType;
                    ab.OtherName = model.OtherName;
                    ab.OtherPositionName = model.OtherPositionName;
                    ab.OtherPhoneExtension = model.OtherPhoneExtension;
                    ab.OtherMobile = model.OtherMobile;
                    ab.OtherEmail = model.OtherEmail;
                    ab.BorrowerOfficerId = model.BorrowerOfficerId;
                    ab.BorrowerOfficerName = model.BorrowerOfficerName;
                    ab.BorrowApproveDate = model.BorrowApproveDate;
                    ab.LenderOfficerId = model.LenderOfficerId;
                    ab.LenderOfficerName = model.LenderOfficerName;
                    ab.LendDate = model.LendDate;
                    ab.LenderOrganizationId = model.LenderOrganizationId;
                    ab.LendApproveOfficerId = model.LendApproveOfficerId;
                    ab.LendApproveOfficerName = model.LendApproveOfficerName;
                    ab.LendApproveDate = model.LendApproveDate;
                    ab.ReceiveOfficerId = model.ReceiveOfficerId;
                    ab.ReceiveOfficerName = model.ReceiveOfficerName;
                    ab.ReceiveDate = model.ReceiveDate;
                    ab.BorrowDocument = model.BorrowDocument;
                    ab.Remark = model.Remark;


                    _context.AssetBorrows.Update(ab);
                    await _context.SaveChangesAsync();

                    model = ab;
                }

                var listId = new List<int>();

                foreach (var item in data.vAssetBorrowItem ?? new List<VAssetBorrowItem>())
                {
                    var abi = new AssetBorrowItem
                    {
                        CreateBy = item.CreateBy,
                        CreateOn = item.CreateOn,
                        UpdateBy = item.UpdateBy,
                        UpdateOn = item.UpdateOn,
                        AssetBorrowId = model.Id,
                        AssetId = item.AssetId,
                        BorrowDetail = item.BorrowDetail,
                        IsUsable = item.IsUsable,
                        ReturnDetail = item.ReturnDetail,
                        Id = item.Id,
                        AssetBorrowStatus = item.AssetBorrowStatus,
                        ReceiveOfficerId = item.ReceiveOfficerId,
                        ReceiveOfficerName = item.ReceiveOfficerName,
                        ReceiveDate = item.ReceiveDate,
                        ReturnOfficerId = item.ReturnOfficerId,
                        ReturnOfficerName = item.ReturnOfficerName,
                        ReturnDate = item.ReturnDate,
                    };
                    _context.AssetBorrowItems.Update(abi);
                    await _context.SaveChangesAsync();
                    listId.Add(abi.Id);
                }

                var removeList = await _context.AssetBorrowItems.Where(x => x.AssetBorrowId == model.Id).ToListAsync();
                foreach (var item in listId) removeList = removeList.Where(x => x.Id != item).ToList();

                _context.AssetBorrowItems.RemoveRange(removeList);
                await _context.SaveChangesAsync();

                foreach (var item in data.FileGuidId ?? new List<string>())
                {
                    var file = _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                    file.ReferenceId = model.Id;
                    file.Sequence = 1; //แนบได้ไฟล์เดียว

                    _contextDoc.AttachFiles.Update(file);
                    await _contextDoc.SaveChangesAsync();
                }
                result.Success = true;
                result.Id = model.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return Ok(result);
        }

        #endregion

        #region AssetTransferList
        [HttpGet("GetListVAssetTransfer")]
        public async Task<IActionResult> GetListVAssetTransfer(string? Code, int? StatusId, DateTime? DocumentDateFrom, DateTime? DocumentDateTo, int? TransferOrganizationId, int? DestinationOrganizationId)
        {
            var whr = PredicateBuilder.True<VAssetTransfer>();

            if (DocumentDateFrom != null) whr = whr.And(x => x.DocumentDate >= DocumentDateFrom);
            if (DocumentDateTo != null) whr = whr.And(x => x.DocumentDate <= DocumentDateTo);
            if (StatusId != null) whr = whr.And(x => x.StatusId == StatusId);
            if (TransferOrganizationId != null) whr = whr.And(x => x.TransferOrganizationId == TransferOrganizationId);
            if (DestinationOrganizationId != null) whr = whr.And(x => x.DestinationOrganizationId == DestinationOrganizationId);
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));

            var res = await _context.VAssetTransfers.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("DeleteAssetTransfer")]
        public async Task<IActionResult> DeleteAssetTransfer(int atId)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.AssetTransfers.Where(x => x.Id == atId).FirstOrDefaultAsync();
                _context.AssetTransfers.Remove(item);
                await _context.SaveChangesAsync();

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }

        [HttpGet("GetAssetTransferDetail")]
        public async Task<IActionResult> GetAssetTransferDetail(int atId)
        {
            var data = new AssetTransferDetailModel();

            data.assetTransfer = await _context.AssetTransfers.Where(x => x.Id == atId).FirstOrDefaultAsync() ?? new AssetTransfer();
            data.vAssetTransferItems = await _context.VAssetTransferItems.Where(x => x.AssetTransferId == atId).ToListAsync();

            return Ok(data);
        }

        [HttpGet("GetListVAssetItemTransfer")]
        public async Task<IActionResult> GetListVAssetItemTransfer(string? AssetNumberGFMIS, string? Code, int? AssetTypeId, int? AssetClassId)
        {
            var whr = PredicateBuilder.True<VAsset>();

            if (AssetNumberGFMIS != null) whr = whr.And(x => x.AssetNumberGfmis.Contains(AssetNumberGFMIS));
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));
            if (AssetTypeId != null) whr = whr.And(x => x.AssetTypeId == AssetTypeId);
            if (AssetClassId != null) whr = whr.And(x => x.AssetClassId == AssetClassId);


            whr = whr.And(x => x.AssetStatus == "A");
            var res = await _context.VAssets.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpPost("SaveAssetTransfer")]
        public async Task<IActionResult> SaveAssetTransfer(AssetTransferDetailModel data)
        {
            var result = new ApiResultsModel();
            try
            {
                var currentYear = DateTime.Now.Year;
                var currentMonth = DateTime.Now.Month;

                var fiscalYearStart = new DateTime(currentYear - 1, 10, 1);

                if (currentMonth >= 10)
                {
                    fiscalYearStart = new DateTime(currentYear, 10, 1);
                }

                var model = data.assetTransfer;

                var lstofficer = _context.VOfficers.ToList();

                if (model.ReceiveOfficerId != null) model.ReceiveOfficerName = lstofficer.Where(x => x.Id == model.ReceiveOfficerId).FirstOrDefault()?.FullName;
                if (model.TransferOfficerId != null) model.TransferOfficerName = lstofficer.Where(x => x.Id == model.TransferOfficerId).FirstOrDefault()?.FullName;


                if (model.Id == 0)
                {
                    var running = _context.AssetTransfers.Where(x => x.DocumentDate >= fiscalYearStart).OrderByDescending(x => x.Running).FirstOrDefault();
                    model.Running = running == null ? 1 : running.Running + 1;
                    model.Code = model.Running.ToString() + "/" + (model.DocumentDate.Value.Year + 543).ToString();

                    var bYear = model.DocumentDate?.Year;
                    if (model.DocumentDate?.Month >= 10) bYear++;
                    model.BudgetYear = bYear + 543;

                    model.TransferDate = DateTime.Now;

                    _context.AssetTransfers.Add(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var at = _context.AssetTransfers.FirstOrDefault(x => x.Id == model.Id);
                    at.UpdateBy = model.UpdateBy;
                    at.UpdateOn = model.UpdateOn;
                    at.DocumentDate = model.DocumentDate;
                    at.DestinationOrganizationId = model.DestinationOrganizationId;
                    at.TransferOfficerId = model.TransferOfficerId;
                    at.TransferOfficerName = model.TransferOfficerName;
                    at.ReceiveOfficerId = model.ReceiveOfficerId;
                    at.ReceiveOfficerName = model.ReceiveOfficerName;

                    _context.AssetTransfers.Update(at);
                    await _context.SaveChangesAsync();

                    model = at;
                }

                var listId = new List<int>();

                var CostCenterId = _context.MasterOrganizations.Where(x => x.Id == model.DestinationOrganizationId).FirstOrDefault()?.CostCenterId;

                foreach (var item in data.vAssetTransferItems ?? new List<VAssetTransferItem>())
                {
                    var itm = new AssetTransferItem
                    {
                        Id = item.Id,
                        CreateBy = item.CreateBy,
                        CreateOn = item.CreateOn,
                        UpdateBy = item.UpdateBy,
                        UpdateOn = item.UpdateOn,
                        AssetId = item.AssetId,
                        AssetTransferId = model.Id,
                        TransferDetail = item.TransferDetail,
                        OldAssetCode = item.OldAssetCode,
                        OldAssetNumberGfmis = item.OldAssetNumberGfmis,
                        OldOrganizationId = item.OldOrganizationId,
                        OldReceiveDate = item.OldReceiveDate,
                        OldAssetAcquisitionTypeId = item.OldAssetAcquisitionTypeId,
                        OldCurrentResponsibleOfficerId = item.OldCurrentResponsibleOfficerId,
                        OldCurrentBorrowerOfficerId = item.OldCurrentBorrowerOfficerId,
                        NewOrganizationId = model.DestinationOrganizationId,
                        NewCostCenterId = CostCenterId,

                    };
                    _context.AssetTransferItems.Update(itm);
                    await _context.SaveChangesAsync();
                    listId.Add(itm.Id);
                }

                var removeList = await _context.AssetTransferItems.Where(x => x.Id == model.Id).ToListAsync();
                foreach (var item in listId) removeList = removeList.Where(x => x.Id != item).ToList();

                _context.AssetTransferItems.RemoveRange(removeList);
                await _context.SaveChangesAsync();

                foreach (var item in data.FileGuidId ?? new List<string>())
                {
                    var file = _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                    file.ReferenceId = model.Id;
                    file.Sequence = 1; //แนบได้ไฟล์เดียว

                    _contextDoc.AttachFiles.Update(file);
                    await _contextDoc.SaveChangesAsync();
                }
                result.Success = true;
                result.Id = model.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return Ok(result);
        }
        #endregion

        #region AssetReturn
        [HttpGet("GetListVAssetReturn")]
        public async Task<IActionResult> GetListVAssetReturn(string? Code, DateTime? ReturnDate, int? StatusId)
        {
            var whr = PredicateBuilder.True<VAssetReturn>();

            if (StatusId != null) whr = whr.And(x => x.StatusId == StatusId);
            if (ReturnDate != null) whr = whr.And(x => x.ReturnDate == ReturnDate);
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));

            var res = await _context.VAssetReturns.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetAssetReturnDetail")]
        public async Task<IActionResult> GetAssetReturnDetail(int arId)
        {
            var data = new AssetReturnDetailModel();

            data.assetReturn = await _context.AssetReturns.Where(x => x.Id == arId).FirstOrDefaultAsync() ?? new AssetReturn();
            data.vAssetReturnItems = await _context.VAssetReturnItems.Where(x => x.AssetReturnId == arId).ToListAsync();

            return Ok(data);
        }

        [HttpPost("SaveAssetReturn")]
        public async Task<IActionResult> SaveAssetReturn(AssetReturnDetailModel data)
        {
            var result = new ApiResultsModel();
            try
            {
                var currentYear = DateTime.Now.Year;
                var currentMonth = DateTime.Now.Month;

                var fiscalYearStart = new DateTime(currentYear - 1, 10, 1);

                if (currentMonth >= 10)
                {
                    fiscalYearStart = new DateTime(currentYear, 10, 1);
                }

                var model = data.assetReturn;

                var lstofficer = _context.VOfficers.ToList();

                if (model.ReturnOfficerId != null) model.ReturnOfficerName = lstofficer.Where(x => x.Id == model.ReturnOfficerId).FirstOrDefault()?.FullName;
                if (model.ReceiveOfficerId != null) model.ReceiveOfficerName = lstofficer.Where(x => x.Id == model.ReceiveOfficerId).FirstOrDefault()?.FullName;
                if (model.ApproveOfficerId != null) model.ApproveOfficerName = lstofficer.Where(x => x.Id == model.ApproveOfficerId).FirstOrDefault()?.FullName;
                if (model.CheckOfficerId != null) model.CheckOfficerName = lstofficer.Where(x => x.Id == model.CheckOfficerId).FirstOrDefault()?.FullName;


                if (model.Id == 0)
                {
                    var running = _context.AssetReturns.Where(x => x.ReturnDate >= fiscalYearStart).OrderByDescending(x => x.Running).FirstOrDefault();
                    model.Running = running == null ? 1 : running.Running + 1;
                    model.Code = model.Running.ToString() + "/" + (model.ReturnDate.Value.Year + 543).ToString();

                    var bYear = model.ReturnDate?.Year;
                    if (model.ReturnDate?.Month >= 10) bYear++;
                    model.BudgetYear = bYear + 543;

                    _context.AssetReturns.Add(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var ar = _context.AssetReturns.FirstOrDefault(x => x.Id == model.Id);
                    ar.UpdateBy = model.UpdateBy;
                    ar.UpdateOn = model.UpdateOn;
                    ar.AssetReturnType = model.AssetReturnType;
                    ar.ReturnOrganizationId = model.ReturnOrganizationId;
                    ar.ReturnOfficerId = model.ReturnOfficerId;
                    ar.ReturnOfficerName = model.ReturnOfficerName;
                    ar.ReturnDate = model.ReturnDate;
                    ar.NewResponsibleOfficerId = model.NewResponsibleOfficerId;
                    ar.NewResponsibleOrganizationId = model.NewResponsibleOrganizationId;
                    ar.CheckOfficerId = model.CheckOfficerId;
                    ar.CheckOfficerName = model.CheckOfficerName;
                    ar.CheckDate = model.CheckDate;
                    ar.ApproveOfficerId = model.ApproveOfficerId;
                    ar.ApproveOfficerName = model.ApproveOfficerName;
                    ar.ApproveDate = model.ApproveDate;
                    ar.ReceiveOfficerId = model.ReceiveOfficerId;
                    ar.ReceiveOfficerName = model.ReceiveOfficerName;
                    ar.ReceiveDate = model.ReceiveDate;


                    _context.AssetReturns.Update(ar);
                    await _context.SaveChangesAsync();

                    model = ar;
                }

                var listId = new List<int>();


                foreach (var item in data.vAssetReturnItems ?? new List<VAssetReturnItem>())
                {
                    var itm = new AssetReturnItem
                    {
                        Id = item.Id,
                        CreateBy = item.CreateBy,
                        CreateOn = item.CreateOn,
                        UpdateBy = item.UpdateBy,
                        UpdateOn = item.UpdateOn,
                        AssetId = item.AssetId,
                        AssetReturnId = model.Id,
                        IsUsable = item.IsUsable,
                        ReturnDetail = item.ReturnDetail,
                        Ischeck = item.Ischeck,
                        CheckDatail = item.CheckDatail,
                        UnitId = item.UnitId,
                        Amount = item.Amount,
                        Cost = item.Cost
                    };
                    _context.AssetReturnItems.Update(itm);
                    await _context.SaveChangesAsync();
                    listId.Add(itm.Id);
                }

                var removeList = await _context.AssetReturnItems.Where(x => x.AssetReturnId == model.Id).ToListAsync();
                foreach (var item in listId) removeList = removeList.Where(x => x.Id != item).ToList();

                _context.AssetReturnItems.RemoveRange(removeList);
                await _context.SaveChangesAsync();

                foreach (var item in data.FileGuidId ?? new List<string>())
                {
                    var file = _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                    file.ReferenceId = model.Id;
                    file.Sequence = 1; //แนบได้ไฟล์เดียว

                    _contextDoc.AttachFiles.Update(file);
                    await _contextDoc.SaveChangesAsync();
                }
                result.Success = true;
                result.Id = model.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return Ok(result);
        }

        [HttpGet("DeleteAssetReturn")]
        public async Task<IActionResult> DeleteAssetReturn(int arId)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.AssetReturns.Where(x => x.Id == arId).FirstOrDefaultAsync();
                _context.AssetReturns.Remove(item);
                await _context.SaveChangesAsync();

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }
        #endregion

        #region AssetWriteOff
        [HttpGet("GetListVAssetWriteOff")]
        public async Task<IActionResult> GetListVAssetWriteOff(int? BudgetYear, string? Code, DateTime? WriteOffDateFrom, DateTime? WriteOffDateTo, string? WriteOffType, string? StatusId)
        {
            var whr = PredicateBuilder.True<VAssetWriteOff>();

            if (StatusId != null) whr = whr.And(x => x.WriteOffStatus == StatusId);
            if (WriteOffType != null) whr = whr.And(x => x.WriteOffType == WriteOffType);
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));
            if (BudgetYear != null) whr = whr.And(x => x.BudgetYear == BudgetYear);
            if (WriteOffDateFrom != null) whr = whr.And(x => x.WriteOffDate >= WriteOffDateFrom);
            if (WriteOffDateTo != null) whr = whr.And(x => x.WriteOffDate <= WriteOffDateTo);

            var res = await _context.VAssetWriteOffs.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("DelAssetWriteOff")]
        public async Task<IActionResult> DelAssetWriteOff(int awId)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.AssetWriteOffs.Where(x => x.Id == awId).FirstOrDefaultAsync();
                _context.AssetWriteOffs.Remove(item);
                await _context.SaveChangesAsync();

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }
        [HttpGet("GetAssetWriteOffDetail")]
        public async Task<IActionResult> GetAssetWriteOffDetail(int awId)
        {
            var data = new AssetWriteOffDetailModel();

            data.assetWriteOff = await _context.AssetWriteOffs.Where(x => x.Id == awId).FirstOrDefaultAsync() ?? new AssetWriteOff();
            data.vAssetWriteOffItems = await _context.VAssetWriteOffItems.Where(x => x.AssetWriteOffId == awId).ToListAsync();

            return Ok(data);
        }

        [HttpGet("GetTableWriteOffVAsset")]
        public async Task<IActionResult> GetTableWriteOffVAsset(string? vasAssetNumberGFMIS, string? vasCode, DateTime? vasApproveDateFrom, DateTime? vasApproveDateTo, string? vasIsExpire)
        {
            var whr = PredicateBuilder.True<VAsset>();

            if (vasAssetNumberGFMIS != null) whr = whr.And(x => x.AssetNumberGfmis.Contains(vasAssetNumberGFMIS));
            if (vasCode != null) whr = whr.And(x => x.Code.Contains(vasCode));
            if (vasApproveDateFrom != null) whr = whr.And(x => x.ApproveDate >= vasApproveDateFrom);
            if (vasApproveDateTo != null) whr = whr.And(x => x.ApproveDate <= vasApproveDateTo);
            if (vasIsExpire != null) whr = whr.And(x => x.IsExpire == vasIsExpire);
            else whr = whr.And(x => x.IsExpire == "N");
            whr = whr.And(x => x.AssetStatus == "W");
            var res = await _context.VAssets.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpPost("SaveAssetWriteOff")]
        public async Task<IActionResult> SaveAssetWriteOff(AssetWriteOffDetailModel data)
        {
            var result = new ApiResultsModel();
            try
            {
                var currentYear = DateTime.Now.Year;
                var currentMonth = DateTime.Now.Month;

                var fiscalYearStart = new DateTime(currentYear - 1, 10, 1);

                if (currentMonth >= 10)
                {
                    fiscalYearStart = new DateTime(currentYear, 10, 1);
                }

                var model = data.assetWriteOff;


                if (model.Id == 0)
                {
                    var running = _context.AssetWriteOffs.Where(x => x.WriteOffDate >= fiscalYearStart).OrderByDescending(x => x.Running).FirstOrDefault();
                    model.Running = running == null ? 1 : running.Running + 1;
                    model.Code = model.Running.ToString() + "/" + (model.WriteOffDate.Value.Year + 543).ToString();

                    var bYear = model.WriteOffDate?.Year;
                    if (model.WriteOffDate?.Month >= 10) bYear++;
                    model.BudgetYear = bYear + 543;

                    _context.AssetWriteOffs.Add(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var ar = _context.AssetWriteOffs.FirstOrDefault(x => x.Id == model.Id);
                    ar.UpdateBy = model.UpdateBy;
                    ar.UpdateOn = model.UpdateOn;
                    ar.WriteOffStatus = model.WriteOffStatus;
                    ar.WriteOffDate = model.WriteOffDate;
                    ar.WriteOffType = model.WriteOffType;
                    ar.WriteOffDetail = model.WriteOffDetail;
                    ar.ReferenceDocument = model.ReferenceDocument;
                    ar.ReferenceDate = model.ReferenceDate;


                    _context.AssetWriteOffs.Update(ar);
                    await _context.SaveChangesAsync();

                    model = ar;
                }

                var listId = new List<int>();

                foreach (var item in data.vAssetWriteOffItems ?? new List<VAssetWriteOffItem>())
                {
                    var itm = new AssetWriteOffItem
                    {
                        Id = item.Id,
                        CreateBy = item.CreateBy,
                        CreateOn = item.CreateOn,
                        UpdateBy = item.UpdateBy,
                        UpdateOn = item.UpdateOn,
                        AssetId = item.AssetId,
                        IsUsable = item.IsUsable,
                        AssetWriteOffId = model.Id,
                        Remark = item.Remark,
                        UnusableDetail = item.UnusableDetail,
                    };
                    _context.AssetWriteOffItems.Update(itm);
                    await _context.SaveChangesAsync();
                    listId.Add(itm.Id);
                }

                var removeList = await _context.AssetWriteOffItems.Where(x => x.AssetWriteOffId == model.Id).ToListAsync();
                foreach (var item in listId) removeList = removeList.Where(x => x.Id != item).ToList();

                _context.AssetWriteOffItems.RemoveRange(removeList);
                await _context.SaveChangesAsync();

                foreach (var item in data.FileGuidId ?? new List<string>())
                {
                    var file = _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                    file.ReferenceId = model.Id;
                    file.Sequence = 1; //แนบได้ไฟล์เดียว

                    _contextDoc.AttachFiles.Update(file);
                    await _contextDoc.SaveChangesAsync();
                }


                //ยืนยัน
                if (model.WriteOffStatus == "C")
                {
                    var lstAwi = await _context.AssetWriteOffItems.Where(x => x.AssetWriteOffId == model.Id).ToListAsync();
                    foreach (var item in lstAwi)
                    {
                        var ac = new AssetChange
                        {
                            CreateBy = data.userId,
                            CreateOn = DateTime.Now,
                            AssetId = item.AssetId,
                            Code = model.Code,
                            ChangeType = 6,
                            ChangeDate = DateTime.Now,
                            ReferenceTable = "AssetWriteOffItem",
                            ReferenceId = model.Id,
                        };
                        _context.AssetChanges.Add(ac);
                        await _context.SaveChangesAsync();

                        var asset = _context.Assets.Where(x => x.Id == item.AssetId).FirstOrDefault();
                        if(asset != null) { 
                        asset.UpdateBy = data.userId;
                        asset.UpdateOn = DateTime.Now;
                        asset.AssetStatus = "C";
                        _context.Assets.Update(asset);
                        await _context.SaveChangesAsync();
                        }
                    }
                }

                result.Success = true;
                result.Id = model.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return Ok(result);
        }
        #endregion

        #region AssetInspectio
        [HttpGet("GetListVAnnualCheck")]
        public async Task<IActionResult> GetListVAnnualCheck(string? Code, int? BudgetYear, string? AnnualCheckStatus)
        {
            var whr = PredicateBuilder.True<VAnnualCheck>();

            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));
            if (BudgetYear != null) whr = whr.And(x => x.BudgetYear == BudgetYear);
            if (AnnualCheckStatus != null) whr = whr.And(x => x.AnnualCheckStatus == AnnualCheckStatus);

            var res = await _context.VAnnualChecks.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region AssetMaintenanceForm 
        [HttpGet("GetListVAssetMaintenanceForm ")]
        public async Task<IActionResult> GetListVAssetMaintenanceForm(string? Code, int? StatusId, DateTime? RequestDateFrom, DateTime? RequestDateTo)
        {
            var whr = PredicateBuilder.True<VAssetMaintenanceForm>();

            if (RequestDateFrom != null) whr = whr.And(x => x.RequestDate >= RequestDateFrom);
            if (RequestDateTo != null) whr = whr.And(x => x.RequestDate <= RequestDateTo);
            if (StatusId != null) whr = whr.And(x => x.StatusId == StatusId);
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));

            var res = await _context.VAssetMaintenanceForms.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("DeleteAssetMaintenanceForm ")]
        public async Task<IActionResult> DeleteAssetMaintenanceForm(int atId)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.AssetMaintenanceForms.Where(x => x.Id == atId).FirstOrDefaultAsync();
                _context.AssetMaintenanceForms.Remove(item);
                await _context.SaveChangesAsync();

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }
        #endregion

        #region AssetRequisition 
        [HttpGet("GetListVAssetRequisition")]
        public async Task<IActionResult> GetListVAssetRequisition(string? Code, DateTime? RequestDateFrom, DateTime? RequestDateTo, int? StatusId, int? RequestOrganizationId)
        { 
            var whr = PredicateBuilder.True<VAssetRequisition>();

            if (RequestDateFrom != null) whr = whr.And(x => x.RequestDate >= RequestDateFrom);
            if (RequestDateTo != null) whr = whr.And(x => x.RequestDate <= RequestDateTo);
            if (StatusId != null) whr = whr.And(x => x.StatusId == StatusId);
            if (Code != null) whr = whr.And(x => x.Code.Contains(Code));
            if (RequestOrganizationId != null) whr = whr.And(x => x.RequestOrganizationId == RequestOrganizationId);

            var res = await _context.VAssetRequisitions.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetAssetRequisitionDetail")]
        public async Task<IActionResult> GetAssetRequisitionDetail(int arId)
        {
            var data = new AssetRequisitionDetailModel();

            data.assetRequisition = await _context.AssetRequisitions.Where(x => x.Id == arId).FirstOrDefaultAsync() ?? new AssetRequisition();
            data.vAssetRequisitionItems = await _context.VAssetRequisitionItems.Where(x => x.AssetRequisitionId == arId).ToListAsync();

            return Ok(data);
        }

        [HttpGet("GetTableRequisitionVAsset")]
        public async Task<IActionResult> GetTableRequisitionVAsset(string? vasAssetNumberGFMIS, string? vasCode, DateTime? vasReceiveDateFrom, DateTime? vasReceiveDateTo, int? vasOrganizationId)
        {
            var whr = PredicateBuilder.True<VAsset>();

            if (vasAssetNumberGFMIS != null) whr = whr.And(x => x.AssetNumberGfmis.Contains(vasAssetNumberGFMIS));
            if (vasCode != null) whr = whr.And(x => x.Code.Contains(vasCode));
            if (vasReceiveDateFrom != null) whr = whr.And(x => x.ApproveDate >= vasReceiveDateFrom);
            if (vasReceiveDateTo != null) whr = whr.And(x => x.ApproveDate <= vasReceiveDateTo);
            if (vasOrganizationId != null) whr = whr.And(x => x.OrganizationId == vasOrganizationId);
            whr = whr.And(x => x.CurrentResponsibleOfficerId == null);
            var res = await _context.VAssets.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpPost("SaveAssetRequisition")]
        public async Task<IActionResult> SaveAssetRequisition(AssetRequisitionDetailModel data)
        {
            var result = new ApiResultsModel();
            try
            {
                var currentYear = DateTime.Now.Year;
                var currentMonth = DateTime.Now.Month;

                var fiscalYearStart = new DateTime(currentYear - 1, 10, 1);

                if (currentMonth >= 10)
                {
                    fiscalYearStart = new DateTime(currentYear, 10, 1);
                }

                var model = data.assetRequisition;

                var lstofficer = _context.VOfficers.ToList();

                if (model.DeliverApproveOfficerId != null) model.DeliverApproveOfficerName = lstofficer.Where(x => x.Id == model.DeliverApproveOfficerId).FirstOrDefault()?.FullName;
                if (model.DeliverOfficerId != null) model.DeliverOfficerName = lstofficer.Where(x => x.Id == model.DeliverOfficerId).FirstOrDefault()?.FullName;
                if (model.ReceiveOfficerName != null) model.DeliverApproveOfficerName = lstofficer.Where(x => x.Id == model.ReceiveOfficerId).FirstOrDefault()?.FullName;


                if (model.Id == 0)
                {
                    var running = _context.AssetRequisitions.Where(x => x.RequestDate >= fiscalYearStart).OrderByDescending(x => x.Running).FirstOrDefault();
                    model.Running = running == null ? 1 : running.Running + 1;

                    var bYear = model.RequestDate?.Year;
                    if (model.RequestDate?.Month >= 10) bYear++;
                    model.BudgetYear = bYear + 543;
                    model.Code = model.Running.ToString() + "/" + model.BudgetYear.ToString();

                    _context.AssetRequisitions.Add(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var ar = _context.AssetRequisitions.FirstOrDefault(x => x.Id == model.Id);
                    ar.UpdateBy = model.UpdateBy;
                    ar.UpdateOn = model.UpdateOn;
                    ar.StorePlaceDetail = model.StorePlaceDetail;
                    ar.RequestOrganizationId = model.RequestOrganizationId;
                    ar.RequestOfficerId = model.RequestOfficerId;
                    ar.RequestOfficerName = model.RequestOfficerName;
                    ar.RequestDate = model.RequestDate;
                    ar.ExpectDate = model.ExpectDate;
                    ar.DeliverApproveOfficerId = model.DeliverApproveOfficerId;
                    ar.DeliverApproveOfficerName = model.DeliverApproveOfficerName;
                    ar.DeliverApproveDate = model.DeliverApproveDate;
                    ar.DeliverOfficerId = model.DeliverOfficerId;
                    ar.DeliverOfficerName = model.DeliverOfficerName;
                    ar.DeliverDate = model.DeliverDate;
                    ar.ReceiveOfficerId = model.ReceiveOfficerId;
                    ar.ReceiveOfficerName = model.ReceiveOfficerName;
                    ar.ReceiveDate = model.ReceiveDate;
                    _context.AssetRequisitions.Update(ar);
                    await _context.SaveChangesAsync();

                    model = ar;
                }

                var listId = new List<int>();

                foreach (var item in data.vAssetRequisitionItems ?? new List<VAssetRequisitionItem>())
                {
                    var itm = new AssetRequisitionItem
                    {
                        Id = item.Id,
                        CreateBy = item.CreateBy,
                        CreateOn = item.CreateOn,
                        UpdateBy = item.UpdateBy,
                        UpdateOn = item.UpdateOn,
                        AssetId = item.AssetId,
                        AssetRequisitionId = model.Id,
                        Remark = item.Remark,
                    };
                    _context.AssetRequisitionItems.Update(itm);
                    await _context.SaveChangesAsync();
                    listId.Add(itm.Id);
                }

                var removeList = await _context.AssetRequisitionItems.Where(x => x.AssetRequisitionId == model.Id).ToListAsync();
                foreach (var item in listId) removeList = removeList.Where(x => x.Id != item).ToList();

                _context.AssetRequisitionItems.RemoveRange(removeList);
                await _context.SaveChangesAsync();

                foreach (var item in data.FileGuidId ?? new List<string>())
                {
                    var file = _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                    file.ReferenceId = model.Id;
                    file.Sequence = 1; //แนบได้ไฟล์เดียว

                    _contextDoc.AttachFiles.Update(file);
                    await _contextDoc.SaveChangesAsync();
                }


                result.Success = true;
                result.Id = model.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return Ok(result);
        }

        [HttpGet("DelAssetRequisition")]
        public async Task<IActionResult> DelAssetRequisition(int arId)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.AssetRequisitions.Where(x => x.Id == arId).FirstOrDefaultAsync();
                _context.AssetRequisitions.Remove(item);
                await _context.SaveChangesAsync();

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }
        #endregion

        #region 1.หน้าจอรายการเบิกจ่ายวัสดุจากหน่วยจัดซื้อ AssetRequisitionMaterialCentralList
        [HttpGet("GetMaterialRequisitionMaterialCentral")]

        public async Task<IActionResult> GetMaterialRequisitionMaterialCentral(int? RequestType, string? Code, int? StatusId, DateTime? RequestDateFrom, DateTime? RequestDateTo, int? OrganizationId)
        {
            var whr = PredicateBuilder.True<VMaterialRequisition>();

            if (RequestType != null && RequestType != 0) whr = whr.And(x => x.RequestType == RequestType);
            if (Code != null && Code != "") whr = whr.And(x => x.Code.Contains(Code));
            if (StatusId != null && StatusId != 0) whr = whr.And(x => x.StatusId == StatusId);
            if (OrganizationId != null && OrganizationId != 0) whr = whr.And(x => x.OrganizationId == OrganizationId);


            if (RequestDateFrom != null)
            {
                if (RequestDateTo != null)
                    whr = whr.And(x => x.RequestDate.Value.Date >= RequestDateFrom.Value.Date);
                else
                    whr = whr.And(x => x.RequestDate.Value.Date == RequestDateFrom.Value.Date);
            }
            if (RequestDateTo != null)
                whr = whr.And(x => x.RequestDate.Value.Date <= RequestDateTo.Value.Date);


            var res = await _context.VMaterialRequisitions.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetAssetRequisitionMaterialCentralDetailModel")]
        public async Task<IActionResult> GetAssetRequisitionMaterialCentralDetailModel(int id)
        {
            var data = new AssetRequisitionMaterialCentralDetailModel();

            data.materialRequisition = await _context.MaterialRequisitions.FirstOrDefaultAsync(x => x.Id == id) ?? new MaterialRequisition();
            data.lstVMaterialRequisitionItem = await _context.VMaterialRequisitionItems.Where(x => x.RequisitionId == id).ToListAsync();

            var lstStatus = new List<MasterStatus>();
            lstStatus = await _context.MasterStatuses.Where(x => x.Active == true).ToListAsync();

            string strStatusName = string.Empty;
            if (lstStatus != null && lstStatus.Count > 0)
            {
                if (data.materialRequisition != null)
                {
                    strStatusName = lstStatus.Where(x => x.Id == data.materialRequisition.StatusId).First().Name;
                }
                else
                {
                    strStatusName = lstStatus[0].Name;
                }
            }

            data.statusName = strStatusName;

            return Ok(data);
        }

        [HttpGet("SetNewAssetRequisitionMaterialCentralDetailModel")]
        public async Task<IActionResult> SetNewAssetRequisitionMaterialCentralDetailModel()
        {
            //var data = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition(), lstVMaterialRequisitionItem = new List<VMaterialRequisitionItem>() };
            var data = new AssetRequisitionMaterialCentralDetailModel { materialRequisition = new MaterialRequisition() };
            var lstStatus = new List<MasterStatus>();
            lstStatus = await _context.MasterStatuses.Where(x => x.Active == true).ToListAsync();

            string strStatusName = string.Empty;
            if (lstStatus != null && lstStatus.Count > 0)
            {
                strStatusName = lstStatus[0].Name;

                data.materialRequisition.StatusId = lstStatus[0].Id;
                data.statusName = strStatusName;
            }

            int? budgetYear;
            int? Nextrunning = 1;
            DateTime? requestDate = DateTime.Today;
            if (requestDate != null)
            {
                if (requestDate?.Month < 10)
                {
                    budgetYear = requestDate?.Year + 543;
                }
                else
                {
                    budgetYear = requestDate?.Year + 544;
                }

                //Get MaxRunning in budgetyear
                var lstMR = new List<MaterialRequisition>();
                lstMR = await _context.MaterialRequisitions.Where(x => x.BudgetYear == budgetYear).ToListAsync();
                if (lstMR != null && lstMR.Count > 0)
                {
                    Nextrunning = lstMR.Last().Running + 1;
                }
                data.materialRequisition.BudgetYear = budgetYear;
                data.materialRequisition.RequestDate = requestDate;
                data.materialRequisition.Running = Nextrunning;
                data.materialRequisition.Code = Nextrunning.ToString() + "/" + budgetYear.ToString();
                data.materialRequisition.RequestType = 1;
            }

            return Ok(data);
        }

        [HttpPost("SaveAssetRequisitionMaterial")]
        public async Task<IActionResult> SaveAssetRequisitionMaterial(AssetRequisitionMaterialCentralDetailModel model)
        {
            var addMode = false;
            var result = new ApiResultsModel();
            try
            {

                var itemMR = new MaterialRequisition();
                if (model.materialRequisition.Id != 0)
                {
                    //Update Mode
                    itemMR = await _context.MaterialRequisitions.FirstOrDefaultAsync(x => x.Id == model.materialRequisition.Id);
                    //item.BudgetYear = model.vMaterialRequisition.BudgetYear;
                    itemMR.Code = model.materialRequisition.Code;
                    itemMR.Running = model.materialRequisition.Running;
                    itemMR.RequestDate = model.materialRequisition.RequestDate;
                    itemMR.RequestType = model.materialRequisition.RequestType;
                    itemMR.RequestBy = model.materialRequisition.RequestBy;
                    itemMR.StatusId = model.materialRequisition.StatusId;
                    itemMR.WarehouseId = model.materialRequisition.WarehouseId;
                    itemMR.OrganizationId = model.materialRequisition.OrganizationId;
                    itemMR.DeliverApproveOfficerId = model.materialRequisition.DeliverApproveOfficerId;
                    itemMR.DeliverOfficerId = model.materialRequisition.DeliverOfficerId;
                    itemMR.ReceiveOfficerId = model.materialRequisition.ReceiveOfficerId;
                    itemMR.DeliverApproveOfficerName = model.materialRequisition.DeliverApproveOfficerName;
                    itemMR.DeliverOfficerName = model.materialRequisition.DeliverOfficerName;
                    itemMR.ReceiveOfficerName = model.materialRequisition.ReceiveOfficerName;

                    itemMR.UpdateOn = model.materialRequisition.UpdateOn;
                    itemMR.UpdateBy = model.materialRequisition.UpdateBy;
                    _context.MaterialRequisitions.Update(itemMR);
                }
                else
                {
                    addMode = true;
                    _context.MaterialRequisitions.Add(model.materialRequisition);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
                result.Id = model.materialRequisition.Id;

                //Delete MaterialRequisitionItem ใน DB ที่ไม่มีแล้วใน Table หน้าจอตอน Save
                var dataMRIteminDB = new List<VMaterialRequisitionItem>();
                dataMRIteminDB = await _context.VMaterialRequisitionItems.Where(x => x.RequisitionId == model.materialRequisition.Id).ToListAsync();
                Boolean chkExist = false;
                if (dataMRIteminDB != null && dataMRIteminDB.Count > 0)
                {
                    if (model.lstVMaterialRequisitionItem != null && model.lstVMaterialRequisitionItem.Count > 0)
                    {
                        //Check exist
                        foreach (var item in dataMRIteminDB)
                        {
                            chkExist = model.lstVMaterialRequisitionItem.Any(a => a.MaterialStockId == item.MaterialStockId);
                            if (chkExist == false)
                            {
                                //delete item
                                var itemD = _context.MaterialRequisitionItems.FirstOrDefault(x => x.Id == item.Id);
                                if (itemD != null)
                                {
                                    //result.Id = itemD.Id;
                                    _context.Remove(itemD);
                                    await _context.SaveChangesAsync();
                                }
                            }
                        }
                    }
                    else
                    {
                        //Delete All MaterialRequisitionItem
                        foreach (var item in dataMRIteminDB)
                        {
                            var itemD = _context.MaterialRequisitionItems.FirstOrDefault(x => x.Id == item.Id);
                            if (itemD != null)
                            {
                                //result.Id = itemD.Id;
                                _context.Remove(itemD);
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }

                //Save MaterialRequisitionItem
                if (model.lstVMaterialRequisitionItem != null && model.lstVMaterialRequisitionItem.Count > 0)
                {
                    var newVMatStock = new VMaterialStock();
                    var itemInsert = new MaterialRequisitionItem();
                    var itemUpdate = new MaterialRequisitionItem();

                    foreach (var item in model.lstVMaterialRequisitionItem)
                    {
                        newVMatStock = await _context.VMaterialStocks.FirstOrDefaultAsync(x => x.Id == item.MaterialStockId);
                        if (newVMatStock != null)
                        {
                            if (item.Id == 0)
                            {
                                itemInsert = new MaterialRequisitionItem();
                                //Insert
                                itemInsert.RequisitionId = model.materialRequisition.Id;
                                itemInsert.MaterialId = newVMatStock.MaterialId;
                                itemInsert.Gpsccode = newVMatStock.Gpsccode;
                                itemInsert.RequestAmount = item.RequestAmount;
                                itemInsert.ReceiveAmount = item.ReceiveAmount;
                                itemInsert.UnitId = newVMatStock.UnitId;
                                itemInsert.UnitPrice = newVMatStock.UnitPrice;
                                itemInsert.TotalPrice = newVMatStock.TotalPrice;
                                itemInsert.Remark = item.Remark;
                                itemInsert.MaterialInItemId = newVMatStock.MaterialInItemId;
                                itemInsert.MaterialStockId = newVMatStock.Id;

                                itemInsert.CreateBy = item.CreateBy;
                                itemInsert.CreateOn = item.CreateOn;

                                _context.MaterialRequisitionItems.Add(itemInsert);
                            }
                            else if (item.Id != 0)
                            {
                                //Update
                                itemUpdate = await _context.MaterialRequisitionItems.FirstOrDefaultAsync(x => x.Id == item.Id);

                                itemUpdate.MaterialId = newVMatStock.MaterialId;
                                itemUpdate.Gpsccode = newVMatStock.Gpsccode;
                                itemUpdate.RequestAmount = item.RequestAmount;
                                itemUpdate.ReceiveAmount = item.ReceiveAmount;
                                itemUpdate.UnitId = newVMatStock.UnitId;
                                itemUpdate.UnitPrice = newVMatStock.UnitPrice;
                                itemUpdate.TotalPrice = newVMatStock.TotalPrice;
                                itemUpdate.Remark = item.Remark;
                                itemUpdate.MaterialInItemId = newVMatStock.MaterialInItemId;
                                itemUpdate.MaterialStockId = newVMatStock.Id;

                                itemUpdate.UpdateBy = item.UpdateBy;
                                itemUpdate.UpdateOn = item.UpdateOn;

                                _context.MaterialRequisitionItems.Update(itemUpdate);
                            }
                            await _context.SaveChangesAsync();
                            result.Success = true;
                        }
                    }
                }

                if (addMode = true)
                {
                    foreach (var item in model.FileGuidId ?? new List<string>())
                    {
                        var file = _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                        file.ReferenceId = result.Id;
                        file.Sequence = 1; //แนบได้ไฟล์เดียว

                        _contextDoc.AttachFiles.Update(file);
                        await _contextDoc.SaveChangesAsync();
                    }
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("SearchListMaterialStock")]
        public async Task<IActionResult> SearchListMaterialStock(int? warehouseId, string? materialName, string? gpsccode)
        {
            var whr = PredicateBuilder.True<VMaterialStock>();

            if (warehouseId != null && warehouseId != 0) whr = whr.And(x => x.WarehouseId == warehouseId);
            if (materialName != null && materialName != "") whr = whr.And(x => x.MaterialName.Contains(materialName));
            if (gpsccode != null && gpsccode != "") whr = whr.And(x => x.Gpsccode.Contains(gpsccode));

            var res = await _context.VMaterialStocks.Where(whr).ToListAsync();
            return Ok(res);
        }


        [HttpGet("GetMaterialRequisitionItem")]
        public async Task<IActionResult> GetMaterialRequisitionItem(int id)
        {
            var data = new VMaterialRequisitionItem();
            data = await _context.VMaterialRequisitionItems.FirstOrDefaultAsync(x => x.Id == id) ?? new VMaterialRequisitionItem();
            return Ok(data);
        }

        [HttpGet("GetMaterialRequisitionItemByConditions")]
        public async Task<IActionResult> GetMaterialRequisitionItemByConditions(int requisitionId, int materialStockId)
        {
            var data = new VMaterialRequisitionItem();
            data = await _context.VMaterialRequisitionItems.FirstOrDefaultAsync(x => x.RequisitionId == requisitionId && x.MaterialStockId == materialStockId) ?? new VMaterialRequisitionItem();
            return Ok(data);
        }

        [HttpGet("GetVMaterialStock")]
        public async Task<IActionResult> GetVMaterialStock(int id)
        {
            var data = new VMaterialStock();
            data = await _context.VMaterialStocks.FirstOrDefaultAsync(x => x.Id == id) ?? new VMaterialStock();
            return Ok(data);
        }

        [HttpGet("GetMaterialStock")]
        public async Task<IActionResult> GetMaterialStock(int id)
        {
            var data = new MaterialStock();
            data = await _context.MaterialStocks.FirstOrDefaultAsync(x => x.Id == id) ?? new MaterialStock();
            return Ok(data);
        }

        [HttpGet("GetActiveOfficer")]
        public async Task<IActionResult> GetActiveOfficer()
        {
            var data = new List<VOfficer>();
            data = await _context.VOfficers.Where(a => a.Active == true).ToListAsync();
            return Ok(data);
        }

        [HttpGet("DeleteAssetRequisitionMaterialCentral")]
        public async Task<IActionResult> DeleteAssetRequisitionMaterialCentral(int? id)
        {
            var result = new ApiResultsModel();
            try
            {
                var arrItem = new List<VMaterialRequisitionItem>();
                arrItem = await _context.VMaterialRequisitionItems.Where(x => x.RequisitionId == id).ToListAsync();
                if (arrItem != null && arrItem.Count > 0)
                {
                    foreach (var RId in arrItem)
                    {
                        var itemDel = _context.MaterialRequisitionItems.FirstOrDefault(x => x.Id == RId.Id);
                        if (itemDel != null)
                        {
                            //result.Id = itemDel.Id;
                            _context.Remove(itemDel);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                var item = await _context.MaterialRequisitions.FirstOrDefaultAsync(x => x.Id == id);
                if (item != null)
                {
                    _context.MaterialRequisitions.Remove(item);
                    await _context.SaveChangesAsync();
                }

                var file = _contextDoc.AttachFiles.Where(x => x.ReferenceId == id && x.ReferenceTable == "MaterialRequisition").FirstOrDefault();
                if (file != null)
                {
                    _contextDoc.AttachFiles.Remove(file);
                    await _contextDoc.SaveChangesAsync();
                }

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Ok(result);
        }

        [HttpGet("GetVMasterWarehouseByOrganizationId")]
        public async Task<IActionResult> GetVMasterWarehouseByOrganizationId(int organizationId)
        {
            var whr = PredicateBuilder.True<VMasterWarehouse>();
            if (organizationId != null && organizationId != 0) whr = whr.And(x => x.OrganizationId == organizationId);

            var res = await _context.VMasterWarehouses.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpPost("SaveAssetRMCentralSendBack")]
        public async Task<IActionResult> SaveAssetRMCentralSendBack(AssetRequisitionMaterialCentralDetailModel model)
        {
            var addMode = false;
            var result = new ApiResultsModel();
            try
            {

                var itemMR = new MaterialRequisition();
                if (model.materialRequisition.Id != 0)
                {
                    //Update Mode
                    itemMR = await _context.MaterialRequisitions.FirstOrDefaultAsync(x => x.Id == model.materialRequisition.Id);

                    itemMR.ReturnRemark = model.materialRequisition.ReturnRemark;
                    itemMR.ReturnDate = model.materialRequisition.ReturnDate;
                    itemMR.ReturnBy = model.materialRequisition.ReturnBy;

                    itemMR.UpdateOn = model.materialRequisition.UpdateOn;
                    itemMR.UpdateBy = model.materialRequisition.UpdateBy;
                    _context.MaterialRequisitions.Update(itemMR);
                }

                await _context.SaveChangesAsync();
                result.Success = true;
                result.Id = model.materialRequisition.Id;


            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpPost("ApproveAssetRMCentralMaterialRequisition")]
        public async Task<IActionResult> ApproveMaterialRequisition(AssetRequisitionMaterialCentralDetailModel model)
        {
            var addMode = false;
            var result = new ApiResultsModel();
            try
            {

                var itemMR = new MaterialRequisition();
                if (model.materialRequisition.Id != 0)
                {
                    //Update Mode
                    itemMR = await _context.MaterialRequisitions.FirstOrDefaultAsync(x => x.Id == model.materialRequisition.Id);
                    itemMR.UpdateOn = model.materialRequisition.UpdateOn;
                    itemMR.UpdateBy = model.materialRequisition.UpdateBy;
                    itemMR.ApproveRequestBy = model.materialRequisition.ApproveRequestBy;
                    itemMR.StatusApprove = "Y";
                    itemMR.ApproveDate = model.materialRequisition.ApproveDate;
                    // itemMR.StatusId = model.materialRequisition.StatusId; ยังไม่ Confirm Spec
                    itemMR.ApproveRequestBy = model.materialRequisition.ApproveRequestBy;
                    _context.MaterialRequisitions.Update(itemMR);
                }

                await _context.SaveChangesAsync();
                result.Success = true;
                result.Id = model.materialRequisition.Id;

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }
        [HttpPost("ApproveAssetRMCentralMaterialStockMovement")]
        public async Task<IActionResult> ApproveAssetRMCentralMaterialStockMovement(AssetRequisitionMaterialCentralDetailApprove model)
        {
            var addMode = false;
            var result = new ApiResultsModel();
            try
            {
                //2.2 Update MaterialStock Stockเดิม
                //2.3 Insert MaterialStock Stockรายการใหม่
                //2.4 Insert MaterialStockMovement

                var itemMS = new MaterialStock();
                if (model.lstMaterialStockUpdate != null && model.lstMaterialStockUpdate.Count > 0)
                {
                    foreach (var matStockUpdate in model.lstMaterialStockUpdate)
                    {
                        itemMS = await _context.MaterialStocks.FirstOrDefaultAsync(x => x.Id == matStockUpdate.Id);

                        itemMS.UpdateBy = matStockUpdate.UpdateBy;
                        itemMS.UpdateOn = matStockUpdate.UpdateOn;
                        itemMS.MaterialId = matStockUpdate.MaterialId;
                        itemMS.StockOut = matStockUpdate.StockOut;
                        itemMS.Available = matStockUpdate.Available;
                        itemMS.RequisitionId = matStockUpdate.RequisitionId;
                        itemMS.RequisitionItemId = matStockUpdate.RequisitionItemId;
                        _context.MaterialStocks.Update(itemMS);
                        await _context.SaveChangesAsync();
                        result.Success = true;
                    }
                }

                int newMatStockId = 0;
                int[] arrNewMatStockId = new int[model.lstMaterialStockInsert.Count];
                if (model.lstMaterialStockInsert != null && model.lstMaterialStockInsert.Count > 0)
                {
                    for (int i = 0; i < model.lstMaterialStockInsert.Count; i++)
                    {
                        _context.MaterialStocks.Add(model.lstMaterialStockInsert[i]);
                        await _context.SaveChangesAsync();
                        result.Success = true;

                        arrNewMatStockId[i] = model.lstMaterialStockInsert[i].Id;
                    }
                }

                if (model.lstMaterialStockMovement != null && model.lstMaterialStockMovement.Count > 0)
                {
                    for (int i = 0; i < model.lstMaterialStockMovement.Count; i++)
                    {
                        model.lstMaterialStockMovement[i].TargetMaterialStockId = arrNewMatStockId[i];
                        _context.MaterialStocks.Add(model.lstMaterialStockInsert[i]);
                        await _context.SaveChangesAsync();
                        result.Success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }
        #endregion

        #region 2.หน้าจอรายการเบิกจ่ายวัสดุจากหน่วยงาน AssetRequisitionMaterialOrganizationList
        [HttpGet("GetMaterialRequisitionMaterialOrganization")]

        public async Task<IActionResult> GetMaterialRequisitionMaterialOrganization(int? RequestType, string? Code, int? StatusId, DateTime? RequestDateFrom, DateTime? RequestDateTo, int? OrganizationId)
        {
            var whr = PredicateBuilder.True<VMaterialRequisition>();

            if (RequestType != null && RequestType != 0) whr = whr.And(x => x.RequestType == RequestType);
            if (Code != null && Code != "") whr = whr.And(x => x.Code.Contains(Code));
            if (StatusId != null && StatusId != 0) whr = whr.And(x => x.StatusId == StatusId);
            if (OrganizationId != null && OrganizationId != 0) whr = whr.And(x => x.OrganizationId == OrganizationId);

            if (RequestDateFrom != null)
            {
                if (RequestDateTo != null)
                    whr = whr.And(x => x.RequestDate.Value.Date >= RequestDateFrom.Value.Date);
                else
                    whr = whr.And(x => x.RequestDate.Value.Date == RequestDateFrom.Value.Date);
            }
            if (RequestDateTo != null)
                whr = whr.And(x => x.RequestDate.Value.Date <= RequestDateTo.Value.Date);


            var res = await _context.VMaterialRequisitions.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion
    }
}
