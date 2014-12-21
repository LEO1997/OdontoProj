using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Controle_de_consultorio_odonto.Classes_de_entidades;

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

        public void save(Tratamento tratamento)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "insert into tratamento(titulo, laudo, Paciente_cpf) values(@tit, @ld," +
                                     "(select cpf from paciente where nome=@pnm));";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@tit", tratamento.Titulo);
            mycommand.Parameters.AddWithValue("@ld", tratamento.Laudo);
            mycommand.Parameters.AddWithValue("@pnm", tratamento.Paciente);

            mycommand.ExecuteNonQuery();
            
            mycon.Close();
        }


        public void update(object cod, object titulo, object laudo)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "update tratamento set titulo=@tit, laudo=@ld where cod_tratamento=@cod;";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cod", cod);
            mycommand.Parameters.AddWithValue("@tit", titulo);
            mycommand.Parameters.AddWithValue("@ld", laudo);

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
