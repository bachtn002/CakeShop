namespace CakeShop.Service.Products.Model
{
    public class CategoryIdForGetAll : InforPageToGet
    {
        private int? categoryId;

        public int? CategoryId { get => categoryId; set => categoryId = value; }
    }
}
