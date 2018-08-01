using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class MigrationConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    Seguimento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Sigla = table.Column<string>(type: "VARCHAR", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalNascimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalNascimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdEmpresa = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Funcionario",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FuncionarioHistorico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdEmpresa = table.Column<int>(nullable: true),
                    IdFuncionario = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Data = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionarioHistorico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_FuncionarioHistorico",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdEstado = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    numero = table.Column<int>(nullable: false),
                    Sala = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estado_Endereco",
                        column: x => x.IdEstado,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarteiraTrabalho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdFuncionario = table.Column<int>(nullable: false),
                    IdLocalNascimento = table.Column<int>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Serie = table.Column<string>(nullable: true),
                    DataEmissao = table.Column<DateTime>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    FiliacaoPai = table.Column<string>(nullable: true),
                    FiliacaoMae = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarteiraTrabalho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionario_CarteiraTrabalho",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocalNascimento_CarteiraTrabalho",
                        column: x => x.IdLocalNascimento,
                        principalTable: "LocalNascimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaHistorico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdFuncionario = table.Column<int>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false),
                    CNPJ = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    Data = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaHistorico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionario_EmpresaHistorico",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoTrabalho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCarteiraTrabalho = table.Column<int>(nullable: false),
                    IdEmpresa = table.Column<int>(nullable: false),
                    Cargo = table.Column<string>(nullable: true),
                    CBONumero = table.Column<int>(nullable: false),
                    DataAdmissao = table.Column<DateTimeOffset>(nullable: false),
                    DataSaida = table.Column<DateTimeOffset>(nullable: false),
                    Remuneracao = table.Column<decimal>(nullable: false),
                    RemuneracaoExtenso = table.Column<string>(nullable: true),
                    FlsFicha = table.Column<int>(nullable: false),
                    RegistroNumero = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: true),
                    CarteiraTrabalhoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoTrabalho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_CarteiraTrabalho_CarteiraTrabalhoId",
                        column: x => x.CarteiraTrabalhoId,
                        principalTable: "CarteiraTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estrangeiro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCarteiraTrabalho = table.Column<int>(nullable: false),
                    Chegada = table.Column<DateTime>(nullable: false),
                    DocumentoIdentidade = table.Column<string>(nullable: true),
                    Expedicao = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estrangeiro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarteiraTrabalho_Estrangeiro",
                        column: x => x.IdCarteiraTrabalho,
                        principalTable: "CarteiraTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Internacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCarteiraTrabalho = table.Column<int>(nullable: false),
                    Hospital = table.Column<string>(nullable: true),
                    Registro = table.Column<string>(nullable: true),
                    Matricula = table.Column<string>(nullable: true),
                    DataInternacao = table.Column<DateTimeOffset>(nullable: false),
                    DataAlta = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarteiraTrabalho_Internacao",
                        column: x => x.IdCarteiraTrabalho,
                        principalTable: "CarteiraTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Licenca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCarteiraTrabalho = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTimeOffset>(nullable: false),
                    DataTermino = table.Column<DateTimeOffset>(nullable: false),
                    Dias = table.Column<int>(nullable: false),
                    CodigoPosto = table.Column<int>(nullable: false),
                    Motivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarteiraTrabalho_Licenca",
                        column: x => x.IdCarteiraTrabalho,
                        principalTable: "CarteiraTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlteracaoSalarial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdContratoTrabalho = table.Column<int>(nullable: false),
                    DataAumento = table.Column<DateTime>(nullable: false),
                    Remuneracao = table.Column<decimal>(nullable: false),
                    RemuneracaoExtenso = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Motivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlteracaoSalarial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_AlteracaoSalarial",
                        column: x => x.IdContratoTrabalho,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnotacaoGeral",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdContratoTrabalho = table.Column<int>(nullable: false),
                    Texto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnotacaoGeral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_AnotacaoGeral",
                        column: x => x.IdContratoTrabalho,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContribuicaoSindical",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdContratoTrabalho = table.Column<int>(nullable: false),
                    ValorContribuicao = table.Column<decimal>(nullable: false),
                    NomeSindicato = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContribuicaoSindical", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_ContribuicaoSindical",
                        column: x => x.IdContratoTrabalho,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ferias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdContratoTrabalho = table.Column<int>(nullable: false),
                    PeriodoRelativo = table.Column<string>(nullable: true),
                    DataInicio = table.Column<DateTimeOffset>(nullable: false),
                    DataTermino = table.Column<DateTimeOffset>(nullable: false),
                    Dias = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_Ferias",
                        column: x => x.IdContratoTrabalho,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlteracaoSalarial_IdContratoTrabalho",
                table: "AlteracaoSalarial",
                column: "IdContratoTrabalho");

            migrationBuilder.CreateIndex(
                name: "IX_AnotacaoGeral_IdContratoTrabalho",
                table: "AnotacaoGeral",
                column: "IdContratoTrabalho");

            migrationBuilder.CreateIndex(
                name: "IX_CarteiraTrabalho_IdFuncionario",
                table: "CarteiraTrabalho",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_CarteiraTrabalho_IdLocalNascimento",
                table: "CarteiraTrabalho",
                column: "IdLocalNascimento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_CarteiraTrabalhoId",
                table: "ContratoTrabalho",
                column: "CarteiraTrabalhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_EmpresaId",
                table: "ContratoTrabalho",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContribuicaoSindical_IdContratoTrabalho",
                table: "ContribuicaoSindical",
                column: "IdContratoTrabalho");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaHistorico_IdFuncionario",
                table: "EmpresaHistorico",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EmpresaId",
                table: "Endereco",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdEstado",
                table: "Endereco",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Estrangeiro_IdCarteiraTrabalho",
                table: "Estrangeiro",
                column: "IdCarteiraTrabalho",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_IdContratoTrabalho",
                table: "Ferias",
                column: "IdContratoTrabalho");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_IdEmpresa",
                table: "Funcionario",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioHistorico_IdEmpresa",
                table: "FuncionarioHistorico",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Internacao_IdCarteiraTrabalho",
                table: "Internacao",
                column: "IdCarteiraTrabalho");

            migrationBuilder.CreateIndex(
                name: "IX_Licenca_IdCarteiraTrabalho",
                table: "Licenca",
                column: "IdCarteiraTrabalho");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlteracaoSalarial");

            migrationBuilder.DropTable(
                name: "AnotacaoGeral");

            migrationBuilder.DropTable(
                name: "ContribuicaoSindical");

            migrationBuilder.DropTable(
                name: "EmpresaHistorico");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Estrangeiro");

            migrationBuilder.DropTable(
                name: "Ferias");

            migrationBuilder.DropTable(
                name: "FuncionarioHistorico");

            migrationBuilder.DropTable(
                name: "Internacao");

            migrationBuilder.DropTable(
                name: "Licenca");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "ContratoTrabalho");

            migrationBuilder.DropTable(
                name: "CarteiraTrabalho");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "LocalNascimento");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
