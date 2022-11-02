using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class Brand : Entity<int>
    {
        /// <summary>
        /// Companies FK
        /// </summary>
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int? CompanyGroupId { get; set; }//2021.10.29
        public virtual CompanyGroup CompanyGroup { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string FormattedName { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        [StringLength(150)]
        public string ImagePath { get; set; }
        [StringLength(150)]
        public string Url { get; set; }
        [StringLength(150)]
        public string MetaTitle { get; set; }
        [StringLength(150)]
        public string MetaKeyWords { get; set; }
        [StringLength(500)]
        public string MetaDescription { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(100)]
        public string WebId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
