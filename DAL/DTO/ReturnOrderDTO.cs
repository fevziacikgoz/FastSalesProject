using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class ReturnOrderDTO
    {
        public double Quantity { get; set; }
        public string ReturnType { get; set; }
        public int OrderId { get; set; }
        public int ProductSkusId { get; set; }
        public int OrderDetailId { get; set; }
    }
}
