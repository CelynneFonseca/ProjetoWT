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
    public class AdmEstabelecimentoController : ControllerBase
    {
        private readonly AdmEstabelecimentoServico admEstabelecimentoServico;

        public AdmEstabelecimentoController()
        {
            admEstabelecimentoServico = new AdmEstabelecimentoServico();
        }

        [HttpGet]
        public IEnumerable<AdmEstabelecimento> ListarTodos()
        {
            return admEstabelecimentoServico.ListarTodos();
        }

        [HttpPost]
        public NotificationResult Salvar(AdmEstabelecimento entidade)
        {
            return admEstabelecimentoServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(AdmEstabelecimento entidade)
        {
            return admEstabelecimentoServico.Excluir(entidade);
        }
    }
}
