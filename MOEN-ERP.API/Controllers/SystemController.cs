using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LinqKit;
using MOEN_ERP.Models.ViewModel;
using MOEN_ERP.API.Services.Repository;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        private readonly MOENDBContext _context;
        public readonly IAuthenService _auth;

        public SystemController(MOENDBContext context, IAuthenService auth)
        {
            _context = context;
            _auth = auth;
        }

        [HttpGet("GetListUser")]
        public async Task<IActionResult> GetListUser(string? Username, string? FirstName, string? LoginType, bool? Active)
        {
            var whr = PredicateBuilder.True<VSystemUser>();

            if (Username != "" && Username != null) whr = whr.And(x => x.Username.Contains(Username));
            if (FirstName != "" && FirstName != null) whr = whr.And(x => x.FirstName.Contains(FirstName) || x.LastName.Contains(FirstName));
            if (LoginType != "" && LoginType != null) whr = whr.And(x => x.LoginType == LoginType);
            if (Active != null) whr = whr.And(x => x.Active == Active);

            var res = await _context.VSystemUsers.Where(whr).ToListAsync();
            return Ok(res);
        }
        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser(int Id)
        {
            var data = new UserDetailModel();

            data.SystemUser = await _context.SystemUsers.FirstOrDefaultAsync(x => x.Id == Id) ?? new SystemUser();
            data.VSystemUserRoleAssign = await _context.VSystemUserRoleAssigns.Where(x => x.SystemUserId == Id).ToListAsync();
            return Ok(data);
        }
        [HttpGet("GetVSystemUserRoleAssign")]
        public async Task<IActionResult> GetVSystemUserRoleAssign(int Id)
        {
            var data = await _context.VSystemUserRoleAssigns.Where(x => x.SystemUserId == Id).ToListAsync();
            return Ok(data);
        }
        [HttpGet("GetUserRoleAssign")]
        public async Task<IActionResult> GetUserRoleAssign(int Id)
        {
            var data = await _context.SystemUserRoleAssigns.FirstOrDefaultAsync(x => x.Id == Id) ?? new SystemUserRoleAssign();
            return Ok(data);
        }

        [HttpPost("SaveUser")]
        public async Task<IActionResult> SaveUser(UserDetailModel model)
        {
            var result = new ApiResultsModel();
            try
            {
                var user = model.SystemUser;
                if (user.Id == 0)
                {
                    if (user.Password != null)
                    {
                        var pass = _auth.GetEncrypt(user.Password);
                    }
                    _context.SystemUsers.Add(user);
                }
                else
                {
                    var update = _context.SystemUsers.FirstOrDefault(x => x.Id == user.Id) ?? new SystemUser();
                    update.Username = user.Username;
                    update.FirstName = user.FirstName;
                    update.LastName = user.LastName;
                    update.Email = user.Email;
                    update.LoginType = user.LoginType;
                    update.Active = user.Active;
                    update.UpdateOn = user.UpdateOn;
                    update.UpdateBy = user.UpdateBy;

                    if (user.Password != null)
                    {
                        var pass = _auth.GetEncrypt(user.Password);
                    }
                    _context.SystemUsers.Update(update);
                }
                _context.SaveChanges();

                result.Id = user.Id;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }
        [HttpPost("SaveUserSystemUserRoleAssign")]
        public async Task<IActionResult> SaveUserSystemUserRoleAssign(SystemUserRoleAssign model)
        {
            var result = new ApiResultsModel();
            try
            {
                if (model.Id == 0)
                {
                    _context.SystemUserRoleAssigns.Add(model);
                }
                else
                {
                    var update = _context.SystemUserRoleAssigns.FirstOrDefault(x => x.Id == model.Id) ?? new SystemUserRoleAssign();

                    update.SystemMenuGroupId = model.SystemMenuGroupId;
                    update.SystemRoleId = model.SystemRoleId;
                    update.EffectiveDate = model.EffectiveDate;
                    update.ExpireDate = model.ExpireDate;
                    update.UpdateBy = model.UpdateBy;
                    update.UpdateOn = model.UpdateOn;
                    update.Active = model.Active;

                    _context.SystemUserRoleAssigns.Update(update);
                }
                _context.SaveChanges();

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var result = new ApiResultsModel();
            try
            {
                //รอเพิ่ม ลบ userId ใน officers

                var user = await _context.SystemUsers.FirstOrDefaultAsync(x => x.Id == userId);
                if (user == null) throw new Exception("ไม่พบผู้ใช้งานที่ต้องการลบ");
                _context.SystemUserRoleAssigns.RemoveRange(_context.SystemUserRoleAssigns.Where(x => x.SystemUserId == userId).ToList());
                _context.SystemUsers.Remove(user);
                _context.SaveChanges();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return Ok(result);
        }

        [HttpGet("DeleteUserRole")]
        public async Task<IActionResult> DeleteUserRole(int roleAssignId)
        {
            var result = new List<VSystemUserRoleAssign>();

            var roleAssing = await _context.SystemUserRoleAssigns.FirstOrDefaultAsync(x => x.Id == roleAssignId);
            var userId = roleAssing.SystemUserId;
            _context.SystemUserRoleAssigns.Remove(roleAssing);
            _context.SaveChanges();

            return Ok(await _context.VSystemUserRoleAssigns.Where(x=>x.SystemUserId == userId).ToListAsync());
        }
    }
}
