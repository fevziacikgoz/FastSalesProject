using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class DFMg6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReturnOrderDetailId",
                table: "OrderDetailAttributes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReturnOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceId = table.Column<short>(type: "smallint", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnOrderNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderStatusId = table.Column<short>(type: "smallint", nullable: false),
                    OrderMarketPlaceStatusId = table.Column<short>(type: "smallint", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceBarcodeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SalesSlipStatus = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceStatus = table.Column<bool>(type: "bit", nullable: false),
                    GiftCardStatus = table.Column<bool>(type: "bit", nullable: false),
                    CargoBarcodeStatus = table.Column<bool>(type: "bit", nullable: false),
                    MarketPlaceOrderId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketPlaceStoreId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EInvoiceId = table.Column<int>(type: "int", nullable: true),
                    EArchiveId = table.Column<int>(type: "int", nullable: true),
                    EDocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EArchiveCancelled = table.Column<bool>(type: "bit", nullable: false),
                    AccountingTransfer = table.Column<bool>(type: "bit", nullable: false),
                    IsSentMail = table.Column<bool>(type: "bit", nullable: true),
                    IsWrittenInvoice = table.Column<bool>(type: "bit", nullable: true),
                    IsInvoicedFromPortal = table.Column<bool>(type: "bit", nullable: true),
                    Ettn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoicedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCargoOrderCreated = table.Column<bool>(type: "bit", nullable: true),
                    IsCargoOrderCancelled = table.Column<bool>(type: "bit", nullable: true),
                    IsCargoReturnOrderCreated = table.Column<bool>(type: "bit", nullable: true),
                    CargoOrderNumber = table.Column<int>(type: "int", nullable: true),
                    CargoApproval = table.Column<bool>(type: "bit", nullable: true),
                    CargoResultKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsInvoiceSuccessfull = table.Column<bool>(type: "bit", nullable: true),
                    AccountOrderMatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnOrder_CompanyGroups_CompanyGroupId",
                        column: x => x.CompanyGroupId,
                        principalTable: "CompanyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrder_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrder_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrder_OrderStatuss_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ReturnOrderId = table.Column<int>(type: "int", nullable: true),
                    OrderDetailDeliveryInfoId = table.Column<int>(type: "int", nullable: true),
                    CargoCompanyId = table.Column<short>(type: "smallint", nullable: true),
                    CargoTrackingNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CargoTrackingUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CargoPaymentInfo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoBarcodeImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastShippingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstShippingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PackageNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DetailStatusId = table.Column<short>(type: "smallint", nullable: true),
                    DetailMarketPlaceStatusId = table.Column<short>(type: "smallint", nullable: true),
                    SalesCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductSku = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductSkusId = table.Column<int>(type: "int", nullable: true),
                    StoreProductId = table.Column<int>(type: "int", nullable: true),
                    MarketPlaceSku = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CargoPrice = table.Column<double>(type: "float", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: true),
                    UnitDiscount = table.Column<double>(type: "float", nullable: true),
                    LineTotalPrice = table.Column<double>(type: "float", nullable: true),
                    LineDiscountPrice = table.Column<double>(type: "float", nullable: true),
                    UnitNetPrice = table.Column<double>(type: "float", nullable: true),
                    LineNetPrice = table.Column<double>(type: "float", nullable: true),
                    MaturityDifference = table.Column<double>(type: "float", nullable: true),
                    SellerCouponDiscount = table.Column<double>(type: "float", nullable: true),
                    SellerDiscount = table.Column<double>(type: "float", nullable: true),
                    SellerInvoicePrice = table.Column<double>(type: "float", nullable: true),
                    Commission = table.Column<double>(type: "float", nullable: true),
                    VatRate = table.Column<int>(type: "int", nullable: true),
                    Vat = table.Column<double>(type: "float", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SapNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CommissionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoDeliveryTime = table.Column<int>(type: "int", nullable: true),
                    CargoArrivalTime = table.Column<int>(type: "int", nullable: true),
                    PaymentDueTime = table.Column<int>(type: "int", nullable: true),
                    DeliveryType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketPlaceLineId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gtip = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Desi = table.Column<double>(type: "float", nullable: true),
                    EInvoiceId = table.Column<int>(type: "int", nullable: true),
                    EArchiveId = table.Column<int>(type: "int", nullable: true),
                    RequestedDeliveryDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuantityUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsLateToCargo = table.Column<bool>(type: "bit", nullable: true),
                    CardMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTransactionCreditorId = table.Column<int>(type: "int", nullable: true),
                    CustomerTransactionDeptId = table.Column<int>(type: "int", nullable: true),
                    AccountTransactionId = table.Column<int>(type: "int", nullable: true),
                    LineType = table.Column<int>(type: "int", nullable: true),
                    AccountOrderDetailMatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetail_OrderStatuss_DetailStatusId",
                        column: x => x.DetailStatusId,
                        principalTable: "OrderStatuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetail_ProductSkus_ProductSkusId",
                        column: x => x.ProductSkusId,
                        principalTable: "ProductSkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetail_ReturnOrder_ReturnOrderId",
                        column: x => x.ReturnOrderId,
                        principalTable: "ReturnOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailAttributes_ReturnOrderDetailId",
                table: "OrderDetailAttributes",
                column: "ReturnOrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrder_CompanyGroupId",
                table: "ReturnOrder",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrder_CompanyId",
                table: "ReturnOrder",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrder_CustomerId",
                table: "ReturnOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrder_OrderStatusId",
                table: "ReturnOrder",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetail_DetailStatusId",
                table: "ReturnOrderDetail",
                column: "DetailStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetail_ProductSkusId",
                table: "ReturnOrderDetail",
                column: "ProductSkusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetail_ReturnOrderId",
                table: "ReturnOrderDetail",
                column: "ReturnOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailAttributes_ReturnOrderDetail_ReturnOrderDetailId",
                table: "OrderDetailAttributes",
                column: "ReturnOrderDetailId",
                principalTable: "ReturnOrderDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailAttributes_ReturnOrderDetail_ReturnOrderDetailId",
                table: "OrderDetailAttributes");

            migrationBuilder.DropTable(
                name: "ReturnOrderDetail");

            migrationBuilder.DropTable(
                name: "ReturnOrder");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetailAttributes_ReturnOrderDetailId",
                table: "OrderDetailAttributes");

            migrationBuilder.DropColumn(
                name: "ReturnOrderDetailId",
                table: "OrderDetailAttributes");
        }
    }
}
