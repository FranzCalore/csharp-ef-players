using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpefplayers.Migrations
{
    /// <inheritdoc />
    public partial class PlayerDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootballPlayer",
                columns: table => new
                {
                    playerId = table.Column<int>(name: "player_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vote = table.Column<int>(type: "int", nullable: false),
                    gameNumber = table.Column<int>(type: "int", nullable: false),
                    winNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayer", x => x.playerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_player_Id",
                table: "FootballPlayer",
                column: "player_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballPlayer");
        }
    }
}
