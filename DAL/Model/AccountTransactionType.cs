using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
   public  class AccountTransactionType : Entity<Int16>
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
