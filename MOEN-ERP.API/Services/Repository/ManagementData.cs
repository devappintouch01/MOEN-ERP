using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using LinqKit;
using Microsoft.EntityFrameworkCore;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IManagementData
    {
       
    }
    public class ManagementData : IManagementData
    {
        MOENDBContext context;
        public ManagementData(MOENDBContext _context) {
            context = _context;
        }


    }
}
