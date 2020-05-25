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
    public partial class form_MainAdminWindow : Form
    {
        private Client _accountOwner;
        
        public form_MainAdminWindow()
        {
            InitializeComponent();
        }

        public form_MainAdminWindow(Client client)
        {
            InitializeComponent();
            _accountOwner = client;
        }
        //division into main admin and users-admins
    }
}
