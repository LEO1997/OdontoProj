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

        public DaoPaciente()
        {
            String conexao = "server=localhost;userid=root;password=;database=Consultorio_odonto;";
            
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
            String strconexao;
            MySqlDataReader dr;//Variável que indentifica cada instância da entidade e armazena seus valores.
            ArrayList array = new ArrayList();//arraylist para retorno dos valores(nomes).
            
            strconexao = "server=localhost;userid=root;password=;database=Consultorio_odonto";
            
            MySqlConnection con = new MySqlConnection(strconexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Paciente;";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                array.Add(dr.GetString("nome"));//Adiciona os valores nome de cada instância da entidade Paciente.
            }
            con.Close();

            return array;
        }

        public ArrayList getPaciente(string nome)
        {
            String strconexao;
            MySqlDataReader dr;
            ArrayList array = new ArrayList();

            strconexao = "server=localhost;userid=root;password=;database=Consultorio_odonto";
            
            MySqlConnection con = new MySqlConnection(strconexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Paciente where nome='" + nome + "';";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                array.Add("Nome: " + dr.GetString("nome") + "\nCPF: " + dr.GetString("cpf")
                    + "\nNascimento: " + dr.GetString("nascimento") + "\nEndereço: " + dr.GetString("endereco")
                    + "\nTelefone: " + dr.GetString("telefone"));
            }
            con.Close();

            return array;
        }
    }
}
