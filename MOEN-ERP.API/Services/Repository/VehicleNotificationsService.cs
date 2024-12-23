using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using LinqKit;
using Microsoft.EntityFrameworkCore;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IVehicleNotificationsService
    {
    }
    public class VehicleNotificationsService : IVehicleNotificationsService
    {
        MOENDBContext context;
        public VehicleNotificationsService(MOENDBContext _context) {
            context = _context;
        }
       
    }

}
