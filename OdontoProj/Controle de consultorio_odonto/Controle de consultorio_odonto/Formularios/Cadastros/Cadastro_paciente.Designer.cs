namespace Controle_de_consultorio_odonto
{
    partial class Cadastro_paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_paciente));
            this.buttonCad = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNasc = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNasc = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCad
            // 
            this.buttonCad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCad.Location = new System.Drawing.Point(114, 235);
            this.buttonCad.Name = "buttonCad";
            this.buttonCad.Size = new System.Drawing.Size(75, 23);
            this.buttonCad.TabIndex = 0;
            this.buttonCad.Text = "Cadastrar";
            this.buttonCad.UseVisualStyleBackColor = true;
            this.buttonCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(6, 16);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(144, 56);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(30, 13);
            this.labelCpf.TabIndex = 3;
            this.labelCpf.Text = "CPF:";
            // 
            // labelNasc
            // 
            this.labelNasc.AutoSize = true;
            this.labelNasc.Location = new System.Drawing.Point(6, 56);
            this.labelNasc.Name = "labelNasc";
            this.labelNasc.Size = new System.Drawing.Size(63, 13);
            this.labelNasc.TabIndex = 4;
            this.labelNasc.Text = "Nascimento";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(19, 61);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(53, 13);
            this.labelEnd.TabIndex = 5;
            this.labelEnd.Text = "Endereco";
            this.labelEnd.Click += new System.EventHandler(this.labelEnd_Click);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(19, 28);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 13);
            this.labelTel.TabIndex = 6;
            this.labelTel.Text = "Telefone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.maskedTextBoxNasc);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.labelCpf);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.labelNasc);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados pessoais";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBox1.Location = new System.Drawing.Point(147, 74);
            this.maskedTextBox1.Mask = "000000000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // maskedTextBoxNasc
            // 
            this.maskedTextBoxNasc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxNasc.Location = new System.Drawing.Point(9, 74);
            this.maskedTextBoxNasc.Mask = "00/00/0000";
            this.maskedTextBoxNasc.Name = "maskedTextBoxNasc";
            this.maskedTextBoxNasc.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBoxNasc.TabIndex = 6;
            this.maskedTextBoxNasc.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxNome
            // 
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxNome.Location = new System.Drawing.Point(47, 19);
            this.textBoxNome.MaxLength = 60;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(232, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxEnd);
            this.groupBox2.Controls.Add(this.maskedTextBoxTel);
            this.groupBox2.Controls.Add(this.labelEnd);
            this.groupBox2.Controls.Add(this.labelTel);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(15, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 90);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados de contato";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxEnd.Location = new System.Drawing.Point(78, 61);
            this.textBoxEnd.MaxLength = 45;
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(169, 20);
            this.textBoxEnd.TabIndex = 8;
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxTel.Location = new System.Drawing.Point(74, 28);
            this.maskedTextBoxTel.Mask = "(00)0000-9999";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTel.TabIndex = 7;
            // 
            // Cadastro_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 270);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro_paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCad;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelNasc;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNasc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBoxEnd;
    }
}