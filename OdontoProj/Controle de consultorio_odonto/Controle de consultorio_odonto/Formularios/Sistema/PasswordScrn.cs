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
                MessageBox.Show("Conexão não estabelecida \n por favor tente novamente");
            }

            if (mycon.State == ConnectionState.Open)
            {
                DataStore.Password = password;
                DataStore.Conexao = conexao;
                this.Dispose();
            }          
        }
    }
}
