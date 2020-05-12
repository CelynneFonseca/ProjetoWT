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
    public class CodigoServico
    {
        private readonly CodigoRepositorio _codigoRepositorio;

        public CodigoServico()
        {
            _codigoRepositorio = new CodigoRepositorio();
        }

        public NotificationResult Salvar(Codigo entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    _codigoRepositorio.Adicionar(entidade);

                    notificationResult.Add("Código QR válido.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Codigo entidade)
        {
            return "";
        }

        public IEnumerable<Codigo> ListarTodos()
        {
            return _codigoRepositorio.ListarTodos(); //lista todos os codigos qr que o local já teve (é necessario? 0.o)
        }

        public IEnumerable<Codigo> CodigoQR()
        {
            return _codigoRepositorio.Codigo();
        }
    }
}
