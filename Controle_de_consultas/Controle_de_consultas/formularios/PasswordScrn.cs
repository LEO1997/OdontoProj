using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_de_consultas.formularios
{
    public partial class PasswordScrn : Form
    {
        public PasswordScrn()
        {
            InitializeComponent();
        }

        private void PasswordScrn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PassBox.Text);
        }
    }
}
