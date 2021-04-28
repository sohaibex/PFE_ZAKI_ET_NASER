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
    public partial class verification_medecin : Form
    {
        public verification_medecin()
        {
            InitializeComponent();
        }

        int res = 0;

        private void verification_medecin_Load(object sender, EventArgs e)
        {
            txt_verification_nom.Enabled = false;
            txt_verification_code.Enabled = false;

            Connexion.da = new SqlDataAdapter("select * from MEDECIN", Connexion.cnx);
            Connexion.da.Fill(Connexion.ds, "MEDECIN");
        }

        private void bt_verifier_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Connexion.ds.Tables["MEDECIN"].Rows.Count; i++)
            {
                if (txt_verification_code.Text == Connexion.ds.Tables["MEDECIN"].Rows[i][0].ToString() || txt_verification_code.Text == Connexion.ds.Tables["MEDECIN"].Rows[i][1].ToString())
                {
                    res = 1;
                    MessageBox.Show("Il existe ce medecin");
                    Ordonnance ord = new Ordonnance();
                    ord.Show();
                }
            }

            if (res == 0)
            {
                MessageBox.Show("Ce medecin n'existe pas");
                Medecin medc = new Medecin();
                medc.Show();
            }
        }

        private void rd_code_CheckedChanged(object sender, EventArgs e)
        {
            txt_verification_nom.Enabled = false;
            txt_verification_code.Enabled = true;
        }

        private void rd_nom_CheckedChanged(object sender, EventArgs e)
        {
            txt_verification_code.Enabled = false;
            txt_verification_nom.Enabled = true;
        }
    }
}
