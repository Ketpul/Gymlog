using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateCardModel4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49af0e0c-4590-47d6-9b60-cafbdccebebe", "AQAAAAIAAYagAAAAEFbAi2udwVWHPwwQdrzXc+0CT1+yodHNyZArDtAC2TknWvXi4olCTiKrqhTO/ZwX2w==", "0ff9d992-b13c-4568-8557-a878738833cf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6cb9fc4-2ad5-4482-b154-6fdb4266978a", "AQAAAAIAAYagAAAAEJCUZaKL4/UGX7xfU2kuDLnclrdB+nWm4WB6FANARi8KeWhSYweWS8K9f9MI56VFew==", "07d6899c-a718-41d1-a8a2-f6e831379f49" });
        }
    }
}
