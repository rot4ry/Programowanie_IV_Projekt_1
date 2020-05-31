using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

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

        public int AddUser(Client client, bool isAdmin = false)
        {

            SqlConnection connection = new SqlConnection(this.connectionString);
            int affected = connection.Execute(
                "INSERT INTO Clients([FirstName], " +
                "[SecondName], [CompanyName], [Email], [PhoneNumber], [Country], " +
                "[City], [Street], [Postcode], [BuildingNumber], " +
                "[Username], [Password],[IsAdmin]) " +

                "VALUES(@firstName, @secondName, @companyName, @email, @phone, " +
                "@country, @city, @street, @postcode, @buildingNumber, @username, " +
                "@password, @isAdmin)",
                new
                {
                    firstName       = client.FirstName,
                    secondName      = client.SecondName,
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
            return affected;
        }

        public Client GetClientDetails(string username)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            
            string query = @"SELECT 
                            [ClientID] 
                            ,[FirstName] 
                            ,[SecondName] 
                            ,[CompanyName] 
                            ,[Email] 
                            ,[PhoneNumber] 
                            ,[Country]
                            ,[City] 
                            ,[Street] 
                            ,[Postcode] 
                            ,[BuildingNumber]
                            ,[Username] 
                            ,[Password]
                            ,[IsAdmin] 
                            FROM Clients
                            WHERE Username = @username";
            
            Client client = connection.QuerySingle<Client>
                (query, new { username = username });
            connection.Close();
            
            return client;
        }
    }
}

