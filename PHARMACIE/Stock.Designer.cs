
namespace PHARMACIE
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picker_date_entrer = new System.Windows.Forms.DateTimePicker();
            this.lb_date_entrer = new System.Windows.Forms.Label();
            this.txt_qte_entrer = new System.Windows.Forms.TextBox();
            this.lb_qte_entrer = new System.Windows.Forms.Label();
            this.cmb_medicament = new System.Windows.Forms.ComboBox();
            this.lb_medicament = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_f_m = new System.Windows.Forms.RadioButton();
            this.rd_medicament = new System.Windows.Forms.RadioButton();
            this.rd_fournisseur = new System.Windows.Forms.RadioButton();
            this.rd_stock = new System.Windows.Forms.RadioButton();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.lb_code_stock = new System.Windows.Forms.Label();
            this.cmb_fournisseur = new System.Windows.Forms.ComboBox();
            this.txt_code_stock = new System.Windows.Forms.TextBox();
            this.lb_fournisseur = new System.Windows.Forms.Label();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_vider = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(441, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 58;
            this.label1.Text = "Gestion du stock";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(202, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 111);
            this.groupBox1.TabIndex = 57;
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
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            // picker_date_entrer
            // 
            this.picker_date_entrer.CalendarFont = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker_date_entrer.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker_date_entrer.Location = new System.Drawing.Point(557, 72);
            this.picker_date_entrer.Name = "picker_date_entrer";
            this.picker_date_entrer.Size = new System.Drawing.Size(261, 30);
            this.picker_date_entrer.TabIndex = 62;
            // 
            // lb_date_entrer
            // 
            this.lb_date_entrer.AutoSize = true;
            this.lb_date_entrer.BackColor = System.Drawing.Color.Transparent;
            this.lb_date_entrer.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_entrer.ForeColor = System.Drawing.Color.Black;
            this.lb_date_entrer.Location = new System.Drawing.Point(417, 77);
            this.lb_date_entrer.Name = "lb_date_entrer";
            this.lb_date_entrer.Size = new System.Drawing.Size(115, 20);
            this.lb_date_entrer.TabIndex = 59;
            this.lb_date_entrer.Text = "Date d\'entrée";
            // 
            // txt_qte_entrer
            // 
            this.txt_qte_entrer.Location = new System.Drawing.Point(557, 30);
            this.txt_qte_entrer.Multiline = true;
            this.txt_qte_entrer.Name = "txt_qte_entrer";
            this.txt_qte_entrer.Size = new System.Drawing.Size(261, 26);
            this.txt_qte_entrer.TabIndex = 68;
            // 
            // lb_qte_entrer
            // 
            this.lb_qte_entrer.AutoSize = true;
            this.lb_qte_entrer.BackColor = System.Drawing.Color.Transparent;
            this.lb_qte_entrer.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qte_entrer.ForeColor = System.Drawing.Color.Black;
            this.lb_qte_entrer.Location = new System.Drawing.Point(417, 33);
            this.lb_qte_entrer.Name = "lb_qte_entrer";
            this.lb_qte_entrer.Size = new System.Drawing.Size(91, 20);
            this.lb_qte_entrer.TabIndex = 67;
            this.lb_qte_entrer.Text = "Qte entrer";
            // 
            // cmb_medicament
            // 
            this.cmb_medicament.FormattingEnabled = true;
            this.cmb_medicament.Location = new System.Drawing.Point(162, 118);
            this.cmb_medicament.Name = "cmb_medicament";
            this.cmb_medicament.Size = new System.Drawing.Size(240, 28);
            this.cmb_medicament.TabIndex = 71;
            // 
            // lb_medicament
            // 
            this.lb_medicament.AutoSize = true;
            this.lb_medicament.BackColor = System.Drawing.Color.Transparent;
            this.lb_medicament.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_medicament.ForeColor = System.Drawing.Color.Black;
            this.lb_medicament.Location = new System.Drawing.Point(19, 121);
            this.lb_medicament.Name = "lb_medicament";
            this.lb_medicament.Size = new System.Drawing.Size(105, 20);
            this.lb_medicament.TabIndex = 70;
            this.lb_medicament.Text = "Medicament";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_f_m);
            this.groupBox2.Controls.Add(this.rd_medicament);
            this.groupBox2.Controls.Add(this.rd_fournisseur);
            this.groupBox2.Controls.Add(this.rd_stock);
            this.groupBox2.Controls.Add(this.bt_rechercher);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox2.Location = new System.Drawing.Point(877, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 238);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // rd_f_m
            // 
            this.rd_f_m.AutoSize = true;
            this.rd_f_m.Location = new System.Drawing.Point(15, 138);
            this.rd_f_m.Name = "rd_f_m";
            this.rd_f_m.Size = new System.Drawing.Size(120, 26);
            this.rd_f_m.TabIndex = 100;
            this.rd_f_m.TabStop = true;
            this.rd_f_m.Text = "Par F + M";
            this.rd_f_m.UseVisualStyleBackColor = true;
            this.rd_f_m.CheckedChanged += new System.EventHandler(this.rd_f_m_CheckedChanged);
            this.rd_f_m.Click += new System.EventHandler(this.rd_f_m_Click);
            // 
            // rd_medicament
            // 
            this.rd_medicament.AutoSize = true;
            this.rd_medicament.Location = new System.Drawing.Point(15, 106);
            this.rd_medicament.Name = "rd_medicament";
            this.rd_medicament.Size = new System.Drawing.Size(179, 26);
            this.rd_medicament.TabIndex = 100;
            this.rd_medicament.TabStop = true;
            this.rd_medicament.Text = "Par Médicament";
            this.rd_medicament.UseVisualStyleBackColor = true;
            this.rd_medicament.CheckedChanged += new System.EventHandler(this.rd_medicament_CheckedChanged);
            this.rd_medicament.Click += new System.EventHandler(this.rd_medicament_Click);
            // 
            // rd_fournisseur
            // 
            this.rd_fournisseur.AutoSize = true;
            this.rd_fournisseur.Location = new System.Drawing.Point(15, 74);
            this.rd_fournisseur.Name = "rd_fournisseur";
            this.rd_fournisseur.Size = new System.Drawing.Size(181, 26);
            this.rd_fournisseur.TabIndex = 100;
            this.rd_fournisseur.TabStop = true;
            this.rd_fournisseur.Text = "Par Fournisseur";
            this.rd_fournisseur.UseVisualStyleBackColor = true;
            this.rd_fournisseur.CheckedChanged += new System.EventHandler(this.rd_fournisseur_CheckedChanged);
            this.rd_fournisseur.Click += new System.EventHandler(this.rd_fournisseur_Click);
            // 
            // rd_stock
            // 
            this.rd_stock.AutoSize = true;
            this.rd_stock.Location = new System.Drawing.Point(15, 42);
            this.rd_stock.Name = "rd_stock";
            this.rd_stock.Size = new System.Drawing.Size(122, 26);
            this.rd_stock.TabIndex = 99;
            this.rd_stock.TabStop = true;
            this.rd_stock.Text = "Par Stock";
            this.rd_stock.UseVisualStyleBackColor = true;
            this.rd_stock.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rd_stock.Click += new System.EventHandler(this.rd_stock_Click);
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.BackColor = System.Drawing.Color.White;
            this.bt_rechercher.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_rechercher.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_rechercher.Location = new System.Drawing.Point(15, 183);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(161, 40);
            this.bt_rechercher.TabIndex = 98;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = false;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // lb_code_stock
            // 
            this.lb_code_stock.AutoSize = true;
            this.lb_code_stock.BackColor = System.Drawing.Color.Transparent;
            this.lb_code_stock.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_code_stock.ForeColor = System.Drawing.Color.Black;
            this.lb_code_stock.Location = new System.Drawing.Point(19, 38);
            this.lb_code_stock.Name = "lb_code_stock";
            this.lb_code_stock.Size = new System.Drawing.Size(97, 20);
            this.lb_code_stock.TabIndex = 84;
            this.lb_code_stock.Text = "Code stock";
            // 
            // cmb_fournisseur
            // 
            this.cmb_fournisseur.FormattingEnabled = true;
            this.cmb_fournisseur.Location = new System.Drawing.Point(162, 74);
            this.cmb_fournisseur.Name = "cmb_fournisseur";
            this.cmb_fournisseur.Size = new System.Drawing.Size(240, 28);
            this.cmb_fournisseur.TabIndex = 83;
            // 
            // txt_code_stock
            // 
            this.txt_code_stock.Enabled = false;
            this.txt_code_stock.Location = new System.Drawing.Point(162, 32);
            this.txt_code_stock.Multiline = true;
            this.txt_code_stock.Name = "txt_code_stock";
            this.txt_code_stock.Size = new System.Drawing.Size(240, 26);
            this.txt_code_stock.TabIndex = 82;
            // 
            // lb_fournisseur
            // 
            this.lb_fournisseur.AutoSize = true;
            this.lb_fournisseur.BackColor = System.Drawing.Color.Transparent;
            this.lb_fournisseur.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fournisseur.ForeColor = System.Drawing.Color.Black;
            this.lb_fournisseur.Location = new System.Drawing.Point(19, 77);
            this.lb_fournisseur.Name = "lb_fournisseur";
            this.lb_fournisseur.Size = new System.Drawing.Size(106, 20);
            this.lb_fournisseur.TabIndex = 81;
            this.lb_fournisseur.Text = "Fournisseur";
            // 
            // dgv_stock
            // 
            this.dgv_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(21, 397);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowHeadersWidth = 62;
            this.dgv_stock.RowTemplate.Height = 28;
            this.dgv_stock.Size = new System.Drawing.Size(831, 287);
            this.dgv_stock.TabIndex = 87;
            this.dgv_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_CellClick);
            this.dgv_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_modifier);
            this.groupBox3.Controls.Add(this.bt_vider);
            this.groupBox3.Controls.Add(this.bt_supprimer);
            this.groupBox3.Controls.Add(this.bt_ajouter);
            this.groupBox3.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox3.Location = new System.Drawing.Point(877, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 274);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opération";
            // 
            // bt_modifier
            // 
            this.bt_modifier.BackColor = System.Drawing.Color.White;
            this.bt_modifier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_modifier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_modifier.Location = new System.Drawing.Point(45, 99);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(161, 40);
            this.bt_modifier.TabIndex = 92;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = false;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_vider
            // 
            this.bt_vider.BackColor = System.Drawing.Color.White;
            this.bt_vider.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_vider.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_vider.Location = new System.Drawing.Point(45, 223);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(161, 40);
            this.bt_vider.TabIndex = 91;
            this.bt_vider.Text = "Vider";
            this.bt_vider.UseVisualStyleBackColor = false;
            this.bt_vider.Click += new System.EventHandler(this.bt_vider_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.BackColor = System.Drawing.Color.White;
            this.bt_supprimer.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_supprimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_supprimer.Location = new System.Drawing.Point(45, 163);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(161, 40);
            this.bt_supprimer.TabIndex = 91;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = false;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BackColor = System.Drawing.Color.White;
            this.bt_ajouter.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_ajouter.Location = new System.Drawing.Point(45, 40);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(161, 40);
            this.bt_ajouter.TabIndex = 93;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = false;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "La listes de stock\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picker_date_entrer);
            this.groupBox4.Controls.Add(this.lb_date_entrer);
            this.groupBox4.Controls.Add(this.lb_qte_entrer);
            this.groupBox4.Controls.Add(this.txt_qte_entrer);
            this.groupBox4.Controls.Add(this.lb_medicament);
            this.groupBox4.Controls.Add(this.cmb_fournisseur);
            this.groupBox4.Controls.Add(this.cmb_medicament);
            this.groupBox4.Controls.Add(this.txt_code_stock);
            this.groupBox4.Controls.Add(this.lb_code_stock);
            this.groupBox4.Controls.Add(this.lb_fournisseur);
            this.groupBox4.Font = new System.Drawing.Font("Britannic Bold", 9F);
            this.groupBox4.Location = new System.Drawing.Point(21, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(831, 178);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info stock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1080, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_premier
            // 
            this.bt_premier.BackColor = System.Drawing.Color.White;
            this.bt_premier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_premier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_premier.Location = new System.Drawing.Point(21, 690);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(160, 42);
            this.bt_premier.TabIndex = 121;
            this.bt_premier.Text = "<<";
            this.bt_premier.UseVisualStyleBackColor = false;
            this.bt_premier.Click += new System.EventHandler(this.bt_premier_Click);
            // 
            // bt_precedent
            // 
            this.bt_precedent.BackColor = System.Drawing.Color.White;
            this.bt_precedent.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_precedent.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_precedent.Location = new System.Drawing.Point(239, 690);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(160, 42);
            this.bt_precedent.TabIndex = 120;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = false;
            this.bt_precedent.Click += new System.EventHandler(this.bt_precedent_Click);
            // 
            // bt_suivant
            // 
            this.bt_suivant.BackColor = System.Drawing.Color.White;
            this.bt_suivant.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_suivant.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_suivant.Location = new System.Drawing.Point(461, 690);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(160, 42);
            this.bt_suivant.TabIndex = 118;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = false;
            this.bt_suivant.Click += new System.EventHandler(this.bt_suivant_Click);
            // 
            // bt_dernier
            // 
            this.bt_dernier.BackColor = System.Drawing.Color.White;
            this.bt_dernier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_dernier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_dernier.Location = new System.Drawing.Point(682, 690);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(160, 42);
            this.bt_dernier.TabIndex = 119;
            this.bt_dernier.Text = ">>";
            this.bt_dernier.UseVisualStyleBackColor = false;
            this.bt_dernier.Click += new System.EventHandler(this.bt_dernier_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 796);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv_stock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DateTimePicker picker_date_entrer;
        private System.Windows.Forms.Label lb_date_entrer;
        private System.Windows.Forms.TextBox txt_qte_entrer;
        private System.Windows.Forms.Label lb_qte_entrer;
        private System.Windows.Forms.ComboBox cmb_medicament;
        private System.Windows.Forms.Label lb_medicament;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_code_stock;
        private System.Windows.Forms.ComboBox cmb_fournisseur;
        private System.Windows.Forms.TextBox txt_code_stock;
        private System.Windows.Forms.Label lb_fournisseur;
        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_rechercher;
    
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
        private System.Windows.Forms.Button bt_vider;
        private System.Windows.Forms.RadioButton rd_f_m;
        private System.Windows.Forms.RadioButton rd_medicament;
        private System.Windows.Forms.RadioButton rd_fournisseur;
        private System.Windows.Forms.RadioButton rd_stock;
    }
}