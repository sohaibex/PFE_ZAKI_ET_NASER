
namespace PHARMACIE
{
    partial class Categorie_medicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorie_medicament));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.txt_rech_code = new System.Windows.Forms.TextBox();
            this.lb_rech_code = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lb_code = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lb_nom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_vider = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.dgv_categ_medicament = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categ_medicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(191, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 111);
            this.groupBox1.TabIndex = 16;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_rechercher);
            this.groupBox2.Controls.Add(this.txt_rech_code);
            this.groupBox2.Controls.Add(this.lb_rech_code);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 9F);
            this.groupBox2.Location = new System.Drawing.Point(12, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 167);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.BackColor = System.Drawing.Color.White;
            this.bt_rechercher.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_rechercher.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_rechercher.Location = new System.Drawing.Point(123, 91);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(160, 48);
            this.bt_rechercher.TabIndex = 91;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = false;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // txt_rech_code
            // 
            this.txt_rech_code.Location = new System.Drawing.Point(140, 43);
            this.txt_rech_code.Name = "txt_rech_code";
            this.txt_rech_code.Size = new System.Drawing.Size(198, 27);
            this.txt_rech_code.TabIndex = 49;
            this.txt_rech_code.Enter += new System.EventHandler(this.txt_rech_code_Enter);
            // 
            // lb_rech_code
            // 
            this.lb_rech_code.AutoSize = true;
            this.lb_rech_code.BackColor = System.Drawing.Color.Transparent;
            this.lb_rech_code.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rech_code.ForeColor = System.Drawing.Color.Black;
            this.lb_rech_code.Location = new System.Drawing.Point(19, 46);
            this.lb_rech_code.Name = "lb_rech_code";
            this.lb_rech_code.Size = new System.Drawing.Size(115, 20);
            this.lb_rech_code.TabIndex = 48;
            this.lb_rech_code.Text = "Code ou Nom";
            // 
            // txt_code
            // 
            this.txt_code.Enabled = false;
            this.txt_code.Location = new System.Drawing.Point(120, 56);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(218, 27);
            this.txt_code.TabIndex = 52;
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.BackColor = System.Drawing.Color.Transparent;
            this.lb_code.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_code.ForeColor = System.Drawing.Color.Black;
            this.lb_code.Location = new System.Drawing.Point(14, 59);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(54, 20);
            this.lb_code.TabIndex = 51;
            this.lb_code.Text = "Code ";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(120, 110);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(218, 27);
            this.txt_nom.TabIndex = 50;
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.BackColor = System.Drawing.Color.Transparent;
            this.lb_nom.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nom.ForeColor = System.Drawing.Color.Black;
            this.lb_nom.Location = new System.Drawing.Point(14, 113);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(50, 20);
            this.lb_nom.TabIndex = 49;
            this.lb_nom.Text = " Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 36);
            this.label1.TabIndex = 54;
            this.label1.Text = "Catégorie du Médicaments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_vider
            // 
            this.bt_vider.BackColor = System.Drawing.Color.White;
            this.bt_vider.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_vider.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_vider.Location = new System.Drawing.Point(795, 667);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(160, 45);
            this.bt_vider.TabIndex = 87;
            this.bt_vider.Text = "Vider";
            this.bt_vider.UseVisualStyleBackColor = false;
            this.bt_vider.Click += new System.EventHandler(this.bt_vider_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.BackColor = System.Drawing.Color.White;
            this.bt_supprimer.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_supprimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_supprimer.Location = new System.Drawing.Point(574, 667);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(160, 45);
            this.bt_supprimer.TabIndex = 88;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = false;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.BackColor = System.Drawing.Color.White;
            this.bt_modifier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_modifier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_modifier.Location = new System.Drawing.Point(352, 667);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(160, 45);
            this.bt_modifier.TabIndex = 89;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = false;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BackColor = System.Drawing.Color.White;
            this.bt_ajouter.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_ajouter.Location = new System.Drawing.Point(134, 667);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(160, 45);
            this.bt_ajouter.TabIndex = 90;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = false;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // dgv_categ_medicament
            // 
            this.dgv_categ_medicament.AllowUserToAddRows = false;
            this.dgv_categ_medicament.AllowUserToDeleteRows = false;
            this.dgv_categ_medicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categ_medicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categ_medicament.Location = new System.Drawing.Point(384, 239);
            this.dgv_categ_medicament.Name = "dgv_categ_medicament";
            this.dgv_categ_medicament.ReadOnly = true;
            this.dgv_categ_medicament.RowHeadersWidth = 62;
            this.dgv_categ_medicament.RowTemplate.Height = 28;
            this.dgv_categ_medicament.Size = new System.Drawing.Size(727, 333);
            this.dgv_categ_medicament.TabIndex = 91;
            this.dgv_categ_medicament.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categ_medicament_CellClick);
            this.dgv_categ_medicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categ_medicament_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1081, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(379, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "La liste des catégories";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_nom);
            this.groupBox3.Controls.Add(this.lb_nom);
            this.groupBox3.Controls.Add(this.lb_code);
            this.groupBox3.Controls.Add(this.txt_code);
            this.groupBox3.Font = new System.Drawing.Font("Britannic Bold", 9F);
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 165);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info catégorie";
            // 
            // bt_premier
            // 
            this.bt_premier.BackColor = System.Drawing.Color.White;
            this.bt_premier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_premier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_premier.Location = new System.Drawing.Point(134, 592);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(160, 45);
            this.bt_premier.TabIndex = 98;
            this.bt_premier.Text = "<<";
            this.bt_premier.UseVisualStyleBackColor = false;
            this.bt_premier.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_precedent
            // 
            this.bt_precedent.BackColor = System.Drawing.Color.White;
            this.bt_precedent.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_precedent.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_precedent.Location = new System.Drawing.Point(352, 592);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(160, 45);
            this.bt_precedent.TabIndex = 97;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = false;
            this.bt_precedent.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_suivant
            // 
            this.bt_suivant.BackColor = System.Drawing.Color.White;
            this.bt_suivant.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_suivant.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_suivant.Location = new System.Drawing.Point(574, 592);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(160, 45);
            this.bt_suivant.TabIndex = 95;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = false;
            this.bt_suivant.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_dernier
            // 
            this.bt_dernier.BackColor = System.Drawing.Color.White;
            this.bt_dernier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_dernier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_dernier.Location = new System.Drawing.Point(795, 592);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(160, 45);
            this.bt_dernier.TabIndex = 96;
            this.bt_dernier.Text = ">>";
            this.bt_dernier.UseVisualStyleBackColor = false;
            this.bt_dernier.Click += new System.EventHandler(this.button4_Click);
            // 
            // Categorie_medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 782);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_categ_medicament);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.bt_vider);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorie_medicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorie_medicament";
            this.Load += new System.EventHandler(this.Categorie_medicament_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categ_medicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_rech_code;
        private System.Windows.Forms.Label lb_rech_code;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_vider;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_rechercher;
        private System.Windows.Forms.DataGridView dgv_categ_medicament;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
    }
}