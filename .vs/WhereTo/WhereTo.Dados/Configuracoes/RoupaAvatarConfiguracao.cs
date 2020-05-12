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
    public class RoupaAvatarConfiguracao : IEntityTypeConfiguration<RoupaAvatar>
    {
        public void Configure(EntityTypeBuilder<RoupaAvatar> builder)
        {
            builder.ToTable("RoupaAvatar");
            builder.HasKey("RoupaID");
            builder.Property(f => f.RoupaID).HasColumnName("RoupaID");
            builder.Property(f => f.Cor).HasColumnName("Cor");
            builder.Property(f => f.Local).HasColumnName("Local");
        }
    }
}
