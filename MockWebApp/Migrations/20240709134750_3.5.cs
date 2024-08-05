using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockWebApp.Migrations
{
    /// <inheritdoc />
    public partial class _35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExcerciseORWarmup",
                table: "Excercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExcerciseORWarmup",
                table: "Excercises");
        }
    }
}
