using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotheque.data.Migrations
{
    /// <inheritdoc />
    public partial class NomDeLaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Livres");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Livres",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
