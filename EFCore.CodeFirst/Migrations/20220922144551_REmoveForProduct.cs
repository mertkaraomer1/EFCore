using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.CodeFirst.Migrations
{
    public partial class REmoveForProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kdv",
                schema: "products",
                table: "ProductTb");

            migrationBuilder.DropColumn(
                name: "PriceKdv",
                schema: "products",
                table: "ProductTb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kdv",
                schema: "products",
                table: "ProductTb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceKdv",
                schema: "products",
                table: "ProductTb",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
