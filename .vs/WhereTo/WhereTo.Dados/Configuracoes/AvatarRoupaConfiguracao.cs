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
    public class AvatarRoupaConfiguracao : IEntityTypeConfiguration<AvatarRoupa>
    {
        public void Configure(EntityTypeBuilder<AvatarRoupa> builder)
        {
            builder.ToTable("AvatarRoupa");
            builder.HasKey("AvatarID");
            builder.HasKey("RoupaID");
            builder.Property(f => f.AvatarID).HasColumnName("AvatarID");
            builder.Property(f => f.RoupaID).HasColumnName("RoupaID");

            builder
                .HasMany("Avatar")
                .WithOne("AvatarID");
            builder
                .HasMany("RoupaAvatar")
                .WithOne("RoupaID");
        }
    }
}
