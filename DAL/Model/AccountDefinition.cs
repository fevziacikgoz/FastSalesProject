using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model
{
    public class AccountDefinition : Entity<int>
    {
        [StringLength(200)]
        public string AccountName { get; set; }
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public Int16? AccountTypeId { get; set; }
        public virtual AccountType AccountType { get; set; }
        public Int16? CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public double? CreatedAmount { get; set; }
        [StringLength(50)]
        public string BranchCode { get; set; }
        [StringLength(50)]
        public string AccountNo { get; set; }
        [StringLength(50)]
        public string Iban { get; set; }
        public short? MarketPlaceId { get; set; }
        public short? BankId  { get; set; }
    }
}

