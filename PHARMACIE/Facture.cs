using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 
namespace PHARMACIE
{
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }
        public static Accueil ac = new Accueil();
        public static COMMANDE Fcmd = new COMMANDE();// POUR ACCEDER A LA VALEUR TEST_F
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            Connexion.da = new SqlDataAdapter("select * from FACTURE ", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "FACTURE");

            dgv_facture.DataSource = Connexion.ds.Tables["FACTUER"];

            Connexion.da = new SqlDataAdapter("select * from FACTURE ", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "FACTURE");

            dgv_facture.DataSource = Connexion.ds.Tables["FACTURE"];

            //if (ac.Test_fact ==0)
            //{
            //    dgv_facture.DataSource = Connexion.ds.Tables["FACTUER"];
            //}

        }
        public void naviguer(int  i)
        {
            Connexion.da = new SqlDataAdapter("select * from FACTURE where", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "FACTURE");
        }
        private void rd_rech_facture_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_rech_facture.Checked)
            {
                picker_pardate_debut.Enabled = false;
                picker_deuxdate_fin.Enabled = false;
                txt_parfacture.Enabled = true;
            }
        }

        private void rd_rech_date_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_rech_date.Checked)
            {
                txt_parfacture.Enabled = false;
                picker_deuxdate_fin.Enabled = false;
                picker_pardate_debut.Enabled = true;
            }
        }

        private void rd_rech_deuxdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_rech_deuxdate.Checked)
            {
                txt_parfacture.Enabled = false;
                picker_deuxdate_fin.Enabled = true;
                picker_pardate_debut.Enabled = true;
            }
        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            if(rd_rech_facture.Checked)
            {

            }
        }

        private void bt_Imprimer_Click(object sender, EventArgs e)
        {
            //SELECTION D
        }

   
    }
}
