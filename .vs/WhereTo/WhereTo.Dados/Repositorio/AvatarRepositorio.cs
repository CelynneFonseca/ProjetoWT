using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Repositorio
{
    public class AvatarRepositorio : RepositorioBase<Avatar>
    {
        public IEnumerable<Avatar> NomeAvatar()
        {
            return Contexto
                .Avatar
                .Where(f => f.NomeAvatar == null);
        }
    }
}
