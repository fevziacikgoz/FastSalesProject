using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class ProductSkuPriceType : Entity<short>
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
