using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_de_consultorio_odonto
{
    public partial class Tela_main : Form
    {
        public Tela_main()
        {
            InitializeComponent();
        }
        private void Tela_main_Load(object sender, EventArgs e)
        {

        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Cadastro_servicos cadServ = new Cadastro_servicos();
            cadServ.MdiParent = this;
            cadServ.Show();            
        }

        private void profissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_profss cadProfs = new Cadastro_profss();
            cadProfs.MdiParent = this;
            cadProfs.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_paciente cadPac = new Cadastro_paciente();
            cadPac.MdiParent = this;
            cadPac.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendador_consulta agCons = new Agendador_consulta();
            agCons.MdiParent = this;
            agCons.Show();
        }

        private void cadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLista tl = new TelaLista();
            tl.MdiParent = this;
            tl.Show();
        }

        private void Tela_main_Load_1(object sender, EventArgs e)
        {

        }
    }
}
