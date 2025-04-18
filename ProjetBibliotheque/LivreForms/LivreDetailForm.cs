using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.Data.Entities;

namespace ProjetBibliotheque.LivreForms
{
    public partial class LivreDetailForm : Form
    {
        public LivreDetailForm(Livre livre)
        {
            InitializeComponent();
            livreBindingSource.DataSource = livre;
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          
        }
    }
}
