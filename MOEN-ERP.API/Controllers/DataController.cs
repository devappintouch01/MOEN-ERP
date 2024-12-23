using MOEN_ERP.API.Services.Repository;
using MOEN_ERP.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataService _dataService;
        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        #region SystemRole
        [HttpGet("GetSystemRoleList")]
        public async Task<IActionResult> GetSystemRoleList([FromBody] SystemRole data)
        {
            var res = await _dataService.GetSystemRoleListAsync(data);
            return Ok(res);
        }
        [HttpGet("GetSystemRole/{Id}")]
        public async Task<IActionResult> GetSystemRole(int Id)
        {
            var res = await _dataService.GetSystemRoleAsync(Id);
            return Ok(res);
        }
        [HttpGet("GetSystemRoleBySystemMenuGroupList/{SystemMenuGroupId}")]
        public async Task<IActionResult> GetSystemRoleBySystemMenuGroupList(int SystemMenuGroupId)
        {
            var res = await _dataService.GetSystemRoleBySystemMenuGroupListAsync(SystemMenuGroupId);
            return Ok(res);
        }
        #endregion

    }
}
