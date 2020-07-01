using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Repositorio
{
    public class EstabelecimentoRepositorio : RepositorioBase<Estabelecimento>
    {
        public IEnumerable<Estabelecimento> Classificacao()
        {
            return Contexto
                .Estabelecimento
                .Where(f => f.Classificacao == 0);
        }
        public IEnumerable<Estabelecimento> Comentarios()
        {
            return Contexto
                .Estabelecimento
                .Where(f => f.Classificacao == 0);
        }

    }
}
