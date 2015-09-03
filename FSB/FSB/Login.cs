using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLoginUser.Text== "" || tbLoginPassword.Text == "")
            {
                MessageBox.Show("Ihre Eingabe ist zu kurz. Bitte überprüfen Sie diese.", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbRegisterUser == "" || tbRegisterP)
        }

        
    }
}
