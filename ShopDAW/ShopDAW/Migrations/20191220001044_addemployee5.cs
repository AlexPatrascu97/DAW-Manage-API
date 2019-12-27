using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopDAW.WebAPI.Migrations
{
    public partial class addemployee5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StartingDay = table.Column<DateTime>(nullable: false),
                    LastDay = table.Column<DateTime>(nullable: false),
                    Post = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Id",
                table: "Employees",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
