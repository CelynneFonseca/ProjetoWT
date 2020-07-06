using System;
using System.Collections.Generic;
using System.Text;
using WhereTo.Comum.NotificationPattern;
using WhereTo.Dados.Repositorio;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Servico.Servicos
{
    public class ItemDetalhesServico
    {
        private readonly ItemDetalhesRepositorio _itemdetalhesRepositorio;

        public ItemDetalhesServico()
        {
            _itemdetalhesRepositorio = new ItemDetalhesRepositorio();
        }

        public NotificationResult Salvar(ItemDetalhes entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.Item_Nome.Length < 2)
                    notificationResult.Add(new NotificationError("Nome do Item Inválido", NotificationErrorType.BUSINESS_RULES));
                if (entidade.Descricao.Length < 4)
                    notificationResult.Add(new NotificationError("Descrição Inválida", NotificationErrorType.BUSINESS_RULES));
                if (entidade.Image_Nome.Length <= null)
                    notificationResult.Add(new NotificationError("Imagem Inválida", NotificationErrorType.BUSINESS_RULES));

                if (notificationResult.IsValid)
                {
                    _itemdetalhesRepositorio.Adicionar(entidade);

                    notificationResult.Add("Item cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(ItemDetalhes entidade)
        {
            return "";
        }

        public IEnumerable<ItemDetalhes> Nome_Item()
        {
            return _itemdetalhesRepositorio.Item_Nome(); 
        }

        public IEnumerable<ItemDetalhes> Descricao()
        {
            return _itemdetalhesRepositorio.Descricao();
        }        

        public IEnumerable<ItemDetalhes> Item_Preco()
        {
            return _itemdetalhesRepositorio.Item_Preco();
        }

        public IEnumerable<ItemDetalhes> Image()
        {
            return _itemdetalhesRepositorio.Image_Nome();
        }

        public IEnumerable<ItemDetalhes> ListarTodos()
        {
            return _itemdetalhesRepositorio.ListarTodos();
        }
    }
}
