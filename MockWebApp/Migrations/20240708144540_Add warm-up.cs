using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Addwarmup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warm_Ups",
                columns: table => new
                {
                    WarmUpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarmUpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarmUpDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyPartID = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warm_Ups", x => x.WarmUpID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warm_Ups");
        }
    }
}
