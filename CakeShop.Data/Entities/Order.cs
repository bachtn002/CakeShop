using CakeShop.Data.Enums;
using System;
using System.Collections.Generic;

namespace CakeShop.Data.Entities
{
    public class Order
    {

        private int id;
        private DateTime orderDate;
        private Guid userId;
        private string shipName;
        private string shipAddress;
        private string shipEmail;
        private string shipPhoneNumber;
        private OrderStatus status;
        private List<OrderDetail> orderDetails;
        private User user;

        public int Id { get => id; set => id = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public Guid UserId { get => userId; set => userId = value; }
        public string ShipName { get => shipName; set => shipName = value; }
        public string ShipAddress { get => shipAddress; set => shipAddress = value; }
        public string ShipEmail { get => shipEmail; set => shipEmail = value; }
        public string ShipPhoneNumber { get => shipPhoneNumber; set => shipPhoneNumber = value; }
        public OrderStatus Status { get => status; set => status = value; }
        public User User { get => user; set => user = value; }
        internal List<OrderDetail> OrderDetails { get => orderDetails; set => orderDetails = value; }
    }
}
