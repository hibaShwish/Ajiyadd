using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ajiyad.Migrations
{
    /// <inheritdoc />
    public partial class addBulidingTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    consultant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingDetails");
        }
    }
}
