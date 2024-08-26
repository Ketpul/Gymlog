using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addCardId2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardId",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d849a20-a875-4884-a5c8-b709d136da9e", "AQAAAAIAAYagAAAAELCdxssGouXoFDcL+rLlvtXVlFA54GnZp3pTCsAbJpOahPNWCfN/YYVjTAuj3fdahg==", "a8c114bf-1352-43d7-ba0a-7924e184ef8e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bfebc08-2e39-48e1-8301-a540189be1b7", "AQAAAAIAAYagAAAAEML3KeE9mj1b058OS9DC9Qr2zEEY1nkTPawukeX6T/fQ9L37XKM8aJm2S9oPLYCAog==", "8ee92d53-f114-4a8e-b522-b2f8167d0e0a" });
        }
    }
}
