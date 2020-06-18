using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereTo.Dominio.Entidades
{
    public class LocalEstabelecimento
    {
        public int EstabelecimentoID { get; set; }
        public string RuaEstabelecimento { get; set; }
        public int NumeroEstabelecimento { get; set; }
        public string BairroEstabelecimento { get; set; }
        public string CidadeEstabelecimento { get; set; }
        public string PaisEstabelecimento { get; set; }
    }
}
