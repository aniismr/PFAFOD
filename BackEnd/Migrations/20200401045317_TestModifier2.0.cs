using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class TestModifier20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "heure",
                table: "Test",
                newName: "Heure");

            migrationBuilder.RenameColumn(
                name: "nbcandidat",
                table: "Test",
                newName: "NbCandidature");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Heure",
                table: "Test",
                newName: "heure");

            migrationBuilder.RenameColumn(
                name: "NbCandidature",
                table: "Test",
                newName: "nbcandidat");
        }
    }
}
