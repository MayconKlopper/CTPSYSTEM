using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Enumeradores;
using CTPSYSTEM.Domain.Historico;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CTPSYSTEM.Database.EntityFramework.FonteDados
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
        public DbSet<ContratoTrabalho> ContratoTrabalho { get; private set; }
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
        public DbSet<Hash> Hash { get; private set; }

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
            modelBuilder.ApplyConfiguration<Estrangeiro>(configuration);
            modelBuilder.ApplyConfiguration<Ferias>(configuration);
            modelBuilder.ApplyConfiguration<Funcionario>(configuration);
            modelBuilder.ApplyConfiguration<Internacao>(configuration);
            modelBuilder.ApplyConfiguration<Licenca>(configuration);
            modelBuilder.ApplyConfiguration<LocalNascimento>(configuration);
            modelBuilder.ApplyConfiguration<Hash>(configuration);

            modelBuilder.ApplyConfiguration<EmpresaHistorico>(configuration);
            modelBuilder.ApplyConfiguration<FuncionarioHistorico>(configuration);

            modelBuilder.Entity<Estado>().HasData(
                    new Estado() { Id = 1, Sigla = EstadoSigla.AC, Nome = EstadoNome.Acre },
                    new Estado() { Id = 2, Sigla = EstadoSigla.AL, Nome = EstadoNome.Alagoas },
                    new Estado() { Id = 3, Sigla = EstadoSigla.AM, Nome = EstadoNome.Amazonas },
                    new Estado() { Id = 4, Sigla = EstadoSigla.AP, Nome = EstadoNome.Amapa },
                    new Estado() { Id = 5, Sigla = EstadoSigla.BA, Nome = EstadoNome.Bahia },
                    new Estado() { Id = 6, Sigla = EstadoSigla.CE, Nome = EstadoNome.Ceara },
                    new Estado() { Id = 7, Sigla = EstadoSigla.DF, Nome = EstadoNome.DistritoFederal },
                    new Estado() { Id = 8, Sigla = EstadoSigla.ES, Nome = EstadoNome.EspiritoSanto },
                    new Estado() { Id = 9, Sigla = EstadoSigla.GO, Nome = EstadoNome.Goiás },
                    new Estado() { Id = 10, Sigla = EstadoSigla.MA, Nome = EstadoNome.Maranhão },
                    new Estado() { Id = 11, Sigla = EstadoSigla.MG, Nome = EstadoNome.MinasGerais },
                    new Estado() { Id = 12, Sigla = EstadoSigla.MS, Nome = EstadoNome.MatoGrossoSul },
                    new Estado() { Id = 13, Sigla = EstadoSigla.MT, Nome = EstadoNome.MatoGrosso },
                    new Estado() { Id = 14, Sigla = EstadoSigla.PA, Nome = EstadoNome.Para },
                    new Estado() { Id = 15, Sigla = EstadoSigla.PB, Nome = EstadoNome.Paraiba },
                    new Estado() { Id = 16, Sigla = EstadoSigla.PE, Nome = EstadoNome.Pernambuco },
                    new Estado() { Id = 17, Sigla = EstadoSigla.PI, Nome = EstadoNome.Piaui },
                    new Estado() { Id = 18, Sigla = EstadoSigla.PR, Nome = EstadoNome.Parana },
                    new Estado() { Id = 19, Sigla = EstadoSigla.RJ, Nome = EstadoNome.RioJaneiro },
                    new Estado() { Id = 20, Sigla = EstadoSigla.RN, Nome = EstadoNome.RioGrandeNorte },
                    new Estado() { Id = 21, Sigla = EstadoSigla.RO, Nome = EstadoNome.Rondonia },
                    new Estado() { Id = 22, Sigla = EstadoSigla.RR, Nome = EstadoNome.Roraima },
                    new Estado() { Id = 23, Sigla = EstadoSigla.RS, Nome = EstadoNome.RioGrandeSul },
                    new Estado() { Id = 24, Sigla = EstadoSigla.SC, Nome = EstadoNome.SantaCatarina },
                    new Estado() { Id = 25, Sigla = EstadoSigla.SE, Nome = EstadoNome.Sergipe },
                    new Estado() { Id = 26, Sigla = EstadoSigla.SP, Nome = EstadoNome.SaoPaulo },
                    new Estado() { Id = 27, Sigla = EstadoSigla.TO, Nome = EstadoNome.Tocantins }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}