using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Transactions;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IExpensesRequestService
    {
    }
    public class ExpensesRequestService : IExpensesRequestService
    {
        MOENDBContext context;
        private readonly IUtilityServices _utility;
        public ExpensesRequestService(IUtilityServices utility, MOENDBContext _context)
        {
            context = _context;
            _utility = utility;
        }

    }

}
