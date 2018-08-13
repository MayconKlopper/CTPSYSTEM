using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain.Dados;

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace CTPSYSTEM.Database.EntityFramework.Persistence
{
    public class BaseContext<Entity> : IBaseStorage<Entity>
        where Entity : class
    {
        protected readonly Conexao conexao;

        public BaseContext(Conexao conexao)
        {
            this.conexao = conexao;
        }

        public void Insert(Entity obj)
        {
            conexao.Add(obj);
        }

        public void Update(Entity item, params Expression<Func<Entity, object>>[] expressions)
        {
            var x = this.conexao.Attach(item);
            foreach (var expression in expressions)
            {
                x.Property(expression).IsModified = true;
            }
        }

        public int SaveChanges()
        {
            return conexao.SaveChanges();
        }
    }
}
