using System.Collections.Generic;

namespace CakeShop.Data.Entities
{
    public class Language
    {

        private string id;
        private string nameLanguage;
        private bool isDefault;
        private List<ProductTranslation> productTranslations;
        private List<CategoryTranslation> categoryTranslations;

        public string Id { get => id; set => id = value; }
        public string NameLanguage { get => nameLanguage; set => nameLanguage = value; }
        public bool IsDefault { get => isDefault; set => isDefault = value; }
        public List<ProductTranslation> ProductTranslations { get => productTranslations; set => productTranslations = value; }
        public List<CategoryTranslation> CategoryTranslations { get => categoryTranslations; set => categoryTranslations = value; }
    }
}
