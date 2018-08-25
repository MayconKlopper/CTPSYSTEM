namespace CTPSYSTEM.Domain.Servicos
{
    public interface IFuncionarioGovernoService
    {
        void Cadastrar(Empresa empresa);

        void Cadastrar(Funcionario funcionario);

        void Cadastrar(CarteiraTrabalho carteiraTrabalho);
    }
}