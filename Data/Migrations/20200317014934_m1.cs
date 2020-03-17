using Microsoft.EntityFrameworkCore.Migrations;

namespace FodApi.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidature",
                columns: table => new
                {
                    id = table.Column<int>(maxLength: 40, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datepostulation = table.Column<string>(nullable: true),
                    type = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    cv = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidature", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    id = table.Column<int>(maxLength: 40, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    mdp = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Candidat",
                columns: table => new
                {
                    id = table.Column<int>(maxLength: 40, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    experience = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    date_de_naissance = table.Column<string>(nullable: true),
                    Candidatureid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Candidat_Candidature_Candidatureid",
                        column: x => x.Candidatureid,
                        principalTable: "Candidature",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competence",
                columns: table => new
                {
                    id = table.Column<int>(maxLength: 40, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libele = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Candidatureid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competence", x => x.id);
                    table.ForeignKey(
                        name: "FK_Competence_Candidature_Candidatureid",
                        column: x => x.Candidatureid,
                        principalTable: "Candidature",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    id = table.Column<int>(maxLength: 40, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    designation = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Utilisateurid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.id);
                    table.ForeignKey(
                        name: "FK_Role_Utilisateur_Utilisateurid",
                        column: x => x.Utilisateurid,
                        principalTable: "Utilisateur",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidat_Candidatureid",
                table: "Candidat",
                column: "Candidatureid");

            migrationBuilder.CreateIndex(
                name: "IX_Competence_Candidatureid",
                table: "Competence",
                column: "Candidatureid");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Utilisateurid",
                table: "Role",
                column: "Utilisateurid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidat");

            migrationBuilder.DropTable(
                name: "Competence");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Candidature");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
