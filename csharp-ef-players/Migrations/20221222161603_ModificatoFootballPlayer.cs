using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpefplayers.Migrations
{
    /// <inheritdoc />
    public partial class ModificatoFootballPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(name: "Team_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    città = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    allenatore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    colori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayer",
                columns: table => new
                {
                    playerId = table.Column<int>(name: "player_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vote = table.Column<double>(type: "float", nullable: false),
                    gameNumber = table.Column<int>(type: "int", nullable: false),
                    winNumber = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(name: "Team_Id", type: "int", nullable: false),
                    TeamId1 = table.Column<int>(name: "Team_Id1", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayer", x => x.playerId);
                    table.ForeignKey(
                        name: "FK_FootballPlayer_Team_Team_Id1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Team_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_player_Id",
                table: "FootballPlayer",
                column: "player_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_Team_Id1",
                table: "FootballPlayer",
                column: "Team_Id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballPlayer");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
