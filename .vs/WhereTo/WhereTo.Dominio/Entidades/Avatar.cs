using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereTo.Dominio.Entidades
{
    public class Avatar
    {
        public int AvatarID { get; set; }
        public char Sexo { get; set; }
        public string NomeAvatar { get; set; }
        public Usuario UsuarioID { get; set; }
    }
}
