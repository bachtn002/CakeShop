using System;
using System.Collections.Generic;

namespace CakeShop.Data.Entities
{
    public class Product
    {
        private int id;
        private decimal productPrice;
        private decimal originalPrice;
        private int stockProduct;
        private string brandProduct;
        private decimal weightProduct;
        private string codeProduct;
        private DateTime dateCreate;
        private string imageProduct;
        private List<ProductTranslation> productTranslations;
        private List<ProductWithCategory> productWithCategories;
        private List<OrderDetail> orderDetails;
        private List<Cart> carts;

        public int IdProduct { get => id; set => id = value; }
        public decimal ProductPrice { get => productPrice; set => productPrice = value; }
        public decimal OriginalPrice { get => originalPrice; set => originalPrice = value; }
        public int StockProduct { get => stockProduct; set => stockProduct = value; }
        public string BrandProduct { get => brandProduct; set => brandProduct = value; }

        public string CodeProduct { get => codeProduct; set => codeProduct = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public string ImageProduct { get => imageProduct; set => imageProduct = value; }
        public List<ProductTranslation> ProductTranslations { get => productTranslations; set => productTranslations = value; }
        public List<ProductWithCategory> ProductWithCategories { get => productWithCategories; set => productWithCategories = value; }
        public List<Cart> Carts { get => carts; set => carts = value; }
        public List<OrderDetail> OrderDetails { get => orderDetails; set => orderDetails = value; }
        public decimal WeightProduct { get => weightProduct; set => weightProduct = value; }
    }
}
