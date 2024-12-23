using Microsoft.AspNetCore.Mvc;
using MOEN_ERP.API.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using MOEN_ERP.Models.Data;
using MOEN_ERP.DAL.Models;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using MOEN_ERP.Models.Common;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using System.Linq;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using MOEN_ERP.Models.ViewModel;
using Microsoft.Extensions.Primitives;
using static System.Net.Mime.MediaTypeNames;
using MOEN_ERP.Models.RawData;

namespace MOEN_ERP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterController : Controller
    {
        private readonly MOENDBContext _context;
        private readonly MOENDOCSContext _contextDoc;
        public MasterController(MOENDBContext context, MOENDOCSContext contextDoc)
        {
            _context = context;
            _contextDoc = contextDoc;
        }

        #region 1.MasterAssetType
        [HttpGet("GetListVMasterAssetType")]
        public async Task<IActionResult> GetListVMasterAssetType(string? nameThai, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterAssetType>();

            if (nameThai != null && nameThai != "") whr = whr.And(x => x.NameThai.Contains(nameThai));           
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VMasterAssetTypes.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetMasterAssetType")]
        public async Task<IActionResult> GetMasterAssetType(int? Id)
        {         

            var data = new MasterAssetTypeDetailModel();

            data.MasterAssetType = await _context.MasterAssetTypes.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterAssetType();
            data.ListMasterAssetTypeSub = await _context.MasterAssetTypeSubs.Where(x => x.AssetTypeId == Id).ToListAsync();
            return Ok(data);
        }

        [HttpPost("SaveMasterAssetType")]
        public async Task<IActionResult> SaveMasterAssetType(MasterAssetType model)
        {
            var result = new ApiResultsModel();
            try
            {
                //Duplicate Check*****
                //model.SequenceNumber; 

                if (model.Id != 0)
                {
                    var item = await _context.MasterAssetTypes.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {
                        item.Active = model.Active;
                        item.EffectiveToDate = model.EffectiveToDate;
                        item.EffectiveFromDate = model.EffectiveFromDate;
                        item.Code = model.Code;
                        item.NameThai = model.NameThai;
                        item.Depreciation = model.Depreciation;
                        item.LifeTimeMax = model.LifeTimeMax;
                        item.LifeTimeMin = model.LifeTimeMin;
                        item.LifeTimeUse = model.LifeTimeUse;
                        item.SequenceNumber = model.SequenceNumber;
                        item.LifeTimeDepreciation = model.LifeTimeDepreciation;
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;
                        _context.MasterAssetTypes.Update(item);
                    }
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterAssetTypes.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterAssetTypes.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
                result.Id = model.Id;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterAssetType")]
        public async Task<IActionResult> DeleteMasterAssetType(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterAssetTypes.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.MasterAssetTypes.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpPost("SaveMasterAssetTypeSub")]
        public async Task<IActionResult> SaveMasterAssetTypeSub(MasterAssetTypeSub model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterAssetTypeSubs.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;

                        item.AssetTypeId = model.AssetTypeId;
                        item.Active = model.Active;
                        item.NameThai = model.NameThai;
                        item.Depreciation = model.Depreciation;
                        item.LifeTimeUse = model.LifeTimeUse;
                        item.LifeTimeDepreciation = model.LifeTimeDepreciation;
                        _context.MasterAssetTypeSubs.Update(item);
                    }
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.MasterAssetTypeSubs.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterAssetTypeSubs.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterAssetTypeSub")]
        public async Task<IActionResult> DeleteMasterAssetTypeSub(string? listDelSubId)
        {
            var result = new ApiResultsModel();
            try
            {
                //int Id = 0;
                string[] arrId;
                if (listDelSubId != "")
                {
                    arrId = listDelSubId.Split(",");

                    if (arrId != null && arrId.Length > 0)
                    {
                        for (int i = 0; i < arrId.Length; i++)
                        {
                            //bool isNumber = Regex.IsMatch(arrId[i], @"^\d+$");
                            int numericvalue;
                            bool isNumber = int.TryParse(arrId[i], out numericvalue);
                            if (isNumber)
                            {
                                int Id = Int32.Parse(arrId[i]);
                                var item = await _context.MasterAssetTypeSubs.FirstOrDefaultAsync(x => x.Id == Id);
                                if (item != null)
                                {
                                    _context.MasterAssetTypeSubs.Remove(item);
                                    await _context.SaveChangesAsync();
                                    result.Success = true;
                                }
                            }                            
                        }
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

        [HttpGet("GetAssetByAssetTypeId")]
        public async Task<IActionResult> GetAssetByAssetTypeId(int? assetTypeId)
        {
            var whr = PredicateBuilder.True<Asset>();
            if (assetTypeId != null && assetTypeId != 0) whr = whr.And(x => x.AssetTypeId == assetTypeId);

            var res = await _context.Assets.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 2.MasterAssetClass
        [HttpGet("GetListVMasterAssetClass")]
        public async Task<IActionResult> GetListVMasterAssetClass(string? nameThai, int? assetTypeId, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterAssetClass>();

            if (nameThai != null && nameThai != "") whr = whr.And(x => x.NameThai.Contains(nameThai));
            if (assetTypeId != null && assetTypeId != 0) whr = whr.And(x => x.AssetTypeId == assetTypeId);           
            if (Active != null) whr = whr.And(x => x.Active == Active);
            var res = await _context.VMasterAssetClasses.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetMasterAssetClass")]
        public async Task<IActionResult> GetMasterAssetClass(int? Id)
        {
            return Ok(await _context.MasterAssetClasses.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterAssetClass());
        }

        [HttpPost("SaveMasterAssetClass")]
        public async Task<IActionResult> SaveMasterAssetClass(MasterAssetClass model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterAssetClasses.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {
                        item.Active = model.Active;
                        item.EffectiveToDate = model.EffectiveToDate;
                        item.EffectiveFromDate = model.EffectiveFromDate;
                        item.Code = model.Code;
                        item.NameThai = model.NameThai;
                        item.AssetTypeId = model.AssetTypeId;
                        item.SequenceNumber = model.SequenceNumber;   
                        item.AssetTypeSubId = model.AssetTypeSubId;
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;
                        _context.MasterAssetClasses.Update(item);
                    }
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterAssetClasses.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterAssetClasses.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterAssetClass")]
        public async Task<IActionResult> DeleteMasterAssetClass(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterAssetClasses.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.MasterAssetClasses.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetAssetByAssetClassId")]
        public async Task<IActionResult> GetAssetByAssetClassId(int? assetClassId)
        {
            var whr = PredicateBuilder.True<Asset>();
            if (assetClassId != null && assetClassId != 0) whr = whr.And(x => x.AssetClassId == assetClassId);

            var res = await _context.Assets.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 3.MasterUnit
        [HttpGet("GetListVMasterUnit")]
        public async Task<IActionResult> GetListVMasterUnit(string? nameTh, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterUnit>();

            if (nameTh != "" && nameTh != null) whr = whr.And(x => x.NameThai.Contains(nameTh));
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VMasterUnits.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMasterUnit")]
        public async Task<IActionResult> GetMasterUnit(int? Id)
        {
            return Ok(await _context.MasterUnits.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterUnit());
        }
        [HttpGet("DeleteMasterUnit")]
        public async Task<IActionResult> DeleteMasterUnit(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterUnits.FirstOrDefaultAsync(x => x.Id == Id);
                _context.MasterUnits.Remove(item);
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }
        [HttpPost("SaveMasterUnit")]
        public async Task<IActionResult> SaveMasterUnit(MasterUnit model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterUnits.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {
                        item.Active = model.Active;
                        item.NameThai = model.NameThai;
                        item.Egpactive = model.Egpactive;
                        item.Egpid = model.Egpid;                       
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;
                        _context.MasterUnits.Update(item);
                    }
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterUnits.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterUnits.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);        
        }

        //- 1.Asset   
        [HttpGet("GetAssetByUnitId")]
        public async Task<IActionResult> GetAssetByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<Asset>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.UnitId == unitId);

            var res = await _context.Assets.Where(whr).ToListAsync();
            return Ok(res);
        }
        //- 2.AssetReturnItem
        [HttpGet("GetAssetReturnItemByUnitId")]
        public async Task<IActionResult> GetAssetReturnItemByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<AssetReturnItem>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.UnitId == unitId);

            var res = await _context.AssetReturnItems.Where(whr).ToListAsync();
            return Ok(res);
        }
        //- 3.MasterMaterial
        [HttpGet("GetMasterMaterialByUnitId")]
        public async Task<IActionResult> GetMasterMaterialByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<MasterMaterial>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.UnitId == unitId);

            var res = await _context.MasterMaterials.Where(whr).ToListAsync();
            return Ok(res);
        }
        //- 4.MaterialBorrowItem
        [HttpGet("GetMaterialBorrowItemByUnitId")]
        public async Task<IActionResult> GetMaterialBorrowItemByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<MaterialBorrowItem>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.UnitId == unitId);

            var res = await _context.MaterialBorrowItems.Where(whr).ToListAsync();
            return Ok(res);
        }
        //- 5.MaterialInItem
        [HttpGet("GetMaterialInItemByUnitId")]
        public async Task<IActionResult> GetMaterialInItemByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<MaterialInItem>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.UnitId == unitId);

            var res = await _context.MaterialInItems.Where(whr).ToListAsync();
            return Ok(res);
        }
        //- 6.MaterialRequisitionItem
        [HttpGet("GetMaterialRequisitionItemByUnitId")]
        public async Task<IActionResult> GetMaterialRequisitionItemByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<MaterialRequisitionItem>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.UnitId == unitId);

            var res = await _context.MaterialRequisitionItems.Where(whr).ToListAsync();
            return Ok(res);
        }
        //- 7.MaterialStock
        [HttpGet("GetMaterialStockByUnitId")]
        public async Task<IActionResult> GetMaterialStockByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<MaterialStock>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.UnitId == unitId);

            var res = await _context.MaterialStocks.Where(whr).ToListAsync();
            return Ok(res);
        }
        //- 8.AnnualCheckMaterial
        [HttpGet("GetAnnualCheckMaterialByUnitId")]
        public async Task<IActionResult> GetAnnualCheckMaterialByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<AnnualCheckMaterial>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.UnitId == unitId);

            var res = await _context.AnnualCheckMaterials.Where(whr).ToListAsync();
            return Ok(res);
        }

        //- 9.BudgetGovernmentItem
        [HttpGet("GetBudgetGovernmentItemByUnitId")]
        public async Task<IActionResult> GetBudgetGovernmentItemByUnitId(int? unitId)
        {
            var whr = PredicateBuilder.True<BudgetGovernmentItem>();
            if (unitId != null && unitId != 0) whr = whr.And(x => x.QuantityUnitId == unitId);

            var res = await _context.BudgetGovernmentItems.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 4.MasterMaterial
        [HttpGet("GetListVMasterMaterial")]
        public async Task<IActionResult> GetListVMasterMaterial(string? nameTh, int? groupId, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterMaterial>();

            if (nameTh != null && nameTh != "") whr = whr.And(x => x.NameThai.Contains(nameTh));
            if (groupId != null && groupId != 0) whr = whr.And(x => x.MaterialGroupId == groupId);
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VMasterMaterials.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMasterMaterial")]
        public async Task<IActionResult> GetMasterMaterial(int? Id)
        {
            return Ok(await _context.MasterMaterials.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterMaterial());
        }
        [HttpGet("DeleteMasterMaterial")]
        public async Task<IActionResult> DeleteMasterMaterial(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterMaterials.FirstOrDefaultAsync(x => x.Id == Id);
                _context.MasterMaterials.Remove(item);
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }
        [HttpPost("SaveMasterMaterial")]
        public async Task<IActionResult> SaveMasterMaterial(MasterMaterial model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterMaterials.FirstOrDefaultAsync(x => x.Id == model.Id);
                    item.NameThai = model.NameThai;
                    item.Active = model.Active;
                    item.Code = model.Code;
                    item.MaterialGroupId = model.MaterialGroupId;
                    item.UnitId = model.UnitId;
                    item.UpdateOn = model.UpdateOn;
                    item.UpdateBy = model.UpdateBy;
                    _context.MasterMaterials.Update(item);
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterMaterials.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterMaterials.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }


        //- MaterialInItem
        [HttpGet("GetMaterialInItemByMaterialId")]
        public async Task<IActionResult> GetMaterialInItemByMaterialId(int? materialId)
        {
            var whr = PredicateBuilder.True<MaterialInItem>();
            if (materialId != null && materialId != 0) whr = whr.And(x => x.MaterialId == materialId);

            var res = await _context.MaterialInItems.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 5.MasterMaterialGroup
        [HttpGet("GetListVMasterMaterialGroup")]
        public async Task<IActionResult> GetListVMasterMaterialGroup(string? nameTh, string? code, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterMaterialGroup>();

            if (nameTh != null && nameTh != "") whr = whr.And(x => x.NameThai.Contains(nameTh));
            if (code != null && code != "") whr = whr.And(x => x.Code.Contains(code));
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VMasterMaterialGroups.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMasterMaterialGroup")]
        public async Task<IActionResult> GetMasterMaterialGroup(int? Id)
        {
            return Ok(await _context.MasterMaterialGroups.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterMaterialGroup());
        }
        [HttpGet("DeleteMasterMaterialGroup")]
        public async Task<IActionResult> DeleteMasterMaterialGroup(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterMaterialGroups.FirstOrDefaultAsync(x => x.Id == Id);
                _context.MasterMaterialGroups.Remove(item);
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }
        [HttpPost("SaveMasterMaterialGroup")]
        public async Task<IActionResult> SaveMasterMaterialGroup(MasterMaterialGroup model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterMaterialGroups.FirstOrDefaultAsync(x => x.Id == model.Id);
                    item.NameThai = model.NameThai;
                    item.Active = model.Active;
                    item.Code = model.Code;
                    item.EffectiveToDate = model.EffectiveToDate;
                    item.EffectiveFromDate = model.EffectiveFromDate;
                    item.UpdateOn = model.UpdateOn;
                    item.UpdateBy = model.UpdateBy;
                    _context.MasterMaterialGroups.Update(item);
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterMaterialGroups.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterMaterialGroups.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        //- MasterMaterialGroup
        [HttpGet("GetdataMasterMaterialByMaterialGroupId")]
        public async Task<IActionResult> GetdataMasterMaterialByMaterialGroupId(int? materialGroupId)
        {
            var whr = PredicateBuilder.True<MasterMaterial>();
            if (materialGroupId != null && materialGroupId != 0) whr = whr.And(x => x.MaterialGroupId == materialGroupId);

            var res = await _context.MasterMaterials.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 6.MasterStrategyCode
        [HttpGet("GetListVMasterStrategyCode")]
        public async Task<IActionResult> GetListVMasterStrategyCode(string? name)
        {
            var whr = PredicateBuilder.True<VMasterStrategyCode>();

            if (name != null && name != "") whr = whr.And(x => x.Name.Contains(name));

            var res = await _context.VMasterStrategyCodes.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMasterStrategyCode")]
        public async Task<IActionResult> GetMasterStrategyCode(int? Id)
        {
            return Ok(await _context.MasterStrategyCodes.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterStrategyCode());
        }
        [HttpGet("DeleteMasterStrategyCode")]
        public async Task<IActionResult> DeleteMasterStrategyCode(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterStrategyCodes.FirstOrDefaultAsync(x => x.Id == Id);
                _context.MasterStrategyCodes.Remove(item);
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }
        [HttpPost("SaveMasterStrategyCode")]
        public async Task<IActionResult> SaveMasterStrategyCode(MasterStrategyCode model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterStrategyCodes.FirstOrDefaultAsync(x => x.Id == model.Id);
                    item.Name = model.Name;
                    item.Abbreviation = model.Abbreviation;
                    item.Active = model.Active;
                    item.EffectiveToDate = model.EffectiveToDate;
                    item.EffectiveFromDate = model.EffectiveFromDate;
                    item.Kpi = model.Kpi;
                    item.Target = model.Target;
                    item.UpdateOn = model.UpdateOn;
                    item.UpdateBy = model.UpdateBy;
                    _context.MasterStrategyCodes.Update(item);
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterStrategyCodes.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterStrategyCodes.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetMasterBudgetExpenseTypeByStrategyCodeId")]
        public async Task<IActionResult> GetMasterBudgetExpenseTypeByStrategyCodeId(int? strategyCodeId)
        {
            var whr = PredicateBuilder.True<MasterBudgetExpenseType>();
            if (strategyCodeId != null && strategyCodeId != 0) whr = whr.And(x => x.StrategyCodeId == strategyCodeId);

            var res = await _context.MasterBudgetExpenseTypes.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMasterStrategicPlanCodeByStrategyCodeId")]
        public async Task<IActionResult> GetMasterStrategicPlanCodeByStrategyCodeId(int? strategyCodeId)
        {
            var whr = PredicateBuilder.True<MasterStrategicPlanCode>();
            if (strategyCodeId != null && strategyCodeId != 0) whr = whr.And(x => x.StrategyCodeId == strategyCodeId);

            var res = await _context.MasterStrategicPlanCodes.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 7.MasterStrategicPlanCode
        [HttpGet("GetListVMasterStrategicPlanCode")]
        public async Task<IActionResult> GetListVMasterStrategicPlanCode(string? name, int? strategyCodeId, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterStrategicPlanCode>();

            if (name != null && name != "") whr = whr.And(x => x.Name.Contains(name));
            if (strategyCodeId != null && strategyCodeId != 0) whr = whr.And(x => x.StrategyCodeId == strategyCodeId);           
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VMasterStrategicPlanCodes.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetMasterStrategicPlanCode")]
        public async Task<IActionResult> GetMasterStrategicPlanCode(int? Id)
        {
            return Ok(await _context.MasterStrategicPlanCodes.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterStrategicPlanCode());
        }

        [HttpPost("SaveMasterStrategicPlanCode")]
        public async Task<IActionResult> SaveMasterStrategicPlanCode(MasterStrategicPlanCode model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterStrategicPlanCodes.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {
                        item.Code = model.Code;
                        item.Name = model.Name;
                        item.BudgetYear = model.BudgetYear;
                        item.EffectiveToDate = model.EffectiveToDate;
                        item.EffectiveFromDate = model.EffectiveFromDate;
                        item.StrategyCodeId = model.StrategyCodeId;
                        item.Target = model.Target;
                        item.Kpi = model.Kpi;
                        item.Abbreviation = model.Abbreviation;
                        item.Active = model.Active; 
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;
                        _context.MasterStrategicPlanCodes.Update(item);
                    }
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterStrategicPlanCodes.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterStrategicPlanCodes.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterStrategicPlanCode")]
        public async Task<IActionResult> DeleteMasterStrategicPlanCode(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterStrategicPlanCodes.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.MasterStrategicPlanCodes.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetMasterBudgetExpenseTypeByStrategicPlanCodeId")]
        public async Task<IActionResult> GetMasterBudgetExpenseTypeByStrategicPlanCodeId(int? strategicPlanCodeId)
        {
            var whr = PredicateBuilder.True<MasterBudgetExpenseType>();
            if (strategicPlanCodeId != null && strategicPlanCodeId != 0) whr = whr.And(x => x.StrategicPlanCodeId == strategicPlanCodeId);

            var res = await _context.MasterBudgetExpenseTypes.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMasterOutputCodeByStrategicPlanCodeId")]
        public async Task<IActionResult> GetMasterOutputCodeByStrategicPlanCodeId(int? strategicPlanCodeId)
        {
            var whr = PredicateBuilder.True<MasterOutputCode>();
            if (strategicPlanCodeId != null && strategicPlanCodeId != 0) whr = whr.And(x => x.StrategicPlanCodeId == strategicPlanCodeId);

            var res = await _context.MasterOutputCodes.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 8.MasterOutputCode
        [HttpGet("GetListVMasterOutputCode")]
        public async Task<IActionResult> GetListVMasterOutputCode(string? name, int? strategyCodeId, int? strategicPlanCodeId, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterOutputCode>();

            if (name != null && name != "") whr = whr.And(x => x.Name.Contains(name));
            if (strategyCodeId != null && strategyCodeId != 0) whr = whr.And(x => x.StrategyCodeId == strategyCodeId);
            if (strategicPlanCodeId != null && strategicPlanCodeId != 0) whr = whr.And(x => x.StrategicPlanCodeId == strategicPlanCodeId);
            if (Active != null) whr = whr.And(x => x.Active == Active);
            var res = await _context.VMasterOutputCodes.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetMasterOutputCode")]
        public async Task<IActionResult> GetMasterOutputCode(int? Id)
        {
            return Ok(await _context.MasterOutputCodes.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterOutputCode());
        }

        [HttpPost("SaveMasterOutputCode")]
        public async Task<IActionResult> SaveMasterOutputCode(MasterOutputCode model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterOutputCodes.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null) {
                        item.Code = model.Code;
                        item.Name = model.Name;
                        item.BudgetYear = model.BudgetYear;
                        item.EffectiveToDate = model.EffectiveToDate;
                        item.EffectiveFromDate = model.EffectiveFromDate;
                        item.StrategicPlanCodeId = model.StrategicPlanCodeId;
                        item.OutputType = model.OutputType;
                        item.Target = model.Target;
                        item.Kpi = model.Kpi;
                        item.Abbreviation = model.Abbreviation;
                        item.Active = model.Active;
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;
                        _context.MasterOutputCodes.Update(item);
                    }                  
                   
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterOutputCodes.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterOutputCodes.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterOutputCode")]
        public async Task<IActionResult> DeleteMasterOutputCode(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterOutputCodes.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.MasterOutputCodes.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }
        [HttpGet("GetMasterBudgetExpenseTypeByOutputCodeId")]
        public async Task<IActionResult> GetMasterBudgetExpenseTypeByOutputCodeId(int? outputCodeId)
        {
            var whr = PredicateBuilder.True<MasterBudgetExpenseType>();
            if (outputCodeId != null && outputCodeId != 0) whr = whr.And(x => x.OutputCodeId == outputCodeId);

            var res = await _context.MasterBudgetExpenseTypes.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMasterActivityCodeByOutputCodeId")]
        public async Task<IActionResult> GetMasterActivityCodeByOutputCodeId(int? outputCodeId)
        {
            var whr = PredicateBuilder.True<MasterActivityCode>();
            if (outputCodeId != null && outputCodeId != 0) whr = whr.And(x => x.OutputCodeId == outputCodeId);

            var res = await _context.MasterActivityCodes.Where(whr).ToListAsync();
            return Ok(res);
        }

        #endregion

        #region 9.MasterActivityCode
        [HttpGet("GetListVMasterActivityCode")]
        public async Task<IActionResult> GetListVMasterActivityCode(string? name, int? strategyCodeId, int? strategicPlanCodeId, int? outputCodeId, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterActivityCode>();

            if (name != null && name != "") whr = whr.And(x => x.Name.Contains(name));
            if (strategyCodeId != null && strategyCodeId != 0) whr = whr.And(x => x.StrategyCodeId == strategyCodeId);
            if (strategicPlanCodeId != null && strategicPlanCodeId != 0) whr = whr.And(x => x.StrategicPlanCodeId == strategicPlanCodeId);
            if (outputCodeId != null && outputCodeId != 0) whr = whr.And(x => x.OutputCodeId == outputCodeId);
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VMasterActivityCodes.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetMasterActivityCode")]
        public async Task<IActionResult> GetMasterActivityCode(int? Id)
        {
            return Ok(await _context.MasterActivityCodes.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterActivityCode());
        }

        [HttpPost("SaveMasterActivityCode")]
        public async Task<IActionResult> SaveMasterActivityCode(MasterActivityCode model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterActivityCodes.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {
                        item.OutputCodeId = model.OutputCodeId;
                        item.Name = model.Name;
                        item.Abbreviation = model.Abbreviation;
                        item.Active = model.Active;
                        item.Code = model.Code;
                        item.EffectiveToDate = model.EffectiveToDate;
                        item.EffectiveFromDate = model.EffectiveFromDate;
                        item.Kpi = model.Kpi;
                        item.Target = model.Target;
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;
                        _context.MasterActivityCodes.Update(item);
                    }                  
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterActivityCodes.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterActivityCodes.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterActivityCode")]
        public async Task<IActionResult> DeleteMasterActivityCode(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterActivityCodes.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.MasterActivityCodes.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetBudgetGovernmentItemByActivityCodeId")]
        public async Task<IActionResult> GetBudgetGovernmentItemByActivityCodeId(int? activityCodeId)
        {
            var whr = PredicateBuilder.True<BudgetGovernmentItem>();
            if (activityCodeId != null && activityCodeId != 0) whr = whr.And(x => x.ActivityCodeId == activityCodeId);

            var res = await _context.BudgetGovernmentItems.Where(whr).ToListAsync();
            return Ok(res);
        }

        #endregion

        #region 10.MasterStorePlace
        [HttpGet("GetListVMasterStorePlace")]
        public async Task<IActionResult> GetListVMasterStorePlace(string? name, int? organizationId, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterStorePlace>();

            if (name != null && name != "") whr = whr.And(x => x.NameThai.Contains(name));
            if (organizationId != null && organizationId != 0) whr = whr.And(x => x.OrganizationId == organizationId);
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VMasterStorePlaces.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetMasterStorePlace")]
        public async Task<IActionResult> GetMasterStorePlace(int? Id)
        {
            return Ok(await _context.MasterStorePlaces.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterStorePlace());
        }

        [HttpPost("SaveMasterStorePlace")]
        public async Task<IActionResult> SaveMasterStorePlace(MasterStorePlace model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterStorePlaces.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;

                        item.Active = model.Active;
                        item.NameThai = model.NameThai;
                        item.Code = model.Code;
                        item.OrganizationId = model.OrganizationId;
                        item.Floor = model.Floor;                    
                      
                        _context.MasterStorePlaces.Update(item);
                    }
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterStorePlaces.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }
                    _context.MasterStorePlaces.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterStorePlace")]
        public async Task<IActionResult> DeleteMasterStorePlace(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterStorePlaces.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.MasterStorePlaces.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetAssetByStorePlaceId")]
        public async Task<IActionResult> GetAssetByStorePlaceId(int? storePlaceId)
        {
            var whr = PredicateBuilder.True<Asset>();
            if (storePlaceId != null && storePlaceId != 0) whr = whr.And(x => x.StorePlaceId == storePlaceId);

            var res = await _context.Assets.Where(whr).ToListAsync();
            return Ok(res);
        }

        #endregion

        #region 11.MasterBudgetExpenseType 
        [HttpGet("GetListVMasterBudgetExpenseType")]
        public async Task<IActionResult> GetListVMasterBudgetExpenseType(int? strategyCodeId, int? strategicPlanCodeId, int? outputCodeId, int? expenseTypeId)
        {
            var whr = PredicateBuilder.True<VMasterBudgetExpenseType>();

            if (strategyCodeId != null && strategyCodeId != 0) whr = whr.And(x => x.StrategyCodeId == strategyCodeId);
            if (strategicPlanCodeId != null && strategicPlanCodeId != 0) whr = whr.And(x => x.StrategicPlanCodeId == strategicPlanCodeId);
            if (outputCodeId != null && outputCodeId != 0) whr = whr.And(x => x.OutputCodeId == outputCodeId);
            if (expenseTypeId != null && expenseTypeId != 0) whr = whr.And(x => x.ExpenseTypeId == expenseTypeId);

            var res = await _context.VMasterBudgetExpenseTypes.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetMasterBudgetExpenseType")]
        public async Task<IActionResult> GetMasterBudgetExpenseType(int? Id)
        {
            return Ok(await _context.MasterBudgetExpenseTypes.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterBudgetExpenseType());
        }

        [HttpPost("SaveMasterBudgetExpenseType")]
        public async Task<IActionResult> SaveMasterBudgetExpenseType(MasterBudgetExpenseType model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.MasterBudgetExpenseTypes.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {
                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;
                        item.Active = model.Active;
                        item.Name = model.Name;
                        item.BudgetTypeId = model.BudgetTypeId;
                        item.ExpenseTypeId = model.ExpenseTypeId;
                        item.StrategyCodeId = model.StrategyCodeId;
                        item.StrategicPlanCodeId = model.StrategicPlanCodeId;
                        item.OutputCodeId = model.OutputCodeId;
                        item.MoneySourceId = model.MoneySourceId;
                        item.BudgetExpenseLevel = model.BudgetExpenseLevel;   
                        item.ParentId = model.ParentId;
                        if (model.ParentId == null)
                        {
                            item.IsParent = true;
                        }
                        else
                        {
                            item.IsParent = false;
                        }
                        //item.IsParent = model.IsParent;
                        item.BudgetFormTypeId = model.BudgetFormTypeId;

                        _context.MasterBudgetExpenseTypes.Update(item);
                    }
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterBudgetExpenseTypes.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.Id = maxId + 1;
                    }
                    else { model.Id = 1; }

                    if (model.ParentId == null)
                    {
                        model.IsParent = true;
                    }
                    else
                    {
                        model.IsParent = false;
                    }
                    _context.MasterBudgetExpenseTypes.Add(model);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterBudgetExpenseType")]
        public async Task<IActionResult> DeleteMasterBudgetExpenseType(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterBudgetExpenseTypes.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.MasterBudgetExpenseTypes.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetBudgetGovernmentItemByBudgetExpenseTypeId")]
        public async Task<IActionResult> GetBudgetGovernmentItemByBudgetExpenseTypeId(int? budgetExpenseTypeId)
        {
            var whr = PredicateBuilder.True<BudgetGovernmentItem>();
            if (budgetExpenseTypeId != null && budgetExpenseTypeId != 0) whr = whr.And(x => x.BudgetExpenseTypeId == budgetExpenseTypeId);

            var res = await _context.BudgetGovernmentItems.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 12.MasterWarehouse
        [HttpGet("GetListVMasterWarehouse")]
        public async Task<IActionResult> GetListVMasterWarehouse(string? name, int? organizationId, bool? Active)
        {
            var whr = PredicateBuilder.True<VMasterWarehouse>();

            if (name != null && name != "") whr = whr.And(x => x.Name.Contains(name));
            if (organizationId != null && organizationId != 0) whr = whr.And(x => x.OrganizationId == organizationId);
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VMasterWarehouses.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetMasterWarehouse")]
        public async Task<IActionResult> GetMasterWarehouse(int? Id)
        {       
            var data = new MasterWarehouseDetail();

            data.MasterWarehouse = await _context.MasterWarehouses.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterWarehouse();
            data.listVMaterialSafetyStock = await _context.VMaterialSafetyStocks.Where(x => x.WarehouseId == Id).ToListAsync();
            return Ok(data);
        }

        [HttpGet("GetMaterialSafetyStockByMaterialGroupId")]
        public async Task<IActionResult> GetMaterialSafetyStockByMaterialGroupId(int? Id, int? materialGroupId)
        {

            //MasterWarehouseDetail
            var data = new MasterWarehouseDetail { MasterWarehouse = new MasterWarehouse(), listVMaterialSafetyStock = new List<VMaterialSafetyStock>() };
           
            data.MasterWarehouse = await _context.MasterWarehouses.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterWarehouse();
            var query =
                           from ms in _context.MaterialSafetyStocks
                           join mm in _context.MasterMaterials on ms.MaterialId equals mm.Id
                           join mg in _context.MasterMaterialGroups on mm.MaterialGroupId equals mg.Id
                           where mm.Active == true && mg.Active == true
                           && ms.WarehouseId == Id && mg.Id == materialGroupId
                           select new VMaterialSafetyStock
                           {
                               Id = ms.Id,
                               CreateBy = ms.CreateBy,
                               CreateOn = ms.CreateOn,
                               UpdateBy = ms.UpdateBy,
                               UpdateOn = ms.UpdateOn,
                               WarehouseId = ms.WarehouseId,
                               MaterialId = ms.MaterialId,
                               MinStock = ms.MinStock,
                               MaxStock = ms.MaxStock,
                               DrawableAmount = ms.DrawableAmount,
                               MaterialName = mm.NameThai
                           };                               
                         

            var res = await query.ToListAsync().ConfigureAwait(false);         
            if (res != null && res.Count > 0)
            {
                data.listVMaterialSafetyStock = res;
            }          

            return Ok(data);
        }

        [HttpPost("SaveMasterWarehouse")]
        public async Task<IActionResult> SaveMasterWarehouse(MasterWarehouseDetail model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.MasterWarehouse.Id != 0)
                {
                    var item = await _context.MasterWarehouses.FirstOrDefaultAsync(x => x.Id == model.MasterWarehouse.Id);
                    if (item != null)
                    {
                        item.UpdateOn = model.MasterWarehouse.UpdateOn;
                        item.UpdateBy = model.MasterWarehouse.UpdateBy;
                        item.Name = model.MasterWarehouse.Name;
                        item.OrganizationId = model.MasterWarehouse.OrganizationId;
                        item.WarehouseLevel = model.MasterWarehouse.WarehouseLevel;
                        item.Active = model.MasterWarehouse.Active; 
                        _context.MasterWarehouses.Update(item);
                    }
                }
                else
                {
                    //Get Max ID  
                    var res = await _context.VMasterWarehouses.ToListAsync();
                    int maxId = 0;
                    if (res != null && res.Count > 0)
                    {
                        maxId = res.Last().Id;
                        model.MasterWarehouse.Id = maxId + 1;
                    }
                    else { model.MasterWarehouse.Id = 1; }
                    _context.MasterWarehouses.Add(model.MasterWarehouse);
                }
                await _context.SaveChangesAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteMasterWarehouse")]
        public async Task<IActionResult> DeleteMasterWarehouse(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.MasterWarehouses.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.MasterWarehouses.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetMaterialSafetyStock")]
        public async Task<IActionResult> GetMaterialSafetyStock(int? Id)
        {

            return Ok(await _context.MaterialSafetyStocks.FirstOrDefaultAsync(x => x.Id == Id) ?? new MaterialSafetyStock());
        }

     

        [HttpPost("UpdateListMaterialSafetyStock")]
        public async Task<IActionResult> UpdateListMaterialSafetyStock(VMaterialSafetyStock[] model)
        {
            var result = new ApiResultsModel();
            try
            {
                for (var i = 0; i < model.Length; i++)
                {
                    if (model[i].Id != 0)
                    {
                        var item = await _context.MaterialSafetyStocks.FirstOrDefaultAsync(x => x.Id == model[i].Id);
                        if (item != null)
                        {
                            item.MaxStock = model[i].MaxStock;
                            item.MinStock = model[i].MinStock;
                            item.DrawableAmount = model[i].DrawableAmount;
                            item.UpdateOn = model[i].UpdateOn;
                            item.UpdateBy = model[i].UpdateBy;
                            _context.MaterialSafetyStocks.Update(item);
                        }
                    }
                   
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }
               
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetMaterialInByWarehouseId")]
        public async Task<IActionResult> GetMaterialInByWarehouseId(int? warehouseId)
        {
            var whr = PredicateBuilder.True<MaterialIn>();
            if (warehouseId != null && warehouseId != 0) whr = whr.And(x => x.WarehouseId == warehouseId);

            var res = await _context.MaterialIns.Where(whr).ToListAsync();
            return Ok(res);
        }


        #endregion

        #region 13.Supplier
        [HttpGet("GetListVSupplier")]
        public async Task<IActionResult> GetListVSupplier(string? nameThai, string? taxId, string? supplierCode, bool? Active)
        {
            var whr = PredicateBuilder.True<VSupplier>();

            if (nameThai != null && nameThai != "") whr = whr.And(x => x.NameThai.Contains(nameThai));
            if (taxId != null && taxId != "") whr = whr.And(x => x.TaxId.Contains(taxId));
            if (supplierCode != null && supplierCode != "") whr = whr.And(x => x.SupplierCode.Contains(supplierCode));
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VSuppliers.Where(whr).ToListAsync();
            return Ok(res);
        }

        [HttpGet("GetSupplier")]
        public async Task<IActionResult> GetSupplierModel(int? Id)
        {
            return Ok(await _context.Suppliers.FirstOrDefaultAsync(x => x.Id == Id) ?? new Supplier());
        }

        [HttpPost("SaveSupplier")]
        public async Task<IActionResult> SaveSupplier(SupplierModel data)
        {
            var result = new ApiResultsModel();
            var model = data.Supplier;
            try
            {
                if (model.Id != 0)
                {
                    var item = await _context.Suppliers.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (item != null)
                    {

                        item.PersonType = model.PersonType;
                        item.NameThai = model.NameThai;
                        item.Active = model.Active;
                        item.TaxId = model.TaxId;
                        item.SupplierCode = model.SupplierCode;
                        item.Address = model.Address;
                        item.ProvinceId = model.ProvinceId;
                        item.AmphurId = model.AmphurId;
                        item.TambonId = model.TambonId;
                        item.ZipCode = model.ZipCode;
                        item.Phone = model.Phone;
                        item.BankId = model.BankId;
                        item.BankBranch = model.BankBranch;
                        item.AccountName = model.AccountName;
                        item.Email = model.Email;

                        //item.FullAddress = model.FullAddress;   
                        //item.BankAccount = model.BankAccount;                        

                        item.UpdateOn = model.UpdateOn;
                        item.UpdateBy = model.UpdateBy;
                        _context.Suppliers.Update(item);
                        await _context.SaveChangesAsync();
                        result.Success = true;

                    }
                }
                else
                {                    
                    _context.Suppliers.Add(model);
                    await _context.SaveChangesAsync();
                    result.Success = true;


                    foreach (var item in data.FileGuidId ?? new List<string>())
                    {
                        var file = _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(item)).FirstOrDefault();
                        file.ReferenceId = model.Id;
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

        [HttpGet("DeleteSupplier")]
        public async Task<IActionResult> DeleteSupplier(int? Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var item = await _context.Suppliers.FirstOrDefaultAsync(x => x.Id == Id);
                if (item != null)
                {
                    _context.Suppliers.Remove(item);
                    await _context.SaveChangesAsync();
                    result.Success = true;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("GetListItemAmphur")]
        public async Task<IActionResult> GetListItemAmphur(int? provinceId)
        {
            var whr = PredicateBuilder.True<MasterAmphur>();

            if (provinceId != null && provinceId != 0) whr = whr.And(x => x.ProvinceId == provinceId);
            var res = await _context.MasterAmphurs.Where(whr).ToListAsync();

            return Ok(res.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
          
        }

        [HttpGet("GetListItemTambon")]
        public async Task<IActionResult> GetListItemTambon(int? provinceId, int? amphurId)
        {
            var result = new SelectListItem();

            if (amphurId != 0)
            {
                var query =
                            from mt in _context.MasterTambons
                            join ma in _context.MasterAmphurs on mt.AmphurId equals ma.Id                           
                            where mt.Active == true && ma.Active == true && ma.Active == true
                            && ma.Id == amphurId
                            select new
                            {
                                mt.Id,
                                mt.NameThai,
                            };
                var res = await query.ToListAsync().ConfigureAwait(false);
                return Ok(res.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
            }
           else if (provinceId != 0 && amphurId == 0)
            {
                var query =
                            from mt in _context.MasterTambons
                            join ma in _context.MasterAmphurs on mt.AmphurId equals ma.Id
                            join mp in _context.MasterProvinces on ma.ProvinceId equals mp.Id
                            where mt.Active == true && ma.Active == true && ma.Active == true
                            && mp.Id == provinceId 
                            select new
                            {
                                mt.Id,
                                mt.NameThai,
                            };
                var res = await query.ToListAsync().ConfigureAwait(false);
                return Ok(res.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
            }
                       
         return Ok(result);

        }

        [HttpGet("GetMasterTambon")]
        public async Task<IActionResult> GetMasterTambon(int? Id)
        {
            return Ok(await _context.MasterTambons.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterTambon());
        }

        [HttpGet("GetMasterAmphur")]
        public async Task<IActionResult> GetMasterAmphur(int? Id)
        {
            return Ok(await _context.MasterAmphurs.FirstOrDefaultAsync(x => x.Id == Id) ?? new MasterAmphur());
        }

        [HttpGet("GetAssetBySupplierId")]
        public async Task<IActionResult> GetAssetBySupplierId(int? supplierId)
        {
            var whr = PredicateBuilder.True<Asset>();
            if (supplierId != null && supplierId != 0) whr = whr.And(x => x.SupplierId == supplierId);           

            var res = await _context.Assets.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetAssetMBySupplierId")]
        public async Task<IActionResult> GetAssetMBySupplierId(int? supplierId)
        {
            var whr = PredicateBuilder.True<AssetMaintenance>();
            if (supplierId != null && supplierId != 0) whr = whr.And(x => x.SupplierId == supplierId);

            var res = await _context.AssetMaintenances.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetAssetMFBySupplierId")]
        public async Task<IActionResult> GetAssetMFBySupplierId(int? supplierId)
        {
            var whr = PredicateBuilder.True<AssetMaintenanceForm>();
            if (supplierId != null && supplierId != 0) whr = whr.And(x => x.SupplierId == supplierId);

            var res = await _context.AssetMaintenanceForms.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetMaterialInBySupplierId")]
        public async Task<IActionResult> GetMaterialInBySupplierId(int? supplierId)
        {
            var whr = PredicateBuilder.True<MaterialIn>();
            if (supplierId != null && supplierId != 0) whr = whr.And(x => x.SupplierId == supplierId);

            var res = await _context.MaterialIns.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetProcurementBySupplierId")]
        public async Task<IActionResult> GetProcurementBySupplierId(int? supplierId)
        {
            var whr = PredicateBuilder.True<Procurement>();
            if (supplierId != null && supplierId != 0) whr = whr.And(x => x.SupplierId == supplierId);

            var res = await _context.Procurements.Where(whr).ToListAsync();
            return Ok(res);
        }
        #endregion

        #region 14.Organization
        [HttpGet("GetListMasterOrganization")]
        public async Task<IActionResult> GetListMasterOrganization()
        {
            var whr = PredicateBuilder.True<MasterOrganization>();

            var res = await _context.MasterOrganizations.ToListAsync();
            return Ok(res);
        }
        #endregion

    }
}

