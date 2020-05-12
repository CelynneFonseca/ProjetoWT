using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Configuracoes
{
    public class CodigoConfiguracao : IEntityTypeConfiguration<Codigo>
    {
        public void Configure(EntityTypeBuilder<Codigo> builder)
        {
            builder.ToTable("Codigo");
            builder.HasKey("CodigoID");
            builder.Property(f => f.CodigoID).HasColumnName("CodigoID");
            builder.Property(f => f.CodigoQR).HasColumnName("CodigoQR");
        }
    }
}
