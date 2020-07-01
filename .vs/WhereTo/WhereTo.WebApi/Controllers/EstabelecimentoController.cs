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
    [Route("Controller")]
    public class EstabelecimentoController : ControllerBase
    {
        private readonly EstabelecimentoServico estabelecimentoServico;

        [HttpGet]
        public IEnumerable<Estabelecimento> ListarTodos()
        {
            return estabelecimentoServico.ListarTodos();
        }

        [HttpPost]
        public NotificationResult Salvar(Estabelecimento entidade)
        {
            return estabelecimentoServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Estabelecimento entidade)
        {
            return estabelecimentoServico.Excluir(entidade);
        }
    }
}
