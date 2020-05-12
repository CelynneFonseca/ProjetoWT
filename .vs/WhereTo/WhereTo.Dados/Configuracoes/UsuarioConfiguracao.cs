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
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    { 
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey("UsuarioID");
            builder.Property(f => f.UsuarioID).HasColumnName("UsuarioID");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Email).HasColumnName("Email");
            builder.Property(f => f.DataNascimento).HasColumnName("DataNascimento");
        }
    }
}
