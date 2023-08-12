using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Layer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fakülteler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakülteName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakülteler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bölümler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BölümName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FakülteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bölümler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bölümler_Fakülteler_FakülteId",
                        column: x => x.FakülteId,
                        principalTable: "Fakülteler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bölümler_FakülteId",
                table: "Bölümler",
                column: "FakülteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bölümler");

            migrationBuilder.DropTable(
                name: "Fakülteler");
        }
    }
}
