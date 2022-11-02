using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class Basket :Entity<int>
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Explanation { get; set; }//description olarak eklendi. Fiili sistemde kaldırılacak
        public decimal InvoicTaxTotal { get; set; }
        public decimal InvoiceTotal { get; set; }
        public bool BasketStatus { get; set; }

        ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<BasketDetail> BasketDetails { get; set; }
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int? CompanyGroupId { get; set; } //2021.10.29
        public virtual CompanyGroup CompanyGroup { get; set; }
        public decimal Discount { get; set; }
        public short DiscountType { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Notes { get; set; }//description olarak revize olacak
    }
}
