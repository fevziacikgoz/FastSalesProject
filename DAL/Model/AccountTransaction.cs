using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class AccountTransaction : Entity<int>
    {
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int AccountDefinitionId { get; set; }
        public virtual AccountDefinition AccountDefinition { get; set; }
        public Int16? AccountTransactionTypeId { get; set; }
        public virtual AccountTransactionType AccountTransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public double? DeptAmount { get; set; }
        public double? CreditorAmount { get; set; }
        public Int16? CurrencyTypeId { get; set; }
        public virtual Currency CurrencyType { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(50)]
        public string DocumentNumber { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int? TransferAccountId { get; set; }
        public int? CustomerTransactionId { get; set; }
        public int? ReceiveId { get; set; }
        public int? TransferId { get; set; }
        public int? OutGoingId{ get; set; }
        public int? CustomerTransferId { get; set; }
        public int? PersonelId { get; set; }
        public int? PersonelTransactionId { get; set; }
        public int? ChequeId { get; set; }
        public int? BondId { get; set; }
        public int? PaymentId { get; set; }
        public int? OutgoingsEntryId { get; set; }
        public int? OutgoingsCategoryId { get; set; }
        public int? PaymentInstallmentId { get; set; }

    }
}
