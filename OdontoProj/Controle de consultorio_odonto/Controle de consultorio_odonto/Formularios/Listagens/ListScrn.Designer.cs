namespace Controle_de_consultorio_odonto.Formularios.Listagens
{
    partial class ListScrn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListScrn));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePac = new System.Windows.Forms.TabPage();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tabPageProf = new System.Windows.Forms.TabPage();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.tabPageServ = new System.Windows.Forms.TabPage();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.tabPageCons = new System.Windows.Forms.TabPage();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this.tabPageTrat = new System.Windows.Forms.TabPage();
            this.dgv5 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPagePac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.tabPageProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.tabPageServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.tabPageCons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.tabPageTrat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePac);
            this.tabControl.Controls.Add(this.tabPageProf);
            this.tabControl.Controls.Add(this.tabPageServ);
            this.tabControl.Controls.Add(this.tabPageCons);
            this.tabControl.Controls.Add(this.tabPageTrat);
            this.tabControl.Location = new System.Drawing.Point(1, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(671, 425);
            this.tabControl.TabIndex = 1;
            // 
            // tabPagePac
            // 
            this.tabPagePac.Controls.Add(this.dgv1);
            this.tabPagePac.Location = new System.Drawing.Point(4, 22);
            this.tabPagePac.Name = "tabPagePac";
            this.tabPagePac.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePac.Size = new System.Drawing.Size(663, 399);
            this.tabPagePac.TabIndex = 0;
            this.tabPagePac.Text = "Pacientes";
            this.tabPagePac.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(663, 432);
            this.dgv1.TabIndex = 0;
            // 
            // tabPageProf
            // 
            this.tabPageProf.Controls.Add(this.dgv2);
            this.tabPageProf.Location = new System.Drawing.Point(4, 22);
            this.tabPageProf.Name = "tabPageProf";
            this.tabPageProf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProf.Size = new System.Drawing.Size(663, 399);
            this.tabPageProf.TabIndex = 1;
            this.tabPageProf.Text = "Profissionais";
            this.tabPageProf.UseVisualStyleBackColor = true;
            // 
            // dgv2
            // 
            this.dgv2.BackgroundColor = System.Drawing.Color.White;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(0, 0);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(667, 432);
            this.dgv2.TabIndex = 0;
            // 
            // tabPageServ
            // 
            this.tabPageServ.Controls.Add(this.dgv3);
            this.tabPageServ.Location = new System.Drawing.Point(4, 22);
            this.tabPageServ.Name = "tabPageServ";
            this.tabPageServ.Size = new System.Drawing.Size(663, 399);
            this.tabPageServ.TabIndex = 2;
            this.tabPageServ.Text = "Serviços";
            this.tabPageServ.UseVisualStyleBackColor = true;
            // 
            // dgv3
            // 
            this.dgv3.BackgroundColor = System.Drawing.Color.White;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(0, 0);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(667, 428);
            this.dgv3.TabIndex = 0;
            // 
            // tabPageCons
            // 
            this.tabPageCons.Controls.Add(this.dgv4);
            this.tabPageCons.Location = new System.Drawing.Point(4, 22);
            this.tabPageCons.Name = "tabPageCons";
            this.tabPageCons.Size = new System.Drawing.Size(663, 399);
            this.tabPageCons.TabIndex = 3;
            this.tabPageCons.Text = "Consultas";
            this.tabPageCons.UseVisualStyleBackColor = true;
            // 
            // dgv4
            // 
            this.dgv4.BackgroundColor = System.Drawing.Color.White;
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(0, 0);
            this.dgv4.Name = "dgv4";
            this.dgv4.Size = new System.Drawing.Size(663, 399);
            this.dgv4.TabIndex = 0;
            // 
            // tabPageTrat
            // 
            this.tabPageTrat.Controls.Add(this.dgv5);
            this.tabPageTrat.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrat.Name = "tabPageTrat";
            this.tabPageTrat.Size = new System.Drawing.Size(663, 399);
            this.tabPageTrat.TabIndex = 4;
            this.tabPageTrat.Text = "Tratamentos";
            this.tabPageTrat.UseVisualStyleBackColor = true;
            // 
            // dgv5
            // 
            this.dgv5.BackgroundColor = System.Drawing.Color.White;
            this.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv5.Location = new System.Drawing.Point(0, 0);
            this.dgv5.Name = "dgv5";
            this.dgv5.Size = new System.Drawing.Size(663, 399);
            this.dgv5.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSaveButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(673, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripSaveButton
            // 
            this.ToolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSaveButton.Image")));
            this.ToolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSaveButton.Name = "ToolStripSaveButton";
            this.ToolStripSaveButton.Size = new System.Drawing.Size(23, 22);
            this.ToolStripSaveButton.Text = "toolStripButton1";
            this.ToolStripSaveButton.ToolTipText = "Salvar alterações";
            this.ToolStripSaveButton.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Deletar item";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // ListScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListScrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.ListScrn_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPagePac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.tabPageProf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.tabPageServ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.tabPageCons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.tabPageTrat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePac;
        private System.Windows.Forms.TabPage tabPageProf;
        private System.Windows.Forms.TabPage tabPageServ;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripSaveButton;
        private System.Windows.Forms.ToolTip toolTipEdit;
        private System.Windows.Forms.TabPage tabPageCons;
        private System.Windows.Forms.DataGridView dgv4;
        private System.Windows.Forms.TabPage tabPageTrat;
        private System.Windows.Forms.DataGridView dgv5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;



    }
}