using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http.Headers;
using System.Text;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IMeetingNotificationsService
    {
        
    }
    public class MeetingNotificationsService : IMeetingNotificationsService
    {
        MOENDBContext context;
        public MeetingNotificationsService(MOENDBContext _context)
        {
            context = _context;
        }

    }


}
