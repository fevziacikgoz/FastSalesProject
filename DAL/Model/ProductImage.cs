using CORE.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class ProductImage : Entity<int>
    {
        public int? CompanyId { get; set; } //2021.10.29
        public virtual Company Company { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [StringLength(350)]
        public string ImagePath { get; set; }

        public int OrderNumber { get; set; } = 1;
    }
}