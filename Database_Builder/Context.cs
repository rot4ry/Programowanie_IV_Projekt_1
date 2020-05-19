using System;   
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Database_Builder
{
    public class Context : DbContext
    {
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

            //Primary Key 
            mb.Entity<Product>().HasKey(x => x.ID);

            mb.Entity<Product>().Property(x => x.ID)
                .HasColumnType("int").UseIdentityColumn(1, 1)
                .HasColumnName("ID")
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


        }
    }
}

