using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class CompanyAttributeValue : Entity<int>
    {
        [StringLength(150)]
        public string Value { get; set; }
        [StringLength(150)]
        public string FormattedName { get; set; }
        public int? CompanyAttributeId { get; set; }
        public virtual CompanyAttribute CompanyAttribute { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        [StringLength(100)]
        public string WebId { get; set; }
    }
}
