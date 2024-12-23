using MOEN_ERP.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMBController : ControllerBase
    {
        private readonly MOENDBContext _context;
        public CMBController(MOENDBContext context)
        {
            _context = context;
        }
        [HttpGet("GetSystemRoles")]
        public async Task<IActionResult> GetSystemRoles()
        {
            var data = await _context.SystemRoles.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.RoleName, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetSystemMenuGroups")]
        public async Task<IActionResult> GetSystemMenuGroups()
        {
            var data = await _context.SystemMenuGroups.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterMaterialGroup")]
        public async Task<IActionResult> GetMasterMaterialGroup()
        {
            var data = await _context.MasterMaterialGroups.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterMaterialGroupCode")]
        public async Task<IActionResult> GetMasterMaterialGroupCode()
        {
            var data = await _context.MasterMaterialGroups.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Code, Value = s.Code.ToString() }).ToList());
        }
        [HttpGet("GetMasterMaterialGroupIdCode")]
        public async Task<IActionResult> GetMasterMaterialGroupIdCode()
        {
            var data = await _context.MasterMaterialGroups.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Code, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterAssetBudgetType")]
        public async Task<IActionResult> GetMasterAssetBudgetType()
        {
            var data = await _context.MasterAssetBudgetTypes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterAssetAcquisitionType")]
        public async Task<IActionResult> GetMasterAssetAcquisitionType()
        {
            var data = await _context.MasterAssetAcquisitionTypes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }

        [HttpGet("GetMasterProcurementMethod")]
        public async Task<IActionResult> GetMasterProcurementMethod()
        {
            var data = await _context.MasterProcurementMethods.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }

        [HttpGet("GetMasterUnit")]
        public async Task<IActionResult> GetMasterUnit()
        {
            var data = await _context.MasterUnits.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterStrategyCode")]
        public async Task<IActionResult> GetMasterStrategyCode()
        {
            var data = await _context.MasterStrategyCodes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterStrategicPlanCode")]
        public async Task<IActionResult> GetMasterStrategicPlanCode()
        {
            var data = await _context.MasterStrategicPlanCodes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterOutputCode")]
        public async Task<IActionResult> GetMasterOutputCode()
        {
            var data = await _context.MasterOutputCodes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterAssetType")]
        public async Task<IActionResult> GetMasterAssetType()
        {
            var data = await _context.MasterAssetTypes.Where(x => x.Active == true).OrderBy(x => x.SequenceNumber).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterAssetClass")]
        public async Task<IActionResult> GetMasterAssetClass()
        {
            var data = await _context.MasterAssetClasses.Where(x => x.Active == true).OrderBy(x => x.SequenceNumber).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterAssetTypeSub")]
        public async Task<IActionResult> GetMasterAssetTypeSub()
        {
            var data = await _context.MasterAssetTypeSubs.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterCostCenter")]
        public async Task<IActionResult> GetMasterCostCenter()
        {
            var data = await _context.MasterCostCenters.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterStorePlace")]
        public async Task<IActionResult> GetMasterStorePlace()
        {
            var data = await _context.MasterStorePlaces.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterOrganization")]  
        public async Task<IActionResult> GetMasterOrganization()
        {
            var data = await _context.MasterOrganizations.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetVMasterWarehouse")]
        public async Task<IActionResult> GetVMasterWarehouse()
        {
            var data = await _context.VMasterWarehouses.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList());
        }

        [HttpGet("GetMasterStatus")]
        public async Task<IActionResult> GetMasterStatus()
        {
            var data = await _context.MasterStatuses.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList());
        }

        [HttpGet("GetVMasterMaterial")]
        public async Task<IActionResult> GetVMasterMaterial()
        {
            var data = await _context.VMasterMaterials.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }  

        [HttpGet("GetVOfficer")]
        public async Task<IActionResult> GetVOfficer()
        {
            var data = await _context.VOfficers.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.FullName, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
        }

        [HttpGet("GetMasterProvince")]
        public async Task<IActionResult> GetMasterProvince()
        {
            var data = await _context.MasterProvinces.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
        }

        [HttpGet("GetMasterAmphur")]
        public async Task<IActionResult> GetMasterAmphur()
        {
            var data = await _context.MasterAmphurs.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
        }

        [HttpGet("GetMasterTambon")]
        public async Task<IActionResult> GetMasterTambon()
        {
            var data = await _context.MasterTambons.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
        }

        [HttpGet("GetMasterBank")]
        public async Task<IActionResult> GetMasterBank()
        {
            var data = await _context.MasterBanks.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
        }

        [HttpGet("GetMasterExpenseType")]
        public async Task<IActionResult> GetMasterExpenseType()
        {
            var data = await _context.MasterExpenseTypes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
        }

        [HttpGet("GetMasterDocumentType")]
        public async Task<IActionResult> GetMasterDocumentType(int? documentGroup)
        {
            var data = await _context.MasterDocumentTypes.Where(x => x.Active == true && x.DocumentGroup == documentGroup).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }

        [HttpGet("GetMasterMoneySource")]
        public async Task<IActionResult> GetMasterMoneySource()
        {
            var data = await _context.MasterMoneySources.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
        }

        [HttpGet("GetMasterBudgetFormType")]
        public async Task<IActionResult> GetMasterBudgetFormType()
        {
            var data = await _context.MasterBudgetFormTypes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).OrderBy(x => x.Text).ToList());
        }

        [HttpGet("GetVMasterWarehouseByOrganizationId")]
        public async Task<IActionResult> GetVMasterWarehouseByOrganizationId(int? organizationId)
        {
            var data = await _context.VMasterWarehouses.Where(x => x.Active == true && x.OrganizationId == organizationId).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterFuelType")]
        public async Task<IActionResult> GetMasterFuelType()
        {
            var data = await _context.MasterFuelTypes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterLandType")]
        public async Task<IActionResult> GetMasterLandType()
        {
            var data = await _context.MasterLandTypes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
        [HttpGet("GetMasterWriteOffType")]
        public async Task<IActionResult> GetMasterWriteOffType()
        {
            var data = await _context.MasterWriteOffTypes.Where(x => x.Active == true).ToListAsync();
            return Ok(data.Select(s => new SelectListItem { Text = s.NameThai, Value = s.Id.ToString() }).ToList());
        }
    }
}
