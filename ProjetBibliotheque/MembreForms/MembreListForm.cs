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
using Bibliotheque.data.Repositories;
using Bibliotheque.Data.Entities;
using Microsoft.Extensions.DependencyInjection;
using ProjetBibliotheque.LivreForms;

namespace ProjetBibliotheque.MembreForms
{
    public partial class MembreListForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        //injection de dépendances
        public MembreListForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void MembreListForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }



        private void ReloadData()
        {
            var membreRepository = _serviceProvider.GetRequiredService<MembreRepository>();
            membreBindingSource.DataSource = membreRepository.GetAll();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {


            var membre = new Membre();
            var dialogForm = new MembreDetailForm(membre);
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var membreRepository = _serviceProvider.GetRequiredService<MembreRepository>();
                membreRepository.Add(membre);


            }
            ReloadData();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {


            var membre = this.membreBindingSource.Current as Membre;
            if (membre == null) return;

            var dialogForm = new MembreDetailForm(membre);
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var membreRepository = _serviceProvider.GetRequiredService<MembreRepository>();
                membreRepository.Update(membre);
            }
            ReloadData();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            var membre = this.membreBindingSource.Current as Membre;
            if (membre== null) return;

            var confirmation = MessageBox.Show($"Êtes vous sur de supprimer Mr/Mme \" {membre.Nom} \" \" { membre.Prenom} \" ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

            if (confirmation == DialogResult.OK)
            {
                var membreRepository = _serviceProvider.GetRequiredService<MembreRepository>();
                membreRepository.Delete(membre.Id);
            }
            ReloadData();
        }
    }
}
