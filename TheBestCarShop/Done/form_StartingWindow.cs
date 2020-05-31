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


        //WARNING - - - - FOR DEBUGGING ONLY - - - REMOVE IT
        private void enableLogin()
        {
            if (loginTextbox.Text.Length == 0 || passwordTextbox.Text.Length == 0)
            {
                loginButton.Enabled = true;
                //loginButton.Enabled = false; //<<this is good
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

            //inputUsername = "useuse111";
            //inputPassword = "use";

            DatabaseHandler dh = new DatabaseHandler();
            
            bool isDataCorrect =  dh.CheckLoginData(inputUsername, inputPassword);
            bool isAdmin = dh.CheckUserAccess(inputUsername, inputPassword);

           
            if (inputUsername == "Admin" && inputPassword == "nimdA")
            {
                form_MainAdminWindow MAW = new form_MainAdminWindow(inputUsername);
                this.Hide();
                MAW.ShowDialog();
                this.Close();
            }

            else if (isDataCorrect == true && isAdmin == true)
            {
                form_MainAdminWindow MAW = new form_MainAdminWindow(inputUsername);
                this.Hide();
                MAW.ShowDialog();
                this.Close();
            }

            else if (isDataCorrect == true)
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
