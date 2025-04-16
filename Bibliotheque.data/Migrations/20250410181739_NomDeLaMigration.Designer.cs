﻿// <auto-generated />
using System;
using Bibliotheque.data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bibliotheque.data.Migrations
{
    [DbContext(typeof(BibliothequeContext))]
    [Migration("20250410181739_NomDeLaMigration")]
    partial class NomDeLaMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("Bibliotheque.Data.Entities.Livre", b =>
                {
                    b.Property<int>("IdLivre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Auteur")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NbrPage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdLivre");

                    b.ToTable("Livres");
                });

            modelBuilder.Entity("Bibliotheque.data.Entities.Emprunt", b =>
                {
                    b.Property<int>("IdLivre")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdMembre")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateEmprunt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateRetour")
                        .HasColumnType("TEXT");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdLivre", "IdMembre");

                    b.HasIndex("IdMembre");

                    b.ToTable("Emprunt");
                });

            modelBuilder.Entity("Bibliotheque.data.Entities.Membre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Membres");
                });

            modelBuilder.Entity("Bibliotheque.data.Entities.Emprunt", b =>
                {
                    b.HasOne("Bibliotheque.Data.Entities.Livre", "Livre")
                        .WithMany("Emprunts")
                        .HasForeignKey("IdLivre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bibliotheque.data.Entities.Membre", "Membre")
                        .WithMany("Emprunts")
                        .HasForeignKey("IdMembre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");

                    b.Navigation("Membre");
                });

            modelBuilder.Entity("Bibliotheque.Data.Entities.Livre", b =>
                {
                    b.Navigation("Emprunts");
                });

            modelBuilder.Entity("Bibliotheque.data.Entities.Membre", b =>
                {
                    b.Navigation("Emprunts");
                });
#pragma warning restore 612, 618
        }
    }
}
