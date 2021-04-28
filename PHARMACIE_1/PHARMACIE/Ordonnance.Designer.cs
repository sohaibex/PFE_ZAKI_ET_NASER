
namespace PHARMACIE
{
    partial class Ordonnance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordonnance));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lb_date_consu = new System.Windows.Forms.Label();
            this.lb_code_ordo = new System.Windows.Forms.Label();
            this.txt_code_ordo = new System.Windows.Forms.TextBox();
            this.cmb_medecin = new System.Windows.Forms.ComboBox();
            this.lb_medecin = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_continue = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.lb_code_rech = new System.Windows.Forms.Label();
            this.txt_code_rech = new System.Windows.Forms.TextBox();
            this.dgv_ordonnance = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordonnance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(379, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 36);
            this.label1.TabIndex = 60;
            this.label1.Text = "Gestion des ordonnances";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(197, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 111);
            this.groupBox1.TabIndex = 59;
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
            // lb_date_consu
            // 
            this.lb_date_consu.AutoSize = true;
            this.lb_date_consu.BackColor = System.Drawing.Color.Transparent;
            this.lb_date_consu.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_consu.ForeColor = System.Drawing.Color.Black;
            this.lb_date_consu.Location = new System.Drawing.Point(108, 78);
            this.lb_date_consu.Name = "lb_date_consu";
            this.lb_date_consu.Size = new System.Drawing.Size(175, 20);
            this.lb_date_consu.TabIndex = 63;
            this.lb_date_consu.Text = "Date de consultation";
            // 
            // lb_code_ordo
            // 
            this.lb_code_ordo.AutoSize = true;
            this.lb_code_ordo.BackColor = System.Drawing.Color.Transparent;
            this.lb_code_ordo.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_code_ordo.ForeColor = System.Drawing.Color.Black;
            this.lb_code_ordo.Location = new System.Drawing.Point(108, 29);
            this.lb_code_ordo.Name = "lb_code_ordo";
            this.lb_code_ordo.Size = new System.Drawing.Size(163, 20);
            this.lb_code_ordo.TabIndex = 86;
            this.lb_code_ordo.Text = "Code d\'ordonnance";
            this.lb_code_ordo.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_code_ordo
            // 
            this.txt_code_ordo.Enabled = false;
            this.txt_code_ordo.Location = new System.Drawing.Point(296, 26);
            this.txt_code_ordo.Multiline = true;
            this.txt_code_ordo.Name = "txt_code_ordo";
            this.txt_code_ordo.Size = new System.Drawing.Size(261, 26);
            this.txt_code_ordo.TabIndex = 85;
            // 
            // cmb_medecin
            // 
            this.cmb_medecin.FormattingEnabled = true;
            this.cmb_medecin.Location = new System.Drawing.Point(296, 118);
            this.cmb_medecin.Name = "cmb_medecin";
            this.cmb_medecin.Size = new System.Drawing.Size(261, 28);
            this.cmb_medecin.TabIndex = 88;
            // 
            // lb_medecin
            // 
            this.lb_medecin.AutoSize = true;
            this.lb_medecin.BackColor = System.Drawing.Color.Transparent;
            this.lb_medecin.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_medecin.ForeColor = System.Drawing.Color.Black;
            this.lb_medecin.Location = new System.Drawing.Point(108, 121);
            this.lb_medecin.Name = "lb_medecin";
            this.lb_medecin.Size = new System.Drawing.Size(74, 20);
            this.lb_medecin.TabIndex = 87;
            this.lb_medecin.Text = "Medecin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_continue);
            this.groupBox3.Controls.Add(this.bt_modifier);
            this.groupBox3.Controls.Add(this.bt_ajouter);
            this.groupBox3.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox3.Location = new System.Drawing.Point(795, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 308);
            this.groupBox3.TabIndex = 89;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opération";
            // 
            // bt_continue
            // 
            this.bt_continue.BackColor = System.Drawing.Color.White;
            this.bt_continue.Enabled = false;
            this.bt_continue.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_continue.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_continue.Location = new System.Drawing.Point(39, 139);
            this.bt_continue.Name = "bt_continue";
            this.bt_continue.Size = new System.Drawing.Size(248, 39);
            this.bt_continue.TabIndex = 97;
            this.bt_continue.Text = "Continue >";
            this.bt_continue.UseVisualStyleBackColor = false;
            this.bt_continue.Click += new System.EventHandler(this.bt_continue_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.BackColor = System.Drawing.Color.White;
            this.bt_modifier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_modifier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_modifier.Location = new System.Drawing.Point(39, 230);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(248, 39);
            this.bt_modifier.TabIndex = 95;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = false;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BackColor = System.Drawing.Color.White;
            this.bt_ajouter.Enabled = false;
            this.bt_ajouter.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_ajouter.Location = new System.Drawing.Point(39, 55);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(248, 39);
            this.bt_ajouter.TabIndex = 96;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = false;
            this.bt_ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_rechercher);
            this.groupBox2.Controls.Add(this.lb_code_rech);
            this.groupBox2.Controls.Add(this.txt_code_rech);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox2.Location = new System.Drawing.Point(795, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 161);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.BackColor = System.Drawing.Color.White;
            this.bt_rechercher.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_rechercher.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_rechercher.Location = new System.Drawing.Point(39, 107);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(248, 39);
            this.bt_rechercher.TabIndex = 97;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = false;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // lb_code_rech
            // 
            this.lb_code_rech.AutoSize = true;
            this.lb_code_rech.BackColor = System.Drawing.Color.Transparent;
            this.lb_code_rech.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_code_rech.ForeColor = System.Drawing.Color.Black;
            this.lb_code_rech.Location = new System.Drawing.Point(18, 66);
            this.lb_code_rech.Name = "lb_code_rech";
            this.lb_code_rech.Size = new System.Drawing.Size(49, 20);
            this.lb_code_rech.TabIndex = 92;
            this.lb_code_rech.Text = "Code";
            // 
            // txt_code_rech
            // 
            this.txt_code_rech.Location = new System.Drawing.Point(73, 61);
            this.txt_code_rech.Multiline = true;
            this.txt_code_rech.Name = "txt_code_rech";
            this.txt_code_rech.Size = new System.Drawing.Size(185, 26);
            this.txt_code_rech.TabIndex = 91;
            // 
            // dgv_ordonnance
            // 
            this.dgv_ordonnance.AllowUserToAddRows = false;
            this.dgv_ordonnance.AllowUserToDeleteRows = false;
            this.dgv_ordonnance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ordonnance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordonnance.Location = new System.Drawing.Point(12, 374);
            this.dgv_ordonnance.Name = "dgv_ordonnance";
            this.dgv_ordonnance.ReadOnly = true;
            this.dgv_ordonnance.RowHeadersWidth = 62;
            this.dgv_ordonnance.RowTemplate.Height = 28;
            this.dgv_ordonnance.Size = new System.Drawing.Size(755, 303);
            this.dgv_ordonnance.TabIndex = 91;
            this.dgv_ordonnance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordonnance_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 97;
            this.label2.Text = "La listes des ordonnances\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.cmb_medecin);
            this.groupBox4.Controls.Add(this.lb_date_consu);
            this.groupBox4.Controls.Add(this.txt_code_ordo);
            this.groupBox4.Controls.Add(this.lb_code_ordo);
            this.groupBox4.Controls.Add(this.lb_medecin);
            this.groupBox4.Font = new System.Drawing.Font("Britannic Bold", 9F);
            this.groupBox4.Location = new System.Drawing.Point(17, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(744, 161);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info ordonnance";
            // 
            // bt_premier
            // 
            this.bt_premier.BackColor = System.Drawing.Color.White;
            this.bt_premier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_premier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_premier.Location = new System.Drawing.Point(12, 692);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(160, 39);
            this.bt_premier.TabIndex = 112;
            this.bt_premier.Text = "<<";
            this.bt_premier.UseVisualStyleBackColor = false;
            this.bt_premier.Click += new System.EventHandler(this.bt_premier_Click);
            // 
            // bt_precedent
            // 
            this.bt_precedent.BackColor = System.Drawing.Color.White;
            this.bt_precedent.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_precedent.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_precedent.Location = new System.Drawing.Point(230, 692);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(160, 39);
            this.bt_precedent.TabIndex = 111;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = false;
            this.bt_precedent.Click += new System.EventHandler(this.bt_precedent_Click);
            // 
            // bt_suivant
            // 
            this.bt_suivant.BackColor = System.Drawing.Color.White;
            this.bt_suivant.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_suivant.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_suivant.Location = new System.Drawing.Point(452, 692);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(160, 39);
            this.bt_suivant.TabIndex = 109;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = false;
            this.bt_suivant.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_dernier
            // 
            this.bt_dernier.BackColor = System.Drawing.Color.White;
            this.bt_dernier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_dernier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_dernier.Location = new System.Drawing.Point(673, 692);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(160, 39);
            this.bt_dernier.TabIndex = 110;
            this.bt_dernier.Text = ">>";
            this.bt_dernier.UseVisualStyleBackColor = false;
            this.bt_dernier.Click += new System.EventHandler(this.bt_dernier_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 27);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // Ordonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 782);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_ordonnance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ordonnance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordonnace";
            this.Load += new System.EventHandler(this.Ordonnance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordonnance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_date_consu;
        private System.Windows.Forms.Label lb_code_ordo;
        private System.Windows.Forms.TextBox txt_code_ordo;
        private System.Windows.Forms.ComboBox cmb_medecin;
        private System.Windows.Forms.Label lb_medecin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_code_rech;
        private System.Windows.Forms.TextBox txt_code_rech;
        private System.Windows.Forms.DataGridView dgv_ordonnance;
        private System.Windows.Forms.Button bt_rechercher;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_continue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}