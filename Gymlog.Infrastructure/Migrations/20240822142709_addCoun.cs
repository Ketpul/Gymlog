using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addCoun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Daily",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Мonth",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f1fd502-f426-420d-b6d2-b024e9f110ef", "AQAAAAIAAYagAAAAEJHnt0U+InDOpdP4CK0L2nHGrhWrBdP9vRflqCapnEzfaZ1xGtqd6vq/8C+UnTVrBQ==", "1b35ee64-9a07-471b-bad6-cae54d7671cc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Daily",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Мonth",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27c0e821-ffd5-47c6-8c05-3b832de1933d", "AQAAAAIAAYagAAAAEP0jevlReOIK58TmOabS3RFUztB3JCgAUAHh1mP2s4hGAHF5OSPIrkK6pLl1Bv742Q==", "250c5248-63c7-4ff4-820b-e5329f2ff5df" });
        }
    }
}
