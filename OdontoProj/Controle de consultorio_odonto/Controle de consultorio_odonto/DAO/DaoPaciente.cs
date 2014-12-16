using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Controle_de_consultorio_odonto.Classes_de_entidades;
using System.Collections;

namespace Controle_de_consultorio_odonto.DAO
{
    class DaoPaciente
    {
        private MySqlConnection mycon;//variável que estabelece conexão com o bd;
        private MySqlCommand mycommand;//armazena o comando a ser executado;
        private MySqlDataReader mydr;

        public DaoPaciente()
        {
            String conexao = DataStore.Conexao;            
            mycon = new MySqlConnection(conexao);
        }

        public void Save(Paciente myPac)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "insert into paciente(cpf, nome, nascimento, endereco, telefone) values(@cpf,@nm,@nasc,@end,@tel)";
            mycommand.Parameters.AddWithValue("@cpf", myPac.Cpf);
            mycommand.Parameters.AddWithValue("@nm", myPac.Nome);
            mycommand.Parameters.AddWithValue("@nasc", myPac.Nascimento);
            mycommand.Parameters.AddWithValue("@end", myPac.Endereco);
            mycommand.Parameters.AddWithValue("@tel", myPac.Telefone);
            mycommand.Prepare();
            mycommand.ExecuteNonQuery();
            mycon.Close();
        }

        public ArrayList listar()
        {            
            ArrayList array = new ArrayList();//arraylist para retorno dos valores(nomes).
                 
            mycon.Open();
            
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "Select * from Paciente;";

            mydr = mycommand.ExecuteReader();
            while (mydr.Read())
            {
                array.Add(mydr.GetString("nome"));//Adiciona os valores nome de cada instância da entidade Paciente.
            }
            
            mycon.Close();

            return array;
        }

        public ArrayList getPaciente(string nome)
        {
            ArrayList array = new ArrayList();
                                            
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "Select * from Paciente where nome='" + nome + "';";
            
            mydr = mycommand.ExecuteReader();
            while (mydr.Read())
            {
                array.Add("Nome: " + mydr.GetString("nome") + "\nCPF: " + mydr.GetString("cpf")
                    + "\nNascimento: " + mydr.GetString("nascimento") + "\nEndereço: " + mydr.GetString("endereco")
                    + "\nTelefone: " + mydr.GetString("telefone"));
            }
            
            mycon.Close();

            return array;
        }
    }
}
