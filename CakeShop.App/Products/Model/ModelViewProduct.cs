using System;

namespace CakeShop.Service.Products.Model
{
    public class ModelViewProduct
    {
        private int id;
        private decimal productPrice;
        private decimal originalPrice;
        private int stockProduct;
        private string brandProduct;
        private decimal weightProduct;
        private string codeProduct;
        private string imageProduct;

        private string nameProduct;
        private string nameCategory;
        private string languageId;
        private DateTime dateCreate;

        public decimal ProductPrice { get => productPrice; set => productPrice = value; }
        public decimal OriginalPrice { get => originalPrice; set => originalPrice = value; }
        public int StockProduct { get => stockProduct; set => stockProduct = value; }
        public string BrandProduct { get => brandProduct; set => brandProduct = value; }
        public decimal WeightProduct { get => weightProduct; set => weightProduct = value; }
        public string CodeProduct { get => codeProduct; set => codeProduct = value; }
        public string ImageProduct { get => imageProduct; set => imageProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string NameCategory { get => nameCategory; set => nameCategory = value; }
        public string LanguageId { get => languageId; set => languageId = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public int Id { get => id; set => id = value; }
    }
}
