using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleOfPastries.Migrations
{
    public partial class updateTypeProductDescrition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TypeProducts",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TypeProducts",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
