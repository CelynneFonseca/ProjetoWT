using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereTo.Dominio.Entidades
{
    public class Local
    {
        public int LocalID { get; set; }
        public int PartesDeCima { get; set; }
        public int PartesDeBaixo { get; set; }
        public int Acessorios { get; set; }
        public RoupaAvatar RoupaID { get; set; }
    }
}
