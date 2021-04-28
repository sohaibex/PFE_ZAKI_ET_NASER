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
    public partial class Medecin : Form
    {
        public Medecin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // desactiver l'joute si l'acces par acceil, et activer si l'acces par commande
        }
        // Methode de navigation
        int index;
        public void naviguer(int i)
        {
            txt_id_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][0].ToString();
            txt_nom_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][1].ToString();
            txt_adr_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][2].ToString();
            rd_par_nom.Checked = false;
            rd_par_id.Checked = false;
            txt_id_medecin.Enabled = false;
            txt_nom_medecin.Enabled = true;
            txt_adr_medecin.Enabled = true;
            bt_modifier.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Medecin_Load(object sender, EventArgs e)
        {
            // Remplissage de la table MEDECIN 
            Connexion.da = new SqlDataAdapter("select * from MEDECIN ", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "MEDECIN");

            // REMPLISSAGE DU DATAGRIDVIEW
            dgv_medecin.DataSource = Connexion.ds.Tables["MEDECIN"];
        }


        private void bt_premier_Click(object sender, EventArgs e)
        {
            // premier
            index = 0;
            naviguer(index);
        }

        private void bt_precedent_Click(object sender, EventArgs e)
        {
            //precedent
            if (index > 0)
            {
                index--;
                naviguer(index);
            }
        }
        private void bt_suivant_Click(object sender, EventArgs e)
        {
            //suivant
            if (index < Connexion.ds.Tables["MEDECIN"].Rows.Count - 1)
            {
                index++;
                naviguer(index);
            }
        }
        private void bt_dernier_Click(object sender, EventArgs e)
        {
            // dernier
            index = Connexion.ds.Tables["MEDECIN"].Rows.Count - 1;
            naviguer(index);

        }

        private void rd_par_id_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_par_id.Checked)
            {
                txt_id_medecin.Enabled = true;
                txt_adr_medecin.Enabled = false;
                txt_nom_medecin.Enabled = false;
            }
        }
        private void rd_par_nom_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_par_nom.Checked)
            {
                txt_id_medecin.Enabled = false;
                txt_adr_medecin.Enabled = false;
                txt_nom_medecin.Enabled = true;
            }
        }

        private void dgv_medecin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sélectionner a traver datagridview avec gestion de navigation

            for (int i = 0; i < Connexion.ds.Tables["MEDECIN"].Rows.Count; i++)
            {
                if (int.Parse(Connexion.ds.Tables["MEDECIN"].Rows[i][0].ToString()) == int.Parse(dgv_medecin.CurrentRow.Cells[0].Value.ToString()))
                {
                    txt_id_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][0].ToString();
                    txt_nom_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][1].ToString();
                    txt_adr_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][2].ToString();

                    txt_adr_medecin.Enabled = true;
                    index = i; // gestion de bouton de navigation
                }
            }

            rd_par_id.Checked = false;
            rd_par_nom.Checked = false;
        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            //recherche par Id:
            if (Connexion.ds.Tables.Contains("MEDECIN")) // Si la table existe deja il faut la supprimer
            {
                Connexion.ds.Tables["MEDECIN"].Clear();
            }
            //Remplissage de la table medecin
            Connexion.da = new SqlDataAdapter("select * from MEDECIN ", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "MEDECIN");
            int res = 0; // Pour tester l'existanse de medecin  ou non
            if (rd_par_id.Checked)
            {
                for (int i = 0; i < Connexion.ds.Tables["MEDECIN"].Rows.Count; i++)
                {
                    if (txt_id_medecin.Text == Connexion.ds.Tables["MEDECIN"].Rows[i][0].ToString())
                    {
                        txt_id_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][0].ToString();
                        txt_nom_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][1].ToString();
                        txt_adr_medecin.Text = Connexion.ds.Tables["MEDECIN"].Rows[i][2].ToString();

                        res = 1; // Affectation de resultat d'existance de medecin rechercher
                        txt_adr_medecin.Enabled = true;
                        txt_nom_medecin.Enabled = true;
                        txt_id_medecin.Enabled = false;
                        break;
                    }
                }
                if (res == 0)
                {
                    if (txt_id_medecin.Text == "")
                    {
                        MessageBox.Show("Il faut entrer le code de medecin pour faire la recherche", "Erreur");
                        bt_vider_Click(sender,e);
                    }
                    else
                    {
                        txt_id_medecin.Text = "";
                        MessageBox.Show("Le medecin que vous cherchez n'existe pas !", "Erreur");
                        bt_vider_Click(sender, e);
                    }
                }
            }
            // recherche par nom 
            int TEST = 0; // Pour tester l'existanse de medecin  ou non
            if (rd_par_nom.Checked)
            {
                if (Connexion.ds.Tables.Contains("RECH")) // Si la table existe deja il faut la supprimer
                {
                    Connexion.ds.Tables["RECH"].Clear();
                }
                Connexion.da = new SqlDataAdapter("select * from MEDECIN where nom_complet_medecin='" + txt_nom_medecin.Text+"'", Connexion.cnx);
                Connexion.da.Fill(Connexion.ds, "RECH");
                for (int i = 0; i < Connexion.ds.Tables["RECH"].Rows.Count; i++)
                {
                    if (txt_nom_medecin.Text == Connexion.ds.Tables["RECH"].Rows[i][1].ToString())
                    {

                        dgv_medecin.DataSource = Connexion.ds.Tables["RECH"];

                        TEST = 1; // Affectation de resultat d'existance de medecin rechercher
                        break;
                    }
                }
                if (TEST == 0)
                {
                    if (txt_nom_medecin.Text == "")
                    {
                        MessageBox.Show("Il faut entrer le nom de medecin pour faire la recherche", "Erreur");
                    }
                    else
                    {
                        txt_nom_medecin.Text = "";
                        MessageBox.Show("Le medecin que vous cherchez n'existe pas !", "Erreur");
                        txt_nom_medecin.Text = "";

                    }
                    bt_vider_Click(sender,e);
                }
              
            }
        }
        private void bt_modifier_Click(object sender, EventArgs e)
        {
            // modifie
            for (int i = 0; i < Connexion.ds.Tables["MEDECIN"].Rows.Count; i++)
            {
                if (txt_id_medecin.Text == Connexion.ds.Tables["MEDECIN"].Rows[i][0].ToString())
                {
                    Connexion.ds.Tables["MEDECIN"].Rows[i][1] = txt_nom_medecin.Text;
                    Connexion.ds.Tables["MEDECIN"].Rows[i][2] = txt_adr_medecin.Text;

                    SqlCommandBuilder cb = new SqlCommandBuilder(Connexion.da);
                    Connexion.da.Update(Connexion.ds, "MEDECIN");

                    MessageBox.Show("Le medecin a été bien modifier", "Réussi");
                    break;
                }
            }
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            // vider
            if (Connexion.ds.Tables.Contains("MEDECIN")) // Si la table existe deja il faut la supprimer
            {
                Connexion.ds.Tables["MEDECIN"].Clear();
            }
            // Remplissage de la table MEDECIN 
            Connexion.da = new SqlDataAdapter("select * from MEDECIN ", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "MEDECIN");

            // REMPLISSAGE DU DATAGRIDVIEW
            dgv_medecin.DataSource = Connexion.ds.Tables["MEDECIN"];

            txt_id_medecin.Text = "";
            txt_nom_medecin.Text = "";
            txt_adr_medecin.Text = "";
            rd_par_nom.Checked = false;
            rd_par_id.Checked = false;
            txt_id_medecin.Enabled = false;
            txt_nom_medecin.Enabled = true;
            txt_adr_medecin.Enabled = true;
        }

        private void rd_par_id_Click(object sender, EventArgs e)
        {
            bt_vider_Click(sender, e);
            rd_par_id.Checked = true;
        }

        private void rd_par_nom_Click(object sender, EventArgs e)
        {
            bt_vider_Click(sender, e);
            rd_par_nom.Checked = true;
        }
    }
}
