
namespace PHARMACIE
{
    partial class Commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commande));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qte_commande = new System.Windows.Forms.TextBox();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.lb_qte_commande = new System.Windows.Forms.Label();
            this.lb_prix = new System.Windows.Forms.Label();
            this.lb_medicament = new System.Windows.Forms.Label();
            this.cmb_medicament = new System.Windows.Forms.ComboBox();
            this.txt_num_facture = new System.Windows.Forms.TextBox();
            this.lb_num_facture = new System.Windows.Forms.Label();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.dgv_cmd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.txt_rech_num_facture = new System.Windows.Forms.TextBox();
            this.lb_rech_num_facture = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_vider = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_validation_cmd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(208, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 111);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(560, 25);
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
            this.label3.Location = new System.Drawing.Point(214, 21);
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
            this.pictureBox4.Location = new System.Drawing.Point(34, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 79);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(394, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestion des Commandes";
            // 
            // txt_qte_commande
            // 
            this.txt_qte_commande.Location = new System.Drawing.Point(579, 77);
            this.txt_qte_commande.Name = "txt_qte_commande";
            this.txt_qte_commande.Size = new System.Drawing.Size(198, 27);
            this.txt_qte_commande.TabIndex = 26;
            // 
            // txt_prix
            // 
            this.txt_prix.Enabled = false;
            this.txt_prix.Location = new System.Drawing.Point(114, 80);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(198, 27);
            this.txt_prix.TabIndex = 27;
            // 
            // lb_qte_commande
            // 
            this.lb_qte_commande.AutoSize = true;
            this.lb_qte_commande.BackColor = System.Drawing.Color.Transparent;
            this.lb_qte_commande.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qte_commande.ForeColor = System.Drawing.Color.Black;
            this.lb_qte_commande.Location = new System.Drawing.Point(359, 80);
            this.lb_qte_commande.Name = "lb_qte_commande";
            this.lb_qte_commande.Size = new System.Drawing.Size(172, 20);
            this.lb_qte_commande.TabIndex = 22;
            this.lb_qte_commande.Text = "Quantité Commande";
            // 
            // lb_prix
            // 
            this.lb_prix.AutoSize = true;
            this.lb_prix.BackColor = System.Drawing.Color.Transparent;
            this.lb_prix.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prix.ForeColor = System.Drawing.Color.Black;
            this.lb_prix.Location = new System.Drawing.Point(6, 83);
            this.lb_prix.Name = "lb_prix";
            this.lb_prix.Size = new System.Drawing.Size(41, 20);
            this.lb_prix.TabIndex = 23;
            this.lb_prix.Text = "Prix";
            // 
            // lb_medicament
            // 
            this.lb_medicament.AutoSize = true;
            this.lb_medicament.BackColor = System.Drawing.Color.Transparent;
            this.lb_medicament.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_medicament.ForeColor = System.Drawing.Color.Black;
            this.lb_medicament.Location = new System.Drawing.Point(359, 35);
            this.lb_medicament.Name = "lb_medicament";
            this.lb_medicament.Size = new System.Drawing.Size(110, 20);
            this.lb_medicament.TabIndex = 25;
            this.lb_medicament.Text = " Medicament";
            // 
            // cmb_medicament
            // 
            this.cmb_medicament.FormattingEnabled = true;
            this.cmb_medicament.Location = new System.Drawing.Point(579, 30);
            this.cmb_medicament.Name = "cmb_medicament";
            this.cmb_medicament.Size = new System.Drawing.Size(198, 28);
            this.cmb_medicament.TabIndex = 30;
            this.cmb_medicament.SelectedIndexChanged += new System.EventHandler(this.cmb_medicament_SelectedIndexChanged);
            // 
            // txt_num_facture
            // 
            this.txt_num_facture.Enabled = false;
            this.txt_num_facture.Location = new System.Drawing.Point(114, 32);
            this.txt_num_facture.Name = "txt_num_facture";
            this.txt_num_facture.Size = new System.Drawing.Size(198, 27);
            this.txt_num_facture.TabIndex = 38;
            // 
            // lb_num_facture
            // 
            this.lb_num_facture.AutoSize = true;
            this.lb_num_facture.BackColor = System.Drawing.Color.Transparent;
            this.lb_num_facture.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num_facture.ForeColor = System.Drawing.Color.Black;
            this.lb_num_facture.Location = new System.Drawing.Point(5, 35);
            this.lb_num_facture.Name = "lb_num_facture";
            this.lb_num_facture.Size = new System.Drawing.Size(89, 20);
            this.lb_num_facture.TabIndex = 37;
            this.lb_num_facture.Text = "N°Facture";
            // 
            // bt_annuler
            // 
            this.bt_annuler.BackColor = System.Drawing.Color.White;
            this.bt_annuler.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_annuler.ForeColor = System.Drawing.Color.Red;
            this.bt_annuler.Location = new System.Drawing.Point(52, 277);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(161, 39);
            this.bt_annuler.TabIndex = 92;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = false;
            this.bt_annuler.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgv_cmd
            // 
            this.dgv_cmd.AllowUserToAddRows = false;
            this.dgv_cmd.AllowUserToDeleteRows = false;
            this.dgv_cmd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cmd.Location = new System.Drawing.Point(12, 365);
            this.dgv_cmd.Name = "dgv_cmd";
            this.dgv_cmd.ReadOnly = true;
            this.dgv_cmd.RowHeadersWidth = 62;
            this.dgv_cmd.RowTemplate.Height = 28;
            this.dgv_cmd.Size = new System.Drawing.Size(849, 343);
            this.dgv_cmd.TabIndex = 93;
            this.dgv_cmd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cmd_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_rechercher);
            this.groupBox2.Controls.Add(this.txt_rech_num_facture);
            this.groupBox2.Controls.Add(this.lb_rech_num_facture);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox2.Location = new System.Drawing.Point(879, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 174);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.BackColor = System.Drawing.Color.White;
            this.bt_rechercher.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_rechercher.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_rechercher.Location = new System.Drawing.Point(54, 119);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(143, 39);
            this.bt_rechercher.TabIndex = 95;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = false;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // txt_rech_num_facture
            // 
            this.txt_rech_num_facture.Location = new System.Drawing.Point(28, 65);
            this.txt_rech_num_facture.Name = "txt_rech_num_facture";
            this.txt_rech_num_facture.Size = new System.Drawing.Size(198, 30);
            this.txt_rech_num_facture.TabIndex = 49;
            // 
            // lb_rech_num_facture
            // 
            this.lb_rech_num_facture.AutoSize = true;
            this.lb_rech_num_facture.BackColor = System.Drawing.Color.Transparent;
            this.lb_rech_num_facture.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rech_num_facture.ForeColor = System.Drawing.Color.Black;
            this.lb_rech_num_facture.Location = new System.Drawing.Point(80, 39);
            this.lb_rech_num_facture.Name = "lb_rech_num_facture";
            this.lb_rech_num_facture.Size = new System.Drawing.Size(89, 20);
            this.lb_rech_num_facture.TabIndex = 48;
            this.lb_rech_num_facture.Text = "N°Facture";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_vider);
            this.groupBox3.Controls.Add(this.bt_supprimer);
            this.groupBox3.Controls.Add(this.bt_modifier);
            this.groupBox3.Controls.Add(this.bt_ajouter);
            this.groupBox3.Controls.Add(this.bt_annuler);
            this.groupBox3.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox3.Location = new System.Drawing.Point(879, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 322);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opération";
            // 
            // bt_vider
            // 
            this.bt_vider.BackColor = System.Drawing.Color.White;
            this.bt_vider.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_vider.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_vider.Location = new System.Drawing.Point(52, 217);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(161, 41);
            this.bt_vider.TabIndex = 102;
            this.bt_vider.Text = "Vider\r\n";
            this.bt_vider.UseVisualStyleBackColor = false;
            this.bt_vider.Click += new System.EventHandler(this.bt_vider_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.BackColor = System.Drawing.Color.White;
            this.bt_supprimer.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_supprimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_supprimer.Location = new System.Drawing.Point(53, 160);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(160, 41);
            this.bt_supprimer.TabIndex = 101;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = false;
            // 
            // bt_modifier
            // 
            this.bt_modifier.BackColor = System.Drawing.Color.White;
            this.bt_modifier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_modifier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_modifier.Location = new System.Drawing.Point(54, 103);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(161, 39);
            this.bt_modifier.TabIndex = 92;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = false;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BackColor = System.Drawing.Color.White;
            this.bt_ajouter.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_ajouter.Location = new System.Drawing.Point(54, 44);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(161, 39);
            this.bt_ajouter.TabIndex = 93;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = false;
            this.bt_ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_validation_cmd
            // 
            this.bt_validation_cmd.BackColor = System.Drawing.Color.White;
            this.bt_validation_cmd.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_validation_cmd.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_validation_cmd.Location = new System.Drawing.Point(295, 714);
            this.bt_validation_cmd.Name = "bt_validation_cmd";
            this.bt_validation_cmd.Size = new System.Drawing.Size(327, 43);
            this.bt_validation_cmd.TabIndex = 94;
            this.bt_validation_cmd.Text = "Validation du commande";
            this.bt_validation_cmd.UseVisualStyleBackColor = false;
            this.bt_validation_cmd.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "La commande de la facture";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_num_facture);
            this.groupBox4.Controls.Add(this.lb_medicament);
            this.groupBox4.Controls.Add(this.lb_prix);
            this.groupBox4.Controls.Add(this.lb_qte_commande);
            this.groupBox4.Controls.Add(this.txt_prix);
            this.groupBox4.Controls.Add(this.txt_qte_commande);
            this.groupBox4.Controls.Add(this.txt_num_facture);
            this.groupBox4.Controls.Add(this.cmb_medicament);
            this.groupBox4.Font = new System.Drawing.Font("Britannic Bold", 9F);
            this.groupBox4.Location = new System.Drawing.Point(12, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(849, 123);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info commandes";
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 782);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_validation_cmd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_cmd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.Commande_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_qte_commande;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.Label lb_qte_commande;
        private System.Windows.Forms.Label lb_prix;
        private System.Windows.Forms.Label lb_medicament;
        private System.Windows.Forms.ComboBox cmb_medicament;
        private System.Windows.Forms.TextBox txt_num_facture;
        private System.Windows.Forms.Label lb_num_facture;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.DataGridView dgv_cmd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_rechercher;
        private System.Windows.Forms.TextBox txt_rech_num_facture;
        private System.Windows.Forms.Label lb_rech_num_facture;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_validation_cmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_vider;
    }
}