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
    public class EstabelecimentoServico
    {
        private readonly EstabelecimentoRepositorio _estabelecimentoRepositorio;

        public EstabelecimentoServico()
        {
            _estabelecimentoRepositorio = new EstabelecimentoRepositorio();
        }

        public NotificationResult Salvar(Estabelecimento entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                /* ---> essa parte não deveria estar no cadastro né? só pros usuarios
                if (entidade.Classificacao < 10)
                    notificationResult.Add(new NotificationError("Classificação inválida. Digite um número de 0 a 10.", NotificationErrorType.BUSINESS_RULES));

                if (entidade.Comentarios.Length < 2)
                    notificationResult.Add(new NotificationError("Escreva um comentário sobre o estabelecimento.", NotificationErrorType.BUSINESS_RULES));
                */

                if (notificationResult.IsValid)
                {
                    _estabelecimentoRepositorio.Adicionar(entidade);

                    notificationResult.Add("Estabelecimento cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Estabelecimento entidade)
        {
            return "";
        }

        public IEnumerable<Estabelecimento> ListarTodos()
        {
            return _estabelecimentoRepositorio.ListarTodos();
        }
    }
}
