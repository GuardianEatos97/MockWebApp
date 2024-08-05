using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockWebApp.Migrations
{
    /// <inheritdoc />
    public partial class WarmUPTweaking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarmUpID",
                table: "Workout_Excercises",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WarmUpID",
                table: "Workout_Excercises");
        }
    }
}
