using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.data.Context;
using Bibliotheque.data.Entities;

namespace Bibliotheque.data.Repositories
{
    public class MembreRepository
    {
        private readonly BibliothequeContext _context;

        public MembreRepository(BibliothequeContext context)
        {
            _context = context;
        }

        // Méthode pour récupérer tous les membres
        public IEnumerable<Membre> GetAll()
        {
            return _context.Membres.ToList();
        }

        // Méthode pour récupérer un membre par son Id
        public Membre GetById(int id)
        {
            return _context.Membres.FirstOrDefault(m => m.Id == id);
        }

        // Méthode pour ajouter un nouveau membre
        public void Add(Membre membre)
        {
            _context.Membres.Add(membre);
            _context.SaveChanges();
        }

        // Méthode pour mettre à jour un membre existant
        public void Update(Membre membre)
        {
            _context.Membres.Update(membre);
            _context.SaveChanges();
        }

        // Méthode pour supprimer un membre par son Id
        public void Delete(int id)
        {
            var membre = _context.Membres.Find(id);
            if (membre != null)
            {
                _context.Membres.Remove(membre);
                _context.SaveChanges();
            }
        }
    }

}
