using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

using CTPSYSTEM.Domain.AppSettings;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Historico;
using Microsoft.Extensions.Configuration;

namespace CTPSYSTEM.Database.EntityFramework.DataSource
{
    public class Conexao : DbContext
    {
        private readonly string sqlServerConnection;

        public Conexao(IConfiguration configuration)
        {
            this.sqlServerConnection = configuration.GetConnectionString("SqlServerConnection");
        }

        public DbSet<AlteracaoSalarial> AlteracaoSalarial { get; private set; }
        public DbSet<AnotacaoGeral> AnotacaoGeral { get; private set; }
        public DbSet<CarteiraTrabalho> CarteiraTrabalho { get; private set; }
        public DbSet<ContribuicaoSindical> ContribuicaoSindical { get; private set; }
        public DbSet<Empresa> Empresa { get; private set; }
        public DbSet<Endereco> Endereco { get; private set; }
        public DbSet<Estado> Estado { get; private set; }
        public DbSet<Estrangeiro> Estrangeiro { get; private set; }
        public DbSet<Ferias> Ferias { get; private set; }
        public DbSet<Funcionario> Funcionario { get; private set; }
        public DbSet<Internacao> Internacao { get; private set; }
        public DbSet<Licenca> Licenca { get; private set; }
        public DbSet<LocalNascimento> LocalNascimento { get; private set; }

        public DbSet<EmpresaHistorico> EmpresaHistorico { get; private set; }
        public DbSet<FuncionarioHistorico> FuncionarioHistorico { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
            optionsBuilder.UseSqlServer(this.sqlServerConnection);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configuration = new Configuration.Configuration();
            modelBuilder.ApplyConfiguration<AlteracaoSalarial>(configuration);
            modelBuilder.ApplyConfiguration<AnotacaoGeral>(configuration);
            modelBuilder.ApplyConfiguration<CarteiraTrabalho>(configuration);
            modelBuilder.ApplyConfiguration<ContribuicaoSindical>(configuration);
            modelBuilder.ApplyConfiguration<Empresa>(configuration);
            modelBuilder.ApplyConfiguration<Endereco>(configuration);
            modelBuilder.ApplyConfiguration<Estado>(configuration);
            modelBuilder.ApplyConfiguration<Estrangeiro>(configuration);
            modelBuilder.ApplyConfiguration<Ferias>(configuration);
            modelBuilder.ApplyConfiguration<Funcionario>(configuration);
            modelBuilder.ApplyConfiguration<Internacao>(configuration);
            modelBuilder.ApplyConfiguration<Licenca>(configuration);
            modelBuilder.ApplyConfiguration<LocalNascimento>(configuration);

            modelBuilder.ApplyConfiguration<EmpresaHistorico>(configuration);
            modelBuilder.ApplyConfiguration<FuncionarioHistorico>(configuration);

            base.OnModelCreating(modelBuilder);
        }
    }
}
