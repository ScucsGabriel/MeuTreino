namespace MeuTreino.View.Principal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Alunos = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Administrador = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Alunos,
            this.Tsb_Administrador});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsb_Alunos
            // 
            this.Tsb_Alunos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Alunos.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Alunos.Image")));
            this.Tsb_Alunos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Alunos.Name = "Tsb_Alunos";
            this.Tsb_Alunos.Size = new System.Drawing.Size(48, 22);
            this.Tsb_Alunos.Text = "Alunos";
            this.Tsb_Alunos.Click += new System.EventHandler(this.Tsb_Alunos_Click);
            // 
            // Tsb_Administrador
            // 
            this.Tsb_Administrador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Administrador.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Administrador.Image")));
            this.Tsb_Administrador.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Administrador.Name = "Tsb_Administrador";
            this.Tsb_Administrador.Size = new System.Drawing.Size(87, 22);
            this.Tsb_Administrador.Text = "Administrador";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsb_Alunos;
        private System.Windows.Forms.ToolStripButton Tsb_Administrador;
    }
}