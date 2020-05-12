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
    public class AvatarRoupaServico
    {
        private readonly AvatarRoupaRepositorio _avatarroupaRepositorio;

        public AvatarRoupaServico()
        {
            _avatarroupaRepositorio = new AvatarRoupaRepositorio();
        }

        public NotificationResult Salvar(AvatarRoupa entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    _avatarroupaRepositorio.Adicionar(entidade);

                    notificationResult.Add("Roupa de Avatar adicionada com sucesso ao seu guarda-roupa.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(AvatarRoupa entidade)
        {
            return "";
        }

        public IEnumerable<AvatarRoupa> ListarTodos()
        {
            return _avatarroupaRepositorio.ListarTodos(); //aqui seria a lista de roupas de avatares do guarda-roupa
        }
    }
}
