using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackLotus.Migrations
{
    public partial class ten3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stockName",
                table: "stock",
                newName: "flowerName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "flowerName",
                table: "stock",
                newName: "stockName");
        }
    }
}
