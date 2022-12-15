using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackLotus.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "orderDetails",
                table: "order",
                newName: "flowerName");

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Catagory",
                table: "flower",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "flowerPrice",
                table: "flower",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "stock",
                table: "flower",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "catagoryDiscription",
                table: "catgory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "order");

            migrationBuilder.DropColumn(
                name: "Catagory",
                table: "flower");

            migrationBuilder.DropColumn(
                name: "flowerPrice",
                table: "flower");

            migrationBuilder.DropColumn(
                name: "stock",
                table: "flower");

            migrationBuilder.DropColumn(
                name: "catagoryDiscription",
                table: "catgory");

            migrationBuilder.RenameColumn(
                name: "flowerName",
                table: "order",
                newName: "orderDetails");
        }
    }
}
