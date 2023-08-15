using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepThoughtsaaS.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Thoughts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "If you go flying back through time, and you see somebody else flying forward into the future, it's probably best to avoid eye contact.");

            migrationBuilder.UpdateData(
                table: "Thoughts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "If I ever get real rich, I hope I'm not real mean to poor people, like I am now.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Thoughts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "If you go flying back through time, and you see somebody else flying forward into the future, it’s probably best to avoid eye contact.");

            migrationBuilder.UpdateData(
                table: "Thoughts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "If I ever get real rich, I hope I’m not real mean to poor people, like I am now.");
        }
    }
}
