using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereTo.Dominio.Entidades
{
    public class Estabelecimento
    {
        public int EstabelecimentoID { get; set; }
        public int Classificacao { get; set; }
        public string Comentarios { get; set; }
        public bool RoupaPersonalizada { get; set; }
        public LocalEstabelecimento CEPEstabelecimento { get; set; }
        public Codigo CodigoID { get; set; }
        public Usuario UsuarioID { get; set; }

    }
}
