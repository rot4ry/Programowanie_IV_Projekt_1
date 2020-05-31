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
        private Client _accountOwner = new Client();
        private DatabaseHandler dh = new DatabaseHandler();
        
        public form_MainAdminWindow()
        {
            InitializeComponent();
            _accountOwner = null;
        }

        public form_MainAdminWindow(string username)
        {
            InitializeComponent();
            _accountOwner = dh.GetClientDetails(username);
        }
        //division into main admin and users-admins
    }
}
