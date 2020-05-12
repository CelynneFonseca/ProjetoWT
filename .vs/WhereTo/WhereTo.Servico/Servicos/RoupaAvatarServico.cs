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
    public class RoupaAvatarServico
    {
        private readonly RoupaAvatarRepositorio _roupaavatarRepositorio;

        public RoupaAvatarServico()
        {
            _roupaavatarRepositorio = new RoupaAvatarRepositorio();
        }

        public NotificationResult Salvar(RoupaAvatar entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    _roupaavatarRepositorio.Adicionar(entidade);

                    notificationResult.Add("Roupa adicionada com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(RoupaAvatar entidade)
        {
            return "";
        }

        public IEnumerable<RoupaAvatar> ListarTodos()
        {
            return _roupaavatarRepositorio.ListarTodos();
        }

        public IEnumerable<RoupaAvatar> Cor()
        {
            return _roupaavatarRepositorio.Cor();
        }

        public IEnumerable<RoupaAvatar> Local()
        {
            return _roupaavatarRepositorio.Local();
        }
    }
}
