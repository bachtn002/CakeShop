using CakeShop.Service.Products.Model;
using CakeShop.Service.Products.Service;
using CakeShop.Service.Users.Model;
using CakeShop.Service.Users.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Admin.IntegrateBackendAPI
{
    public interface IManageProductApi
    {
        public Task<PagedResultProduct<ModelViewProduct>> GetAllProduct();
    }
}
