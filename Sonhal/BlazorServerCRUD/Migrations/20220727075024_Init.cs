using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerCRUD.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.UrunId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "UrunId", "Fiyat", "Renk", "UrunAdi" },
                values: new object[] { 1, 156, "Neon Gri", "Msi Laptop" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "UrunId", "Fiyat", "Renk", "UrunAdi" },
                values: new object[] { 2, 1886, "Siyah", "Lenova m30" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
