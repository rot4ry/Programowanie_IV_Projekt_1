using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            LoadProductValues();
            SetIndependentComboBoxValues();
            SetYears();
            ResetFilterValues();
        }

        //CONSTRUCTION OF THE FILTER VALUES SECTION
        private List<Product> availableProductsList = new List<Product>();
        private List<string> productionYears = new List<string>();
        private List<string> priceRanges = new List<string>(){"0", "100", "200", "500",
                                                            "1000", "3000", "5000", "10000",
                                                            "20000", "50000", "100000"};

        private string defaultBrandText = "Choose a brand";
        private string defaultModelText = "Choose a model";
        private string defaultYearText = "Choose a year";
        private string defaultCategoryText = "Choose a category";
        private string defaultManufacturerText = "Choose a manufacturer";
        private string defaultPriceText = "Choose price range";


        private void LoadProductValues()
        {
            availableProductsList = dh.GetAvailableProductsList();
        }

        //set independent values      
        private void SetIndependentComboBoxValues()
        {
            brandCBox.DataSource = availableProductsList
                                        .Select(x => x.CarBrand.ToString())
                                        .Distinct()
                                        .OrderBy(x => x)
                                        .Reverse()
                                        .Append(defaultBrandText)
                                        .Reverse()
                                        .ToList<string>();

            categoryCBox.DataSource = availableProductsList
                                        .Select(x => x.Category)
                                        .Distinct()
                                        .OrderBy(x => x)
                                        .Reverse()
                                        .Append(defaultCategoryText)
                                        .Reverse()
                                        .ToList<string>();
            //change to strings
            priceFromCBox.DataSource = priceRanges
                                        .OrderByDescending(x => Convert.ToDecimal(x))
                                        .Append(defaultPriceText)
                                        .Reverse()
                                        .ToList<string>();

            priceToCBox.DataSource = priceRanges
                                        .OrderBy(x => Convert.ToDecimal(x))
                                        .Append(defaultPriceText)
                                        .Reverse()
                                        .ToList<string>();
        }

        //set dependent values
        //e.g. when selecting Brand1, making Model1, model choice field 
        //mustn't show Brand2's Model1
        private void SetModels()
        {
            modelCBox.DataSource = availableProductsList
                                    .Where(x => x.CarBrand == brandCBox.Text.ToString())
                                    .Select(x => x.CarModel)
                                    .Distinct()
                                    .OrderBy(x => x)
                                    .Reverse()
                                    .Append(defaultModelText)
                                    .Reverse()
                                    .ToList<string>();

            modelCBox.Text = defaultModelText;
        }

        private void SetManufacturers()
        {
            manufacturerCBox.DataSource = availableProductsList
                                    .Where(x => x.Category == categoryCBox.Text.ToString())
                                    .Select(x => x.Manufacturer)
                                    .Distinct()
                                    .OrderBy(x => x)
                                    .Reverse()
                                    .Append(defaultManufacturerText)
                                    .Reverse()
                                    .ToList<string>();

            manufacturerCBox.Text = defaultManufacturerText;
        }

        private void SetYears()
        {
            //for all brands and models
            int beginningOfProduction = availableProductsList
                                    .Select(x => x.CarFirstProdYear)
                                    .Min();

            int endOfProduction = availableProductsList
                                    .Select(x => x.CarFirstProdYear)
                                    .Max();

            productionYears.Clear();

            for (int i = beginningOfProduction; i <= endOfProduction; i++)
            {
                productionYears.Add(i.ToString());
            }

            firstYearCBox.DataSource = productionYears
                                    .OrderBy(x => x)
                                    .Reverse()
                                    .Append(defaultYearText)
                                    .Reverse()
                                    .ToList<string>();

            lastYearCBox.DataSource = productionYears
                                    .OrderByDescending(x => x)
                                    .Reverse()
                                    .Append(defaultYearText)
                                    .Reverse()
                                    .ToList<string>();

            firstYearCBox.Text = defaultYearText;
            lastYearCBox.Text = defaultYearText;
        }

        private void SetBrandYears()
        {
            //for particular brand
            int beginningOfProduction = availableProductsList.Select(x => x.CarFirstProdYear).Min();
            int endOfProduction = availableProductsList.Select(x => x.CarLastProdYear).Max();
            try
            {
                beginningOfProduction = availableProductsList
                                    .Where(x => x.CarBrand.Contains(brandCBox.Text.ToString()))
                                    .Select(x => x.CarFirstProdYear)
                                    .Min();
            }
            catch (Exception bopException) { Console.WriteLine(bopException); }

            try
            {
                endOfProduction = availableProductsList
                                    .Where(x => x.CarBrand.Contains(brandCBox.Text.ToString()))
                                    .Select(x => x.CarLastProdYear)
                                    .Max();
            }
            catch (Exception eopException) { Console.WriteLine(eopException.Message); }

            productionYears.Clear();

            for (int i = beginningOfProduction; i <= endOfProduction; i++)
            {
                productionYears.Add(i.ToString());
            }

            firstYearCBox.DataSource = productionYears
                                    .OrderBy(x => x)
                                    .Reverse()
                                    .Append(defaultYearText)
                                    .Reverse()
                                    .ToList<string>();

            lastYearCBox.DataSource = productionYears
                                    .OrderByDescending(x => x)
                                    .Reverse()
                                    .Append(defaultYearText)
                                    .Reverse()
                                    .ToList<string>();

            firstYearCBox.Text = defaultYearText;
            lastYearCBox.Text = defaultYearText;
        }

        private void SetModelYears()
        {
            //for a particular brand & model
            int beginningOfProduction = availableProductsList.Select(x => x.CarFirstProdYear).Min();
            int endOfProduction = availableProductsList.Select(x => x.CarLastProdYear).Max();

            try
            {
                beginningOfProduction = availableProductsList
                .Where(x => x.CarBrand.Contains(brandCBox.Text.ToString()) && x.CarModel.Contains(modelCBox.Text.ToString()))
                .Select(x => x.CarFirstProdYear)
                .Min();
            }
            catch (Exception bopException) { Console.WriteLine(bopException); }

            try
            {
                endOfProduction = availableProductsList
                .Where(x => x.CarBrand.Contains(brandCBox.Text.ToString()) && x.CarModel.Contains(modelCBox.Text.ToString()))
                .Select(x => x.CarLastProdYear)
                .Max();
            }
            catch (Exception eopException) { Console.WriteLine(eopException.Message); }

            productionYears.Clear();

            for (int i = beginningOfProduction; i <= endOfProduction; i++)
            {
                productionYears.Add(i.ToString());
            }

            firstYearCBox.DataSource = productionYears
                                    .OrderBy(x => x)
                                    .Reverse()
                                    .Append(defaultYearText)
                                    .Reverse()
                                    .ToList<string>();

            lastYearCBox.DataSource = productionYears
                                    .OrderByDescending(x => x)
                                    .Reverse()
                                    .Append(defaultYearText)
                                    .Reverse()
                                    .ToList<string>();

            firstYearCBox.Text = defaultYearText;
            lastYearCBox.Text = defaultYearText;
        }


        //checking logical values 
        private void ValidateYears()
        {
            try
            {
                int fcbValue = Convert.ToInt32(firstYearCBox.Text.ToString()); //might cause trouble
                lastYearCBox.DataSource = productionYears
                                        .Where(x => Convert.ToInt32(x) >= fcbValue)
                                        .OrderBy(x => x)
                                        .Append(defaultYearText)
                                        .Reverse()
                                        .ToList<string>();

                lastYearCBox.Text = defaultYearText;
            }
            catch (Exception ConvertException)
            {
                Console.WriteLine(ConvertException.Message);
                firstYearCBox.Text = defaultYearText;
                lastYearCBox.Text = defaultYearText;
            }
        }

        private void ValidatePrices()
        {
            try
            {
                decimal pcbValue = Convert.ToDecimal(priceFromCBox.Text.ToString()); //might cause trouble
                priceToCBox.DataSource = priceRanges
                                    .Where(x => Convert.ToDecimal(x) >= pcbValue)
                                    .Append(defaultPriceText)
                                    .Reverse()
                                    .ToList<string>();

                priceToCBox.Text = defaultPriceText;
            }
            catch (Exception ConvertException)
            {
                Console.WriteLine(ConvertException.Message);
                priceFromCBox.Text = defaultPriceText;
                priceToCBox.Text = defaultPriceText;
            }
        }

        private void YearsBasedOnInput()
        {
            if (brandCBox.Text.ToString() != defaultBrandText &&
                modelCBox.Text.ToString() != defaultModelText)
                SetModelYears();

            else if (brandCBox.Text.ToString() != defaultBrandText)
                SetBrandYears();

            else
                SetYears();
        }

        private void ResetFilterValues()
        {
            brandCBox.Text = defaultBrandText;
            modelCBox.Text = defaultModelText;
            firstYearCBox.Text = defaultYearText;
            lastYearCBox.Text = defaultYearText;
            categoryCBox.Text = defaultCategoryText;
            manufacturerCBox.Text = defaultManufacturerText;
            priceFromCBox.Text = defaultPriceText;
            priceToCBox.Text = defaultPriceText;
            SetFilters();
        }

        //Buttons
        private void clearButtons_Click(object sender, EventArgs e)
        {
            ResetFilterValues();
            searchResultView.Rows.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SetFilters();
            ViewSearchResult(BuildSearchResult());
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

        
        //FILTERING CONTRAPTION
        private delegate void FilterResult(ref List<Product> products);
        private FilterResult Filter;

        private void SetFilters()
        {
            Filter += FilterByNone;
            SetBrandFilter();
            SetModelFliter();
            SetFirstYearFilter();
            SetLastYearFilter();
            SetCategoryFilter();
            SetManufacturerFilter();
            SetBottomPriceFilter();
            SetTopPriceFilter();
        }

        private void FilterByNone(ref List<Product> products)
        {
            #pragma warning disable CS1717 // Assignment made to same variable
            products = products;
            #pragma warning restore CS1717 // Assignment made to same variable
        }

        private void FilterByBrand(ref List<Product> products)
        {
            string brand = brandCBox.Text.ToString();
            products = products.Where(x => x.CarBrand.Contains(brand)).ToList<Product>();
        }
        private void SetBrandFilter()
        {
            if (brandCBox.Text.ToString() != defaultBrandText)
            {
                Filter += FilterByBrand;
            }
            else if (brandCBox.Text.ToString() == defaultBrandText)
            {
                Filter -= FilterByBrand;
            }
        }

        private void FilterByModel(ref List<Product> products)
        {
            string model = modelCBox.Text.ToString();
            products = products.Where(x => x.CarModel.Contains(model)).ToList<Product>();
        }
        private void SetModelFliter()
        {
            if (modelCBox.Text.ToString() != defaultModelText)
            {
                Filter += FilterByModel;
            }
            else if (modelCBox.Text.ToString() == defaultModelText)
            {
                Filter -= FilterByModel;
            }
        }

        private void FilterByFirstYear(ref List<Product> products)
        {
            try
            {
                int firstYear = Convert.ToInt32(firstYearCBox.Text.ToString());
                products = products.Where(x => x.CarFirstProdYear >= firstYear).ToList<Product>();
            }
            catch (FormatException fe) { Console.WriteLine(fe.Message); }
        }
        private void SetFirstYearFilter()
        {
            if (firstYearCBox.Text.ToString() != defaultYearText)
            {
                Filter += FilterByFirstYear;
            }
            else if (firstYearCBox.Text.ToString() == defaultYearText)
            {
                Filter -= FilterByFirstYear;
            }
        }

        private void FilterByLastYear(ref List<Product> products)
        {
            try
            {
                int lastYear = Convert.ToInt32(lastYearCBox.Text.ToString());
                products = products.Where(x => x.CarLastProdYear <= lastYear).ToList<Product>();
            }
            catch (FormatException fe) { Console.WriteLine(fe.Message); }
        }
        private void SetLastYearFilter()
        {
            if (lastYearCBox.Text.ToString() != defaultYearText)
            {
                Filter += FilterByLastYear;
            }
            else if (lastYearCBox.Text.ToString() == defaultYearText)
            {
                Filter -= FilterByLastYear;
            }
        }

        private void FilterByCategory(ref List<Product> products)
        {
            string category = categoryCBox.Text.ToString();
            products = products.Where(x => x.Category.Contains(category)).ToList<Product>();
        }
        private void SetCategoryFilter()
        {
            if (categoryCBox.Text.ToString() != defaultCategoryText)
            {
                Filter += FilterByCategory;
            }
            else if (categoryCBox.Text.ToString() == defaultCategoryText)
            {
                Filter -= FilterByCategory;
            }
        }

        private void FilterByManufacturer(ref List<Product> products)
        {
            string manufacturer = manufacturerCBox.Text.ToString();
            products = products.Where(x => x.Manufacturer.Contains(manufacturer)).ToList<Product>();
        }
        private void SetManufacturerFilter()
        {
            if (manufacturerCBox.Text.ToString() != defaultManufacturerText)
            {
                Filter += FilterByManufacturer;
            }
            else if (manufacturerCBox.Text.ToString() == defaultManufacturerText)
            {
                Filter -= FilterByManufacturer;
            }
        }

        private void FilterByPriceBottom(ref List<Product> products)
        {
            try
            {
                decimal price = Convert.ToDecimal(priceFromCBox.Text.ToString());
                products = products.Where(x => x.Price >= price).ToList<Product>();
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
        private void SetBottomPriceFilter()
        {
            if (priceFromCBox.Text.ToString() != defaultPriceText)
            {
                Filter += FilterByPriceBottom;
            }
            else if (priceFromCBox.Text.ToString() == defaultPriceText)
            {
                Filter -= FilterByPriceBottom;
            }
        }

        private void FilterByPriceTop(ref List<Product> products)
        {
            try
            {
                decimal price = Convert.ToDecimal(priceToCBox.Text.ToString());
                products = products.Where(x => x.Price <= price).ToList<Product>();
            }
            catch (FormatException fe) { Console.WriteLine(fe.Message); }
        }
        private void SetTopPriceFilter()
        {
            if (priceToCBox.Text.ToString() != defaultPriceText)
            {
                Filter += FilterByPriceTop;
            }
            else if (priceToCBox.Text.ToString() == defaultPriceText)
            {
                Filter -= FilterByPriceTop;
            }
        }
    

        //SEARCH RESULT 
        private List<Product> BuildSearchResult()
        {
            searchResultView.Rows.Clear();

            List<Product> searchResult = dh.GetAvailableProductsList();
            SetFilters();
            try
            {
                Filter(ref searchResult);
                return searchResult;
            }
            catch(Exception emptyListException)
            {
                Console.WriteLine(emptyListException.Message);
                return (List<Product>)null;
            }
        }
        
        private void ViewSearchResult(List<Product> searchResult)
        {
            AddColumns();

            if (searchResult != null)
            {
                foreach (Product product in searchResult)
                {
                    searchResultView.Rows.Add(
                        partID.Tag = product.ProductID,
                        partCategory.Tag = product.Category,
                        partName.Tag = product.Name,
                        partManufacturer.Tag = product.Manufacturer,
                        partPrice.Tag = product.Price
                        );
                }
            }
            else
            {
                form_SystemMessage failure = new form_SystemMessage("Sorry.", "Something went wrong.");
            }
        }

        private void ReplaceColumnWithButtons(string name, string text)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            {
                buttonColumn.Name = name;
                buttonColumn.HeaderText = "";
                buttonColumn.Text = text;
                buttonColumn.UseColumnTextForButtonValue = true;
                buttonColumn.Width = 152;

                buttonColumn.DefaultCellStyle = new DataGridViewCellStyle()
                {
                    //WELCOME TO THE HOUSE OF FUN
                    BackColor   = stylingButton.BackColor,
                    ForeColor   = stylingButton.ForeColor,
                    Font        = stylingButton.Font,
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                };
                this.searchResultView.Columns.Add(buttonColumn);
            }
        }

        private void AddColumns()
        {
            if(searchResultView.Columns["details"] == null)
            {
                searchResultView.Columns.Remove("detailsEmpty");
                ReplaceColumnWithButtons("details", "Show details");
            }
            if(searchResultView.Columns["toKart"] == null)
            {
                searchResultView.Columns.Remove("kartEmpty");
                ReplaceColumnWithButtons("toKart", "Add to kart");
            }
        }
        //Event handler for buttons in the DataGridView
        private void searchResultView_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if(e.ColumnIndex == searchResultView.Columns["details"].Index)
            {
                int productID = (int)searchResultView[0, e.RowIndex].Value;
                form_ProductDetailsWindow productDetails = new form_ProductDetailsWindow(productID);
                productDetails.ShowDialog();
            }

            else if(e.ColumnIndex == searchResultView.Columns["toKart"].Index)
            {
                int productID = (int)searchResultView[0, e.RowIndex].Value;
                //place for a shopping kart list, then pushed to shopping kart form
            }
        }

        //Combo boxes' event handlers => validating and setting up filters
        //[BRAND]
        private void brandCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetModels();
            YearsBasedOnInput();
        }
        private void brandCBox_Leave(object sender, EventArgs e)
        {
            SetModels();
            YearsBasedOnInput();
        }
        private void brandCBox_TextUpdate(object sender, EventArgs e)
        {
            SetModels();
            YearsBasedOnInput();
        }

        //[MODEL]
        private void modelCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearsBasedOnInput();
        }
        private void modelCBox_Leave(object sender, EventArgs e)
        {
            YearsBasedOnInput();
        }
        private void modelCBox_TextChanged(object sender, EventArgs e)
        {
            YearsBasedOnInput();
        }

        //[FIRST YEAR]
        private void firstYearCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateYears();
        }
        private void firstYearCBox_Leave(object sender, EventArgs e)
        {
            ValidateYears();
        }
        private void firstYearCBox_TextChanged(object sender, EventArgs e)
        {
            ValidateYears();
        }

        //[CATEGORY]
        private void categoryCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetManufacturers();
        }
        private void categoryCBox_Leave(object sender, EventArgs e)
        {
            SetManufacturers();
        }
        private void categoryCBox_TextChanged(object sender, EventArgs e)
        {
            SetManufacturers();
        }

        //[PRICE FROM]
        private void priceFromCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidatePrices();
        }
        private void priceFromCBox_Leave(object sender, EventArgs e)
        {
            ValidatePrices();
        }
        private void priceFromCBox_TextChanged(object sender, EventArgs e)
        {
            ValidatePrices();
        }
    }
}

