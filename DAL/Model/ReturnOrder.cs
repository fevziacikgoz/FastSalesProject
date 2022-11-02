using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class ReturnOrder : Entity<int>
    {
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int? CompanyGroupId { get; set; } //2021.10.29
        public virtual CompanyGroup CompanyGroup { get; set; }
        public short? MarketPlaceId { get; set; }
        //public virtual MarketPlace MarketPlace { get; set; }
        public int StoreId { get; set; }
        //public virtual Store Store { get; set; }
        public DateTime OrderDate { get; set; }
        [StringLength(50)]
        public string ReturnOrderNumber { get; set; }
        public short OrderStatusId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; } // hüseyine sorulacak
        public short? OrderMarketPlaceStatusId { get; set; }
        //public virtual OrderMarketPlaceStatus OrderMarketPlaceStatus { get; set; }
        [StringLength(50)]
        public string PaymentType { get; set; }
        [StringLength(50)]
        public string PaymentStatus { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [StringLength(50)]
        public string MarketPlaceBarcodeStatus { get; set; }
        public bool SalesSlipStatus { get; set; } = false;
        public bool InvoiceStatus { get; set; } = false;
        public bool GiftCardStatus { get; set; } = false;
        public bool CargoBarcodeStatus { get; set; } = false;
        [StringLength(50)]
        public string MarketPlaceOrderId { get; set; }
        [StringLength(50)]
        public string MarketPlaceStoreId { get; set; }
        public int? EInvoiceId { get; set; }
        public int? EArchiveId { get; set; }
        [StringLength(50)]
        public string EDocumentNumber { get; set; }
        public bool EArchiveCancelled { get; set; } = false;
        public bool AccountingTransfer { get; set; } = false;
        public bool? IsSentMail { get; set; }
        public bool? IsWrittenInvoice { get; set; }
        public bool? IsInvoicedFromPortal { get; set; }
        public string Ettn { get; set; }
        public DateTime? InvoicedDate { get; set; }
        public virtual ICollection<ReturnOrderDetail> OrderDetails { get; set; }

        public bool? IsCargoOrderCreated { get; set; }
        public bool? IsCargoOrderCancelled { get; set; }
        public bool? IsCargoReturnOrderCreated { get; set; }
        public int? CargoOrderNumber { get; set; }
        public bool? CargoApproval { get; set; }

        [StringLength(50)]
        public string CargoResultKey { get; set; }
        public bool? IsInvoiceSuccessfull { get; set; }

        public string AccountOrderMatchId { get; set; }

        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        [StringLength(250)]
        public string Description { get; set; }

    }
}
