namespace CTPSYSTEM.Domain.Servicos
{
    public interface IHashService
    {
        string GerarHash(int idFuncionario, int idCarteiraTrabalho);

        ( int, string ) verificaValidadeHash(string hashCode, int idFuncionario, int idCarteiraTrabalho);
    }
}