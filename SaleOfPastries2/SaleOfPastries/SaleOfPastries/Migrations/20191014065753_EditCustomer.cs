using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleOfPastries.Migrations
{
    public partial class EditCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "TypeProducts",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "TypeProducts");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);
        }
    }
}
