using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotheque.data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livres",
                columns: table => new
                {
                    IdLivre = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titre = table.Column<string>(type: "TEXT", nullable: false),
                    Auteur = table.Column<string>(type: "TEXT", nullable: false),
                    NbrPage = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livres", x => x.IdLivre);
                });

            migrationBuilder.CreateTable(
                name: "Membres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: false),
                    Prenom = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Statut = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emprunt",
                columns: table => new
                {
                    IdLivre = table.Column<int>(type: "INTEGER", nullable: false),
                    IdMembre = table.Column<int>(type: "INTEGER", nullable: false),
                    DateEmprunt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateRetour = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Statut = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprunt", x => new { x.IdLivre, x.IdMembre });
                    table.ForeignKey(
                        name: "FK_Emprunt_Livres_IdLivre",
                        column: x => x.IdLivre,
                        principalTable: "Livres",
                        principalColumn: "IdLivre",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprunt_Membres_IdMembre",
                        column: x => x.IdMembre,
                        principalTable: "Membres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprunt_IdMembre",
                table: "Emprunt",
                column: "IdMembre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprunt");

            migrationBuilder.DropTable(
                name: "Livres");

            migrationBuilder.DropTable(
                name: "Membres");
        }
    }
}
