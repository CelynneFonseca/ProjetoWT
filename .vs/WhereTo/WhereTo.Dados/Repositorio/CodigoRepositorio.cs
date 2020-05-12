using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Repositorio
{
    public class CodigoRepositorio : RepositorioBase<Codigo>
    {
        public IEnumerable<Codigo> Codigo()
        {
            return Contexto
                .Codigo
                .Where(f => f.CodigoID != 0);
        }
    }
}
