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
    public partial class Categorie_medicament : Form
    {
        public Categorie_medicament()
        {
            InitializeComponent();
        }

        int index;
        int myvalue;


        public void naviguer(int i)
        {
            txt_code.Text = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][0].ToString();
            txt_nom.Text = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][1].ToString();
            bt_ajouter.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Categorie_medicament_Load(object sender, EventArgs e)
        {
            Connexion.da = new SqlDataAdapter("select * from CATEGORIE_DU_MEDICAMENT", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "CATEGORIE_DU_MEDICAMENT");

            myvalue = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows.Count + 1;

            dgv_categ_medicament.DataSource = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"];
            bt_ajouter.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                naviguer(index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows.Count - 1)
            {
                index++;
                naviguer(index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows.Count - 1;
            naviguer(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 0;
            naviguer(index);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            DataRow NR = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].NewRow();
            NR[0] = myvalue;
            NR[1] = txt_nom.Text;
            Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows.Add(NR);

            SqlCommandBuilder cb = new SqlCommandBuilder(Connexion.da);
            Connexion.da.Update(Connexion.ds, "CATEGORIE_DU_MEDICAMENT");

            MessageBox.Show("La Catégorie est ajouté avec succès", "Réussi");

            txt_code.Text = "";
            txt_nom.Text = "";
            txt_rech_code.Text = "";
            bt_ajouter.Enabled = true;
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows.Count; i++)
            {
                if (txt_code.Text == Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][0].ToString())
                {
                    Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][1] = txt_nom.Text;

                    SqlCommandBuilder cb = new SqlCommandBuilder(Connexion.da);
                    Connexion.da.Update(Connexion.ds, "CATEGORIE_DU_MEDICAMENT");

                    MessageBox.Show("La catégorie est bien été modifier", "Réussi");
                    bt_vider_Click(sender, e);
                    break;
                }
            }
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vous voullez vraiment supprimer la catégorie ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows.Count; i++)
                {
                    if (Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i].RowState.ToString() != "Deleted")
                    {
                        if (txt_code.Text == Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][0].ToString())
                        {
                            Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i].Delete();

                            SqlCommandBuilder cb = new SqlCommandBuilder(Connexion.da);
                            Connexion.da.Update(Connexion.ds, "CATEGORIE_DU_MEDICAMENT");

                            MessageBox.Show("La catégorie est bien été supprimé", "Réussi");
                            txt_code.Text = "";
                            txt_nom.Text = "";
                            txt_rech_code.Text = "";
                            bt_ajouter.Enabled = true;
                            break;
                        }
                    }
                }
            }
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            txt_code.Text = "";
            txt_nom.Text = "";
            txt_rech_code.Text = "";
            bt_ajouter.Enabled = true;
        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
          
            int j = 0;
            for (int i = 0; i < Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows.Count; i++)
            {
                if (txt_rech_code.Text == Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][0].ToString() || txt_rech_code.Text == Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][1].ToString())
                {
                    txt_code.Text = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][0].ToString();
                    txt_nom.Text = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][1].ToString();
                    bt_ajouter.Enabled = false;
                    j = 1;
                }
            }
            if (j == 0)
            {
                MessageBox.Show("Categorie Introuvable!", "Erreur");
            }
            txt_rech_code.Text = "";
        }



        private void dgv_categ_medicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_categ_medicament_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            for (int i = 0; i < Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows.Count; i++)
            {
                if (dgv_categ_medicament.CurrentRow.Cells[0].Value.ToString() == Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][0].ToString())
                {
                    txt_code.Text = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][0].ToString();
                    txt_nom.Text = Connexion.ds.Tables["CATEGORIE_DU_MEDICAMENT"].Rows[i][1].ToString();
                    bt_ajouter.Enabled = false;

                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_rech_code_Enter(object sender, EventArgs e)
        {
            bt_vider_Click(sender, e);
            bt_ajouter.Enabled = false;
        }
    }
}
