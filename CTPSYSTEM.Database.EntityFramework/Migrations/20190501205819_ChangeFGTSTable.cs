using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class ChangeFGTSTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FGTS_ContratoTrabalho_ContratoTrabalhoId",
                table: "FGTS");

            migrationBuilder.DropIndex(
                name: "IX_FGTS_ContratoTrabalhoId",
                table: "FGTS");

            migrationBuilder.DropColumn(
                name: "ContratoTrabalhoId",
                table: "FGTS");

            migrationBuilder.AlterColumn<string>(
                name: "Praca",
                table: "FGTS",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BancoDepositario",
                table: "FGTS",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Agencia",
                table: "FGTS",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FGTS_IdContratoTrabalho",
                table: "FGTS",
                column: "IdContratoTrabalho");

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoTrabalho_FGTS",
                table: "FGTS",
                column: "IdContratoTrabalho",
                principalTable: "ContratoTrabalho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContratoTrabalho_FGTS",
                table: "FGTS");

            migrationBuilder.DropIndex(
                name: "IX_FGTS_IdContratoTrabalho",
                table: "FGTS");

            migrationBuilder.AlterColumn<string>(
                name: "Praca",
                table: "FGTS",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BancoDepositario",
                table: "FGTS",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Agencia",
                table: "FGTS",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContratoTrabalhoId",
                table: "FGTS",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FGTS_ContratoTrabalhoId",
                table: "FGTS",
                column: "ContratoTrabalhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGTS_ContratoTrabalho_ContratoTrabalhoId",
                table: "FGTS",
                column: "ContratoTrabalhoId",
                principalTable: "ContratoTrabalho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
