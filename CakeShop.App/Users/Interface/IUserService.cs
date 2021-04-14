using CakeShop.Service.ApiResult;
using CakeShop.Service.Users.Model;
using CakeShop.Service.Users.Service;
using System;
using System.Threading.Tasks;


namespace CakeShop.Service.Users.Interface
{
    public interface IUserService
    {
        Task<string> LoginAuthenticate(LoginAuthenRequest request);
        Task<bool> RegisterUser(RegisterModel request);
        Task<PagedResultUser<ViewModelUsers>> GetAllUserService();

        Task<ApiResult<bool>> DeleteUser(Guid id);
    }
}
