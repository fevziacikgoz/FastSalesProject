using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class ProductSku : Entity<int>
    {
        public bool? AccountTransfered { get; set; }

        //erp programına aktarıldı mı
        public DateTime? AccountTransferedDate { get; set; }

        [StringLength(150)]
        public string Barcode { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompanyGroup CompanyGroup { get; set; }
        public int? CompanyGroupId { get; set; } //2021.10.29
        public int? CompanyId { get; set; }
        public double? Desi { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsPriceChange { get; set; } = false;
        public bool IsSaleWithOutStock { get; set; } = false;
        public int? IsSaleWithOutStockQuantity { get; set; }
        public bool IsStockChange { get; set; } = false;
        public DateTime? LastPriceUpdate { get; set; }
        public DateTime? LastStockUpdate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? MaxStock { get; set; }
        public int? MinStock { get; set; }

        [StringLength(100)]
        public string Mpn { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Product Product { get; set; }
        //public virtual ICollection<ProductBundleSku> ProductBundleSkus { get; set; }
        public int? ProductId { get; set; }
        public int? ProductionYear { get; set; }
        //public virtual ICollection<ProductSkuCompatible> ProductSkuCompatibles { get; set; }
        public virtual ICollection<ProductSkuImage> ProductSkuImages { get; set; }
        public virtual ICollection<ProductSkuPrice> ProductSkuPrices { get; set; }
        //public virtual ICollection<ProductSkuSupplier> ProductSkuSuppliers { get; set; }
        public virtual ICollection<ProductSkuVariant> ProductSkuVariant { get; set; }
        public int? PurchaseSize { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal Quantity { get; set; } = 0;

        [Column(TypeName = "decimal(18,3)")]
        public decimal ReservQuantity { get; set; } = 0;

        [StringLength(50)]
        public string ShelfNumber { get; set; }

        [StringLength(150)]
        public string StockCode { get; set; }

        //public virtual ICollection<StoreProduct> StoreProducts { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public virtual User User { get; set; }
        public int? UserId { get; set; }

        [StringLength(500)]
        public string VariantPath { get; set; }

        public int? WarrantyPeriodMonth { get; set; }
    }
}