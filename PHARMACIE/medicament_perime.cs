using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARMACIE
{
    public partial class medicament_perime : Form
    {
        public medicament_perime()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        // dgv 
        public void Dgv()
        {
            
            DateTime DATESYSTEM = DateTime.Now;
            var req = from v in Gestion_medicament.db.MEDICAMENT
                      where v.date_exp < DATESYSTEM
                      select v;
            dgv_medic_perime.DataSource = req.ToList();
        }
        private void medicament_perime_Load(object sender, EventArgs e)
        {
          
            cmb_nom_medic_perime.DataSource = Gestion_medicament.db.MEDICAMENT;
            cmb_nom_medic_perime.DisplayMember = "nom_medicament";
            cmb_nom_medic_perime.ValueMember = "nom_medicament";
            Dgv();
           
        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            
            // recherche medicament perime
            // AVEC NOM MEDICAMENT
            if (rd_rech_medicamentNom.Checked)
            {
                DateTime DATESYSTEM1 = DateTime.Now;
                string combo = cmb_nom_medic_perime.SelectedValue.ToString();
                var req = from v in Gestion_medicament.db.MEDICAMENT
                          where v.date_exp < DATESYSTEM1 && v.nom_medicament == combo.ToString()
                          select v;
               int test = int.Parse(req.Count().ToString());
                if(test >=1)
                {
                    dgv_medic_perime.DataSource = req.ToList();
                    
                }
                else
                {
                    MessageBox.Show("medicament introuvable");
                   
                  
                    Dgv();
                }
               
            }
            // AVEC ID MEDICAMENT
            if (rd_rech_medicamentCode.Checked)
            {
                DateTime DATESYSTEM1 = DateTime.Now;
                int I = int.Parse(txt_code_medic_perime.Text);
                var req1 = from v in Gestion_medicament.db.MEDICAMENT
                           where v.date_exp < DATESYSTEM1 && v.code_medicament == I
                           select v;
                int test = int.Parse(req1.Count().ToString());
                if (test >= 1)
                {
                    dgv_medic_perime.DataSource = req1.ToList();
                }
                else
                {
                    MessageBox.Show("medicament introuvable");
                    txt_code_medic_perime.Text = "";
                    Dgv();

                }
            }

        }

        private void cmb_nom_medic_perime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rd_rech_medicamentNom_CheckedChanged(object sender, EventArgs e)
        {
            txt_code_medic_perime.Enabled = false;
            cmb_nom_medic_perime.Enabled = true;
            txt_code_medic_perime.Text= "";
        }

        private void rd_rech_medicamentCode_CheckedChanged(object sender, EventArgs e)
        {
            txt_code_medic_perime.Enabled = true;
            cmb_nom_medic_perime.Enabled = false;
            
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_nom_medic_perime_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
    }
}
