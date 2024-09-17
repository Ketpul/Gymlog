using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCardReadingForeignKeyFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba24d403-fd95-4e39-96fa-d4796c61265b", "AQAAAAIAAYagAAAAEBhTD8Ot8ggUyXrkDIX5z7IZIXXsCAgmOxWNA5i8nOw3rULQn48IZ06CPjlT2/OJXQ==", "12886830-5178-466c-a27c-40c8a4d59afa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818612ee-1c40-45fb-823d-dcd3fefaa21e", "AQAAAAIAAYagAAAAEGbskg8bxoI+BD9KMtE23jJ3lNlg1Dw1yi1lMXOQxY+hDA8gPZ603VQYTsidfp3zsg==", "b5e432e3-480f-449a-938a-bf17b073c2ce" });
        }
    }
}
