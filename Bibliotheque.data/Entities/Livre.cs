using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bibliotheque.data.Entities;

namespace Bibliotheque.Data.Entities
{
    public class Livre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLivre { get; set; }

        private string _titre;

        [Required]
        public string Titre
        {
            get => _titre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Veuillez saisir un titre valide");
                _titre = value;
            }
        }

        private string _auteur;

        [Required]
        public string Auteur
        {
            get => _auteur;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Veuillez saisir un auteur valide");
                _auteur = value;
            }
        }

        private int _nbrPage;

        [Range(50, int.MaxValue, ErrorMessage = "Veuillez saisir un nombre de pages supérieur ou égal à 50")]
        public int NbrPage
        {
            get => _nbrPage;
            set
            {
                if (value < 50)
                    throw new ArgumentException("Veuillez saisir un nombre de pages supérieur ou égal à 50 !");
                _nbrPage = value;
            }
        }

        public string Description { get; set; }
        public string Image { get; set; }
        public string Etat { get; set; }

        // Navigation vers les emprunts
        public ICollection<Emprunt> Emprunts { get; set; } = new List<Emprunt>();
    }
}
