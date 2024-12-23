using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Data;
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
    public class DashboardController : ControllerBase
    {
        private readonly MOENDBContext _context;
        public DashboardController(MOENDBContext context)
        {
            _context = context;
        }
    }
}
