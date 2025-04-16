using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.Data.Entities;

namespace Bibliotheque.data.Entities
{
    public class Emprunt
    {
        public int IdLivre { get; set; }
        public Livre Livre { get; set; }
        public int IdMembre { get; set; }
        public Membre Membre { get; set; }
        public DateTime DateEmprunt { get; set; } = DateTime.Now;
        public DateTime? DateRetour { get; set; }
        public Boolean Statut { get; set; } //En cours ou Rendu

    }

}
