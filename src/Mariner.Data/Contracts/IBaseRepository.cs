using System;
using System.Collections.Generic;

namespace Mariner.Data.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Excluir(TEntity entity);

        List<TEntity> ObterTodos();
        List<TEntity> FindAll(Func<TEntity, bool> func);

        TEntity ObterPorId(int id);
    }
}
