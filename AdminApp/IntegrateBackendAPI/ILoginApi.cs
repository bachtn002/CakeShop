using CakeShop.Service.Users.Model;
using System.Threading.Tasks;

namespace Admin.IntegrateBackendAPI
{
    public interface ILoginApi
    {
        Task<string> Authen(LoginAuthenticateRequest request);
    }
}
