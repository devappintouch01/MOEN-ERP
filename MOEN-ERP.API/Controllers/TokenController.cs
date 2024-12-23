using MOEN_ERP.API.Models;
using MOEN_ERP.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : Controller
    {
        private IJwtTokenManager _tokenManager;
        public TokenController(IJwtTokenManager tokenManager)
        {
            _tokenManager = tokenManager;
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody]UserCredential credential)
        {
            var token = _tokenManager.Authenticate(credential.UserName, credential.Password);
            if (string.IsNullOrEmpty(token))
                return Unauthorized();
            return Ok(token);
        }
    }
}
