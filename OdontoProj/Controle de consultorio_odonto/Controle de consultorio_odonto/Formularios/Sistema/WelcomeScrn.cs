using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controle_de_consultorio_odonto.Formularios.Listagens;
using Controle_de_consultorio_odonto.Formularios.Cadastros;

namespace Controle_de_consultorio_odonto.Formularios.Sistema
{
    public partial class WelcomeScrn : Form
    {
        public WelcomeScrn()
        {
            InitializeComponent();
        }

        private void WelcomeScrn_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {

        }


//ToolStripMenuItens de Cadastro------------------------------------------------------------------||
        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_servicos cadServ = new Cadastro_servicos();            
            cadServ.Show();    
        }

        private void profissionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Cadastro_profss cadProf = new Cadastro_profss();
            cadProf.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_paciente cadPac = new Cadastro_paciente();
             cadPac.Show();
        }

//Eventos dos botões------------------------------------------------------------------------------||
        private void pictBoxSearch_Click_1(object sender, EventArgs e)
        {
            ListScrn ls = new ListScrn();
            ls.Show();
        }

        private void pictBoxSerch_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipSearch = new ToolTip();
            toolTipSearch.SetToolTip(this.pictBoxSearch, "Consulta e alteração de dados");
        }

        private void pictBoxSchedule_Click(object sender, EventArgs e)
        {
            Agendador_consulta agendaConsulta = new Agendador_consulta();
            agendaConsulta.Show();
        }

        private void pictBoxSchedule_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipSchedule = new ToolTip();
            toolTipSchedule.SetToolTip(this.pictBoxSchedule, "Agendamento de consultas");
        }       
//ToolStripMenuItens de Cadastro------------------------------------------------------------------||

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoTratamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_tratamento cadTrat = new Cadastro_tratamento();
              cadTrat.Show();
        }

       
        
    }
}
