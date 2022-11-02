using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class CompanyAttribute : Entity<int>
    {
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string FormattedName { get; set; }
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int? CompanyGroupId { get; set; } //2021.10.29
        public virtual CompanyGroup CompanyGroup { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [StringLength(100)]
        public string WebId { get; set; }
        public bool IsVariants { get; set; }
        public virtual ICollection<CompanyAttributeValue> CompanyAttributeValues { get; set; }
    }
}
