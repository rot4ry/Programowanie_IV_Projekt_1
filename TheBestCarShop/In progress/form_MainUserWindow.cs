using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBestCarShop.In_progress;

namespace TheBestCarShop
{
    public partial class form_MainUserWindow : Form
    {
        private static Client _accountOwner = new Client();
        private DatabaseHandler dh = new DatabaseHandler();

        private Stopwatch loggedInTime = new Stopwatch();
        private bool loggedIn { get; set; }
        
        
        public form_MainUserWindow(string username)
        {
            InitializeComponent();
            _accountOwner = dh.GetClientDetails(username);
            SetWelcomeLabel();
            loggedInTime.Start();
            loggedIn = true;
        }

        private void SetWelcomeLabel()
        {
            string tab = "               "; //for alignment only, due to winforms' WONDERFUL design.
            string[] welcomeWords = new string[]
            {
                $"{tab}Hello, {_accountOwner.FirstName}!",
                $"{tab}How is your day, {_accountOwner.FirstName}? ッ",
                $"{tab}Welcome, {_accountOwner.FirstName}!",
                $"{tab}Nice to see you again, {_accountOwner.FirstName}!",
                $"{tab}Ready to roll?",
                $"{tab}Hello there.",
                $"{tab}It's {_accountOwner.FirstName}!",
                $"{tab}{_accountOwner.FirstName}, I am your father.",
                $"{tab}Servus, {_accountOwner.FirstName}!",
                $"{tab}こんにちは, {_accountOwner.FirstName}-さん!",
                $"{tab}イースターエッグ" //easter eggs
            };
            welcomeLabel.Text = welcomeWords[new Random().Next(0, welcomeWords.Length)];
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loggedInTime.Stop();
            loggedIn = false;

            form_StartingWindow startingWindow = new form_StartingWindow();
            this.Hide();
            startingWindow.ShowDialog();
            this.Close();
        }

        
        private void loggedTimer_Tick(object sender, EventArgs e)
        {
            measuredTimeLabel.Text = $"{loggedInTime.ElapsedMilliseconds/3600000} \tHours \n{loggedInTime.ElapsedMilliseconds/60000} \tMinutes \n{loggedInTime.ElapsedMilliseconds/1000} \tSeconds";
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            //[TODO] working shop window
            form_ShopWindow shopWindow = new form_ShopWindow();
            shopWindow.ShowDialog();
        }

        private void shoppingKartButton_Click(object sender, EventArgs e)
        {
            //[TODO] working shopping kart
            form_ShoppingKart shoppingKart = new form_ShoppingKart();
            shoppingKart.ShowDialog();
        }

        private void myOrdersButton_Click(object sender, EventArgs e)
        {
            //[TODO] all client's orders
            form_MyOrders myOrders = new form_MyOrders();
            myOrders.ShowDialog();
        }

        private void randomThingButton_Click(object sender, EventArgs e)
        {

            //add a random product to the shopping kart and order it
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            form_AccountSettings settings = new form_AccountSettings(_accountOwner);
            settings.ShowDialog();
            if (RefreshClient() == 0)
            {
                this.Hide();
                form_StartingWindow startingWindow = new form_StartingWindow();
                startingWindow.ShowDialog();
                this.Close();
            }
        }

        private int RefreshClient()
        {
            if (dh.GetClientDetails(_accountOwner.Username) != null)
            {
                _accountOwner = dh.GetClientDetails(_accountOwner.Username);
                return 1;
            }

            else
            {
                loggedIn = false;
                return 0;
            }
        }

        //shop access, shopping kart
    }
}
