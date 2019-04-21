using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class AddFGTSTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FGTS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdContratoTrabalho = table.Column<int>(nullable: false),
                    Opcao = table.Column<DateTime>(nullable: false),
                    Retratacao = table.Column<DateTime>(nullable: true),
                    BancoDepositario = table.Column<string>(nullable: true),
                    Agencia = table.Column<int>(nullable: true),
                    Praca = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    ContratoTrabalhoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FGTS_ContratoTrabalho_ContratoTrabalhoId",
                        column: x => x.ContratoTrabalhoId,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FGTS_ContratoTrabalhoId",
                table: "FGTS",
                column: "ContratoTrabalhoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FGTS");
        }
    }
}
