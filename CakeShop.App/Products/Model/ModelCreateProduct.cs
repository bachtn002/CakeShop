using System;

namespace CakeShop.Service.Products.Model
{
    public class ModelCreateProduct
    {
        private decimal productPrice;
        private decimal originalPrice;
        private int stockProduct;
        private string brandProduct;
        private decimal weightProduct;
        private string codeProduct;
        private DateTime dateCreate;
        private string imageProduct;

        private string nameProduct;
        private string description;
        private string seoDescription;
        private string seoTitle;
        private string seoAlias;
        private string languageId;

        public decimal ProductPrice { get => productPrice; set => productPrice = value; }
        public decimal OriginalPrice { get => originalPrice; set => originalPrice = value; }
        public int StockProduct { get => stockProduct; set => stockProduct = value; }
        public string BrandProduct { get => brandProduct; set => brandProduct = value; }
        public decimal WeightProduct { get => weightProduct; set => weightProduct = value; }
        public string CodeProduct { get => codeProduct; set => codeProduct = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public string ImageProduct { get => imageProduct; set => imageProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string Description { get => description; set => description = value; }
        public string SeoDescription { get => seoDescription; set => seoDescription = value; }
        public string SeoTitle { get => seoTitle; set => seoTitle = value; }
        public string SeoAlias { get => seoAlias; set => seoAlias = value; }
        public string LanguageId { get => languageId; set => languageId = value; }
    }
}
