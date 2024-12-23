
using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Transactions;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IMasterService
    {
    }

    public class MasterService : IMasterService
    {
        MOENDBContext context;
        public MasterService(MOENDBContext _context) {
            context = _context;
        }

    }
}
