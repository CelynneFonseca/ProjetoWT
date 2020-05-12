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
    public class UsuarioServico
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        public NotificationResult Salvar(Usuario entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.Nome.Length < 2)
                    notificationResult.Add(new NotificationError("Nome Inválido", NotificationErrorType.BUSINESS_RULES));

                if (entidade.DataNascimento.Date == null)
                    notificationResult.Add(new NotificationError("Data de Nascimento Inválida", NotificationErrorType.BUSINESS_RULES));

                if (notificationResult.IsValid)
                {
                    _usuarioRepositorio.Adicionar(entidade);

                    notificationResult.Add("Usuario cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public string Excluir(Usuario entidade)
        {
            return "";
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return _usuarioRepositorio.ListarTodos();
        }

        public IEnumerable<Usuario> Nome()
        {
            return _usuarioRepositorio.Nome();
        }
    }
}
