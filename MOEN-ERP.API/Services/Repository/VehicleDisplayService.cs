using MOEN_ERP.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IVehicleDisplayService
    {
    }

    public class VehicleDisplayService : IVehicleDisplayService
    {
        MOENDBContext context;
        public VehicleDisplayService(MOENDBContext _context) {
            context = _context;
        }

    }
}
