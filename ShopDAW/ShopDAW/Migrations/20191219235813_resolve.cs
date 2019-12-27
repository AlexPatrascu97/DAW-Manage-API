using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopDAW.WebAPI.Migrations
{
    public partial class resolve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_Id",
                table: "Carts",
                newName: "IX_Carts_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_Id",
                table: "Cart",
                newName: "IX_Cart_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");
        }
    }
}
