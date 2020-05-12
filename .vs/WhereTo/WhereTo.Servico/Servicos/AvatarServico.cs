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
    public class AvatarServico
    {
        private readonly AvatarRepositorio _avatarRepositorio;

        public AvatarServico()
        {
            _avatarRepositorio = new AvatarRepositorio();
        }

        public NotificationResult Salvar(Avatar entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.NomeAvatar.Length < 2)
                    notificationResult.Add(new NotificationError("Nome Inválido", NotificationErrorType.BUSINESS_RULES));

                if (notificationResult.IsValid)
                {
                    _avatarRepositorio.Adicionar(entidade);

                    notificationResult.Add("Avatar cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Avatar entidade)
        {
            return "";
        }

        public IEnumerable<Avatar> Nome()
        {
            return _avatarRepositorio.NomeAvatar(); //Lista os nomes que o avatar já teve.
        }
    }
}
