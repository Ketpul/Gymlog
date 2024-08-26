using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatecode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_AspNetUsers_PhoneNumber",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_PhoneNumber",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b6e70db-4e42-4862-aa56-fdb291cf0625", "AQAAAAIAAYagAAAAENhgXv2ww0CO2U9NM89gSJaG1/y4hm5or85G2RI9Si+LEkGPOMHxhl/jgJbe7gaBHA==", "7fdc0cc4-1c21-4be8-863f-1d68bc278419" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Cards",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "929709c0-4106-4374-8623-dfd659cae6f4", "AQAAAAIAAYagAAAAEL2uUyz4FRtSWuNhTrZ1KN/3FVdDc0rwQ+BwBJt5xM9bQq+k8S7fOxTlbBFYmr4h4Q==", "fa3b1446-491a-49e4-98f4-a090c79b07c6" });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PhoneNumber",
                table: "Cards",
                column: "PhoneNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_AspNetUsers_PhoneNumber",
                table: "Cards",
                column: "PhoneNumber",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
