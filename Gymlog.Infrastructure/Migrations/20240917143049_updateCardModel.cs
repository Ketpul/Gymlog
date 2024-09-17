using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateCardModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReadingDates",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b47d1e75-d351-4b0d-8f60-a0a38d715939", "AQAAAAIAAYagAAAAEH6ybhYpeouVaV+gxHQ1qihaYD2x/7deyeVnfJCaE8Mmr42EZ9qeHJVkBpPe3ADhdA==", "4f7c5c3b-23bc-4b4d-ac63-213200bc4295" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReadingDates",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f1fd502-f426-420d-b6d2-b024e9f110ef", "AQAAAAIAAYagAAAAEJHnt0U+InDOpdP4CK0L2nHGrhWrBdP9vRflqCapnEzfaZ1xGtqd6vq/8C+UnTVrBQ==", "1b35ee64-9a07-471b-bad6-cae54d7671cc" });
        }
    }
}
