using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopDAW.WebAPI.Migrations
{
    public partial class cross : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Carts",
                newName: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_ProductId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Carts",
                newName: "ProductID");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
