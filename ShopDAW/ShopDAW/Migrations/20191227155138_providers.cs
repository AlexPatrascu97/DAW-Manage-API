using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopDAW.WebAPI.Migrations
{
    public partial class providers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Payment = table.Column<int>(nullable: false),
                    PayDay = table.Column<DateTime>(nullable: false),
                    Payed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Providers_Id",
                table: "Providers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Providers");
        }
    }
}
