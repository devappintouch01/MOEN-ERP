using MOEN_ERP.API.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesRequestController : ControllerBase
    {

        private readonly IExpensesRequestService _expen;
        public ExpensesRequestController(IExpensesRequestService expen) {
            _expen = expen;
        }

    }
}
