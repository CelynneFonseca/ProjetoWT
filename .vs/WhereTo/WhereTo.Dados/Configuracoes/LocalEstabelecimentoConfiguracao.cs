﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Configuracoes
{
    public class LocalEstabelecimentoConfiguracao : IEntityTypeConfiguration<LocalEstabelecimento>
    {
        public void Configure(EntityTypeBuilder<LocalEstabelecimento> builder)
        {
            builder.ToTable("LocalEstabelecimento");
            builder.HasKey("NomeEstabelecimento");
            builder.Property(f => f.NomeEstabelecimento).HasColumnName("NomeEstabelecimento");
            builder.Property(f => f.CEPEstabelecimento).HasColumnName("CEPEstabelecimento");
            builder.Property(f => f.RuaEstabelecimento).HasColumnName("RuaEstabelecimento");
            builder.Property(f => f.NumeroEstabelecimento).HasColumnName("NumeroEstabelecimento");
            builder.Property(f => f.BairroEstabelecimento).HasColumnName("BairroEstabelecimento");
            builder.Property(f => f.CidadeEstabelecimento).HasColumnName("CidadeEstabelecimento");
            builder.Property(f => f.PaisEstabelecimento).HasColumnName("PaisEstabelecimento");
            builder.Property(f => f.EstabelecimentoID).HasColumnName("EstabelecimentoID");

            builder
                .HasMany("Estabelecimento")
                .WithOne("EstabelecimentoID");
        }
    }
}
