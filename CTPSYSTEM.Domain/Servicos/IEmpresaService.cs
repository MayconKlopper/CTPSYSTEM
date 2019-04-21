namespace CTPSYSTEM.Domain.Servicos
{
    public interface IEmpresaService
    {
        void Cadastrar(ContratoTrabalho contratoTrabalho);

        void Cadastrar(AlteracaoSalarial alteracaoSalarial);

        void Cadastrar(ContribuicaoSindical contribuicaoSindical);

        void Cadastrar(AnotacaoGeral anotacaoGeral);

        void Cadastrar(FGTS fgts);

        void Cadastrar(Ferias ferias);

        void Cadastrar(Licenca licenca);

        void Cadastrar(Internacao internacao);

        void VincularFuncionario(Funcionario funcionario, int idEmpresa);

        void DesvincularFuncionario(int idFuncionario, int idContratoTrabalho);
    }
}