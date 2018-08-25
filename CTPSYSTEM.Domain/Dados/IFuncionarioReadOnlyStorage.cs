using CTPSYSTEM.Domain.Historico;
using System.Collections.Generic;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IFuncionarioReadOnlyStorage
    {
        Funcionario RecuperaFuncionario(string CPF);

        IEnumerable<CarteiraTrabalho> RecuperaCarteiraTrabalho(int idFuncionario);

        IEnumerable<Internacao> RecuperaInternacao(int idCarteiraTrabalho);

        IEnumerable<Licenca> RecuperaLicensa(int idCarteiraTrabalho);

        IEnumerable<ContratoTrabalho> RecuperaContratoTrabalho(int idCarteiraTrabalho);

        IEnumerable<AlteracaoSalarial> AlteracaoSalarial(int idContratoTrabalho);

        IEnumerable<Ferias> RecuperaFerias(int idContratoTrabalho);

        IEnumerable<AnotacaoGeral> RecuperaAnotacaoGeral(int idContratoTrabalho);

        IEnumerable<ContribuicaoSindical> RecuperaContribuicaoSindical(int idContratoTrabalho);

        IEnumerable<EmpresaHistorico> RecuperaHistoricoEmpresa(int idFuncionario);
    }
}