using CakeShop.Service.Products.Model;
using CakeShop.Service.Products.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.MainWebApp.IntergrateAPI
{
    public interface IProduct 
    {
        public Task<PagedResultProduct<ModelViewProduct>> GetAllProduct();
    }
}
