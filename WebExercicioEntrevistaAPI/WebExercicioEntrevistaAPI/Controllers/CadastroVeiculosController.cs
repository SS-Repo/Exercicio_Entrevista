using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebExercicioEntrevistaAPI.Models;

namespace WebExercicioEntrevistaAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/public")]
    public class CadastroVeiculosController : ApiController
    {
        private static List<CadastroVeiculos> L_CadastroVeiculos = new List<CadastroVeiculos>();

        [Route("veiculos")]
        public HttpResponseMessage Get()
        {
            var result = L_CadastroVeiculos;
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("veiculo")]
        public HttpResponseMessage Post([FromBody]CadastroVeiculos cadastroveiculos)
        {
            if (cadastroveiculos == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            try
            {
                L_CadastroVeiculos.Add(cadastroveiculos);
                var result = L_CadastroVeiculos;
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao incluir veiculo");
            }
        }

        [HttpDelete]
        [Route("veiculo")]
        public HttpResponseMessage Delete([FromBody]string id)
        {
            int codigo = Convert.ToInt32(id);
            L_CadastroVeiculos.RemoveAt(L_CadastroVeiculos.IndexOf(L_CadastroVeiculos.First(x => x.Id.Equals(codigo))));
            return Request.CreateResponse(HttpStatusCode.OK, "Veiculo excluido com sucesso");
        }
    }
}
