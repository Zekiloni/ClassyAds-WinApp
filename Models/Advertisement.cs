using ClassyAdsWinApp.Enums;
using System;


namespace ClassyAdsWinApp.Models
{
    internal class Advertisement
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }


        public bool IsNegotiable { get; set; }

        public string ProductMake { get; set; }

        public string ProductModel { get; set; }

        public AdvertisementStatus Status { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsPremium { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpiringAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual Category Category { get; set; }
    }
}
