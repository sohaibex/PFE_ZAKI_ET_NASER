
namespace PHARMACIE
{
    partial class Gestion_medicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_medicament));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_categ = new System.Windows.Forms.ComboBox();
            this.Picker_date_exp = new System.Windows.Forms.DateTimePicker();
            this.txt_qte_en_stock = new System.Windows.Forms.TextBox();
            this.txt_prix_medicament = new System.Windows.Forms.TextBox();
            this.txt_nom_medicament = new System.Windows.Forms.TextBox();
            this.txt_code_medicament = new System.Windows.Forms.TextBox();
            this.lb_date_exp = new System.Windows.Forms.Label();
            this.lb_categ_medicament = new System.Windows.Forms.Label();
            this.lb_qte_en_stock = new System.Windows.Forms.Label();
            this.lb_prix_medicament = new System.Windows.Forms.Label();
            this.lb_nom_medicament = new System.Windows.Forms.Label();
            this.lb_code_medicament = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.txt_rech_code_medic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_medicaments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.bt_vider = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(183, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 111);
            this.groupBox1.TabIndex = 14;
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
            this.pictureBox4.Location = new System.Drawing.Point(23, 21);
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
            this.label1.Location = new System.Drawing.Point(373, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion des medicaments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_categ);
            this.groupBox2.Controls.Add(this.Picker_date_exp);
            this.groupBox2.Controls.Add(this.txt_qte_en_stock);
            this.groupBox2.Controls.Add(this.txt_prix_medicament);
            this.groupBox2.Controls.Add(this.txt_nom_medicament);
            this.groupBox2.Controls.Add(this.txt_code_medicament);
            this.groupBox2.Controls.Add(this.lb_date_exp);
            this.groupBox2.Controls.Add(this.lb_categ_medicament);
            this.groupBox2.Controls.Add(this.lb_qte_en_stock);
            this.groupBox2.Controls.Add(this.lb_prix_medicament);
            this.groupBox2.Controls.Add(this.lb_nom_medicament);
            this.groupBox2.Controls.Add(this.lb_code_medicament);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 190);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail du médicament";
            // 
            // cmb_categ
            // 
            this.cmb_categ.FormattingEnabled = true;
            this.cmb_categ.Location = new System.Drawing.Point(495, 146);
            this.cmb_categ.Name = "cmb_categ";
            this.cmb_categ.Size = new System.Drawing.Size(198, 30);
            this.cmb_categ.TabIndex = 8;
            // 
            // Picker_date_exp
            // 
            this.Picker_date_exp.CalendarFont = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picker_date_exp.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picker_date_exp.Location = new System.Drawing.Point(172, 88);
            this.Picker_date_exp.Name = "Picker_date_exp";
            this.Picker_date_exp.Size = new System.Drawing.Size(200, 30);
            this.Picker_date_exp.TabIndex = 7;
            // 
            // txt_qte_en_stock
            // 
            this.txt_qte_en_stock.Enabled = false;
            this.txt_qte_en_stock.Location = new System.Drawing.Point(172, 145);
            this.txt_qte_en_stock.Name = "txt_qte_en_stock";
            this.txt_qte_en_stock.Size = new System.Drawing.Size(198, 30);
            this.txt_qte_en_stock.TabIndex = 6;
            // 
            // txt_prix_medicament
            // 
            this.txt_prix_medicament.Location = new System.Drawing.Point(495, 91);
            this.txt_prix_medicament.Name = "txt_prix_medicament";
            this.txt_prix_medicament.Size = new System.Drawing.Size(198, 30);
            this.txt_prix_medicament.TabIndex = 6;
            // 
            // txt_nom_medicament
            // 
            this.txt_nom_medicament.Location = new System.Drawing.Point(495, 37);
            this.txt_nom_medicament.Name = "txt_nom_medicament";
            this.txt_nom_medicament.Size = new System.Drawing.Size(198, 30);
            this.txt_nom_medicament.TabIndex = 6;
            // 
            // txt_code_medicament
            // 
            this.txt_code_medicament.Enabled = false;
            this.txt_code_medicament.Location = new System.Drawing.Point(172, 37);
            this.txt_code_medicament.Multiline = true;
            this.txt_code_medicament.Name = "txt_code_medicament";
            this.txt_code_medicament.Size = new System.Drawing.Size(198, 32);
            this.txt_code_medicament.TabIndex = 6;
            // 
            // lb_date_exp
            // 
            this.lb_date_exp.AutoSize = true;
            this.lb_date_exp.BackColor = System.Drawing.Color.Transparent;
            this.lb_date_exp.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_exp.ForeColor = System.Drawing.Color.Black;
            this.lb_date_exp.Location = new System.Drawing.Point(6, 96);
            this.lb_date_exp.Name = "lb_date_exp";
            this.lb_date_exp.Size = new System.Drawing.Size(132, 20);
            this.lb_date_exp.TabIndex = 2;
            this.lb_date_exp.Text = "Date expiration";
            // 
            // lb_categ_medicament
            // 
            this.lb_categ_medicament.AutoSize = true;
            this.lb_categ_medicament.BackColor = System.Drawing.Color.Transparent;
            this.lb_categ_medicament.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categ_medicament.ForeColor = System.Drawing.Color.Black;
            this.lb_categ_medicament.Location = new System.Drawing.Point(392, 150);
            this.lb_categ_medicament.Name = "lb_categ_medicament";
            this.lb_categ_medicament.Size = new System.Drawing.Size(87, 20);
            this.lb_categ_medicament.TabIndex = 2;
            this.lb_categ_medicament.Text = "Categorie\r\n";
            // 
            // lb_qte_en_stock
            // 
            this.lb_qte_en_stock.AutoSize = true;
            this.lb_qte_en_stock.BackColor = System.Drawing.Color.Transparent;
            this.lb_qte_en_stock.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qte_en_stock.ForeColor = System.Drawing.Color.Black;
            this.lb_qte_en_stock.Location = new System.Drawing.Point(6, 150);
            this.lb_qte_en_stock.Name = "lb_qte_en_stock";
            this.lb_qte_en_stock.Size = new System.Drawing.Size(108, 20);
            this.lb_qte_en_stock.TabIndex = 2;
            this.lb_qte_en_stock.Text = "Qte en stock";
            // 
            // lb_prix_medicament
            // 
            this.lb_prix_medicament.AutoSize = true;
            this.lb_prix_medicament.BackColor = System.Drawing.Color.Transparent;
            this.lb_prix_medicament.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prix_medicament.ForeColor = System.Drawing.Color.Black;
            this.lb_prix_medicament.Location = new System.Drawing.Point(393, 96);
            this.lb_prix_medicament.Name = "lb_prix_medicament";
            this.lb_prix_medicament.Size = new System.Drawing.Size(41, 20);
            this.lb_prix_medicament.TabIndex = 2;
            this.lb_prix_medicament.Text = "Prix";
            // 
            // lb_nom_medicament
            // 
            this.lb_nom_medicament.AutoSize = true;
            this.lb_nom_medicament.BackColor = System.Drawing.Color.Transparent;
            this.lb_nom_medicament.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nom_medicament.ForeColor = System.Drawing.Color.Black;
            this.lb_nom_medicament.Location = new System.Drawing.Point(389, 42);
            this.lb_nom_medicament.Name = "lb_nom_medicament";
            this.lb_nom_medicament.Size = new System.Drawing.Size(45, 20);
            this.lb_nom_medicament.TabIndex = 2;
            this.lb_nom_medicament.Text = "Nom";
            // 
            // lb_code_medicament
            // 
            this.lb_code_medicament.AutoSize = true;
            this.lb_code_medicament.BackColor = System.Drawing.Color.Transparent;
            this.lb_code_medicament.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_code_medicament.ForeColor = System.Drawing.Color.Black;
            this.lb_code_medicament.Location = new System.Drawing.Point(6, 42);
            this.lb_code_medicament.Name = "lb_code_medicament";
            this.lb_code_medicament.Size = new System.Drawing.Size(152, 20);
            this.lb_code_medicament.TabIndex = 2;
            this.lb_code_medicament.Text = "Code medicament";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_rechercher);
            this.groupBox3.Controls.Add(this.txt_rech_code_medic);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox3.Location = new System.Drawing.Point(805, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 190);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.BackColor = System.Drawing.Color.White;
            this.bt_rechercher.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_rechercher.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_rechercher.Location = new System.Drawing.Point(61, 117);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(143, 41);
            this.bt_rechercher.TabIndex = 96;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = false;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // txt_rech_code_medic
            // 
            this.txt_rech_code_medic.Location = new System.Drawing.Point(28, 65);
            this.txt_rech_code_medic.Name = "txt_rech_code_medic";
            this.txt_rech_code_medic.Size = new System.Drawing.Size(198, 30);
            this.txt_rech_code_medic.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(55, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Code Medicament";
            // 
            // dgv_medicaments
            // 
            this.dgv_medicaments.AllowUserToAddRows = false;
            this.dgv_medicaments.AllowUserToDeleteRows = false;
            this.dgv_medicaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_medicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicaments.Location = new System.Drawing.Point(34, 390);
            this.dgv_medicaments.Name = "dgv_medicaments";
            this.dgv_medicaments.ReadOnly = true;
            this.dgv_medicaments.RowHeadersWidth = 62;
            this.dgv_medicaments.RowTemplate.Height = 28;
            this.dgv_medicaments.Size = new System.Drawing.Size(1052, 253);
            this.dgv_medicaments.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 99;
            this.label2.Text = "La listes des médicaments";
            // 
            // bt_premier
            // 
            this.bt_premier.BackColor = System.Drawing.Color.White;
            this.bt_premier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_premier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_premier.Location = new System.Drawing.Point(136, 649);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(160, 38);
            this.bt_premier.TabIndex = 107;
            this.bt_premier.Text = "<<";
            this.bt_premier.UseVisualStyleBackColor = false;
            this.bt_premier.Click += new System.EventHandler(this.bt_premier_Click);
            // 
            // bt_precedent
            // 
            this.bt_precedent.BackColor = System.Drawing.Color.White;
            this.bt_precedent.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_precedent.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_precedent.Location = new System.Drawing.Point(354, 649);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(160, 38);
            this.bt_precedent.TabIndex = 106;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = false;
            this.bt_precedent.Click += new System.EventHandler(this.bt_precedent_Click);
            // 
            // bt_suivant
            // 
            this.bt_suivant.BackColor = System.Drawing.Color.White;
            this.bt_suivant.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_suivant.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_suivant.Location = new System.Drawing.Point(576, 649);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(160, 38);
            this.bt_suivant.TabIndex = 104;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = false;
            this.bt_suivant.Click += new System.EventHandler(this.bt_suivant_Click);
            // 
            // bt_dernier
            // 
            this.bt_dernier.BackColor = System.Drawing.Color.White;
            this.bt_dernier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_dernier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_dernier.Location = new System.Drawing.Point(797, 649);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(160, 38);
            this.bt_dernier.TabIndex = 105;
            this.bt_dernier.Text = ">>";
            this.bt_dernier.UseVisualStyleBackColor = false;
            this.bt_dernier.Click += new System.EventHandler(this.bt_dernier_Click);
            // 
            // bt_vider
            // 
            this.bt_vider.BackColor = System.Drawing.Color.White;
            this.bt_vider.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_vider.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_vider.Location = new System.Drawing.Point(797, 693);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(160, 45);
            this.bt_vider.TabIndex = 100;
            this.bt_vider.Text = "Vider";
            this.bt_vider.UseVisualStyleBackColor = false;
            this.bt_vider.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.BackColor = System.Drawing.Color.White;
            this.bt_supprimer.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_supprimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_supprimer.Location = new System.Drawing.Point(576, 693);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(160, 45);
            this.bt_supprimer.TabIndex = 101;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = false;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.BackColor = System.Drawing.Color.White;
            this.bt_modifier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_modifier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_modifier.Location = new System.Drawing.Point(354, 693);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(160, 45);
            this.bt_modifier.TabIndex = 102;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = false;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1086, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BackColor = System.Drawing.Color.White;
            this.bt_ajouter.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_ajouter.Location = new System.Drawing.Point(136, 693);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(160, 45);
            this.bt_ajouter.TabIndex = 109;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = false;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // Gestion_medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1123, 781);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.bt_vider);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_medicaments);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_medicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Pharmacie";
            this.Load += new System.EventHandler(this.Gestion_medicament_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_date_exp;
        private System.Windows.Forms.Label lb_qte_en_stock;
        private System.Windows.Forms.Label lb_prix_medicament;
        private System.Windows.Forms.Label lb_nom_medicament;
        private System.Windows.Forms.Label lb_code_medicament;
        private System.Windows.Forms.TextBox txt_qte_en_stock;
        private System.Windows.Forms.TextBox txt_prix_medicament;
        private System.Windows.Forms.TextBox txt_nom_medicament;
        private System.Windows.Forms.DateTimePicker Picker_date_exp;
        private System.Windows.Forms.Label lb_categ_medicament;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_rech_code_medic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_medicaments;
        private System.Windows.Forms.Button bt_rechercher;
        private System.Windows.Forms.ComboBox cmb_categ;
        private System.Windows.Forms.TextBox txt_code_medicament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
        private System.Windows.Forms.Button bt_vider;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_ajouter;
    }
}