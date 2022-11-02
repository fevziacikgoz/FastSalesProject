using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class Product : Entity<int>
    {
        public virtual Brand Brand { get; set; }
        public int? BrandId { get; set; }
        public virtual Category Category { get; set; }
        public int? CategoryId { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompanyGroup CompanyGroup { get; set; }
        public int? CompanyGroupId { get; set; } //2021.10.29
        public int? CompanyId { get; set; }
        public virtual Currency Currency { get; set; }
        public short? CurrencyId { get; set; }
        public string Description { get; set; }

        public short? GroupCode { get; set; } = 0;

        [StringLength(15)]
        public string GtipCode { get; set; }


        [StringLength(15)]

        public string GtinNo { get; set; }




        [StringLength(250)]
        public string InvoiceTitle { get; set; }

        public bool IsBundle { get; set; } = false;

        public bool IsVariant { get; set; } = false;
        // public virtual KabPackagingCode KabPackagingCode { get; set; }
        public short? KabPackagingCodeId { get; set; }
        [StringLength(150)]
        public string MainCode { get; set; }

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }

        // public virtual ICollection<ProductMeta> ProductMetas { get; set; }

        // public virtual ICollection<ProductSkuCompatible> ProductSkuCompatibles { get; set; }

        public virtual ICollection<ProductSku> ProductSkus { get; set; }

        // public virtual ICollection<ProductSkuSupplier> ProductSkuSuppliers { get; set; }

        public int? PurchaseVat { get; set; }

        public int? SalesVat { get; set; }

        [StringLength(250)]
        public string SubTitle { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public virtual UnitType UnitType { get; set; }
        public short? UnitTypeId { get; set; }
        public virtual User User { get; set; }
        public int? UserId { get; set; }
        public double? Weight { get; set; }
    }
}