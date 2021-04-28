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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        public static SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Pharmacie;Integrated Security=True");
        public static SqlDataAdapter da;
        public static DataSet ds = new DataSet();
        public static int id_ut = 0; // Pour recupéré le id d'utilisateur
        public static Accueil ac = new Accueil();
        public static Gestion_medicament M = new Gestion_medicament();


        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from UTILISATEUR  ", cnx);
            da.Fill(ds, "UTILISATEUR");


            cmb_utilisateur.Items.Add("EMPLOYE");
            cmb_utilisateur.Items.Add("ADMIN");

            lb_erreur.Hide();
            lb_vide.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        { 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_affichage_mdps.Checked)
            {
                txt_mdps.UseSystemPasswordChar = false;
            }
            else
            {
                txt_mdps.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* Boucle de verification d'utilisateur et le mot de passe avec récuperation d'id d'utilisateur 
            * pour le affecter dans les commandes et les factures et les medicaments qui vont 
            * être ajouter etc 

            *  Ouverture du forme d'acceuil 
            */

            lb_erreur.Hide();

            for (var i = 0; i < ds.Tables["UTILISATEUR"].Rows.Count; i++)
            {
                if (cmb_utilisateur.SelectedItem.ToString() == ds.Tables["UTILISATEUR"].Rows[i][5].ToString())
                {
                    // Mot de passe incorrect ou vide

                    if (txt_mdps.Text != ds.Tables["UTILISATEUR"].Rows[i][6].ToString())
                    {
                        if (txt_mdps.Text == "")
                        {
                            lb_erreur.Text = "Veuillez saisir votre mot de passe";
                            lb_erreur.Show();
                        }
                        else
                        {
                            lb_erreur.Text = "Le mot de passe est incorrect.";
                            lb_erreur.Show();
                            txt_mdps.Text = "";
                        }
                    }

                    // Mot de passe Correct 

                    if (txt_mdps.Text == ds.Tables["UTILISATEUR"].Rows[i][6].ToString())
                    {
                        Accueil ac = new Accueil();
                        ac.Identifiant_ut = int.Parse(ds.Tables["UTILISATEUR"].Rows[i][0].ToString());
                        M.Id_ut = int.Parse(ds.Tables["UTILISATEUR"].Rows[i][0].ToString());
                        ac.Show();


                        this.Hide();
                    }
                }

            }
        }

        private void cmb_utilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_erreur.Hide();
            lb_vide.Hide();

        }
    }
}
