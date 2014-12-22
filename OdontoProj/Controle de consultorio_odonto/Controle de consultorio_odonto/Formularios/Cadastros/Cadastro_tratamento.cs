using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controle_de_consultorio_odonto.DAO;
using Controle_de_consultorio_odonto.Classes_de_entidades;

namespace Controle_de_consultorio_odonto.Formularios.Cadastros
{
    public partial class Cadastro_tratamento : Form
    {
        public Cadastro_tratamento()
        {
            InitializeComponent();
        }

        private void labelPac_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_tratamento_Load(object sender, EventArgs e)
        {
            DaoPaciente daoPac = new DaoPaciente();
            ComboBox combpac = comboBoxPac;
            combpac.DataSource = daoPac.list();//Pega as instâncias de Paciente.
            combpac.DisplayMember = "nome";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Tratamento tratamento = new Tratamento();
            string titulo = textBoxTitulo.Text;
            string paciente = comboBoxPac.Text;
            string laudo = textBoxLaudo.Text;

            if (titulo.Equals("") || paciente.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro de validação",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else
            {
                if (laudo.Equals("") || laudo.Length < 30)
                {
                    MessageBox.Show("Informe o laudo para liberar o tratamento.", "Erro de validação",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;                  
                }
                else
                {
                    tratamento.Laudo = laudo;
                    tratamento.Titulo = titulo;
                    tratamento.Paciente = paciente;
                    DaoTratamento daoTrat = new DaoTratamento();
                    daoTrat.save(tratamento);

                    MessageBox.Show("Dados salvos corretamente.");
                    this.Dispose();
                }
            }
        }
    }
}
