using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model
{
    public class Customer : Entity<int>
    {
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int? StoreId { get; set; }
        // public virtual Store Store { get; set; }
        public int? CompanyGroupId { get; set; }//2021.10.29
        public virtual CompanyGroup CompanyGroup { get; set; }
        [StringLength(50)]
        public string Number { get; set; }
        public int? TypeId { get; set; } = 1;


        public short? MarketPlaceId { get; set; }
        //public virtual MarketPlace MarketPlace { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Surname { get; set; }
        [StringLength(350)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string ShortTitle { get; set; }
        public short? SectorId { get; set; }
        //public virtual Sector Sector { get; set; }

        public int? CustomerInvoiceId { get; set; }
        // public virtual CustomerInvoice CustomerInvoice { get; set; }

        public bool? IsActive { get; set; }
        [StringLength(250)]
        public string ImagePath { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

        public int? CustomerFinanceId { get; set; }
        // public virtual CustomerFinance CustomerFinance { get; set; }

        //public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        //public virtual ICollection<CustomerPhone> CustomerPhones { get; set; }
        //public virtual ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        //public virtual ICollection<Cheque> Chequeies { get; set; }
        //public virtual ICollection<CustomerMail> CustomerMails { get; set; }
        //public virtual ICollection<CustomerBank> CustomerBanks { get; set; }
        //public virtual ICollection<CustomerAuthorizedPerson> CustomerAuthorizedPersons { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        [InverseProperty("TakenCustomer")]
        //public virtual ICollection<Bond> TakenCustomerBonds { get; set; }
        //[InverseProperty("GivenCustomer")] ------hüseyin ile konuşulacak


        //public virtual ICollection<Bond> GivenCustomerBonds { get; set; }
        //[InverseProperty("TakenCustomer")]
        //public virtual ICollection<Cheque> TakenCustomerCheques { get; set; }
        //[InverseProperty("GivenCustomer")]
        //public virtual ICollection<Cheque> GivenCustomerCheques { get; set; }

        public int? CustomerPresentativeId { get; set; }
        public int? SalesPresentativeId { get; set; }
        public int? MatchCustomerId { get; set; }
        [StringLength(50)]
        public string MarketPlaceCustomerId { get; set; }

        [StringLength(50)]
        public string SubTitle { get; set; }

        public string AccountCustomerMatchId { get; set; }
    }
}
