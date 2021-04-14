using CakeShop.Service.Products.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Admin.Models
{
    public class ProductModel
    {
        private List<ModelViewProduct> products;

        public List<ModelViewProduct> Products { get => products; set => products = value; }
    }
}
