namespace CakeShop.Service.Products.Model
{
    public class InforPageToGet
    {
        private int pageIndex; // Vi tri Page
        private int pageSize; // Kich thuoc Page

        public int PageIndex { get => pageIndex; set => pageIndex = value; }
        public int PageSize { get => pageSize; set => pageSize = value; }
    }
}
