﻿// <auto-generated />
using System;
using CTPSYSTEM.Database.EntityFramework.FonteDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    [DbContext(typeof(Conexao))]
    [Migration("20180818163443_AlterFuncionarioTable")]
    partial class AlterFuncionarioTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CTPSYSTEM.Domain.AlteracaoSalarial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo");

                    b.Property<DateTime>("DataAumento");

                    b.Property<int>("IdContratoTrabalho");

                    b.Property<string>("Motivo");

                    b.Property<decimal>("Remuneracao");

                    b.Property<string>("RemuneracaoExtenso");

                    b.HasKey("Id")
                        .HasName("PK_AlteracaoSalarial");

                    b.HasIndex("IdContratoTrabalho");

                    b.ToTable("AlteracaoSalarial");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.AnotacaoGeral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdContratoTrabalho");

                    b.Property<string>("Texto");

                    b.HasKey("Id")
                        .HasName("PK_AnotacaoGeral");

                    b.HasIndex("IdContratoTrabalho");

                    b.ToTable("AnotacaoGeral");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.CarteiraTrabalho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime>("DataEmissao");

                    b.Property<string>("FiliacaoMae");

                    b.Property<string>("FiliacaoPai");

                    b.Property<string>("Foto");

                    b.Property<int>("IdFuncionario");

                    b.Property<int>("IdLocalNascimento");

                    b.Property<int>("Numero");

                    b.Property<string>("NumeroDocumento");

                    b.Property<string>("Serie");

                    b.HasKey("Id")
                        .HasName("PK_CarteiraTrabalho");

                    b.HasIndex("IdFuncionario");

                    b.HasIndex("IdLocalNascimento")
                        .IsUnique();

                    b.ToTable("CarteiraTrabalho");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.ContratoTrabalho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CBONumero");

                    b.Property<string>("Cargo");

                    b.Property<int?>("CarteiraTrabalhoId");

                    b.Property<DateTimeOffset>("DataAdmissao");

                    b.Property<DateTimeOffset>("DataSaida");

                    b.Property<int?>("EmpresaId");

                    b.Property<int>("FlsFicha");

                    b.Property<int>("IdCarteiraTrabalho");

                    b.Property<int>("IdEmpresa");

                    b.Property<int>("RegistroNumero");

                    b.Property<decimal>("Remuneracao");

                    b.Property<string>("RemuneracaoExtenso");

                    b.HasKey("Id");

                    b.HasIndex("CarteiraTrabalhoId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("ContratoTrabalho");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.ContribuicaoSindical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano");

                    b.Property<int>("IdContratoTrabalho");

                    b.Property<string>("NomeSindicato");

                    b.Property<decimal>("ValorContribuicao");

                    b.HasKey("Id")
                        .HasName("PK_ContribuicaoSindical");

                    b.HasIndex("IdContratoTrabalho");

                    b.ToTable("ContribuicaoSindical");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Seguimento");

                    b.HasKey("Id")
                        .HasName("PK_Empresa");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade");

                    b.Property<int?>("EmpresaId");

                    b.Property<int>("IdEstado");

                    b.Property<string>("Rua");

                    b.Property<string>("Sala");

                    b.Property<int>("numero");

                    b.HasKey("Id")
                        .HasName("PK_Endereco");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("IdEstado");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<int>("Sigla");

                    b.HasKey("Id");

                    b.ToTable("Estado");

                    b.HasData(
                        new { Id = 1, Nome = "Acre", Sigla = 1 },
                        new { Id = 2, Nome = "Alagoas", Sigla = 2 },
                        new { Id = 3, Nome = "Amazonas", Sigla = 4 },
                        new { Id = 4, Nome = "Amapá", Sigla = 3 },
                        new { Id = 5, Nome = "Bahia", Sigla = 5 },
                        new { Id = 6, Nome = "Ceará", Sigla = 6 },
                        new { Id = 7, Nome = "Distrito Federal", Sigla = 7 },
                        new { Id = 8, Nome = "Espírito Santo", Sigla = 8 },
                        new { Id = 9, Nome = "Goiás", Sigla = 9 },
                        new { Id = 10, Nome = "Maranhão", Sigla = 10 },
                        new { Id = 11, Nome = "Minas Gerais", Sigla = 13 },
                        new { Id = 12, Nome = "Mato Grosso do Sul", Sigla = 12 },
                        new { Id = 13, Nome = "Mato Grosso", Sigla = 11 },
                        new { Id = 14, Nome = "Pará", Sigla = 14 },
                        new { Id = 15, Nome = "Paraíba", Sigla = 15 },
                        new { Id = 16, Nome = "Pernambuco", Sigla = 17 },
                        new { Id = 17, Nome = "Piauí", Sigla = 18 },
                        new { Id = 18, Nome = "Paraná", Sigla = 16 },
                        new { Id = 19, Nome = "Rio de Janeiro", Sigla = 21 },
                        new { Id = 20, Nome = "Rio Grande do Norte", Sigla = 22 },
                        new { Id = 21, Nome = "Rondônia", Sigla = 20 },
                        new { Id = 22, Nome = "Roraima", Sigla = 19 },
                        new { Id = 23, Nome = "Rio Grande do Sul", Sigla = 23 },
                        new { Id = 24, Nome = "Santa Catarina", Sigla = 24 },
                        new { Id = 25, Nome = "Sergipe", Sigla = 26 },
                        new { Id = 26, Nome = "São Paulo", Sigla = 25 },
                        new { Id = 27, Nome = "Tocantins", Sigla = 27 }
                    );
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Estrangeiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Chegada");

                    b.Property<string>("DocumentoIdentidade");

                    b.Property<string>("Estado");

                    b.Property<DateTime>("Expedicao");

                    b.Property<int>("IdCarteiraTrabalho");

                    b.Property<string>("Observacao");

                    b.HasKey("Id")
                        .HasName("PK_Estrangeiro");

                    b.HasIndex("IdCarteiraTrabalho")
                        .IsUnique();

                    b.ToTable("Estrangeiro");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Ferias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DataInicio");

                    b.Property<DateTimeOffset>("DataTermino");

                    b.Property<int>("Dias");

                    b.Property<int>("IdContratoTrabalho");

                    b.Property<string>("PeriodoRelativo");

                    b.HasKey("Id")
                        .HasName("PK_Ferias");

                    b.HasIndex("IdContratoTrabalho");

                    b.ToTable("Ferias");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF");

                    b.Property<int?>("IdEmpresa");

                    b.Property<string>("Nome");

                    b.HasKey("Id")
                        .HasName("PK_Funcionario");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Hash", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime>("DataExpiracao");

                    b.Property<DateTime>("DataGeracao");

                    b.Property<string>("HashCode");

                    b.Property<int>("IdCarteiraTrabalho");

                    b.Property<int>("IdEmpresa");

                    b.Property<int>("IdFuncionario");

                    b.HasKey("Id")
                        .HasName("PK_Hash");

                    b.ToTable("Hash");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Historico.EmpresaHistorico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ");

                    b.Property<DateTimeOffset>("Data");

                    b.Property<int>("IdEmpresa");

                    b.Property<int?>("IdFuncionario");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("RazaoSocial");

                    b.HasKey("Id")
                        .HasName("PK_EmpresaHistorico");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("EmpresaHistorico");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Historico.FuncionarioHistorico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF");

                    b.Property<DateTimeOffset>("Data");

                    b.Property<int?>("IdEmpresa");

                    b.Property<int>("IdFuncionario");

                    b.Property<string>("Nome");

                    b.HasKey("Id")
                        .HasName("PK_FuncionarioHistorico");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("FuncionarioHistorico");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Internacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DataAlta");

                    b.Property<DateTimeOffset>("DataInternacao");

                    b.Property<string>("Hospital");

                    b.Property<int>("IdCarteiraTrabalho");

                    b.Property<string>("Matricula");

                    b.Property<string>("Registro");

                    b.HasKey("Id")
                        .HasName("PK_Internacao");

                    b.HasIndex("IdCarteiraTrabalho");

                    b.ToTable("Internacao");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Licenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoPosto");

                    b.Property<DateTimeOffset>("DataInicio");

                    b.Property<DateTimeOffset>("DataTermino");

                    b.Property<int>("Dias");

                    b.Property<int>("IdCarteiraTrabalho");

                    b.Property<string>("Motivo");

                    b.HasKey("Id")
                        .HasName("PK_Licenca");

                    b.HasIndex("IdCarteiraTrabalho");

                    b.ToTable("Licenca");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.LocalNascimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade");

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdEstado");

                    b.HasKey("Id")
                        .HasName("PK_LocalNascimento");

                    b.HasIndex("IdEstado")
                        .IsUnique();

                    b.ToTable("LocalNascimento");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.AlteracaoSalarial", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.ContratoTrabalho", "ContratoTrabalho")
                        .WithMany("AlteracaoSalarial")
                        .HasForeignKey("IdContratoTrabalho")
                        .HasConstraintName("FK_ContratoTrabalho_AlteracaoSalarial")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.AnotacaoGeral", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.ContratoTrabalho", "ContratoTrabalho")
                        .WithMany("AnotacaoGeral")
                        .HasForeignKey("IdContratoTrabalho")
                        .HasConstraintName("FK_ContratoTrabalho_AnotacaoGeral")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.CarteiraTrabalho", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.Funcionario", "funcionario")
                        .WithMany("CarteiraTrabalho")
                        .HasForeignKey("IdFuncionario")
                        .HasConstraintName("FK_Funcionario_CarteiraTrabalho")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CTPSYSTEM.Domain.LocalNascimento", "localNascimento")
                        .WithOne("CarteiraTrabalho")
                        .HasForeignKey("CTPSYSTEM.Domain.CarteiraTrabalho", "IdLocalNascimento")
                        .HasConstraintName("FK_LocalNascimento_CarteiraTrabalho")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.ContratoTrabalho", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.CarteiraTrabalho", "CarteiraTrabalho")
                        .WithMany("ContratoTrabalho")
                        .HasForeignKey("CarteiraTrabalhoId");

                    b.HasOne("CTPSYSTEM.Domain.Empresa", "Empresa")
                        .WithMany("ContratoTrabalho")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.ContribuicaoSindical", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.ContratoTrabalho", "ContratoTrabalho")
                        .WithMany("ContribuicaoSindical")
                        .HasForeignKey("IdContratoTrabalho")
                        .HasConstraintName("FK_ContratoTrabalho_ContribuicaoSindical")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Endereco", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.Empresa")
                        .WithMany("Endereco")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("CTPSYSTEM.Domain.Estado", "Estado")
                        .WithMany("Endereco")
                        .HasForeignKey("IdEstado")
                        .HasConstraintName("FK_Estado_Endereco")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Estrangeiro", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.CarteiraTrabalho", "CarteiraTrabalho")
                        .WithOne("Estrangeiro")
                        .HasForeignKey("CTPSYSTEM.Domain.Estrangeiro", "IdCarteiraTrabalho")
                        .HasConstraintName("FK_CarteiraTrabalho_Estrangeiro")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Ferias", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.ContratoTrabalho", "ContratoTrabalho")
                        .WithMany("Ferias")
                        .HasForeignKey("IdContratoTrabalho")
                        .HasConstraintName("FK_ContratoTrabalho_Ferias")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Funcionario", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.Empresa", "Empresa")
                        .WithMany("Funcionario")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK_Empresa_Funcionario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Historico.EmpresaHistorico", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.Funcionario", "Funcionario")
                        .WithMany("EmpresaHistorico")
                        .HasForeignKey("IdFuncionario")
                        .HasConstraintName("FK_Funcionario_EmpresaHistorico")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Historico.FuncionarioHistorico", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.Empresa", "Empresa")
                        .WithMany("FuncionarioHistorico")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK_Empresa_FuncionarioHistorico")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Internacao", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.CarteiraTrabalho", "CarteiraTrabalho")
                        .WithMany("Internacao")
                        .HasForeignKey("IdCarteiraTrabalho")
                        .HasConstraintName("FK_CarteiraTrabalho_Internacao")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.Licenca", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.CarteiraTrabalho", "CarteiraTrabalho")
                        .WithMany("Licenca")
                        .HasForeignKey("IdCarteiraTrabalho")
                        .HasConstraintName("FK_CarteiraTrabalho_Licenca")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CTPSYSTEM.Domain.LocalNascimento", b =>
                {
                    b.HasOne("CTPSYSTEM.Domain.Estado", "Estado")
                        .WithOne("LocalNascimento")
                        .HasForeignKey("CTPSYSTEM.Domain.LocalNascimento", "IdEstado")
                        .HasConstraintName("FK_Estado_localNascimento")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
