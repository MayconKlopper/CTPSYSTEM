namespace CTPSYSTEM.Domain.Dados
{
    public interface IHashStorage : IBaseStorage<Hash>
    {
        Hash RecuperaHash(string hashCode);

        void DesativarHash(string hashCode);

        void DesativarHash(int idHash);
    }
}