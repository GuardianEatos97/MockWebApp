using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Workouts",
                newName: "WorkoutName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Workouts",
                newName: "WorkoutDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Workouts",
                newName: "WorkoutId");

            migrationBuilder.RenameColumn(
                name: "Team",
                table: "Users",
                newName: "UserTeam");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Jersey",
                table: "Users",
                newName: "UserJersey");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Types",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Types",
                newName: "TypeDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Types",
                newName: "TypeID");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "ServiceProviders",
                newName: "SPType");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ServiceProviders",
                newName: "SPName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ServiceProviders",
                newName: "SPId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Excercises",
                newName: "ExcerciseName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Excercises",
                newName: "ExcerciseDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Excercises",
                newName: "ExcerciseId");

            migrationBuilder.AlterColumn<int>(
                name: "WorkOutID",
                table: "Workout_Excercises",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ExcerciseID",
                table: "Workout_Excercises",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkoutName",
                table: "Workouts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "WorkoutDescription",
                table: "Workouts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "WorkoutId",
                table: "Workouts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserTeam",
                table: "Users",
                newName: "Team");

            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UserJersey",
                table: "Users",
                newName: "Jersey");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "Types",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TypeDescription",
                table: "Types",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "TypeID",
                table: "Types",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SPType",
                table: "ServiceProviders",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "SPName",
                table: "ServiceProviders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SPId",
                table: "ServiceProviders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ExcerciseName",
                table: "Excercises",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ExcerciseDescription",
                table: "Excercises",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ExcerciseId",
                table: "Excercises",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "WorkOutID",
                table: "Workout_Excercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ExcerciseID",
                table: "Workout_Excercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
