using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.ViewModel;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Transactions;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IDataService
    {
        #region SystemRole
        public Task<List<MOEN_ERP.DAL.Models.SystemRole>> GetSystemRoleListAsync(SystemRole data);
        public Task<MOEN_ERP.DAL.Models.SystemRole> GetSystemRoleAsync(int Id);
        public Task<List<MOEN_ERP.DAL.Models.SystemRole>> GetSystemRoleBySystemMenuGroupListAsync(int SystemMenuGroupId);
        #endregion

    }
    public class DataService : IDataService
    {
        MOENDBContext context;
        public DataService(MOENDBContext _context)
        {
            context = _context;
        }


        #region SystemRole
        public async Task<List<MOEN_ERP.DAL.Models.SystemRole>> GetSystemRoleListAsync(SystemRole data)
        {
            var whr = PredicateBuilder.True<MOEN_ERP.DAL.Models.SystemRole>();

            if (data.Id != null) whr = whr.And(x => x.Id == data.Id);
            if (data.CreateBy != null) whr = whr.And(x => x.CreateBy == data.CreateBy);
            if (data.CreateOn != null) whr = whr.And(x => x.CreateOn == data.CreateOn);
            if (data.UpdateBy != null) whr = whr.And(x => x.UpdateBy == data.UpdateBy);
            if (data.UpdateOn != null) whr = whr.And(x => x.UpdateOn == data.UpdateOn);
            if (data.RoleName != null) whr = whr.And(x => x.RoleName.Contains(data.RoleName));
            if (data.Description != null) whr = whr.And(x => x.Description.Contains(data.Description));
            //if (data.Active != null) whr = whr.And(x => x.Active == data.Active);


            return await context.SystemRoles.Where(whr).ToListAsync();
        }
        public async Task<MOEN_ERP.DAL.Models.SystemRole> GetSystemRoleAsync(int Id)
        {

            return await context.SystemRoles.FirstOrDefaultAsync(x => x.Id == Id) ?? new MOEN_ERP.DAL.Models.SystemRole();
        }

        public async Task<List<MOEN_ERP.DAL.Models.SystemRole>> GetSystemRoleBySystemMenuGroupListAsync(int SystemMenuGroupId)
        {
            var result = new List<MOEN_ERP.DAL.Models.SystemRole>();


            result = await (from m in context.SystemMenus
                            join mg in context.SystemMenuGroups
                            on m.SystemMenuGroupId equals mg.Id
                            join mr in context.SystemMenuRoleAssigns
                            on m.Id equals mr.SystemMenuId
                            join r in context.SystemRoles
                            on mr.SystemRoleId equals r.Id
                            join ur in context.SystemUserRoleAssigns
                            on r.Id equals ur.SystemRoleId
                            where m.Active == true && m.IsShowInSiteMenu == true && m.SystemMenuGroupId == SystemMenuGroupId
                            select r).Distinct().ToListAsync();

            return result;
        }
        #endregion
    }
}
