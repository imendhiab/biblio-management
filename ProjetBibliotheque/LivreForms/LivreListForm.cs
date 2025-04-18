using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.data.Repositories;
using Bibliotheque.Data.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ProjetBibliotheque.LivreForms
{
    public partial class LivreListForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        //injection de dépendances
        public LivreListForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void LivreListForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var livre = new Livre();
            var dialogForm = new LivreDetailForm(livre);
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var livreRepository = _serviceProvider.GetRequiredService<LivreRepository>();
                livreRepository.Add(livre);


            }
            ReloadData();

        }
        private void ReloadData()
        {
            var livreRepository = _serviceProvider.GetRequiredService<LivreRepository>();
            livreBindingSource.DataSource = livreRepository.GetAll();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            var livre = this.livreBindingSource.Current as Livre;
            if (livre == null) return;


            var dialogForm = new LivreDetailForm(livre);
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var livreRepository = _serviceProvider.GetRequiredService<LivreRepository>();
                livreRepository.Update(livre);
            }
            ReloadData();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            var livre = this.livreBindingSource.Current as Livre;
            if (livre == null) return;

            var confirmation =MessageBox.Show($"Êtes vous sur de supprimer \"{ livre.Titre} \" ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

            if (confirmation == DialogResult.OK)
            {
                var livreRepository = _serviceProvider.GetRequiredService<LivreRepository>();
                livreRepository.Delete(livre.IdLivre);
            }
            ReloadData();

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
