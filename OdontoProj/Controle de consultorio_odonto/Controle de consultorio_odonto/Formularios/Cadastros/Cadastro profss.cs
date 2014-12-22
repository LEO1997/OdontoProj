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
    public partial class Cadastro_profss : Form
    {
        public Cadastro_profss()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Profissional myProf = new Profissional();
            string nome, cro, telefone, espc;
                           
                nome = textBoxNome.Text;
                cro = textBoxCro.Text;
                telefone = maskedTextBoxTel.Text;
                espc = "";

                if (checkBoxCiru.Checked)
                {
                    espc = espc + checkBoxCiru.Text + "/";
                }
                if (checkBoxPD.Checked)
                {
                    espc = espc + checkBoxPD.Text + "/";
                }
                if (checkBoxPero.Checked)
                {
                    espc = espc + checkBoxPero.Text + "/";
                }
                if (checkBoxOrto.Checked)
                {
                    espc = espc + checkBoxOrto.Text + "/";
                }
                if (checkBoxOP.Checked)
                {
                    espc = espc + checkBoxOP.Text + "/";
                }
                if (checkBoxRad.Checked)
                {
                    espc = espc + checkBoxRad.Text + "/";
                }

               

                if (nome.Equals("") || cro.Equals("") || telefone.Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "Erro de validação",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                }
                else
                {
                    myProf.Cro = cro;
                    myProf.Nome = nome;
                    myProf.Telefone = telefone;
                    myProf.Especializacao = espc;

                   DaoProf daoprof = new DaoProf();
                    daoprof.Save(myProf);

                   MessageBox.Show("Dados salvos corretamente."); 
                   this.Dispose();
                }
           
        }
    }
}
