using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CompanyGroup : Entity<int>
    {
        [StringLength(150)]
        public string Name { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
