using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Repositorio
{
    public class LocalEstabelecimentoRepositorio : RepositorioBase<AdmEstabelecimento>
    {
        public IEnumerable<LocalEstabelecimento> NomeEstabelecimento()
        {
            return Contexto
                .LocalEstabelecimento
                .Where(f => f.NomeEstabelecimento == null);
        }

        public IEnumerable<LocalEstabelecimento> CEPEstabelecimento()
        {
            return Contexto
                .LocalEstabelecimento
                .Where(f => f.CEPEstabelecimento == null);
        }
        
        public IEnumerable<LocalEstabelecimento> RuaEstabelecimento()
        {
            return Contexto
                .LocalEstabelecimento
                .Where(f => f.RuaEstabelecimento == null);
        }

        public IEnumerable<LocalEstabelecimento> NumeroEstabelecimento()
        {
            return Contexto
                .LocalEstabelecimento
                .Where(f => f.NumeroEstabelecimento == 0);
        }

        public IEnumerable<LocalEstabelecimento> BairroEstabelecimento()
        {
            return Contexto
                .LocalEstabelecimento
                .Where(f => f.BairroEstabelecimento == null);
        }

        public IEnumerable<LocalEstabelecimento> CidadeEstabelecimento()
        {
            return Contexto
                .LocalEstabelecimento
                .Where(f => f.CidadeEstabelecimento == null);
        }

        public IEnumerable<LocalEstabelecimento> PaisEstabelecimento()
        {
            return Contexto
                .LocalEstabelecimento
                .Where(f => f.PaisEstabelecimento == null);
        }

        public void Adicionar(LocalEstabelecimento entidade)
        {
            throw new NotImplementedException();
        }
    }
}
