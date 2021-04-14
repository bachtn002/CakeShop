using CakeShop.Service.ApiResult;
using CakeShop.Service.Users.Model;
using CakeShop.Service.Users.Service;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CakeShop.Admin.IntegrateBackendAPI
{
    public class ManageUsersApi : IManageUsersApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ManageUsersApi(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> Create(RegisterModel request)
        {
            var client = _httpClientFactory.CreateClient();
            var json = JsonConvert.SerializeObject(request);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            client.BaseAddress = new Uri("https://localhost:5001");
            var response = await client.PostAsync("/api/users/register", httpContext);
            return response.IsSuccessStatusCode;
        }

        public async Task<ApiResult<bool>> DeleteUserById(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            client.BaseAddress = new Uri("https://localhost:5001");
            var result = await client.DeleteAsync($"/api/users/{id}");
            var body = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(body);
            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(body);


        }

        public async Task<PagedResultUser<ViewModelUsers>> GetAllUser()
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            client.BaseAddress = new Uri("https://localhost:5001");
            var result = await client.GetAsync("/api/users/get-all-user");
            var body = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<PagedResultUser<ViewModelUsers>>(body);
            }
            else
            {
                return null;
            }
        }
    }
}
