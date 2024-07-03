using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockWebApp.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BodyParts",
                newName: "BodyPartName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "BodyParts",
                newName: "BodyPartDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BodyParts",
                newName: "BodyPartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BodyPartName",
                table: "BodyParts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BodyPartDescription",
                table: "BodyParts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "BodyPartId",
                table: "BodyParts",
                newName: "Id");
        }
    }
}
