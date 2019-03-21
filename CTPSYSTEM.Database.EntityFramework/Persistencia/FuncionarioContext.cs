using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Historico;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CTPSYSTEM.Database.EntityFramework.Persistence
{
    public class FuncionarioContext : IFuncionarioReadOnlyStorage
    {
        private readonly Conexao conexao;

        public FuncionarioContext(Conexao conexao)
        {
            this.conexao = conexao;
        }

        public Funcionario RecuperaFuncionario(string CPF)
        {
            return this.conexao
                       .Funcionario
                       .Include(funcionario => funcionario.CarteiraTrabalho)
                       .Include(funcionario => funcionario.LocalNascimento)
                        .ThenInclude(localNascimento => localNascimento.Estado)
                .FirstOrDefault(funcionario => funcionario.CPF == CPF);
        }

        public IEnumerable<EmpresaHistorico> RecuperaHistoricoEmpresa(int idFuncionario)
        {
            return conexao.EmpresaHistorico
                          .Where(empresaHistorico => empresaHistorico.IdFuncionario == idFuncionario);
        }

        public IEnumerable<CarteiraTrabalho> RecuperaHistoricoCarteiraTrabalho(int idFuncionario)
        {
            return conexao.CarteiraTrabalho
                          .Include(carteiraTrabalho => carteiraTrabalho.Funcionario)
                          .Where(carteiraTrabalho => carteiraTrabalho.IdFuncionario == idFuncionario && !carteiraTrabalho.Ativo);
        }

        public CarteiraTrabalho RecuperaCarteiraTrabalho(int idFuncionario)
        {
            return conexao.CarteiraTrabalho
                          .Include(carteiraTrabalho => carteiraTrabalho.Funcionario)
                          .FirstOrDefault(carteiraTrabalho => carteiraTrabalho.IdFuncionario == idFuncionario && carteiraTrabalho.Ativo);
        }

        public IEnumerable<Internacao> RecuperaInternacao(int idCarteiraTrabalho)
        {
            return conexao.Internacao
                          .Where(internacao => internacao.IdCarteiraTrabalho == idCarteiraTrabalho);
        }

        public IEnumerable<Licenca> RecuperaLicenca(int idCarteiraTrabalho)
        {
            return conexao.Licenca
                          .Where(licenca => licenca.IdCarteiraTrabalho == idCarteiraTrabalho);
        }

        public IEnumerable<ContratoTrabalho> RecuperaContratoTrabalho(int idCarteiraTrabalho)
        {
            return conexao.ContratoTrabalho
                          .Include(contratoTrabalho => contratoTrabalho.Empresa)
                          .Where(contratoTrabalho => contratoTrabalho.IdCarteiraTrabalho == idCarteiraTrabalho);
        }

        public IEnumerable<AlteracaoSalarial> RecuperaAlteracaoSalarial(int idContratoTrabalho)
        {
            return conexao.AlteracaoSalarial
                          .Where(alteracaoSalarial => alteracaoSalarial.IdContratoTrabalho == idContratoTrabalho);
        }

        public IEnumerable<Ferias> RecuperaFerias(int idContratoTrabalho)
        {
            return conexao.Ferias
                          .Where(ferias => ferias.IdContratoTrabalho == idContratoTrabalho);
        }

        public IEnumerable<AnotacaoGeral> RecuperaAnotacaoGeral(int idContratoTrabalho)
        {
            return conexao.AnotacaoGeral
                          .Where(anotacaoGeral => anotacaoGeral.IdContratoTrabalho == idContratoTrabalho);
        }

        public IEnumerable<ContribuicaoSindical> RecuperaContribuicaoSindical(int idContratoTrabalho)
        {
            return conexao.ContribuicaoSindical
                          .Where(contribuicaoSindical => contribuicaoSindical.IdContratoTrabalho == idContratoTrabalho);
        }

        public IEnumerable<FGTS> RecuperaFGTS(int idContratoTrabalho)
        {
            return conexao.FGTS
                          .Where(fgts => fgts.IdContratoTrabalho == idContratoTrabalho);
        }
    }
}