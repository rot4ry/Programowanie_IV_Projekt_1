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
    public partial class form_ShopWindow : Form
    {
        private Client _accountOwner;
        private DatabaseHandler dh = new DatabaseHandler();

        public form_ShopWindow(Client client)
        {
            InitializeComponent();
            _accountOwner = client;
        }
        private void form_ShopWindow_Load(object sender, EventArgs e)
        {
            this.ActiveControl = titleLabel;
            LoadAllowedValues();
        }

        //values for combo boxes
        private List<Product> availableProductsList = new List<Product>();

        private List<string> carBrands = new List<string>();
        private List<string> carModels = new List<string>();
        private List<int> carProdYears = new List<int>();
        //what about years?
        private List<string> partCategories = new List<string>();
        private List<string> partManufacturers = new List<string>();
        private List<decimal> prices = new List<decimal>();

        private void LoadAllowedValues()
        {
            //gets list of available products and adds proper values to search fields
            availableProductsList = dh.GetAvailableProductsList();
            foreach(var product in availableProductsList)
            {
                carBrands.Add(product.CarBrand);
                carModels.Add(product.CarModel);
                carProdYears.Add(product.CarFirstProdYear);
                carProdYears.Add(product.CarLastProdYear);

                partCategories.Add(product.Category);
                partManufacturers.Add(product.Manufacturer);
                prices.Add(product.Price);
            }

            brandCBox.DataSource = carBrands;
            modelCBox.DataSource = carModels;
            firstYearCBox.DataSource = carProdYears;
            lastYearCBox.DataSource = carProdYears;

            categoryCBox.DataSource = partCategories;
            manufacturerCBox.DataSource = partManufacturers;
            priceFromCBox.DataSource = prices;
            priceToCBox.DataSource = prices;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shoppingKartButton_Click(object sender, EventArgs e)
        {
            form_ShoppingKart shoppingKart = new form_ShoppingKart();
            this.Hide();
            shoppingKart.ShowDialog();
        }

    }
}
