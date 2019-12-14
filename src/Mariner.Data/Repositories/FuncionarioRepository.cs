using Mariner.Data.Context;
using Mariner.Data.Contracts;
using Mariner.Data.Entities;
using System;
using System.Linq.Expressions;

namespace Mariner.Data.Repositories
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        //private readonly DataContext context;

        public FuncionarioRepository(DataContext context) : base(context)
        {
           
        }

        public Expression<Func<Funcionario, bool>> FindByNome(string nome)
        {
            return x => x.Nome == nome;
        }
    }
}
