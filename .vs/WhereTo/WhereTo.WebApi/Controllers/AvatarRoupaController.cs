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
    public class AvatarRoupaController : ControllerBase
    {
        private readonly AvatarRoupaServico avatarRoupaServico;

        public AvatarRoupaController()
        {
            avatarRoupaServico = new AvatarRoupaServico();
        }

        [HttpGet]
        public IEnumerable<AvatarRoupa> ListarTodos()
        {
            return avatarRoupaServico.ListarTodos();
        }

        [HttpPost]
        public NotificationResult Salvar(AvatarRoupa entidade)
        {
            return avatarRoupaServico.Salvar();
        }

        [HttpDelete]
        public string Excluir(AvatarRoupa entidade)
        {
            return avatarRoupaServico.Excluir();
        }
    }
}
