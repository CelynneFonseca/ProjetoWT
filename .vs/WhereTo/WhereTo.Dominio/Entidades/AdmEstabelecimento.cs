using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereTo.Dominio.Entidades
{
    public class AdmEstabelecimento
    {
        public int AdmID { get; set; }
        public string NomeAdm { get; set; }
        public string TelefonePrincipal { get; set; }
        public string TelefoneSecundario { get; set; } 
        public LocalEstabelecimento EstabelecimentoID { get; set; }
    }
}
