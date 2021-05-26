using Locadora.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locadora.Infra.Data.Mapeamentos
{
    public class FilmeMap
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filme");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).IsRequired().HasColumnName("Id");
            builder.Property(f => f.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(200);
            builder.Property(f => f.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(f => f.Ativo).IsRequired().HasColumnName("Ativo");
        }
    }
}
