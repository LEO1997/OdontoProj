﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Controle_de_consultorio_odonto.Classes_de_entidades;
using System.Collections;

namespace Controle_de_consultorio_odonto.DAO
{
    class DaoConsulta
    {
        private MySqlConnection mycon;//variável que estabelece conexão com o bd;
        private MySqlCommand mycommand;//armazena o comando a ser executado;

        public DaoConsulta()
        {
            String conexao = "server=localhost;userid=root;password=superiorclock;database=Consultorio_odonto;";
            
            mycon = new MySqlConnection(conexao);           
        }

        public void Save(Consulta myCons)
        {
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;//Vincula comado de execução com a variável de conexão.
            mycommand.CommandText = "insert into consulta(data_hora, sala, Paciente_cpf, Profissional_cro, preco_total)" + 
                                    "values(@dth,@sl,(select cpf from Paciente where nome='" + myCons.Pac + "')," +
                                    "(select cro from Profissional where nome='" + myCons.Prof + "'),@prt)";
            mycommand.Parameters.AddWithValue("@dth", myCons.Dtahora);
            mycommand.Parameters.AddWithValue("@sl", myCons.Sala);            
            mycommand.Parameters.AddWithValue("@prt", myCons.PrecoTotal);            
            mycommand.Prepare();
            mycommand.ExecuteNonQuery();
            mycon.Close();
        }

        public void adicionaPreco(string descservico, string dtahora)//Função para adicionar os precos do serviço à
        {                                                            //consulta
            mycon.Open();

            mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = "update Consulta set preco_total=preco_total + " +
                                     "(select preco from Servico where descricao='" + descservico + 
                                     "') where Consulta.data_hora='" + dtahora + "';" ; //Incrementa o valor da consulta com o preço do serviço.
            mycommand.Prepare();
            mycommand.ExecuteNonQuery();
            mycon.Close();
        }

        public ArrayList getConsulta(string nomePac)//Retorna consultas realizadas por determindao paciente.
        {
            String strconexao;
            MySqlDataReader dr;
            MySqlDataReader dr2;
            MySqlDataReader dr3;
            MySqlDataReader dr4;
            ArrayList array = new ArrayList();

            strconexao = "server=localhost;userid=root;password=;database=Consultorio_odonto";
            

            MySqlConnection con = new MySqlConnection(strconexao);       
            MySqlConnection con2 = new MySqlConnection(strconexao);
            MySqlConnection con3 = new MySqlConnection(strconexao);
            MySqlConnection con4 = new MySqlConnection(strconexao);
            con.Open();
            con2.Open();
            con3.Open();
            con4.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlCommand cmd3 = new MySqlCommand();
            MySqlCommand cmd4 = new MySqlCommand();
            cmd.Connection = con;
            cmd2.Connection = con2;
            cmd3.Connection = con3;
            cmd4.Connection = con4;

            cmd.CommandText = "Select * from Consulta, Paciente where Paciente_cpf=" +
                               "(select cpf from Paciente where nome ='" + nomePac + "');";
            
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmd2.CommandText = "Select * from Paciente, Consulta where cpf=" + dr.GetString("Paciente_cpf") + ";";
                dr2 = cmd2.ExecuteReader();
                dr2.Read();
                string pacnome = dr2.GetString("nome");

                cmd3.CommandText = "Select * from Profissional, Consulta where cro=" + dr.GetString("Profissional_cro") + ";";
                dr3 = cmd3.ExecuteReader();
                dr3.Read();
                string profnome = dr3.GetString("nome");

                cmd4.CommandText = "Select * from Servico, Servico_has_Consulta where cod_servico=" +
                                   "(select servico_cod_servico from Servico_has_Consulta where Consulta_codigo='" + dr.GetString("codigo") + "' limit 1);";
                ArrayList arr = new ArrayList();//ArrayList para adicionar valores de descrição dos serviços da consulta.
                dr4 = cmd4.ExecuteReader();            
                while (dr4.Read())
                {
                    arr.Add(dr4.GetString("descricao"));
                }

                string str = ("Código: " + dr.GetString("codigo") + "\nData e hora: " + dr.GetString("data_hora")
                    + "\nSala: " + dr.GetString("sala")
                    + "\nPaciente: " + pacnome  + "\nProfissional: " + profnome
                    + "\nServiços: " + arr[0] + "-"
                    + "\nPreço total: R$" + dr.GetString("preco_total"));

                array.Add(str);
            }
            con.Close();

            return array;
        }
    }
}