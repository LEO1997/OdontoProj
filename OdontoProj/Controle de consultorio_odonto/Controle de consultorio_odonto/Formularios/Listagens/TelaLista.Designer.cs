namespace Controle_de_consultorio_odonto
{
    partial class TelaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLista));
            this.textBoxPac = new System.Windows.Forms.TextBox();
            this.buttonPac = new System.Windows.Forms.Button();
            this.textBoxProf = new System.Windows.Forms.TextBox();
            this.buttonProf = new System.Windows.Forms.Button();
            this.textBoxServ = new System.Windows.Forms.TextBox();
            this.buttonServ = new System.Windows.Forms.Button();
            this.groupBoxPac = new System.Windows.Forms.GroupBox();
            this.groupBoxProf = new System.Windows.Forms.GroupBox();
            this.groupBoxServ = new System.Windows.Forms.GroupBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxPac.SuspendLayout();
            this.groupBoxProf.SuspendLayout();
            this.groupBoxServ.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPac
            // 
            this.textBoxPac.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxPac.Location = new System.Drawing.Point(6, 31);
            this.textBoxPac.MaxLength = 50;
            this.textBoxPac.Name = "textBoxPac";
            this.textBoxPac.Size = new System.Drawing.Size(297, 20);
            this.textBoxPac.TabIndex = 0;
            // 
            // buttonPac
            // 
            this.buttonPac.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPac.Location = new System.Drawing.Point(115, 57);
            this.buttonPac.Name = "buttonPac";
            this.buttonPac.Size = new System.Drawing.Size(75, 23);
            this.buttonPac.TabIndex = 1;
            this.buttonPac.Text = "Pesquisar";
            this.buttonPac.UseVisualStyleBackColor = true;
            this.buttonPac.Click += new System.EventHandler(this.buttonPac_Click);
            // 
            // textBoxProf
            // 
            this.textBoxProf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxProf.Location = new System.Drawing.Point(6, 21);
            this.textBoxProf.MaxLength = 45;
            this.textBoxProf.Name = "textBoxProf";
            this.textBoxProf.Size = new System.Drawing.Size(297, 20);
            this.textBoxProf.TabIndex = 4;
            // 
            // buttonProf
            // 
            this.buttonProf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonProf.Location = new System.Drawing.Point(115, 47);
            this.buttonProf.Name = "buttonProf";
            this.buttonProf.Size = new System.Drawing.Size(75, 23);
            this.buttonProf.TabIndex = 5;
            this.buttonProf.Text = "Pesquisar";
            this.buttonProf.UseVisualStyleBackColor = true;
            this.buttonProf.Click += new System.EventHandler(this.buttonProf_Click);
            // 
            // textBoxServ
            // 
            this.textBoxServ.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxServ.Location = new System.Drawing.Point(6, 19);
            this.textBoxServ.MaxLength = 45;
            this.textBoxServ.Name = "textBoxServ";
            this.textBoxServ.Size = new System.Drawing.Size(297, 20);
            this.textBoxServ.TabIndex = 6;
            // 
            // buttonServ
            // 
            this.buttonServ.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonServ.Location = new System.Drawing.Point(115, 45);
            this.buttonServ.Name = "buttonServ";
            this.buttonServ.Size = new System.Drawing.Size(75, 23);
            this.buttonServ.TabIndex = 8;
            this.buttonServ.Text = "Pesquisar";
            this.buttonServ.UseVisualStyleBackColor = true;
            this.buttonServ.Click += new System.EventHandler(this.buttonServ_Click);
            // 
            // groupBoxPac
            // 
            this.groupBoxPac.Controls.Add(this.textBoxPac);
            this.groupBoxPac.Controls.Add(this.buttonPac);
            this.groupBoxPac.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxPac.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPac.Name = "groupBoxPac";
            this.groupBoxPac.Size = new System.Drawing.Size(311, 90);
            this.groupBoxPac.TabIndex = 10;
            this.groupBoxPac.TabStop = false;
            this.groupBoxPac.Text = "Pesquisar paciente";
            // 
            // groupBoxProf
            // 
            this.groupBoxProf.Controls.Add(this.buttonProf);
            this.groupBoxProf.Controls.Add(this.textBoxProf);
            this.groupBoxProf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxProf.Location = new System.Drawing.Point(12, 108);
            this.groupBoxProf.Name = "groupBoxProf";
            this.groupBoxProf.Size = new System.Drawing.Size(311, 81);
            this.groupBoxProf.TabIndex = 11;
            this.groupBoxProf.TabStop = false;
            this.groupBoxProf.Text = "Pesquisar profissional";
            // 
            // groupBoxServ
            // 
            this.groupBoxServ.Controls.Add(this.textBoxServ);
            this.groupBoxServ.Controls.Add(this.buttonServ);
            this.groupBoxServ.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxServ.Location = new System.Drawing.Point(12, 200);
            this.groupBoxServ.Name = "groupBoxServ";
            this.groupBoxServ.Size = new System.Drawing.Size(311, 79);
            this.groupBoxServ.TabIndex = 12;
            this.groupBoxServ.TabStop = false;
            this.groupBoxServ.Text = "Pesquisar serviço";
            // 
            // buttonBack
            // 
            this.buttonBack.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonBack.Location = new System.Drawing.Point(127, 307);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Voltar";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // TelaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 349);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxServ);
            this.Controls.Add(this.groupBoxProf);
            this.Controls.Add(this.groupBoxPac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar dados";
            this.groupBoxPac.ResumeLayout(false);
            this.groupBoxPac.PerformLayout();
            this.groupBoxProf.ResumeLayout(false);
            this.groupBoxProf.PerformLayout();
            this.groupBoxServ.ResumeLayout(false);
            this.groupBoxServ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPac;
        private System.Windows.Forms.Button buttonPac;
        private System.Windows.Forms.TextBox textBoxProf;
        private System.Windows.Forms.Button buttonProf;
        private System.Windows.Forms.TextBox textBoxServ;
        private System.Windows.Forms.Button buttonServ;
        private System.Windows.Forms.GroupBox groupBoxPac;
        private System.Windows.Forms.GroupBox groupBoxProf;
        private System.Windows.Forms.GroupBox groupBoxServ;
        private System.Windows.Forms.Button buttonBack;
    }
}