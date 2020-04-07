using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class TestModifier21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "reptrue",
                table: "Question",
                newName: "RepTrue");

            migrationBuilder.RenameColumn(
                name: "rep3",
                table: "Question",
                newName: "Rep3");

            migrationBuilder.RenameColumn(
                name: "rep2",
                table: "Question",
                newName: "Rep2");

            migrationBuilder.RenameColumn(
                name: "rep1",
                table: "Question",
                newName: "Rep1");

            migrationBuilder.RenameColumn(
                name: "ennonce",
                table: "Question",
                newName: "Ennonce");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Question",
                newName: "QuestionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RepTrue",
                table: "Question",
                newName: "reptrue");

            migrationBuilder.RenameColumn(
                name: "Rep3",
                table: "Question",
                newName: "rep3");

            migrationBuilder.RenameColumn(
                name: "Rep2",
                table: "Question",
                newName: "rep2");

            migrationBuilder.RenameColumn(
                name: "Rep1",
                table: "Question",
                newName: "rep1");

            migrationBuilder.RenameColumn(
                name: "Ennonce",
                table: "Question",
                newName: "ennonce");

            migrationBuilder.RenameColumn(
                name: "QuestionID",
                table: "Question",
                newName: "QuestionId");
        }
    }
}
