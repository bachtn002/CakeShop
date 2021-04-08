using CakeShop.Data.Enums;
using System;

namespace CakeShop.Data.Entities
{
    public class Transaction
    {
        private int id;
        private DateTime transactionDate;
        private string externalTransactionId;
        private decimal amount;
        private decimal fee;
        private string result;
        private string message;
        private TransactionStatus status;
        private string provider;
        private Guid userId;
        private User user;


        public int Id { get => id; set => id = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public string ExternalTransactionId { get => externalTransactionId; set => externalTransactionId = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public decimal Fee { get => fee; set => fee = value; }
        public string Result { get => result; set => result = value; }
        public string Message { get => message; set => message = value; }
        public TransactionStatus Status { get => status; set => status = value; }
        public string Provider { get => provider; set => provider = value; }
        public Guid UserId { get => userId; set => userId = value; }
        public User User { get => user; set => user = value; }
    }
}
