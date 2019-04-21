using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class AlterRealtionshipContratoTrabalho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContratoTrabalho_CarteiraTrabalho_CarteiraTrabalhoId",
                table: "ContratoTrabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoTrabalho_Empresa_EmpresaId",
                table: "ContratoTrabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalNascimento_Estado",
                table: "LocalNascimento");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalNascimento_Funcionario",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_ContratoTrabalho_CarteiraTrabalhoId",
                table: "ContratoTrabalho");

            migrationBuilder.DropIndex(
                name: "IX_ContratoTrabalho_EmpresaId",
                table: "ContratoTrabalho");

            migrationBuilder.DropColumn(
                name: "CarteiraTrabalhoId",
                table: "ContratoTrabalho");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "ContratoTrabalho");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataAumento",
                table: "AlteracaoSalarial",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_IdCarteiraTrabalho",
                table: "ContratoTrabalho",
                column: "IdCarteiraTrabalho");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_IdEmpresa",
                table: "ContratoTrabalho",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoTrabalho_CarteiraTrabalho",
                table: "ContratoTrabalho",
                column: "IdCarteiraTrabalho",
                principalTable: "CarteiraTrabalho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoTrabalho_Empresa",
                table: "ContratoTrabalho",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_LocalNascimento",
                table: "LocalNascimento",
                column: "IdEstado",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_LocalNascimento",
                table: "LocalNascimento",
                column: "IdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContratoTrabalho_CarteiraTrabalho",
                table: "ContratoTrabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoTrabalho_Empresa",
                table: "ContratoTrabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_Estado_LocalNascimento",
                table: "LocalNascimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_LocalNascimento",
                table: "LocalNascimento");

            migrationBuilder.DropIndex(
                name: "IX_ContratoTrabalho_IdCarteiraTrabalho",
                table: "ContratoTrabalho");

            migrationBuilder.DropIndex(
                name: "IX_ContratoTrabalho_IdEmpresa",
                table: "ContratoTrabalho");

            migrationBuilder.AddColumn<int>(
                name: "CarteiraTrabalhoId",
                table: "ContratoTrabalho",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "ContratoTrabalho",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAumento",
                table: "AlteracaoSalarial",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_CarteiraTrabalhoId",
                table: "ContratoTrabalho",
                column: "CarteiraTrabalhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_EmpresaId",
                table: "ContratoTrabalho",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoTrabalho_CarteiraTrabalho_CarteiraTrabalhoId",
                table: "ContratoTrabalho",
                column: "CarteiraTrabalhoId",
                principalTable: "CarteiraTrabalho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoTrabalho_Empresa_EmpresaId",
                table: "ContratoTrabalho",
                column: "EmpresaId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_LocalNascimento_Funcionario",
                table: "LocalNascimento",
                column: "IdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
