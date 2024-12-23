using MOEN_ERP.API.Services.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleNotificationsController : ControllerBase
    {
        private readonly IVehicleNotificationsService _noti;
        public VehicleNotificationsController(IVehicleNotificationsService noti) {
            _noti = noti;
        }

    }

}
