using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Razor_TeamEXPFarmers.Data.Migrations
{
    public partial class AddGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_VideoGame_VideoGameID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PlatformVideoGame_VideoGame_VideoGamesVideoGameID",
                table: "PlatformVideoGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideoGame",
                table: "VideoGame");

            migrationBuilder.RenameTable(
                name: "VideoGame",
                newName: "VideoGames");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideoGames",
                table: "VideoGames",
                column: "VideoGameID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_VideoGames_VideoGameID",
                table: "OrderItem",
                column: "VideoGameID",
                principalTable: "VideoGames",
                principalColumn: "VideoGameID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformVideoGame_VideoGames_VideoGamesVideoGameID",
                table: "PlatformVideoGame",
                column: "VideoGamesVideoGameID",
                principalTable: "VideoGames",
                principalColumn: "VideoGameID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_VideoGames_VideoGameID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PlatformVideoGame_VideoGames_VideoGamesVideoGameID",
                table: "PlatformVideoGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideoGames",
                table: "VideoGames");

            migrationBuilder.RenameTable(
                name: "VideoGames",
                newName: "VideoGame");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideoGame",
                table: "VideoGame",
                column: "VideoGameID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_VideoGame_VideoGameID",
                table: "OrderItem",
                column: "VideoGameID",
                principalTable: "VideoGame",
                principalColumn: "VideoGameID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformVideoGame_VideoGame_VideoGamesVideoGameID",
                table: "PlatformVideoGame",
                column: "VideoGamesVideoGameID",
                principalTable: "VideoGame",
                principalColumn: "VideoGameID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
