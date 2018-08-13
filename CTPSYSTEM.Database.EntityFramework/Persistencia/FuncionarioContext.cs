using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;

using System;
using System.Collections.Generic;
using System.Linq;
using CTPSYSTEM.Domain.Historico;
using Microsoft.EntityFrameworkCore;

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
                       .Include(funcionario => funcionario.Empresa)
                       .ThenInclude(empresa => empresa.Endereco)
                       .ThenInclude(endereco => endereco.Estado)
                .FirstOrDefault(funcionario => funcionario.CPF == CPF);
        }

        public IEnumerable<EmpresaHistorico> RecuperaHistoricoEmpresa(int idFuncionario)
        {
            return conexao.EmpresaHistorico
                          .Where(empresaHistorico => empresaHistorico.IdFuncionario == idFuncionario);
        }

        public IEnumerable<CarteiraTrabalho> RecuperaCarteiraTrabalho(int idFuncionario)
        {
            return conexao.CarteiraTrabalho
                          .Include(carteiraTrabalho => carteiraTrabalho.localNascimento)
                          .Where(carteiraTrabalho => carteiraTrabalho.IdFuncionario == idFuncionario);
        }

        public IEnumerable<Internacao> RecuperaInternacao(int idCarteiraTrabalho)
        {
            return conexao.Internacao
                          .Where(internacao => internacao.IdCarteiraTrabalho == idCarteiraTrabalho);
        }

        public IEnumerable<Licenca> RecuperaLicensa(int idCarteiraTrabalho)
        {
            return conexao.Licenca
                          .Where(licenca => licenca.IdCarteiraTrabalho == idCarteiraTrabalho);
        }

        public IEnumerable<ContratoTrabalho> RecuperaContratoTrabalho(int idCarteiraTrabalho)
        {
            return conexao.ContratoTrabalho
                          .Where(contratoTrabalho => contratoTrabalho.IdCarteiraTrabalho == idCarteiraTrabalho);
        }

        public IEnumerable<AlteracaoSalarial> AlteracaoSalarial(int idContratoTrabalho)
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
    }
}
