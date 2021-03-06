﻿using System;
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
        private Client _accountOwner = new Client();
        private DatabaseHandler dh = new DatabaseHandler();

        private Stopwatch loggedInTime = new Stopwatch();
        
        public form_MainUserWindow(string username)
        {
            InitializeComponent();
            _accountOwner = dh.GetClientDetails(username);
            SetWelcomeLabel();
            loggedInTime.Start();
        }

        private void form_MainUserWindow_Load(object sender, EventArgs e)
        {
            //adds an artificial shopping kart as an unconfirmed order,
            //deleted while logging out
            dh.AddUnplacedOrder(_accountOwner.ClientID);    
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
                $"{tab}イースターエッグ", 
                $"{tab}Gas, gas, gas...🚗 "
            };
            welcomeLabel.Text = welcomeWords[new Random().Next(0, welcomeWords.Length)];
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loggedInTime.Stop();
            dh.RemoveUnplacedOrder(_accountOwner.ClientID);
           
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
            form_ShopWindow shopWindow = new form_ShopWindow(_accountOwner);
            shopWindow.ShowDialog();
        }

        private void shoppingKartButton_Click(object sender, EventArgs e)
        {
            form_ShoppingKart shoppingKart = new form_ShoppingKart(_accountOwner);
            shoppingKart.ShowDialog();
        }

        private void myOrdersButton_Click(object sender, EventArgs e)
        {
            form_MyOrders myOrders = new form_MyOrders(_accountOwner);
            myOrders.ShowDialog();
        }

        private void randomThingButton_Click(object sender, EventArgs e)
        {
            //creates a random order
            dh.RemoveUnplacedOrder(_accountOwner.ClientID);
            dh.AddUnplacedOrder(_accountOwner.ClientID);

            List<Product> products = dh.GetAvailableProductsList();
            int kartID = dh.GetShoppingKartID(_accountOwner.ClientID);
            int productID = products.OrderBy(x => Guid.NewGuid()).Select(x => x.ProductID).First();

            dh.AddToKartIfNotExists(kartID, productID);
            int random = dh.UpdateProductQuantityBasedOnKart(productID, 1);
            if (random == 1) dh.ConfirmOrder(_accountOwner.ClientID, kartID);
            else dh.UpdateProductQuantityBasedOnKart(productID, -1);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            form_AccountSettings settings = new form_AccountSettings(_accountOwner);
            settings.ShowDialog();
            if (RefreshClient() == 0)
            {
                dh.RemoveUnplacedOrder(_accountOwner.ClientID);
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
                return 0;
            }
        }
    }
}

