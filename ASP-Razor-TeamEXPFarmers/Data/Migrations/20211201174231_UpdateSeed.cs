using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Razor_TeamEXPFarmers.Data.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_PaymentID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Payment",
                newName: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PaymentID",
                table: "Customers",
                column: "PaymentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_PaymentID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "PaymentID",
                table: "Payment",
                newName: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PaymentID",
                table: "Customers",
                column: "PaymentID",
                unique: true);
        }
    }
}
