using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestCarShop.In_progress
{
    public partial class form_AccountSettings : Form
    {
        private Client _accountOwner = new Client();
        public form_AccountSettings(Client client)
        {
            InitializeComponent();
            _accountOwner = client;
        }





        //Some frontend methods
        private void TryClearingField(ref bool _fieldClicked, TextBox textBox)
        {
            if (_fieldClicked != true)
            {
                _fieldClicked = true;
                textBox.Text = "";
            }
        }

        private void TryResetingField(ref bool _fieldClicked, TextBox textBox, string _defaultText)
        {
            if (textBox.Text.Length == 0)
            {
                textBox.Text = _defaultText;
                _fieldClicked = false;
            }
        }

        private void ENTER_PasswordField(ref bool _fieldClicked, TextBox textbox)
        {
            if (_fieldClicked == false) textbox.Text = "";
            textbox.PasswordChar = '•';
            _fieldClicked = true;
        }

        private void LEAVE_PasswordField(ref bool _fieldClicked, TextBox textbox, string defaultText)
        {
            if (textbox.Text.Length == 0 || textbox.Text == defaultText)
            {
                textbox.Text = defaultText;
                textbox.PasswordChar = '\0';
                _fieldClicked = false;
                //enable update button?
            }
            //enable update button?
        }
    }
}
