using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Models
{
    internal class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentCategoryId { get; set; }

        public bool IsFeatured { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public virtual List<Advertisement> Advertisements { get; set; }

        public virtual Category ParentCategory { get; set; }

        public virtual List<Category> ChildCategories { get; set; }
    }
}
