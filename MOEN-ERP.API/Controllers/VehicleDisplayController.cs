using MOEN_ERP.API.Services.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleDisplayController : ControllerBase
    {
        private readonly IVehicleDisplayService _display;
        public VehicleDisplayController(IVehicleDisplayService display) {
            _display = display;
        }


    }
}
