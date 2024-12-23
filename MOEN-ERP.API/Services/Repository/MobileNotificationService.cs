using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Transactions;

namespace MOEN_ERP.API.Services.Repository
{
    public  class LoginToken
    {
        public string accessToken
        {
            get;
            set;
        }
    }

    public interface IMobileNotificationService
    {
    }

    public class MobileNotificationService : IMobileNotificationService
    {
        MOENDBContext context;
        public MobileNotificationService(MOENDBContext _context)
        {
            context = _context;
        }

    }
}
