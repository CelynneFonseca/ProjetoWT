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
    [ApiController]
    [Route("controller")]
    public class AvatarController : ControllerBase
    {
        private readonly AvatarServico avatarServico;

        public AvatarController()
        {
            avatarServico = new AvatarServico();
        }

        [HttpGet]
        public IEnumerable<Avatar> Nome()
        {
            return avatarServico.Nome();
        }

        public IEnumerable<Avatar> ListarTodos()
        {
            return avatarServico.ListarTodos();
        }

        [HttpPost]
        public NotificationResult Salvar(Avatar entidade)
        {
            return avatarServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Avatar entidade)
        {
            return avatarServico.Excluir(entidade);
        }
    }
}
