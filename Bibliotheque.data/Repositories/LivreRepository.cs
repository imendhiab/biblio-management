using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.data.Context;
using Bibliotheque.Data.Entities;

namespace Bibliotheque.data.Repositories
{
    public class LivreRepository
    {
        private readonly BibliothequeContext _context;

        public LivreRepository(BibliothequeContext context)
        {
            _context = context;
        }

        // Méthode pour récupérer tous les livres
        public IEnumerable<Livre> GetAll()
        {
            return _context.Livres.ToList();
        }

        // Méthode pour récupérer un livre par son Id
        public Livre GetById(int id)
        {
            return _context.Livres.FirstOrDefault(l => l.IdLivre == id);
        }

        // Méthode pour ajouter un nouveau livre
        public void Add(Livre livre)
        {
            _context.Livres.Add(livre);
            _context.SaveChanges();
        }

        // Méthode pour mettre à jour un livre existant
        public void Update(Livre livre)
        {
            _context.Livres.Update(livre);
            _context.SaveChanges();
        }

        // Méthode pour supprimer un livre par son Id
        public void Delete(int id)
        {
            var livre = _context.Livres.Find(id);
            if (livre != null)
            {
                _context.Livres.Remove(livre);
                _context.SaveChanges();
            }
        }
    }

}
