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
	/// Modified by:
    /// Jason Huggins (23/11/2021) - fixed formatting.
    /// Tyronne Bradburn (23/11/2021) - Added 9 new Person. Added 9 new
    /// Staff members. Updated comments. Added Addresses. Added Payment Cards.
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

            /// TODO: Complete seeding for the first half (Tyronne), 
            /// at least 10 in each.

            // Add customers here, use "var staff" below for adding staff members.
            // Customers PersonID number is odds(up to 19).
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
                },

                new Person
                {
                    PersonID = 3,
                    FirstName = "Daniel",
                    LastName = "Smith",
                    Email = "danielsmith@mail.com",
                    ContactNumber = "01753894521",
                    DateOfBirth = DateTime.Parse("1980-10-05"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    PersonID = 5,
                    FirstName = "Tom",
                    LastName = "Jones",
                    Email = "tomjones@mail.com",
                    ContactNumber = "01729863547",
                    DateOfBirth = DateTime.Parse("1994-01-12"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    PersonID = 7,
                    FirstName = "Lisa",
                    LastName = "McDonald",
                    Email = "lisamcdonald@mail.com",
                    ContactNumber = "017734755569",
                    DateOfBirth = DateTime.Parse("1965-12-25"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    PersonID = 9,
                    FirstName = "Monica",
                    LastName = "Johnson",
                    Email = "monicajohnson@mail.com",
                    ContactNumber = "01799420217",
                    DateOfBirth = DateTime.Parse("2000-01-01"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    PersonID = 11,
                    FirstName = "Monica",
                    LastName = "Johnson",
                    Email = "monicajohnson@mail.com",
                    ContactNumber = "01799420217",
                    DateOfBirth = DateTime.Parse("2000-01-01"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    PersonID = 13,
                    FirstName = "Mason",
                    LastName = "Tickner",
                    Email = "masontickner@mail.com",
                    ContactNumber = "01749628730",
                    DateOfBirth = DateTime.Parse("1985-05-31"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    PersonID = 15,
                    FirstName = "Thomas",
                    LastName = "White",
                    Email = "thomaswhite@mail.com",
                    ContactNumber = "01796315207",
                    DateOfBirth = DateTime.Parse("1999-03-25"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    PersonID = 17,
                    FirstName = "Bailey",
                    LastName = "Norton",
                    Email = "baileynorton@mail.com",
                    ContactNumber = "017",
                    DateOfBirth = DateTime.Parse("1991-07-10"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },

                new Person
                {
                    PersonID = 19,
                    FirstName = "Vanessa",
                    LastName = "Clayton",
                    Email = "vanessaclayton@mail.com",
                    ContactNumber = "01715876320",
                    DateOfBirth = DateTime.Parse("1993-04-10"), // YYYY-MM-DD,
                    IsCustomer = true,
                    IsStaff = false
                },
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Person.AddRange(people);
            /// context.SaveChanges();

            /// Staffs PersonID number is even(up to 20)
            var staff = new Staff[]
            {
                new Staff
                {
                    PersonID = 2, // should be a different PersonID to "var people" above
                    FirstName = "Tyler",
                    LastName = "Smith",
                    Email = "t.smith01@mail.com",
                    ContactNumber = "01634892243",
                    DateOfBirth = DateTime.Parse("1980-06-23"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Manager",
                    Salary = 30250
                },

                new Staff
                {
                    PersonID = 4, // should be a different PersonID to "var people" above
                    FirstName = "Johnathon",
                    LastName = "Curtis",
                    Email = "j.curtis02@mail.com",
                    ContactNumber = "01675438602",
                    DateOfBirth = DateTime.Parse("1985-12-13"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Manager",
                    Salary = 30250
                },

                new Staff
                {
                    PersonID = 6, // should be a different PersonID to "var people" above
                    FirstName = "Jake",
                    LastName = "Shaw",
                    Email = "j.shaw03@mail.com",
                    ContactNumber = "01695423601",
                    DateOfBirth = DateTime.Parse("1990-01-10"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    PersonID = 8, // should be a different PersonID to "var people" above
                    FirstName = "Sid",
                    LastName = "Harding",
                    Email = "s.harding04@mail.com",
                    ContactNumber = "016238465210",
                    DateOfBirth = DateTime.Parse("1995-07-30"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    PersonID = 10, // should be a different PersonID to "var people" above
                    FirstName = "Harlow",
                    LastName = "Holmes",
                    Email = "h.holmes05@mail.com",
                    ContactNumber = "016238465210",
                    DateOfBirth = DateTime.Parse("1995-07-30"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    PersonID = 12, // should be a different PersonID to "var people" above
                    FirstName = "Sid",
                    LastName = "Harding",
                    Email = "s.harding@mail.com",
                    ContactNumber = "016238465210",
                    DateOfBirth = DateTime.Parse("1995-07-30"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    PersonID = 14, // should be a different PersonID to "var people" above
                    FirstName = "Maddison",
                    LastName = "Rowley",
                    Email = "m.rowley@mail.com",
                    ContactNumber = "016647892036",
                    DateOfBirth = DateTime.Parse("2000-02-02"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    PersonID = 16, // should be a different PersonID to "var people" above
                    FirstName = "Carrie-Ann",
                    LastName = "Partridge",
                    Email = "c.partridge@mail.com",
                    ContactNumber = "01602587692",
                    DateOfBirth = DateTime.Parse("1983-08-10"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    PersonID = 18, // should be a different PersonID to "var people" above
                    FirstName = "Viktoria",
                    LastName = "Griffin",
                    Email = "v.griffin@mail.com",
                    ContactNumber = "01666598710",
                    DateOfBirth = DateTime.Parse("1987-04-15"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },

                new Staff
                {
                    PersonID = 20, // should be a different PersonID to "var people" above
                    FirstName = "Joyce",
                    LastName = "Iles",
                    Email = "j.iles@mail.com",
                    ContactNumber = "01654896320",
                    DateOfBirth = DateTime.Parse("1993-24-06"), // YYYY-MM-DD,
                    IsCustomer = false,
                    IsStaff = true,
                    JobPosition = "Sales Rep",
                    Salary = 25500
                },
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
                },

                new Address
                {
                    AddressID = 2,
                    HouseNo = "124",
                    Street = "Nottingham Road",
                    City = "Abedeen",
                    Postcode = "AV2 2TJ"
                },

                new Address
                {
                    AddressID = 3,
                    HouseNo = "60",
                    Street = "Holburn Road",
                    City = "Hele Bridge",
                    Postcode = "EX20 3QX"
                },

                new Address
                {
                    AddressID = 4,
                    HouseNo = "65",
                    Street = "Copthorne Way",
                    City = "Cameron",
                    Postcode = "G83 4TN"
                },

                new Address
                {
                    AddressID = 5,
                    HouseNo = "65",
                    Street = "Guild Street",
                    City = "London",
                    Postcode = "NW1 1BE"
                },

                new Address
                {
                    AddressID = 6,
                    HouseNo = "64",
                    Street = "South Street",
                    City = "London",
                    Postcode = "SE14 8JW"
                },

                new Address
                {
                    AddressID = 7,
                    HouseNo = "34",
                    Street = "Shannon Way",
                    City = "Chiddingfold",
                    Postcode = "GU8 0JS"
                },

                new Address
                {
                    AddressID = 8,
                    HouseNo = "83",
                    Street = "Lairg Road",
                    City = "Newbold",
                    Postcode = "S42 9PU"
                },

                new Address
                {
                    AddressID = 9,
                    HouseNo = "44",
                    Street = "Duckpit lane",
                    City = "Upton",
                    Postcode = "EX14 1AF"
                },

                new Address
                {
                    AddressID = 10,
                    HouseNo = "33",
                    Street = "Wilthers Close",
                    City = "Allesley",
                    Postcode = "CV5 3LW"
                },

                new Address
                {
                    AddressID = 11,
                    HouseNo = "66",
                    Street = "Kingsway North",
                    City = "Holme Pierrepont",
                    Postcode = "NG12 8PZ"
                },

                new Address
                {
                    AddressID = 12,
                    HouseNo = "98",
                    Street = "Thornton Street",
                    City = "Hundleby",
                    Postcode = "PE23 6SJ"
                },

                new Address
                {
                    AddressID = 13,
                    HouseNo = "70",
                    Street = "Ross Road",
                    City = "Martock",
                    Postcode = "TA12 2QE"
                },

                new Address
                {
                    AddressID = 14,
                    HouseNo = "117",
                    Street = "Winchester Road",
                    City = "Merthyr Cynog",
                    Postcode = "LD3 2DR"
                },

                new Address
                {
                    AddressID = 15,
                    HouseNo = "133",
                    Street = "Witney Way",
                    City = "Knockentiber",
                    Postcode = "KA2 0PN"
                },

                new Address
                {
                    AddressID = 16,
                    HouseNo = "126",
                    Street = "Goldern Knowes Road",
                    City = "Foxley",
                    Postcode = "SN16 7RD"
                },

                new Address
                {
                    AddressID = 17,
                    HouseNo = "48",
                    Street = "Grey Street",
                    City = "Kentmere",
                    Postcode = "LA8 9PG"
                },

                new Address
                {
                    AddressID = 18,
                    HouseNo = "39",
                    Street = "Whitby Road",
                    City = "Derbyhaven",
                    Postcode = "IM9 6YF"
                },

                new Address
                {
                    AddressID = 19,
                    HouseNo = "54",
                    Street = "Fulford Road",
                    City = "Pentlepoir",
                    Postcode = "SA69 5FN"
                },

                new Address
                {
                    AddressID = 20,
                    HouseNo = "66",
                    Street = "Clasper Way",
                    City = "Hever",
                    Postcode = "TN8 2WL"
                },
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Address.AddRange(addresses);
            /// context.SaveChanges();

            /// Customers PersonID is odds(up to 19).
            /// Staffs Person ID is even(up to 20).
            var payments = new Payment[]
            {
                new Payment
                {
                    PersonID = 1, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "9999999999999999", // 16 digits
                    CardExpiryMonth = 11, // 2 digits
                    CardExpiryYear = 2025, // 4 digits
                    CardCSV = 999 // 3 digits
                },

                new Payment
                {
                    PersonID = 2, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "8888888888888888", // 16 digits
                    CardExpiryMonth = 12, // 2 digits
                    CardExpiryYear = 2025, // 4 digits
                    CardCSV = 888 // 3 digits
                },

                new Payment
                {
                    PersonID = 3, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "7777777777777777", // 16 digits
                    CardExpiryMonth = 01, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 777 // 3 digits
                },

                new Payment
                {
                    PersonID = 4, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "6666666666666666", // 16 digits
                    CardExpiryMonth = 02, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 666 // 3 digits
                },

                new Payment
                {
                    PersonID = 5, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "5555555555555555", // 16 digits
                    CardExpiryMonth = 03, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 555 // 3 digits
                },

                new Payment
                {
                    PersonID = 6, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "4444444444444444", // 16 digits
                    CardExpiryMonth = 04, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 444 // 3 digits
                },

                new Payment
                {
                    PersonID = 7, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "3333333333333333", // 16 digits
                    CardExpiryMonth = 05, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 333 // 3 digits
                },

                new Payment
                {
                    PersonID = 8, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "2222222222222222", // 16 digits
                    CardExpiryMonth = 06, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 222 // 3 digits
                },

                new Payment
                {
                    PersonID = 9, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1111111111111111", // 16 digits
                    CardExpiryMonth = 07, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 111 // 3 digits
                },

                new Payment
                {
                    PersonID = 10, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1010101010101010", // 16 digits
                    CardExpiryMonth = 08, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 101 // 3 digits
                },

                new Payment
                {
                    PersonID = 11, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "0101010101010101", // 16 digits
                    CardExpiryMonth = 09, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 010 // 3 digits
                },

                new Payment
                {
                    PersonID = 12, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1212121212121212", // 16 digits
                    CardExpiryMonth = 10, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 121 // 3 digits
                },

                new Payment
                {
                    PersonID = 13, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1313131313131313", // 16 digits
                    CardExpiryMonth = 11, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 131 // 3 digits
                },

                new Payment
                {
                    PersonID = 14, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1414141414141414", // 16 digits
                    CardExpiryMonth = 12, // 2 digits
                    CardExpiryYear = 2026, // 4 digits
                    CardCSV = 141 // 3 digits
                },

                new Payment
                {
                    PersonID = 15, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1515151515151515", // 16 digits
                    CardExpiryMonth = 01, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 151 // 3 digits
                },

                new Payment
                {
                    PersonID = 16, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1616161616161616", // 16 digits
                    CardExpiryMonth = 02, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 161 // 3 digits
                },

                new Payment
                {
                    PersonID = 17, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1717171717171717", // 16 digits
                    CardExpiryMonth = 03, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 171 // 3 digits
                },

                new Payment
                {
                    PersonID = 18, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1818181818181818", // 16 digits
                    CardExpiryMonth = 04, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 181 // 3 digits
                },

                new Payment
                {
                    PersonID = 19, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "1919191919191919", // 16 digits
                    CardExpiryMonth = 05, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 191 // 3 digits
                },

                new Payment
                {
                    PersonID = 20, // Make sure this ID matches an existing person ID above
                    PaymentCardNo = "2020202020202020", // 16 digits
                    CardExpiryMonth = 06, // 2 digits
                    CardExpiryYear = 2027, // 4 digits
                    CardCSV = 202 // 3 digits
                },
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Payment.AddRange(payments);
            /// context.SaveChanges();


            /// TODO: Complete seeding for the second half (Dan),
            /// at least 10 in each.

            /// Customers PersonID is odds(up to 19).
            /// Staffs Person ID is even(up to 20).
            var orders = new Order[]
            {
                new Order
                {
                    OrderID = 1,
                    PersonID = 1, // Make sure this ID matches an existing person ID above
                    DateCreated = DateTime.Parse("2021-05-13"),
                    IsPaid = false
                },

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Order.AddRange(orders);
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
                },

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.OrderItems.AddRange(orderItems);
            /// context.SaveChanges();

            var platforms = new Platform[]
            {
                new Platform
                {
                    PlatformID = "PlayStation 5"
                },

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.Platform.AddRange(platforms);
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
                    // Platform = "Playstation 5" Not sure if this needs to be here.(Tyronne)
                    Genre = Genre.Action,
                    PEGI = PEGI.PEGI_16,
                    DifficultyLevel = DifficultyLevel.Moderate,
                    MatureContentLevel = MatureContentLevel.Moderate,
                    MatureContentDescription = "Contains moderate violence.",
                    ReleaseDate = DateTime.Parse("2018-09-07"),
                    Price = 25,
                    InStockQuantity = 10
                },

                // Example above, add the rest below.
            };

            /// TODO: Only add this in after scaffolding the database.
            /// context.VideoGames.AddRange(videoGames);
            /// context.SaveChanges();
        }
    }
}
