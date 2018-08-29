using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class AddHashTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hash",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HashCode = table.Column<string>(nullable: true),
                    IdFuncionario = table.Column<int>(nullable: false),
                    IdCarteiraTrabalho = table.Column<int>(nullable: false),
                    IdEmpresa = table.Column<int>(nullable: false),
                    DataGeracao = table.Column<DateTime>(nullable: false),
                    DataExpiracao = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hash", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hash");
        }
    }
}