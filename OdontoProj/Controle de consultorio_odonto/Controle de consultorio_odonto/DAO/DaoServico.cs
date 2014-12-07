using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Controle_de_consultorio_odonto.Classes_de_entidades;
using System.Collections;

namespace Controle_de_consultorio_odonto.DAO
{
    class DaoServico
    {
        private MySqlConnection mycon;
        private MySqlCommand mycommand;

        public DaoServico()
        {
            String conexao = DataStore.Conexao;
           
            mycon = new MySqlConnection(conexao);           
        }

        public void Save(Servico myServ)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "insert into servico(descricao, preco) values(@dsc,@prc)";
            mycommand.Parameters.AddWithValue("@dsc", myServ.Descricao);
            mycommand.Parameters.AddWithValue("@prc", myServ.Preco);
            mycommand.Prepare();
            mycommand.ExecuteNonQuery();
            mycon.Close();
        }

        public ArrayList listar()
        {
            String strconexao;
            MySqlDataReader dr;//Variável que indentifica cada instância da entidade e armazena seus valores.
            ArrayList array = new ArrayList();//arraylist para retorno dos valores(nomes).

            strconexao = DataStore.Conexao;
            //strconexao = "server=localhost;userid=root;password=superiorclock;database=Consultorio_odonto;";
            MySqlConnection con = new MySqlConnection(strconexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Servico;";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                array.Add(dr.GetString("descricao"));//Adiciona os valores descricao de cada instância da entidade Servico.
            }
            con.Close();

            return array;
        }

        public ArrayList getServico(string desc)//Pega individualmente um serviço.
        {
            String strconexao;
            MySqlDataReader dr;
            ArrayList array = new ArrayList();

            strconexao = DataStore.Conexao;
            MySqlConnection con = new MySqlConnection(strconexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Servico where descricao='" + desc + "';";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                array.Add("Nome: " + dr.GetString("descricao") + "\nCódigo: " + dr.GetString("cod_servico")
                    + "\nPreço: R$" + dr.GetString("preco"));
            }
            con.Close();

            return array;
        }
    }
}
