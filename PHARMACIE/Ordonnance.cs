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
    public partial class Ordonnance : Form
    {
        public Ordonnance()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Pharmacie;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SqlCommand cmd;

        int index = 0;
        int res = 0;
        int myvalue;

        // Fonction de navigation
        public void naviguer(int i)
        {
            txt_code_ordo.Text = ds.Tables["LOAD"].Rows[i][0].ToString();
            dateTimePicker1.Value = DateTime.Parse(ds.Tables["LOAD"].Rows[i][1].ToString());
            cmb_medecin.Text = ds.Tables["LOAD"].Rows[i][2].ToString();
            bt_modifier.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // affectation de numero d'ordonnance a la table facture 

            // if clicker autre fois exception, deja entrer

            // desactiver
           
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // cacher ordonnance et afficher commande
        }

        private void Ordonnance_Load(object sender, EventArgs e)
        {
            // Remplissage de la table MEDECIN et le remplissage du combo

            da = new SqlDataAdapter("select * from MEDECIN ", cnx);
            da.Fill(ds, "MEDECIN");
            cmb_medecin.DataSource = ds.Tables["MEDECIN"];
            cmb_medecin.DisplayMember = "nom_complet_medecin";
            cmb_medecin.ValueMember = "id_medecin";

            // Remplissage de la table Ordonnance et calcule des ordonnances

            da = new SqlDataAdapter("select * from ORDONNANCE ", cnx);
            da.Fill(ds, "ORDONNANCE");
            myvalue = ds.Tables["ORDONNANCE"].Rows.Count + 1;


            // REMPLISSAGE DU DATAGRIDVIEW à traver une jointure

            da = new SqlDataAdapter("select O.code_ord, O.date_consult, M.nom_complet_medecin from ORDONNANCE O inner join MEDECIN M on O.id_medecin = M.id_medecin", cnx);
            da.Fill(ds, "LOAD");
            dgv_ordonnance.DataSource = ds.Tables["LOAD"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < ds.Tables["LOAD"].Rows.Count - 1)
            {
                index++;
                naviguer(index);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_premier_Click(object sender, EventArgs e)
        {
            index = 0;
            naviguer(index);
        }

        private void bt_precedent_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                naviguer(index);
            }
        }

        private void bt_dernier_Click(object sender, EventArgs e)
        {
            index = ds.Tables["LOAD"].Rows.Count - 1;
            naviguer(index);
        }

        private void bt_continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commande cm = new Commande();
            cm.Show();
            // il faut la coder après venir du forme commande
        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            res = 0; // Pour voire est qui la trouver un ordonnance ou non

            if (ds.Tables.Contains("ORDONNANCE")) // Si la table existe deja il faut la supprimer
            {
                ds.Tables["ORDONNANCE"].Clear();
            }

            //Remplissage de la table ORDONNANCE
            da = new SqlDataAdapter("select * from ORDONNANCE ", cnx);
            da.Fill(ds, "ORDONNANCE");

            for (int i = 0; i < ds.Tables["ORDONNANCE"].Rows.Count; i++)
            {
                if (txt_code_rech.Text == ds.Tables["ORDONNANCE"].Rows[i][0].ToString())
                {
                    txt_code_rech.Text = "";
                    txt_code_ordo.Text = ds.Tables["ORDONNANCE"].Rows[i][0].ToString();
                    dateTimePicker1.Value = DateTime.Parse(ds.Tables["ORDONNANCE"].Rows[i][1].ToString());
                    cmb_medecin.Text = ds.Tables["LOAD"].Rows[i][2].ToString();

                    res = 1; // Affectation de resultat d'existance d'ordonnance rechercher
                    break;
                }
            }

            // Si la recherche fini par aucun ordonnance existe on va tester les champs si vide ou non existe
            if (res == 0)
            {
                if (txt_code_rech.Text == "")
                {
                    MessageBox.Show("Il faut entrer le code d'ordonnance pour faire la recherche", "Erreur");
                }
                else
                {
                    txt_code_rech.Text = "";
                    MessageBox.Show("L'ordonnance que vous cherchez n'existe pas", "Erreur");
                }
            }
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            // MODIFICATION D'UN ORDONNANCE

            string req = " update ORDONNANCE set date_consult= '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', id_medecin = " + cmb_medecin.SelectedValue + " where code_ord = " + txt_code_ordo.Text + " ";
            cmd = new SqlCommand(req, cnx);

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Modification done");

            // ACTUALISATION des données

            if (ds.Tables.Contains("LOAD"))
            {
                ds.Tables["LOAD"].Clear();
            }

            da = new SqlDataAdapter("select O.code_ord, O.date_consult, M.nom_complet_medecin from ORDONNANCE O inner join MEDECIN M on O.id_medecin = M.id_medecin", cnx);
            da.Fill(ds, "LOAD");
            dgv_ordonnance.DataSource = ds.Tables["LOAD"];
        }

        private void dgv_ordonnance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sélectionner a traver datagridview avec gestion de navigation

            for (int i = 0; i < ds.Tables["LOAD"].Rows.Count; i++)
            {
                if (int.Parse(ds.Tables["LOAD"].Rows[i][0].ToString()) == int.Parse(dgv_ordonnance.CurrentRow.Cells[0].Value.ToString()))
                {
                    txt_code_ordo.Text = ds.Tables["ORDONNANCE"].Rows[i][0].ToString();
                    dateTimePicker1.Value = DateTime.Parse(ds.Tables["ORDONNANCE"].Rows[i][1].ToString());
                    cmb_medecin.Text = ds.Tables["LOAD"].Rows[i][2].ToString();


                    index = i; // gestion de bouton de navigation
                }
            }
        }
    }
}
