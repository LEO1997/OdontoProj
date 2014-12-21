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
            
                      
        }

        public Agendador_consulta(string tituloDeTratamento)
        {
            InitializeComponent();
            this.labelTrat.Text = tituloDeTratamento;
        }

        private void buttonAgendar_Click(object sender, EventArgs e)
        {
            Consulta myConsulta = new Consulta();//Objeto para armazenar os valores de Consulta.         

            string paciente, profissional;
            string servico1;
            int sala=0;
            DateTime dtaHr;
            string dtaHrS;
            string tratamento;

            paciente = comboBoxPaciente.Text;
            profissional = comboBoxProfissional.Text;
            servico1 = comboBoxServ1.Text;            
            tratamento = labelTrat.Text;
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
                || (servico1.Equals("")))
            {
                MessageBox.Show("Preencha corretamente todos os campos!");

            }
            else
            {
                myConsulta.Dtahora = dtaHrS;
                myConsulta.Sala = sala;
                myConsulta.Pac = paciente;
                myConsulta.Prof = profissional;
                myConsulta.Serv = servico1;
                myConsulta.Trat = tratamento;
                DaoConsulta daoconsulta = new DaoConsulta();
                 daoconsulta.Save(myConsulta);//Cadastra a consulta no bd.                                                  
                                                  
                
                MessageBox.Show("Dados salvos corretamente.");
                this.Dispose();
            }
        }

        private void Agendador_consulta_Load(object sender, EventArgs e)
        {
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
        }

        private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTrat_Enter(object sender, EventArgs e)
        {

        }        
        

    }
}
