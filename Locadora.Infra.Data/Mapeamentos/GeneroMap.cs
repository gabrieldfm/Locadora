using Locadora.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.Data.Mapeamentos
{
    public class GeneroMap
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Genero");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).IsRequired().HasColumnName("Id");
            builder.Property(f => f.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
            builder.Property(f => f.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(f => f.Ativo).IsRequired().HasColumnName("Ativo");
        }
    }
}
