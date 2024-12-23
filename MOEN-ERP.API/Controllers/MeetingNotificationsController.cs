using MOEN_ERP.API.Services.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingNotificationsController : ControllerBase
    {
        private readonly IMeetingNotificationsService _noti;
        public MeetingNotificationsController(IMeetingNotificationsService noti) {
            _noti = noti;
        }

    }
}
