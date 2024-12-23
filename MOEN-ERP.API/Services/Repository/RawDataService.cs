using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Data;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IRawDataService
    {

        #region V_SystemUserRoleAssign
        public Task<List<MOEN_ERP.DAL.Models.VSystemUserRoleAssign>> GetViewSystemUserRoleAssignListAsync(VSystemUserRoleAssign data);
        public Task<MOEN_ERP.DAL.Models.VSystemUserRoleAssign> GetViewSystemUserRoleAssignAsync(int Id);
        #endregion

        #region FN_BookingSystemMenu
        public Task<List<MOEN_ERP.DAL.Models.SystemMenu>> GetFunctionSystemMenuListAsync(MOEN_ERP.Models.ViewModel.FunctionSystemMenu data);
        #endregion

    }
    public class RawDataService : IRawDataService
    {
        MOENDBContext context;
        public RawDataService(MOENDBContext _context)
        {
            context = _context;
        }


        #region V_SystemUserRoleAssign
        public async Task<List<MOEN_ERP.DAL.Models.VSystemUserRoleAssign>> GetViewSystemUserRoleAssignListAsync(VSystemUserRoleAssign data)
        {
            try
            {
                var whr = PredicateBuilder.True<MOEN_ERP.DAL.Models.VSystemUserRoleAssign>();

                if (data.Id != null) whr = whr.And(x => x.Id == data.Id);
                if (data.RoleName != null) whr = whr.And(x => x.RoleName.Contains(data.RoleName));
                if (data.Description != null) whr = whr.And(x => x.Description.Contains(data.Description));
                if (data.SystemRoleId != null) whr = whr.And(x => x.SystemRoleId == data.SystemRoleId);
                if (data.SystemUserId != null) whr = whr.And(x => x.SystemUserId == data.SystemUserId);
                //if (data.Active != null) whr = whr.And(x => x.Active == data.Active);
                if (data.EffectiveDate != null) whr = whr.And(x => x.EffectiveDate == data.EffectiveDate);
                if (data.ExpireDate != null) whr = whr.And(x => x.ExpireDate == data.ExpireDate);
                if (data.Priority != null) whr = whr.And(x => x.Priority == data.Priority);
                //if (data.OrganizationId != null) whr = whr.And(x => x.OrganizationId == data.OrganizationId);
                if (data.SystemUserRoleId != null) whr = whr.And(x => x.SystemUserRoleId == data.SystemUserRoleId);


                return await context.VSystemUserRoleAssigns.Where(whr).OrderBy(x => x.Priority).ToListAsync();
            }
            catch (Exception ex)
            {
                var exstr = ex.Message;
                return new List<MOEN_ERP.DAL.Models.VSystemUserRoleAssign>();
            }
            
        }

        public async Task<MOEN_ERP.DAL.Models.VSystemUserRoleAssign> GetViewSystemUserRoleAssignAsync(int Id)
        {

            return await context.VSystemUserRoleAssigns.FirstOrDefaultAsync(x => x.Id == Id) ?? new MOEN_ERP.DAL.Models.VSystemUserRoleAssign();
        }
        #endregion


        #region FN_BookingSystemMenu
        public async Task<List<MOEN_ERP.DAL.Models.SystemMenu>> GetFunctionSystemMenuListAsync(MOEN_ERP.Models.ViewModel.FunctionSystemMenu data)
        {
            try
            {
                var result = new List<MOEN_ERP.DAL.Models.SystemMenu>();

                string SystemRoleId = data.SystemRoleId != null ? data.SystemRoleId.ToString() : "null";
                result = await context.Database.SqlQueryRaw<DAL.Models.SystemMenu>($"select * from dbo.FN_BookingSystemMenu({SystemRoleId}, {data.SystemMenuGroupId})").ToListAsync();
                return result;
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }
        #endregion
    }
}
