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

        public ArrayList list(String paciente)
        {
            ArrayList codigos = new ArrayList();//arraylist para retorno dos valores(codigos).
            ArrayList dados = new ArrayList();

            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "Select * from Consulta where paciente_cpf=" +
                                    "(select cpf from paciente where nome=@nm);";
            mycommand.Parameters.AddWithValue("@nm", paciente);

            mydr = mycommand.ExecuteReader();
            while (mydr.Read())
            {                
                codigos.Add(mydr.GetString("codigo"));
            }
            mydr.Close();

            string profissionais = "Atendido pelo drs.: " + getProfissionais(codigos);
            dados.Add(profissionais);
            string servicos = "Serviços prestados: " + getServicos(codigos);
            dados.Add(servicos);
            string tratamentos = "Tratamentos fornecidos: " + getTratamentos(codigos);
            dados.Add(tratamentos);
            string datas = "Datas: " + getDatas(codigos);
            dados.Add(datas);
            string salas = "Salas de atendimento: " + getSalas(codigos);
            dados.Add(salas);
            string precos = "Preço total a pagar: R$" + Convert.ToString(getFullPrice(codigos));
            dados.Add(precos);

            mycon.Close();

            return dados;
        }



        private double getFullPrice(ArrayList codigos)
        {
            double resultado=0;

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            foreach (string codigo in codigos)
            {                
                mycommand.CommandText = "Select * from servico where cod_servico=" +
                                        "(select servico_cod_servico from Consulta where codigo=@cod);";
                mycommand.Parameters.Clear();
                mycommand.Parameters.AddWithValue("@cod", codigo);
                mydr = mycommand.ExecuteReader();
                mydr.Read();
                resultado += Convert.ToDouble(mydr.GetString("preco"));
                mydr.Close();
            }

            return resultado;
        }

        private string getServicos(ArrayList codigos)
        {
            string resultado = "";
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            foreach (string codigo in codigos)
            {
                mycommand.CommandText = "Select * from servico where cod_servico=" +
                                        "(select servico_cod_servico from Consulta where codigo=@cod);";
                mycommand.Parameters.Clear();
                mycommand.Parameters.AddWithValue("@cod", codigo);
                mydr = mycommand.ExecuteReader();
                mydr.Read();
                resultado += mydr.GetString("descricao") + "(R$" + mydr.GetString("preco") + "), ";
                mydr.Close();
            }

            return resultado;
        }

        private string getProfissionais(ArrayList codigos)
        {
            string resultado = "";
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            foreach (string codigo in codigos)
            {
                mycommand.CommandText = "Select * from profissional where cro=" +
                                        "(select profissional_cro from Consulta where codigo=@cod);";
                mycommand.Parameters.Clear();
                mycommand.Parameters.AddWithValue("@cod", codigo);
                mydr = mycommand.ExecuteReader();
                mydr.Read();
                resultado += mydr.GetString("nome") + ", ";
                mydr.Close();
            }

            return resultado;
        }

        private string getDatas(ArrayList codigos)
        {
            string resultado = "";
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            foreach (string codigo in codigos)
            {
                mycommand.CommandText = "Select * from Consulta where codigo=@cod;";
                mycommand.Parameters.Clear();
                mycommand.Parameters.AddWithValue("@cod", codigo);
                mydr = mycommand.ExecuteReader();
                mydr.Read();
                resultado += mydr.GetString("data_hora") + " - ";
                mydr.Close();
            }

            return resultado;
        }

        private string getSalas(ArrayList codigos)
        {
            string resultado = "";
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            foreach (string codigo in codigos)
            {
                mycommand.CommandText = "Select * from Consulta where codigo=@cod;";
                mycommand.Parameters.Clear();
                mycommand.Parameters.AddWithValue("@cod", codigo);
                mydr = mycommand.ExecuteReader();
                mydr.Read();
                resultado += mydr.GetString("sala") + ", ";
                mydr.Close();
            }

            return resultado;
        }

        private string getTratamentos(ArrayList codigos)
        {
            string resultado = "";
            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            foreach (string codigo in codigos)
            {
                mycommand.CommandText = "Select * from tratamento where cod_tratamento=" +
                                        "(select tratamento_cod_tratamento from Consulta where codigo=@cod);";
                mycommand.Parameters.Clear();
                mycommand.Parameters.AddWithValue("@cod", codigo);
                mydr = mycommand.ExecuteReader();

                try
                {
                    mydr.Read();
                    resultado += mydr.GetString("titulo") + " - ";
                }
                catch (MySqlException)
                {
                    resultado += "";
                }                
                mydr.Close();
            }

            return resultado;
        }
       
    }
}
