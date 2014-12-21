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
    class DaoProf
    {
        private MySqlConnection mycon;//variável que estabelece conexão com o bd;
        private MySqlCommand mycommand;//armazena o comando a ser executado;
        private MySqlDataReader mydr;

        public DaoProf()
        {
            String conexao = DataStore.Conexao;            
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

        public void update(object cro, object nome, object tel, object esp)
        {            
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "update profissional set nome=@nm, telefone=@tel, especializacao=@esp " +
                                      "where cro=@cro;"; 

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cro", cro);
            mycommand.Parameters.AddWithValue("@nm", nome);
            mycommand.Parameters.AddWithValue("@tel", tel);
            mycommand.Parameters.AddWithValue("@esp", esp);            

            mycommand.ExecuteNonQuery();

            mycon.Close();

        }

        public void delete(object cro)
        {
            mycon.Open();
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "delete from profissional where cro=@cro;";  

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cro", cro);
            mycommand.ExecuteNonQuery();

            mycon.Close();
        }       


        public ArrayList listar()
        {                        
            ArrayList array = new ArrayList();//arraylist para retorno dos valores(nomes).         
            
            mycon.Open();
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "Select * from Profissional;";
           
            mydr = mycommand.ExecuteReader();
            while (mydr.Read())
            {
                array.Add(mydr.GetString("nome"));//Adiciona os valores nomes de cada instância da entidade Profissional.
            }
           
            mycon.Close();

            return array;
        }

        public ArrayList getProfs(string nome)//retorna os valores das instâncias de Profissional que apresentam
        {                                     //o nome do parâmetro.                       
            ArrayList array = new ArrayList();
            
            mycon.Open();
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "Select * from Profissional where nome='" + nome + "';";
            
            mydr = mycommand.ExecuteReader();            
            while (mydr.Read())
            {
                array.Add("Nome: " + mydr.GetString("nome") + "\nCRO: " + mydr.GetString("cro")
                    + "\nEspecialização: " + mydr.GetString("especializacao")
                    + "\nTelefone: " + mydr.GetString("telefone"));
            }
            
            mycon.Close();

            return array;
        }
    }
}
