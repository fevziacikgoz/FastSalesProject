using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class ProductSkuImage : Entity<int>
    {
        public int? ProductSkuId { get; set; }
        public virtual ProductSku ProductSku { get; set; }
        public int? ProductImageId { get; set; }
        public virtual ProductImage ProductImage { get; set; }
        public int OrderNumber { get; set; }
        [StringLength(450)]
        public string ImageUrl { get; set; }
    }
}
