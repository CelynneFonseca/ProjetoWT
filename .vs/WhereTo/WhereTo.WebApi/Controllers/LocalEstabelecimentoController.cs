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
    public class LocalEstabelecimentoController : ControllerBase
    {
        private readonly LocalEstabelecimentoServico localEstabelecimentoServico;

        public LocalEstabelecimentoController()
        {
            localEstabelecimentoServico = new LocalEstabelecimentoServico();
        }

        [HttpGet]
        public IEnumerable<LocalEstabelecimento> ListarTodos()
        {
            return localEstabelecimentoServico.CEPEstabelecimento();
        }

        [HttpPost]
        public NotificationResult Salvar(LocalEstabelecimento entidade)
        {
            return localEstabelecimentoServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(LocalEstabelecimento entidade)
        {
            return localEstabelecimentoServico.Excluir(entidade);
        }
    }
}
