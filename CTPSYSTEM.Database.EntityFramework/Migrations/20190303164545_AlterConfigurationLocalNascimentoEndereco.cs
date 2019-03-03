using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class AlterConfigurationLocalNascimentoEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Empresa_EmpresaId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalNascimento_Estado_EstadoId",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_LocalNascimento_EstadoId",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_EmpresaId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "LocalNascimento");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Endereco");

            migrationBuilder.CreateIndex(
                name: "IX_LocalNascimento_IdEstado",
                table: "LocalNascimento",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdEmpresa",
                table: "Endereco",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Endereco",
                table: "Endereco",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalNascimento_Estado",
                table: "LocalNascimento",
                column: "IdEstado",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Endereco",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalNascimento_Estado",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_LocalNascimento_IdEstado",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_IdEmpresa",
                table: "Endereco");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "LocalNascimento",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Endereco",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocalNascimento_EstadoId",
                table: "LocalNascimento",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EmpresaId",
                table: "Endereco",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Empresa_EmpresaId",
                table: "Endereco",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalNascimento_Estado_EstadoId",
                table: "LocalNascimento",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
