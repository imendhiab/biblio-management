namespace ProjetBibliotheque.LivreForms
{
    partial class GestionLivre
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAjouter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            textBoxId = new TextBox();
            pictureBox2 = new PictureBox();
            groupBoxLivre = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelAuteur = new Label();
            labelTitre = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxTitre = new TextBox();
            numericUpDownNbrPage = new NumericUpDown();
            textBoxAuteur = new TextBox();
            textBoxDescription = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            buttonRechercher = new Button();
            textBoxRecherche = new TextBox();
            groupBoxCritere = new GroupBox();
            radioButtonTitre = new RadioButton();
            radioButtonAuteur = new RadioButton();
            dataGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBoxLivre.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbrPage).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            groupBoxCritere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxLivre, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(dataGridView, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12.1008406F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1153, 641);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonAjouter);
            flowLayoutPanel1.Controls.Add(buttonModifier);
            flowLayoutPanel1.Controls.Add(buttonSupprimer);
            flowLayoutPanel1.Controls.Add(textBoxId);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12.1008406F);
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1145, 64);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAjouter.Location = new Point(4, 4);
            buttonAjouter.Margin = new Padding(4);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(145, 54);
            buttonAjouter.TabIndex = 0;
            buttonAjouter.Text = "&Ajouter";
            buttonAjouter.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModifier.Location = new Point(157, 4);
            buttonModifier.Margin = new Padding(4);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(145, 54);
            buttonModifier.TabIndex = 1;
            buttonModifier.Text = "&Modifier";
            buttonModifier.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click_1;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSupprimer.Location = new Point(310, 4);
            buttonSupprimer.Margin = new Padding(4);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(145, 54);
            buttonSupprimer.TabIndex = 2;
            buttonSupprimer.Text = "&Supprimer";
            buttonSupprimer.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(462, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(49, 34);
            textBoxId.TabIndex = 1;
            textBoxId.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(517, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // groupBoxLivre
            // 
            groupBoxLivre.Controls.Add(tableLayoutPanel2);
            groupBoxLivre.Dock = DockStyle.Fill;
            groupBoxLivre.Font = new Font("Segoe UI", 12F);
            groupBoxLivre.Location = new Point(4, 76);
            groupBoxLivre.Margin = new Padding(4);
            groupBoxLivre.Name = "groupBoxLivre";
            groupBoxLivre.Padding = new Padding(4);
            groupBoxLivre.Size = new Size(1145, 158);
            groupBoxLivre.TabIndex = 4;
            groupBoxLivre.TabStop = false;
            groupBoxLivre.Text = "Détails Livre:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 446F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelAuteur, 0, 1);
            tableLayoutPanel2.Controls.Add(labelTitre, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 2, 0);
            tableLayoutPanel2.Controls.Add(textBoxTitre, 1, 0);
            tableLayoutPanel2.Controls.Add(numericUpDownNbrPage, 1, 2);
            tableLayoutPanel2.Controls.Add(textBoxAuteur, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxDescription, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI", 12.1008406F);
            tableLayoutPanel2.Location = new Point(4, 31);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1137, 123);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelAuteur
            // 
            labelAuteur.AutoSize = true;
            labelAuteur.Dock = DockStyle.Fill;
            labelAuteur.Location = new Point(3, 45);
            labelAuteur.Name = "labelAuteur";
            labelAuteur.Size = new Size(99, 42);
            labelAuteur.TabIndex = 1;
            labelAuteur.Text = "Auteur:";
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Dock = DockStyle.Fill;
            labelTitre.Location = new Point(3, 0);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(99, 45);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Titre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 87);
            label3.Name = "label3";
            label3.Size = new Size(99, 36);
            label3.TabIndex = 2;
            label3.Text = "Nb page:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(554, 0);
            label1.Name = "label1";
            label1.Size = new Size(580, 45);
            label1.TabIndex = 3;
            label1.Text = "Description:";
            // 
            // textBoxTitre
            // 
            textBoxTitre.Dock = DockStyle.Fill;
            textBoxTitre.Location = new Point(109, 4);
            textBoxTitre.Margin = new Padding(4);
            textBoxTitre.Name = "textBoxTitre";
            textBoxTitre.Size = new Size(438, 34);
            textBoxTitre.TabIndex = 5;
            // 
            // numericUpDownNbrPage
            // 
            numericUpDownNbrPage.Location = new Point(108, 90);
            numericUpDownNbrPage.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownNbrPage.Name = "numericUpDownNbrPage";
            numericUpDownNbrPage.Size = new Size(80, 34);
            numericUpDownNbrPage.TabIndex = 4;
            // 
            // textBoxAuteur
            // 
            textBoxAuteur.Dock = DockStyle.Fill;
            textBoxAuteur.Location = new Point(109, 49);
            textBoxAuteur.Margin = new Padding(4);
            textBoxAuteur.Name = "textBoxAuteur";
            textBoxAuteur.Size = new Size(438, 34);
            textBoxAuteur.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(554, 48);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            tableLayoutPanel2.SetRowSpan(textBoxDescription, 2);
            textBoxDescription.Size = new Size(580, 72);
            textBoxDescription.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(buttonRechercher);
            flowLayoutPanel2.Controls.Add(textBoxRecherche);
            flowLayoutPanel2.Controls.Add(groupBoxCritere);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(4, 242);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1145, 60);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(198, 54);
            button1.TabIndex = 0;
            button1.Text = "&Trier par Titre";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonRechercher
            // 
            buttonRechercher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRechercher.Location = new Point(207, 3);
            buttonRechercher.Name = "buttonRechercher";
            buttonRechercher.Size = new Size(148, 50);
            buttonRechercher.TabIndex = 7;
            buttonRechercher.Text = "&Rechercher";
            buttonRechercher.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Location = new Point(361, 3);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(290, 34);
            textBoxRecherche.TabIndex = 8;
            // 
            // groupBoxCritere
            // 
            groupBoxCritere.Controls.Add(radioButtonTitre);
            groupBoxCritere.Controls.Add(radioButtonAuteur);
            groupBoxCritere.Location = new Point(657, 3);
            groupBoxCritere.Name = "groupBoxCritere";
            groupBoxCritere.Size = new Size(249, 57);
            groupBoxCritere.TabIndex = 9;
            groupBoxCritere.TabStop = false;
            // 
            // radioButtonTitre
            // 
            radioButtonTitre.AutoSize = true;
            radioButtonTitre.Checked = true;
            radioButtonTitre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonTitre.Location = new Point(18, 20);
            radioButtonTitre.Name = "radioButtonTitre";
            radioButtonTitre.Size = new Size(78, 32);
            radioButtonTitre.TabIndex = 1;
            radioButtonTitre.TabStop = true;
            radioButtonTitre.Text = "Titre";
            radioButtonTitre.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuteur
            // 
            radioButtonAuteur.AutoSize = true;
            radioButtonAuteur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonAuteur.Location = new Point(130, 18);
            radioButtonAuteur.Name = "radioButtonAuteur";
            radioButtonAuteur.Size = new Size(98, 32);
            radioButtonAuteur.TabIndex = 0;
            radioButtonAuteur.Text = "Auteur";
            radioButtonAuteur.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 310);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1145, 307);
            dataGridView.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 624);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 14);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // GestionLivre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 641);
            Controls.Add(tableLayoutPanel1);
            Name = "GestionLivre";
            Text = "Gestion des livres";
            Load += GestionLivre_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBoxLivre.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbrPage).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBoxCritere.ResumeLayout(false);
            groupBoxCritere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        private void GestionLivre_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBoxLivre;
        private FileSystemWatcher fileSystemWatcher1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelAuteur;
        private Label labelTitre;
        private Label label3;
        private Label label1;
        private NumericUpDown numericUpDownNbrPage;
        private TextBox textBoxTitre;
        private TextBox textBoxAuteur;
        private TextBox textBoxDescription;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private Button buttonRechercher;
        private TextBox textBoxRecherche;
        private GroupBox groupBoxCritere;
        private RadioButton radioButtonTitre;
        private RadioButton radioButtonAuteur;
        private TextBox textBoxId;
        private DataGridView dataGridView;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}