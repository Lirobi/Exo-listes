using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace exolistes
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }
        string[,] tabVerbes = {
                 { "aller", "to go", "gehen", "ir", "andare" },
                 { "boire ", "to drink", "trinken", "beber", "bere" },
                 { "chanter", "to sing", "singen", "cantar", "cantare" },
                 { "danser", "to dance", "tanzen", "bailar", "ballare" },
                 { "fermer", "to close", "schliessen", "cerrar", "chiudere" },
                 { "manger", "to eat", "essen", "comer", "mangiare" },
                 { "travailler", "to work", "arbeiten", "trabajar", "lavorare" },
                 };

        private void cboVerbe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            for (int i = 0; i < tabVerbes.GetLength(0); i++)
            {
                cboVerbe.Items.Add(tabVerbes[i, 0]);
            }
        }

        private void rdbAnglais_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAllemand_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbEspagnol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbItalien_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void grpChoix_Enter(object sender, EventArgs e)
        {

        }

        private void rdbAnglais_Click(object sender, EventArgs e)
        {
            // Cast du sender
            RadioButton r = (RadioButton)sender;

            int numVerbe = cboVerbe.SelectedIndex;
            int numLangue = Convert.ToInt16(r.Tag.ToString());

            lblResultat.Text = tabVerbes[numVerbe, numLangue];
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmNouveau frmNv = new frmNouveau();
            frmNv.Show();
        }
    }
}