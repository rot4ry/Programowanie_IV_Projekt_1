using System;
using System.Drawing;
using System.Windows.Forms;


namespace TheBestCarShop
{
    public partial class form_SystemMessage : Form
    {
 
        public Form __callingForm = new Form();       
        
        private void SetCaller(Form callingForm)
        {
            if (callingForm != null) __callingForm = callingForm;
        }

        /*
         * When constructor's parameter <Form callingForm> is NOT null 
         * it will cause the <acceptButton> to close BOTH: 
         * form_SystemMessage object
         * AND
         * object of the form that called the SystemMessage
         * 
         * This might be useful while calling some error/success messages
         * in different parts of code
         * 
         * There might be a better way.
         */


        public form_SystemMessage()
        {
            InitializeComponent();
            this.Show();
        }

        public form_SystemMessage(string message, string description = null, Form callingForm = null)
        {
            SetCaller(callingForm);
            InitializeComponent();
            
            messageLabel.Text = message;
            
            if (description == null)
            {
                descriptionLabel.Visible = false;
                messageLabel.Location = new Point(messageLabel.Location.X, messageLabel.Location.Y + 20);
            }
            else descriptionLabel.Text = description;
            this.Show();
        }
        
        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if(__callingForm != null)   __callingForm.Close();
        }
    }
}


