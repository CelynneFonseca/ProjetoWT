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
    public class AvatarConfiguracao : IEntityTypeConfiguration<Avatar>
    {
        public void Configure(EntityTypeBuilder<Avatar> builder)
        {
            builder.ToTable("Avatar");
            builder.HasKey("AvatarID");
            builder.Property(f => f.AvatarID).HasColumnName("AvatarID");
            builder.Property(f => f.NomeAvatar).HasColumnName("NomeAvatar");
            builder.Property(f => f.Sexo).HasColumnName("Sexo");
            builder.Property(f => f.UsuarioID).HasColumnName("UsuarioID");

            builder
                .HasMany("Usuario")
                .WithOne("UsuarioID");
        }
    }
}
