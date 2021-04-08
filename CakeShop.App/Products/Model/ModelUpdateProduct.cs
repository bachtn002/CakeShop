namespace CakeShop.Service.Products.Model
{
    public class ModelUpdateProduct
    {
        private int id;
        private string nameProduct;
        private string description;
        private string seoDescription;
        private string seoTitle;
        private string seoAlias;
        private string languageId;

        private string imageProduct;
        private decimal productPrice;
        private int stockProduct;

        public int Id { get => id; set => id = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string Description { get => description; set => description = value; }
        public string SeoDescription { get => seoDescription; set => seoDescription = value; }
        public string SeoTitle { get => seoTitle; set => seoTitle = value; }
        public string SeoAlias { get => seoAlias; set => seoAlias = value; }
        public string ImageProduct { get => imageProduct; set => imageProduct = value; }
        public decimal ProductPrice { get => productPrice; set => productPrice = value; }
        public int StockProduct { get => stockProduct; set => stockProduct = value; }
        public string LanguageId { get => languageId; set => languageId = value; }
    }
}
