using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CORE.Entities.Concrete;

namespace DAL.Model
{
    public class ReturnOrderDetail : Entity<int>
    {
        public int? OrderId { get; set; }
        public virtual ReturnOrder ReturnOrder { get; set; }
        public int? OrderDetailDeliveryInfoId { get; set; }
        // public virtual OrderDetailDeliveryInfo OrderDetailDeliveryInfo { get; set; }
        public short? CargoCompanyId { get; set; }
        // public CargoCompany CargoCompany { get; set; }
        [StringLength(150)]
        public string CargoTrackingNumber { get; set; }
        [StringLength(250)]
        public string CargoTrackingUrl { get; set; }
        [StringLength(50)]
        public string CargoPaymentInfo { get; set; }
        [StringLength(50)]
        public string CargoBarcode { get; set; }
        [StringLength(250)]
        public string CargoBarcodeImageUrl { get; set; }
        public DateTime? LastShippingDate { get; set; }
        public DateTime? FirstShippingDate { get; set; }
        [StringLength(50)]
        public string PackageNumber { get; set; }
        public short? DetailStatusId { get; set; }
        public virtual OrderStatus DetailStatus { get; set; } // hüseyin
        public short? DetailMarketPlaceStatusId { get; set; }
        //public virtual OrderMarketPlaceStatus DetailMarketPlaceStatus { get; set; }
        [StringLength(50)]
        public string SalesCode { get; set; }
        [StringLength(50)]
        public string ProductBarcode { get; set; }
        [StringLength(100)]
        public string ProductSku { get; set; }
        public int? ProductSkusId { get; set; }
        public virtual ProductSku ProductSkus { get; set; }
        public int? StoreProductId { get; set; }
        //public StoreProduct StoreProduct { get; set; }
        [StringLength(50)]
        public string MarketPlaceSku { get; set; }
        [StringLength(200)]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string ProductSize { get; set; }
        [StringLength(50)]
        public string ProductColor { get; set; }
        public int Quantity { get; set; }
        public double? CargoPrice { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitDiscount { get; set; }
        public double? LineTotalPrice { get; set; }
        public double? LineDiscountPrice { get; set; }
        public double? UnitNetPrice { get; set; }
        public double? LineNetPrice { get; set; }
        public double? MaturityDifference { get; set; }
        public double? SellerCouponDiscount { get; set; }
        public double? SellerDiscount { get; set; }
        public double? SellerInvoicePrice { get; set; }
        public double? Commission { get; set; } = 0;
        public int? VatRate { get; set; } = 18;
        public double? Vat { get; set; }
        [StringLength(50)]
        public string Currency { get; set; }
        [StringLength(50)]
        public string SapNumber { get; set; }
        [StringLength(50)]
        public string Version { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        [StringLength(50)]
        public string CommissionType { get; set; }
        public int? CargoDeliveryTime { get; set; }
        public int? CargoArrivalTime { get; set; }
        public int? PaymentDueTime { get; set; }
        [StringLength(50)]
        public string DeliveryType { get; set; }
        [StringLength(50)]
        public string MarketPlaceLineId { get; set; }
        [StringLength(50)]
        public string Gtip { get; set; }
        public double? Desi { get; set; }
        public int? EInvoiceId { get; set; }
        public int? EArchiveId { get; set; }
        [StringLength(50)]
        public string RequestedDeliveryDate { get; set; }
        [StringLength(50)]
        public string QuantityUnit { get; set; }
        public bool? IsLateToCargo { get; set; } = false;
        public string CardMessage { get; set; }
        public int? CustomerTransactionCreditorId { get; set; }
        public int? CustomerTransactionDeptId { get; set; }
        public int? AccountTransactionId { get; set; }
        //public int? OrderDetailSurtaxId { get; set; }

        /*
         LineType Sipariş detay satırının ürün mü yada kargo ücreti,kurulum ücreti gibi bir satırmı olduğunu belirmek için kullanılan bir alan,
         LineType = 0 ise bu bir ürün satırıdır,
         LineType = 1 ise bu bir servis ücretidir,
         LineType = 2 ise Kargo ücreti satırıdır.
         LineType = 3 ise Gsm Sipariş Kalemi
         LineType = 4 ise Gezi ücreti

         N11 orderDetail de gelen bir değer diğer pazaryerlerinde mevcut değil.
         
         */
        public int? LineType { get; set; } = 0;
        [StringLength(150)]
        [NotMapped]
        public string MarketPlaceVariantSku { get; set; }
        public virtual ICollection<OrderDetailAttribute> OrderDetailAttributes { get; set; }// hüseyine


        public string AccountOrderDetailMatchId { get; set; }

        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        [StringLength(250)]
        public string Description { get; set; }

    }
}
