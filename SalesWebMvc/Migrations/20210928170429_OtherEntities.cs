using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaçesRecprd_Seller_SellerId",
                table: "SaçesRecprd");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaçesRecprd",
                table: "SaçesRecprd");

            migrationBuilder.RenameTable(
                name: "SaçesRecprd",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SaçesRecprd_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SaçesRecprd");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SaçesRecprd",
                newName: "IX_SaçesRecprd_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaçesRecprd",
                table: "SaçesRecprd",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaçesRecprd_Seller_SellerId",
                table: "SaçesRecprd",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
