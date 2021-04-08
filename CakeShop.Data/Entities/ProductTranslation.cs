namespace CakeShop.Data.Entities
{
    public class ProductTranslation
    {

        private int id;
        private int productId;
        private string nameProduct;
        private string description;
        private string seoDescription;
        private string seoTitle;
        private string seoAlias;
        private string languageId;
        private Product product;
        private Language language;


        public int Id { get => id; set => id = value; }
        public int ProductId { get => productId; set => productId = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string Description { get => description; set => description = value; }
        public string SeoDescription { get => seoDescription; set => seoDescription = value; }
        public string SeoTitle { get => seoTitle; set => seoTitle = value; }
        public string SeoAlias { get => seoAlias; set => seoAlias = value; }
        public string LanguageId { get => languageId; set => languageId = value; }
        public Product Product { get => product; set => product = value; }
        public Language Language { get => language; set => language = value; }
    }
}