using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bibliotheque.data.Entities
{
    public class Membre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string Nom { get; set; }
        public string Prenom { get; set; }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                if (!IsValidEmail(value))
                {
                    throw new ArgumentException("L'email n'est pas valide.");
                }
                _email = value;
            }
        }

       
        public string Statut { get; set; }
        public string Image { get; set; }

        public DateTime date_inscription { get; set; }

        public DateTime date_deb_abonn { get; set; }
        public DateTime date_expir_abonn{ get; set; }
        public string etat_abonn { get; set; }
        public int duree_abonnement{ get; set; }


        // Navigation vers les emprunts
        public ICollection<Emprunt> Emprunts { get; set; } = new List<Emprunt>();



        private static bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
