using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Service
{
    public class AutomovelService
    {
        private static string conexaoProd = "Data source = 172.16.3.200/FAMEMA2; User Id = HCTM; Password = Sistemas11G; Integrated Security = no; ";
        private static string conexaoTeste = "Data source = 172.16.3.25/SISTEMAS; User Id = famemasistemas; Password = desenv2013; Integrated Security = no; ";

        private static string conexao;
        public static string Conexao
        {
            get
            {
                if (conexao == "PROD")
                {
                    return conexaoProd;
                }
                else if (conexao == "TESTE")
                {
                    return conexaoTeste;
                }

                return null;
            }
            set
            {
                conexao = value;
            }
        }
    }
}