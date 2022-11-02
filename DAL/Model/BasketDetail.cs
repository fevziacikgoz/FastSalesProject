using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BasketDetail:Entity<int>
    {
       
        public int BasketId { get; set; }
        public virtual Basket Basket { get; set; }
        public int ProductSkuId { get; set; }
        public virtual ProductSku ProductSku { get; set; }
        public string Unit { get; set; }
        public virtual UnitType UnitType { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal LineTotal { get; set; }
        public decimal Discount { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Ctimestamp { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Rtimestamp { get; set; }
        public string URL { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string StockName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Notes { get; set; }//description olarak revize olacak
    }
}
