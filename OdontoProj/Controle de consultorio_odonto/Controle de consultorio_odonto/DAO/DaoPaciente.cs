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

        public void update(object cpf, object name, object nasc, object end, object tel)
        {           
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "update paciente set nome=@nm, nascimento=@nasc, endereco=@end, telefone=@tel " +
                                    "where cpf=@cpf;";

            mycommand.Parameters.AddWithValue("@cpf", cpf);
            mycommand.Parameters.AddWithValue("@nm", name);
            mycommand.Parameters.AddWithValue("@nasc", nasc);
            mycommand.Parameters.AddWithValue("@end", end);
            mycommand.Parameters.AddWithValue("@tel", tel);

            mycommand.ExecuteNonQuery();

            mycon.Close();

        }

        public void delete(object cpf)
        {
            mycon.Open();
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "delete from paciente where cpf=@cpf;";

            mycommand.Parameters.Clear();
            mycommand.Parameters.AddWithValue("@cpf", cpf);
            mycommand.ExecuteNonQuery();

            mycon.Close();
        }       

        public ArrayList list()
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
