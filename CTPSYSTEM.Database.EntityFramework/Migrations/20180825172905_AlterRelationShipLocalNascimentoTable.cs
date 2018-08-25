using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class AlterRelationShipLocalNascimentoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalNascimento_CarteiraTrabalho",
                table: "CarteiraTrabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_Estado_localNascimento",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_LocalNascimento_IdEstado",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_CarteiraTrabalho_IdLocalNascimento",
                table: "CarteiraTrabalho");

            migrationBuilder.DropColumn(
                name: "IdLocalNascimento",
                table: "CarteiraTrabalho");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Endereco",
                newName: "Numero");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "LocalNascimento",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFuncionario",
                table: "LocalNascimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LocalNascimento_EstadoId",
                table: "LocalNascimento",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalNascimento_IdFuncionario",
                table: "LocalNascimento",
                column: "IdFuncionario",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalNascimento_Estado_EstadoId",
                table: "LocalNascimento",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalNascimento_Funcionario",
                table: "LocalNascimento",
                column: "IdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalNascimento_Estado_EstadoId",
                table: "LocalNascimento");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalNascimento_Funcionario",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_LocalNascimento_EstadoId",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_LocalNascimento_IdFuncionario",
                table: "LocalNascimento");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "LocalNascimento");

            migrationBuilder.DropColumn(
                name: "IdFuncionario",
                table: "LocalNascimento");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Endereco",
                newName: "numero");

            migrationBuilder.AddColumn<int>(
                name: "IdLocalNascimento",
                table: "CarteiraTrabalho",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LocalNascimento_IdEstado",
                table: "LocalNascimento",
                column: "IdEstado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarteiraTrabalho_IdLocalNascimento",
                table: "CarteiraTrabalho",
                column: "IdLocalNascimento",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalNascimento_CarteiraTrabalho",
                table: "CarteiraTrabalho",
                column: "IdLocalNascimento",
                principalTable: "LocalNascimento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_localNascimento",
                table: "LocalNascimento",
                column: "IdEstado",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
