using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Microsoft.Data.SqlClient;

namespace TheBestCarShop
{
    public class DatabaseHandler
    {
        public string connectionString = @"
                    Data Source=DESKTOP-GSQML5J\MYSERVER;
                    Initial Catalog=TheShop;
                    Integrated Security=True;
                    Connect Timeout=30;
                    Encrypt=False;
                    TrustServerCertificate=False;
                    ApplicationIntent=ReadWrite;
                    MultiSubnetFailover=False";

        public void AddProduct()
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
        }

        public void AddOrder()
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
        }

        public void AddOrderDetail()
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
        }

        public bool CheckLoginData(string username, string password)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connectionString);
                
                var queryResult = 
                    (connection.Query<int>(
                    "SELECT *  " +
                    "FROM Clients " +
                    "WHERE Username = @username " +
                    "AND " +
                    "Password = @password "
                    , new { username = username, password = password })).Count();
                
                connection.Close();
                return queryResult == 1 ? true : false;
            }
            catch (Exception DatabaseHandlerException)
            {
                Console.WriteLine(DatabaseHandlerException.Message);
                Console.WriteLine("DatabaseHandlerException CheckLoginData");
                return false;
            }
        }

        public bool CheckUserAccess(string username, string password)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connectionString);
                var queryResult =
                    connection.Query<int>(
                    "SELECT * " +
                    "FROM Clients " +
                    "WHERE Username = @username " +
                    "AND Password = @password " +
                    "AND IsAdmin = 1",
                    new { username = username, password = password }).Count();

                connection.Close();
                return queryResult == 1 ? true : false;
            }
            catch (Exception DatabaseHandlerException)
            {
                Console.WriteLine(DatabaseHandlerException.Message);
                Console.WriteLine("DatabaseHandlerException CheckUserAccess");
                return false;
            }
        }

        public void AddUser(Client client, bool isAdmin = false)
        {

            SqlConnection connection = new SqlConnection(this.connectionString);
            connection.Execute(
                "INSERT INTO Clients([First name], " +
                "[Second name], [Company name], [E-mail], [Phone number], [Country], " +
                "[City], [Street], [Postcode], [Building number], " +
                "[Username], [Password],[IsAdmin]) " +

                "VALUES(@firstName, @secondName, @companyName, @email, @phone, " +
                "@country, @city, @street, @postcode, @buildingNumber, @username, " +
                "@password, @isAdmin)",
                new
                {
                    firstName       = client.FirstName,
                    secondName      = client.Surname,
                    companyName     = client.CompanyName,
                    email           = client.Email,
                    phone           = client.PhoneNumber,
                    country         = client.Country,
                    city            = client.City,
                    street          = client.Street,
                    postcode        = client.Postcode,
                    buildingNumber  = client.BuildingNumber,
                    username        = client.Username,
                    password        = client.Password,
                    isAdmin         = isAdmin
                });

            connection.Close();
        }

        public Client GetClientDetails(string username)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            var client = connection.Query<Client>(
                "SELECT *" +
                "FROM Clients" +
                "WHERE Username = @username", new { username = username });
            if (client.Count() > 1)
                throw new Exception("Multiple Clients with the same name, logical error.");
            else
            {
                List<Client> list = client.ToList<Client>();
                return list.First();
            }
        }
    }
}

