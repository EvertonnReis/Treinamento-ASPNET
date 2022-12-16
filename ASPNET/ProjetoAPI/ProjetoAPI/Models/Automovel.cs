using Automovel.Domain;
using DAO;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    public class Automovel
    {
        public string Get(int id)
        {
            string sqlString = "select " +
                               "id_automovel," +
                               "modelo_automovel," +
                               "ano_automovel" +
                               "from automoveis";

            var dt = BDOracle.getDataTable(sqlString);

            AutomovelDTO automovel = new AutomovelDTO();


            try
            {
                DataRow reg = dt.Rows[0];
                automovel.id_automovel = Convert.ToInt32(reg["id_automovel"].ToString());
                automovel.modelo_automovel = reg["modelo_automovel"].ToString();
                automovel.ano_automovel = Convert.ToInt32(reg["ano_automovel"].ToString());
                return JObject.FromObject(automovel).ToString();
            }
            catch (Exception)
            {
                return null;
            }   
 
        }
    }
}