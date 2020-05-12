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
    public class EstabelecimentoConfiguracao : IEntityTypeConfiguration<Estabelecimento>
    {
        public void Configure(EntityTypeBuilder<Estabelecimento> builder)
        {
            builder.ToTable("Estabelecimento");
            builder.HasKey("EstabelecimentoID");
            builder.Property(f => f.EstabelecimentoID).HasColumnName("EstabelecimentoID");
            builder.Property(f => f.Classificacao).HasColumnName("Classificacao");
            builder.Property(f => f.Comentarios).HasColumnName("Comentarios");
            builder.Property(f => f.RoupaPersonalizada).HasColumnName("RoupaPersonalizada");
            builder.Property(f => f.CodigoID).HasColumnName("CodigoID");
            builder.Property(f => f.CEPEstabelecimento).HasColumnName("CEPEstabelecimento");
            builder.Property(f => f.UsuarioID).HasColumnName("UsuarioID");

            builder
                .HasMany("Codigo")
                .WithOne("CodigoID");

            builder
                .HasMany("LocalEstabelecimento")
                .WithOne("CEPEstabelecimento");

            builder
                .HasMany("Usuario")
                .WithOne("UsuarioID");
        }
    }
}
