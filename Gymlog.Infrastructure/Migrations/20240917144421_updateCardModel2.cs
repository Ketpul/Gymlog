using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateCardModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReadingDates",
                table: "Cards");

            migrationBuilder.CreateTable(
                name: "ReadingDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingDates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardReadings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    ReadingDateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardReadings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardReadings_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardReadings_ReadingDates_ReadingDateId",
                        column: x => x.ReadingDateId,
                        principalTable: "ReadingDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6cb9fc4-2ad5-4482-b154-6fdb4266978a", "AQAAAAIAAYagAAAAEJCUZaKL4/UGX7xfU2kuDLnclrdB+nWm4WB6FANARi8KeWhSYweWS8K9f9MI56VFew==", "07d6899c-a718-41d1-a8a2-f6e831379f49" });

            migrationBuilder.CreateIndex(
                name: "IX_CardReadings_CardId",
                table: "CardReadings",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardReadings_ReadingDateId",
                table: "CardReadings",
                column: "ReadingDateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardReadings");

            migrationBuilder.DropTable(
                name: "ReadingDates");

            migrationBuilder.AddColumn<string>(
                name: "ReadingDates",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b47d1e75-d351-4b0d-8f60-a0a38d715939", "AQAAAAIAAYagAAAAEH6ybhYpeouVaV+gxHQ1qihaYD2x/7deyeVnfJCaE8Mmr42EZ9qeHJVkBpPe3ADhdA==", "4f7c5c3b-23bc-4b4d-ac63-213200bc4295" });
        }
    }
}
