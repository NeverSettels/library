using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class EditCopies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Edition",
                table: "Copies",
                newName: "Condition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Condition",
                table: "Copies",
                newName: "Edition");
        }
    }
}
