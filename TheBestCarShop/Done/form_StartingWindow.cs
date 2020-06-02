using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestCarShop
{
    public partial class form_StartingWindow : Form
    {
        /*
         *  COMMENT SECTION
         *  Enabled buttons are Color.Ivory, disabled Color.Aqua
         */
        
        public form_StartingWindow()
        {
            InitializeComponent();
            enableLogin();
        }


        /*
         *  LOGIN SECTION
         */
        private void enableLogin()
        {
            if (loginTextbox.Text.Length == 0 || passwordTextbox.Text.Length == 0)
            {
                loginButton.Enabled = false; 
            }

            else
            { 
                loginButton.Enabled = true;
            }
        }

        private void loginTextbox_TextChanged(object sender, EventArgs e)
        {
            enableLogin();
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            enableLogin();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string inputUsername = loginTextbox.Text;
            string inputPassword = passwordTextbox.Text;

            inputUsername = "LukSky141";
            inputPassword = "LukSky141";

            DatabaseHandler dh = new DatabaseHandler();
            
            bool isDataCorrect =  dh.CheckLoginData(inputUsername, inputPassword);
           
            if (isDataCorrect == true)
            {
                form_MainUserWindow MUW = new form_MainUserWindow(inputUsername);
                this.Hide();
                MUW.ShowDialog();
                this.Close();
            }

            else
            {
                form_SystemMessage wrongCredentials = new form_SystemMessage("Unable to log in.", "Check your login and password.");
                loginTextbox.Clear();
                passwordTextbox.Clear();
                this.ActiveControl = loginTextbox;
            }
        }



        /*
         *  CREATE ACCOUNT SECTION
         */

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_CreateAccount createAccount = new form_CreateAccount();
            createAccount.ShowDialog();
            this.Show();
        }
    }
}
