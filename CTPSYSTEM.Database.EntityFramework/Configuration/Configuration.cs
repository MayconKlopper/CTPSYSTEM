using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Historico;

using Microsoft.EntityFrameworkCore;
using System;
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

            #region Relacionamentos

            builder.HasOne(carteiraTrabalho => carteiraTrabalho.funcionario)
                   .WithMany(funcionario => funcionario.CarteiraTrabalho)
                   .HasForeignKey(carteiraTrabalho => carteiraTrabalho.IdFuncionario)
                   .HasConstraintName("FK_Funcionario_Id")
                   .IsRequired(true)
                   .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(carteiraTrabalho => carteiraTrabalho.Estrangeiro)
            //       .WithOne(estrangeiro => estrangeiro.CarteiraTrabalho)
            //       .HasForeignKey<Estrangeiro>(estrangeiro => estrangeiro.IdCarteiraTrabalho)
            //       .IsRequired(false);

            builder.HasOne(carteiraTrabalho => carteiraTrabalho.localNascimento)
                   .WithOne(localNascimento => localNascimento.CarteiraTrabalho)
                   .HasForeignKey<CarteiraTrabalho>(carteiraTrabalho => carteiraTrabalho.IdLocalNascimento)
                   .HasConstraintName("FK_LocalNascimento_Id")
                   .IsRequired(true)
                   .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany(carteiraTrabalho => carteiraTrabalho.Internacao)
            //       .WithOne(internacao => internacao.CarteiraTrabalho)
            //       .HasForeignKey(internacao => internacao.IdCarteiraTrabalho)
            //       .IsRequired(false)
            //       .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(carteiraTrabalho => carteiraTrabalho.Licenca)
            //       .WithOne(licenca => licenca.CarteiraTrabalho)
            //       .HasForeignKey(licenca => licenca.IdCarteiraTrabalho)
            //       .IsRequired(false)
            //       .OnDelete(DeleteBehavior.Restrict);

            #endregion
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

            #region Relacionamentos

            builder.HasOne(contratoTrabalho => contratoTrabalho.CarteiraTrabalho)
                   .WithMany(carteiraTrabalho => carteiraTrabalho.ContratoTrabalho)
                   .HasForeignKey(contratoTrabalho => contratoTrabalho.IdCarteiraTrabalho)
                   .HasConstraintName("PK_CarteiraTrabalho_Id")
                   .IsRequired(true)
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion
        }

        public void Configure(EntityTypeBuilder<Empresa> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<AlteracaoSalarial> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<AnotacaoGeral> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<ContribuicaoSindical> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<Estado> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<Estrangeiro> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<Ferias> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<Internacao> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<Licenca> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<LocalNascimento> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<EmpresaHistorico> builder)
        {


            #region Relacionamentos



            #endregion
        }

        public void Configure(EntityTypeBuilder<FuncionarioHistorico> builder)
        {


            #region Relacionamentos



            #endregion
        }
    }
}
