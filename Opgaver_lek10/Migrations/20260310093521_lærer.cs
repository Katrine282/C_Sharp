using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opgaver_lek10.Migrations
{
    /// <inheritdoc />
    public partial class lærer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KlasseLære");

            migrationBuilder.RenameColumn(
                name: "LæreID",
                table: "Lærer",
                newName: "LærerID");

            migrationBuilder.CreateTable(
                name: "KlasseLærer",
                columns: table => new
                {
                    KlasserKlasseId = table.Column<int>(type: "int", nullable: false),
                    LærereLærerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlasseLærer", x => new { x.KlasserKlasseId, x.LærereLærerID });
                    table.ForeignKey(
                        name: "FK_KlasseLærer_Klasser_KlasserKlasseId",
                        column: x => x.KlasserKlasseId,
                        principalTable: "Klasser",
                        principalColumn: "KlasseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlasseLærer_Lærer_LærereLærerID",
                        column: x => x.LærereLærerID,
                        principalTable: "Lærer",
                        principalColumn: "LærerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KlasseLærer_LærereLærerID",
                table: "KlasseLærer",
                column: "LærereLærerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KlasseLærer");

            migrationBuilder.RenameColumn(
                name: "LærerID",
                table: "Lærer",
                newName: "LæreID");

            migrationBuilder.CreateTable(
                name: "KlasseLære",
                columns: table => new
                {
                    KlasserKlasseId = table.Column<int>(type: "int", nullable: false),
                    LærerLæreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlasseLære", x => new { x.KlasserKlasseId, x.LærerLæreID });
                    table.ForeignKey(
                        name: "FK_KlasseLære_Klasser_KlasserKlasseId",
                        column: x => x.KlasserKlasseId,
                        principalTable: "Klasser",
                        principalColumn: "KlasseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlasseLære_Lærer_LærerLæreID",
                        column: x => x.LærerLæreID,
                        principalTable: "Lærer",
                        principalColumn: "LæreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KlasseLære_LærerLæreID",
                table: "KlasseLære",
                column: "LærerLæreID");
        }
    }
}
