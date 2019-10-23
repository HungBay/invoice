using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleOfPastries.Migrations
{
    public partial class addImgTypeProductEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageTypeProduct",
                table: "TypeProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageTypeProduct",
                table: "TypeProducts",
                nullable: true);
        }
    }
}
