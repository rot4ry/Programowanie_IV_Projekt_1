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
    public partial class form_ProductDetailsWindow : Form
    {
        private DatabaseHandler dh = new DatabaseHandler();
        private int _id;
        private Product _product = new Product();
        
        public form_ProductDetailsWindow(int ID)
        {
            InitializeComponent();
            _id = ID;
        }

        private void form_ProductDetailsWindow_Load(object sender, EventArgs e)
        {
            _product = dh.GetProduct(_id);
            if(_product != null)
            {
                label5.Text = _product.Name;
                label6.Text = _product.Manufacturer;
                label7.Text = Math.Round(_product.Price,2).ToString();
                label8.Text = _product.Quantity.ToString();

                label10.Text = _product.CarBrand;
                label11.Text = _product.CarModel;
                label13.Text = _product.CarFirstProdYear.ToString();
                label15.Text = _product.CarLastProdYear.ToString();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
