using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Razor_TeamEXPFarmers.Data.Migrations
{
    public partial class DataAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseNo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    HouseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    City = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentCardNo = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    CardStartMonth = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    CardStartYear = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CardExpiryMonth = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    CardExpiryYear = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CardCSV = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    PlatformID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.PlatformID);
                });

            migrationBuilder.CreateTable(
                name: "VideoGame",
                columns: table => new
                {
                    VideoGameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    PEGI = table.Column<int>(type: "int", nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    MatureContentLevel = table.Column<int>(type: "int", nullable: false),
                    MatureContentDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "Money", nullable: false),
                    InStockQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGame", x => x.VideoGameID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    PaymentID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCustomer = table.Column<bool>(type: "bit", nullable: false),
                    IsStaff = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_Customers_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Payment_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payment",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlatformVideoGame",
                columns: table => new
                {
                    PlatformsPlatformID = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    VideoGamesVideoGameID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformVideoGame", x => new { x.PlatformsPlatformID, x.VideoGamesVideoGameID });
                    table.ForeignKey(
                        name: "FK_PlatformVideoGame_Platform_PlatformsPlatformID",
                        column: x => x.PlatformsPlatformID,
                        principalTable: "Platform",
                        principalColumn: "PlatformID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatformVideoGame_VideoGame_VideoGamesVideoGameID",
                        column: x => x.VideoGamesVideoGameID,
                        principalTable: "VideoGame",
                        principalColumn: "VideoGameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DispatchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Customers_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Customers",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    VideoGameID = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemQuantity = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    CustomerRating = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    CustomerReview = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CustomerReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_VideoGame_VideoGameID",
                        column: x => x.VideoGameID,
                        principalTable: "VideoGame",
                        principalColumn: "VideoGameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressID",
                table: "Customers",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PaymentID",
                table: "Customers",
                column: "PaymentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_PersonID",
                table: "Order",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_VideoGameID",
                table: "OrderItem",
                column: "VideoGameID");

            migrationBuilder.CreateIndex(
                name: "IX_PlatformVideoGame_VideoGamesVideoGameID",
                table: "PlatformVideoGame",
                column: "VideoGamesVideoGameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "PlatformVideoGame");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "VideoGame");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
