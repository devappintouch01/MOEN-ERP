using MOEN_ERP.DAL.Models;
using LinqKit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MOEN_ERP.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsVehicleController : ControllerBase
    {
        private readonly MOENDBContext _context;
        public ReportsVehicleController(MOENDBContext context)
        {
            _context = context;
        }

    }
}
