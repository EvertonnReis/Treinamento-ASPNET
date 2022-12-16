using DAO;
using ProjetoAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjetoAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            AutomovelService.Conexao = "TESTE";
            BDOracle.strConexao = AutomovelService.Conexao;
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
