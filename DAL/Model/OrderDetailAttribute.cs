using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class OrderDetailAttribute : Entity<int>
    {
        public int OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Value { get; set; }
        [StringLength(100)]
        public string DisplayName { get; set; }
    }
}
