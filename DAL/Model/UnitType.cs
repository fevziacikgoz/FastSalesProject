using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class UnitType : Entity<short>
    {
        [StringLength(250)]
        public string Unit { get; set; }

        [StringLength(3)]
        public string UnitCode { get; set; }
    }
}
