namespace Controle_de_consultorio_odonto
{
    partial class Cadastro_servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_servicos));
            this.labelDescr = new System.Windows.Forms.Label();
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.buttonCad = new System.Windows.Forms.Button();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelDescr
            // 
            this.labelDescr.AutoSize = true;
            this.labelDescr.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelDescr.Location = new System.Drawing.Point(12, 31);
            this.labelDescr.Name = "labelDescr";
            this.labelDescr.Size = new System.Drawing.Size(55, 13);
            this.labelDescr.TabIndex = 2;
            this.labelDescr.Text = "Descrição";
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxDescr.Location = new System.Drawing.Point(73, 28);
            this.textBoxDescr.MaxLength = 45;
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescr.TabIndex = 3;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelPreco.Location = new System.Drawing.Point(12, 71);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 4;
            this.labelPreco.Text = "Preço";
            // 
            // buttonCad
            // 
            this.buttonCad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCad.Location = new System.Drawing.Point(73, 121);
            this.buttonCad.Name = "buttonCad";
            this.buttonCad.Size = new System.Drawing.Size(75, 23);
            this.buttonCad.TabIndex = 6;
            this.buttonCad.Text = "Cadastrar";
            this.buttonCad.UseVisualStyleBackColor = true;
            this.buttonCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(73, 68);
            this.maskedTextBoxPreco.Mask = "000.00";
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPreco.TabIndex = 7;
            // 
            // Cadastro_servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(210, 156);
            this.Controls.Add(this.maskedTextBoxPreco);
            this.Controls.Add(this.buttonCad);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.textBoxDescr);
            this.Controls.Add(this.labelDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro_servicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescr;
        private System.Windows.Forms.TextBox textBoxDescr;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Button buttonCad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
    }
}