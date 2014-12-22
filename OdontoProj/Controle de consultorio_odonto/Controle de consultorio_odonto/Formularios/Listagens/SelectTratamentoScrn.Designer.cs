namespace Controle_de_consultorio_odonto.Formularios.Listagens
{
    partial class SelectTratamentoScrn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTratamentoScrn));
            this.comboBoxPac = new System.Windows.Forms.ComboBox();
            this.comboBoxTrat = new System.Windows.Forms.ComboBox();
            this.labelPac = new System.Windows.Forms.Label();
            this.labelTrat = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPac
            // 
            this.comboBoxPac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPac.FormattingEnabled = true;
            this.comboBoxPac.Location = new System.Drawing.Point(67, 51);
            this.comboBoxPac.Name = "comboBoxPac";
            this.comboBoxPac.Size = new System.Drawing.Size(243, 21);
            this.comboBoxPac.TabIndex = 0;
            this.comboBoxPac.SelectedIndexChanged += new System.EventHandler(this.comboBoxPac_SelectedIndexChanged);
            // 
            // comboBoxTrat
            // 
            this.comboBoxTrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrat.FormattingEnabled = true;
            this.comboBoxTrat.Location = new System.Drawing.Point(79, 116);
            this.comboBoxTrat.Name = "comboBoxTrat";
            this.comboBoxTrat.Size = new System.Drawing.Size(242, 21);
            this.comboBoxTrat.TabIndex = 1;
            // 
            // labelPac
            // 
            this.labelPac.AutoSize = true;
            this.labelPac.Location = new System.Drawing.Point(12, 54);
            this.labelPac.Name = "labelPac";
            this.labelPac.Size = new System.Drawing.Size(49, 13);
            this.labelPac.TabIndex = 2;
            this.labelPac.Text = "Paciente";
            // 
            // labelTrat
            // 
            this.labelTrat.AutoSize = true;
            this.labelTrat.Location = new System.Drawing.Point(12, 119);
            this.labelTrat.Name = "labelTrat";
            this.labelTrat.Size = new System.Drawing.Size(61, 13);
            this.labelTrat.TabIndex = 3;
            this.labelTrat.Text = "Tratamento";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(116, 182);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(126, 23);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Adicionar consultas";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // SelectTratamentoScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 224);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelTrat);
            this.Controls.Add(this.labelPac);
            this.Controls.Add(this.comboBoxTrat);
            this.Controls.Add(this.comboBoxPac);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectTratamentoScrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SelectTratamentoScrn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPac;
        private System.Windows.Forms.ComboBox comboBoxTrat;
        private System.Windows.Forms.Label labelPac;
        private System.Windows.Forms.Label labelTrat;
        private System.Windows.Forms.Button buttonSelect;
    }
}