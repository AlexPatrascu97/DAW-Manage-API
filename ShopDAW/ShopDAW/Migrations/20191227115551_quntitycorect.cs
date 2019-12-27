using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopDAW.WebAPI.Migrations
{
    public partial class quntitycorect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qunatity",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Qunatity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
