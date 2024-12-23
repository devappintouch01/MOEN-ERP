using MOEN_ERP.API.Services;
using MOEN_ERP.API.Services.Repository;
using MOEN_ERP.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;


namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {
        public readonly IAuthenService _auth;
        public AuthenController(IAuthenService auth) {
            _auth = auth;
        }

        #region SignIn
        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn([FromBody] MOEN_ERP.Models.Common.SignInModel data)
        {
            //Logz.AddLog("Start Sign In Api");
            var res = await _auth.SignInAsync(data);
            return Ok(res);
        }


        [HttpPost("SignInSSO")]
        public async Task<IActionResult> SignInSSO([FromBody] MOEN_ERP.Models.Common.SignInSSOModel data)
        {
            var res = await _auth.SignInSSOAsync(data);
            return Ok(res);
        }
        #endregion




    }
}
