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
            DataSet dtaSet = new DataSet();
            MySqlDataAdapter adpter = new MySqlDataAdapter("select * from paciente;", "server=127.0.0.1;user=root;password=superiorclock;database=consultorio_odonto;");
            DataTable dt = new DataTable();

            adpter.Fill(dt);

            dtaSet.Tables.Add(dt);

            DataTableReader dtr = new DataTableReader(dtaSet.Tables[0]);
            dt.Load(dtr, LoadOption.OverwriteChanges);

            dgv1.DataSource = dt;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //
            DataSet dtaSet2 = new DataSet();
            MySqlDataAdapter adpter2 = new MySqlDataAdapter("select * from profissional;", "server=127.0.0.1;user=root;password=superiorclock;database=consultorio_odonto;");
            DataTable dt2 = new DataTable();            

            adpter2.Fill(dt2);

            dtaSet2.Tables.Add(dt2);

            DataTableReader dtr2 = new DataTableReader(dtaSet2.Tables[0]);
            dt2.Load(dtr2, LoadOption.OverwriteChanges);

            dgv2.DataSource = dt2;
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //
            DataSet dtaSet3 = new DataSet();
            MySqlDataAdapter adpter3 = new MySqlDataAdapter("select * from servico;", "server=127.0.0.1;user=root;password=superiorclock;database=consultorio_odonto;");
            DataTable dt3 = new DataTable();

            adpter3.Fill(dt3);

            dtaSet3.Tables.Add(dt3);

            DataTableReader dtr3 = new DataTableReader(dtaSet3.Tables[0]);
            dt3.Load(dtr3, LoadOption.OverwriteChanges);

            dgv3.DataSource = dt3;
            dgv3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //
            DataSet dtaSet4 = new DataSet();
            MySqlDataAdapter adpter4 = new MySqlDataAdapter("select * from servico;", "server=127.0.0.1;user=root;password=superiorclock;database=consultorio_odonto;");
            DataTable dt4 = new DataTable();

            adpter4.Fill(dt3);

            dtaSet3.Tables.Add(dt3);

            DataTableReader dtr3 = new DataTableReader(dtaSet3.Tables[0]);
            dt3.Load(dtr3, LoadOption.OverwriteChanges);

            dgv3.DataSource = dt3;
            dgv3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            

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
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=superiorclock;database=consultorio_odonto;");
            MySqlCommand cmd = new MySqlCommand("");
            MySqlCommand cmdDel = new MySqlCommand("");

            conn.Open();
            cmd.Connection = conn;
            cmdDel.Connection = conn;            

            if (tabControl.SelectedTab.Equals(tabPagePac))
            {                
                cmdDel.CommandText = "delete from paciente;";
                cmd.CommandText = "insert into paciente(cpf, nome, nascimento, endereco, telefone)"
                                   + "values(@cpf,@nm,@nasc,@end,@tel)";

                cmdDel.Prepare();
                cmdDel.ExecuteNonQuery();
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

            }
            else
            {
                if (tabControl.SelectedTab.Equals(tabPageProf))
                {
                    cmdDel.CommandText = "DELETE FROM PROFISSIONAL";
                    cmd.CommandText = "insert into profissional(cro, nome, telefone, especializacao)"
                                       + "values(@cro,@nm,@tel,@esp)";

                    cmdDel.ExecuteNonQuery();
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

                }
                else
                {
                    if (tabControl.SelectedTab.Equals(tabPageServ))
                    {
                        cmdDel.CommandText = "DELETE FROM SERVICO";
                        cmd.CommandText = "insert into servico(descricao, preco) values(@dsc,@prc)";

                        cmdDel.ExecuteNonQuery();
                        for (int i = 0; i < dgv3.Rows.Count - 1; i++)
                        {

                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@dsc",
                                dgv3.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@prc",
                                dgv3.Rows[i].Cells[2].Value);

                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
            }
                        
        }
      
    }
}
