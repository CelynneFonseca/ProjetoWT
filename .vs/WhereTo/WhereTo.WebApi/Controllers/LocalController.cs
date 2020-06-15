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
    public class LocalController : ControllerBase
    {
        private readonly LocalServico localServico;

        public LocalController()
        {
            localServico = new LocalServico();
        }

        [HttpGet]
        public IEnumerable<Local> ListarTodos()
        {
            return localServico.ListarTodos();
        }

        [HttpPost]
        public NotificationResult Salvar(Local entidade)
        {
            return localServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Local entidade)
        {
            return localServico.Excluir(entidade);
        }
    }
}
