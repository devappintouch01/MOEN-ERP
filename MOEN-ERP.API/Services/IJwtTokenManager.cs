namespace MOEN_ERP.API.Services
{
    public interface IJwtTokenManager
    {

        string Authenticate(string userName, string passWord);

    }
}
