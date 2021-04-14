
using CakeShop.Service.ApiResult;
using CakeShop.Service.Users.Model;
using CakeShop.Service.Users.Service;
using System;
using System.Threading.Tasks;

namespace CakeShop.Admin.IntegrateBackendAPI
{
    public interface IManageUsersApi
    {
        public Task<PagedResultUser<ViewModelUsers>> GetAllUser();
        public Task<ApiResult<bool>> DeleteUserById(Guid id);
        public Task<bool> Create(RegisterModel request);
    }
}
