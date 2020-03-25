using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class EditCC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CompetenceCandidaure",
                table: "CompetenceCandidaure");

            migrationBuilder.DropColumn(
                name: "CompetenceCandidaureID",
                table: "CompetenceCandidaure");

            migrationBuilder.AddColumn<int>(
                name: "CompetenceCandidatureID",
                table: "CompetenceCandidaure",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompetenceCandidaure",
                table: "CompetenceCandidaure",
                column: "CompetenceCandidatureID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CompetenceCandidaure",
                table: "CompetenceCandidaure");

            migrationBuilder.DropColumn(
                name: "CompetenceCandidatureID",
                table: "CompetenceCandidaure");

            migrationBuilder.AddColumn<int>(
                name: "CompetenceCandidaureID",
                table: "CompetenceCandidaure",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompetenceCandidaure",
                table: "CompetenceCandidaure",
                column: "CompetenceCandidaureID");
        }
    }
}
