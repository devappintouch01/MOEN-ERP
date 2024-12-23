using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.Services
{
    public interface ITokenService
    {
        public Task<string> GetTokenAsync(string userName, string userPassword);
    }
}
