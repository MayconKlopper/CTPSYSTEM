using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CTPSYSTEM.Database.EntityFramework.Persistencia
{
    public class FuncionarioGovernoContext : BaseContext<CarteiraTrabalho>, IFuncionarioGovernoReadOnlyStorage, IFuncionarioGovernoStorage
    {
        public FuncionarioGovernoContext(Conexao conexao) : base(conexao)
        {
        }

        public void Insert(Funcionario funcionario)
        {
            conexao.Funcionario.Add(funcionario);
        }

        public void Insert(Empresa empresa)
        {
            conexao.Empresa.Add(empresa);
        }

        public new void Update<T>(T item, params Expression<Func<T, object>>[] expressions) where T : class
        {
            var x = this.conexao.Attach(item);
            foreach (var expression in expressions)
            {
                x.Property(expression).IsModified = true;
            }
        }

        public IEnumerable<Empresa> RecuperaEmpresa()
        {
            return conexao.Empresa
                          .Include(empresa => empresa.Endereco)
                          .ThenInclude(endereco => endereco.Estado);
        }

        public IEnumerable<Funcionario> RecuperaFuncionario()
        {
            return conexao.Funcionario;
        }
    }
}