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
    public class AdmEstabelecimentoConfiguracao : IEntityTypeConfiguration<AdmEstabelecimento>
    {
        public void Configure(EntityTypeBuilder<AdmEstabelecimento> builder)
        {
            builder.ToTable("AdmEstabelecimento");
            builder.HasKey("AdmID");
            builder.Property(f => f.AdmID).HasColumnName("AdmID");
            builder.Property(f => f.NomeAdm).HasColumnName("NomeAdm");
            builder.Property(f => f.TelefonePrincipal).HasColumnName("TelefonePrincipal");
            builder.Property(f => f.TelefoneSecundario).HasColumnName("TelefoneSecundario");
            builder.Property(f => f.CEPEstabelecimento).HasColumnName("CEPEstabelecimento");

            builder
                .HasMany("LocalEstabelecimento")
                .WithOne("CEPEstabelecimento");
        }
    }
}
