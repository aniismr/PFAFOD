using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidat",
                columns: table => new
                {
                    CandidatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    CandidatNom = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CandidatPrenom = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DateDeNaissance = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidat", x => x.CandidatId);
                });

            migrationBuilder.CreateTable(
                name: "Competence",
                columns: table => new
                {
                    CompetenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetenceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competence", x => x.CompetenceID);
                });

            migrationBuilder.CreateTable(
                name: "Candidature",
                columns: table => new
                {
                    CandidatureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePostulation = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    CandidatID = table.Column<int>(nullable: false),
                    CV = table.Column<string>(nullable: true),
                    Reponse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidature", x => x.CandidatureID);
                    table.ForeignKey(
                        name: "FK_Candidature_Candidat_CandidatID",
                        column: x => x.CandidatID,
                        principalTable: "Candidat",
                        principalColumn: "CandidatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetenceCandidaure",
                columns: table => new
                {
                    CompetenceCandidaureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatureID = table.Column<int>(nullable: false),
                    CompetenceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetenceCandidaure", x => x.CompetenceCandidaureID);
                    table.ForeignKey(
                        name: "FK_CompetenceCandidaure_Candidature_CandidatureID",
                        column: x => x.CandidatureID,
                        principalTable: "Candidature",
                        principalColumn: "CandidatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetenceCandidaure_Competence_CompetenceID",
                        column: x => x.CompetenceID,
                        principalTable: "Competence",
                        principalColumn: "CompetenceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidature_CandidatID",
                table: "Candidature",
                column: "CandidatID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetenceCandidaure_CandidatureID",
                table: "CompetenceCandidaure",
                column: "CandidatureID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetenceCandidaure_CompetenceID",
                table: "CompetenceCandidaure",
                column: "CompetenceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetenceCandidaure");

            migrationBuilder.DropTable(
                name: "Candidature");

            migrationBuilder.DropTable(
                name: "Competence");

            migrationBuilder.DropTable(
                name: "Candidat");
        }
    }
}
