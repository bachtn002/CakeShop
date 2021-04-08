namespace CakeShop.Data.Entities
{
    public class ProductWithCategory
    {
        private int productId;
        private Product product;
        private int categoryId;
        private Category category;

        public int ProductId { get => productId; set => productId = value; }

        public int CategoryId { get => categoryId; set => categoryId = value; }

        public Product Product { get => product; set => product = value; }
        public Category Category { get => category; set => category = value; }
    }
}
