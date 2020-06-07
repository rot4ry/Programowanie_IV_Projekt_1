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
    public partial class form_ShoppingKart : Form
    {
        private DatabaseHandler dh = new DatabaseHandler();
        private Client _accountOwner;
        private int _shoppingKartID;

        private List<OrderDetail> shoppingKartList = new List<OrderDetail>();
        private List<Product> productList = new List<Product>();

        public form_ShoppingKart(Client client)
        {
            InitializeComponent();
            _accountOwner = client;
        }


        private void form_ShoppingKart_Load(object sender, EventArgs e)
        {
            _shoppingKartID = dh.GetShoppingKartID(_accountOwner.ClientID);
            shoppingKartList = dh.GetKartList(_shoppingKartID);
            BuildProductsList();
            ViewKart();
        }

        private void BuildProductsList()
        {
            foreach (var item in shoppingKartList)
            {
                Product product = dh.GetProduct(item.ProductID);
                productList.Add(product);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            int result = dh.ConfirmOrder(_accountOwner.ClientID, _shoppingKartID);
            if(result == 1)
            {
                form_SystemMessage success = new form_SystemMessage("Success!", "Your order is being prepared!", this);
            }
            else
            {
                form_SystemMessage success = new form_SystemMessage("Failure.", "Something went wrong, please try again.");
            }
        }

        private void clearKartButton_Click(object sender, EventArgs e)
        {
            dh.ClearKart(_shoppingKartID);
            ViewKart();
        }

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
        {//more 
            //building
            AddColumns();
            if(productList != null && shoppingKartList != null)
            {
                foreach(var item in productList)
                {
                    shoppingKartView.Rows.Add(
                        item.Name,
                        item.Price);
                }
            }
        }

    }

}


/*

private void ViewSearchResult(List<Product> searchResult)
{
    AddColumns();

    if (searchResult != null)
    {
        foreach (Product product in searchResult)
        {
            searchResultView.Rows.Add(
                product.ProductID,
                product.Category,
                product.Name,
                product.Manufacturer,
                Math.Round(product.Price, 2)
                );
        }
    }
    else
    {
        form_SystemMessage failure = new form_SystemMessage("Sorry.", "Something went wrong.");
    }
}


private void AddColumns()
{
    if (searchResultView.Columns["details"] == null)
    {
        searchResultView.Columns.Remove("detailsEmpty");
        ReplaceColumnWithButtons("details", "Show details");
    }
    if (searchResultView.Columns["toKart"] == null)
    {
        searchResultView.Columns.Remove("kartEmpty");
        ReplaceColumnWithButtons("toKart", "Add to kart");
    }
}
//Event handler for buttons in the DataGridView
private void searchResultView_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.ColumnIndex == searchResultView.Columns["details"].Index)
    {
        int productID = (int)searchResultView[0, e.RowIndex].Value;
        form_ProductDetailsWindow productDetails = new form_ProductDetailsWindow(productID);
        productDetails.ShowDialog();
    }

    else if (e.ColumnIndex == searchResultView.Columns["toKart"].Index)
    {
        int productID = (int)searchResultView[0, e.RowIndex].Value;
        dh.AddToKart(_shoppingKartID, productID);
    }
}
*/