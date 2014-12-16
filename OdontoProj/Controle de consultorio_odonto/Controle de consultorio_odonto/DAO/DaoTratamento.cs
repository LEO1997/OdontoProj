using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Controle_de_consultorio_odonto.DAO
{
    class DaoTratamento
    {
        private MySqlConnection mycon;//variável que estabelece conexão com o bd;
        private MySqlCommand mycommand;//armazena o comando a ser executado;

        public DaoTratamento()
        {
            String conexao = DataStore.Conexao;

            mycon = new MySqlConnection(conexao);
        }


    }   
}
