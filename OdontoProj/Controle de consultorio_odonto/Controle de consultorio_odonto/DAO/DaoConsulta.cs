using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Controle_de_consultorio_odonto.Classes_de_entidades;
using System.Collections;
using System.Data;

namespace Controle_de_consultorio_odonto.DAO
{
    class DaoConsulta
    {
        private string conexao;
        private MySqlConnection mycon;//variável que estabelece conexão com o bd;
        private MySqlCommand mycommand;//armazena o comando a ser executado;
        private MySqlDataReader mydr;

        public DaoConsulta()
        {
            conexao = DataStore.Conexao;            
            mycon = new MySqlConnection(conexao);           
        }

        public void Save(Consulta myCons)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;//Vincula comado de execução com a variável de conexão.
            mycommand.CommandText = "insert into consulta(data_hora, sala, Paciente_cpf, Profissional_cro, Servico_cod_servico, Tratamento_cod_tratamento)" + 
                                    "values(@dth,@sl,(select cpf from Paciente where nome='" + myCons.Pac + "')," +
                                    "(select cro from Profissional where nome='" + myCons.Prof + "')," +
                                    "(select cod_servico from Servico where descricao='" + myCons.Serv + "')," +
                                    "(select cod_tratamento from Tratamento where titulo='" + myCons.Trat + "'));";
            mycommand.Parameters.AddWithValue("@dth", myCons.Dtahora);
            mycommand.Parameters.AddWithValue("@sl", myCons.Sala);                                   
            mycommand.Prepare();
            mycommand.ExecuteNonQuery();
            
            mycon.Close();
        }

        public void update(object cod, object dta, object sala, object cro, object serv)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "update consulta set data_hora=@dt , sala=@sl, Profissional_cro=@pcro, " +
                                      "Servico_cod_servico=@scs where codigo=@cod;";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cod", cod);
            mycommand.Parameters.AddWithValue("@dt", dta);
            mycommand.Parameters.AddWithValue("@sl", sala);
            mycommand.Parameters.AddWithValue("@pcro", cro);
            mycommand.Parameters.AddWithValue("@scs", serv);            

            mycommand.ExecuteNonQuery();

            mycon.Close();

        }

        public void delete(object cod)
        {
            mycon.Open();
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "delete from consulta where codigo=@cod;";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cod", cod);
            mycommand.ExecuteNonQuery();

            mycon.Close();
        }
               
    }
}
