using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidade;
using MySql.Data.MySqlClient;


namespace AplicacaoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome, turma, modalidade, email, telefone;
            Aluno meualuno;

            nome = txtnome.Text;
            turma = txtturma.Text;
            modalidade = cmbmodalidade.Text;
            email = txtemail.Text;
            telefone = txttelefone.Text;

            meualuno = new Aluno();
            meualuno.Nome = nome;
            meualuno.Turma = turma;
            meualuno.Modalidade = modalidade;
            meualuno.Email = email;
            meualuno.Telefone = telefone;
            
            string conexao = "server=localhost;userid=root;password=cachorro;database=bdjinf;";
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();          
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into aluno (nome,turma,email,modalidade,telefone) values (@nm,@tm,@em,@md,@tel)";
            cmd.Parameters.AddWithValue("@nm",meualuno.Nome);
            cmd.Parameters.AddWithValue("@tm", meualuno.Turma);
            cmd.Parameters.AddWithValue("@em", meualuno.Email);
            cmd.Parameters.AddWithValue("@md", meualuno.Modalidade);
            cmd.Parameters.AddWithValue("@tel", meualuno.Telefone);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(meualuno.Nome + " " + meualuno.Turma + " " + meualuno.Modalidade + " " + meualuno.Email + " " + meualuno.Telefone);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String strconexao;
            MySqlDataReader dr;

            strconexao = "server=localhost;userid=root;password=cachorro;database=bdjinf";
            MySqlConnection con = new MySqlConnection(strconexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from aluno";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show(dr.GetString("nome"));
            }
            con.Close();
            //MessageBox.Show(DateTime.Today.ToShortDateString());
            
        }


    }
}
