using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class ProductSkuVariant : Entity<int>
    {
        public int ProductSkuId { get; set; }
        public virtual ProductSku ProductSku { get; set; }
        public int CompanyAttributeId { get; set; }
        public virtual CompanyAttribute CompanyAttribute { get; set; } //hüseyin
        [StringLength(350)]
        public string Name { get; set; }
        public int CompanyAttributeValueId { get; set; }
        public virtual CompanyAttributeValue CompanyAttributeValue { get; set; } //hüseyin 
        [StringLength(350)]
        public string Value { get; set; }
        public bool IsVariant { get; set; }
    }
}
