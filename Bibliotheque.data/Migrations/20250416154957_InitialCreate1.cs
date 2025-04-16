using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotheque.data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "date_deb_abonn",
                table: "Membres",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "date_expir_abonn",
                table: "Membres",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "date_inscription",
                table: "Membres",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "duree_abonnement",
                table: "Membres",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "etat_abonn",
                table: "Membres",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Etat",
                table: "Livres",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Livres",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "Statut",
                table: "Emprunt",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date_deb_abonn",
                table: "Membres");

            migrationBuilder.DropColumn(
                name: "date_expir_abonn",
                table: "Membres");

            migrationBuilder.DropColumn(
                name: "date_inscription",
                table: "Membres");

            migrationBuilder.DropColumn(
                name: "duree_abonnement",
                table: "Membres");

            migrationBuilder.DropColumn(
                name: "etat_abonn",
                table: "Membres");

            migrationBuilder.DropColumn(
                name: "Etat",
                table: "Livres");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Livres");

            migrationBuilder.AlterColumn<string>(
                name: "Statut",
                table: "Emprunt",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");
        }
    }
}
