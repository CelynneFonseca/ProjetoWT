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
    [Route("api/controller")]
    [ApiController]
    public class ItemDetalhesController : ControllerBase
    {
        private readonly ItemDetalhesServico itemDetalhesServico;

        public ItemDetalhesController()
        {
            itemDetalhesServico = new ItemDetalhesServico();
        }

        [HttpGet]
        public IEnumerable<ItemDetalhes> Item_Nome()
        {
            return itemDetalhesServico.Nome_Item();
        }

        public IEnumerable<ItemDetalhes> ListarTodos()
        {
            return itemDetalhesServico.ListarTodos();
        }

        [HttpPost]
        public NotificationResult Salvar(ItemDetalhes entidade)
        {
            return itemDetalhesServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(ItemDetalhes entidade)
        {
            return itemDetalhesServico.Excluir(entidade);
        }
    }
}
