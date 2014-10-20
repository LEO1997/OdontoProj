namespace AplicacaoBD
{
    partial class frmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPalestrante = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastros});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(284, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPalestrante,
            this.mnuCursos,
            this.mnuAlunos});
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastros.Text = "Cadastros";
            // 
            // mnuPalestrante
            // 
            this.mnuPalestrante.Name = "mnuPalestrante";
            this.mnuPalestrante.Size = new System.Drawing.Size(152, 22);
            this.mnuPalestrante.Text = "Palestrante";
            this.mnuPalestrante.Click += new System.EventHandler(this.mnuPalestrante_Click);
            // 
            // mnuCursos
            // 
            this.mnuCursos.Name = "mnuCursos";
            this.mnuCursos.Size = new System.Drawing.Size(152, 22);
            this.mnuCursos.Text = "Cursos";
            // 
            // mnuAlunos
            // 
            this.mnuAlunos.Name = "mnuAlunos";
            this.mnuAlunos.Size = new System.Drawing.Size(152, 22);
            this.mnuAlunos.Text = "Alunos";
            this.mnuAlunos.Click += new System.EventHandler(this.mnuAlunos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Sistema Controle Minicursos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnuPalestrante;
        private System.Windows.Forms.ToolStripMenuItem mnuCursos;
        private System.Windows.Forms.ToolStripMenuItem mnuAlunos;
    }
}