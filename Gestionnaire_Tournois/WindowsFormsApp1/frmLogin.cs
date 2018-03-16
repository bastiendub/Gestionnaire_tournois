using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTournois;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {


        public CC_Tournois facade;
        public static string userLogin, userMdp;
        public frmLogin()
        {
            facade = new CC_Tournois();
            InitializeComponent();    
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                //facade.TestConnexion(tbxNom.Text, tbxMdp.Text);
                
                if (facade.TestConnexion(tbxNom.Text, tbxMdp.Text) == true)
                {
                    //userLogin = tbxNom.Text;
                    //userMdp = tbxMdp.Text;
                    accueil pageAccueil = new accueil(tbxNom.Text);
                    pageAccueil.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Mot de passe incorrect, veuillez réessayer.");
                tbxMdp.Text = "";
                tbxNom.Text = "";
            }
            
        }
    }
}
