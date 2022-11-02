using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{

    public class Company : Entity<int>
    {
        //[Required(AllowEmptyStrings =false,ErrorMessage ="Lütfen şirket isim gir")]

        [StringLength(150)]
        public string Name { get; set; }
        public int? CompanyGroupId { get; set; }//2021.10.29
        public virtual CompanyGroup CompanyGroup { get; set; }
        public string LogoPath { get; set; }
        [StringLength(250)]
        public string OfficialName { get; set; }
        public short CompanyTypeId { get; set; } = 1;
        //public virtual CompanyType CompanyType { get; set; }
        public short? CompanyClassId { get; set; }
        // public virtual CompanyClass CompanyClass { get; set; }
        public int? CompanyInvoiceId { get; set; }
        //public virtual CompanyInvoice CompanyInvoice { get; set; }
        public int? CompanyFinanceId { get; set; }
        //public virtual CompanyFinance CompanyFinance { get; set; }
        public int? CompanyAccountIntegratorId { get; set; }
        //public virtual CompanyAccountIntegrator CompanyAccountIntegrator { get; set; }

        [StringLength(50)]
        public string AccountProgram { get; set; }
        //public virtual ICollection<CompanyAttribute> CompanyAttributes { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        // public virtual ICollection<Store> Stores { get; set; }
        //public virtual ICollection<CompanyAddress> CompanyAddress { get; set; }
        //public virtual ICollection<CompanyPhone> CompanyPhones { get; set; }
        // public virtual ICollection<CompanyMail> CompanyMails { get; set; }
        //public virtual ICollection<CompanyMailServer> CompanyMailServers { get; set; }
        //public virtual ICollection<CompanyWebsite> CompanyWebsites { get; set; }

        // public virtual ICollection<CompanyPromotionCode> CompanyPromotionCodes { get; set; }

    }
}
