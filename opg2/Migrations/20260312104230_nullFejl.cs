using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace opg2.Migrations
{
    /// <inheritdoc />
    public partial class nullFejl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_operator",
                table: "calculations",
                newName: "Operator");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Operator",
                table: "calculations",
                newName: "_operator");
        }
    }
}
