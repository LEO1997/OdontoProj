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
    class DaoServico
    {
        private string conexao;
        private MySqlConnection mycon;
        private MySqlCommand mycommand;
        private MySqlDataReader mydr;

        public DaoServico()
        {
            conexao = DataStore.Conexao;       
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

        public void update(object cod, object desc, object preco)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "update servico set descricao=@dsc , preco=@prc where cod_servico=@cod;";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cod", cod);
            mycommand.Parameters.AddWithValue("@dsc", desc);
            mycommand.Parameters.AddWithValue("@prc", preco);            

            mycommand.ExecuteNonQuery();

            mycon.Close();
        }

        public void delete(object cod)
        {
            mycon.Open();
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "delete from servico where cod_servico=@cod;";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cod", cod);
            mycommand.ExecuteNonQuery();

            mycon.Close();
        }        

        public ArrayList listar()
        {            
            //Variável que indentifica cada instância da entidade e armazena seus valores.
            ArrayList array = new ArrayList();//arraylist para retorno dos valores(nomes).
                                
            mycon.Open();
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "Select * from Servico;";
           
            mydr = mycommand.ExecuteReader();
            while (mydr.Read())
            {
                array.Add(mydr.GetString("descricao"));//Adiciona os valores descricao de cada instância da entidade Servico.
            }
           
            mycon.Close();

            return array;
        }

        public ArrayList getServico(string desc)//Pega individualmente um serviço.
        {                        
            ArrayList array = new ArrayList();

            mycon.Open();            
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "Select * from Servico where descricao='" + desc + "';";
            
            mydr = mycommand.ExecuteReader();
            while (mydr.Read())
            {
                array.Add("Nome: " + mydr.GetString("descricao") + "\nCódigo: " + mydr.GetString("cod_servico")
                    + "\nPreço: R$" + mydr.GetString("preco"));
            }
           
            mycon.Close();

            return array;
        }
    }
}
