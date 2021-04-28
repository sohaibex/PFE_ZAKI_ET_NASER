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
    public partial class Gestion_medicament : Form
    {
        public Gestion_medicament()
        {
            InitializeComponent();
        }

        public static DataClasses1DataContext db = new DataClasses1DataContext();


        private int id_ut;  // Pour afficher l'utilisateur connecté

        public int Id_ut
        {
            get { return id_ut; }
            set { id_ut = value; }
        }
        // methode pour remplire dagatridview
        public void Dgv()
        {
            if (Connexion.ds.Tables.Contains("MEDICAMENT"))
                Connexion.ds.Tables["MEDICAMENT"].Rows.Clear();

            Connexion.da = new SqlDataAdapter("select * from MEDICAMENT where date_exp> getdate() ", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "MEDICAMENT");

            dgv_medicaments.DataSource = Connexion.ds.Tables["MEDICAMENT"];
        }
        int index;
        // naviguer
        void naviguer(int i)
        {
            txt_code_medicament.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][0].ToString();
            txt_nom_medicament.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][1].ToString();
            Picker_date_exp.Value = DateTime.Parse(Connexion.ds.Tables["MEDICAMENT"].Rows[i][4].ToString());
            txt_qte_en_stock.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][3].ToString();
            txt_prix_medicament.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][2].ToString();
            cmb_categ.SelectedValue = int.Parse(Connexion.ds.Tables["MEDICAMENT"].Rows[i][6].ToString());

            bt_ajouter.Enabled = false;
        }

        private void Gestion_medicament_Load(object sender, EventArgs e)
        {
 
        //    MessageBox.Show(Connexion.ac.Identifiant_ut.ToString());

            // charger le formulaire avec comboBox de la categorie
            cmb_categ.DataSource = db.CATEGORIE_DU_MEDICAMENT.ToList();
            cmb_categ.DisplayMember = "libelle_categ";
            cmb_categ.ValueMember = "code_categ";
            // APPEL DE LA METHODE POUR CHARGER LA DGV

            Dgv();
            vider();
            bt_ajouter.Enabled = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.Close();
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
            if (index < Connexion.ds.Tables["MEDICAMENT"].Rows.Count - 1)
            {
                index++;
                naviguer(index);
            }
        }

        private void bt_dernier_Click(object sender, EventArgs e)
        {
            // dernier
            index = Connexion.ds.Tables["MEDICAMENT"].Rows.Count - 1;
            naviguer(index);
        }


        public void vider()
        {
            txt_rech_code_medic.Text = "";
            txt_code_medicament.Text = "";
            Picker_date_exp.Value = DateTime.Now;
            txt_nom_medicament.Text = "";
            txt_prix_medicament.Text = "";
            txt_qte_en_stock.Text = "";
            bt_ajouter.Enabled = true;

        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            vider();
            Dgv();
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            // modifier medicament
            if (MessageBox.Show("vous voules vraiment modifiée ce medicament ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = int.Parse(txt_code_medicament.Text.ToString());
                var req = from MD in db.MEDICAMENT
                          where MD.code_medicament == i
                          select MD;
                foreach (var Md in req)
                {
                    Md.date_exp = Picker_date_exp.Value;
                    Md.prix = float.Parse(txt_prix_medicament.Text);
                    Md.nom_medicament = txt_nom_medicament.Text;
                    Md.qte_en_stock = int.Parse(txt_qte_en_stock.Text);
                    Md.code_categ = int.Parse(cmb_categ.SelectedValue.ToString());
                }
                db.SubmitChanges();
                MessageBox.Show("medicament modifiée");
                vider();
                Dgv();
            }
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            // supprimer medicament
            if (MessageBox.Show("vous êtes sur de supprimer ce medicament ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // verification commande
                int j = 0;
                var req1 = from v in db.COMMANDE
                          select v;
                foreach(var v in req1)
                {
                    if(v.code_medicament == int.Parse(txt_code_medicament.Text.ToString()))
                    {
                        MessageBox.Show("tu peux pas supprimer ce medicament.", "Erreur");
                        j = 1;
                    }
                }
                if(j==0)
                {
                    int i = int.Parse(txt_code_medicament.Text.ToString());
                    var req = from MD in db.MEDICAMENT
                              where MD.code_medicament == i
                              select MD;
                    foreach (var Md in req)
                    {
                        db.MEDICAMENT.DeleteOnSubmit(Md);
                    }
                    db.SubmitChanges();
                    MessageBox.Show("medicament supprimée");
                    Dgv();
                }
            }
        }
        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            // rechercher medicament
            bt_ajouter.Enabled = false;
            int j = 0;
            for (int i = 0; i < Connexion.ds.Tables["MEDICAMENT"].Rows.Count; i++)
            {
                if (txt_rech_code_medic.Text == Connexion.ds.Tables["MEDICAMENT"].Rows[i][0].ToString())
                {

                    txt_code_medicament.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][0].ToString();
                    Picker_date_exp.Value = DateTime.Parse(Connexion.ds.Tables["MEDICAMENT"].Rows[i][4].ToString());
                    txt_prix_medicament.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][2].ToString();
                    txt_nom_medicament.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][1].ToString();
                    txt_qte_en_stock.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][3].ToString();
                    cmb_categ.SelectedValue = int.Parse(Connexion.ds.Tables["MEDICAMENT"].Rows[i][6].ToString());
                    j = 1;
                }
            }
            if (j == 0)
            {
                if (Connexion.ds.Tables.Contains("rech"))
                {
                    Connexion.ds.Tables["rech"].Rows.Clear();
                }
                
                Connexion.da = new SqlDataAdapter("select * from MEDICAMENT where date_exp <= getdate() ", Connexion.cnx);
                Connexion.da.Fill(Connexion.ds, "rech");
                int k = 0;
                for (int i = 0; i < Connexion.ds.Tables["rech"].Rows.Count; i++)
                {
                    if (txt_rech_code_medic.Text == Connexion.ds.Tables["rech"].Rows[i][0].ToString())
                    {
                       k= 1;
                        break;
                    }
                   
                }
                if(k==0)
                {
                        MessageBox.Show("Medicament Introuvable!", "Erreur");
                }
                else
                {

                    MessageBox.Show("Medicament périmé!", "Erreur");
                }
                vider();
              
            }
            txt_rech_code_medic.Text = "";
        }

      
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            //AJOUTER MEDICAMENT
                if (txt_nom_medicament.Text != "" && txt_prix_medicament.Text != "" && Picker_date_exp.Value != null)
            {

                bool Verifier = false;
                for (int i = 0; i < Connexion.ds.Tables["MEDICAMENT"].Rows.Count; i++)
                {
                    if (txt_code_medicament.Text == Connexion.ds.Tables["MEDICAMENT"].Rows[i][0].ToString())
                    {
                        MessageBox.Show("Madicamnet existe déja.");
                        Verifier = true;

                    }
                }
                if (!Verifier)
                {
                    if (Connexion.ds.Tables.Contains("MEDICAMENT"))
                    {
                        Connexion.ds.Tables["MEDICAMENT"].Rows.Clear();
                    }

                    Connexion.da = new SqlDataAdapter("select * from MEDICAMENT ", Connexion.cnx);
                    Connexion.da.Fill(Connexion.ds, "MEDICAMENT");

                    int idres = Connexion.ds.Tables["MEDICAMENT"].Rows.Count-1;

                    int new_code_med = int.Parse(Connexion.ds.Tables["MEDICAMENT"].Rows[idres][0].ToString());

                    //Connexion.ds.Tables["MEDICAMENT"].Rows[idres][0]

                    MessageBox.Show(Connexion.M.Id_ut.ToString());
                    DataRow drow = Connexion.ds.Tables["MEDICAMENT"].NewRow();
                    drow[0] = new_code_med + 1;
                    drow[1] = txt_nom_medicament.Text;
                    drow[2] = txt_prix_medicament.Text;
                    drow[3] = "0"; 
                    drow[4] = DateTime.Parse(Picker_date_exp.Value.ToString());
                    drow[5] = Connexion.M.Id_ut.ToString();
                    drow[6] = cmb_categ.SelectedValue;
                
                    Connexion.ds.Tables["MEDICAMENT"].Rows.Add(drow);
                     
                    // SAUVGARDER
                 
                    SqlCommandBuilder cb = new SqlCommandBuilder(Connexion.da);
                    Connexion.da.Update(Connexion.ds, "MEDICAMENT");

                    MessageBox.Show("l'ajout est effectué avec succés.");
                }

            }
            else
            {
                MessageBox.Show("veuillez remplire tous les champs");
            }
        }

    }
}

