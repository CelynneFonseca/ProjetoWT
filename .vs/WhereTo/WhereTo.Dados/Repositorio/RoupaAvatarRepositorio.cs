using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Repositorio
{
    public class RoupaAvatarRepositorio : RepositorioBase<RoupaAvatar>
    {
        public IEnumerable<RoupaAvatar> Cor()
        {
            return Contexto
                .RoupaAvatar
                .Where(f => f.Cor == null);
        }

        public IEnumerable<RoupaAvatar> Local()
        {
            return Contexto
                .RoupaAvatar
                .Where(f => f.Local == 0);
        }
    }
}
