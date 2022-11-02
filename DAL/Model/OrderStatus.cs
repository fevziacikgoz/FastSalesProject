using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class OrderStatus : Entity<short>
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string N11Name { get; set; }
        [StringLength(50)]
        public string HepsiburadaName { get; set; }
        [StringLength(50)]
        public string TrendyolName { get; set; }
        [StringLength(50)]
        public string GittiGidiyorName { get; set; }
        [StringLength(50)]
        public string WoocommerceName { get; set; }
        [StringLength(50)]
        public string AmazonName { get; set; }
        [StringLength(50)]
        public string AliexpressName { get; set; }
        [StringLength(50)]
        public string N11DetailName { get; set; }
        [StringLength(50)]
        public string PrestaName { get; set; }
        [StringLength(200)]
        public string CssClass { get; set; }
    }
}
