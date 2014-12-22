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
    public partial class Cadastro_paciente : Form
    {
        public Cadastro_paciente()
        {
            InitializeComponent();
        }

        private void labelEnd_Click(object sender, EventArgs e)
        {

        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            Paciente myPaciente = new Paciente();
            string cpf, nome, nascimento, endereco, telefone;

            cpf = maskedTextBox1.Text;
            nome = textBoxNome.Text;
            nascimento = maskedTextBoxNasc.Text;
            endereco = textBoxEnd.Text;
            telefone = maskedTextBoxTel.Text;

            if (cpf.Equals("") || nome.Equals("") || nascimento.Equals("") || endereco.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro de validação",
                                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                myPaciente.Cpf = cpf;
                myPaciente.Nome = nome;
                myPaciente.Nascimento = nascimento;
                myPaciente.Endereco = endereco;
                myPaciente.Telefone = telefone;

                DaoPaciente daoPaciente = new DaoPaciente();
                 daoPaciente.Save(myPaciente);

                MessageBox.Show("Dados salvos corretamente.");
                this.Dispose();
            }
        }
    }
}
