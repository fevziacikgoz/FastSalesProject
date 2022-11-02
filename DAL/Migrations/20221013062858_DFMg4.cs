using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class DFMg4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTransactionType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTransactionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TurnNumber = table.Column<short>(type: "smallint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    AccountTypeId = table.Column<short>(type: "smallint", nullable: true),
                    CurrencyId = table.Column<short>(type: "smallint", nullable: true),
                    CreatedAmount = table.Column<double>(type: "float", nullable: true),
                    BranchCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AccountNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Iban = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketPlaceId = table.Column<short>(type: "smallint", nullable: true),
                    BankId = table.Column<short>(type: "smallint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountDefinition_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountDefinition_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountDefinition_Currencys_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    AccountDefinitionId = table.Column<int>(type: "int", nullable: false),
                    AccountTransactionTypeId = table.Column<short>(type: "smallint", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptAmount = table.Column<double>(type: "float", nullable: true),
                    CreditorAmount = table.Column<double>(type: "float", nullable: true),
                    CurrencyTypeId = table.Column<short>(type: "smallint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    TransferAccountId = table.Column<int>(type: "int", nullable: true),
                    CustomerTransactionId = table.Column<int>(type: "int", nullable: true),
                    ReceiveId = table.Column<int>(type: "int", nullable: true),
                    TransferId = table.Column<int>(type: "int", nullable: true),
                    OutGoingId = table.Column<int>(type: "int", nullable: true),
                    CustomerTransferId = table.Column<int>(type: "int", nullable: true),
                    PersonelId = table.Column<int>(type: "int", nullable: true),
                    PersonelTransactionId = table.Column<int>(type: "int", nullable: true),
                    ChequeId = table.Column<int>(type: "int", nullable: true),
                    BondId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    OutgoingsEntryId = table.Column<int>(type: "int", nullable: true),
                    OutgoingsCategoryId = table.Column<int>(type: "int", nullable: true),
                    PaymentInstallmentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_AccountDefinition_AccountDefinitionId",
                        column: x => x.AccountDefinitionId,
                        principalTable: "AccountDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_AccountTransactionType_AccountTransactionTypeId",
                        column: x => x.AccountTransactionTypeId,
                        principalTable: "AccountTransactionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_Currencys_CurrencyTypeId",
                        column: x => x.CurrencyTypeId,
                        principalTable: "Currencys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountDefinition_AccountTypeId",
                table: "AccountDefinition",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountDefinition_CompanyId",
                table: "AccountDefinition",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountDefinition_CurrencyId",
                table: "AccountDefinition",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_AccountDefinitionId",
                table: "AccountTransaction",
                column: "AccountDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_AccountTransactionTypeId",
                table: "AccountTransaction",
                column: "AccountTransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_CompanyId",
                table: "AccountTransaction",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_CurrencyTypeId",
                table: "AccountTransaction",
                column: "CurrencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_CustomerId",
                table: "AccountTransaction",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTransaction");

            migrationBuilder.DropTable(
                name: "AccountDefinition");

            migrationBuilder.DropTable(
                name: "AccountTransactionType");

            migrationBuilder.DropTable(
                name: "AccountType");
        }
    }
}
