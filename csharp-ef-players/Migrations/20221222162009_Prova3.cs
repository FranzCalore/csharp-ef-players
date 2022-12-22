using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpefplayers.Migrations
{
    /// <inheritdoc />
    public partial class Prova3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballPlayer_Team_Team_Id1",
                table: "FootballPlayer");

            migrationBuilder.DropIndex(
                name: "IX_FootballPlayer_Team_Id1",
                table: "FootballPlayer");

            migrationBuilder.DropColumn(
                name: "Team_Id1",
                table: "FootballPlayer");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_Team_Id",
                table: "FootballPlayer",
                column: "Team_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballPlayer_Team_Team_Id",
                table: "FootballPlayer",
                column: "Team_Id",
                principalTable: "Team",
                principalColumn: "Team_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballPlayer_Team_Team_Id",
                table: "FootballPlayer");

            migrationBuilder.DropIndex(
                name: "IX_FootballPlayer_Team_Id",
                table: "FootballPlayer");

            migrationBuilder.AddColumn<int>(
                name: "Team_Id1",
                table: "FootballPlayer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_Team_Id1",
                table: "FootballPlayer",
                column: "Team_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballPlayer_Team_Team_Id1",
                table: "FootballPlayer",
                column: "Team_Id1",
                principalTable: "Team",
                principalColumn: "Team_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
