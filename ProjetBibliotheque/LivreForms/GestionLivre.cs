using Bibliotheque.data.Repositories;
using Bibliotheque.Data.Entities;

using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetBibliotheque.LivreForms
{
    public partial class GestionLivre : Form
    {
        private readonly LivreRepository _livreRepository;

        public GestionLivre(LivreRepository livreRepository)
        {
            InitializeComponent();
            _livreRepository = livreRepository;
            ConfigurerDataGridView();
            RafraichirGrille();
        }

        private void RafraichirGrille()
        {
            var livres = _livreRepository.GetAll();
            dataGridView.Rows.Clear();
            foreach (var livre in livres)
            {
                dataGridView.Rows.Add(livre.IdLivre, livre.Titre, livre.Auteur, livre.NbrPage, livre.Description);
            }
        }

        private void ConfigurerDataGridView()
        {
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Titre", "Titre");
            dataGridView.Columns.Add("Auteur", "Auteur");
            dataGridView.Columns.Add("NbrPage", "NbrPage");
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns[0].Visible = false;
        }

        // Ajout d'un livre
        private void AjouterLivre(string titre, string auteur, int nbrPage, string description,string image,string etat)
        {
            var livre = new Livre
            {
                Titre = titre,
                Auteur = auteur,
                NbrPage = nbrPage,
                Description = description,
                Image="image",            //path recuperé lors du parcours des files
                Etat="disponible"          //etat recuperé de radiobutton.text
            };
            _livreRepository.Add(livre);
            RafraichirGrille();
        }

        // Modifier un livre
        private void ModifierLivre(int id, string titre, string auteur, int nbrPage, string description, string image, string etat)
        {
            var livre = _livreRepository.GetById(id);
            if (livre != null)
            {
                livre.Titre = titre;
                livre.Auteur = auteur;
                livre.NbrPage = nbrPage;
                livre.Description = description;
                livre.Image = "image";           //path recuperé lors du parcours des files
                livre.Etat = "disponible";       //etat recuperé de radiobutton.text

               _livreRepository.Update(livre);
                RafraichirGrille();
            }
        }

        // Supprimer un livre
        private void SupprimerLivre(int id)
        {
            _livreRepository.Delete(id);
            RafraichirGrille();
        }

        // Gestion des événements
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string titre = textBoxTitre.Text;
            string auteur = textBoxAuteur.Text;
            int nbrPage = (int)numericUpDownNbrPage.Value;
            string description = textBoxDescription.Text;
            string image = "image";
            string etat = "disponible";

            AjouterLivre(titre, auteur, nbrPage, description,image, etat);
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // Supprimer un livre basé sur l'ID sélectionné dans le DataGridView
            int selectedId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            SupprimerLivre(selectedId);
        }

        private void buttonModifier_Click_1(object sender, EventArgs e)
        {
            string titre = textBoxTitre.Text;
            string auteur = textBoxAuteur.Text;
            int nbrPage = (int)numericUpDownNbrPage.Value;
            string description = textBoxDescription.Text;
            string image="image";
            string etat = "disponible";
            // Modifier un livre en fonction des entrées dans les contrôles de l'interface
            int selectedId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            ModifierLivre(selectedId, titre, auteur, nbrPage, description,image,etat);
        }

    
    }
}
