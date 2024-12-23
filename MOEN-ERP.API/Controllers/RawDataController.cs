using Microsoft.AspNetCore.Mvc;
using MOEN_ERP.API.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using MOEN_ERP.Models.Data;
using MOEN_ERP.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace MOEN_ERP.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class RawDataController : ControllerBase
    {

        private readonly IRawDataService _rawData; 
        private readonly MOENDBContext _context;

        public RawDataController(IRawDataService rawData, MOENDBContext context)
        {
            _rawData = rawData;
            _context = context;
        }

        #region V_SystemUserRoleAssign
        [HttpGet("GetViewSystemUserRoleAssignList")]
        public async Task<IActionResult> GetViewSystemUserRoleAssignList([FromBody] VSystemUserRoleAssign data)
        {
            var res = await _rawData.GetViewSystemUserRoleAssignListAsync(data);
            return Ok(res);
        }
        [HttpGet("GetViewSystemUserRoleAssign/{Id}")]
        public async Task<IActionResult> GetViewSystemUserRoleAssign(int Id)
        {
            var res = await _rawData.GetViewSystemUserRoleAssignAsync(Id);
            return Ok(res);
        }
        #endregion


        #region FN_BookingSystemMenu
        [HttpGet("GetFunctionSystemMenuList")]
        public async Task<IActionResult> GetFunctionSystemMenuList([FromBody] MOEN_ERP.Models.ViewModel.FunctionSystemMenu data)
        {
            var res = await _rawData.GetFunctionSystemMenuListAsync(data);
            return Ok(res);
        }
        #endregion
    }
}
