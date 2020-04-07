using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidature_test_TestId",
                table: "Candidature");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_test_TestId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_TestQuestion_test_TestID",
                table: "TestQuestion");

            migrationBuilder.DropTable(
                name: "testCandidat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_test",
                table: "test");

            migrationBuilder.DropIndex(
                name: "IX_Question_TestId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Candidature_TestId",
                table: "Candidature");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Candidature");

            migrationBuilder.RenameTable(
                name: "test",
                newName: "Test");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test",
                table: "Test",
                column: "TestId");

            migrationBuilder.CreateTable(
                name: "testCandidature",
                columns: table => new
                {
                    TestCandidatureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(nullable: false),
                    CandidatureID = table.Column<int>(nullable: false),
                    Score = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testCandidature", x => x.TestCandidatureID);
                    table.ForeignKey(
                        name: "FK_testCandidature_Candidature_CandidatureID",
                        column: x => x.CandidatureID,
                        principalTable: "Candidature",
                        principalColumn: "CandidatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_testCandidature_Test_TestID",
                        column: x => x.TestID,
                        principalTable: "Test",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_testCandidature_CandidatureID",
                table: "testCandidature",
                column: "CandidatureID");

            migrationBuilder.CreateIndex(
                name: "IX_testCandidature_TestID",
                table: "testCandidature",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_TestQuestion_Test_TestID",
                table: "TestQuestion",
                column: "TestID",
                principalTable: "Test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestQuestion_Test_TestID",
                table: "TestQuestion");

            migrationBuilder.DropTable(
                name: "testCandidature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Test",
                table: "Test");

            migrationBuilder.RenameTable(
                name: "Test",
                newName: "test");

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Question",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Candidature",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_test",
                table: "test",
                column: "TestId");

            migrationBuilder.CreateTable(
                name: "testCandidat",
                columns: table => new
                {
                    TestCandidatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatureID = table.Column<int>(type: "int", nullable: false),
                    TestID = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Question_TestId",
                table: "Question",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidature_TestId",
                table: "Candidature",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_testCandidat_CandidatureID",
                table: "testCandidat",
                column: "CandidatureID");

            migrationBuilder.CreateIndex(
                name: "IX_testCandidat_TestID",
                table: "testCandidat",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidature_test_TestId",
                table: "Candidature",
                column: "TestId",
                principalTable: "test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_test_TestId",
                table: "Question",
                column: "TestId",
                principalTable: "test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestQuestion_test_TestID",
                table: "TestQuestion",
                column: "TestID",
                principalTable: "test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
