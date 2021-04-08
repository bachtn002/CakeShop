namespace CakeShop.Data.Entities
{
    public class OrderDetail
    {

        private int orderId;
        private int productId;
        private int quantity;
        private decimal price;
        private Order order;
        private Product product;

        public int OrderId { get => orderId; set => orderId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Price { get => price; set => price = value; }
        public Order Order { get => order; set => order = value; }
        public Product Product { get => product; set => product = value; }
    }
}
