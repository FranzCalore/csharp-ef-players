using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpefplayers.Migrations
{
    /// <inheritdoc />
    public partial class NuovoDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Città = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Allenatore",
                columns: table => new
                {
                    AllenatoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameNumber = table.Column<int>(type: "int", nullable: false),
                    WinNumber = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allenatore", x => x.AllenatoreId);
                    table.ForeignKey(
                        name: "FK_Allenatore_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId");
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayer",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vote = table.Column<double>(type: "float", nullable: false),
                    GameNumber = table.Column<int>(type: "int", nullable: false),
                    WinNumber = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayer", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_FootballPlayer_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allenatore_AllenatoreId",
                table: "Allenatore",
                column: "AllenatoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Allenatore_TeamId",
                table: "Allenatore",
                column: "TeamId",
                unique: true,
                filter: "[TeamId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_PlayerId",
                table: "FootballPlayer",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_TeamId",
                table: "FootballPlayer",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allenatore");

            migrationBuilder.DropTable(
                name: "FootballPlayer");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
