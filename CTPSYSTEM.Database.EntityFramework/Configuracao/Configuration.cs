using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Historico;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CTPSYSTEM.Database.EntityFramework.Configuration
{
    public class Configuration : IEntityTypeConfiguration<CarteiraTrabalho>
        , IEntityTypeConfiguration<ContratoTrabalho>
        , IEntityTypeConfiguration<Empresa>
        , IEntityTypeConfiguration<Funcionario>
        , IEntityTypeConfiguration<AlteracaoSalarial>
        , IEntityTypeConfiguration<AnotacaoGeral>
        , IEntityTypeConfiguration<ContribuicaoSindical>
        , IEntityTypeConfiguration<Endereco>
        , IEntityTypeConfiguration<Estado>
        , IEntityTypeConfiguration<Estrangeiro>
        , IEntityTypeConfiguration<Ferias>
        , IEntityTypeConfiguration<Internacao>
        , IEntityTypeConfiguration<Licenca>
        , IEntityTypeConfiguration<LocalNascimento>
        , IEntityTypeConfiguration<EmpresaHistorico>
        , IEntityTypeConfiguration<FuncionarioHistorico>
        , IEntityTypeConfiguration<Hash>
    {
        public void Configure(EntityTypeBuilder<CarteiraTrabalho> builder)
        {
            builder.ToTable("CarteiraTrabalho");

            builder.HasKey(carteiraTrabalho => carteiraTrabalho.Id)
                   .HasName("PK_CarteiraTrabalho");

            builder.Property(carteiraTrabalho => carteiraTrabalho.DataEmissao);
            builder.Property(carteiraTrabalho => carteiraTrabalho.FiliacaoMae);
            builder.Property(carteiraTrabalho => carteiraTrabalho.FiliacaoPai);
            builder.Property(carteiraTrabalho => carteiraTrabalho.Foto)
                   .IsRequired(false);
            builder.Property(carteiraTrabalho => carteiraTrabalho.Numero);
            builder.Property(carteiraTrabalho => carteiraTrabalho.Serie);
            builder.Property(carteiraTrabalho => carteiraTrabalho.NumeroDocumento);
            builder.Property(carteiraTrabalho => carteiraTrabalho.Ativo)
                   .HasDefaultValue(1);

            #region Relacionamentos

            builder.HasOne(carteiraTrabalho => carteiraTrabalho.funcionario)
                   .WithMany(funcionario => funcionario.CarteiraTrabalho)
                   .HasForeignKey(carteiraTrabalho => carteiraTrabalho.IdFuncionario)
                   .HasConstraintName("FK_Funcionario_CarteiraTrabalho")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(carteiraTrabalho => carteiraTrabalho.localNascimento)
                   .WithOne(localNascimento => localNascimento.CarteiraTrabalho)
                   .HasForeignKey<CarteiraTrabalho>(carteiraTrabalho => carteiraTrabalho.IdLocalNascimento)
                   .HasConstraintName("FK_LocalNascimento_CarteiraTrabalho")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<ContratoTrabalho> builder)
        {
            builder.ToTable("ContratoTrabalho");

            builder.HasKey(contratoTrabalho => contratoTrabalho.Id)
                   .HasName("PK_ContratoTrabalho");

            builder.Property(contratoTrabalho => contratoTrabalho.Cargo);
            builder.Property(contratoTrabalho => contratoTrabalho.CBONumero);
            builder.Property(contratoTrabalho => contratoTrabalho.DataAdmissao);
            builder.Property(contratoTrabalho => contratoTrabalho.Remuneracao);
            builder.Property(contratoTrabalho => contratoTrabalho.RemuneracaoExtenso);
            builder.Property(contratoTrabalho => contratoTrabalho.DataSaida)
                   .IsRequired(false);
            builder.Property(contratoTrabalho => contratoTrabalho.RegistroNumero)
                   .IsRequired(false)
                   .HasDefaultValue(0);
            builder.Property(contratoTrabalho => contratoTrabalho.FlsFicha)
                   .IsRequired(false)
                   .HasDefaultValue(0);
            builder.Property(contratoTrabalho => contratoTrabalho.Ativo)
                   .HasDefaultValue(1);

            #region Relacionamentos

            builder.HasOne(contratoTrabalho => contratoTrabalho.CarteiraTrabalho)
                   .WithMany(carteiraTrabalho => carteiraTrabalho.ContratoTrabalho)
                   .HasForeignKey(contratoTrabalho => contratoTrabalho.IdCarteiraTrabalho)
                   .HasConstraintName("FK_CarteiraTrabalho_ContratoTrabalho")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(contratoTrabalho => contratoTrabalho.Empresa)
                   .WithMany(empresa => empresa.ContratoTrabalho)
                   .HasForeignKey(contratoTrabalho => contratoTrabalho.IdEmpresa)
                   .HasConstraintName("FK_Empresa_ContratoTrabalho")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(empresa => empresa.Id)
                   .HasName("PK_Empresa");

            builder.Property(empresa => empresa.CNPJ);
            builder.Property(empresa => empresa.NomeFantasia);
            builder.Property(empresa => empresa.RazaoSocial);
            builder.Property(empresa => empresa.Seguimento);
        }

        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(funcionario => funcionario.Id)
                   .HasName("PK_Funcionario");

            builder.Property(funcionario => funcionario.Nome);
            builder.Property(funcionario => funcionario.CPF);

            #region Relacionamentos

            builder.HasOne(funcionario => funcionario.Empresa)
                   .WithMany(empresa => empresa.Funcionario)
                   .HasForeignKey(funcionario => funcionario.IdEmpresa)
                   .HasConstraintName("FK_Empresa_Funcionario")
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<AlteracaoSalarial> builder)
        {
            builder.ToTable("AlteracaoSalarial");

            builder.HasKey(alteracaoSalarial => alteracaoSalarial.Id)
                   .HasName("PK_AlteracaoSalarial");

            builder.Property(alteracaoSalarial => alteracaoSalarial.DataAumento);
            builder.Property(alteracaoSalarial => alteracaoSalarial.Remuneracao);
            builder.Property(alteracaoSalarial => alteracaoSalarial.RemuneracaoExtenso);
            builder.Property(alteracaoSalarial => alteracaoSalarial.Cargo);
            builder.Property(alteracaoSalarial => alteracaoSalarial.Motivo);

            #region Relacionamentos

            builder.HasOne(alteracaoSalarial => alteracaoSalarial.ContratoTrabalho)
                   .WithMany(contratoTrabalho => contratoTrabalho.AlteracaoSalarial)
                   .HasForeignKey(alteracaoSalarial => alteracaoSalarial.IdContratoTrabalho)
                   .HasConstraintName("FK_ContratoTrabalho_AlteracaoSalarial")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<AnotacaoGeral> builder)
        {
            builder.ToTable("AnotacaoGeral");

            builder.HasKey(anotacaoGeral => anotacaoGeral.Id)
                   .HasName("PK_AnotacaoGeral");

            builder.Property(anotacaoGeral => anotacaoGeral.Texto);

            #region Relacionamentos

            builder.HasOne(anotacaoGeral => anotacaoGeral.ContratoTrabalho)
                   .WithMany(contratoTrabalho => contratoTrabalho.AnotacaoGeral)
                   .HasForeignKey(anotacaoGeral => anotacaoGeral.IdContratoTrabalho)
                   .HasConstraintName("FK_ContratoTrabalho_AnotacaoGeral")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<ContribuicaoSindical> builder)
        {
            builder.ToTable("ContribuicaoSindical");

            builder.HasKey(contribuicaoSindical => contribuicaoSindical.Id)
                   .HasName("PK_ContribuicaoSindical");

            builder.Property(contribuicaoSindical => contribuicaoSindical.ValorContribuicao);
            builder.Property(contribuicaoSindical => contribuicaoSindical.NomeSindicato);
            builder.Property(contribuicaoSindical => contribuicaoSindical.Ano);

            #region Relacionamentos

            builder.HasOne(contribuicaoSindical => contribuicaoSindical.ContratoTrabalho)
                   .WithMany(contratoTrabalho => contratoTrabalho.ContribuicaoSindical)
                   .HasForeignKey(contribuicaoSindical => contribuicaoSindical.IdContratoTrabalho)
                   .HasConstraintName("FK_ContratoTrabalho_ContribuicaoSindical")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<Ferias> builder)
        {
            builder.ToTable("Ferias");

            builder.HasKey(ferias => ferias.Id)
                   .HasName("PK_Ferias");

            builder.Property(ferias => ferias.DataInicio);
            builder.Property(ferias => ferias.DataTermino);
            builder.Property(ferias => ferias.Dias);
            builder.Property(ferias => ferias.PeriodoRelativo);

            #region Relacionamentos

            builder.HasOne(ferias => ferias.ContratoTrabalho)
                   .WithMany(contratoTrabalho => contratoTrabalho.Ferias)
                   .HasForeignKey(ferias => ferias.IdContratoTrabalho)
                   .HasConstraintName("FK_ContratoTrabalho_Ferias")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(endereco => endereco.Id)
                   .HasName("PK_Endereco");

            builder.Property(endereco => endereco.Rua);
            builder.Property(endereco => endereco.Cidade);
            builder.Property(endereco => endereco.numero);
            builder.Property(endereco => endereco.Sala);

            #region Relacionamentos

            builder.HasOne(endereco => endereco.Estado)
                   .WithMany(estado => estado.Endereco)
                   .HasForeignKey(endereco => endereco.IdEstado)
                   .HasConstraintName("FK_Estado_Endereco")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado");

            builder.HasKey(estado => estado.Id);

            builder.Property(estado => estado.Nome);
            builder.Property(estado => estado.Sigla)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(2);
        }

        public void Configure(EntityTypeBuilder<Estrangeiro> builder)
        {
            builder.ToTable("Estrangeiro");

            builder.HasKey(estrangeiro => estrangeiro.Id)
                   .HasName("PK_Estrangeiro");

            builder.Property(estrangeiro => estrangeiro.Chegada);
            builder.Property(estrangeiro => estrangeiro.DocumentoIdentidade);
            builder.Property(estrangeiro => estrangeiro.Expedicao);
            builder.Property(estrangeiro => estrangeiro.Observacao);

            #region Relacionamentos

            builder.HasOne(estrangeiro => estrangeiro.CarteiraTrabalho)
                   .WithOne(carteiraTrabalho => carteiraTrabalho.Estrangeiro)
                   .HasForeignKey<Estrangeiro>(estrangeiro => estrangeiro.IdCarteiraTrabalho)
                   .HasConstraintName("FK_CarteiraTrabalho_Estrangeiro")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<Internacao> builder)
        {
            builder.ToTable("Internacao");

            builder.HasKey(internacao => internacao.Id)
                   .HasName("PK_Internacao");

            builder.Property(internacao => internacao.Hospital);
            builder.Property(internacao => internacao.DataInternacao);
            builder.Property(internacao => internacao.DataAlta);
            builder.Property(internacao => internacao.Registro);
            builder.Property(internacao => internacao.Matricula);

            #region Relacionamentos

            builder.HasOne(internacao => internacao.CarteiraTrabalho)
                   .WithMany(carteiraTrabalho => carteiraTrabalho.Internacao)
                   .HasForeignKey(internacao => internacao.IdCarteiraTrabalho)
                   .HasConstraintName("FK_CarteiraTrabalho_Internacao")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<Licenca> builder)
        {
            builder.ToTable("Licenca");

            builder.HasKey(licenca => licenca.Id)
                   .HasName("PK_Licenca");

            builder.Property(licenca => licenca.Dias);
            builder.Property(licenca => licenca.DataInicio);
            builder.Property(licenca => licenca.CodigoPosto);
            builder.Property(licenca => licenca.Motivo)
                   .IsRequired(false);

            #region Relacionamentos

            builder.HasOne(licenca => licenca.CarteiraTrabalho)
                   .WithMany(carteiraTrabalho => carteiraTrabalho.Licenca)
                   .HasForeignKey(licenca => licenca.IdCarteiraTrabalho)
                   .HasConstraintName("FK_CarteiraTrabalho_Licenca")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<LocalNascimento> builder)
        {
            builder.ToTable("LocalNascimento");

            builder.HasKey(localNascimento => localNascimento.Id)
                   .HasName("PK_LocalNascimento");

            builder.Property(localNascimento => localNascimento.Cidade);
            builder.Property(localNascimento => localNascimento.Data);

            #region Relacionamentos

            builder.HasOne(localNascimento => localNascimento.Estado)
                   .WithOne(Estado => Estado.LocalNascimento)
                   .HasForeignKey<LocalNascimento>(localNascimento => localNascimento.IdEstado)
                   .HasConstraintName("FK_Estado_localNascimento")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<EmpresaHistorico> builder)
        {
            builder.ToTable("EmpresaHistorico");

            builder.HasKey(empresaHistorico => empresaHistorico.Id)
                   .HasName("PK_EmpresaHistorico");

            builder.Property(empresaHistorico => empresaHistorico.IdEmpresa);
            builder.Property(empresaHistorico => empresaHistorico.CNPJ);
            builder.Property(empresaHistorico => empresaHistorico.NomeFantasia);
            builder.Property(empresaHistorico => empresaHistorico.RazaoSocial);
            builder.Property(empresaHistorico => empresaHistorico.Data);

            #region Relacionamentos

            builder.HasOne(empresaHistorico => empresaHistorico.Funcionario)
                   .WithMany(funcionario => funcionario.EmpresaHistorico)
                   .HasForeignKey(empresaHistorico => empresaHistorico.IdFuncionario)
                   .HasConstraintName("FK_Funcionario_EmpresaHistorico")
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<FuncionarioHistorico> builder)
        {
            builder.ToTable("FuncionarioHistorico");

            builder.HasKey(funcionarioHistorico => funcionarioHistorico.Id)
                   .HasName("PK_FuncionarioHistorico");

            builder.Property(funcionarioHistorico => funcionarioHistorico.IdFuncionario);
            builder.Property(funcionarioHistorico => funcionarioHistorico.Nome);
            builder.Property(funcionarioHistorico => funcionarioHistorico.CPF);
            builder.Property(funcionarioHistorico => funcionarioHistorico.Data);

            #region Relacionamentos

            builder.HasOne(funcionarioHistorico => funcionarioHistorico.Empresa)
                   .WithMany(empresa => empresa.FuncionarioHistorico)
                   .HasForeignKey(funcionarioHistorico => funcionarioHistorico.IdEmpresa)
                   .HasConstraintName("FK_Empresa_FuncionarioHistorico")
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion Relacionamentos
        }

        public void Configure(EntityTypeBuilder<Hash> builder)
        {
            builder.ToTable("Hash");

            builder.HasKey(hash => hash.Id)
                   .HasName("PK_Hash");

            builder.Property(hash => hash.HashCode);
            builder.Property(hash => hash.IdFuncionario);
            builder.Property(hash => hash.IdCarteiraTrabalho);
            builder.Property(hash => hash.DataGeracao);
            builder.Property(hash => hash.DataExpiracao);
            builder.Property(hash => hash.Ativo)
                   .HasDefaultValue(1);
        }
    }
}