using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dados.Configuracoes;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.EntityFramework.Contexto
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Avatar> Avatar { get; set; }
        public DbSet<RoupaAvatar> RoupaAvatar { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<Codigo> Codigo { get; set; }
        public DbSet<LocalEstabelecimento> LocalEstabelecimento { get; set; }
        public DbSet<AdmEstabelecimento> AdmEstabelecimento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("server=201.62.57.93;database=dbLAB_2020;user id=visualstudio;password=visualstud;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            modelBuilder.ApplyConfiguration(new AvatarConfiguracao());
            modelBuilder.ApplyConfiguration(new RoupaAvatarConfiguracao());
            modelBuilder.ApplyConfiguration(new LocalConfiguracao());
            modelBuilder.ApplyConfiguration(new CodigoConfiguracao());
            modelBuilder.ApplyConfiguration(new LocalEstabelecimentoConfiguracao());
            modelBuilder.ApplyConfiguration(new AdmEstabelecimentoConfiguracao());
        }
    }
}
