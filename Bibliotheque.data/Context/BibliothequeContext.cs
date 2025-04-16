using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.data.Entities;
using Bibliotheque.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheque.data.Context
{
    public class BibliothequeContext: DbContext
    {

        //constructeur utilisé par EF Core Tools
        public BibliothequeContext() 
        { 
        }

        //Constructeur avec DbContextOptions utilisé par l'application
        public BibliothequeContext(DbContextOptions<BibliothequeContext> options) : base(options) 
        {
        }

        public DbSet<Livre> Livres { get; set; }
        public DbSet<Membre> Membres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
                //configuration par défaut pour les outils EF core
                options.UseSqlite("Data Source=bibliotheque.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Emprunt>()
                .HasKey(e => new { e.IdLivre, e.IdMembre }); // Clé composite

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Livre)
                .WithMany(l => l.Emprunts)
                .HasForeignKey(e => e.IdLivre);

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Membre)
                .WithMany(m => m.Emprunts)
                .HasForeignKey(e => e.IdMembre);
        }






    }
}
