using CTPSYSTEM.Domain.Historico;
using System.Collections.Generic;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IFuncionarioReadOnlyStorage
    {
        Funcionario RecuperaFuncionario(string CPF);

        CarteiraTrabalho RecuperaCarteiraTrabalho(int idFuncionario);

        IEnumerable<Internacao> RecuperaInternacao(int idCarteiraTrabalho);

        IEnumerable<Licenca> RecuperaLicenca(int idCarteiraTrabalho);

        IEnumerable<ContratoTrabalho> RecuperaContratoTrabalho(int idCarteiraTrabalho);

        IEnumerable<AlteracaoSalarial> RecuperaAlteracaoSalarial(int idContratoTrabalho);

        IEnumerable<FGTS> RecuperaFGTS(int idContratoTrabalho);

        IEnumerable<Ferias> RecuperaFerias(int idContratoTrabalho);

        IEnumerable<AnotacaoGeral> RecuperaAnotacaoGeral(int idContratoTrabalho);

        IEnumerable<ContribuicaoSindical> RecuperaContribuicaoSindical(int idContratoTrabalho);

        IEnumerable<EmpresaHistorico> RecuperaHistoricoEmpresa(int idFuncionario);

        IEnumerable<CarteiraTrabalho> RecuperaHistoricoCarteiraTrabalho(int idFuncionario);
    }
}