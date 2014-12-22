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
    public partial class Cadastro_servicos : Form
    {
        public Cadastro_servicos()
        {
            InitializeComponent();
        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            Servico myServ = new Servico();
            string desc;
            double preco=0;

           
            desc = textBoxDescr.Text;

            try
            {
                preco = Convert.ToDouble(maskedTextBoxPreco.Text);
            }
            catch (FormatException)
            {
                preco = 0;
            }

            if (desc.Equals("") || preco.Equals(0))
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro de validação",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                myServ.Descricao = desc;
                myServ.Preco = preco;

                DaoServico daoserv = new DaoServico();
                 daoserv.Save(myServ);

                MessageBox.Show("Dados salvos corretamente.");
                this.Dispose();
            }
           
        }

        private void labelPreco_Click(object sender, EventArgs e)
        {

        }
    }
}
