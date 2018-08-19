using CTPSYSTEM.Application.ArquivosRecurso;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Servicos;

using System;
using System.Collections.Generic;
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

        public void GerarHash(int idFuncionario, int idCarteiraTrabalho)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(idFuncionario.ToString());
            stringBuilder.Append(idCarteiraTrabalho.ToString());
            stringBuilder.Append(Guid.NewGuid().ToString());
            stringBuilder.Append(DateTime.Now.Millisecond.ToString());

            var data = Encoding.UTF8.GetBytes(stringBuilder.ToString());

            string hashCode;
            using (SHA512 shaM = new SHA512Managed())
            {
                var byteHash = shaM.ComputeHash(data);
                hashCode = byteHash.ToString();
            }

            DateTime dataGerecao = DateTime.Now;

            Hash hash = new Hash(hashCode, idFuncionario, idCarteiraTrabalho, dataGerecao, dataGerecao.AddDays(1));

            this.hashStorage.Insert(hash);
        }

        public string verificaVlidadeHash(string hashCode, int idFuncionario, int idCarteiraTrabalho)
        {
            Hash hash = this.hashStorage.RecuperaHash(hashCode);

            string mensagem;

            if(hash == null)
            {
                return Mensagens.HashInexistente;
            }
            else if (hash.IdFuncionario != idFuncionario || hash.IdCarteiraTrabalho != idCarteiraTrabalho)
            {
                return Mensagens.HashInválido;
            }
            else if (DateTime.Compare(hash.DataExpiracao, DateTime.Now) < 0)
            {
                mensagem = Mensagens.HashExpirado;
            }
            else
            {
                mensagem = Mensagens.HashVálido;
            }

            hash.Ativo = false;
            this.hashStorage.Update(hash, h => h.Ativo);
            this.hashStorage.SaveChanges();

            return mensagem;
        }
    }
}
