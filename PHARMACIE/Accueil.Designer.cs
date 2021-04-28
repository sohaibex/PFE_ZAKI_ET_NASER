
namespace PHARMACIE
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentPerimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.périméToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordonnanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_identifiant = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_identifiant = new System.Windows.Forms.Label();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.bt_deconnexion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.medicamentToolStripMenuItem,
            this.fornisseurToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.factureToolStripMenuItem,
            this.medecinToolStripMenuItem,
            this.ordonnanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // medicamentToolStripMenuItem
            // 
            this.medicamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentPerimerToolStripMenuItem,
            this.cToolStripMenuItem,
            this.périméToolStripMenuItem});
            this.medicamentToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.medicamentToolStripMenuItem.Name = "medicamentToolStripMenuItem";
            this.medicamentToolStripMenuItem.Size = new System.Drawing.Size(246, 29);
            this.medicamentToolStripMenuItem.Text = "Gestion des Medicaments";
            this.medicamentToolStripMenuItem.Click += new System.EventHandler(this.medicamentToolStripMenuItem_Click);
            // 
            // medicamentPerimerToolStripMenuItem
            // 
            this.medicamentPerimerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.medicamentPerimerToolStripMenuItem.Name = "medicamentPerimerToolStripMenuItem";
            this.medicamentPerimerToolStripMenuItem.Size = new System.Drawing.Size(389, 34);
            this.medicamentPerimerToolStripMenuItem.Text = "les Medicament";
            this.medicamentPerimerToolStripMenuItem.Click += new System.EventHandler(this.medicamentPerimerToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(389, 34);
            this.cToolStripMenuItem.Text = "Les Catégories des Medicaments";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // périméToolStripMenuItem
            // 
            this.périméToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.périméToolStripMenuItem.Name = "périméToolStripMenuItem";
            this.périméToolStripMenuItem.Size = new System.Drawing.Size(389, 34);
            this.périméToolStripMenuItem.Text = "Medicament Périmé";
            this.périméToolStripMenuItem.Click += new System.EventHandler(this.périméToolStripMenuItem_Click);
            // 
            // fornisseurToolStripMenuItem
            // 
            this.fornisseurToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.fornisseurToolStripMenuItem.Name = "fornisseurToolStripMenuItem";
            this.fornisseurToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.fornisseurToolStripMenuItem.Text = "Fournisseur";
            this.fornisseurToolStripMenuItem.Click += new System.EventHandler(this.fornisseurToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.commandeToolStripMenuItem.Text = "Commande";
            this.commandeToolStripMenuItem.Click += new System.EventHandler(this.commandeToolStripMenuItem_Click);
            // 
            // factureToolStripMenuItem
            // 
            this.factureToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.factureToolStripMenuItem.Name = "factureToolStripMenuItem";
            this.factureToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.factureToolStripMenuItem.Text = "Facture";
            this.factureToolStripMenuItem.Click += new System.EventHandler(this.factureToolStripMenuItem_Click);
            // 
            // medecinToolStripMenuItem
            // 
            this.medecinToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.medecinToolStripMenuItem.Name = "medecinToolStripMenuItem";
            this.medecinToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.medecinToolStripMenuItem.Text = "Medecin";
            this.medecinToolStripMenuItem.Click += new System.EventHandler(this.medecinToolStripMenuItem_Click);
            // 
            // ordonnanceToolStripMenuItem
            // 
            this.ordonnanceToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.ordonnanceToolStripMenuItem.Name = "ordonnanceToolStripMenuItem";
            this.ordonnanceToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.ordonnanceToolStripMenuItem.Text = "Ordonnance";
            this.ordonnanceToolStripMenuItem.Click += new System.EventHandler(this.ordonnanceToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(199, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 111);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(563, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 79);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(215, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "PHARMACIE";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(23, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 79);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(290, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 59);
            this.label1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.txt_identifiant);
            this.groupBox2.Controls.Add(this.txt_prenom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lb_identifiant);
            this.groupBox2.Controls.Add(this.lb_prenom);
            this.groupBox2.Controls.Add(this.lb_nom);
            this.groupBox2.Location = new System.Drawing.Point(320, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 286);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txt_nom
            // 
            this.txt_nom.Enabled = false;
            this.txt_nom.Location = new System.Drawing.Point(163, 101);
            this.txt_nom.Multiline = true;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(218, 32);
            this.txt_nom.TabIndex = 53;
            // 
            // txt_identifiant
            // 
            this.txt_identifiant.Enabled = false;
            this.txt_identifiant.Location = new System.Drawing.Point(163, 194);
            this.txt_identifiant.Multiline = true;
            this.txt_identifiant.Name = "txt_identifiant";
            this.txt_identifiant.Size = new System.Drawing.Size(218, 32);
            this.txt_identifiant.TabIndex = 53;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Enabled = false;
            this.txt_prenom.Location = new System.Drawing.Point(163, 148);
            this.txt_prenom.Multiline = true;
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(218, 32);
            this.txt_prenom.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(71, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Utilisateur connectée";
            // 
            // lb_identifiant
            // 
            this.lb_identifiant.AutoSize = true;
            this.lb_identifiant.BackColor = System.Drawing.Color.Transparent;
            this.lb_identifiant.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_identifiant.ForeColor = System.Drawing.Color.Black;
            this.lb_identifiant.Location = new System.Drawing.Point(42, 201);
            this.lb_identifiant.Name = "lb_identifiant";
            this.lb_identifiant.Size = new System.Drawing.Size(115, 25);
            this.lb_identifiant.TabIndex = 2;
            this.lb_identifiant.Text = "Identifiant\r\n";
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.BackColor = System.Drawing.Color.Transparent;
            this.lb_prenom.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prenom.ForeColor = System.Drawing.Color.Black;
            this.lb_prenom.Location = new System.Drawing.Point(42, 155);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(84, 25);
            this.lb_prenom.TabIndex = 2;
            this.lb_prenom.Text = "Prenom";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.BackColor = System.Drawing.Color.Transparent;
            this.lb_nom.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nom.ForeColor = System.Drawing.Color.Black;
            this.lb_nom.Location = new System.Drawing.Point(43, 108);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(54, 25);
            this.lb_nom.TabIndex = 2;
            this.lb_nom.Text = "Nom";
            // 
            // bt_deconnexion
            // 
            this.bt_deconnexion.BackColor = System.Drawing.Color.White;
            this.bt_deconnexion.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_deconnexion.ForeColor = System.Drawing.Color.Red;
            this.bt_deconnexion.Location = new System.Drawing.Point(944, 669);
            this.bt_deconnexion.Name = "bt_deconnexion";
            this.bt_deconnexion.Size = new System.Drawing.Size(167, 51);
            this.bt_deconnexion.TabIndex = 88;
            this.bt_deconnexion.Text = "Deconnexion";
            this.bt_deconnexion.UseVisualStyleBackColor = false;
            this.bt_deconnexion.Click += new System.EventHandler(this.bt_deconnexion_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1123, 782);
            this.Controls.Add(this.bt_deconnexion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_identifiant;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.ToolStripMenuItem medicamentPerimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.Button bt_deconnexion;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_identifiant;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ToolStripMenuItem medecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordonnanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem périméToolStripMenuItem;
    }
}