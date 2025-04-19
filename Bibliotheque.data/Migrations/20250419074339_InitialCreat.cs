using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotheque.data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type_abonn",
                table: "Membres",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type_abonn",
                table: "Membres");
        }
    }
}
