using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.CodeFirst.Migrations
{
    public partial class updateOwnedType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Person_Surname",
                table: "Managers",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Person_Name",
                table: "Managers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Person_Age",
                table: "Managers",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "Person_Surname",
                table: "Employees",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Person_Name",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Person_Age",
                table: "Employees",
                newName: "Age");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Managers",
                newName: "Person_Surname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Managers",
                newName: "Person_Name");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Managers",
                newName: "Person_Age");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Employees",
                newName: "Person_Surname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "Person_Name");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Employees",
                newName: "Person_Age");
        }
    }
}
