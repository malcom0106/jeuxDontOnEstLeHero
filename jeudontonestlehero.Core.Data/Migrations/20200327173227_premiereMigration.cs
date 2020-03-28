using Microsoft.EntityFrameworkCore.Migrations;

namespace jeudontonestlehero.Core.Data.Migrations
{
    public partial class premiereMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aventure",
                columns: table => new
                {
                    AventureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TypeAventure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aventure", x => x.AventureId);
                });

            migrationBuilder.CreateTable(
                name: "Paragraphe",
                columns: table => new
                {
                    ParagrapheID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(nullable: false),
                    Titre = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paragraphe", x => x.ParagrapheID);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(nullable: true),
                    ParagrapheID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Question_Paragraphe_ParagrapheID",
                        column: x => x.ParagrapheID,
                        principalTable: "Paragraphe",
                        principalColumn: "ParagrapheID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reponse",
                columns: table => new
                {
                    ReponseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    QuestionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reponse", x => x.ReponseId);
                    table.ForeignKey(
                        name: "FK_Reponse_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_ParagrapheID",
                table: "Question",
                column: "ParagrapheID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reponse_QuestionId",
                table: "Reponse",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aventure");

            migrationBuilder.DropTable(
                name: "Reponse");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Paragraphe");
        }
    }
}
