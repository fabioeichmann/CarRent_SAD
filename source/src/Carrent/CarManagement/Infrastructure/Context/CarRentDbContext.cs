using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Carrent.CarManagement.Domain;
using Carrent.CustomerManagement.Domain;
using Carrent.ReservationManagement.Domain;
using Carrent.Common.Infrastructure.Context;

namespace Carrent.CarManagement.Infrastructure.Context
{
    public class CarRentDbContext : BaseDbContext
    {
        #region Entities
        public CarRentDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("CarRent_Cars");
            modelBuilder.Entity<CarClass>().ToTable("CarRent_CarClasses");
            modelBuilder.Entity<Customer>().ToTable("CarRent_Customers");
            modelBuilder.Entity<Reservation>().ToTable("CarRent_Reservations");

            /*
            #region List of City
            var postcodes = new List<PostalCode>
            {
                new PostalCode
                {
                    Id = 100,
                    PostCode = "9244",
                    City = "Niederuzwil",
                    Country = "CH"
                },
                new PostalCode
                {
                    Id = 101,
                    PostCode = "9553",
                    City = "Bettwiesen",
                    Country = "CH"
                },
                new PostalCode
                {
                    Id = 102,
                    PostCode = "9445",
                    City = "Rebstein",
                    Country = "CH"
                },
                new PostalCode
                {
                    Id = 104,
                    PostCode = "9425",
                    City = "Thal",
                    Country = "CH"
                },
                new PostalCode
                {
                    Id = 105,
                    PostCode = "10115",
                    City = "Berlin",
                    Country = "DE"
                },
                new PostalCode
                {
                    Id = 106,
                    PostCode = "1000",
                    City = "Amsterdam",
                    Country = "NE"
                },
                new PostalCode
                {
                    Id = 107,
                    PostCode = "00031",
                    City = "Rom",
                    Country = "IT"
                }
            };
            #endregion

            #region List of Customer
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 10000,
                    Sex = (Sex)3,
                    Firstname= "Eric",
                    Familyname= "Lüchinger",
                    Street = "Hauptstrasse",
                    HouseNumber = "12",
                    PostalCodeId = 100,
                },
                new Customer
                {
                    Id = 10001,
                    Sex = (Sex)3,
                    Firstname= "Marta",
                    Familyname= "Kuster",
                    Street = "Bergstrasse",
                    HouseNumber = "25",
                    PostalCodeId = 101,
                }
            };
            #endregion

            #region List of CarClasses
            var carclasses = new List<CarClass>
            {
                new CarClass
                {
                    Id = 1,
                    Type = 0,
                    DailyPrice = 25
                },
                new CarClass
                {
                    Id = 2,
                    Type = (ClassType)1,
                    DailyPrice = 15
                },
                new CarClass
                {
                    Id = 3,
                    Type = (ClassType)2,
                    DailyPrice = 10
                }
            };
            #endregion

            #region List of Cars
            var cars = new List<Car>
            {
                new Car
                {
                    Id = 1000,
                    ClassId = 1,
                    Name = "",
                    Make = "",
                    Type = ""
                },
                new Car
                {
                    Id = 1001,
                    ClassId = 2,
                    Name = "",
                    Make = "",
                    Type = ""
                },
                new Car
                {
                    Id = 1001,
                    ClassId = 3,
                    Name = "",
                    Make = "",
                    Type = ""
                }
            };
            #endregion
            */
        }
    }
