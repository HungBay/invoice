using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirstInvoice.Migrations
{
    public partial class invoiceDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID_KHACHHANG = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TEN_KHACH_HANG = table.Column<string>(maxLength: 30, nullable: false),
                    DIA_CHI_KHACH_HANG = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID_KHACHHANG);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID_SP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MOTA_SP = table.Column<string>(nullable: false),
                    GIA = table.Column<double>(nullable: false),
                    SOLUONG = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID_SP);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    ID_HOADON = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_KHACHHANG = table.Column<int>(nullable: false),
                    NGAYBAN = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.ID_HOADON);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_ID_KHACHHANG",
                        column: x => x.ID_KHACHHANG,
                        principalTable: "Customers",
                        principalColumn: "ID_KHACHHANG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice_details",
                columns: table => new
                {
                    ID_CTHD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_HOADON = table.Column<int>(nullable: false),
                    ID_SP = table.Column<int>(nullable: false),
                    SOLUONG = table.Column<int>(nullable: false),
                    THANHTIEN = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_details", x => x.ID_CTHD);
                    table.ForeignKey(
                        name: "FK_Invoice_details_Invoices_ID_HOADON",
                        column: x => x.ID_HOADON,
                        principalTable: "Invoices",
                        principalColumn: "ID_HOADON",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_details_Products_ID_SP",
                        column: x => x.ID_SP,
                        principalTable: "Products",
                        principalColumn: "ID_SP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_details_ID_HOADON",
                table: "Invoice_details",
                column: "ID_HOADON");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_details_ID_SP",
                table: "Invoice_details",
                column: "ID_SP");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ID_KHACHHANG",
                table: "Invoices",
                column: "ID_KHACHHANG");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice_details");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
