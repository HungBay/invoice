using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildMvcWebApi.Migrations
{
    public partial class addSeedTypeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("550aff08-9a87-4633-8639-f25db8b9a5e1"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("b51fb4ea-8357-46fd-9b75-d1dab0b6619e"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "Name", "UpdatedAt", "status" },
                values: new object[] { new Guid("b51fb4ea-8357-46fd-9b75-d1dab0b6619e"), new DateTime(2019, 11, 9, 17, 43, 13, 483, DateTimeKind.Local).AddTicks(9946), "Bánh ngọt là một loại thức ăn thường dưới hình thức món bánh dạng bánh mì từ bột nhào, được nướng lên dùng để tráng miệng. Bánh ngọt có nhiều loại, có thể phân loại dựa theo nguyên liệu và kỹ thuật chế biến như bánh ngọt làm từ lúa mì, bơ, bánh ngọt dạng bọt biển. Bánh ngọt có thể phục vụ những mục đính đặc biệt như bánh cưới, bánh sinh nhật, bánh Giáng sinh, bánh Halloween..", "20131108144733.jpg", "Bánh ngọt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "Name", "UpdatedAt", "status" },
                values: new object[] { new Guid("550aff08-9a87-4633-8639-f25db8b9a5e1"), new DateTime(2019, 11, 9, 17, 43, 13, 485, DateTimeKind.Local).AddTicks(6774), "Pizza đã không chỉ còn là một món ăn được ưa chuộng khắp thế giới mà còn được những nhà cầm quyền EU chứng nhận là một phần di sản văn hóa ẩm thực châu Âu. Và để được chứng nhận là một nhà sản xuất pizza không hề đơn giản. Người ta phải qua đủ mọi các bước xét duyệt của chính phủ Ý và liên minh châu Âu nữa… tất cả là để đảm bảo danh tiếng cho món ăn này.", "pizza.jpg", "Bánh Pizza", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });
        }
    }
}
