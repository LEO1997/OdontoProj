using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controle_de_consultorio_odonto.Classes_de_entidades;
using Controle_de_consultorio_odonto.DAO;

namespace Controle_de_consultorio_odonto
{
    public partial class Agendador_consulta : Form
    {
        public Agendador_consulta()
        {
            InitializeComponent();
            
            //Recebe valores das entidades do banco e exibe nas devidas comboboxes.
            DaoPaciente daoPac = new DaoPaciente();
            ComboBox combpac = comboBoxPaciente;
            combpac.DataSource = daoPac.listar();//Pega as instâncias de Paciente.
            combpac.DisplayMember = "nome";//Exibe apenas o valor de nome das instâncias.

            DaoProf daoProf = new DaoProf();
            ComboBox combprof = comboBoxProfissional;
            combprof.DataSource = daoProf.listar();//Pega as instâncias de Profissional.
            combprof.DisplayMember = "nome";//Exibe apenas o valor de nome das instâncias.
            
            DaoServico daoServ = new DaoServico();
            ComboBox combserv1 = comboBoxServ1;
            combserv1.DataSource = daoServ.listar();//Pega as instâncias de Servico.            
            combserv1.DisplayMember = "descricao";//Exibe apenas o valor de descricao das instâncias.
            DaoServico daoServ2 = new DaoServico();
            ComboBox combserv2 = comboBoxServ2;
            combserv2.DataSource = daoServ.listar();//Pega as instâncias de Servico.
            combserv2.DisplayMember = "descricao";//Exibe apenas o valor de descricao das instâncias. 
            //Recebe valores das entidades do banco e exibe nas devidas comboboxes.
        }

        private void buttonAgendar_Click(object sender, EventArgs e)
        {
            Consulta myConsulta = new Consulta();//Objeto para armazenar os valores de Consulta.
            Servico_has_Consulta myShc1 = new Servico_has_Consulta();//Objeto para armazenar os valores de Servico_has_Consulta.
            Servico_has_Consulta myShc2 = new Servico_has_Consulta();//Objeto para armazenar os valores de Servico_has_Consulta.

            string paciente, profissional;
            string servico1, servico2;
            int sala=0;
            DateTime dtaHr;
            string dtaHrS;

            paciente = comboBoxPaciente.Text;
            profissional = comboBoxProfissional.Text;
            servico1 = comboBoxServ1.Text;
            servico2 = comboBoxServ2.Text;
            try
            {
                sala = Convert.ToInt32(comboBoxSala.Text);//Converte o texto da combo em double.
            }
            catch (FormatException)//Se o texto não puder ser convertido adiciona-se um valor EQUIVALENTE a nulo.
            {
                sala = 0;
            }
            dtaHr = dateTimePicker1.Value;
            dtaHrS = dtaHr.ToString("yyyy-MM-dd/HH:mm:ss");
            dtaHrS = dtaHrS.Substring(0, 13) + ":00:00";//Transforma a data e hora em string e arredonda o horário.
                                                        //para evitar consultas muito próximas.

            //Se ainda houver campos a serem preenchidos, o programa não permite agendamento.
            if (paciente.Equals("") || profissional.Equals("") || sala.Equals(0) || dtaHr.Equals("")
                || (servico1.Equals("") && servico2.Equals("")))
            {
                MessageBox.Show("Preencha corretamente todos os campos!");

            }
            else
            {
                myConsulta.Dtahora = dtaHrS;
                myConsulta.Sala = sala;
                myConsulta.Pac = paciente;
                myConsulta.Prof = profissional;
                myConsulta.PrecoTotal = 0.50;//Taxa inicial da consulta;
                DaoConsulta daoconsulta = new DaoConsulta();
                 daoconsulta.Save(myConsulta);//Cadastra a consulta no bd.

                DaoServHasCons daoSHC = new DaoServHasCons();
                 if (myShc2.Equals(""))//Se a combobox de servico 2 não tiver nenhum valor visível.
                 {
                     myShc1.HoraConsulta = dtaHrS;
                     myShc1.DescServico = servico1;
                     daoSHC.Save(myShc1);//Vincula a consulta com o 1° serviço.
                     daoconsulta.adicionaPreco(servico1, dtaHrS);//Adiciona o preço do primeiro serviço à consulta.
                 }
                 else
                 {
                     if (myShc1.Equals(""))//Se a combobox de servico 1 não tiver nenhum valor visível.
                     {
                         myShc2.HoraConsulta = dtaHrS;
                         myShc2.DescServico = servico2;
                         daoSHC.Save(myShc2);//Vincula a consulta com o 2° serviço.
                         daoconsulta.adicionaPreco(servico2, dtaHrS);//Adiciona o preço do segundo serviço à consulta.
                     }
                     else//Se ambas apresentarem valores visíveis.
                     {
                         myShc1.HoraConsulta = dtaHrS;
                         myShc1.DescServico = servico1;
                         myShc2.HoraConsulta = dtaHrS;
                         myShc2.DescServico = servico2;
                         daoSHC.Save(myShc1);//Vincula a consulta com o 1° serviço.
                         daoSHC.Save(myShc2);//Vincula a consulta com o 2° serviço.
                         daoconsulta.adicionaPreco(servico1, dtaHrS);//Adiciona o preço do primeiro serviço à consulta.
                         daoconsulta.adicionaPreco(servico2, dtaHrS);//Adiciona o preço do segundo serviço à consulta.
                     }
                 }
                
                MessageBox.Show("Dados salvos corretamente.");
                this.Dispose();
            }
        }

        private void Agendador_consulta_Load(object sender, EventArgs e)
        {

        }
        

    }
}
