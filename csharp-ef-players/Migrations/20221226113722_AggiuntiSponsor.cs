using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpefplayers.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntiSponsor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sponsors",
                columns: table => new
                {
                    SponsorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Scadenza = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsors", x => x.SponsorId);
                });

            migrationBuilder.CreateTable(
                name: "SponsorTeam",
                columns: table => new
                {
                    ListaSponsorSponsorId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorTeam", x => new { x.ListaSponsorSponsorId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_SponsorTeam_Sponsors_ListaSponsorSponsorId",
                        column: x => x.ListaSponsorSponsorId,
                        principalTable: "Sponsors",
                        principalColumn: "SponsorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SponsorTeam_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SponsorTeam_TeamId",
                table: "SponsorTeam",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SponsorTeam");

            migrationBuilder.DropTable(
                name: "Sponsors");
        }
    }
}
