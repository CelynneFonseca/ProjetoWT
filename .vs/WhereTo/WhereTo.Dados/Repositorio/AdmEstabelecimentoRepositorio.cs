using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Repositorio
{
    public class AdmEstabelecimentoRepositorio : RepositorioBase<AdmEstabelecimento>
    {
        public IEnumerable<AdmEstabelecimento> NomeAdm()
        {
            return Contexto
                .AdmEstabelecimento
                .Where(f => f.NomeAdm == null);
        }

        public IEnumerable<AdmEstabelecimento> TelefonePrincipal()
        {
            return Contexto
                .AdmEstabelecimento
                .Where(f => f.TelefonePrincipal == null);
        }

        public IEnumerable<AdmEstabelecimento> TelefoneSecundario()
        {
            return Contexto
                .AdmEstabelecimento
                .Where(f => f.TelefoneSecundario == null);
        }
    }
}
