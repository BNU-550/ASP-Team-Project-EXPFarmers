using ASP_Razor_TeamEXPFarmers.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Razor_TeamEXPFarmers.Data
{
    /// <summary>
    /// Initialises the database by seeding data, having at least 10 records
    /// in each table and demonstrating the relationships from the ERD.
    /// 
    /// NOTE: Leave the commented primary keys as is, they are just there for
    /// illustrative purposes but the database will generate the primary key
    /// values itself.
    /// 
    /// Created by Jason Huggins
    /// Modified by:
    /// - Jason Huggins (02/12/2021) - Scaffolded database.
    /// - Tyronne Bradburn (25/11/2021) - Completed seeding process. Updated comments. 
    /// </summary>
    public static class DbInitialiser
    {
        /// <summary>
        /// Initialises the database with seeded data, calling each method to
        /// create test data for each model. 
        /// </summary>
        public static void Initialise(ApplicationDbContext context)
        {
            AddAddresses(context);
            AddPayments(context);
            AddCustomers(context);
            AddStaff(context);

            AddOrders(context);
            AddOrderItems(context);

            AddPlatforms(context);
            AddVideoGames(context);
        }

        private static void AddCustomers(ApplicationDbContext context)
        {
            /// Look for any customers.
            if (context.Customers.Any())
            {
                return; // Database has been seeded.
            }

            // Add customers here, use "var staff" below for adding staff members.
            // Customers' PersonID number is odd (up to 19).
            var customers = new Person[]
            {
                new Person
                {
                    //PersonID = 1,
                    AddressID = 1,
                    PaymentID = 1,
                    FirstName = "Mark",
                    LastName = "Wayne",
                    Email = "markwayne10@mail.com",
                    ContactNumber = "01732927421",
                    DateOfBirth = DateTime.Parse("1976-05-03"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 3,
                    AddressID = 2,
                    PaymentID = 2,
                    FirstName = "Daniel",
                    LastName = "Smith",
                    Email = "danielsmith@mail.com",
                    ContactNumber = "01753894521",
                    DateOfBirth = DateTime.Parse("1980-10-05"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 5,
                    AddressID = 3,
                    PaymentID = 3,                    
                    FirstName = "Tom",
                    LastName = "Jones",
                    Email = "tomjones@mail.com",
                    ContactNumber = "01729863547",
                    DateOfBirth = DateTime.Parse("1994-01-12"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 7,
                    AddressID = 4,
                    PaymentID = 4,
                    FirstName = "Lisa",
                    LastName = "McDonald",
                    Email = "lisamcdonald@mail.com",
                    ContactNumber = "017734755569",
                    DateOfBirth = DateTime.Parse("1965-12-25"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 9,
                    AddressID = 5,
                    PaymentID = 5,
                    FirstName = "Monica",
                    LastName = "Johnson",
                    Email = "monicajohnson@mail.com",
                    ContactNumber = "01799420217",
                    DateOfBirth = DateTime.Parse("2000-01-01"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 11,
                    AddressID = 6,
                    PaymentID = 6,
                    FirstName = "Monica",
                    LastName = "Johnson",
                    Email = "monicajohnson@mail.com",
                    ContactNumber = "01799420217",
                    DateOfBirth = DateTime.Parse("2000-01-01"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 13,
                    AddressID = 7,
                    PaymentID = 7,
                    FirstName = "Mason",
                    LastName = "Tickner",
                    Email = "masontickner@mail.com",
                    ContactNumber = "01749628730",
                    DateOfBirth = DateTime.Parse("1985-05-31"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 15,
                    AddressID = 8,
                    PaymentID = 8,
                    FirstName = "Thomas",
                    LastName = "White",
                    Email = "thomaswhite@mail.com",
                    ContactNumber = "01796315207",
                    DateOfBirth = DateTime.Parse("1999-03-25"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 17,
                    AddressID = 9,
                    PaymentID = 9,
                    FirstName = "Bailey",
                    LastName = "Norton",
                    Email = "baileynorton@mail.com",
                    ContactNumber = "017",
                    DateOfBirth = DateTime.Parse("1991-07-10"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    //PersonID = 19,
                    AddressID = 10,
                    PaymentID = 10,
                    FirstName = "Vanessa",
                    LastName = "Clayton",
                    Email = "vanessaclayton@mail.com",
                    ContactNumber = "01715876320",
                    DateOfBirth = DateTime.Parse("1993-04-10"), // YYYY-MM-DD
                    IsCustomer = true,
                    IsStaff = false
                },
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private static void AddStaff(ApplicationDbContext context)
        {
            /// Look for any staff members.
            if (context.Staff.Any())
            {
                return; // Database has been seeded.
            }

            /// Staff members' PersonID number is even (up to 20).
            var staff = new Staff[]
            {
                new Staff
                {
                    //PersonID = 12,
                    AddressID= 11,
                    PaymentID = 11,

                    FirstName = "Tyler",
                    LastName = "Smith",
                    Email = "t.smith01@mail.com",
                    ContactNumber = "01634892243",
                    DateOfBirth = DateTime.Parse("1980-06-23"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Manager",
                    Salary = 30250
                },

                new Staff
                {
                    //PersonID = 13,
                    AddressID= 12,
                    PaymentID = 12,

                    FirstName = "Johnathon",
                    LastName = "Curtis",
                    Email = "j.curtis02@mail.com",
                    ContactNumber = "01675438602",
                    DateOfBirth = DateTime.Parse("1985-12-13"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Manager",
                    Salary = 30250
                },

                new Staff
                {
                    //PersonID = 14,
                    AddressID= 13,
                    PaymentID = 13,

                    FirstName = "Jake",
                    LastName = "Shaw",
                    Email = "j.shaw03@mail.com",
                    ContactNumber = "01695423601",
                    DateOfBirth = DateTime.Parse("1990-01-10"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    //PersonID = 15,
                    AddressID= 14,
                    PaymentID = 14,

                    FirstName = "Sid",
                    LastName = "Harding",
                    Email = "s.harding04@mail.com",
                    ContactNumber = "016238465210",
                    DateOfBirth = DateTime.Parse("1995-07-30"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    //PersonID = 16,
                    AddressID= 15,
                    PaymentID = 15,

                    FirstName = "Harlow",
                    LastName = "Holmes",
                    Email = "h.holmes05@mail.com",
                    ContactNumber = "016238465210",
                    DateOfBirth = DateTime.Parse("1995-07-30"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    //PersonID = 17,
                    AddressID= 16,
                    PaymentID = 16,

                    FirstName = "Sid",
                    LastName = "Harding",
                    Email = "s.harding@mail.com",
                    ContactNumber = "016238465210",
                    DateOfBirth = DateTime.Parse("1995-07-30"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    //PersonID = 18,
                    AddressID= 17,
                    PaymentID = 17,

                    FirstName = "Maddison",
                    LastName = "Rowley",
                    Email = "m.rowley@mail.com",
                    ContactNumber = "016647892036",
                    DateOfBirth = DateTime.Parse("2000-02-02"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    //PersonID = 19,
                    AddressID= 18,
                    PaymentID = 18,

                    FirstName = "Carrie-Ann",
                    LastName = "Partridge",
                    Email = "c.partridge@mail.com",
                    ContactNumber = "01602587692",
                    DateOfBirth = DateTime.Parse("1983-08-10"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    //PersonID = 20,
                    AddressID= 19,
                    PaymentID = 19,

                    FirstName = "Viktoria",
                    LastName = "Griffin",
                    Email = "v.griffin@mail.com",
                    ContactNumber = "01666598710",
                    DateOfBirth = DateTime.Parse("1987-04-15"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    //PersonID = 21,
                    AddressID= 20,
                    PaymentID = 20,

                    FirstName = "Joyce",
                    LastName = "Iles",
                    Email = "j.iles@mail.com",
                    ContactNumber = "01654896320",
                    DateOfBirth = DateTime.Parse("1993-02-06"), // YYYY-MM-DD
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },
            };

            context.Staff.AddRange(staff);
            context.SaveChanges();
        }

        private static void AddAddresses(ApplicationDbContext context)
        {
            /// Look for any addresses.
            /// 
            if (context.Address.Any())
            {
                 return; // Database has been seeded.
            }

            var addresses = new Address[]
            {
                new Address
                {
                    HouseNo = "26",
                    Street = "Raye Lane",
                    City = "Henley-on-Thames",
                    Postcode = "RG98 3GW"
                },

                new Address
                {
                    HouseNo = "124",
                    Street = "Nottingham Road",
                    City = "Abedeen",
                    Postcode = "AV2 2TJ"
                },

                new Address
                {
                    HouseNo = "60",
                    Street = "Holburn Road",
                    City = "Hele Bridge",
                    Postcode = "EX20 3QX"
                },

                new Address
                {
                    HouseNo = "65",
                    Street = "Copthorne Way",
                    City = "Cameron",
                    Postcode = "G83 4TN"
                },

                new Address
                {
                    HouseNo = "65",
                    Street = "Guild Street",
                    City = "London",
                    Postcode = "NW1 1BE"
                },

                new Address
                {
                    HouseNo = "64",
                    Street = "South Street",
                    City = "London",
                    Postcode = "SE14 8JW"
                },

                new Address
                {
                    HouseNo = "34",
                    Street = "Shannon Way",
                    City = "Chiddingfold",
                    Postcode = "GU8 0JS"
                },

                new Address
                {
                    HouseNo = "83",
                    Street = "Lairg Road",
                    City = "Newbold",
                    Postcode = "S42 9PU"
                },

                new Address
                {
                    HouseNo = "44",
                    Street = "Duckpit lane",
                    City = "Upton",
                    Postcode = "EX14 1AF"
                },

                new Address
                {
                    HouseNo = "33",
                    Street = "Wilthers Close",
                    City = "Allesley",
                    Postcode = "CV5 3LW"
                },

                new Address
                {
                    HouseNo = "66",
                    Street = "Kingsway North",
                    City = "Holme Pierrepont",
                    Postcode = "NG12 8PZ"
                },

                new Address
                {
                    HouseNo = "98",
                    Street = "Thornton Street",
                    City = "Hundleby",
                    Postcode = "PE23 6SJ"
                },

                new Address
                {
                    HouseNo = "70",
                    Street = "Ross Road",
                    City = "Martock",
                    Postcode = "TA12 2QE"
                },

                new Address
                {
                    HouseNo = "117",
                    Street = "Winchester Road",
                    City = "Merthyr Cynog",
                    Postcode = "LD3 2DR"
                },

                new Address
                {
                    HouseNo = "133",
                    Street = "Witney Way",
                    City = "Knockentiber",
                    Postcode = "KA2 0PN"
                },

                new Address
                {
                    HouseNo = "126",
                    Street = "Goldern Knowes Road",
                    City = "Foxley",
                    Postcode = "SN16 7RD"
                },

                new Address
                {
                    HouseNo = "48",
                    Street = "Grey Street",
                    City = "Kentmere",
                    Postcode = "LA8 9PG"
                },

                new Address
                {
                    HouseNo = "39",
                    Street = "Whitby Road",
                    City = "Derbyhaven",
                    Postcode = "IM9 6YF"
                },

                new Address
                {
                    HouseNo = "54",
                    Street = "Fulford Road",
                    City = "Pentlepoir",
                    Postcode = "SA69 5FN"
                },

                new Address
                {
                    //AddressID = 20,
                    HouseNo = "66",
                    Street = "Clasper Way",
                    City = "Hever",
                    Postcode = "TN8 2WL"
                },
            };

            context.Address.AddRange(addresses);
            context.SaveChanges();
        }

        private static void AddPayments(ApplicationDbContext context)
        {
            /// Look for any payment cards.
            /// 
            if (context.Payment.Any())
            {
                return; // Database has been seeded.
            }

            /// Customers' PersonID is odd (up to 19).
            /// Staff members' PersonID is even (up to 20).
            var payments = new Payment[]
            {
                new Payment
                {
                    PaymentCardNo = "9999999999999999", // 16 digits
                    CardExpiryMonth = 11, // 2 digits
                    CardExpiryYear = 2025, // 4 digits
                    CardCSV = 999 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "8888888888888888", // 16 digits
                    CardExpiryMonth = 12, // 2 digits
                    CardExpiryYear = 2025, // 4 digits
                    CardCSV = 888 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "7777777777777777", // 16 digits
                    CardExpiryMonth = 01, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 777 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "6666666666666666", // 16 digits
                    CardExpiryMonth = 02, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 666 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "5555555555555555", // 16 digits
                    CardExpiryMonth = 03, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 555 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "4444444444444444", // 16 digits
                    CardExpiryMonth = 04, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 444 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "3333333333333333", // 16 digits
                    CardExpiryMonth = 05, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 333 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "2222222222222222", // 16 digits
                    CardExpiryMonth = 06, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 222 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1111111111111111", // 16 digits
                    CardExpiryMonth = 07, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 111 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1010101010101010", // 16 digits
                    CardExpiryMonth = 08, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 101 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "0101010101010101", // 16 digits
                    CardExpiryMonth = 09, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 010 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1212121212121212", // 16 digits
                    CardExpiryMonth = 10, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 121 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1313131313131313", // 16 digits
                    CardExpiryMonth = 11, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 131 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1414141414141414", // 16 digits
                    CardExpiryMonth = 12, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 141 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1515151515151515", // 16 digits
                    CardExpiryMonth = 01, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 151 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1616161616161616", // 16 digits
                    CardExpiryMonth = 02, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 161 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1717171717171717", // 16 digits
                    CardExpiryMonth = 03, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 171 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1818181818181818", // 16 digits
                    CardExpiryMonth = 04, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 181 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "1919191919191919", // 16 digits
                    CardExpiryMonth = 05, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 191 // 3 digits
                },

                new Payment
                {
                    PaymentCardNo = "2020202020202020", // 16 digits
                    CardExpiryMonth = 06, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 202 // 3 digits
                },
            };

            context.Payment.AddRange(payments);
            context.SaveChanges();
        }

        private static void AddOrders(ApplicationDbContext context)
        {
            /// To be added after scaffolding.
            /// Look for any orders.
            /// if (context.Order.Any())
            /// {
            ///     return; // Database has been seeded.
            /// }

            /// Customers' PersonID is odd (up to 19).
            /// Staff members; PersonID is even (up to 20).
            var orders = new Order[]
            {
                new Order
                {
                    PersonID = 2, 
                    DateCreated = DateTime.Parse("2021-05-13"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 3, 
                    DateCreated = DateTime.Parse("2021-05-05"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 4, 
                    DateCreated = DateTime.Parse("2021-05-01"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 5, 
                    DateCreated = DateTime.Parse("2021-05-06"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 6, 
                    DateCreated = DateTime.Parse("2021-05-02"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 7, 
                    DateCreated = DateTime.Parse("2021-05-07"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 8, 
                    DateCreated = DateTime.Parse("2021-05-03"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 8, 
                    DateCreated = DateTime.Parse("2021-05-08"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 10, 
                    DateCreated = DateTime.Parse("2021-05-04"),
                    IsPaid = false
                },

                new Order
                {
                    PersonID = 10, 
                    DateCreated = DateTime.Parse("2021-05-09"),
                    IsPaid = false
                },
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }

        private static void AddOrderItems(ApplicationDbContext context)
        {
            /// Look for any order items.
            if (context.OrderItems.Any())
            {
                return; // Database has been seeded.
            }

            var orderItems = new OrderItem[]
            {
                new OrderItem
                {
                    OrderID = 3, 
                    VideoGameID = 1, 
                    SalePrice = 31,
                    ItemQuantity = 1
                },

                new OrderItem
                {
                    OrderID = 3, 
                    VideoGameID = 2, 
                    SalePrice = 100,
                    ItemQuantity = 5
                },

                new OrderItem
                {
                    //OrderItemID = 3,
                    OrderID = 4, 
                    VideoGameID = 3, 
                    SalePrice = 31,
                    ItemQuantity = 1
                },

                new OrderItem
                {
                    //OrderItemID = 4,
                    OrderID = 4, 
                    VideoGameID = 4, 
                    SalePrice = 31,
                    ItemQuantity = 1
                },

                new OrderItem
                {
                    //OrderItemID = 5,
                    OrderID = 5, 
                    VideoGameID = 5, 
                    SalePrice = 31,
                    ItemQuantity = 1
                },

                new OrderItem
                {
                    //OrderItemID = 6,
                    OrderID = 6, 
                    VideoGameID = 6,
                    SalePrice = 31,
                    ItemQuantity = 1
                },

                new OrderItem
                {
                    //OrderItemID = 7,
                    OrderID = 7,
                    VideoGameID = 7,
                    SalePrice = 31,
                    ItemQuantity = 1
                },

                new OrderItem
                {
                    //OrderItemID = 8,
                    OrderID = 8,
                    VideoGameID = 8,
                    SalePrice = 31,
                    ItemQuantity = 1
                },

                new OrderItem
                {
                    //OrderItemID = 9,
                    OrderID = 9,
                    VideoGameID = 9,
                    SalePrice = 31,
                    ItemQuantity = 1
                },

                new OrderItem
                {
                    //OrderItemID = 10,
                    OrderID = 10,
                    VideoGameID = 10,
                    SalePrice = 31,
                    ItemQuantity = 1
                },
            };

            context.OrderItems.AddRange(orderItems);
            context.SaveChanges();
        }

        private static void AddPlatforms(ApplicationDbContext context)
        {
            /// Look for any platforms.
            if (context.Platforms.Any())
            {
                return; // Database has been seeded.
            }

            var platforms = new Platform[]
            {
                new Platform
                {
                    PlatformID = "PlayStation 5"
                },

                new Platform
                {
                    PlatformID = "Xbox Series X/S"
                },

                new Platform
                {
                    PlatformID = "Nintendo Switch"
                },

                new Platform
                {
                    PlatformID = "PC"
                },

                new Platform
                {
                    PlatformID = "PlayStation 4"
                },

                new Platform
                {
                    PlatformID = "Xbox One"
                },

                new Platform
                {
                    PlatformID = "Stadia"
                },

                new Platform
                {
                    PlatformID = "Oculus Rift"
                },
            };

            context.Platforms.AddRange(platforms);
            context.SaveChanges();
        }

        private static void AddVideoGames(ApplicationDbContext context)
        {
            /// Look for any video games.
            if (context.VideoGames.Any())
            {
                return; // Database has been seeded.
            }

            var videoGames = new VideoGame[]
            {
                new VideoGame
                {
                    // VideoGameID = 1
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
                },

                new VideoGame
                {
                    //VideoGameID = 2,
                    Title = "Destiny 2",
                    Description = "Destiny 2 is a free-to-play online-only multiplayer"
                    + "first-person shooter video game",
                    Image = "Destiny2CoverArt.jpg",
                    Genre = Genre.Action,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Moderate,
                    MatureContentDescription = "Contains moderate violence.",
                    ReleaseDate = DateTime.Parse("2017-09-06"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 3,
                    Title = "Forza 5",
                    Description = "Set in an open world environment based in a"
                    + "fictional representation of Mexico.",
                    Image = "Forza5CoverArt.jpg",
                    Genre = Genre.Racing,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.None,
                    MatureContentDescription = "Contains No Violence.",
                    ReleaseDate = DateTime.Parse("2021-11-09"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 4,
                    Title = "Baldur's Gate III",
                    Description = "Return to the legendary city of Baldur’s Gate® in a tale of fellowship and betrayal,"
                    + "sacrifice and survival and the lure of absolute power.",
                    Image = "BaldursGateIIICoverArt.jpg",
                    // PlatformID = "Playstation 5" Not sure if this needs to be here.(Tyronne)
                    Genre = Genre.Role_Playing,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Mature,
                    MatureContentDescription = "Contains Violence.",
                    ReleaseDate = DateTime.Parse("2020-10-06"),
                    Price = 25,
                    InStockQuantity = 10
                },

                 new VideoGame
                {
                    //VideoGameID = 5,
                    Title = "God of War",
                    Description = "Many years after Kratos defeated the Olympian gods,"
                    + "he now lives with his son Atreus in ancient Scandinavia in the realm of Midgard.",
                    Image = "GodOfWarCoverArt.jpg",
                    // PlatformID = "Playstation 5" Not sure if this needs to be here.(Tyronne)
                    Genre = Genre.Action,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Mature,
                    MatureContentDescription = "Contains high levels of Violence.",
                    ReleaseDate = DateTime.Parse("2018-04-20"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 6,
                    Title = "The Master Chief Collection",
                    Description = "The Master Chief Collection originally consisted of Halo: Combat Evolved Anniversary," 
                    + "Halo 2 Anniversary, Halo 3, and Halo 4"
                    + "complete with their full catalog of extras, including all multiplayer maps and gameplay modes.",
                    Image = "TheMasterChiefCollectionCoverArt.jpg",
                    Genre = Genre.Action,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Mature,
                    MatureContentDescription = "Contains moderate Violence.",
                    ReleaseDate = DateTime.Parse("2014-11-11"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 7,
                    Title = "X-COM",
                    Description = "In the spring of 2015, as a global alien invasion begins." 
                    + "A group of countries called the Council of Nations has banded together to create XCOM,"
                    + "the most elite military and scientific organization in human history, tasked with defending them from the alien attack",
                    Image = "X-COM.jpg",
                    Genre = Genre.Strategy,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Mature,
                    MatureContentDescription = "Contains Moderate Violence.",
                    ReleaseDate = DateTime.Parse("2012-10-09"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 8,
                    Title = "FIFA 22",
                    Description = "Play the most immersive, realistic and authentic football sim – the all new FIFA 22."
                    +"Whether you're just playing a quick match with friends or challenging yourself in the career mode with your favourite team,"
                    + "you'll love the updated gameplay, physics and reinvented AI.",
                    Image = "FIFA22.jpg",
                    Genre = Genre.Simulation,
                    PEGI = PEGI.PEGI_3,
                    DifficultyLevel = DifficultyLevel.Easy,
                    MatureContentLevel = MatureContentLevel.None,
                    MatureContentDescription = "Contains no Violence.",
                    ReleaseDate = DateTime.Parse("2021-10-01"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 9,
                    Title = "Shadow of the Tomb Raider",
                    Description = "players take on the role of Lara Croft as she explores environments across the continents of Central and South America."
                    + "In addition to standalone areas, the game has a large hub in the Hidden City of Paititi."
                    + "A new barter system allows players to trade and sell various resources gathered from the areas surrounding Paititi.",
                    Image = "ShadowoftheTombRaider.jpg",
                    Genre = Genre.Action,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Moderate,
                    MatureContentDescription = "Contains Moderate Violence.",
                    ReleaseDate = DateTime.Parse("2018-09-14"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 10,
                    Title = "F1 2021",
                    Description = "F1 2021 is the official video game of the 2021 Formula One and" 
                    + "Formula 2 Championships developed by Codemasters and published by EA Sports.",
                    Image = "F12021.jpg",
                    Genre = Genre.Racing,
                    PEGI = PEGI.PEGI_3,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.None,
                    MatureContentDescription = "Contains no Violence.",
                    ReleaseDate = DateTime.Parse("2021-07-16"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 11,
                    Title = "Rise of the Tomb Raider",
                    Description = "follows Lara Croft as she ventures into Siberia in search of the legendary city of Kitezh" 
                    + "while battling the paramilitary organization Trinity,"
                    + "which intends to uncover the city's promise of immortality.",
                    Image = "RiseoftheTOMBrAIDER.jpg",
                    Genre = Genre.Action_Adventure,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Moderate,
                    MatureContentDescription = "Contains Moderate Violence.",
                    ReleaseDate = DateTime.Parse("2015-11-10"),
                    Price = 25,
                    InStockQuantity = 10
                },

                new VideoGame
                {
                    //VideoGameID = 12,
                    Title = "Tomb Raider",
                    Description = "The game is set on Yamatai, a fictional lost island in the Dragon's Triangle off the coast of Japan.",
                    Image = "TombRaider.jpg",
                    Genre = Genre.Action_Adventure,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Moderate,
                    MatureContentDescription = "Contains Moderate Violence.",
                    ReleaseDate = DateTime.Parse("2015-03-05"),
                    Price = 25,
                    InStockQuantity = 10
                },
            };

            context.VideoGames.AddRange(videoGames);
            context.SaveChanges();
        }
    }
}
