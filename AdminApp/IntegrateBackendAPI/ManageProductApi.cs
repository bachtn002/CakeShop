using CakeShop.Service.Products.Model;
using CakeShop.Service.Products.Service;
using CakeShop.Service.Users.Model;
using CakeShop.Service.Users.Service;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CakeShop.Admin.IntegrateBackendAPI
{
    public class ManageProductApi : IManageProductApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ManageProductApi(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<PagedResultProduct<ModelViewProduct>> GetAllProduct()
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            client.BaseAddress = new Uri("https://localhost:5001");
            var result = await client.GetAsync("/api/product/get-all-product");
            var body = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<PagedResultProduct<ModelViewProduct>>(body);
            }
            else
            {
                return null;
            }
        }
    }
}
