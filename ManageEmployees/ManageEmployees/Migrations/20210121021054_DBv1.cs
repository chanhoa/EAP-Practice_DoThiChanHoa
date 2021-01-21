using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageEmployees.Migrations
{
    public partial class DBv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Department", "Image", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Phòng Kế toán", "Do-thi-chan-hoa.jpg", "Đỗ Thị Chan Hòa", "012369856" },
                    { 2, "Phòng bảo vệ", "Tuan.jpg", "Phạm Tuân", "012369856" },
                    { 3, "Phòng bảo vệ", "Vu-quang-huy.jpg", "Vũ Quang Huy", "012369856" },
                    { 4, "Phòng công nghệ thông tin", "Hieu-icetea.jpg", "Nguyễn Đình Hiếu", "012369856" },
                    { 5, "Phòng quản lý", "truong-thanh-tu.jpg", "Trương Thanh Tú", "012369856" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
