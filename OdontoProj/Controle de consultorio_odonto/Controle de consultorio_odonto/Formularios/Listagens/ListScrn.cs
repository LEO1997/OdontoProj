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
       

        private void ListScrn_Load(object sender, EventArgs e)
        {
            dgvLoad(dgv1);
            dgvLoad(dgv2);
            dgvLoad(dgv3);
            dgvLoad(dgv4);
            dgvLoad(dgv5);            

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
        

        
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {             
            switch (tabControl.SelectedTab.Name)
            {
                
                //Salvar alterações na tabela de pacientes.
                case "tabPagePac":

                    DaoPaciente daoPac = new DaoPaciente();     
                               
                        for (int i = 0; i < dgv1.Rows.Count - 1; i++)
                        {

                            daoPac.update(dgv1.Rows[i].Cells[0].Value, 
                                          dgv1.Rows[i].Cells[1].Value, 
                                          dgv1.Rows[i].Cells[2].Value, 
                                          dgv1.Rows[i].Cells[3].Value, 
                                          dgv1.Rows[i].Cells[4].Value);                                     
                        
                        }                        
                    
                    break;

                //Salvar alterações na tabela de profissionais.
                case "tabPageProf":

                    DaoProf daoProf = new DaoProf();          
                 
                        for (int i = 0; i < dgv2.Rows.Count - 1; i++)
                        {

                            daoProf.update(dgv2.Rows[i].Cells[0].Value,
                                           dgv2.Rows[i].Cells[1].Value,                            
                                           dgv2.Rows[i].Cells[2].Value,                            
                                           dgv2.Rows[i].Cells[3].Value);
                           
                        }                       

                    break;

                //Salvar alterações na tabela de serviço.
                case "tabPageServ":

                    DaoServico daoServ = new DaoServico();
                      
                        for (int i = 0; i < dgv3.Rows.Count - 1; i++)
                        {
                            

                            daoServ.update(dgv3.Rows[i].Cells[0].Value,                            
                                           dgv3.Rows[i].Cells[1].Value,
                                           dgv3.Rows[i].Cells[2].Value);

                        }                        

                        break;

                //Salvar alterações na tabela de consultas.
                case "tabPageCons":

                      DaoConsulta daoCons = new DaoConsulta();

                          for (int i = 0; i < dgv4.Rows.Count - 1; i++)
                          {

                              daoCons.update(dgv4.Rows[i].Cells[0].Value,                              
                                             dgv4.Rows[i].Cells[1].Value,                              
                                             dgv4.Rows[i].Cells[2].Value,                              
                                             dgv4.Rows[i].Cells[4].Value,                              
                                             dgv4.Rows[i].Cells[5].Value);
                              
                          }                          
                          
                          break;

                //Salvar alterações na tabela de consultas.
                case "tabPageTrat":

                      DaoTratamento daoTrat = new DaoTratamento();
                      
                        for (int i = 0; i < dgv5.Rows.Count - 1; i++)
                        {                           
                            
                            daoTrat.update(dgv5.Rows[i].Cells[0].Value,
                                           dgv5.Rows[i].Cells[1].Value,
                                           dgv5.Rows[i].Cells[2].Value);                            
                            
                        }                        

                        break;                         

            }                                       
                        
        }


        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {

           DialogResult msbResult = MessageBox.Show("Tem certeza que deseja deletar este item?", "Deletar item", 
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (msbResult.Equals(DialogResult.Yes))
           {

               switch (tabControl.SelectedTab.Name)
               {

                   //Excluir de pacientes.
                   case "tabPagePac":

                       DaoPaciente daoPac = new DaoPaciente();

                       for (int i = 0; i < dgv1.SelectedRows.Count; i++)
                       {
                           daoPac.delete(dgv1.SelectedRows[0].Cells[0].Value);
                       }
                       dgvLoad(dgv1);

                       break;

                   //Excluir de profissionais.
                   case "tabPageProf":

                       DaoProf daoProf = new DaoProf();

                       for (int i = 0; i < dgv2.SelectedRows.Count; i++)
                       {
                           daoProf.delete(dgv2.SelectedRows[i].Cells[0].Value);
                       }
                       dgvLoad(dgv2);

                       break;

                   //Excluir de serviço.
                   case "tabPageServ":

                       DaoServico daoServ = new DaoServico();

                       for (int i = 0; i < dgv3.SelectedRows.Count; i++)
                       {
                           daoServ.delete(dgv3.SelectedRows[i].Cells[0].Value);
                       }
                       dgvLoad(dgv3);

                       break;

                   //Excluir de consultas.
                   case "tabPageCons":

                       DaoConsulta daoCons = new DaoConsulta();

                       for (int i = 0; i < dgv4.SelectedRows.Count; i++)
                       {
                           daoCons.delete(dgv4.SelectedRows[i].Cells[0].Value);
                       }
                       dgvLoad(dgv4);


                       break;

                   //Excluir de tratamentos.
                   case "tabPageTrat":

                       DaoTratamento daoTrat = new DaoTratamento();

                       for (int i = 0; i < dgv5.SelectedRows.Count; i++)
                       {
                           daoTrat.delete(dgv5.SelectedRows[i].Cells[0].Value);
                       }
                       dgvLoad(dgv5);

                       break;
               }
           }
        }


        //Método para carregar ou recarregar tabela.
        private void dgvLoad(DataGridView dgv)
        {
            switch (dgv.Name)
            {
                case "dgv1":
                    dgv.DataSource = generateDataTable("select * from paciente;");
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.Columns["cpf"].ReadOnly = true;
                    break;

                case "dgv2":

                    dgv.DataSource = generateDataTable("select * from profissional;");
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.Columns["cro"].ReadOnly = true;
                    break;

                case "dgv3":
                    dgv.DataSource = generateDataTable("select * from servico;");
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.Columns["cod_servico"].ReadOnly = true;
                    break;

                case "dgv4":
                    dgv.DataSource = generateDataTable("select * from consulta;");
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.Columns["codigo"].ReadOnly = true;
                    dgv.Columns["Profissional_cro"].ReadOnly = true;
                    dgv.Columns["Tratamento_cod_tratamento"].ReadOnly = true;
                    break;

                case "dgv5":
                    dgv.DataSource = generateDataTable("select * from tratamento;");
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.Columns["cod_tratamento"].ReadOnly = true;
                    dgv.Columns["Paciente_cpf"].ReadOnly = true;
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
