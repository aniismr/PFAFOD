using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class TestModifier22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "libelle",
                table: "Categorie",
                newName: "Libelle");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Categorie",
                newName: "CategorieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Libelle",
                table: "Categorie",
                newName: "libelle");

            migrationBuilder.RenameColumn(
                name: "CategorieID",
                table: "Categorie",
                newName: "CategorieId");
        }
    }
}
