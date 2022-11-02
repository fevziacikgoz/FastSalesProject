using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class ProductSkuPrice : Entity<int>
    {
        public int? CompanyGroupId { get; set; } //2021.10.29
        public virtual CompanyGroup CompanyGroup { get; set; }
        public short ProductSkuPriceTypeId { get; set; }
        public virtual ProductSkuPriceType ProductSkuPriceType { get; set; }
        public double? Price { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public int ProductSkuId { get; set; }
        public virtual ProductSku ProductSku { get; set; }

        public short MarketPlaceId { get; set; } = 1;
        //  public virtual MarketPlace MarketPlace { get; set; }

    }
}
