using Mariner.Data.Context;
using Mariner.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mariner.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>  where TEntity : class
    {
        protected readonly DataContext context;

        protected BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public void Inserir(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Excluir(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<TEntity> ObterTodos()
        {
            return context.Set<TEntity>().ToList();
        }

        public virtual List<TEntity> FindAll(Func<TEntity, bool> expression)
        {
            return context.Set<TEntity>().Where(expression).ToList();
        }

        public TEntity ObterPorId(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

       
    }
}
