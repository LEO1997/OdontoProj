using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Controle_de_consultorio_odonto.Classes_de_entidades;
using System.Collections;

namespace Controle_de_consultorio_odonto.DAO
{
    class DaoProf
    {
        private MySqlConnection mycon;//variável que estabelece conexão com o bd;
        private MySqlCommand mycommand;//armazena o comando a ser executado;

        public DaoProf()
        {
            String conexao = "server=localhost;userid=root;password=superiorclock;database=Consultorio_odonto;";
            
            mycon = new MySqlConnection(conexao);           
        }

        public void Save(Profissional myProf)
        {
            mycon.Open();//Abrea a conexão com o bd usando a string de conexão.

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "insert into profissional(cro, nome, telefone, especializacao) values(@cro,@nm,@tel,@esp)";
            mycommand.Parameters.AddWithValue("@cro", myProf.Cro);
            mycommand.Parameters.AddWithValue("@nm", myProf.Nome);
            mycommand.Parameters.AddWithValue("@tel", myProf.Telefone);
            mycommand.Parameters.AddWithValue("@esp", myProf.Especializacao);
            mycommand.Prepare();
            mycommand.ExecuteNonQuery();
            mycon.Close();
        }

        public ArrayList listar()
        {
            String strconexao;
            MySqlDataReader dr;//Variável que indentifica cada instância da entidade e armazena seus valores.
            ArrayList array = new ArrayList();//arraylist para retorno dos valores(nomes).

            strconexao = "server=localhost;userid=root;password=;database=Consultorio_odonto";
            
            MySqlConnection con = new MySqlConnection(strconexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Profissional;";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                array.Add(dr.GetString("nome"));//Adiciona os valores nomes de cada instância da entidade Profissional.
            }
            con.Close();

            return array;
        }

        public ArrayList getProfs(string nome)//retorna os valores das instâncias de Profissional que apresentam
        {                                     //o nome do parâmetro.
            String strconexao;
            MySqlDataReader dr;
            ArrayList array = new ArrayList();

            strconexao = "server=localhost;userid=root;password=;database=Consultorio_odonto";
            
            MySqlConnection con = new MySqlConnection(strconexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Profissional where nome='" + nome + "';";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                array.Add("Nome: " + dr.GetString("nome") + "\nCRO: " + dr.GetString("cro")
                    + "\nEspecialização: " + dr.GetString("especializacao")
                    + "\nTelefone: " + dr.GetString("telefone"));
            }
            con.Close();

            return array;
        }
    }
}
