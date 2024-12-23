using MOEN_ERP.API.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesConsiderController : ControllerBase
    {
        private readonly IExpensesConsiderService _expenCon;
        public ExpensesConsiderController(IExpensesConsiderService expenCon) {
            _expenCon = expenCon;
        }

    }
}
