using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_consultorio_odonto.DAO
{
    static class DataStore
    {        
        private static string conexao;        

        public static string Conexao
        {
            get
            {
                return conexao;
            }
            set
            {
                conexao = value;
            }
        }
       
    }
}
