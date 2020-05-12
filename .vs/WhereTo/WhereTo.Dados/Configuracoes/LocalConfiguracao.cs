using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Configuracoes
{
    public class LocalConfiguracao : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.ToTable("Local");
            builder.HasKey("LocalID");
            builder.Property(f => f.LocalID).HasColumnName("LocalID");
            builder.Property(f => f.PartesDeCima).HasColumnName("PartesDeCima");
            builder.Property(f => f.PartesDeBaixo).HasColumnName("PartesDeBaixo");
            builder.Property(f => f.Acessorios).HasColumnName("Acessorios");
            builder.Property(f => f.RoupaID).HasColumnName("RoupaID");

            builder
                .HasMany("RoupaAvatar")
                .WithOne("RoupaID");
        }
    }
}
