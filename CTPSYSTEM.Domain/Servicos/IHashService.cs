namespace CTPSYSTEM.Domain.Servicos
{
    public interface IHashService
    {
        string GerarHash(int idFuncionario, int idCarteiraTrabalho);

        void verificaValidadeHash(string hashCode, int idFuncionario, int idCarteiraTrabalho);
    }
}