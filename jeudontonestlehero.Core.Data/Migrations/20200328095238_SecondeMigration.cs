using Microsoft.EntityFrameworkCore.Migrations;

namespace jeudontonestlehero.Core.Data.Migrations
{
    public partial class SecondeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Paragraphe_ParagrapheID",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                table: "Reponse");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Reponse",
                newName: "QuestionID");

            migrationBuilder.RenameIndex(
                name: "IX_Reponse_QuestionId",
                table: "Reponse",
                newName: "IX_Reponse_QuestionID");

            migrationBuilder.RenameColumn(
                name: "ParagrapheID",
                table: "Question",
                newName: "ParagrapheId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_ParagrapheID",
                table: "Question",
                newName: "IX_Question_ParagrapheId");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionID",
                table: "Reponse",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReponseId",
                table: "Question",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Paragraphe_ParagrapheId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Reponse_Question_QuestionID",
                table: "Reponse");

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

            migrationBuilder.RenameColumn(
                name: "ParagrapheId",
                table: "Question",
                newName: "ParagrapheID");

            migrationBuilder.RenameIndex(
                name: "IX_Question_ParagrapheId",
                table: "Question",
                newName: "IX_Question_ParagrapheID");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Reponse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Paragraphe_ParagrapheID",
                table: "Question",
                column: "ParagrapheID",
                principalTable: "Paragraphe",
                principalColumn: "ParagrapheID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                table: "Reponse",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
