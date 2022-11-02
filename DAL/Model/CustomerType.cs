using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class CustomerType : Entity<int>
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
