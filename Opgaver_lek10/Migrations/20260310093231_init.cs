using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opgaver_lek10.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "Klasser",
            //     columns: table => new
            //     {
            //         KlasseId = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         KlasseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Klasser", x => x.KlasseId);
            //     });
            //
            // migrationBuilder.CreateTable(
            //     name: "Lærer",
            //     columns: table => new
            //     {
            //         LæreID = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Lærer", x => x.LæreID);
            //     });
            //
            // migrationBuilder.CreateTable(
            //     name: "Elever",
            //     columns: table => new
            //     {
            //         ElevID = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         CPR = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         klasseId = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Elever", x => x.ElevID);
            //         table.ForeignKey(
            //             name: "FK_Elever_Klasser_klasseId",
            //             column: x => x.klasseId,
            //             principalTable: "Klasser",
            //             principalColumn: "KlasseId");
            //     });
            //
            // migrationBuilder.CreateTable(
            //     name: "KlasseLære",
            //     columns: table => new
            //     {
            //         KlasserKlasseId = table.Column<int>(type: "int", nullable: false),
            //         LærerLæreID = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_KlasseLære", x => new { x.KlasserKlasseId, x.LærerLæreID });
            //         table.ForeignKey(
            //             name: "FK_KlasseLære_Klasser_KlasserKlasseId",
            //             column: x => x.KlasserKlasseId,
            //             principalTable: "Klasser",
            //             principalColumn: "KlasseId",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "FK_KlasseLære_Lærer_LærerLæreID",
            //             column: x => x.LærerLæreID,
            //             principalTable: "Lærer",
            //             principalColumn: "LæreID",
            //             onDelete: ReferentialAction.Cascade);
            //     });
            //
            // migrationBuilder.InsertData(
            //     table: "Klasser",
            //     columns: new[] { "KlasseId", "KlasseName" },
            //     values: new object[] { 1, "1A" });
            //
            // migrationBuilder.InsertData(
            //     table: "Elever",
            //     columns: new[] { "ElevID", "Adresse", "CPR", "Navn", "klasseId" },
            //     values: new object[] { 1, "Solsikkevej 67", "140189-1234", "Vilje", 1 });
            //
            // migrationBuilder.CreateIndex(
            //     name: "IX_Elever_klasseId",
            //     table: "Elever",
            //     column: "klasseId");
            //
            // migrationBuilder.CreateIndex(
            //     name: "IX_KlasseLære_LærerLæreID",
            //     table: "KlasseLære",
            //     column: "LærerLæreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elever");

            migrationBuilder.DropTable(
                name: "KlasseLære");

            migrationBuilder.DropTable(
                name: "Klasser");

            migrationBuilder.DropTable(
                name: "Lærer");
        }
    }
}
