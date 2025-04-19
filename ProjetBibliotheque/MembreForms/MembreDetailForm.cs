using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.data.Entities;

namespace ProjetBibliotheque.MembreForms
{
    public partial class MembreDetailForm : Form
    {
        public MembreDetailForm(Membre membre)
        {

            InitializeComponent();
            InitialiserFormulaire();
            membreBindingSource.DataSource = membre;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Récupérer l'objet Membre lié au formulaire
            var membre = membreBindingSource.Current as Membre;
            if (membre != null)
            {
                // Affecter la valeur du champ Etat
                membre.etat_abonn = guna2ToggleSwitchEtat.Checked ? "actif" : "inactif";
            }

            this.DialogResult = DialogResult.OK;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void InitialiserFormulaire()
        {
            // Définir la date système (aujourd'hui)
            DateTime aujourdHui = DateTime.Now;

            // Initialiser les DateTimePickers
            dateTimePickerInscrip.Value = aujourdHui;
            dateTimePickerAbonn.Value = aujourdHui;
            dateTimePickerExpir.Value = aujourdHui;

            // État par défaut : inactif (non coché)
            guna2ToggleSwitchEtat.Checked = false;

            // Désactiver l'interaction utilisateur sur le toggle
            //guna2ToggleSwitchEtat.Enabled = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MembreDetailForm_Load(object sender, EventArgs e)
        {
            InitialiserFormulaire();
        }

        private void dateTimePickerAbonn_ValueChanged(object sender, EventArgs e)
        {
            MettreAJourAbonnementEtEtat();
        }

        private void comboBoxTypeAbonn_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourAbonnementEtEtat();
        }
        private void MettreAJourAbonnementEtEtat()
        {
            DateTime dateAbonnement = dateTimePickerAbonn.Value;
            string typeAbonnement = comboBoxTypeAbonn.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(typeAbonnement))
            {
                DateTime dateExpiration = CalculerDateExpiration(dateAbonnement, typeAbonnement);
                dateTimePickerExpir.Value = dateExpiration;

                MettreAJourEtat(dateAbonnement, dateExpiration);
            }
        }

        private void MettreAJourEtat(DateTime dateAbonnement, DateTime dateExpiration)
        {
            // Si la date d'expiration est >= à la date d'abonnement, l'abonnement est actif
            if (dateExpiration >= DateTime.Now)
            {
                guna2ToggleSwitchEtat.Checked = true;
            }
            else
            {
                guna2ToggleSwitchEtat.Checked = false;
            }
        }

        private DateTime CalculerDateExpiration(DateTime dateAbonnement, string typeAbonnement)
        {
            switch (typeAbonnement?.Trim().ToLower())
            {
                case "mensuel":
                    return dateAbonnement.AddMonths(1);

                case "trimestriel":
                    return dateAbonnement.AddMonths(3);

                case "annuel":
                    return dateAbonnement.AddMonths(12);


                default:
                    // Type inconnu ou vide -> pas de changement
                    return dateAbonnement;
            }
        }






    }
}
