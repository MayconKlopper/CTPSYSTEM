using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using System.Linq;

namespace CTPSYSTEM.Database.EntityFramework.Persistencia
{
    public class HashContext : BaseContext<Hash>, IHashStorage
    {
        public HashContext(Conexao conexao) : base(conexao)
        {
        }

        public void DesativarHash(string hashCode)
        {
            var hash = conexao.Hash.FirstOrDefault(h => h.HashCode == hashCode);
            hash.Ativo = false;
            base.Update(hash, h => h.Ativo);
        }

        public void DesativarHash(int idHash)
        {
            var hash = conexao.Hash.FirstOrDefault(h => h.Id == idHash);
            hash.Ativo = false;
            base.Update(hash, h => h.Ativo);
        }

        public Hash RecuperaHash(string hashCode)
        {
            return conexao.Hash.FirstOrDefault(h => h.HashCode == hashCode);
        }
    }
}