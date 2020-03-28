using Microsoft.EntityFrameworkCore.Migrations;

namespace jeudontonestlehero.Core.Data.Migrations
{
    public partial class MiseAJourDesClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Paragraphe_ParagrapheId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Reponse_Question_QuestionID",
                table: "Reponse");

            migrationBuilder.DropIndex(
                name: "IX_Question_ParagrapheId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "ParagrapheId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "ReponseId",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "QuestionID",
                table: "Reponse",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Reponse_QuestionID",
                table: "Reponse",
                newName: "IX_Reponse_QuestionId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reponse",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Question",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Paragraphe",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paragraphe",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "maQuestionQuestionId",
                table: "Paragraphe",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                table: "Reponse",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphe_Question_maQuestionQuestionId",
                table: "Paragraphe");

            migrationBuilder.DropForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                table: "Reponse");

            migrationBuilder.DropIndex(
                name: "IX_Paragraphe_maQuestionQuestionId",
                table: "Paragraphe");

            migrationBuilder.DropColumn(
                name: "maQuestionQuestionId",
                table: "Paragraphe");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Reponse",
                newName: "QuestionID");

            migrationBuilder.RenameIndex(
                name: "IX_Reponse_QuestionId",
                table: "Reponse",
                newName: "IX_Reponse_QuestionID");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reponse",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Question",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ParagrapheId",
                table: "Question",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReponseId",
                table: "Question",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reponse_Question_QuestionID",
                table: "Reponse",
                column: "QuestionID",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
