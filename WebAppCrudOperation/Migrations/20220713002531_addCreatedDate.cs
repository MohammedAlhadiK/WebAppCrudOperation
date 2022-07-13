using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCrudOperation.Migrations
{
    public partial class addCreatedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "HR",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "HR",
                table: "Departments",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "HR",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "HR",
                table: "Departments");
        }
    }
}
