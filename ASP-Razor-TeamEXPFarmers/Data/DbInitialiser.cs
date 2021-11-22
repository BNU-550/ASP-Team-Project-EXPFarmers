using ASP_Razor_TeamEXPFarmers.Models;
using System;
using System.Collections.Generic;

namespace ASP_Razor_TeamEXPFarmers.Data
{
    /// <summary>
    /// Initialises the database by seeding data, having at least 10 records
    /// in each table and demonstrating the relationships from the ERD.
    /// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (22/11/2021)
    /// </summary>
    public static class DbInitialiser
    {
        /// TODO: Start with seeding Person, Staff, Address, Payment [first half] 
        /// Order, OrderItem, Platform, VideoGame [second half] in that order.
        /// 
        /// At least 10 of each.
        /// 
        /// Ensure an order has many items on it, a video game has been sold
        /// many times, a video game has many platforms etc (check ERD for
        /// relationships).
        /// 
        /// See Contoso example for guidance:
        /// "https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?
        /// view=aspnetcore-6.0&tabs=visual-studio#seed-the-database" [URL]
        public static void Initialise(ApplicationDbContext context)
        {
            /// Instantiating lists using ICollection. Commenting out as
            /// I'm not sure if they're needed here.
            /// 
            /// ICollection<OrderItem> orderItemList = new List<OrderItem>();
            /// ICollection<Order> orderList = new List<Order>();
            /// ICollection<VideoGame> videoGameList = new List<VideoGame>();
            /// ICollection<Platform> platformList = new List<Platform>();

            /// TODO: Complete seeding for the first half (Tyronne/Dan), 
            /// at least 10 in each.

            // Add customers here, use "var staff" below for adding staff members.
            var people = new Person[]
            {
                new Person
                {
                    PersonID = 1,
                    FirstName = "Mark",
                    LastName = "Wayne",
                    Email = "markwayne10@mail.com",
                    ContactNumber = "01732927421",
                    DateOfBirth = DateTime.Parse("1976-05-03"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                }

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Person.AddRange(people);
            /// context.SaveChanges();

            var staff = new Staff[]
            {
                new Staff
                {
                    PersonID = 2, // should be a different PersonID to "var people" above
                    FirstName = "Tyler",
                    LastName = "Smith",
                    Email = "t.smith37@mail.com",
                    ContactNumber = "01634892243",
                    DateOfBirth = DateTime.Parse("1980-06-23"),
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Manager",
                    Salary = 30250
                }

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Staff.AddRange(staff);
            /// context.SaveChanges();

            var addresses = new Address[]
            {
                new Address
                {
                    AddressID = 1,
                    HouseNo = "26",
                    Street = "Raye Lane",
                    City = "Henley-on-Thames",
                    Postcode = "RG98 3GW"
                }

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Staff.AddRange(staff);
            /// context.SaveChanges();

            var payments = new Payment[]
            {
                new Payment
                {
                    PersonID = 1, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "9999999999999999", // 16 digits
                    CardExpiryMonth = 11, // 2 digits
                    CardExpiryYear = 2025, // 4 digits
                    CardCSV = 999 // 3 digits
                }

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Staff.AddRange(staff);
            /// context.SaveChanges();


            /// TODO: Complete seeding for the second half (Tyronne/Dan),
            /// at least 10 in each.

            var orders = new Order[]
            {
                new Order
                {
                    OrderID = 1,
                    PersonID = 1, // Make sure this ID matches an existing person ID above
                    DateCreated = DateTime.Parse("2021-05-13"),
                    IsPaid = false
                }

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Staff.AddRange(staff);
            /// context.SaveChanges();

            var orderItems = new OrderItem[]
            {
                new OrderItem
                {
                    OrderItemID = 1,
                    OrderID = 1, // Make sure this ID matches an existing order ID above
                    VideoGameID = 1, // Make sure this ID matches an existing video game ID below
                    SalePrice = 31,
                    ItemQuantity = 1
                }

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Staff.AddRange(staff);
            /// context.SaveChanges();

            var platforms = new Platform[]
            {
                new Platform
                {
                    PlatformID = "PlayStation 5"
                }

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Staff.AddRange(staff);
            /// context.SaveChanges();

            var videoGames = new VideoGame[]
            {
                new VideoGame
                {
                    VideoGameID = 1,
                    Title = "Marvel's Spider-Man",
                    Description = "Swing your way through New York City as everyone's "
                    + "favourite superhero Spider-Man!",
                    Image = "spidermancoverart.jpg",
                    Genre = Genre.Action,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Moderate,
                    MatureContentDescription = "Contains moderate violence.",
                    ReleaseDate = DateTime.Parse("2018-09-07"),
                    Price = 25,
                    InStockQuantity = 10
                }

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Staff.AddRange(staff);
            /// context.SaveChanges();
        }
    }
}
