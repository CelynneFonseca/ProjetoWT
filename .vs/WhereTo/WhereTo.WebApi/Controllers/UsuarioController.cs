using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhereTo.Comum.NotificationPattern;
using WhereTo.Dominio.Entidades;
using WhereTo.Servico.Servicos;

namespace WhereTo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioServico usuarioServico;

        public UsuarioController()
        {
            usuarioServico = new UsuarioServico();
        }

        [HttpGet]
        public IEnumerable<Usuario> Nome()
        {
            return usuarioServico.Nome();
        }

        [HttpPost]
        public NotificationResult Salvar(Usuario entidade)
        {
            return usuarioServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Usuario entidade)
        {
            return usuarioServico.Excluir(entidade);
        }
    }
}
