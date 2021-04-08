using CakeShop.Data.Enums;
using System.Collections.Generic;

namespace CakeShop.Data.Entities
{
    public class Category
    {

        private int id;
        private int sortOrder;
        private bool isShowOnHome;
        private int? parentId;
        private Status status;
        private List<CategoryTranslation> categoryTranslations;
        private List<ProductWithCategory> productWithCategories;

        public int Id { get => id; set => id = value; }
        public int SortOrder { get => sortOrder; set => sortOrder = value; }
        public bool IsShowOnHome { get => isShowOnHome; set => isShowOnHome = value; }
        public int? ParentId { get => parentId; set => parentId = value; }
        public Status Status { get => status; set => status = value; }
        public List<CategoryTranslation> CategoryTranslations { get => categoryTranslations; set => categoryTranslations = value; }
        public List<ProductWithCategory> ProductWithCategories { get => productWithCategories; set => productWithCategories = value; }
    }
}
