using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Builder;
using Microsoft.EntityFrameworkCore;

namespace Database_Builder
{
    public class Context : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = @"
                    Data Source=DESKTOP-GSQML5J\MYSERVER;
                    Initial Catalog=TheShop;
                    Integrated Security=True;
                    Connect Timeout=30;
                    Encrypt=False;
                    TrustServerCertificate=False;
                    ApplicationIntent=ReadWrite;
                    MultiSubnetFailover=False";

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            /*
             * <Client's configuration>
             */
            mb.Entity<Client>().HasKey(x => x.ClientID);

            mb.Entity<Client>().Property(x => x.ClientID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("Client ID")
                .HasColumnType("int")
                .IsRequired();

            //Client's details
            mb.Entity<Client>().Property(x => x.FirstName)
                .HasColumnName("First name")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.Surname)
                .HasColumnName("Second name")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.CompanyName)
                .HasColumnName("Company name")
                .HasColumnType("varchar(255)");

            mb.Entity<Client>().Property(x => x.Email)
                .HasColumnName("E-mail")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.PhoneNumber)
                .HasColumnName("Phone number")
                .HasColumnType("varchar(15)")
                .IsRequired();

            //client's address
            mb.Entity<Client>().Property(x => x.Country)
                .HasColumnName("Country")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.City)
                .HasColumnName("City")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.Street)
                .HasColumnName("Street")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.Postcode)
                .HasColumnName("Postcode")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.BuildingNumber)
                .HasColumnName("Building number")
                .HasColumnType("varchar(20)")
                .IsRequired();

            //account details - It's entirely unsafe to keep them here

            mb.Entity<Client>().Property(x => x.Username)
                .HasColumnName("Username")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.Password)
                .HasColumnName("Password")
                .HasColumnType("varchar(255)")
                .IsRequired();

            mb.Entity<Client>().Property(x => x.IsAdmin)
                .HasColumnType("bit")
                .IsRequired();

            /*
             * <End of Clients configuration>
             */

            



            /*
             * <Orders configuration> 
             */
            //Primary Key
            mb.Entity<Order>().HasKey(x => x.OrderID);

            mb.Entity<Order>().Property(x => x.OrderID)
                .HasColumnType("int")
                .UseIdentityColumn(1, 1)
                .IsRequired();

            //Details
            mb.Entity<Order>().Property(x => x.CustomerID)
                .HasColumnType("int")
                .HasColumnName("Client ID")
                .IsRequired();

            mb.Entity<Order>().Property(x => x.ReceivedDate)
                .HasColumnType("datetime")
                .IsRequired();

            mb.Entity<Order>().Property(x => x.SentDate)
                .HasColumnType("datetime")
                .IsRequired();

            mb.Entity<Order>().Property(x => x.DeliveredDate)
                .HasColumnType("datetime")
                .IsRequired();

            /*
             * <End of Orders configuration>
             */



            /*
             * <OrderDetails configuration>
             */

            mb.Entity<OrderDetail>().HasNoKey();

            mb.Entity<OrderDetail>().Property(x => x.OrderID)
                .HasColumnType("int")
                .UseIdentityColumn(1, 1)
                .IsRequired();

            mb.Entity<OrderDetail>().Property(x => x.ProductID)
                .HasColumnType("int")
                .IsRequired();

            mb.Entity<OrderDetail>().Property(x => x.Price)
                .HasColumnType("money")
                .IsRequired();

            mb.Entity<OrderDetail>().Property(x => x.Quantity)
                .HasColumnType("int")
                .IsRequired();
            /*
             * <End of OrderDetails configuration>
             */



            /*
             * <Product configuration>
             */
            //Primary Key 
            mb.Entity<Product>().HasKey(x => x.ProductID);

            mb.Entity<Product>().Property(x => x.ProductID)
                .HasColumnType("int").UseIdentityColumn(1, 1)
                .IsRequired();

            //Car details
            mb.Entity<Product>().Property(x => x.CarBrand)
                .HasColumnType("varchar(255)")
                .HasColumnName("Brand")
                .IsRequired();

            mb.Entity<Product>().Property(x => x.CarModel)
                .HasColumnType("varchar(255)")
                .HasColumnName("Model")
                .IsRequired();

            mb.Entity<Product>().Property(x => x.CarFirstProdYear)
                .HasColumnType("int")
                .HasColumnName("Beginning of model production")
                .IsRequired();

            mb.Entity<Product>().Property(x => x.CarLastProdYear)
                .HasColumnType("int")
                .HasColumnName("End of model production")
                .IsRequired();

            //Price
            mb.Entity<Product>().Property(x => x.Price)
                .HasColumnType("money")
                .HasColumnName("Price")
                .IsRequired();

            //Product details
            mb.Entity<Product>().Property(x => x.PartName)
                .HasColumnType("varchar(255)")
                .HasColumnName("Name")
                .IsRequired();

            mb.Entity<Product>().Property(x => x.PartCategory)
                .HasColumnType("varchar(50)")
                .HasColumnName("Category")
                .IsRequired();

            mb.Entity<Product>().Property(x => x.PartManufacturer)
                .HasColumnType("varchar(255)")
                .HasColumnName("Manufacturer")
                .IsRequired();

            mb.Entity<Product>().Property(x => x.PartCode)
                .HasColumnType("varchar(36)")
                .HasColumnName("Code")
                .IsRequired();

            mb.Entity<Product>().Property(x => x.IsAvailable)
                .HasColumnName("Is Available?")
                .IsRequired();

            mb.Entity<Product>().Property(x => x.QtAvailable)
                .HasColumnName("Quantity")
                .HasColumnType("int");
            /*
             * <End of Product configuration>
             */

        }
    }
}

