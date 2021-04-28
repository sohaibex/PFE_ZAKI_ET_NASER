
namespace PHARMACIE
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_rech_facture = new System.Windows.Forms.RadioButton();
            this.rd_rech_date = new System.Windows.Forms.RadioButton();
            this.rd_rech_deuxdate = new System.Windows.Forms.RadioButton();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.picker_pardate_debut = new System.Windows.Forms.DateTimePicker();
            this.picker_deuxdate_fin = new System.Windows.Forms.DateTimePicker();
            this.txt_parfacture = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Imprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.dgv_facture = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(412, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = "Gestion Des Facture";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(195, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 111);
            this.groupBox1.TabIndex = 39;
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
            this.groupBox2.Controls.Add(this.rd_rech_facture);
            this.groupBox2.Controls.Add(this.rd_rech_date);
            this.groupBox2.Controls.Add(this.rd_rech_deuxdate);
            this.groupBox2.Controls.Add(this.bt_rechercher);
            this.groupBox2.Controls.Add(this.picker_pardate_debut);
            this.groupBox2.Controls.Add(this.picker_deuxdate_fin);
            this.groupBox2.Controls.Add(this.txt_parfacture);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox2.Location = new System.Drawing.Point(22, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 180);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // rd_rech_facture
            // 
            this.rd_rech_facture.AutoSize = true;
            this.rd_rech_facture.Location = new System.Drawing.Point(90, 33);
            this.rd_rech_facture.Name = "rd_rech_facture";
            this.rd_rech_facture.Size = new System.Drawing.Size(140, 26);
            this.rd_rech_facture.TabIndex = 98;
            this.rd_rech_facture.TabStop = true;
            this.rd_rech_facture.Text = "Par Facture";
            this.rd_rech_facture.UseVisualStyleBackColor = true;
            this.rd_rech_facture.CheckedChanged += new System.EventHandler(this.rd_rech_facture_CheckedChanged);
            // 
            // rd_rech_date
            // 
            this.rd_rech_date.AutoSize = true;
            this.rd_rech_date.Location = new System.Drawing.Point(89, 78);
            this.rd_rech_date.Name = "rd_rech_date";
            this.rd_rech_date.Size = new System.Drawing.Size(111, 26);
            this.rd_rech_date.TabIndex = 98;
            this.rd_rech_date.TabStop = true;
            this.rd_rech_date.Text = "Par date";
            this.rd_rech_date.UseVisualStyleBackColor = true;
            this.rd_rech_date.CheckedChanged += new System.EventHandler(this.rd_rech_date_CheckedChanged);
            // 
            // rd_rech_deuxdate
            // 
            this.rd_rech_deuxdate.AutoSize = true;
            this.rd_rech_deuxdate.Location = new System.Drawing.Point(89, 130);
            this.rd_rech_deuxdate.Name = "rd_rech_deuxdate";
            this.rd_rech_deuxdate.Size = new System.Drawing.Size(182, 26);
            this.rd_rech_deuxdate.TabIndex = 98;
            this.rd_rech_deuxdate.TabStop = true;
            this.rd_rech_deuxdate.Text = "Entrer deux date";
            this.rd_rech_deuxdate.UseVisualStyleBackColor = true;
            this.rd_rech_deuxdate.CheckedChanged += new System.EventHandler(this.rd_rech_deuxdate_CheckedChanged);
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.BackColor = System.Drawing.Color.White;
            this.bt_rechercher.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_rechercher.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_rechercher.Location = new System.Drawing.Point(837, 117);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(224, 43);
            this.bt_rechercher.TabIndex = 95;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = false;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // picker_pardate_debut
            // 
            this.picker_pardate_debut.Location = new System.Drawing.Point(353, 78);
            this.picker_pardate_debut.Name = "picker_pardate_debut";
            this.picker_pardate_debut.Size = new System.Drawing.Size(328, 30);
            this.picker_pardate_debut.TabIndex = 97;
            // 
            // picker_deuxdate_fin
            // 
            this.picker_deuxdate_fin.Location = new System.Drawing.Point(351, 130);
            this.picker_deuxdate_fin.Name = "picker_deuxdate_fin";
            this.picker_deuxdate_fin.Size = new System.Drawing.Size(328, 30);
            this.picker_deuxdate_fin.TabIndex = 97;
            // 
            // txt_parfacture
            // 
            this.txt_parfacture.Location = new System.Drawing.Point(353, 32);
            this.txt_parfacture.Name = "txt_parfacture";
            this.txt_parfacture.Size = new System.Drawing.Size(326, 30);
            this.txt_parfacture.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1081, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_Imprimer
            // 
            this.bt_Imprimer.BackColor = System.Drawing.Color.White;
            this.bt_Imprimer.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_Imprimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_Imprimer.Location = new System.Drawing.Point(865, 639);
            this.bt_Imprimer.Name = "bt_Imprimer";
            this.bt_Imprimer.Size = new System.Drawing.Size(224, 43);
            this.bt_Imprimer.TabIndex = 99;
            this.bt_Imprimer.Text = "Imprimer";
            this.bt_Imprimer.UseVisualStyleBackColor = false;
            this.bt_Imprimer.Click += new System.EventHandler(this.bt_Imprimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "La listes des factures\r\n";
            // 
            // bt_premier
            // 
            this.bt_premier.BackColor = System.Drawing.Color.White;
            this.bt_premier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_premier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_premier.Location = new System.Drawing.Point(131, 693);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(160, 42);
            this.bt_premier.TabIndex = 125;
            this.bt_premier.Text = "<<";
            this.bt_premier.UseVisualStyleBackColor = false;
            // 
            // bt_precedent
            // 
            this.bt_precedent.BackColor = System.Drawing.Color.White;
            this.bt_precedent.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_precedent.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_precedent.Location = new System.Drawing.Point(349, 693);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(160, 42);
            this.bt_precedent.TabIndex = 124;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = false;
            // 
            // bt_suivant
            // 
            this.bt_suivant.BackColor = System.Drawing.Color.White;
            this.bt_suivant.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_suivant.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_suivant.Location = new System.Drawing.Point(571, 693);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(160, 42);
            this.bt_suivant.TabIndex = 122;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = false;
            // 
            // bt_dernier
            // 
            this.bt_dernier.BackColor = System.Drawing.Color.White;
            this.bt_dernier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_dernier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_dernier.Location = new System.Drawing.Point(792, 693);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(160, 42);
            this.bt_dernier.TabIndex = 123;
            this.bt_dernier.Text = ">>";
            this.bt_dernier.UseVisualStyleBackColor = false;
            // 
            // dgv_facture
            // 
            this.dgv_facture.AllowUserToAddRows = false;
            this.dgv_facture.AllowUserToDeleteRows = false;
            this.dgv_facture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facture.Location = new System.Drawing.Point(22, 415);
            this.dgv_facture.Name = "dgv_facture";
            this.dgv_facture.ReadOnly = true;
            this.dgv_facture.RowHeadersWidth = 62;
            this.dgv_facture.RowTemplate.Height = 28;
            this.dgv_facture.Size = new System.Drawing.Size(1067, 218);
            this.dgv_facture.TabIndex = 94;
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 782);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Imprimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_facture);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_rech_facture;
        private System.Windows.Forms.RadioButton rd_rech_date;
        private System.Windows.Forms.RadioButton rd_rech_deuxdate;
        private System.Windows.Forms.Button bt_rechercher;
        private System.Windows.Forms.DateTimePicker picker_pardate_debut;
        private System.Windows.Forms.DateTimePicker picker_deuxdate_fin;
        private System.Windows.Forms.TextBox txt_parfacture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Imprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
        private System.Windows.Forms.DataGridView dgv_facture;
    }
}