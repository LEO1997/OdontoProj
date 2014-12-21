using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

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


        public void update(object cod, object titulo)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "update tratamento set titulo=@tit where cod_tratamento=@cod;";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cod", cod);
            mycommand.Parameters.AddWithValue("@tit", titulo);            

            mycommand.ExecuteNonQuery();

            mycon.Close();

        }

        public void delete(object cod)
        {
            mycon.Open();
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "delete from tratamento where cod_tratamento=@cod;";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cod", cod);
            mycommand.ExecuteNonQuery();

            mycon.Close();
        }      


    }   
}
