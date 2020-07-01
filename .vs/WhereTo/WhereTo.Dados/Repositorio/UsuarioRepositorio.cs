using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dados.EntityFramework.Contexto;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Repositorio
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>
    {
        public IEnumerable<Usuario> Nome()
        {
            return Contexto
                .Usuario
                .Where(f => f.Nome == null);
        }

        public IEnumerable<Usuario> Senha()
        {
            return Contexto
                .Usuario
                .Where(f => f.Senha == null);
        }

        public IEnumerable<Usuario> Email()
        {
            return Contexto
                .Usuario
                .Where(f => f.Email == null);
        }
    }
}
