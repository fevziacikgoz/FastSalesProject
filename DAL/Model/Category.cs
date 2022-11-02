using CORE.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class Category : Entity<int>
    {
        //public virtual ICollection<CategoryMarketPlaceCategory> CategoryMarketPlaceCategories { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? CodeLength { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompanyGroup CompanyGroup { get; set; }
        public int? CompanyGroupId { get; set; }

        //Fk Company
        public int? CompanyId { get; set; }

        [StringLength(50)]
        public string FormattedName { get; set; }

        [StringLength(500)]
        public string FullPath { get; set; }

        public bool? IsDeep { get; set; } = true;
        public bool IsFastSelling { get; set; } = false;

        [StringLength(50)]
        public string Name { get; set; }

        //2021.10.29
        public int? ParentId { get; set; } = 0;

        public int? ProductOrder { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        [StringLength(100)]
        public string WebId { get; set; }
    }
}