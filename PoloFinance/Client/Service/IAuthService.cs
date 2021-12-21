using PoloFinance.Shared.Model.Account;
using PoloFinance.Shared.Model.Account.Result;

namespace PoloFinance.Client.Service
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
