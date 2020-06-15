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
    public class CodigoController : ControllerBase
    {
        private readonly CodigoServico codigoServico;

        public CodigoController()
        {
            codigoServico = new CodigoServico();
        }

        [HttpGet]
        public IEnumerable<Codigo> ListarTodos()
        {
            return codigoServico.ListarTodos();
        }

        [HttpPost]
        public NotificationResult Salvar(Codigo entidade)
        {
            return codigoServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Codigo entidade)
        {
            return codigoServico.Excluir(entidade);
        }
    }
}
