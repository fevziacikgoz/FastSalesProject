using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class User : Entity<int>
    {
        public int? CompanyGroupId { get; set; }
        public virtual CompanyGroup CompanyGroup { get; set; }
        public short UserTypeId { get; set; } = 1;

        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(150)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool IsApproved { get; set; } = false;
        [StringLength(150)]
        public string ImagePath { get; set; }

    }
}
