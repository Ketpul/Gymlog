using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addCardId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bfebc08-2e39-48e1-8301-a540189be1b7", "AQAAAAIAAYagAAAAEML3KeE9mj1b058OS9DC9Qr2zEEY1nkTPawukeX6T/fQ9L37XKM8aJm2S9oPLYCAog==", "8ee92d53-f114-4a8e-b522-b2f8167d0e0a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b6e70db-4e42-4862-aa56-fdb291cf0625", "AQAAAAIAAYagAAAAENhgXv2ww0CO2U9NM89gSJaG1/y4hm5or85G2RI9Si+LEkGPOMHxhl/jgJbe7gaBHA==", "7fdc0cc4-1c21-4be8-863f-1d68bc278419" });
        }
    }
}
