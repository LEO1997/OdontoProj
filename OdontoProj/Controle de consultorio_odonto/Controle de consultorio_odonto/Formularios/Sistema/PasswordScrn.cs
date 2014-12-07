using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controle_de_consultorio_odonto.DAO;
using Controle_de_consultorio_odonto.Formularios.Sistema;

namespace Controle_de_consultorio_odonto.Formularios
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String password = textBoxPass.Text;
            String conexao = "server=localhost;userid=root;password=" + password + ";database=Consultorio_odonto;";

            MySqlConnection mycon = new MySqlConnection(conexao);

            try
            {
                mycon.Open();
            }
            catch
            {
                MessageBox.Show("SENHA DE ACESSO INCORRETA");
                textBoxPass.Text = "";
                textBoxPass.Focus();
            }

            if (mycon.State == ConnectionState.Open)
            {                
                DataStore.Conexao = conexao;
                
                this.Hide();

                WelcomeScrn ws = new WelcomeScrn();
                 ws.ShowDialog();

                this.Close();
                this.Dispose();
            }          
        }
    }
}
