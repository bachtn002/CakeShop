using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CakeShop.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfB;
        private List<Cart> carts;
        private List<Order> orders;
        private List<Transaction> transactions;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfB { get => dateOfB; set => dateOfB = value; }
        public List<Cart> Carts { get => carts; set => carts = value; }
        public List<Order> Orders { get => orders; set => orders = value; }
        public List<Transaction> Transactions { get => transactions; set => transactions = value; }
    }
}
