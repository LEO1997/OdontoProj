namespace Controle_de_consultorio_odonto.Formularios.Cadastros
{
    partial class Cadastro_tratamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_tratamento));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.groupBoxLaudo = new System.Windows.Forms.GroupBox();
            this.textBoxLaudo = new System.Windows.Forms.TextBox();
            this.labelPac = new System.Windows.Forms.Label();
            this.comboBoxPac = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxLaudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(195, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxTitulo.Location = new System.Drawing.Point(93, 38);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(229, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // groupBoxLaudo
            // 
            this.groupBoxLaudo.Controls.Add(this.textBoxLaudo);
            this.groupBoxLaudo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxLaudo.Location = new System.Drawing.Point(12, 140);
            this.groupBoxLaudo.Name = "groupBoxLaudo";
            this.groupBoxLaudo.Size = new System.Drawing.Size(401, 175);
            this.groupBoxLaudo.TabIndex = 2;
            this.groupBoxLaudo.TabStop = false;
            this.groupBoxLaudo.Text = "Laudo";
            // 
            // textBoxLaudo
            // 
            this.textBoxLaudo.Location = new System.Drawing.Point(6, 36);
            this.textBoxLaudo.Multiline = true;
            this.textBoxLaudo.Name = "textBoxLaudo";
            this.textBoxLaudo.Size = new System.Drawing.Size(389, 122);
            this.textBoxLaudo.TabIndex = 3;
            // 
            // labelPac
            // 
            this.labelPac.AutoSize = true;
            this.labelPac.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelPac.Location = new System.Drawing.Point(171, 75);
            this.labelPac.Name = "labelPac";
            this.labelPac.Size = new System.Drawing.Size(85, 13);
            this.labelPac.TabIndex = 3;
            this.labelPac.Text = "Paciente tratado";
            this.labelPac.Click += new System.EventHandler(this.labelPac_Click);
            // 
            // comboBoxPac
            // 
            this.comboBoxPac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPac.FormattingEnabled = true;
            this.comboBoxPac.Location = new System.Drawing.Point(93, 91);
            this.comboBoxPac.Name = "comboBoxPac";
            this.comboBoxPac.Size = new System.Drawing.Size(229, 21);
            this.comboBoxPac.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave.Location = new System.Drawing.Point(174, 341);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Cadastro_tratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 376);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxPac);
            this.Controls.Add(this.labelPac);
            this.Controls.Add(this.groupBoxLaudo);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro_tratamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cadastro_tratamento_Load);
            this.groupBoxLaudo.ResumeLayout(false);
            this.groupBoxLaudo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.GroupBox groupBoxLaudo;
        private System.Windows.Forms.TextBox textBoxLaudo;
        private System.Windows.Forms.Label labelPac;
        private System.Windows.Forms.ComboBox comboBoxPac;
        private System.Windows.Forms.Button buttonSave;
    }
}