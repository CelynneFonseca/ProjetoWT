using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WhereTo.WebApi
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AutenticacaoBasicaAttribute : TypeFilterAttribute
    {
        public AutenticacaoBasicaAttribute() : base(typeof(AutenticacaoBasicaHandler))
        {

        }
    }

    public class AutenticacaoBasicaHandler : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                string cabecalho = context.HttpContext.Request.Headers["Authorization"];

                if (cabecalho != null)
                {
                    var authHeaderValue = AuthenticationHeaderValue.Parse(cabecalho);
                    if (authHeaderValue.Scheme.Equals(AuthenticationSchemes.Basic.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        var credenciais = Encoding.UTF8
                            .GetString(Convert.FromBase64String(authHeaderValue.Parameter ?? string.Empty))
                            .Split(':', 3);

                        if (credenciais.Length == 3)
                            if (EstaAutenticado(context, credenciais[0], credenciais[1], credenciais[2]))
                                return;
                    }
                }

                NaoAutorizadoResult(context);
            }
            catch (FormatException)
            {
                NaoAutorizadoResult(context);
            }
        }

        public bool EstaAutenticado(AuthorizationFilterContext context, string username, string password, string data)
        {
            return username == "gabriel" && password == "teste*123" && Convert.ToDateTime(data).AddMinutes(5) < DateTime.Now;
        }

        private void NaoAutorizadoResult(AuthorizationFilterContext context)
        {
            context.Result = new UnauthorizedResult();
        }
    }
}
