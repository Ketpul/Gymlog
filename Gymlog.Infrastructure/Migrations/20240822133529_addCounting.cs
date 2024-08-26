using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addCounting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DailyCounting",
                table: "Cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "МonthCounting",
                table: "Cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27c0e821-ffd5-47c6-8c05-3b832de1933d", "AQAAAAIAAYagAAAAEP0jevlReOIK58TmOabS3RFUztB3JCgAUAHh1mP2s4hGAHF5OSPIrkK6pLl1Bv742Q==", "250c5248-63c7-4ff4-820b-e5329f2ff5df" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyCounting",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "МonthCounting",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d849a20-a875-4884-a5c8-b709d136da9e", "AQAAAAIAAYagAAAAELCdxssGouXoFDcL+rLlvtXVlFA54GnZp3pTCsAbJpOahPNWCfN/YYVjTAuj3fdahg==", "a8c114bf-1352-43d7-ba0a-7924e184ef8e" });
        }
    }
}
