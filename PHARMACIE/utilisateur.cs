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
    public partial class utilisateur : Form
    {
        public utilisateur()
        {
            InitializeComponent();
        }
        // NAVIGUER
        int index = 0;
        public void naviguer(int i)
        {
            txt_id_utilisateur.Text     = Connexion.ds.Tables["UTILISATEUR"].Rows[i][0].ToString();
            txt_nom_utilisateur.Text    = Connexion.ds.Tables["UTILISATEUR"].Rows[i][1].ToString();
            txt_prenom_utilisateur.Text = Connexion.ds.Tables["UTILISATEUR"].Rows[i][2].ToString();
            txt_adr_utilisateur.Text    = Connexion.ds.Tables["UTILISATEUR"].Rows[i][3].ToString();
            txt_tel_utilisateur.Text    = Connexion.ds.Tables["UTILISATEUR"].Rows[i][4].ToString();
            txt_AppId_utilisateur.Text  = Connexion.ds.Tables["UTILISATEUR"].Rows[i][5].ToString();
            txt_mdps_utilisateur.Text   = Connexion.ds.Tables["UTILISATEUR"].Rows[i][6].ToString();
        }

        //VIDER
        public void vider()
        {

            txt_id_utilisateur.Text = "";
            txt_nom_utilisateur.Text = "";
            txt_prenom_utilisateur.Text = "";
            txt_adr_utilisateur.Text = "";
            txt_tel_utilisateur.Text = "";
            txt_AppId_utilisateur.Text = "";
            txt_mdps_utilisateur.Text = "";

            txt_id_utilisateur.Enabled = false;
            txt_nom_utilisateur.Enabled = true;
            txt_prenom_utilisateur.Enabled = true;
            txt_adr_utilisateur.Enabled = true;
            txt_tel_utilisateur.Enabled = true;
            txt_AppId_utilisateur.Enabled = false;
            txt_mdps_utilisateur.Enabled = true;


            if (Connexion.ds.Tables.Contains("UTILISATEUR"))
                Connexion.ds.Tables["UTILISATEUR"].Rows.Clear();

            if (Connexion.ds.Tables.Contains("RES"))
                Connexion.ds.Tables["RES"].Rows.Clear();

            Connexion.da = new SqlDataAdapter("select * from UTILISATEUR", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "UTILISATEUR");


          

            bt_ajouter.Enabled = true;
         
            rd_par_id.Checked = false;
            rd_par_nom.Checked = false;

         
          
            dgv_utilisateur.DataSource = Connexion.ds.Tables["UTILISATEUR"];

        }


        private void utilisateur_Load(object sender, EventArgs e)
        {
            
            // charger le formulaire
            Connexion.da = new SqlDataAdapter("select * from UTILISATEUR", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "UTILISATEUR");
            dgv_utilisateur.DataSource = Connexion.ds.Tables["UTILISATEUR"];
           
            //vider();
            txt_id_utilisateur.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void bt_premier_Click(object sender, EventArgs e)
        {
            // premier
            index = 0;
            naviguer(index);

            bt_ajouter.Enabled = false;
        }
        private void bt_dernier_Click(object sender, EventArgs e)
        {
            // dernier
            index = Connexion.ds.Tables["UTILISATEUR"].Rows.Count-1;
            naviguer(index);
            bt_ajouter.Enabled = false;
        }
        private void bt_precedent_Click(object sender, EventArgs e)
        {
            // precedent
            if(index>0)
            {
                index--; 
                naviguer(index);
                bt_ajouter.Enabled = false;

            }
        }
        private void bt_suivant_Click(object sender, EventArgs e)
        {
            // suivant
            if (index < Connexion.ds.Tables["UTILISATEUR"].Rows.Count - 1)
            {
                index++;
                naviguer(index);
                bt_ajouter.Enabled = false;
            }
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            // ajouter utilisateur

            if (txt_nom_utilisateur.Text != "" && txt_mdps_utilisateur.Text != "" && txt_prenom_utilisateur.Text != "" && txt_tel_utilisateur.Text != "" && txt_adr_utilisateur.Text != "")
            {
                bool Verifier = false;
                for (int i = 0; i < Connexion.ds.Tables["UTILISATEUR"].Rows.Count; i++)
                {
                    if (txt_id_utilisateur.Text == Connexion.ds.Tables["UTILISATEUR"].Rows[i][0].ToString())
                    {
                        MessageBox.Show("utilisateur existe déja.");
                        Verifier = true;

                    }
                }
                if (!Verifier)
                {
                    int idres = Connexion.ds.Tables["UTILISATEUR"].Rows.Count;

                    DataRow drow = Connexion.ds.Tables["UTILISATEUR"].NewRow();
                    drow[0] = idres + 1;
                    drow[1] = txt_nom_utilisateur.Text;
                    drow[2] = txt_prenom_utilisateur.Text;
                    drow[3] = txt_adr_utilisateur.Text;
                    drow[4] = int.Parse(txt_tel_utilisateur.Text);
                    drow[5] = "EMPLOYE";
                    drow[6] = txt_mdps_utilisateur.Text;
                    Connexion.ds.Tables["UTILISATEUR"].Rows.Add(drow);

                    // SAUVGARDER
                    SqlCommandBuilder cb = new SqlCommandBuilder(Connexion.da);
                    Connexion.da.Update(Connexion.ds, "UTILISATEUR");
                    MessageBox.Show("l'ajout est effectué avec succés.");
                    idres++;
                    txt_id_utilisateur.Text = idres.ToString();
                }

            }
            else
                MessageBox.Show("veuillez remplire tous les champs");
    
        }
        private void bt_modifier_Click(object sender, EventArgs e)
        {
            //  modifier utilisateur
            try
            {
                for (int i = 0; i < Connexion.ds.Tables["UTILISATEUR"].Rows.Count; i++)
                {
                    if (txt_id_utilisateur.Text == Connexion.ds.Tables["UTILISATEUR"].Rows[i][0].ToString())
                    {
                        Connexion.ds.Tables["UTILISATEUR"].Rows[i][1] = txt_nom_utilisateur.Text;
                        Connexion.ds.Tables["UTILISATEUR"].Rows[i][2] = txt_prenom_utilisateur.Text;
                        Connexion.ds.Tables["UTILISATEUR"].Rows[i][3] = txt_adr_utilisateur.Text;
                        Connexion.ds.Tables["UTILISATEUR"].Rows[i][4] = int.Parse(txt_tel_utilisateur.Text);
                        Connexion.ds.Tables["UTILISATEUR"].Rows[i][5] = txt_AppId_utilisateur.Text;
                        Connexion.ds.Tables["UTILISATEUR"].Rows[i][6] = txt_mdps_utilisateur.Text;

                    }
                }
                // SAUVGARDER
                SqlCommandBuilder cb = new SqlCommandBuilder(Connexion.da);
                Connexion.da.Update(Connexion.ds, "UTILISATEUR");
                MessageBox.Show("Information d'utilisateur est bien modifiée");
                
            }
            catch
            {
                MessageBox.Show("Erreur de la modification");
            }
        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {

            // recherche
            // Par id
            bool test = false;
            if (Connexion.ds.Tables.Contains("UTILISATEUR"))
                Connexion.ds.Tables["UTILISATEUR"].Rows.Clear();

            Connexion.da = new SqlDataAdapter("select * from UTILISATEUR ", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "UTILISATEUR");

            if (rd_par_id.Checked)
            {

                for (int i = 0; i < Connexion.ds.Tables["UTILISATEUR"].Rows.Count; i++)
                {

                    if (txt_id_utilisateur.Text == Connexion.ds.Tables["UTILISATEUR"].Rows[i][0].ToString())
                    {
                        txt_id_utilisateur.Text = Connexion.ds.Tables["UTILISATEUR"].Rows[i][0].ToString();
                        txt_nom_utilisateur.Text = Connexion.ds.Tables["UTILISATEUR"].Rows[i][1].ToString();
                        txt_prenom_utilisateur.Text = Connexion.ds.Tables["UTILISATEUR"].Rows[i][2].ToString();
                        txt_adr_utilisateur.Text = Connexion.ds.Tables["UTILISATEUR"].Rows[i][3].ToString();
                        txt_tel_utilisateur.Text = Connexion.ds.Tables["UTILISATEUR"].Rows[i][4].ToString();
                        txt_AppId_utilisateur.Text = Connexion.ds.Tables["UTILISATEUR"].Rows[i][5].ToString();
                        txt_mdps_utilisateur.Text = Connexion.ds.Tables["UTILISATEUR"].Rows[i][6].ToString();
                        bt_ajouter.Enabled = false;
                        test = true;

                        txt_id_utilisateur.Enabled = false;
                        txt_nom_utilisateur.Enabled = true;
                        txt_prenom_utilisateur.Enabled = true;
                        txt_adr_utilisateur.Enabled = true;
                        txt_tel_utilisateur.Enabled = true;
                        txt_AppId_utilisateur.Enabled = false;
                        txt_mdps_utilisateur.Enabled = true;


                    }
                }
                if (!test)
                {
           
                    MessageBox.Show("L'utilisateur introuvable.");
                    vider();
                    txt_id_utilisateur.Enabled = false;
                    txt_nom_utilisateur.Enabled = true;
                    txt_prenom_utilisateur.Enabled = true;
                    txt_adr_utilisateur.Enabled = true;
                    txt_tel_utilisateur.Enabled = true;
                    txt_AppId_utilisateur.Enabled = false;
                    txt_mdps_utilisateur.Enabled = true;

                }
            }
            // Par nom


            if (rd_par_nom.Checked)
            {


                if (Connexion.ds.Tables.Contains("RES"))
                    Connexion.ds.Tables["RES"].Rows.Clear();

                if (Connexion.ds.Tables.Contains("UTILISATEUR"))
                    Connexion.ds.Tables["UTILISATEUR"].Rows.Clear();


                Connexion.da = new SqlDataAdapter("select * from UTILISATEUR", Connexion.cnx);
                Connexion.da.Fill(Connexion.ds, "UTILISATEUR");

                Connexion.da = new SqlDataAdapter("select * from UTILISATEUR where nom_ut = '" + txt_nom_utilisateur.Text + "'", Connexion.cnx);
                Connexion.da.Fill(Connexion.ds, "RES");

                var ligne = int.Parse(Connexion.ds.Tables["RES"].Rows.Count.ToString());

                if (ligne == 1)
                {
                    txt_id_utilisateur.Text = Connexion.ds.Tables["RES"].Rows[0][0].ToString();
                    txt_prenom_utilisateur.Text = Connexion.ds.Tables["RES"].Rows[0][2].ToString();
                    txt_adr_utilisateur.Text = Connexion.ds.Tables["RES"].Rows[0][3].ToString();
                    txt_tel_utilisateur.Text = Connexion.ds.Tables["RES"].Rows[0][4].ToString();
                    txt_AppId_utilisateur.Text = Connexion.ds.Tables["RES"].Rows[0][5].ToString();
                    txt_mdps_utilisateur.Text = Connexion.ds.Tables["RES"].Rows[0][6].ToString();
                    bt_ajouter.Enabled = false;
                    dgv_utilisateur.DataSource = Connexion.ds.Tables["RES"];

                    txt_id_utilisateur.Enabled = false;
                    txt_nom_utilisateur.Enabled = true;
                    txt_prenom_utilisateur.Enabled = true;
                    txt_adr_utilisateur.Enabled = true;
                    txt_tel_utilisateur.Enabled = true;
                    txt_AppId_utilisateur.Enabled = false;
                    txt_mdps_utilisateur.Enabled = true;

                }

                else if (ligne > 1)
                {
                    {
                        txt_id_utilisateur.Text = "";
                        txt_nom_utilisateur.Text = "";
                        txt_prenom_utilisateur.Text = "";
                        txt_adr_utilisateur.Text = "";
                        txt_tel_utilisateur.Text = "";
                        txt_AppId_utilisateur.Text = "";
                        txt_mdps_utilisateur.Text = "";


                        dgv_utilisateur.DataSource = Connexion.ds.Tables["RES"];
                    }

                }
                else
                {
                    MessageBox.Show("Aucune utilisateur qui a çe nom");
                    vider();
                    txt_id_utilisateur.Enabled = false;
                    txt_nom_utilisateur.Enabled = true;
                    txt_prenom_utilisateur.Enabled = true;
                    txt_adr_utilisateur.Enabled = true;
                    txt_tel_utilisateur.Enabled = true;
                    txt_AppId_utilisateur.Enabled = false;
                    txt_mdps_utilisateur.Enabled = true;

                }

            }
        }
        private void dgv_utilisateur_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            vider();
            vider();
        }

        private void rd_par_id_CheckedChanged(object sender, EventArgs e)
        {
            txt_id_utilisateur.Enabled = true;
            txt_nom_utilisateur.Enabled = false;
            txt_prenom_utilisateur.Enabled = false;
            txt_adr_utilisateur.Enabled = false;
            txt_tel_utilisateur.Enabled = false;
            txt_AppId_utilisateur.Enabled = false;
            txt_mdps_utilisateur.Enabled = false;
        }

        private void rd_par_nom_CheckedChanged(object sender, EventArgs e)
        {
            txt_id_utilisateur.Enabled = false;
            txt_nom_utilisateur.Enabled = true;
            txt_prenom_utilisateur.Enabled = false;
            txt_adr_utilisateur.Enabled = false;
            txt_tel_utilisateur.Enabled = false;
            txt_AppId_utilisateur.Enabled = false;
            txt_mdps_utilisateur.Enabled = false;
        }

        private void rd_par_nom_Click(object sender, EventArgs e)
        {
            // Par nom
            vider();
            rd_par_nom.Checked = true;

                    txt_id_utilisateur.Enabled = false;
                    txt_nom_utilisateur.Enabled = true;
                    txt_prenom_utilisateur.Enabled = false;
                    txt_adr_utilisateur.Enabled = false;
                    txt_tel_utilisateur.Enabled = false;
                    txt_AppId_utilisateur.Enabled = false;
                    txt_mdps_utilisateur.Enabled = false;
        }

        private void rd_par_id_Click(object sender, EventArgs e)
        {
            vider();
            rd_par_id.Checked = true;

            txt_id_utilisateur.Enabled = true;
            txt_nom_utilisateur.Enabled = false;
            txt_prenom_utilisateur.Enabled = false;
            txt_adr_utilisateur.Enabled = false;
            txt_tel_utilisateur.Enabled = false;
            txt_AppId_utilisateur.Enabled = false;
            txt_mdps_utilisateur.Enabled = false;
        }
    }
}
