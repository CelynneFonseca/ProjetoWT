using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereTo.Comum.NotificationPattern;
using WhereTo.Dados.Repositorio;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Servico.Servicos
{
    public class LocalServico
    {
        private readonly LocalRepositorio _localRepositorio;

        public LocalServico()
        {
            _localRepositorio = new LocalRepositorio();
        }

        public NotificationResult Salvar(Local entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
               if (notificationResult.IsValid)
                {
                    _localRepositorio.Adicionar(entidade);

                    notificationResult.Add("Local da peça de roupa do avatar cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Local> ListarTodos()
        {
            return _localRepositorio.ListarTodos();
        }

        public string Excluir(Local entidade)
        {
            return "";
        }
    }
}
