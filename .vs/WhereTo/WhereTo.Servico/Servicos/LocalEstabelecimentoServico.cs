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
    public class LocalEstabelecimentoServico
    {
        private readonly LocalEstabelecimentoRepositorio _localestabelecimentoRepositorio;

        public LocalEstabelecimentoServico()
        {
            _localestabelecimentoRepositorio = new LocalEstabelecimentoRepositorio();
        }

        public NotificationResult Salvar(LocalEstabelecimento entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.NomeEstabelecimento.Length < 4)
                    notificationResult.Add(new NotificationError("Nome do Estabelecimento Inválido", NotificationErrorType.BUSINESS_RULES));

                if (entidade.CEPEstabelecimento.Length < 5)
                    notificationResult.Add(new NotificationError("CEP inválido", NotificationErrorType.BUSINESS_RULES));

                if (entidade.RuaEstabelecimento.Length < 4)
                    notificationResult.Add(new NotificationError("Nome da Rua Inválido", NotificationErrorType.BUSINESS_RULES));

                if (entidade.NumeroEstabelecimento == 0)
                    notificationResult.Add(new NotificationError("Numero Inválido", NotificationErrorType.BUSINESS_RULES));

                if (entidade.BairroEstabelecimento.Length < 4)
                    notificationResult.Add(new NotificationError("Nome do Bairro Inválido", NotificationErrorType.BUSINESS_RULES));

                if (entidade.CidadeEstabelecimento.Length < 4)
                    notificationResult.Add(new NotificationError("Nome da Cidade Inválido", NotificationErrorType.BUSINESS_RULES));

                if (entidade.PaisEstabelecimento.Length < 2)
                    notificationResult.Add(new NotificationError("Nome do País Inválido", NotificationErrorType.BUSINESS_RULES));

                if (notificationResult.IsValid)
                {
                    _localestabelecimentoRepositorio.Adicionar(entidade);

                    notificationResult.Add("Local do Estabelecimento cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(LocalEstabelecimento entidade)
        {
            return "";
        }

        public IEnumerable<LocalEstabelecimento> NomeEstabelecimento()
        {
            return _localestabelecimentoRepositorio.NomeEstabelecimento();
        }

        public IEnumerable<LocalEstabelecimento> CEPEstabelecimento()
        {
            return _localestabelecimentoRepositorio.CEPEstabelecimento();
        }


        public IEnumerable<LocalEstabelecimento> RuaEstabelecimento()
        {
            return _localestabelecimentoRepositorio.RuaEstabelecimento();
        }

        public IEnumerable<LocalEstabelecimento> NumeroEstabelecimento()
        {
            return _localestabelecimentoRepositorio.NumeroEstabelecimento();
        }

        public IEnumerable<LocalEstabelecimento> BairroEstabelecimento()
        {
            return _localestabelecimentoRepositorio.BairroEstabelecimento();
        }

        public IEnumerable<LocalEstabelecimento> CidadeEstabelecimento()
        {
            return _localestabelecimentoRepositorio.CidadeEstabelecimento();
        }

        public IEnumerable<LocalEstabelecimento> PaisEstabelecimento()
        {
            return _localestabelecimentoRepositorio.PaisEstabelecimento();
        }
    }
}
