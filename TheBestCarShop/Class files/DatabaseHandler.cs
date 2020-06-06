using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
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
        
        //PRODUCT RELATED METHODS
        public List<Product> GetAvailableProductsList()
        {
            IEnumerable<Product> queryResult;
            List<Product> availableProductsList = new List<Product>();

            string query = "SELECT * FROM Products WHERE IsAvailable=1";

            try
            {
                SqlConnection connection = new SqlConnection(this.connectionString);
                queryResult = connection.Query<Product>(query);
                foreach(var item in queryResult)
                {
                    availableProductsList.Add((Product)item);
                }
                connection.Close();
                return availableProductsList;
            }
            catch (Exception DatabaseHandlerException)
            {
                Console.WriteLine(DatabaseHandlerException.Message);
                return (List<Product>) null;
            }
        }
        
        public Product GetProduct(int id)
        {
            string query = "SELECT * FROM Products WHERE ProductID = @id";
            try
            {
                SqlConnection connection = new SqlConnection(this.connectionString);
                Product product = connection.QuerySingle<Product>(query, new { id = id });
                connection.Close();

                return product;
            }
            catch(Exception DatabaseHandlerException)
            {
                Console.WriteLine(DatabaseHandlerException.Message);
                return (Product)null;
            }
        }

        //ORDER RELATED METHODS
        public int AddUnplacedOrder(int ClientID)
        {
            string insert = 
                "INSERT INTO Orders([CustomerID],[ReceivedDate],[SentDate],[DeliveredDate],[IsPlaced]) " +
                "VALUES (@customerId, @receivedDate, @sentDate, @deliveredDate, @isPlaced)";
            int affected = 0;
            try
            {
                SqlConnection connection = new SqlConnection(this.connectionString);
                affected = connection.Execute(insert,
                    new {   customerId = ClientID, 
                            receivedDate = DateTime.Now,
                            sentDate = DateTime.Now,    
                            deliveredDate = DateTime.Now,
                            isPlaced = false 
                    });
            }
            catch(Exception DatabaseHandlerException)
            {
                Console.WriteLine(DatabaseHandlerException.Message);
            }
            return affected;
        }

        public void ConfirmOrder(int ClientID)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            //set IsPlaced = true
            //set current shopping kart order as an actual order, 
            //will not be removed when logging out 
            
            //also, update values by order detail quantities
        }

        public int RemoveUnplacedOrder(int ClientID)
        {
            string delete = "DELETE FROM Orders " +
                            "WHERE CustomerID = @clientID " +
                            "AND IsPlaced = 'false'";
            int affected = 0;
            try
            {
                SqlConnection connection = new SqlConnection(this.connectionString);
                affected = connection.Execute(delete, new { clientID = ClientID });
            }
            catch(Exception DatabaseHandlerException)
            {
                Console.WriteLine(DatabaseHandlerException.Message);
            }
            return affected;
        }

        public void RemoveAllUnplacedOrders()
        {
            //just for making sure no unplaced orders occupy the database

        }
        
        //ORDER DETAILS RELATED METHODS
        
        public void AddOrderDetail()
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
        }

        public void RemoveOrderDetail()
        {

        }

        //USER RELATED METHODS
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
                    firstName = client.FirstName,
                    secondName = client.SecondName,
                    companyName = client.CompanyName,
                    email = client.Email,
                    phone = client.PhoneNumber,
                    country = client.Country,
                    city = client.City,
                    street = client.Street,
                    postcode = client.Postcode,
                    buildingNumber = client.BuildingNumber,
                    username = client.Username,
                    password = client.Password,
                    isAdmin = isAdmin
                });

            connection.Close();
            return affected;
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
            try
            {
                Client client = connection.QuerySingle<Client>
                    (query, new { username = username });
                connection.Close();
                return client;
            }
            catch(Exception DatabaseHandlerException)
            {
                Console.WriteLine(DatabaseHandlerException.Message);
                return (Client)null;
            }
        }

        public int UpdateClientField(string columnName, string value, string username)
        {
            int affected = 0;
            SqlConnection connection = new SqlConnection(this.connectionString);
            string update = "UPDATE Clients " +
                            $"SET {columnName} = @value " +
                            "WHERE Username = @username ";
            try
            {
                affected = connection.Execute(update, new { value = value, username = username });
            }
            catch (Exception DatabaseHandlerException) { Console.WriteLine(DatabaseHandlerException.Message); }

            if (affected == 1)
            {
                form_SystemMessage success = new form_SystemMessage("Success!", $"Data has been updated!");
            }
            else
            {
                form_SystemMessage failure = new form_SystemMessage("Failure!", "Something went wrong.");
            }
            
            connection.Close();
            return affected;
        }

        public int DeleteClient(string username)
        {
            int affected = 0;

            SqlConnection connection = new SqlConnection(this.connectionString);
            string delete = "DELETE Clients WHERE Username = @username";

            try
            {
                affected = connection.Execute(delete, new { username = username });
            }
            catch(Exception DatabaseHandlerException)
            {
                Console.WriteLine(DatabaseHandlerException.Message);
            }
            
            return affected;
        }
    }
}

