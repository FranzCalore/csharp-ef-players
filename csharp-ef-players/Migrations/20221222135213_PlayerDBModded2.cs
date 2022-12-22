using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpefplayers.Migrations
{
    /// <inheritdoc />
    public partial class PlayerDBModded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FootballPlayer_player_Id",
                table: "FootballPlayer");

            migrationBuilder.AlterColumn<double>(
                name: "vote",
                table: "FootballPlayer",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_player_Id",
                table: "FootballPlayer",
                column: "player_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FootballPlayer_player_Id",
                table: "FootballPlayer");

            migrationBuilder.AlterColumn<int>(
                name: "vote",
                table: "FootballPlayer",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayer_player_Id",
                table: "FootballPlayer",
                column: "player_Id");
        }
    }
}
