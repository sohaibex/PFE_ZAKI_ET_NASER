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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        SqlCommand cmd;

        private int identifiant_ut;  // Pour afficher l'utilisateur connecté

        public int Identifiant_ut
        {
            get { return identifiant_ut; }
            set { identifiant_ut = value; }
        }

        private int test_fact;  //POUR TESTER LOAD DU FACTURE
        public int Test_fact
        {
            get { return test_fact; }
            set { test_fact = value; }
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;

            // Récupération des infos d'utilisateur connecté pour les affichers 

            Connexion.da = new SqlDataAdapter("select * from UTILISATEUR where id_utilisateur = " +identifiant_ut + "", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "active");

            txt_nom.Text = Connexion.ds.Tables["active"].Rows[0][1].ToString();
            txt_prenom.Text = Connexion.ds.Tables["active"].Rows[0][2].ToString();
            txt_identifiant.Text = Connexion.ds.Tables["active"].Rows[0][5].ToString();


            if (Connexion.ds.Tables["active"].Rows[0][5].ToString() == "EMPLOYE")
            {
                utilisateurToolStripMenuItem.Enabled = false;
            }


            // activation du strip UTILISATEUR if ( ds.tables.rows[varibable_acceil+1][identifiant] == "admin "
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorie_medicament Fmc = new Categorie_medicament();
            Fmc.Show();
            
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Recuperation des codes facture pour insere une nouvelle facture avant la commande

            int CNT;
            cmd = new SqlCommand("select count (*) from FACTURE", Connexion.cnx);
            Connexion.cnx.Open();
            CNT = int.Parse(cmd.ExecuteScalar().ToString());
            Connexion.cnx.Close();
            CNT = CNT + 2;
            MessageBox.Show(""+ identifiant_ut +"");
            // AJOUTE
            string req = "insert into FACTURE values (" + CNT + ",GETDATE(),0," + identifiant_ut + ",null)";
            cmd = new SqlCommand(req, Connexion.cnx);

            Connexion.cnx.Open();
            cmd.ExecuteNonQuery();
            Connexion.cnx.Close();

            Commande Fc = new Commande();
            Fc.Show();

        }

        private void bt_deconnexion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("vous voules vraiment se deconnecté ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connexion Fco = new Connexion();
                Fco.Show();
                this.Hide();
            }
            else
                return;
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilisateur Fu = new utilisateur();
            Fu.Show();
        }

        private void medicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void medicamentPerimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_medicament Fm = new Gestion_medicament();
            Fm.Show();
        }

        private void périméToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicament_perime Fmp = new medicament_perime();
            Fmp.Show();
        }

        private void fornisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fournisseur Ffr = new Fournisseur();
            Ffr.Show();
           
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock Fs = new Stock();
            Fs.Show();
        }

        private void medecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medecin Fmd = new Medecin();
            Fmd.Show();
        }

        private void factureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OUVERTURE DU FORMULAIRE FACTURE 
            test_fact = 0; // POUR TESTER 
            Facture FF = new Facture();
            FF.Show();
        }

        private void ordonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordonnance FOr = new Ordonnance();
            FOr.Show();
        }
    }
}
