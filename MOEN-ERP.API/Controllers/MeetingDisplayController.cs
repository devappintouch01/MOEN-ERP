using MOEN_ERP.API.Services.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingDisplayController : ControllerBase
    {
        private readonly IMeetingDisplayService _display;
        public MeetingDisplayController(IMeetingDisplayService display) {
            _display = display;
        }


    }
}
