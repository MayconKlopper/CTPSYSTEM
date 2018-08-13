using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class UpdateLocalNascimentoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "LocalNascimento");

            migrationBuilder.AddColumn<int>(
                name: "IdEstado",
                table: "LocalNascimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LocalNascimento_IdEstado",
                table: "LocalNascimento",
                column: "IdEstado",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_localNascimento",
                table: "LocalNascimento",
                column: "IdEstado",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_localNascimento",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_LocalNascimento_IdEstado",
                table: "LocalNascimento");

            migrationBuilder.DropColumn(
                name: "IdEstado",
                table: "LocalNascimento");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "LocalNascimento",
                nullable: true);
        }
    }
}
