using Mariner.Data.Entities;
using Mariner.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Mariner.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> builder) : base(builder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
