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
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();
        }
        // methode qui remplie dataGridView
        public void Dgv()
        {
            var req = from v in Gestion_medicament.db.FOURNISSEUR select v;
            dgv_fournisseur.DataSource = req.ToList();
        }
        // methode avtice desactive Button ajouter
        public void AjouterAvtiveDesactive()
        {
            if(txt_id_fournisseur.Text =="")
            {
                bt_ajouter.Enabled = true;
            }
            else
            {
                bt_ajouter.Enabled = false;
            }

        }
        private void Fournisseur_Load(object sender, EventArgs e)
        {
            AjouterAvtiveDesactive();
            Dgv();
            bt_ajouter.Enabled = true;
        }

        int index;
        // naviguer
        void naviguer(int i)
        {

            txt_id_fournisseur.Text = Gestion_medicament.db.FOURNISSEUR.ToList()[i].id_fournisseur.ToString();
            txt_nom_fournisseur.Text = Gestion_medicament.db.FOURNISSEUR.ToList()[i].nom_f.ToString();
            txt_prenom_fournisseur.Text = Gestion_medicament.db.FOURNISSEUR.ToList()[i].prenom_f.ToString();
            txt_tel_fournisseur.Text = Gestion_medicament.db.FOURNISSEUR.ToList()[i].tel_f.ToString();
            txt_adr_fournisseur.Text = Gestion_medicament.db.FOURNISSEUR.ToList()[i].adresse_f.ToString();

            bt_ajouter.Enabled = false;
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
           
            // bouton rechercher
            // VERIVIER LE TYPE DE TXT_RECH_FOURNISSEUR
            if (txt_id_rech_fournisseur.Text != "")
            {
                int j = 0;
                int n = 0;
                string tst = txt_id_rech_fournisseur.Text;
                if (tst.Trim() == "")
                {
                    //Pour Supprime toutes les instances de début et de fin d'un caractère de la chaîne actuelle.  
                    return;
                } 
                for (int i = 0; i < tst.Length; i++)
                {
                    if (!char.IsNumber(tst[i]))
                    {
                        n++;
                    }
                }
                if (n > 0)
                {
                    // recherche par nom :

                       // recherche le nombre de nom 
                    var Nombre = (from v in Gestion_medicament.db.FOURNISSEUR select v.nom_f).Count();

                    string NOM = Convert.ToString(txt_id_rech_fournisseur.Text.ToString());
                    var Req = from v in Gestion_medicament.db.FOURNISSEUR
                               where v.nom_f == Convert.ToString(txt_id_rech_fournisseur.Text.ToString())
                              select v;
                    foreach (var i in Req)
                    {
                        if(int.Parse(Nombre.ToString()) > 1)
                        {
                            dgv_fournisseur.DataSource = Req.ToList();
                        }
                        else
                        {
                            var Dgv = from v in Gestion_medicament.db.FOURNISSEUR select v;

                            dgv_fournisseur.DataSource = Dgv.ToList();

                            txt_id_fournisseur.Text = i.id_fournisseur.ToString();
                            txt_nom_fournisseur.Text = i.nom_f.ToString();
                            txt_prenom_fournisseur.Text = i.prenom_f.ToString();
                            txt_tel_fournisseur.Text = i.tel_f.ToString();
                            txt_adr_fournisseur.Text = i.adresse_f.ToString();

                        }
                        j = 1;
                    }
                }
                else
                {
                    // recherche par Id :
                    int ID = int.Parse(txt_id_rech_fournisseur.Text);

                    var Req = from v in Gestion_medicament.db.FOURNISSEUR
                              where v.id_fournisseur == int.Parse(txt_id_rech_fournisseur.Text)
                              select v;
                    foreach (var i in Req)
                    {
                        txt_id_fournisseur.Text = i.id_fournisseur.ToString();
                        txt_nom_fournisseur.Text = i.nom_f.ToString();
                        txt_prenom_fournisseur.Text = i.prenom_f.ToString();
                        txt_tel_fournisseur.Text = i.tel_f.ToString();
                        txt_adr_fournisseur.Text = i.adresse_f.ToString();
                    
                        dgv_fournisseur.DataSource = Req.ToList();

                        j = 2;
                    }
              
                }
                if (j == 0)
                {
                    MessageBox.Show("Fournisseur Introuvable!", "Erreur");

                    txt_id_rech_fournisseur.Text = "";
                    Vider();
                    Dgv();
                    
                }
                txt_id_rech_fournisseur.Text = "";
                AjouterAvtiveDesactive();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //precedent
            if (index > 0)
            {
                index--;
                naviguer(index);
            }
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

        private void bt_suivant_Click(object sender, EventArgs e)
        {
            //suivant
            if (index < Gestion_medicament.db.FOURNISSEUR.ToList().Count - 1)
            {
                index++;
                naviguer(index);
            }
        }

        private void bt_dernier_Click(object sender, EventArgs e)
        {
            // dernier
            index = Gestion_medicament.db.FOURNISSEUR.ToList().Count - 1;
            naviguer(index);
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_nom_fournisseur.Text != "" && txt_prenom_fournisseur.Text != "" && txt_tel_fournisseur.Text != "" && txt_adr_fournisseur.Text != "")
            {
                int K = 0;
                if (txt_id_fournisseur.Text != "")
                {
                    var Req1 = from v in Gestion_medicament.db.FOURNISSEUR
                               where v.id_fournisseur == int.Parse(txt_id_fournisseur.Text.ToString())
                               select v;
                    foreach (var v in Req1)
                    {
                        if (txt_id_fournisseur.Text == v.id_fournisseur.ToString())
                        {
                            MessageBox.Show("le fournisseur existe deja");
                            K = 1;
                            break;
                        }
                    }
                }

                if (K == 0)
                {
                    int codeF;
                    var req = (from v in Gestion_medicament.db.FOURNISSEUR select v).Count();
                    codeF = int.Parse(req.ToString());

                    FOURNISSEUR F = new FOURNISSEUR();
                    F.id_fournisseur = codeF + 1;
                    F.nom_f = txt_nom_fournisseur.Text;
                    F.prenom_f = txt_prenom_fournisseur.Text;
                    F.tel_f = int.Parse(txt_tel_fournisseur.Text);
                    F.adresse_f = txt_adr_fournisseur.Text;
                    Gestion_medicament.db.FOURNISSEUR.InsertOnSubmit(F);
                    Gestion_medicament.db.SubmitChanges();
                    MessageBox.Show("Fournisseur ajoutée");

                    codeF++;
                    txt_id_fournisseur.Text = codeF.ToString();

                    Vider();
                    Dgv();
                    
                }
               
            }
            else
            {
                MessageBox.Show(" les champs ils sont vide.");
            }
            
        }
       
        private void bt_annuler_Click(object sender, EventArgs e)
        {
            Vider();
            bt_ajouter.Enabled = true;
            Dgv();

        }
        // vider
        public void Vider()
        {
            txt_id_fournisseur.Text = "";
            txt_nom_fournisseur.Text = "";
            txt_prenom_fournisseur.Text = "";
            txt_tel_fournisseur.Text = "";
            txt_adr_fournisseur.Text = "";

            txt_id_rech_fournisseur.Text = "";
          

        }
        private void bt_modifier_Click(object sender, EventArgs e)
        {
            // modifier fournisseur
            if (MessageBox.Show("vous voules vraiment modifiée ce fournisseur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = int.Parse(txt_id_fournisseur.Text.ToString());
                var req = from F in Gestion_medicament.db.FOURNISSEUR
                          where F.id_fournisseur == i
                          select F;
                foreach (var F in req)
                {
                    F.nom_f = txt_nom_fournisseur.Text;
                    F.prenom_f = txt_prenom_fournisseur.Text;
                    F.tel_f = int.Parse(txt_tel_fournisseur.Text);
                    F.adresse_f = txt_adr_fournisseur.Text;
                }
                Gestion_medicament.db.SubmitChanges();
                MessageBox.Show("medicament modifiée");
                Vider();
                Dgv();
            
            }
            bt_ajouter.Enabled = true;
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            // supprimer fournisseur
            if (MessageBox.Show("vous voules vraiment supprimer ce fournisseur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int i = int.Parse(txt_id_fournisseur.Text.ToString());
                var req = from F in Gestion_medicament.db.FOURNISSEUR
                          where F.id_fournisseur == i
                          select F;
                foreach (var F in req)
                {
                    Gestion_medicament.db.FOURNISSEUR.DeleteOnSubmit(F);
                }
                Gestion_medicament.db.SubmitChanges();
                MessageBox.Show("suppresion avec succées");
                Vider();
                Dgv();
            
            }
            bt_ajouter.Enabled = true;
        }

        private void dgv_fournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                var clickDGV = from v in Gestion_medicament.db.FOURNISSEUR
                               where v.id_fournisseur == int.Parse(dgv_fournisseur.CurrentRow.Cells[0].Value.ToString())
                               select v;
                foreach (var i in clickDGV)
                {
                    txt_id_fournisseur.Text = i.id_fournisseur.ToString();
                    txt_nom_fournisseur.Text = i.nom_f.ToString();
                    txt_prenom_fournisseur.Text = i.prenom_f.ToString();
                    txt_tel_fournisseur.Text = i.tel_f.ToString();
                    txt_adr_fournisseur.Text = i.adresse_f.ToString();
                }
            AjouterAvtiveDesactive();
        }

        private void txt_id_rech_fournisseur_Enter(object sender, EventArgs e)
        {
            Vider();
            Dgv();
        }
    }
}
