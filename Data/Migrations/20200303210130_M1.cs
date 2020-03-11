using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FodApi.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidat",
                columns: table => new
                {
                    id_candidat = table.Column<int>(maxLength: 40, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    cv = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    experience = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    datenaissance = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidat", x => x.id_candidat);
                });

            migrationBuilder.CreateTable(
                name: "Candidature",
                columns: table => new
                {
                    id_candidature = table.Column<int>(maxLength: 40, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    datecandidature = table.Column<DateTime>(nullable: false),
                    Candidatid_candidat = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidature", x => x.id_candidature);
                    table.ForeignKey(
                        name: "FK_Candidature_Candidat_Candidatid_candidat",
                        column: x => x.Candidatid_candidat,
                        principalTable: "Candidat",
                        principalColumn: "id_candidat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competence",
                columns: table => new
                {
                    id_competence = table.Column<string>(type: "nvarchar(100)", maxLength: 40, nullable: false),
                    libele = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Candidatureid_candidature = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competence", x => x.id_competence);
                    table.ForeignKey(
                        name: "FK_Competence_Candidature_Candidatureid_candidature",
                        column: x => x.Candidatureid_candidature,
                        principalTable: "Candidature",
                        principalColumn: "id_candidature",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidature_Candidatid_candidat",
                table: "Candidature",
                column: "Candidatid_candidat");

            migrationBuilder.CreateIndex(
                name: "IX_Competence_Candidatureid_candidature",
                table: "Competence",
                column: "Candidatureid_candidature");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competence");

            migrationBuilder.DropTable(
                name: "Candidature");

            migrationBuilder.DropTable(
                name: "Candidat");
        }
    }
}
