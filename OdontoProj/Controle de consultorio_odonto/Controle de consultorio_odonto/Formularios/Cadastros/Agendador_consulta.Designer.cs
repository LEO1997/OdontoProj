namespace Controle_de_consultorio_odonto
{
    partial class Agendador_consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendador_consulta));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.labelMedico = new System.Windows.Forms.Label();
            this.comboBoxProfissional = new System.Windows.Forms.ComboBox();
            this.labelSala = new System.Windows.Forms.Label();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.buttonAgendar = new System.Windows.Forms.Button();
            this.groupBoxPacMed = new System.Windows.Forms.GroupBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.groupBoxDtaSla = new System.Windows.Forms.GroupBox();
            this.labelServ2 = new System.Windows.Forms.Label();
            this.comboBoxServ2 = new System.Windows.Forms.ComboBox();
            this.labelDta = new System.Windows.Forms.Label();
            this.comboBoxServ1 = new System.Windows.Forms.ComboBox();
            this.labelServ1 = new System.Windows.Forms.Label();
            this.groupBoxPacMed.SuspendLayout();
            this.groupBoxDtaSla.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(6, 16);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(94, 13);
            this.labelPaciente.TabIndex = 1;
            this.labelPaciente.Text = "Nome do paciente";
            // 
            // labelMedico
            // 
            this.labelMedico.AutoSize = true;
            this.labelMedico.Location = new System.Drawing.Point(6, 57);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(105, 13);
            this.labelMedico.TabIndex = 3;
            this.labelMedico.Text = "Nome do profissional";
            // 
            // comboBoxProfissional
            // 
            this.comboBoxProfissional.AutoCompleteCustomSource.AddRange(new string[] {
            "Teste"});
            this.comboBoxProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfissional.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxProfissional.FormattingEnabled = true;
            this.comboBoxProfissional.Items.AddRange(new object[] {
            "Regivanderson",
            "Daniella"});
            this.comboBoxProfissional.Location = new System.Drawing.Point(117, 54);
            this.comboBoxProfissional.MaxLength = 45;
            this.comboBoxProfissional.Name = "comboBoxProfissional";
            this.comboBoxProfissional.Size = new System.Drawing.Size(259, 21);
            this.comboBoxProfissional.TabIndex = 4;
            // 
            // labelSala
            // 
            this.labelSala.AutoSize = true;
            this.labelSala.Location = new System.Drawing.Point(276, 94);
            this.labelSala.Name = "labelSala";
            this.labelSala.Size = new System.Drawing.Size(28, 13);
            this.labelSala.TabIndex = 5;
            this.labelSala.Text = "Sala";
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSala.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxSala.Location = new System.Drawing.Point(310, 91);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(66, 21);
            this.comboBoxSala.TabIndex = 6;
            // 
            // buttonAgendar
            // 
            this.buttonAgendar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAgendar.Location = new System.Drawing.Point(178, 245);
            this.buttonAgendar.Name = "buttonAgendar";
            this.buttonAgendar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgendar.TabIndex = 7;
            this.buttonAgendar.Text = "Agendar";
            this.buttonAgendar.UseVisualStyleBackColor = true;
            this.buttonAgendar.Click += new System.EventHandler(this.buttonAgendar_Click);
            // 
            // groupBoxPacMed
            // 
            this.groupBoxPacMed.Controls.Add(this.comboBoxPaciente);
            this.groupBoxPacMed.Controls.Add(this.labelPaciente);
            this.groupBoxPacMed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxPacMed.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPacMed.Name = "groupBoxPacMed";
            this.groupBoxPacMed.Size = new System.Drawing.Size(388, 63);
            this.groupBoxPacMed.TabIndex = 8;
            this.groupBoxPacMed.TabStop = false;
            this.groupBoxPacMed.Text = "Dados do paciente";
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(117, 13);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(259, 21);
            this.comboBoxPaciente.TabIndex = 5;
            // 
            // groupBoxDtaSla
            // 
            this.groupBoxDtaSla.Controls.Add(this.labelServ2);
            this.groupBoxDtaSla.Controls.Add(this.comboBoxServ2);
            this.groupBoxDtaSla.Controls.Add(this.labelMedico);
            this.groupBoxDtaSla.Controls.Add(this.labelDta);
            this.groupBoxDtaSla.Controls.Add(this.comboBoxProfissional);
            this.groupBoxDtaSla.Controls.Add(this.comboBoxServ1);
            this.groupBoxDtaSla.Controls.Add(this.labelServ1);
            this.groupBoxDtaSla.Controls.Add(this.labelSala);
            this.groupBoxDtaSla.Controls.Add(this.comboBoxSala);
            this.groupBoxDtaSla.Controls.Add(this.dateTimePicker1);
            this.groupBoxDtaSla.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxDtaSla.Location = new System.Drawing.Point(12, 81);
            this.groupBoxDtaSla.Name = "groupBoxDtaSla";
            this.groupBoxDtaSla.Size = new System.Drawing.Size(388, 136);
            this.groupBoxDtaSla.TabIndex = 9;
            this.groupBoxDtaSla.TabStop = false;
            this.groupBoxDtaSla.Text = "Dados de atendimento";
            // 
            // labelServ2
            // 
            this.labelServ2.AutoSize = true;
            this.labelServ2.Location = new System.Drawing.Point(194, 16);
            this.labelServ2.Name = "labelServ2";
            this.labelServ2.Size = new System.Drawing.Size(55, 13);
            this.labelServ2.TabIndex = 12;
            this.labelServ2.Text = "Serviço 2:";
            // 
            // comboBoxServ2
            // 
            this.comboBoxServ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServ2.FormattingEnabled = true;
            this.comboBoxServ2.Location = new System.Drawing.Point(255, 13);
            this.comboBoxServ2.Name = "comboBoxServ2";
            this.comboBoxServ2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServ2.TabIndex = 14;
            // 
            // labelDta
            // 
            this.labelDta.AutoSize = true;
            this.labelDta.Location = new System.Drawing.Point(6, 94);
            this.labelDta.Name = "labelDta";
            this.labelDta.Size = new System.Drawing.Size(61, 13);
            this.labelDta.TabIndex = 7;
            this.labelDta.Text = "data e hora";
            // 
            // comboBoxServ1
            // 
            this.comboBoxServ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServ1.FormattingEnabled = true;
            this.comboBoxServ1.Location = new System.Drawing.Point(67, 13);
            this.comboBoxServ1.Name = "comboBoxServ1";
            this.comboBoxServ1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServ1.TabIndex = 13;
            // 
            // labelServ1
            // 
            this.labelServ1.AutoSize = true;
            this.labelServ1.Location = new System.Drawing.Point(6, 16);
            this.labelServ1.Name = "labelServ1";
            this.labelServ1.Size = new System.Drawing.Size(55, 13);
            this.labelServ1.TabIndex = 11;
            this.labelServ1.Text = "Serviço 1:";
            // 
            // Agendador_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 280);
            this.Controls.Add(this.groupBoxDtaSla);
            this.Controls.Add(this.groupBoxPacMed);
            this.Controls.Add(this.buttonAgendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Agendador_consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Agendador_consulta_Load);
            this.groupBoxPacMed.ResumeLayout(false);
            this.groupBoxPacMed.PerformLayout();
            this.groupBoxDtaSla.ResumeLayout(false);
            this.groupBoxDtaSla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.Label labelMedico;
        private System.Windows.Forms.ComboBox comboBoxProfissional;
        private System.Windows.Forms.Label labelSala;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.Button buttonAgendar;
        private System.Windows.Forms.GroupBox groupBoxPacMed;
        private System.Windows.Forms.GroupBox groupBoxDtaSla;
        private System.Windows.Forms.Label labelDta;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.ComboBox comboBoxServ2;
        private System.Windows.Forms.ComboBox comboBoxServ1;
        private System.Windows.Forms.Label labelServ2;
        private System.Windows.Forms.Label labelServ1;


        public System.EventHandler comboBoxServ1_SelectedIndexChanged { get; set; }
    }
}