using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddBookCopies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCopy_Books_BookId",
                table: "BookCopy");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCopy_Copies_CopyId",
                table: "BookCopy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCopy",
                table: "BookCopy");

            migrationBuilder.RenameTable(
                name: "BookCopy",
                newName: "BookCopies");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopy_CopyId",
                table: "BookCopies",
                newName: "IX_BookCopies_CopyId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopy_BookId",
                table: "BookCopies",
                newName: "IX_BookCopies_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCopies",
                table: "BookCopies",
                column: "BookCopyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Copies_CopyId",
                table: "BookCopies",
                column: "CopyId",
                principalTable: "Copies",
                principalColumn: "CopyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Copies_CopyId",
                table: "BookCopies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCopies",
                table: "BookCopies");

            migrationBuilder.RenameTable(
                name: "BookCopies",
                newName: "BookCopy");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopies_CopyId",
                table: "BookCopy",
                newName: "IX_BookCopy_CopyId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopies_BookId",
                table: "BookCopy",
                newName: "IX_BookCopy_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCopy",
                table: "BookCopy",
                column: "BookCopyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopy_Books_BookId",
                table: "BookCopy",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopy_Copies_CopyId",
                table: "BookCopy",
                column: "CopyId",
                principalTable: "Copies",
                principalColumn: "CopyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
