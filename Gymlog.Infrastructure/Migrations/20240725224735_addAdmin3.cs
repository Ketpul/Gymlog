using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addAdmin3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "929709c0-4106-4374-8623-dfd659cae6f4", "AQAAAAIAAYagAAAAEL2uUyz4FRtSWuNhTrZ1KN/3FVdDc0rwQ+BwBJt5xM9bQq+k8S7fOxTlbBFYmr4h4Q==", "1234567890", "fa3b1446-491a-49e4-98f4-a090c79b07c6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "179db4a2-5c44-4566-925f-6e76e730b012", "AQAAAAIAAYagAAAAEMhNmCvihlqPz7j/cPuNb3ZkajbEjIdLhvo0WPkmlASwKRRRhq7YmIbZiav6H3L7LA==", null, "2d173d19-75b7-4842-9fdc-d3c161ef792a" });
        }
    }
}
