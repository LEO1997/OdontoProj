using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controle_de_consultorio_odonto.DAO;
using System.IO;

namespace Controle_de_consultorio_odonto.Formularios.Listagens
{
    public partial class SelectPacienteScrn : Form
    {
        public SelectPacienteScrn()
        {
            InitializeComponent();
        }
        
        private void SelectPacienteScrn_Load(object sender, EventArgs e)
        {
            DaoPaciente daoPac = new DaoPaciente();
            ComboBox combpac = comboBoxPac;
            combpac.DataSource = daoPac.list();//Pega as instâncias de Paciente.
            combpac.DisplayMember = "nome";
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (comboBoxPac.Text.Equals(""))
            {
                MessageBox.Show("Selecione um paciente.");
            }
            else
            {

                DaoConsulta daoConsulta = new DaoConsulta();
                
                FileInfo arq = new FileInfo(@"C:\Users\leonp_000\Desktop\" + comboBoxPac.Text + ".txt");
                StreamWriter file = new StreamWriter(arq.FullName, true);

                foreach (string str in daoConsulta.list(comboBoxPac.Text))
                {               
                    file.WriteLine(str);
                }

                file.Close();

                MessageBox.Show("Boleto gerado com sucesso", "Sucesso",
                                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
                this.Dispose();
            }
        }   

    }
}
