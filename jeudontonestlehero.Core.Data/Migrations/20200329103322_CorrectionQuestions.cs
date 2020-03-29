using Microsoft.EntityFrameworkCore.Migrations;

namespace jeudontonestlehero.Core.Data.Migrations
{
    public partial class CorrectionQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphe_Question_maQuestionQuestionId",
                table: "Paragraphe");

            migrationBuilder.DropIndex(
                name: "IX_Paragraphe_maQuestionQuestionId",
                table: "Paragraphe");

            migrationBuilder.DropColumn(
                name: "maQuestionQuestionId",
                table: "Paragraphe");

            migrationBuilder.AddColumn<int>(
                name: "ParagrapheId",
                table: "Question",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Paragraphe",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paragraphe",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ParagrapheId",
                table: "Question",
                column: "ParagrapheId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Paragraphe_ParagrapheId",
                table: "Question",
                column: "ParagrapheId",
                principalTable: "Paragraphe",
                principalColumn: "ParagrapheID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Paragraphe_ParagrapheId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_ParagrapheId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "ParagrapheId",
                table: "Question");

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "maQuestionQuestionId",
                table: "Paragraphe",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphe_maQuestionQuestionId",
                table: "Paragraphe",
                column: "maQuestionQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphe_Question_maQuestionQuestionId",
                table: "Paragraphe",
                column: "maQuestionQuestionId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
