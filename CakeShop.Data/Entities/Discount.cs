using CakeShop.Data.Enums;
using System;

namespace CakeShop.Data.Entities
{
    public class Discount
    {

        private int id;
        private DateTime fromDate;
        private DateTime toDate;
        private bool applyForAll;
        private int? discountPercent;
        private decimal? discountAmount;
        private string productIds;
        private string productCategoryIds;
        private Status status;
        private string nameDiscount;

        public int Id { get => id; set => id = value; }
        public DateTime FromDate { get => fromDate; set => fromDate = value; }
        public DateTime ToDate { get => toDate; set => toDate = value; }
        public bool ApplyForAll { get => applyForAll; set => applyForAll = value; }
        public int? DiscountPercent { get => discountPercent; set => discountPercent = value; }
        public decimal? DiscountAmount { get => discountAmount; set => discountAmount = value; }
        public string ProductIds { get => productIds; set => productIds = value; }
        public string ProductCategoryIds { get => productCategoryIds; set => productCategoryIds = value; }
        public Status Status { get => status; set => status = value; }
        public string NameDiscount { get => nameDiscount; set => nameDiscount = value; }
    }
}
