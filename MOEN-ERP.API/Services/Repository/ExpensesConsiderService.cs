using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace MOEN_ERP.API.Services.Repository
{

    public interface IExpensesConsiderService
    {
    }
    public class ExpensesConsiderService : IExpensesConsiderService
    {
        MOENDBContext context;
        private readonly IUtilityServices _utility;
        public ExpensesConsiderService(IUtilityServices utility, MOENDBContext _context)
        {
            _utility = utility;
            context = _context;
        }
        

    }

}
