using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopDAW.WebAPI.Migrations
{
    public partial class crossfull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropColumn(
				name: "UserId",
				table: "Carts");
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
