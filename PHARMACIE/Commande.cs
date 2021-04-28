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
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }

        SqlCommand cmd;

        public static Accueil acc = new Accueil();
        int ancient_id_medicament;   // Pour rechercher dans la table commande id de medicament pour le changer
        int obligation_or = 0;
        int ordonnance_existe = 1;      // ordonnance ajouter dans la premiere commande

        private void button5_Click(object sender, EventArgs e)
        {

            // test du medecin si'll y'a plusieur ordonnance ou bien ajouter dans cette cmd avec la variable check medecin

            // si Ajouter a cette commande : supprimer le medecin apartir de id d'ordonnance 
            //
            //  Test d'ordonnace si existe dans la facture ( id ou NULL ) --- OUI ---- supprimer l'ordo apartir de son id
            // 
            // suppression de la dernier row de facture ( par defaut )
            //
            // cacher le forme commmande et revenir au forme d'acceile 
            this.Hide();
        }

        private void Commande_Load(object sender, EventArgs e)
        {
            // datagridview VIDE pour verification avec le client

            Connexion.da = new SqlDataAdapter("select * from MEDICAMENT", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "MEDICAMENT");

            cmb_medicament.DataSource = Connexion.ds.Tables["MEDICAMENT"];
            cmb_medicament.DisplayMember = "nom_medicament";
            cmb_medicament.ValueMember = "code_medicament";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Desactivation du bouton vider
            bt_vider.Enabled = false;

            // verification du medicament ( ordonnance obligatoire ou non )
            for (int i = 0; i < Connexion.ds.Tables["MEDICAMENT"].Rows.Count; i++)
            {
                if (int.Parse(Connexion.ds.Tables["MEDICAMENT"].Rows[i][7].ToString()) == 1)
                {
                    obligation_or = 1;
                }
            }

            // si oui
            if (obligation_or == 1)
            {
                DialogResult res = MessageBox.Show("L'ordonnance est obligatoire | est ce que vous le avez ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes && ordonnance_existe == 1)
                {
                    ordonnance_existe = 0;
                    verification_medecin VF = new verification_medecin();
                    VF.Show();
                    this.Hide();
                }
            }
            else        // L'ordonnance n'est pas obligatoire
            {
                // L'ajoute
            }

            // L'ordonnance deja ajouter
            if (ordonnance_existe == 0)
            {
                // Ajoute
            }


            /* OUI PREMIER FOIS ----
                    verification d'existance du medecin
                        / OUI --- AJT ordonnance
                               
                            variable_check_medecin = true;

                                    Show form ordonnace pour ajouter AVEC BUTTON CONTINUE activé
                                    Activation de button ajouter dans le forme ordonnance


                        / NON --- AJT Medecin --- AJT Ordo

                            variable_check_medecin = false;
            
                                Show form medecin avec button activé pour ajouter AVEC BUTTON CONTINUE activé pour 
                                     Aller effectuer l'ordonnance 

                                Show forme ordonnance pour l'ajouter avec button ajoute activé et button CONTINUE
                                    activé pour revenir a la commande
            
         
            variable = 1;
            */


            //OUI DEUXIEME FOIS --- if ( variable = 1) ---- Ajoute sans ouvrir le forme


            /* 
             * Check variable if = 0 
             * affecter dans la table facture NULL pour l'ordonnance
            */

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // ouverture du forme FACTURE après validation du commande
            acc.Test_fact = 1;



            // ACTIVATION du button continue et Ajouter dans ordonnance si il ya un medicament contient ordo

            /* affectation du zero pour la variable ( check ordonnance ) variable = 0;
            
            affectation : table facture = datefacturation = date system
                                            Montant = Variable calcul apartir de datagridview
                                            idutilisateur = variable d'acceuil;
            
            code_ordo = deja affecter dans l'ajoute d'ordo sinon deja été null

            */


            // aprèss la validation il faut afficher le forme du facture, et cacher la commande

            Facture ft = new Facture();
            ft.Show();
        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            bt_ajouter.Enabled = false;
            bt_vider.Enabled = true;

            if (Connexion.ds.Tables.Contains("COMMANDE"))
            {
                Connexion.ds.Tables["COMMANDE"].Clear();
            }

            int j = 0;

            for (int i = 0; i < Connexion.ds.Tables["FACTURE"].Rows.Count; i++)
            {
                if (txt_rech_num_facture.Text == Connexion.ds.Tables["FACTURE"].Rows[i][0].ToString())
                {
                    // Jointure pour l'affichage du nom medicament à la place de son ID
                    Connexion.da = new SqlDataAdapter("select c.code_facture, m.nom_medicament, m.prix , c.qte_vendue from COMMANDE c join MEDICAMENT m on c.code_medicament = m.code_medicament where c.code_facture = " + int.Parse(txt_rech_num_facture.Text) + "", Connexion.cnx);
                    Connexion.da.Fill(Connexion.ds, "COMMANDE");

                    dgv_cmd.DataSource = Connexion.ds.Tables["COMMANDE"];
                    txt_num_facture.Text = Connexion.ds.Tables["FACTURE"].Rows[i][0].ToString();
                    txt_rech_num_facture.Text = "";

                    j = 1;
                }
            }
            if (j == 0)
            {
                MessageBox.Show("Les commandes n'existe pas car la facture est Introuvable!", "Erreur");
            }
        }

        private void dgv_cmd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Remplissage de la table COMMANDE sans jointure pour faire la modification
            Connexion.da = new SqlDataAdapter("select * from COMMANDE", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "VC");

            // AFfECTATION Depuis la DataGridView au text boxes
            for (int i = 0; i < Connexion.ds.Tables["COMMANDE"].Rows.Count; i++)
            {
                if (dgv_cmd.CurrentRow.Cells[1].Value.ToString() == Connexion.ds.Tables["COMMANDE"].Rows[i][1].ToString())
                {
                    txt_num_facture.Text = Connexion.ds.Tables["COMMANDE"].Rows[i][0].ToString();
                    cmb_medicament.Text = Connexion.ds.Tables["COMMANDE"].Rows[i][1].ToString();
                    txt_prix.Text = Connexion.ds.Tables["COMMANDE"].Rows[i][2].ToString();
                    txt_qte_commande.Text = Connexion.ds.Tables["COMMANDE"].Rows[i][3].ToString();

                    // Recuperation d'id de medicament si il y'a une operation de mofication ou suppression
                    ancient_id_medicament = int.Parse(cmb_medicament.SelectedValue.ToString());
                }

            }
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            //Boucle pour trouver la ligne du facture + le medicament a changer 

            for (int i = 0; i < Connexion.ds.Tables["VC"].Rows.Count; i++)
            {
                if (txt_num_facture.Text == Connexion.ds.Tables["VC"].Rows[i][0].ToString() && ancient_id_medicament == int.Parse(Connexion.ds.Tables["VC"].Rows[i][1].ToString()))
                {
                    string req = " update COMMANDE set code_medicament= " + int.Parse(cmb_medicament.SelectedValue.ToString()) + ", qte_vendue = " + int.Parse(txt_qte_commande.Text.ToString()) + " where code_facture = " + int.Parse(Connexion.ds.Tables["VC"].Rows[i][0].ToString()) + " AND code_medicament = " + ancient_id_medicament + "";
                    cmd = new SqlCommand(req, Connexion.cnx);

                    Connexion.cnx.Open();
                    cmd.ExecuteNonQuery();
                    Connexion.cnx.Close();

                    MessageBox.Show("La commande à bien été modifier", "Réussi");
                    break;
                }
            }

            if (Connexion.ds.Tables.Contains("COMMANDE"))
            {
                Connexion.ds.Tables["COMMANDE"].Clear();
            }

            Connexion.da = new SqlDataAdapter("select c.code_facture, m.nom_medicament, m.prix , c.qte_vendue from COMMANDE c join MEDICAMENT m on c.code_medicament = m.code_medicament where c.code_facture = " + int.Parse(txt_num_facture.Text) + "", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "COMMANDE");

            dgv_cmd.DataSource = Connexion.ds.Tables["COMMANDE"];
        }

        private void cmb_medicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            // remplissage du prix après la selection d'un medicament

            for (int i = 0; i < Connexion.ds.Tables["MEDICAMENT"].Rows.Count; i++)
            {
                if (cmb_medicament.SelectedValue.ToString() == Connexion.ds.Tables["MEDICAMENT"].Rows[i][0].ToString())
                {
                    txt_prix.Text = Connexion.ds.Tables["MEDICAMENT"].Rows[i][2].ToString();
                }
            }
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            Connexion.ds.Tables["COMMANDE"].Rows.Clear();

            txt_num_facture.Text = "";
            txt_prix.Text = "";
            txt_qte_commande.Text = "";

            bt_ajouter.Enabled = true;
        }
    }
}
