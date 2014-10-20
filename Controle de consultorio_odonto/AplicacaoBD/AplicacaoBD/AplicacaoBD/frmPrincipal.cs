using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicacaoBD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuPalestrante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicou em palestrante");
        }

        private void mnuAlunos_Click(object sender, EventArgs e)
        {
            //criacao de um objeto formulario de alunos
            Form1 frm = new Form1();
            //definir o formulario principal como MDI Pai
            frm.MdiParent = this;
            //mostrar o formulario de alunos
            frm.Show();
        }
    }
}
