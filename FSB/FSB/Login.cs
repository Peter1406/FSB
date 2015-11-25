using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net; // HTTP Zeugs
using System.Net.NetworkInformation;
using System.IO;  // Streamreader usw
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSB
{
    public partial class Login : Form
    {
        string InputEingabe;
        string WebPfad = "http://edv-biela.de/1Schule/";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /*if (IsServerOnline(DatenbankHost, 1500) == false)
            {
                MessageBox.Show("Die Freundesbuch-Datenbank ist offline.\nDie Anwendung wird nun geschlossen.Bitte versuchen Sie es zu einem späteren Zeitpunkt erneut.", "Datenbank offline", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }*/
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLoginUser.Text== "" || tbLoginPassword.Text == "" || tbLoginUser.Text.Length<5 || tbLoginPassword.Text.Length<7)
            {
                MessageBox.Show("Ihre Eingabe ist fehlerhaft. \nBitte versuchen Sie es erneut", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Loged In
                if (GetHtmlSource(WebPfad + "Login.php?user=" + tbLoginUser.Text).Replace(" ", "") == tbLoginPassword.Text)
                {
                    MessageBox.Show("Es hat funktioniert!");
                }
                else // Falsche Logindaten
                {
                    MessageBox.Show(GetHtmlSource(WebPfad + "Login.php?user=" + tbLoginUser.Text) + "'\n" + tbLoginPassword.Text);
                }
            }

            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ////////Leerzeichen verbieten
            if (tbRegisterUser.Text == "" || 
                tbRegisterPassword.Text == "" || !(tbRegisterPasswordCheck.Text == tbRegisterPassword.Text) ||
                tbRegisterMail.Text == "" || !(tbRegisterMail.Text.Contains("@")) || !(tbRegisterMail.Text.Contains(".")) || 
                tbRegisterUser.Text.Length < 4 || tbRegisterPassword.Text.Length < 7)
            {
                MessageBox.Show("Ihre Eingabe ist fehlerhaft. \nBitte überprüfen Sie folgendes:\n1. Der Username muss mindestens aus drei Zeichen bestehen\n2. Das Passwort muss mindestens aus sechs Zeichen bestehen.\n3. Die Passwörter müssen übereinstimmen.\n4. Die E-Mailadresse muss gültig sein\n\nBitte versuchen Sie es erneut", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRegisterMail.Text = "";
                tbRegisterPassword.Text = "";
                tbRegisterPasswordCheck.Text = "";
                tbRegisterMail.Text = "";
            }
            else
            {
                BookRegister(tbRegisterUser.Text, tbRegisterPassword.Text, tbRegisterMail.Text);
            }

        }

        private void LinkPassVergessen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InputEingabe = Microsoft.VisualBasic.Interaction.InputBox("Bitte geben Sie Ihren Usernamen ODER Ihre E-Mailadresse ein um Ihr neues Passwort zugeschickt zu bekommen.", "Reset Passwort","");
            BookGetPassword(InputEingabe);
        }






        #region DBK ansprechen
        private string GetHtmlSource(string url)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
                return data;
            }
            else return "";
        }
        private void BookLogin(string user, string pass)
        {
            MessageBox.Show("Ihre Eingabe ist fehlerhaft. \nBitte versuchen Sie es erneut.", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BookRegister(string user, string pass, string mail)
        {
            //php check username und mail
            //php register
        }
        private void BookGetPassword(string UserOrMail)
        {
            // php pw anfordern

        }
        #endregion



    }
}
