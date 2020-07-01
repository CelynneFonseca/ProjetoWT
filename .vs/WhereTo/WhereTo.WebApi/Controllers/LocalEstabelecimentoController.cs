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
            return localEstabelecimentoServico.NomeEstabelecimento();
        }

        [HttpGet]
        public IEnumerable<LocalEstabelecimento> CEPEstabelecimento()
        {
            return localEstabelecimentoServico.CEPEstabelecimento();
        }

        [HttpGet]
        public IEnumerable<LocalEstabelecimento> RuaEstabelecimento()
        {
            return localEstabelecimentoServico.RuaEstabelecimento();
        }

        [HttpGet]
        public IEnumerable<LocalEstabelecimento> NumeroEstabelecimento()
        {
            return localEstabelecimentoServico.NumeroEstabelecimento();
        }

        [HttpGet]
        public IEnumerable<LocalEstabelecimento> BairroEstabelecimento()
        {
            return localEstabelecimentoServico.BairroEstabelecimento();
        }

        [HttpGet]
        public IEnumerable<LocalEstabelecimento> CidadeEstabelecimento()
        {
            return localEstabelecimentoServico.CidadeEstabelecimento();
        }

        [HttpGet]
        public IEnumerable<LocalEstabelecimento> PaisEstabelecimento()
        {
            return localEstabelecimentoServico.PaisEstabelecimento();
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
