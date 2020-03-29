using Microsoft.EntityFrameworkCore.Migrations;

namespace jeudontonestlehero.Core.Data.Migrations
{
    public partial class CorrectionOrthographiqueParagrapheId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParagrapheID",
                table: "Paragraphe",
                newName: "ParagrapheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParagrapheId",
                table: "Paragraphe",
                newName: "ParagrapheID");
        }
    }
}
