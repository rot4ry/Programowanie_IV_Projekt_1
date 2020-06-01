using System;
using System.Text;
using System.Windows.Forms;

namespace TheBestCarShop
{
    public partial class form_CreateAccount : Form
    {
        public form_CreateAccount()
        {
            InitializeComponent();
        }

        private void form_CreateAccount_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private bool isUsernameGenerated = false;
        private void EnableCreateAccount()
        {   
            //Needs an event?

            if( (_Counter.IsReady() == true)                        &&
                (isUsernameGenerated == true)                       && 
                (loginTB.Text != DefaultTexts._username)            &&
                (nameTB.Text != DefaultTexts._name)                 &&
                (surnameTB.Text!=DefaultTexts._secondName)          &&
                (passwordTB_create.Text == passwordTB_repeat.Text)  &&
                (checkBox1.Checked == true)                         &&
                (checkBox2.Checked == true)                         &&
                (checkBox3.Checked == true)
              )
            {
                createAccountButton.Enabled = true;
            }
            else
            {
                createAccountButton.Enabled = false;
            }
        }

        //BUTTONS
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string companyName = @companyNameTB.Text;
            if (companyNameTB.Text == DefaultTexts._companyName)
                companyName = "No details.";

            string finalUsername = @loginTB.Text;
            
            string finalPassword;
            if (passwordTB_create.Text == passwordTB_repeat.Text)
                finalPassword = @passwordTB_repeat.Text;
            else throw new Exception("Wrong password exception.");

            createAccountButton.Enabled = false;

            DatabaseHandler dh = new DatabaseHandler();
            try
            {
                int affected = dh.AddUser(new Client()
                {
                    FirstName = @nameTB.Text,
                    SecondName = @surnameTB.Text,
                    CompanyName = @companyName,
                    Email = @mailTB.Text,
                    PhoneNumber = @phoneTB.Text,
                    Country = @countryTB.Text,
                    City = @cityTB.Text,
                    Street = @streetTB.Text,
                    Postcode = @postcodeTB.Text,
                    BuildingNumber = @buildingTB.Text,
                    Username = finalUsername,
                    Password = finalPassword,
                }
                );
                
                if (affected == 1)
                {
                    form_SystemMessage message = new form_SystemMessage
                ("Success!", "Your account has been created!", this);
                }
            }
            catch (Exception whileInserting)
            {
                Console.WriteLine(whileInserting.Message);
                form_SystemMessage alert = new form_SystemMessage
                    ("Failure!", "Your account wasn't created. \nTry again please.");
            }
        }

        private void generateUsernameButton_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string surname = surnameTB.Text;
            string variableToken = new Random().Next(10, 1000).ToString();
            try
            {
                name = name.Remove(new Random().Next(3, name.Length));
                surname = surname.Remove(new Random().Next(3, surname.Length));
            }
            catch(Exception exception) 
            {
                /*If an exception is thrown a whole name is used*/
                Console.WriteLine(exception.Message);
            }

            string generatedUsername = new StringBuilder()
                .Append(name)
                .Append(surname)
                .Append(variableToken)
                .ToString();
            
            loginTB.Text = generatedUsername;
            
            isUsernameGenerated = true;
            EnableCreateAccount();
        }

        //Field clearing        
        private ClickController _Counter = new ClickController();

        private void TryClearingField(ref bool _fieldClicked, TextBox textBox)
        {
            if (_fieldClicked != true)
            {
                _fieldClicked = true;
                textBox.Text = "";
                EnableCreateAccount();
            }
            else EnableCreateAccount();
        }

        private void TryResetingField(ref bool _fieldClicked, TextBox textBox, string _defaultText)
        {
            if (textBox.Text.Length == 0 || textBox.Text==_defaultText)
            {
                textBox.Text = _defaultText;
                _fieldClicked = false;
                EnableCreateAccount();
            }
            else EnableCreateAccount();
        }

        private void clearPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTB_create.PasswordChar = '\0';
            passwordTB_repeat.PasswordChar = '\0';
            passwordTB_create.Text = DefaultTexts._password;
            passwordTB_repeat.Text = DefaultTexts._passwordRepeat;
            _Counter._passwordClicked = false;
            _Counter._passwordRepeatClicked = false;
            EnableCreateAccount();
        }


        private void nameTB_Enter(object sender, EventArgs e)
        {
            TryClearingField( ref _Counter._nameClicked, nameTB);
        }
        private void nameTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._nameClicked, nameTB, DefaultTexts._name);
        }


        private void surnameTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._secondNameClicked, surnameTB);
        }
        private void surnameTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._secondNameClicked, surnameTB, DefaultTexts._secondName);
        }


        private void companyNameTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._companyNameClicked, companyNameTB);
        }
        private void companyNameTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._companyNameClicked, companyNameTB, DefaultTexts._companyName);
        }


        private void mailTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._emailClicked, mailTB);
        }
        private void mailTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._emailClicked, mailTB, DefaultTexts._email);
        }


        private void phoneTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._phoneNumberClicked, phoneTB);
        }
        private void phoneTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._phoneNumberClicked, phoneTB, DefaultTexts._phoneNumber);
        }


        private void countryTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._countryClicked, countryTB);
        }
        private void countryTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._countryClicked, countryTB, DefaultTexts._country);
        }


        private void cityTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._cityClicked, cityTB);
        }
        private void cityTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._cityClicked, cityTB, DefaultTexts._city);
        }


        private void streetTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._streetClicked, streetTB);
        }
        private void streetTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._streetClicked, streetTB, DefaultTexts._street);
        }


        private void postcodeTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._postcodeClicked, postcodeTB);
        }
        private void postcodeTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._postcodeClicked, postcodeTB, DefaultTexts._postcode);
        }


        private void buildingTB_Enter(object sender, EventArgs e)
        {
            TryClearingField(ref _Counter._buildingNumberClicked, buildingTB);
        }
        private void buildingTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._buildingNumberClicked, buildingTB, DefaultTexts._buildingNumber);
        }

        
        //Login and password section
        private void ENTER_PasswordField(ref bool _fieldClicked, TextBox textbox)
        {
            if(_fieldClicked == false) textbox.Text = "";
            textbox.PasswordChar = '•';
            _fieldClicked = true;
        }

        private void LEAVE_PasswordField(ref bool _fieldClicked, TextBox textbox, string defaultText)
        {
            if (textbox.Text.Length == 0 || textbox.Text == defaultText )
            {
                textbox.Text = defaultText;
                textbox.PasswordChar = '\0';
                _fieldClicked = false;
                EnableCreateAccount();
            }
            EnableCreateAccount();
        }

        private void passwordTB_create_Enter(object sender, EventArgs e)
        {
            ENTER_PasswordField(ref _Counter._passwordClicked, passwordTB_create);
        }
        private void passwordTB_create_Leave(object sender, EventArgs e)
        {
            LEAVE_PasswordField(ref _Counter._passwordClicked, passwordTB_create, DefaultTexts._password);
        }


        private void passwordTB_repeat_Enter(object sender, EventArgs e)
        {
            ENTER_PasswordField(ref _Counter._passwordRepeatClicked, passwordTB_repeat);
        }
        private void passwordTB_repeat_Leave(object sender, EventArgs e)
        {
            LEAVE_PasswordField(ref _Counter._passwordRepeatClicked, passwordTB_repeat, DefaultTexts._passwordRepeat);            
        }

        private void passwordTB_create_TextChanged(object sender, EventArgs e)
        {
            EnableCreateAccount();
        }

        private void passwordTB_repeat_TextChanged(object sender, EventArgs e)
        {
            EnableCreateAccount();
        }

        private void loginTB_Leave(object sender, EventArgs e)
        {
            TryResetingField(ref _Counter._usernameClicked, loginTB, DefaultTexts._username);
        }

                

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EnableCreateAccount();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            EnableCreateAccount();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            EnableCreateAccount();
        }

        
    }
}
