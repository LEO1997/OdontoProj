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

namespace Controle_de_consultorio_odonto.Formularios.Listagens
{
    public partial class ListScrn : Form
    {
        public ListScrn()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void ListScrn_Load(object sender, EventArgs e)
        {

            dgv1.DataSource = generateDataTable("select * from paciente;");
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.Columns["cpf"].ReadOnly = true;


            //            

            dgv2.DataSource = generateDataTable("select * from profissional;");
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv2.Columns["cro"].ReadOnly = true;


            //            

            dgv3.DataSource = generateDataTable("select * from servico;");
            dgv3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv3.Columns["cod_servico"].ReadOnly = true;

            //           

            dgv4.DataSource = generateDataTable("select * from consulta;");
            dgv4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv4.Columns["codigo"].ReadOnly = true;
            dgv4.Columns["Paciente_cpf"].ReadOnly = true;
            dgv4.Columns["Tratamento_cod_tratamento"].ReadOnly = true;

            

        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(DataStore.Conexao);
            MySqlCommand cmd = new MySqlCommand("");
            MySqlCommand cmdDel = new MySqlCommand("");

            conn.Open();
            cmd.Connection = conn;
            cmdDel.Connection = conn;

            switch (tabControl.SelectedTab.Name)
            {
                
                //Salvar alterações na tabela de pacientes.
                case "tabPagePac":

                    cmd.CommandText = "update paciente set nome=@nm, nascimento=@nasc, endereco=@end, telefone=@tel " +
                                    "where cpf=@cpf;";               
                               
                        for (int i = 0; i < dgv1.Rows.Count - 1; i++)
                        {
                    
                        cmd.Parameters.AddWithValue("@cpf",
                            dgv1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@nm",
                            dgv1.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@nasc",
                            dgv1.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@end",
                           dgv1.Rows[i].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@tel",
                            dgv1.Rows[i].Cells[4].Value);

                        cmd.ExecuteNonQuery();
                        }
                    conn.Close();
                    
                    break;

                //Salvar alterações na tabela de profissionais.
                case "tabPageProf":
                    
                    cmd.CommandText = "update profissional set nome=@nm, telefone=@tel, especializacao=@esp " +
                                      "where cro=@cro;";           
                 
                        for (int i = 0; i < dgv2.Rows.Count - 1; i++)
                        {

                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@cro",
                                dgv2.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@nm",
                                dgv2.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@tel",
                                dgv2.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("@esp",
                                dgv2.Rows[i].Cells[3].Value);

                            cmd.ExecuteNonQuery();
                        }
                    conn.Close();

                    break;

                //Salvar alterações na tabela de serviço.
                case "tabPageServ":

                    cmd.CommandText = "update servico set descricao=@dsc , preco=@prc where cod_servico=@cod;";
                      
                        for (int i = 0; i < dgv3.Rows.Count - 1; i++)
                        {

                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@cod",
                                dgv3.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@dsc",
                                dgv3.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@prc",
                                dgv3.Rows[i].Cells[2].Value);

                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();

                        break;

                //Salvar alterações na tabela de consultas.
                case "tabPageCons":
                    
                    cmd.CommandText = "update consulta set data_hora=@dt , sala=@sl, Profissional_cro=@pcro, " + 
                                      "Servico_cod_servico=@scs where codigo=@cod;";

                          for (int i = 0; i < dgv3.Rows.Count - 1; i++)
                          {

                              cmd.Parameters.Clear();

                              cmd.Parameters.AddWithValue("@cod",
                                  dgv3.Rows[i].Cells[0].Value);
                              cmd.Parameters.AddWithValue("@dt",
                                  dgv3.Rows[i].Cells[1].Value);
                              cmd.Parameters.AddWithValue("@sl",
                                  dgv3.Rows[i].Cells[2].Value);
                              cmd.Parameters.AddWithValue("@pcro",
                                  dgv3.Rows[i].Cells[4].Value);
                              cmd.Parameters.AddWithValue("@scs",
                                  dgv3.Rows[i].Cells[5].Value);

                              cmd.ExecuteNonQuery();
                          }
                          conn.Close();
                          
                          break;

            }
            
                           
                        
        }



        //Método para criar uma tablela de dados para cada DataGridView.
        private DataTable generateDataTable(string cmd)
        {
            DataSet dtaSet = new DataSet();
            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd, DataStore.Conexao);
            DataTable dt = new DataTable();

            adpter.Fill(dt);

            dtaSet.Tables.Add(dt);

            DataTableReader dtr = new DataTableReader(dtaSet.Tables[0]);
            dt.Load(dtr, LoadOption.OverwriteChanges);

            return dt;
        }
      
    }
}
