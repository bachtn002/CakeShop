namespace CakeShop.Data.Entities
{
    public class CategoryTranslation
    {
        private int id;
        private int categoryId;
        private string nameCategory;
        private string seoDescription;
        private string seoTitle;
        private string languageId;
        private string seoAlias;
        private Category category;
        private Language language;



        public int Id { get => id; set => id = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string NameCategory { get => nameCategory; set => nameCategory = value; }
        public string SeoDescription { get => seoDescription; set => seoDescription = value; }
        public string SeoTitle { get => seoTitle; set => seoTitle = value; }
        public string LanguageId { get => languageId; set => languageId = value; }
        public string SeoAlias { get => seoAlias; set => seoAlias = value; }
        public Category Category { get => category; set => category = value; }
        public Language Language { get => language; set => language = value; }
    }
}
