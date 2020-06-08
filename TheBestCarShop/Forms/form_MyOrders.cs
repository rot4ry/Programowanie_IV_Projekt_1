using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBestCarShop.Class_files;

namespace TheBestCarShop.In_progress
{
    public partial class form_MyOrders : Form
    {
        private DatabaseHandler dh = new DatabaseHandler();
        private Client _accountOwner;
        private List<ShoppingHistoryPosition> shoppingHistory;

        public form_MyOrders(Client client)
        {
            InitializeComponent();
            _accountOwner = client;
        }

        private void form_MyOrders_Load(object sender, EventArgs e)
        {
            shoppingHistory = dh.GetCustomerHistory(_accountOwner.ClientID);
            ViewHistory();
            ComputeOrderValues();
        }

        private void ViewHistory()
        {
            historyView.Rows.Clear();

            foreach(ShoppingHistoryPosition item in shoppingHistory)
            {
                if(item.ReceivedDate == item.SentDate && item.ReceivedDate == item.DeliveredDate)
                {
                    //this will be changed when someone actually marks the order
                    //as sent, then delivered
                    //in the wpf project
                    historyView.Rows.Add(
                        item.ReceivedDate,
                        null,
                        null,
                        item.Name,
                        Math.Round(item.Price, 2),
                        item.Quantity
                        );
                }
                else
                {
                    historyView.Rows.Add(
                        item.ReceivedDate,
                        item.SentDate,
                        item.DeliveredDate,
                        item.Name,
                        Math.Round(item.Price, 2),
                        item.Quantity
                        );
                }    
            }
        }

        private void ComputeOrderValues()
        {
            sumLabel.Text = Math.Round(shoppingHistory.Sum(x => x.Quantity * x.Price),2).ToString() + " moneys";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
