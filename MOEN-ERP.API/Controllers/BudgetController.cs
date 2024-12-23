using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOEN_ERP.API.Services.Repository;
using MOEN_ERP.Models.Data;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        IBudgetService _service;
        public BudgetController(IBudgetService service)
        {
            _service = service;
        }

        [HttpGet("GetBudgetListAsync")]
        public async Task<IActionResult> GetBudgetListAsync([FromQuery] BudgetRequestFilter data)
        {
            try
            {
                // Get the username from the authenticated user
                var username = User.Identity?.Name;

                var result = await _service.GetBudgetListAsync(data);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("BudgetRequestDetail")]
        public async Task<IActionResult> BudgetRequestDetail(int id)
        {
            try
            {
                var result = await _service.BudgetRequestDetail(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("SaveBudgetList")]
        public async Task<IActionResult> SaveBudgetList([FromBody] BudgetRequestForm data)
        {
            try
            {
                var result = await _service.SaveBudgetList(data);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("DeleteBudgetRequest")]
        public async Task<IActionResult> DeleteBudgetRequest(int id)
        {
            try
            {
                _service.DeleteBudgetRequest(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
