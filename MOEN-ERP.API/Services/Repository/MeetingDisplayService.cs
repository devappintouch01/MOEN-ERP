using MOEN_ERP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IMeetingDisplayService
    {
    }

    public class MeetingDisplayService : IMeetingDisplayService
    {
        MOENDBContext context;
        public MeetingDisplayService(MOENDBContext _context)
        {
            context = _context;
        }

    }
}
