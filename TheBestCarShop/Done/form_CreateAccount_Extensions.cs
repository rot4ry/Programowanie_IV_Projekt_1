using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestCarShop
{
    public partial class form_CreateAccount : Form
    {
        private class ClickController
        {
            //This controls removing basic texts from fields on click
            //It might be solved with events?
            public bool _nameClicked            = false;
            public bool _secondNameClicked      = false;
            public bool _companyNameClicked     = false;
            public bool _emailClicked           = false;
            public bool _phoneNumberClicked     = false;

            public bool _countryClicked         = false;
            public bool _cityClicked            = false;
            public bool _streetClicked          = false;
            public bool _postcodeClicked        = false;
            public bool _buildingNumberClicked  = false;

            public bool _usernameClicked        = false;
            public bool _passwordClicked        = false;
            public bool _passwordRepeatClicked  = false;

            public bool IsReady()
            {
                if (_nameClicked == _secondNameClicked == _emailClicked == _phoneNumberClicked
                    == _countryClicked == _cityClicked == _streetClicked == _postcodeClicked
                    == _buildingNumberClicked == _passwordClicked ==
                    _passwordRepeatClicked == true)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        private static class DefaultTexts
        {
            public static string _name              = " First name ★";
            public static string _secondName        = " Second name ★";
            public static string _companyName       = " Company name";
            public static string _email             = " e-mail address ★";
            public static string _phoneNumber       = " Phone number ★";

            public static string _country           = " Country ★";
            public static string _city              = " City ★";
            public static string _street            = " Street ★";
            public static string _postcode          = " Postcode ★";
            public static string _buildingNumber    = " BuildingNumber ★";

            public static string _username          = " Username";
            public static string _password          = " Enter password ★";
            public static string _passwordRepeat    = " Repeat password ★";
        }
    }
}
