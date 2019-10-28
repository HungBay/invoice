using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleOfPastries.Migrations
{
    public partial class addImgTypeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageTypeProduct",
                table: "TypeProducts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageTypeProduct",
                table: "TypeProducts");
        }
    }
}
