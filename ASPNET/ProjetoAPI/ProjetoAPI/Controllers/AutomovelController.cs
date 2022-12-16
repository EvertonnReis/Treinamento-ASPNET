using HttpActionResultStatus;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjetoAPI.Models;

namespace ProjetoAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AutomovelController: ApiController
    {
        [HttpGet]
        [Route("api/automovel")]        
        public IHttpActionResult Get(int id)
        {
            try
            {
                HttpResult result = new HttpResult();
                var automovel = new ProjetoAPI.Models.Automovel();
                string retorno = automovel.Get(id);
                if (String.IsNullOrEmpty(retorno))
                {
                    retorno = @"('Message': 'Automovel não encontrado')";
                    return result.ResultStatus(JObject.Parse(retorno).ToString(), Request, HttpStatusCode.InternalServerError);
                }
                return result.ResultStatus(retorno, Request, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}