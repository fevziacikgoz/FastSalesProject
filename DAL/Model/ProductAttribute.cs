using CORE.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class ProductAttribute : Entity<int>
    {
        public virtual CompanyAttribute CompanyAttribute { get; set; }
        public int CompanyAttributeId { get; set; }
        public virtual CompanyAttributeValue CompanyAttributeValue { get; set; }
        public int CompanyAttributeValueId { get; set; }

        [StringLength(1000)]
        public string Name { get; set; }

        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        [StringLength(1000)]
        public string Value { get; set; }
    }
}