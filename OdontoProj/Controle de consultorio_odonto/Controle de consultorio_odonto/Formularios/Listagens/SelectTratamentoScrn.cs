using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controle_de_consultorio_odonto.DAO;

namespace Controle_de_consultorio_odonto.Formularios.Listagens
{
    public partial class SelectTratamentoScrn : Form
    {
        public SelectTratamentoScrn()
        {
            InitializeComponent();
        }

        private void SelectTratamentoScrn_Load(object sender, EventArgs e)
        {
            DaoPaciente daoPac = new DaoPaciente();
            ComboBox combpac = comboBoxPac;
            combpac.DataSource = daoPac.list();//Pega as instâncias de Paciente.
            combpac.DisplayMember = "nome";
        }

        private void comboBoxPac_SelectedIndexChanged(object sender, EventArgs e)
        {
            DaoTratamento daoTrat = new DaoTratamento();
            ComboBox combTrat = comboBoxTrat;
            combTrat.DataSource = daoTrat.list(comboBoxPac.Text);
            combTrat.DisplayMember = "titulo";

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxTrat.Text.Equals(""))
            {
                MessageBox.Show("Selecione um tratamento para adicionar consultas.");
            }
            else
            {                
                Agendador_consulta agendaConsultas = new Agendador_consulta(comboBoxTrat.Text);
                agendaConsultas.Show();
                this.Dispose();
            }
        }
    }
}
