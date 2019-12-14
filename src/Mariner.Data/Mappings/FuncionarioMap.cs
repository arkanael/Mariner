using Mariner.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mariner.Data.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
              .HasColumnName("Nome")
              .HasColumnType("varchar(75)")
              .IsRequired();

            builder.Property(x => x.Salario)
              .HasColumnName("Salario")
              .HasColumnType("money")
              .IsRequired();

            builder.Property(x => x.DataAdimissao)
              .HasColumnName("DataAdimissao")
              .HasColumnType("Date")
              .IsRequired();

        }
    }
}
