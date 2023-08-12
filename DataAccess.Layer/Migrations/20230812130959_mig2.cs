using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Layer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FakülteName",
                table: "Fakülteler",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BölümName",
                table: "Bölümler",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Fakülteler",
                newName: "FakülteName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Bölümler",
                newName: "BölümName");
        }
    }
}
