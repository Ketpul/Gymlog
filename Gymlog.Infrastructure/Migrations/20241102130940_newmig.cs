using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db1a3c56-e2e8-45d0-a2a2-ea2526808e1d", "AQAAAAIAAYagAAAAEBBdVKH7Ao7yQHw5eJWpFsfA8wEr9PwLwfHjkhxtYgsJaJTuNe6PaUkDFtJcfhfLjw==", "1c5faaf2-caa0-42d0-9d09-deaa18aa2447" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba24d403-fd95-4e39-96fa-d4796c61265b", "AQAAAAIAAYagAAAAEBhTD8Ot8ggUyXrkDIX5z7IZIXXsCAgmOxWNA5i8nOw3rULQn48IZ06CPjlT2/OJXQ==", "12886830-5178-466c-a27c-40c8a4d59afa" });
        }
    }
}
