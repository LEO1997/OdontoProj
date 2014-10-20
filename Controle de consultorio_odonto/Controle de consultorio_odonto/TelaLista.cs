using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controle_de_consultorio_odonto.DAO;
using System.Collections;

namespace Controle_de_consultorio_odonto
{
    public partial class TelaLista : Form
    {
        public TelaLista()
        {
            InitializeComponent();
        }

        private void buttonPac_Click(object sender, EventArgs e)
        {

            DaoPaciente daoPac = new DaoPaciente();
            ArrayList arry = daoPac.getPaciente(textBoxPac.Text);
            if (arry.Count == 0)
            {
                MessageBox.Show("Paciente não cadastrado.");
                textBoxPac.Text = "";
            }
            else
            {
                foreach (string i in arry)
                {
                    MessageBox.Show(i);
                }
                textBoxPac.Text = "";
            }
        }

        private void buttonProf_Click(object sender, EventArgs e)
        {
            DaoProf daoProf = new DaoProf();
            ArrayList arry = daoProf.getProfs(textBoxProf.Text);
            if (arry.Count == 0)
            {
                MessageBox.Show("Profissional não cadastrado.");
                textBoxProf.Text = "";
            }
            else
            {
                foreach (string i in arry)
                {
                    MessageBox.Show(i);
                }
                textBoxProf.Text = "";
            }
        }

        private void buttonServ_Click(object sender, EventArgs e)
        {
            DaoServico daoServ = new DaoServico();
            ArrayList arry = daoServ.getServico(textBoxServ.Text);
            if (arry.Count == 0)
            {
                MessageBox.Show("Serviço indisponível.");
                textBoxServ.Text = "";
            }
            else
            {
                foreach (string i in arry)
                {
                    MessageBox.Show(i);
                }
                textBoxServ.Text = "";
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            DaoConsulta daoCons = new DaoConsulta();
            ArrayList arry = daoCons.getConsulta(textBoxConsulta.Text);
            if (arry.Count == 0)
            {
                MessageBox.Show("Consulta inexistente.");
                textBoxConsulta.Text = "";
            }
            else
            {
                foreach (string i in arry)
                {
                    MessageBox.Show(i);
                }
                textBoxConsulta.Text = "";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
