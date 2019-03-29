using CTPSYSTEM.Application.ArquivosRecurso;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Servicos;

using System;
using System.Security.Cryptography;
using System.Text;

namespace CTPSYSTEM.Application
{
    public class HashService : IHashService
    {
        private readonly IHashStorage hashStorage;

        public HashService(IHashStorage hashStorage)
        {
            this.hashStorage = hashStorage;
        }

        public string GerarHash(int idFuncionario, int idCarteiraTrabalho)
        {
            string hashString = Guid.NewGuid().ToString();

            var data = Encoding.UTF8.GetBytes(hashString);

            string hashCode;
            using (SHA512 shaM = new SHA512Managed())
            {
                var byteHash = shaM.ComputeHash(data);
                hashCode = this.GetStringFromHash(byteHash);
            }

            DateTime dataGerecao = DateTime.Now;

            Hash hash = new Hash(hashCode, idFuncionario, idCarteiraTrabalho, dataGerecao, dataGerecao.AddDays(1));

            this.hashStorage.Insert(hash);
            this.hashStorage.SaveChanges();

            return hashCode;
        }

        public void verificaValidadeHash(string hashCode, int idFuncionario, int idCarteiraTrabalho)
        {
            Hash hash = this.hashStorage.RecuperaHash(hashCode);

            if (hash == null)
            {
                throw new Exception(Mensagens.HashInexistente);
            }
            else if (!hash.Ativo)
            {
                throw new Exception(Mensagens.HashInativo);
            }
            else if (hash.IdFuncionario != idFuncionario || hash.IdCarteiraTrabalho != idCarteiraTrabalho)
            {
                throw new Exception(Mensagens.HashInválido);
            }
            else if (DateTime.Compare(hash.DataExpiracao, DateTime.Now) < 0)
            {
                hash.Ativo = false;
                this.hashStorage.Update(hash, h => h.Ativo);
                this.hashStorage.SaveChanges();

                throw new Exception(Mensagens.HashExpirado);
            }
        }

        private string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}