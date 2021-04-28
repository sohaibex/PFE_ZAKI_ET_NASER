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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        // DGV 
        public void dgv()
        {
            if (Connexion.ds.Tables.Contains("STOCK"))
            {
                Connexion.ds.Tables["STOCK"].Clear();
            }

            Connexion.da = new SqlDataAdapter("select * from STOCK", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds,"STOCK");
            dgv_stock.DataSource = Connexion.ds.Tables["STOCK"];

            //var req = from v in Gestion_medicament.db.STOCK
            //          select new
            //          {
            //              v.code_stock,
            //              v.qte_entre,
            //              v.date_entre,
            //              v.MEDICAMENT.nom_medicament,
            //              v.FOURNISSEUR.nom_f,
            //              v.FOURNISSEUR.prenom_f
            //          };
            //dgv_stock.DataSource = req.ToList();
        }
      

        // naviguer
        int index;
        public void naviguer(int i)
        {
            txt_code_stock.Text = Gestion_medicament.db.STOCK.ToList()[i].code_stock.ToString();
            cmb_fournisseur.SelectedValue = int.Parse(Gestion_medicament.db.STOCK.ToList()[i].id_fournisseur.ToString());
            cmb_medicament.SelectedValue = int.Parse(Gestion_medicament.db.STOCK.ToList()[i].code_medicament.ToString());
            txt_qte_entrer.Text = Gestion_medicament.db.STOCK.ToList()[i].qte_entre.ToString();
            picker_date_entrer.Value = DateTime.Parse(Gestion_medicament.db.STOCK.ToList()[i].date_entre.ToString());


            bt_ajouter.Enabled = false;
            cmb_fournisseur.Enabled = true;
            cmb_medicament.Enabled = true;

            rd_fournisseur.Checked = false;
            rd_f_m.Checked = false;
            rd_stock.Checked = false;
            rd_medicament.Checked = false;

            txt_code_stock.Enabled = false;
            txt_qte_entrer.Enabled = true;
            picker_date_entrer.Enabled = true;
            dgv();

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            var reqF = from F in Gestion_medicament.db.FOURNISSEUR
                       select F;

            cmb_fournisseur.DataSource = reqF;
            cmb_fournisseur.DisplayMember = "nom_f";
            cmb_fournisseur.ValueMember = "id_fournisseur";


            var reqM = from M in Gestion_medicament.db.MEDICAMENT
                       select M;

            cmb_medicament.DataSource = reqM;
            cmb_medicament.DisplayMember = "nom_medicament";
            cmb_medicament.ValueMember = "code_medicament";

            //Connexion.da = new SqlDataAdapter("select * from STOCK", Connexion.cnx);
            //Connexion.da.Fill(Connexion.ds,"STOCK");

            dgv();

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        private void rd_par_stock_CheckedChanged(object sender, EventArgs e)
        {



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
            // suivant
            if (index < Gestion_medicament.db.STOCK.ToList().Count - 1)
            {
                index++;
                naviguer(index);
            }
        }

        private void bt_dernier_Click(object sender, EventArgs e)
        {
            index = Gestion_medicament.db.STOCK.ToList().Count - 1;
            naviguer(index);
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            // ajouter stock
            if (txt_qte_entrer.Text != "" && picker_date_entrer.Value != null)
            {
                int K = 0;
                if (txt_code_stock.Text != "")
                {
                    var Req1 = from S in Gestion_medicament.db.STOCK
                               where S.code_stock == int.Parse(txt_code_stock.Text.ToString())
                               select S;
                    foreach (var S in Req1)
                    {
                        if (txt_code_stock.Text == S.code_stock.ToString())
                        {
                            MessageBox.Show("le Stock existe deja");
                            K = 1;
                        }
                    }
                }
                if (K == 0)
                {
                    int codeS;
                    var req = (from v in Gestion_medicament.db.STOCK select v).Count();
                    codeS = int.Parse(req.ToString());

                    STOCK ST = new STOCK();
                    ST.code_stock = codeS + 2;
                    ST.code_medicament = int.Parse(cmb_medicament.SelectedValue.ToString());
                    ST.id_fournisseur = int.Parse(cmb_fournisseur.SelectedValue.ToString());
                    ST.qte_entre = int.Parse(txt_qte_entrer.Text);
                    ST.date_entre = DateTime.Parse(picker_date_entrer.Value.ToString());
                    Gestion_medicament.db.STOCK.InsertOnSubmit(ST);
                    Gestion_medicament.db.SubmitChanges();
                    MessageBox.Show("Stock ajoutée");

                    codeS++;
                    txt_code_stock.Text = codeS.ToString();

                    vider();
                    dgv();

                }
            }
            else
            {
                MessageBox.Show(" les champs ils sont vide.");
            }

        }
        // vider
        public void vider()
        {
            txt_code_stock.Text = "";
            cmb_medicament.SelectedIndex = -1;
            cmb_fournisseur.SelectedIndex = -1;
            txt_qte_entrer.Text = "";
            picker_date_entrer.Value = DateTime.Now;
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            vider();
            bt_ajouter.Enabled = true;
            cmb_fournisseur.Enabled = true;
            cmb_medicament.Enabled = true;

            rd_fournisseur.Checked = false;
            rd_f_m.Checked = false;
            rd_stock.Checked = false;
            rd_medicament.Checked = false;

            txt_code_stock.Enabled = false;
            txt_qte_entrer.Enabled = true;
            picker_date_entrer.Enabled = true;

            dgv();

        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {

            // modifier fournisseur
           
            if (txt_code_stock.Text != "" && txt_qte_entrer.Text != "" && picker_date_entrer.Value != null && cmb_fournisseur.SelectedIndex != -1 && cmb_medicament.SelectedIndex != -1)
            {

                if (MessageBox.Show("vous voules vraiment modifiée ce stock ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection cnx = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Gestion_Pharmacie;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand();
                    MessageBox.Show("" + txt_qte_entrer.Text + " ");
                    MessageBox.Show("" + picker_date_entrer.Value + " ");
                    MessageBox.Show("" + cmb_medicament.SelectedValue + " ");
                    MessageBox.Show("" + cmb_fournisseur.SelectedValue + " ");
                    MessageBox.Show("" + txt_code_stock.Text + " ");


                    String VAR = "update STOCK set qte_entre =@p1 ,date_entre=@p2 ,code_medicament=@p3,id_fournisseur=@p4 where code_stock =@p5";
                    cmd = new SqlCommand(VAR, cnx);
                    cmd.Parameters.AddWithValue("@p1", this.txt_qte_entrer.Text);
                    cmd.Parameters.AddWithValue("@p2", this.picker_date_entrer.Value);
                    cmd.Parameters.AddWithValue("@p3", this.cmb_medicament.SelectedValue);
                    cmd.Parameters.AddWithValue("@p4", this.cmb_fournisseur.SelectedValue);
                    cmd.Parameters.AddWithValue("@p5", this.txt_code_stock.Text);
                    if (cnx.State == ConnectionState.Open)
                    {
                        cnx.Close();

                    }
                    cnx.Open();
                    cmd.ExecuteNonQuery();

                    cnx.Close();
                    MessageBox.Show("stock modifiée");
                    dgv();
                    vider();
                    bt_ajouter.Enabled = true;
                }                
            }
            else
            {
                MessageBox.Show(" les champs ils sont vide.");
            }
 

        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            // supprimer stock

            if (MessageBox.Show("vous voules vraiment supprimer ce stock ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int i = int.Parse(txt_code_stock.Text.ToString());
                var req = from S in Gestion_medicament.db.STOCK
                          where S.code_stock == i
                          select S;
                foreach (var ST in req)
                {
                    Gestion_medicament.db.STOCK.DeleteOnSubmit(ST);
                }
                Gestion_medicament.db.SubmitChanges();
                MessageBox.Show("suppresion avec succées");
                vider();
                dgv();
                bt_ajouter.Enabled = true;

            }
        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            //RECHERCHE PAR STOCK 

            // recherche par Id :
            if (rd_stock.Checked)
            {
                if (txt_code_stock.Text == "")
                {
                    MessageBox.Show("le champs est vide.");
                }
                else
                {
                    int i = 0;
                    var Req = from ST in Gestion_medicament.db.STOCK
                              where ST.code_stock == int.Parse(txt_code_stock.Text)
                              select ST;
                    foreach (var ST in Req)
                    {
                        txt_code_stock.Text = ST.code_stock.ToString();
                        txt_qte_entrer.Text = ST.qte_entre.ToString();
                        cmb_fournisseur.SelectedValue = int.Parse(ST.id_fournisseur.ToString());
                        cmb_medicament.SelectedValue = int.Parse(ST.code_medicament.ToString());
                        picker_date_entrer.Value = DateTime.Parse(ST.date_entre.ToString());
                        i = 1;
                        cmb_fournisseur.Enabled = true;
                        cmb_medicament.Enabled = true;
                        txt_code_stock.Enabled = false;
                        txt_qte_entrer.Enabled = true;
                        picker_date_entrer.Enabled = true;
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("stock introuvable");

                        rd_stock.Checked = false;

                    }
                }

            }
            // rechercher par Fournisseur
            if (rd_fournisseur.Checked)
            {
                if (cmb_fournisseur.SelectedIndex == -1)
                {
                    MessageBox.Show("le champs est vide choisi pour afficher l'element concerner");
                }
                else
                {
                    int i = 0;
                    var Req1 = from ST in Gestion_medicament.db.STOCK
                               where ST.id_fournisseur == int.Parse(cmb_fournisseur.SelectedValue.ToString())
                               select ST;
                    foreach (var ST in Req1)
                    {
                        dgv_stock.DataSource = Req1.ToList();
                        i = 1;
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("stock introuvable");
                        dgv();
                        vider();

                        rd_fournisseur.Checked = false;

                    }
                }
            }
            // recherche par Medicament 
            if (rd_medicament.Checked)
            {
                if (cmb_medicament.SelectedIndex == -1)
                {
                    MessageBox.Show("le champs est vide choisi pour afficher l'element concerner");

                }
                else
                {
                    int i = 0;
                    var Req2 = from ST in Gestion_medicament.db.STOCK
                               where ST.code_medicament == int.Parse(cmb_medicament.SelectedValue.ToString())
                               select ST;
                    foreach (var ST in Req2)
                    {
                        dgv_stock.DataSource = Req2.ToList();
                        i = 1;
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("stock introuvable");
                        dgv();
                        vider();

                        rd_medicament.Checked = false;
                    }
                }
            }
            // recherche par Medicament et fournisseur
            if (rd_f_m.Checked)
            {
                if (cmb_fournisseur.SelectedIndex == -1 && cmb_medicament.SelectedIndex == -1)
                {
                    MessageBox.Show("les champs sont vide choisi pour afficher les elements concerner");

                }
                else if (cmb_fournisseur.SelectedIndex == -1 || cmb_medicament.SelectedIndex == -1)
                {
                    MessageBox.Show("il manque un champs a remplire");

                }
                else
                {
                    int i = 0;
                    var Req3 = from ST in Gestion_medicament.db.STOCK
                               where ST.code_medicament == int.Parse(cmb_medicament.SelectedValue.ToString()) && ST.id_fournisseur == int.Parse(cmb_fournisseur.SelectedValue.ToString())
                               select ST;
                    foreach (var ST in Req3)
                    {
                        dgv_stock.DataSource = Req3.ToList();
                        i = 1;
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("stock introuvable");
                        dgv();
                        vider();
                        rd_f_m.Checked = false;
                    }
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_stock.Checked == true)
            {
                cmb_fournisseur.Enabled = false;
                cmb_medicament.Enabled = false;
                txt_code_stock.Enabled = true;
                txt_qte_entrer.Enabled = false;
                picker_date_entrer.Enabled = false;
            }
        }

        private void rd_fournisseur_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_fournisseur.Checked == true)
            {
                cmb_fournisseur.Enabled = true;
                cmb_medicament.Enabled = false;
                txt_code_stock.Enabled = false;
                txt_qte_entrer.Enabled = false;
                picker_date_entrer.Enabled = false;
            }
        }

        private void rd_medicament_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_medicament.Checked == true)
            {
                cmb_fournisseur.Enabled = false;
                cmb_medicament.Enabled = true;
                txt_code_stock.Enabled = false;
                txt_qte_entrer.Enabled = false;
                picker_date_entrer.Enabled = false;
            }
        }

        private void rd_f_m_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_f_m.Checked == true)
            {
                cmb_fournisseur.Enabled = true;
                cmb_medicament.Enabled = true;
                txt_code_stock.Enabled = false;
                txt_qte_entrer.Enabled = false;
                picker_date_entrer.Enabled = false;
            }
        }

        private void rd_stock_Click(object sender, EventArgs e)
        {
            vider();
            dgv();
        }

        private void rd_fournisseur_Click(object sender, EventArgs e)
        {
            vider();
            dgv();

        }

        private void rd_medicament_Click(object sender, EventArgs e)
        {
            vider();
            dgv();
        }

        private void rd_f_m_Click(object sender, EventArgs e)
        {
            vider();
            dgv();
        }

        private void dgv_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Req = from ST in Gestion_medicament.db.STOCK
                      where ST.code_stock == int.Parse(dgv_stock.CurrentRow.Cells[0].Value.ToString())
                      select ST;
            foreach (var ST in Req)
            {
                txt_code_stock.Text = ST.code_stock.ToString();
                txt_qte_entrer.Text = ST.qte_entre.ToString();
                cmb_fournisseur.SelectedValue = int.Parse(ST.id_fournisseur.ToString());
                cmb_medicament.SelectedValue = int.Parse(ST.code_medicament.ToString());
                picker_date_entrer.Value = DateTime.Parse(ST.date_entre.ToString());
            }
            bt_ajouter.Enabled = true;
            cmb_fournisseur.Enabled = true;
            cmb_medicament.Enabled = true;

            rd_fournisseur.Checked = false;
            rd_f_m.Checked = false;
            rd_stock.Checked = false;
            rd_medicament.Checked = false;

            txt_code_stock.Enabled = false;
            txt_qte_entrer.Enabled = true;
            picker_date_entrer.Enabled = true;

        }
    }
}
