using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageEmployees.Migrations
{
    public partial class DBv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Đỗ Thị Chan Hòa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Đổ Thị Chan Hòa");
        }
    }
}
