using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestCarShop.In_progress
{
    //ADd some user refresh function to see the changes
    public partial class form_AccountSettings : Form
    {
        private Client _accountOwner = new Client();
        private DatabaseHandler dh = new DatabaseHandler();
        
        public form_AccountSettings(Client client)
        {
            InitializeComponent();
            _accountOwner = client;
        }

        private void form_AccountSettings_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            ViewUserDetails();
            updatePasswordButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void ViewUserDetails()
        {
            _accountOwner = dh.GetClientDetails(_accountOwner.Username);

            firstnameTB.Text        = _accountOwner.FirstName;
            secondnameTB.Text       = _accountOwner.SecondName;
            compNameTB.Text         = _accountOwner.CompanyName;
            emailTB.Text            = _accountOwner.Email;
            phoneNumberTB.Text      = _accountOwner.PhoneNumber;

            countryNameTB.Text      = _accountOwner.Country;
            cityNameTB.Text         = _accountOwner.City;
            streetNameTB.Text       = _accountOwner.Street;
            postcodeNumberTB.Text   = _accountOwner.Postcode;
            buildingNumberTB.Text   = _accountOwner.BuildingNumber;
            usernameTB.Text         = _accountOwner.Username;
        }

        private class UpdateClickController
        {
            public bool _emailClicked           = false;
            public bool _phoneNumberClicked     = false;

            public bool _countryClicked         = false;
            public bool _cityClicked            = false;
            public bool _streetClicked          = false;
            public bool _postcodeClicked        = false;
            public bool _buildingNumberClicked  = false;

            public bool _passwordClicked        = false;
            public bool _passwordRepeatClicked  = false;
        }


        //Controlling the content
        private UpdateClickController ucc = new UpdateClickController();

        //EMAIL SECTION
        private void emailTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref ucc._emailClicked, emailTB);
        }
        private void emailTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref ucc._emailClicked, emailTB, _accountOwner.Email);
        }
        private void emailUpdateButton_Click(object sender, EventArgs e)
        {
            dh.UpdateClientField("[Email]", emailTB.Text, _accountOwner.Username);
            ViewUserDetails();
        }
        //PHONE SECTION
        private void phoneNumberTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref ucc._phoneNumberClicked, phoneNumberTB);
        }
        private void phoneNumberTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref ucc._phoneNumberClicked, phoneNumberTB, _accountOwner.PhoneNumber);
        }
        private void phoneUpdateButton_Click(object sender, EventArgs e)
        {
            dh.UpdateClientField("[PhoneNumber]", phoneNumberTB.Text, _accountOwner.Username);
        }
        //COUNTRY SECTION
        private void countryNameTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref ucc._countryClicked, countryNameTB);
        }
        private void countryNameTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref ucc._countryClicked, countryNameTB, _accountOwner.Country);
        }
        private void countryUpdateButton_Click(object sender, EventArgs e)
        {
            dh.UpdateClientField("[Country]", countryNameTB.Text, _accountOwner.Username);
        }
        //CITY SECTION
        private void cityNameTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref ucc._cityClicked, cityNameTB);
        }
        private void cityNameTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref ucc._cityClicked, cityNameTB, _accountOwner.City);
        }
        private void cityUpdateButton_Click(object sender, EventArgs e)
        {
            dh.UpdateClientField("[City]", cityNameTB.Text, _accountOwner.Username);
        }
        //STREET SECTION
        private void streetNameTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref ucc._streetClicked, streetNameTB);
        }
        private void streetNameTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref ucc._streetClicked, streetNameTB, _accountOwner.Street);
        }
        private void steetUpdateButton_Click(object sender, EventArgs e)
        {
            dh.UpdateClientField("[Street]", streetNameTB.Text, _accountOwner.Username);
        }
        //POSTCODE SECTION
        private void postcodeNumberTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref ucc._postcodeClicked, postcodeNumberTB);
        }
        private void postcodeNumberTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref ucc._postcodeClicked, postcodeNumberTB, _accountOwner.Postcode);
        }
        private void postcodeUpdateButton_Click(object sender, EventArgs e)
        {
            dh.UpdateClientField("[Postcode]", postcodeNumberTB.Text, _accountOwner.Username);
        }
        //BUILDING NUMBER SECTION
        private void buildingNumberTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref ucc._buildingNumberClicked, buildingNumberTB);
        }
        private void buildingNumberTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref ucc._buildingNumberClicked, buildingNumberTB, _accountOwner.BuildingNumber);
        }
        private void buildingUpdateButton_Click(object sender, EventArgs e)
        {
            dh.UpdateClientField("[BuildingNumber]", buildingNumberTB.Text, _accountOwner.Username);
        }
        //PASSWORD SECTION: 

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTB.Text == passwordRepeatTB.Text)
            {
                dh.UpdateClientField("[Password]", passwordTB.Text, _accountOwner.Username);
            }
        }

        //ENTER PASSWORD
        private void passwordTB_Enter(object sender, EventArgs e)
        {
            ENTER_PasswordField(ref ucc._passwordClicked, passwordTB);
        }
        private void passwordTB_Leave(object sender, EventArgs e)
        {
            LEAVE_PasswordField(ref ucc._passwordClicked, passwordTB, "Enter password");
        }
        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            EnableUpdatePasswordButton();
        }

        //REPEAT PASSWORD
        private void passwordRepeatTB_Enter(object sender, EventArgs e)
        {
            ENTER_PasswordField(ref ucc._passwordRepeatClicked, passwordRepeatTB);
        }
        private void passwordRepeatTB_Leave(object sender, EventArgs e)
        {
            LEAVE_PasswordField(ref ucc._passwordRepeatClicked, passwordRepeatTB, "Repeat password");
        }
        private void passwordRepeatTB_TextChanged(object sender, EventArgs e)
        {
            EnableUpdatePasswordButton();
        }


        //Some frontend methods, control values of textboxes
        //FOR NON-MASKED 
        private void TryClearingField(ref bool _fieldClicked, TextBox textBox)
        {   //ON ENTER
            if (_fieldClicked != true)
            {
                _fieldClicked = true;
                textBox.Text = "";
            }
        }

        private void TryResetingField(ref bool _fieldClicked, TextBox textBox, string _defaultText)
        {   //ON LEAVE
            if (textBox.Text.Length == 0)
            {
                textBox.Text = _defaultText;
                _fieldClicked = false;
            }
        }

        //FOR PASSWORD TEXTBOXES
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
                EnableUpdatePasswordButton();
            }
            EnableUpdatePasswordButton();
        }

        private void EnableUpdatePasswordButton()
        {

            if (passwordTB.Text == passwordRepeatTB.Text &&
               passwordTB.Text != "Enter password" &&
               passwordRepeatTB.Text != "Repeat password")
            {
                updatePasswordButton.Enabled = true;
            }

            else updatePasswordButton.Enabled = false;
        }


        //ACCOUNT REMOVAL
        private void EnableDeleteButton()
        {
            if (checkBox1.Checked == true &&
                checkBox2.Checked == true &&
                checkBox3.Checked == true &&
                checkBox4.Checked == true &&
                checkBox5.Checked == true &&
                checkBox6.Checked == true
                )
            {
                deleteButton.Enabled = true;
            }

            else deleteButton.Enabled = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EnableDeleteButton();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            EnableDeleteButton();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            EnableDeleteButton();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            EnableDeleteButton();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            EnableDeleteButton();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            EnableDeleteButton();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dh.DeleteClient(_accountOwner.Username) == 1)
            {
                form_SystemMessage success = new form_SystemMessage("Success!", "Your account has been deleted!", this);
            }
            else
            {
                form_SystemMessage failure = new form_SystemMessage("Failure!", "Something went wrong.", this);
            }
        }
    }
}
