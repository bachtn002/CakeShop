using CakeShop.Service.ApiResult;
using CakeShop.Service.Products.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Admin.IntegrateBackendAPI
{
    public interface IProductApi
    {
        Task<PagedResult<ModelViewProduct>> GetAllProduct();
    }
}
