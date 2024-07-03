using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_workouts",
                table: "workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_workOut_Excercises",
                table: "workOut_Excercises");

            migrationBuilder.RenameTable(
                name: "workouts",
                newName: "Workouts");

            migrationBuilder.RenameTable(
                name: "workOut_Excercises",
                newName: "Workout_Excercises");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workout_Excercises",
                table: "Workout_Excercises",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workout_Excercises",
                table: "Workout_Excercises");

            migrationBuilder.RenameTable(
                name: "Workouts",
                newName: "workouts");

            migrationBuilder.RenameTable(
                name: "Workout_Excercises",
                newName: "workOut_Excercises");

            migrationBuilder.AddPrimaryKey(
                name: "PK_workouts",
                table: "workouts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_workOut_Excercises",
                table: "workOut_Excercises",
                column: "Id");
        }
    }
}
