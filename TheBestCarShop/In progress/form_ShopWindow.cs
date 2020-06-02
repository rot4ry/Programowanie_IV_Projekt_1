using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TheBestCarShop
{
    public partial class form_ShopWindow : Form
    {
        private Client _accountOwner;
        private DatabaseHandler dh = new DatabaseHandler();

        private List<Product> availableProductsList = new List<Product>();
        private List<decimal> priceRanges = new List<decimal>(){  0, 100, 200, 500,
                                                            1000, 3000, 5000, 10000,
                                                            20000, 50000, 100000};
        private List<int> productionYears = new List<int>();

        public form_ShopWindow(Client client)
        {
            InitializeComponent();
            _accountOwner = client;
        }

        private void form_ShopWindow_Load(object sender, EventArgs e)
        {
            this.ActiveControl = titleLabel;
            LoadProductValues();
            SetIndependentComboBoxValues();
            DefineYears();
            EmptyComboBoxes();
        }
        
        private void LoadProductValues()
        {
            availableProductsList = dh.GetAvailableProductsList();
        }

        //set independent values      
        private void SetIndependentComboBoxValues()
        {
            brandCBox.DataSource = availableProductsList.Select(x => x.CarBrand).Distinct().OrderBy(x => x).ToList<string>();
            categoryCBox.DataSource = availableProductsList.Select(x => x.Category).Distinct().OrderBy(x => x).ToList<string>();

            priceFromCBox.DataSource = priceRanges.OrderBy(x => x).ToList<decimal>();
            priceToCBox.DataSource = priceRanges.OrderByDescending(x => x).ToList<decimal>();
        }
        
        //set dependent values
        //e.g. when selecting Brand1, making Model1, model choice field 
        //mustn't show Brand2's Model2
        private void SetModels()
        {
            modelCBox.DataSource = availableProductsList.Where(x => x.CarBrand == brandCBox.Text).Select(x => x.CarModel).Distinct().ToList<string>();
            modelCBox.Text = "";
        }

        private void SetManufacturers()
        {
            manufacturerCBox.DataSource = availableProductsList.Where(x => x.Category == categoryCBox.Text).Select(x => x.Manufacturer).Distinct().ToList<string>();
            manufacturerCBox.Text = "";
        }
        
        private void SetYears()
        {
            int beginningOfProduction = availableProductsList.Select(x => x.CarFirstProdYear).OrderBy(x => x).First();
            int endOfProduction = availableProductsList.Select(x => x.CarFirstProdYear).OrderByDescending(x => x).First();
            productionYears.Clear();

            for (int i = beginningOfProduction; i <= endOfProduction; i++)
            {
                productionYears.Add(i);
            }
            firstYearCBox.DataSource = productionYears.OrderBy(x => x).ToList<int>();
            lastYearCBox.DataSource = productionYears.OrderByDescending(x => x).ToList<int>();

            firstYearCBox.Text = "";
            lastYearCBox.Text = "";
        }

        private void SetBrandYears()
        {
            //for particular brand
            int beginningOfProduction = availableProductsList.Where(x => x.CarBrand == brandCBox.Text).Select(x => x.CarFirstProdYear).OrderBy(x => x).First();
            int endOfProduction = availableProductsList.Where(x => x.CarBrand == brandCBox.Text).Select(x => x.CarLastProdYear).OrderByDescending(x => x).First();
            productionYears.Clear();

            for (int i = beginningOfProduction; i <= endOfProduction; i++)
            {
                productionYears.Add(i);
            }
            firstYearCBox.DataSource = productionYears.OrderBy(x => x).ToList<int>();
            lastYearCBox.DataSource = productionYears.OrderByDescending(x => x).ToList<int>();
            
            firstYearCBox.Text = "";
            lastYearCBox.Text = "";
        }

        private void SetModelYears()
        {
            //for a particular  brand & model
            int beginningOfProduction = availableProductsList.Where(x => x.CarBrand == brandCBox.Text && x.CarModel == modelCBox.Text).Select(x => x.CarFirstProdYear).OrderBy(x => x).First();
            int endOfProduction = availableProductsList.Where(x => x.CarBrand == brandCBox.Text && x.CarModel == modelCBox.Text).Select(x => x.CarLastProdYear).OrderByDescending(x => x).First();
            productionYears.Clear();
            
            for (int i = beginningOfProduction; i <= endOfProduction; i++)
            {
                productionYears.Add(i);
            }
            firstYearCBox.DataSource = productionYears.OrderBy(x => x).ToList<int>();
            lastYearCBox.DataSource = productionYears.OrderByDescending(x => x).ToList<int>();

            firstYearCBox.Text = "";
            lastYearCBox.Text = "";
        }



        //checking logical values 
        private void ValidateYears()
        {   
            try
            { 
            int fcbValue = Convert.ToInt32(firstYearCBox.Text); //might cause trouble
            lastYearCBox.DataSource = productionYears.Where(x => x >= fcbValue).OrderByDescending(x => x).ToList<int>();
            lastYearCBox.Text = "";
            }
            catch (Exception ConvertException)
            {
                Console.WriteLine(ConvertException.Message);
                EmptyComboBoxes();
            }
        }

        private void ValidatePrices()
        {
            try
            {
                int pcbValue = Convert.ToInt32(priceFromCBox.Text); //might cause trouble
                priceToCBox.DataSource = priceRanges.Where(x => x >= pcbValue).OrderByDescending(x => x).ToList<decimal>();
                priceToCBox.Text = "";
            }
            catch(Exception ConvertException)
            {
                Console.WriteLine(ConvertException.Message);
                EmptyComboBoxes();
            }
        }

        private void DefineYears()
        {
            if (brandCBox.Text != "" && modelCBox.Text != "") SetModelYears();
            else if (brandCBox.Text != "") SetBrandYears();
            else SetYears();
        }

        private void EmptyComboBoxes()
        {
            brandCBox.Text = "";
            modelCBox.Text = "";
            firstYearCBox.Text = "";
            lastYearCBox.Text = "";
            categoryCBox.Text = "";
            manufacturerCBox.Text = "";
            priceFromCBox.Text = "";
            priceToCBox.Text = "";
        }

        private void clearButtons_Click(object sender, EventArgs e)
        {
            EmptyComboBoxes();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shoppingKartButton_Click(object sender, EventArgs e)
        {
            form_ShoppingKart shoppingKart = new form_ShoppingKart();
            shoppingKart.ShowDialog();
        }
        //Car details
        private void brandCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetModels();
            DefineYears();
        }
        private void modelCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefineYears();
        }
        private void firstYearCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateYears();
        }


        //Product details
        private void categoryCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetManufacturers();
        }

        private void priceFromCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidatePrices();
        }
    }
}
