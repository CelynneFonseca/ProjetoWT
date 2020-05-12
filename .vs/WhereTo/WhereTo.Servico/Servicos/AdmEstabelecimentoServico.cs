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
    public class AdmEstabelecimentoServico
    {
        private readonly AdmEstabelecimentoRepositorio _admestabelecimentoRepositorio;

        public AdmEstabelecimentoServico()
        {
            _admestabelecimentoRepositorio = new AdmEstabelecimentoRepositorio();
        }

        public NotificationResult Salvar(AdmEstabelecimento entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.NomeAdm.Length < 2)
                    notificationResult.Add(new NotificationError("Nome Inválido", NotificationErrorType.BUSINESS_RULES));

                if (entidade.TelefonePrincipal.Length < 9)
                    notificationResult.Add(new NotificationError("Telefone Principal Inválido", NotificationErrorType.BUSINESS_RULES));

                if (notificationResult.IsValid)
                {
                    _admestabelecimentoRepositorio.Adicionar(entidade);

                    notificationResult.Add("Administrador cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(AdmEstabelecimento entidade)
        {
            return "";
        }

        public IEnumerable<AdmEstabelecimento> ListarTodos()
        {
            return _admestabelecimentoRepositorio.ListarTodos();
        }

        public IEnumerable<AdmEstabelecimento> Nome()
        {
            return _admestabelecimentoRepositorio.NomeAdm();
        }
    }
}
