using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class TestModifier23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_testCandidature_Candidature_CandidatureID",
                table: "testCandidature");

            migrationBuilder.DropForeignKey(
                name: "FK_testCandidature_Test_TestID",
                table: "testCandidature");

            migrationBuilder.DropTable(
                name: "TestQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_testCandidature",
                table: "testCandidature");

            migrationBuilder.RenameTable(
                name: "testCandidature",
                newName: "TestCandidature");

            migrationBuilder.RenameIndex(
                name: "IX_testCandidature_TestID",
                table: "TestCandidature",
                newName: "IX_TestCandidature_TestID");

            migrationBuilder.RenameIndex(
                name: "IX_testCandidature_CandidatureID",
                table: "TestCandidature",
                newName: "IX_TestCandidature_CandidatureID");

            migrationBuilder.AlterColumn<string>(
                name: "NbCandidature",
                table: "Test",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NbPlace",
                table: "Test",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Test",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestCandidature",
                table: "TestCandidature",
                column: "TestCandidatureID");

            migrationBuilder.CreateTable(
                name: "TestCategorie",
                columns: table => new
                {
                    TestCategorieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(nullable: false),
                    CategorieID = table.Column<int>(nullable: false),
                    NbQuestion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCategorie", x => x.TestCategorieID);
                    table.ForeignKey(
                        name: "FK_TestCategorie_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "CategorieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestCategorie_Test_TestID",
                        column: x => x.TestID,
                        principalTable: "Test",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestCategorie_CategorieID",
                table: "TestCategorie",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_TestCategorie_TestID",
                table: "TestCategorie",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_TestCandidature_Candidature_CandidatureID",
                table: "TestCandidature",
                column: "CandidatureID",
                principalTable: "Candidature",
                principalColumn: "CandidatureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestCandidature_Test_TestID",
                table: "TestCandidature",
                column: "TestID",
                principalTable: "Test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestCandidature_Candidature_CandidatureID",
                table: "TestCandidature");

            migrationBuilder.DropForeignKey(
                name: "FK_TestCandidature_Test_TestID",
                table: "TestCandidature");

            migrationBuilder.DropTable(
                name: "TestCategorie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestCandidature",
                table: "TestCandidature");

            migrationBuilder.DropColumn(
                name: "NbPlace",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Test");

            migrationBuilder.RenameTable(
                name: "TestCandidature",
                newName: "testCandidature");

            migrationBuilder.RenameIndex(
                name: "IX_TestCandidature_TestID",
                table: "testCandidature",
                newName: "IX_testCandidature_TestID");

            migrationBuilder.RenameIndex(
                name: "IX_TestCandidature_CandidatureID",
                table: "testCandidature",
                newName: "IX_testCandidature_CandidatureID");

            migrationBuilder.AlterColumn<string>(
                name: "NbCandidature",
                table: "Test",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_testCandidature",
                table: "testCandidature",
                column: "TestCandidatureID");

            migrationBuilder.CreateTable(
                name: "TestQuestion",
                columns: table => new
                {
                    TestQuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    TestID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestQuestion", x => x.TestQuestionID);
                    table.ForeignKey(
                        name: "FK_TestQuestion_Question_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestQuestion_Test_TestID",
                        column: x => x.TestID,
                        principalTable: "Test",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestion_QuestionID",
                table: "TestQuestion",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestion_TestID",
                table: "TestQuestion",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_testCandidature_Candidature_CandidatureID",
                table: "testCandidature",
                column: "CandidatureID",
                principalTable: "Candidature",
                principalColumn: "CandidatureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_testCandidature_Test_TestID",
                table: "testCandidature",
                column: "TestID",
                principalTable: "Test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
