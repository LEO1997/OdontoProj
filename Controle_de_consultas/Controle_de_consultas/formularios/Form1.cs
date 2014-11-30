using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controle_de_consultas.formularios;

namespace Controle_de_consultas
{
    public partial class InitScrn : Form
    {
        public InitScrn()
        {
            InitializeComponent();
        }

        private void InitScrn_Load(object sender, EventArgs e)
        {
            PasswordScrn ps = new PasswordScrn();
             ps.MdiParent = this;
             ps.Show();
        }
    }
}
