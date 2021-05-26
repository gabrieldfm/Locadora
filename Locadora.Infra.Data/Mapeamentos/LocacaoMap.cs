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
    public class LocacaoMap
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.ToTable("Locacao");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).IsRequired().HasColumnName("Id");
            builder.Property(f => f.CpfCliente).IsRequired().HasColumnName("CpfCliente").HasMaxLength(14);
            builder.Property(f => f.DataLocacao).IsRequired().HasColumnName("DataLocacao");
        }
    }
}
