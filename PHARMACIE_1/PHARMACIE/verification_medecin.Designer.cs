
namespace PHARMACIE
{
    partial class verification_medecin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_verification_code = new System.Windows.Forms.TextBox();
            this.txt_verification_nom = new System.Windows.Forms.TextBox();
            this.bt_verifier = new System.Windows.Forms.Button();
            this.rd_code = new System.Windows.Forms.RadioButton();
            this.rd_nom = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verification d\'existance du medecin";
            // 
            // txt_verification_code
            // 
            this.txt_verification_code.Location = new System.Drawing.Point(141, 74);
            this.txt_verification_code.Multiline = true;
            this.txt_verification_code.Name = "txt_verification_code";
            this.txt_verification_code.Size = new System.Drawing.Size(185, 26);
            this.txt_verification_code.TabIndex = 92;
            // 
            // txt_verification_nom
            // 
            this.txt_verification_nom.Location = new System.Drawing.Point(141, 121);
            this.txt_verification_nom.Multiline = true;
            this.txt_verification_nom.Name = "txt_verification_nom";
            this.txt_verification_nom.Size = new System.Drawing.Size(185, 26);
            this.txt_verification_nom.TabIndex = 93;
            // 
            // bt_verifier
            // 
            this.bt_verifier.BackColor = System.Drawing.Color.White;
            this.bt_verifier.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.bt_verifier.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_verifier.Location = new System.Drawing.Point(373, 89);
            this.bt_verifier.Name = "bt_verifier";
            this.bt_verifier.Size = new System.Drawing.Size(250, 40);
            this.bt_verifier.TabIndex = 96;
            this.bt_verifier.Text = "Verifier";
            this.bt_verifier.UseVisualStyleBackColor = false;
            this.bt_verifier.Click += new System.EventHandler(this.bt_verifier_Click);
            // 
            // rd_code
            // 
            this.rd_code.AutoSize = true;
            this.rd_code.Location = new System.Drawing.Point(21, 75);
            this.rd_code.Name = "rd_code";
            this.rd_code.Size = new System.Drawing.Size(100, 24);
            this.rd_code.TabIndex = 97;
            this.rd_code.TabStop = true;
            this.rd_code.Text = "Par Code";
            this.rd_code.UseVisualStyleBackColor = true;
            this.rd_code.CheckedChanged += new System.EventHandler(this.rd_code_CheckedChanged);
            // 
            // rd_nom
            // 
            this.rd_nom.AutoSize = true;
            this.rd_nom.Location = new System.Drawing.Point(21, 122);
            this.rd_nom.Name = "rd_nom";
            this.rd_nom.Size = new System.Drawing.Size(95, 24);
            this.rd_nom.TabIndex = 97;
            this.rd_nom.TabStop = true;
            this.rd_nom.Text = "Par Nom";
            this.rd_nom.UseVisualStyleBackColor = true;
            this.rd_nom.CheckedChanged += new System.EventHandler(this.rd_nom_CheckedChanged);
            // 
            // verification_medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 170);
            this.Controls.Add(this.rd_nom);
            this.Controls.Add(this.rd_code);
            this.Controls.Add(this.bt_verifier);
            this.Controls.Add(this.txt_verification_nom);
            this.Controls.Add(this.txt_verification_code);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verification_medecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verification_medecin";
            this.Load += new System.EventHandler(this.verification_medecin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_verification_code;
        private System.Windows.Forms.TextBox txt_verification_nom;
        private System.Windows.Forms.Button bt_verifier;
        private System.Windows.Forms.RadioButton rd_code;
        private System.Windows.Forms.RadioButton rd_nom;
    }
}