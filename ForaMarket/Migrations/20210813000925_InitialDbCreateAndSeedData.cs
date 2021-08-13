using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForaMarket.Migrations
{
    public partial class InitialDbCreateAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchandises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandises", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Merchandises",
                columns: new[] { "Id", "DateCreated", "Name", "Price" },
                values: new object[] { 1, new DateTime(2021, 8, 12, 18, 9, 25, 593, DateTimeKind.Local).AddTicks(4165), "Dead bee body", 0m });

            migrationBuilder.InsertData(
                table: "Merchandises",
                columns: new[] { "Id", "DateCreated", "Name", "Price" },
                values: new object[] { 2, new DateTime(2021, 8, 12, 18, 9, 25, 595, DateTimeKind.Local).AddTicks(4091), "A living bee body", 0m });

            migrationBuilder.InsertData(
                table: "Merchandises",
                columns: new[] { "Id", "DateCreated", "Name", "Price" },
                values: new object[] { 3, new DateTime(2021, 8, 12, 18, 9, 25, 595, DateTimeKind.Local).AddTicks(4122), "oh shit, another dead bee body", 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merchandises");
        }
    }
}
