using System;

namespace CakeShop.Data.Entities
{
    public class Cart
    {
        private int id;
        private int productId;
        private int quantity;
        private decimal price;
        private Guid userId;
        private Product product;
        private DateTime dateCreated;
        private User user;

        public int Id { get => id; set => id = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Price { get => price; set => price = value; }
        public Guid UserId { get => userId; set => userId = value; }
        public Product Product { get => product; set => product = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public User User { get => user; set => user = value; }
    }
}
