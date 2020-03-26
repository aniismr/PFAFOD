using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class AddTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Candidature",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategorieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "test",
                columns: table => new
                {
                    TestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    nbcandidat = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    heure = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test", x => x.TestId);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ennonce = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    rep1 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    rep2 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    rep3 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    reptrue = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    CategorieID = table.Column<int>(nullable: false),
                    TestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Question_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Question_test_TestId",
                        column: x => x.TestId,
                        principalTable: "test",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "testCandidat",
                columns: table => new
                {
                    TestCandidatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(nullable: false),
                    CandidatureID = table.Column<int>(nullable: false),
                    score = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testCandidat", x => x.TestCandidatID);
                    table.ForeignKey(
                        name: "FK_testCandidat_Candidature_CandidatureID",
                        column: x => x.CandidatureID,
                        principalTable: "Candidature",
                        principalColumn: "CandidatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_testCandidat_test_TestID",
                        column: x => x.TestID,
                        principalTable: "test",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestQuestion",
                columns: table => new
                {
                    TestQuestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(nullable: false),
                    QuestionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestQuestion", x => x.TestQuestionID);
                    table.ForeignKey(
                        name: "FK_TestQuestion_Question_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestQuestion_test_TestID",
                        column: x => x.TestID,
                        principalTable: "test",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidature_TestId",
                table: "Candidature",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_CategorieID",
                table: "Question",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_TestId",
                table: "Question",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_testCandidat_CandidatureID",
                table: "testCandidat",
                column: "CandidatureID");

            migrationBuilder.CreateIndex(
                name: "IX_testCandidat_TestID",
                table: "testCandidat",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestion_QuestionID",
                table: "TestQuestion",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestion_TestID",
                table: "TestQuestion",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidature_test_TestId",
                table: "Candidature",
                column: "TestId",
                principalTable: "test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidature_test_TestId",
                table: "Candidature");

            migrationBuilder.DropTable(
                name: "testCandidat");

            migrationBuilder.DropTable(
                name: "TestQuestion");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "test");

            migrationBuilder.DropIndex(
                name: "IX_Candidature_TestId",
                table: "Candidature");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Candidature");
        }
    }
}
