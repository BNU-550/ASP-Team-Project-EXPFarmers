using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Razor_TeamEXPFarmers.Data.Migrations
{
    public partial class PlatformPkNone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlatformVideoGame_Platform_PlatformsPlatformID",
                table: "PlatformVideoGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platform",
                table: "Platform");

            migrationBuilder.RenameTable(
                name: "Platform",
                newName: "Platforms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platforms",
                table: "Platforms",
                column: "PlatformID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformVideoGame_Platforms_PlatformsPlatformID",
                table: "PlatformVideoGame",
                column: "PlatformsPlatformID",
                principalTable: "Platforms",
                principalColumn: "PlatformID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlatformVideoGame_Platforms_PlatformsPlatformID",
                table: "PlatformVideoGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platforms",
                table: "Platforms");

            migrationBuilder.RenameTable(
                name: "Platforms",
                newName: "Platform");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platform",
                table: "Platform",
                column: "PlatformID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformVideoGame_Platform_PlatformsPlatformID",
                table: "PlatformVideoGame",
                column: "PlatformsPlatformID",
                principalTable: "Platform",
                principalColumn: "PlatformID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
