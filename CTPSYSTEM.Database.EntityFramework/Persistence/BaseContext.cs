using CTPSYSTEM.Database.EntityFramework.DataSource;
using CTPSYSTEM.Domain.Data;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Database.EntityFramework.Persistence
{
    class BaseContext<Entity> : IBaseStorage<Entity>
        where Entity : class
    {
        private readonly Conexao conexao;

        public BaseContext(Conexao conexao)
        {
            this.conexao = conexao;
        }

        public void Insert(Entity obj)
        {
            conexao.Add(obj);
        }

        public int SaveChanges()
        {
            return conexao.SaveChanges();
        }
    }
}
