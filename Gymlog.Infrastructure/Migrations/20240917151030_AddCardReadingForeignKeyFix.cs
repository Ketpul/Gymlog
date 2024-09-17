using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCardReadingForeignKeyFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818612ee-1c40-45fb-823d-dcd3fefaa21e", "AQAAAAIAAYagAAAAEGbskg8bxoI+BD9KMtE23jJ3lNlg1Dw1yi1lMXOQxY+hDA8gPZ603VQYTsidfp3zsg==", "b5e432e3-480f-449a-938a-bf17b073c2ce" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49af0e0c-4590-47d6-9b60-cafbdccebebe", "AQAAAAIAAYagAAAAEFbAi2udwVWHPwwQdrzXc+0CT1+yodHNyZArDtAC2TknWvXi4olCTiKrqhTO/ZwX2w==", "0ff9d992-b13c-4568-8557-a878738833cf" });
        }
    }
}
