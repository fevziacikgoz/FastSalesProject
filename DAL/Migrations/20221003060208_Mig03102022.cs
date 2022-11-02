using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Mig03102022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyGroupId",
                table: "Baskets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Baskets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CompanyGroupId",
                table: "Baskets",
                column: "CompanyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CompanyId",
                table: "Baskets",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_CompanyGroups_CompanyGroupId",
                table: "Baskets",
                column: "CompanyGroupId",
                principalTable: "CompanyGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Companys_CompanyId",
                table: "Baskets",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_CompanyGroups_CompanyGroupId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Companys_CompanyId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_CompanyGroupId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_CompanyId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "CompanyGroupId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Baskets");
        }
    }
}
