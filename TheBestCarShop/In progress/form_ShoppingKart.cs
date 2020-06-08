using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TheBestCarShop
{
    public partial class form_ShoppingKart : Form
    {
        private DatabaseHandler dh = new DatabaseHandler();
        private Client _accountOwner;
        private int _shoppingKartID;
        

        private List<OrderDetail> shoppingKartList = new List<OrderDetail>();
        private List<Product> productsInKart = new List<Product>();

        public form_ShoppingKart(Client client)
        {
            InitializeComponent();
            _accountOwner = client;
        }

        private void form_ShoppingKart_Load(object sender, EventArgs e)
        {
            _shoppingKartID = dh.GetShoppingKartID(_accountOwner.ClientID);
            RefreshKart();
        }

        //DataGridView contents
        private void RefreshKart()
        {
            BuildProductsList();
            ViewKart();
        }
        private void BuildProductsList()
        {
            shoppingKartList.Clear();
            productsInKart.Clear();

            shoppingKartList = dh.GetKartList(_shoppingKartID);
            foreach (var item in shoppingKartList)
            {
                Product product = dh.GetProduct(item.ProductID);  
                productsInKart.Add(product);
            }
        }

        //Controlling DataGridView layout
        private void ReplaceColumnWithButtons(string name, string text)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            
            buttonColumn.Name = name;
            buttonColumn.HeaderText = "";
            buttonColumn.Text = text;
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.Width = 152;

            buttonColumn.DefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = stylingButtonSK.BackColor,
                ForeColor = stylingButtonSK.ForeColor,
                Font = stylingButtonSK.Font,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
            };
            this.shoppingKartView.Columns.Add(buttonColumn);  
        }
        private void AddColumns()
        {
            if (shoppingKartView.Columns["details"] == null)
            {
                shoppingKartView.Columns.Remove("detailsEmpty");
                ReplaceColumnWithButtons("details", "Show details");
            }
            if (shoppingKartView.Columns["remove"] == null)
            {
                shoppingKartView.Columns.Remove("removeEmpty");
                ReplaceColumnWithButtons("remove", "Remove from kart");
            }
        }
        private void ViewKart()
        {
            shoppingKartView.Rows.Clear();
            AddColumns();
            if(productsInKart != null)
            {
                foreach(var item in productsInKart)
                {
                    shoppingKartView.Rows.Add(
                        item.ProductID,
                        item.Name,
                        shoppingKartList.Where(x=>x.ProductID==item.ProductID).Select(x=>x.Quantity).Single(),
                        Math.Round(item.Price,2)
                        );
                }
            }
        }

        //Button events
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            shoppingKartList = dh.GetKartList(_shoppingKartID);
            
            int _broken = 0;
            int _passed = 0;
            //try updating values
            foreach(OrderDetail item in shoppingKartList)
            {
                int updateResult = dh.UpdateProductQuantityBasedOnKart
                    (item.ProductID, item.Quantity);
                if (updateResult == 1)
                {
                    _passed += 1;
                }
                else
                {
                    _broken = 1;
                    break;
                }
            }

            //if an error occurs, values are returned to the previous state
            if (_broken == 1)
            {
                foreach (OrderDetail item in shoppingKartList)
                {
                    int reverse = dh.UpdateProductQuantityBasedOnKart(item.ProductID, (-1) * item.Quantity);

                    if (reverse == 1)
                    {
                        _passed -= 1;
                    }
                    if (_passed == 0) break;
                }
            }
            else if (_broken == 0)
            {
                int result = dh.ConfirmOrder(_accountOwner.ClientID, _shoppingKartID);
                if (result == 1)
                {
                    form_SystemMessage success = new form_SystemMessage("Success!", "Your order is being prepared!", this);
                }
                else
                {
                    form_SystemMessage success = new form_SystemMessage("Failure.", "Something went wrong, please try again.");
                }
            }
        }
        private void clearKartButton_Click(object sender, EventArgs e)
        {
            dh.ClearKart(_shoppingKartID);
            RefreshKart();
        }


        //Grid buttons events
        private void shoppingKartView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == shoppingKartView.Columns["details"].Index)
            {
                int productID = (int)shoppingKartView[0, e.RowIndex].Value;
                form_ProductDetailsWindow details = new form_ProductDetailsWindow(productID);
                details.ShowDialog();
            }
            else if(e.ColumnIndex == shoppingKartView.Columns["remove"].Index)
            {
                int productID = (int)shoppingKartView[0, e.RowIndex].Value;
                dh.RemoveFromKart(_shoppingKartID, productID);
                RefreshKart();
            }
        }
        private void shoppingKartView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == shoppingKartView.Columns["Quantity"].Index)
            {
                int quantity = productsInKart
                    .Where(x => x.ProductID == Convert.ToInt32(shoppingKartView[0, e.RowIndex].Value))
                    .Select(x => x.Quantity).Single();

                if (Convert.ToInt32(shoppingKartView["Quantity", e.RowIndex].Value) > quantity)
                {
                    form_SystemMessage alert = new form_SystemMessage("Sorry.", $"Right now the quantity if this product available eguals \n{quantity}");
                    shoppingKartView[e.ColumnIndex, e.RowIndex].Value = 1;
                }
                else
                {
                    int productID = (int)shoppingKartView[0, e.RowIndex].Value;
                    int newQuantity = Convert.ToInt32(shoppingKartView["Quantity", e.RowIndex].Value);
                    dh.UpdateQuantityInKart(_shoppingKartID, productID, newQuantity);
                }
            }
        }
    }
}
