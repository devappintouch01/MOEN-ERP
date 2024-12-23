using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MOEN_ERP.API.Services
{
    public class JwtTokenManager : IJwtTokenManager
    {
        private readonly IConfiguration _configuration;
        public JwtTokenManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Authenticate(string userName, string passWord)
        {
            //if(!Data.Users.Any(x => x.))\

            //if (userName.Trim() == "admin" && passWord.Trim() != "test")
            //    return null;

            if(string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord))
                return null;


            var key = _configuration.GetValue<string>("JwtConfig:Key");
            var keyBytes = Encoding.ASCII.GetBytes(key);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[] {
                new Claim(ClaimTypes.NameIdentifier, userName)
                }),
                Expires = DateTime.UtcNow.AddHours(24),
                //Expires = DateTime.UtcNow.AddSeconds(30),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(keyBytes),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
