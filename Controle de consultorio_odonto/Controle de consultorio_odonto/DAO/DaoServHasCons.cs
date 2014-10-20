using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Controle_de_consultorio_odonto.Classes_de_entidades;

namespace Controle_de_consultorio_odonto.DAO
{
    class DaoServHasCons
    {
        private MySqlConnection mycon;//variável que estabelece conexão com o bd;
        private MySqlCommand mycommand;//armazena o comando a ser executado;

        public DaoServHasCons()
        {
            String conexao = "server=localhost;userid=root;password=;database=Consultorio_odonto;";
            
            mycon = new MySqlConnection(conexao);           
        }

        public void Save(Servico_has_Consulta mySHC)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "insert into servico_has_consulta(Servico_cod_servico, Consulta_codigo) values((select cod_servico from Servico where descricao='" + mySHC.DescServico + "')," +
                                    "(select codigo from Consulta where data_hora='" + mySHC.HoraConsulta + "'));";            
            mycommand.Prepare();
            mycommand.ExecuteNonQuery();
            mycon.Close();
    }
    }
}
