using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Currency : Entity<short>
    {
        [StringLength(50)]
        public string Name { get; set; }
        public double? Rate { get; set; }
        [StringLength(3)]
        public string Symbol { get; set; }
        [StringLength(3)]
        public string Code { get; set; }
    }
}
