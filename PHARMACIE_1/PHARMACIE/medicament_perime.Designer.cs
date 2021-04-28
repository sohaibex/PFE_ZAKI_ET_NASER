
namespace PHARMACIE
{
    partial class medicament_perime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicament_perime));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_rech_medicamentCode = new System.Windows.Forms.RadioButton();
            this.rd_rech_medicamentNom = new System.Windows.Forms.RadioButton();
            this.cmb_nom_medic_perime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.txt_code_medic_perime = new System.Windows.Forms.TextBox();
            this.lb_code_medic_perime = new System.Windows.Forms.Label();
            this.dgv_medic_perime = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medic_perime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(413, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 36);
            this.label1.TabIndex = 56;
            this.label1.Text = "Médicaments Périmé";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(206, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 111);
            this.groupBox1.TabIndex = 55;
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
            this.groupBox2.Controls.Add(this.rd_rech_medicamentCode);
            this.groupBox2.Controls.Add(this.rd_rech_medicamentNom);
            this.groupBox2.Controls.Add(this.cmb_nom_medic_perime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bt_rechercher);
            this.groupBox2.Controls.Add(this.txt_code_medic_perime);
            this.groupBox2.Controls.Add(this.lb_code_medic_perime);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.groupBox2.Location = new System.Drawing.Point(56, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 138);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rd_rech_medicamentCode
            // 
            this.rd_rech_medicamentCode.AutoSize = true;
            this.rd_rech_medicamentCode.Font = new System.Drawing.Font("Britannic Bold", 9F);
            this.rd_rech_medicamentCode.Location = new System.Drawing.Point(494, 46);
            this.rd_rech_medicamentCode.Name = "rd_rech_medicamentCode";
            this.rd_rech_medicamentCode.Size = new System.Drawing.Size(209, 24);
            this.rd_rech_medicamentCode.TabIndex = 100;
            this.rd_rech_medicamentCode.TabStop = true;
            this.rd_rech_medicamentCode.Text = "Par code medicament";
            this.rd_rech_medicamentCode.UseVisualStyleBackColor = true;
            this.rd_rech_medicamentCode.CheckedChanged += new System.EventHandler(this.rd_rech_medicamentCode_CheckedChanged);
            // 
            // rd_rech_medicamentNom
            // 
            this.rd_rech_medicamentNom.AutoSize = true;
            this.rd_rech_medicamentNom.Font = new System.Drawing.Font("Britannic Bold", 9F);
            this.rd_rech_medicamentNom.Location = new System.Drawing.Point(494, 87);
            this.rd_rech_medicamentNom.Name = "rd_rech_medicamentNom";
            this.rd_rech_medicamentNom.Size = new System.Drawing.Size(206, 24);
            this.rd_rech_medicamentNom.TabIndex = 101;
            this.rd_rech_medicamentNom.TabStop = true;
            this.rd_rech_medicamentNom.Text = "Par nom medicament";
            this.rd_rech_medicamentNom.UseVisualStyleBackColor = true;
            this.rd_rech_medicamentNom.CheckedChanged += new System.EventHandler(this.rd_rech_medicamentNom_CheckedChanged);
            // 
            // cmb_nom_medic_perime
            // 
            this.cmb_nom_medic_perime.Enabled = false;
            this.cmb_nom_medic_perime.FormattingEnabled = true;
            this.cmb_nom_medic_perime.Location = new System.Drawing.Point(209, 84);
            this.cmb_nom_medic_perime.Name = "cmb_nom_medic_perime";
            this.cmb_nom_medic_perime.Size = new System.Drawing.Size(208, 30);
            this.cmb_nom_medic_perime.TabIndex = 99;
            this.cmb_nom_medic_perime.SelectedIndexChanged += new System.EventHandler(this.cmb_nom_medic_perime_SelectedIndexChanged);
            this.cmb_nom_medic_perime.SelectionChangeCommitted += new System.EventHandler(this.cmb_nom_medic_perime_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Medicament";
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.BackColor = System.Drawing.Color.White;
            this.bt_rechercher.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_rechercher.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_rechercher.Location = new System.Drawing.Point(802, 58);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(230, 42);
            this.bt_rechercher.TabIndex = 97;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = false;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // txt_code_medic_perime
            // 
            this.txt_code_medic_perime.Enabled = false;
            this.txt_code_medic_perime.Location = new System.Drawing.Point(209, 48);
            this.txt_code_medic_perime.Name = "txt_code_medic_perime";
            this.txt_code_medic_perime.Size = new System.Drawing.Size(207, 30);
            this.txt_code_medic_perime.TabIndex = 49;
            // 
            // lb_code_medic_perime
            // 
            this.lb_code_medic_perime.AutoSize = true;
            this.lb_code_medic_perime.BackColor = System.Drawing.Color.Transparent;
            this.lb_code_medic_perime.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_code_medic_perime.ForeColor = System.Drawing.Color.Black;
            this.lb_code_medic_perime.Location = new System.Drawing.Point(64, 48);
            this.lb_code_medic_perime.Name = "lb_code_medic_perime";
            this.lb_code_medic_perime.Size = new System.Drawing.Size(49, 20);
            this.lb_code_medic_perime.TabIndex = 48;
            this.lb_code_medic_perime.Text = "Code";
            // 
            // dgv_medic_perime
            // 
            this.dgv_medic_perime.AllowUserToAddRows = false;
            this.dgv_medic_perime.AllowUserToDeleteRows = false;
            this.dgv_medic_perime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_medic_perime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medic_perime.Location = new System.Drawing.Point(56, 381);
            this.dgv_medic_perime.Name = "dgv_medic_perime";
            this.dgv_medic_perime.ReadOnly = true;
            this.dgv_medic_perime.RowHeadersWidth = 62;
            this.dgv_medic_perime.RowTemplate.Height = 28;
            this.dgv_medic_perime.Size = new System.Drawing.Size(1038, 335);
            this.dgv_medic_perime.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 25);
            this.label4.TabIndex = 99;
            this.label4.Text = "La listes des médicaments périmés\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1079, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // medicament_perime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 782);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_medic_perime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "medicament_perime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicament_perime";
            this.Load += new System.EventHandler(this.medicament_perime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medic_perime)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_code_medic_perime;
        private System.Windows.Forms.Label lb_code_medic_perime;
        private System.Windows.Forms.Button bt_rechercher;
        private System.Windows.Forms.ComboBox cmb_nom_medic_perime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_medic_perime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rd_rech_medicamentCode;
        private System.Windows.Forms.RadioButton rd_rech_medicamentNom;
    }
}