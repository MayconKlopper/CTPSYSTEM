using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class AddColumnContratoTrabalhoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "ContratoTrabalho",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "ContratoTrabalho");
        }
    }
}