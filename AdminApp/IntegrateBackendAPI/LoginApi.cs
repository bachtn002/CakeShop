using CakeShop.Service.ApiResult;
using CakeShop.Service.Users.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Admin.IntegrateBackendAPI
{
    public class LoginApi : ILoginApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public LoginApi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> Authen(LoginAuthenRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var client = _httpClientFactory.CreateClient();
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            client.BaseAddress = new Uri("https://localhost:5001");
            var result = await client.PostAsync("/api/users/authenticate", httpContext);
            var token = await result.Content.ReadAsStringAsync();
            return token;
        }
    }
}
