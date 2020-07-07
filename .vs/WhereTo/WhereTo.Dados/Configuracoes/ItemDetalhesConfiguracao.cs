using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Configuracoes
{
    public class ItemDetalhesConfiguracao : IEntityTypeConfiguration<ItemDetalhes>
    {
        public void Configure(EntityTypeBuilder<ItemDetalhes> builder)
        {
            builder.ToTable("ItemDetalhes");
            builder.HasKey("Item_ID");
            builder.Property(f => f.Item_ID).HasColumnName("Item_ID");
            builder.Property(f => f.Item_Nome).HasColumnName("Item_Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.Item_Preco).HasColumnName("Item_Preco");
            builder.Property(f => f.Image_Nome).HasColumnName("Image_Nome");
        }
    }
}
