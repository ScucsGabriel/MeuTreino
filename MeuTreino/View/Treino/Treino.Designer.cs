namespace MeuTreino.View.Treino
{
    partial class FormTreino
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
            this.Combo_Treino = new System.Windows.Forms.ComboBox();
            this.Label_Treino = new System.Windows.Forms.Label();
            this.Btn_BuscarTreino = new System.Windows.Forms.Button();
            this.Label_Data = new System.Windows.Forms.Label();
            this.Label_DataTreino = new System.Windows.Forms.Label();
            this.Btn_EditarTreino = new System.Windows.Forms.Button();
            this.LstView_ListaTreino = new System.Windows.Forms.ListView();
            this.Label_Matricula = new System.Windows.Forms.Label();
            this.Label_NumeroMatricula = new System.Windows.Forms.Label();
            this.Btn_CadastrarTreino = new System.Windows.Forms.Button();
            this.Btn_VoltarMedidas = new System.Windows.Forms.Button();
            this.Btn_ExcluirTreino = new System.Windows.Forms.Button();
            this.Btn_SalvarPdf = new System.Windows.Forms.Button();
            this.Salvar_Xls = new System.Windows.Forms.SaveFileDialog();
            this.Salvar_Pdf = new System.Windows.Forms.SaveFileDialog();
            this.Btn_SalvarXls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Combo_Treino
            // 
            this.Combo_Treino.FormattingEnabled = true;
            this.Combo_Treino.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.Combo_Treino.Location = new System.Drawing.Point(63, 31);
            this.Combo_Treino.Name = "Combo_Treino";
            this.Combo_Treino.Size = new System.Drawing.Size(87, 21);
            this.Combo_Treino.TabIndex = 0;
            this.Combo_Treino.Text = "-- Selecione --";
            // 
            // Label_Treino
            // 
            this.Label_Treino.AutoSize = true;
            this.Label_Treino.Location = new System.Drawing.Point(22, 34);
            this.Label_Treino.Name = "Label_Treino";
            this.Label_Treino.Size = new System.Drawing.Size(37, 13);
            this.Label_Treino.TabIndex = 1;
            this.Label_Treino.Text = "Treino";
            // 
            // Btn_BuscarTreino
            // 
            this.Btn_BuscarTreino.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_BuscarTreino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarTreino.Location = new System.Drawing.Point(310, 22);
            this.Btn_BuscarTreino.Name = "Btn_BuscarTreino";
            this.Btn_BuscarTreino.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarTreino.TabIndex = 6;
            this.Btn_BuscarTreino.Text = "Buscar";
            this.Btn_BuscarTreino.UseVisualStyleBackColor = false;
            this.Btn_BuscarTreino.Click += new System.EventHandler(this.Btn_BuscarTreino_Click);
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Location = new System.Drawing.Point(168, 34);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(30, 13);
            this.Label_Data.TabIndex = 7;
            this.Label_Data.Text = "Data";
            // 
            // Label_DataTreino
            // 
            this.Label_DataTreino.AutoSize = true;
            this.Label_DataTreino.Location = new System.Drawing.Point(204, 34);
            this.Label_DataTreino.Name = "Label_DataTreino";
            this.Label_DataTreino.Size = new System.Drawing.Size(0, 13);
            this.Label_DataTreino.TabIndex = 8;
            // 
            // Btn_EditarTreino
            // 
            this.Btn_EditarTreino.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarTreino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarTreino.Location = new System.Drawing.Point(611, 22);
            this.Btn_EditarTreino.Name = "Btn_EditarTreino";
            this.Btn_EditarTreino.Size = new System.Drawing.Size(134, 34);
            this.Btn_EditarTreino.TabIndex = 9;
            this.Btn_EditarTreino.Text = "Editar";
            this.Btn_EditarTreino.UseVisualStyleBackColor = false;
            this.Btn_EditarTreino.Click += new System.EventHandler(this.Btn_EditarTreino_Click);
            // 
            // LstView_ListaTreino
            // 
            this.LstView_ListaTreino.AllowColumnReorder = true;
            this.LstView_ListaTreino.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaTreino.HideSelection = false;
            this.LstView_ListaTreino.Location = new System.Drawing.Point(25, 93);
            this.LstView_ListaTreino.Name = "LstView_ListaTreino";
            this.LstView_ListaTreino.Size = new System.Drawing.Size(1026, 308);
            this.LstView_ListaTreino.TabIndex = 69;
            this.LstView_ListaTreino.UseCompatibleStateImageBehavior = false;
            this.LstView_ListaTreino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_ListaTreino_KeyDown);
            // 
            // Label_Matricula
            // 
            this.Label_Matricula.AutoSize = true;
            this.Label_Matricula.Location = new System.Drawing.Point(29, 426);
            this.Label_Matricula.Name = "Label_Matricula";
            this.Label_Matricula.Size = new System.Drawing.Size(52, 13);
            this.Label_Matricula.TabIndex = 70;
            this.Label_Matricula.Text = "Matrícula";
            this.Label_Matricula.Visible = false;
            // 
            // Label_NumeroMatricula
            // 
            this.Label_NumeroMatricula.AutoSize = true;
            this.Label_NumeroMatricula.Location = new System.Drawing.Point(87, 426);
            this.Label_NumeroMatricula.Name = "Label_NumeroMatricula";
            this.Label_NumeroMatricula.Size = new System.Drawing.Size(13, 13);
            this.Label_NumeroMatricula.TabIndex = 71;
            this.Label_NumeroMatricula.Text = "0";
            this.Label_NumeroMatricula.Visible = false;
            // 
            // Btn_CadastrarTreino
            // 
            this.Btn_CadastrarTreino.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_CadastrarTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CadastrarTreino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_CadastrarTreino.Location = new System.Drawing.Point(460, 22);
            this.Btn_CadastrarTreino.Name = "Btn_CadastrarTreino";
            this.Btn_CadastrarTreino.Size = new System.Drawing.Size(134, 34);
            this.Btn_CadastrarTreino.TabIndex = 72;
            this.Btn_CadastrarTreino.Text = "Cadastrar";
            this.Btn_CadastrarTreino.UseVisualStyleBackColor = false;
            this.Btn_CadastrarTreino.Click += new System.EventHandler(this.Btn_CadastrarTreino_Click);
            // 
            // Btn_VoltarMedidas
            // 
            this.Btn_VoltarMedidas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarMedidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarMedidas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarMedidas.Location = new System.Drawing.Point(917, 22);
            this.Btn_VoltarMedidas.Name = "Btn_VoltarMedidas";
            this.Btn_VoltarMedidas.Size = new System.Drawing.Size(134, 34);
            this.Btn_VoltarMedidas.TabIndex = 74;
            this.Btn_VoltarMedidas.Text = "Voltar";
            this.Btn_VoltarMedidas.UseVisualStyleBackColor = false;
            this.Btn_VoltarMedidas.Click += new System.EventHandler(this.Btn_VoltarMedidas_Click);
            // 
            // Btn_ExcluirTreino
            // 
            this.Btn_ExcluirTreino.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirTreino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirTreino.Location = new System.Drawing.Point(762, 22);
            this.Btn_ExcluirTreino.Name = "Btn_ExcluirTreino";
            this.Btn_ExcluirTreino.Size = new System.Drawing.Size(134, 34);
            this.Btn_ExcluirTreino.TabIndex = 73;
            this.Btn_ExcluirTreino.Text = "Excluir";
            this.Btn_ExcluirTreino.UseVisualStyleBackColor = false;
            this.Btn_ExcluirTreino.Click += new System.EventHandler(this.Btn_ExcluirTreino_Click);
            // 
            // Btn_SalvarPdf
            // 
            this.Btn_SalvarPdf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarPdf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_SalvarPdf.Location = new System.Drawing.Point(917, 415);
            this.Btn_SalvarPdf.Name = "Btn_SalvarPdf";
            this.Btn_SalvarPdf.Size = new System.Drawing.Size(134, 34);
            this.Btn_SalvarPdf.TabIndex = 75;
            this.Btn_SalvarPdf.Text = "Salvar PDF";
            this.Btn_SalvarPdf.UseVisualStyleBackColor = false;
            this.Btn_SalvarPdf.Click += new System.EventHandler(this.Btn_SalvarPdf_Click);
            // 
            // Btn_SalvarXls
            // 
            this.Btn_SalvarXls.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarXls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarXls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_SalvarXls.Location = new System.Drawing.Point(762, 415);
            this.Btn_SalvarXls.Name = "Btn_SalvarXls";
            this.Btn_SalvarXls.Size = new System.Drawing.Size(134, 34);
            this.Btn_SalvarXls.TabIndex = 76;
            this.Btn_SalvarXls.Text = "Salvar XLS";
            this.Btn_SalvarXls.UseVisualStyleBackColor = false;
            this.Btn_SalvarXls.Click += new System.EventHandler(this.Btn_SalvarXls_Click);
            // 
            // FormTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 468);
            this.Controls.Add(this.Btn_SalvarXls);
            this.Controls.Add(this.Btn_SalvarPdf);
            this.Controls.Add(this.Btn_VoltarMedidas);
            this.Controls.Add(this.Btn_ExcluirTreino);
            this.Controls.Add(this.Btn_CadastrarTreino);
            this.Controls.Add(this.Label_NumeroMatricula);
            this.Controls.Add(this.Label_Matricula);
            this.Controls.Add(this.LstView_ListaTreino);
            this.Controls.Add(this.Btn_EditarTreino);
            this.Controls.Add(this.Label_DataTreino);
            this.Controls.Add(this.Label_Data);
            this.Controls.Add(this.Btn_BuscarTreino);
            this.Controls.Add(this.Label_Treino);
            this.Controls.Add(this.Combo_Treino);
            this.Name = "FormTreino";
            this.Text = "-- Selecione --";
            this.Load += new System.EventHandler(this.FormTreino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_Treino;
        private System.Windows.Forms.Label Label_Treino;
        private System.Windows.Forms.Button Btn_BuscarTreino;
        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.Label Label_DataTreino;
        private System.Windows.Forms.Button Btn_EditarTreino;
        private System.Windows.Forms.ListView LstView_ListaTreino;
        private System.Windows.Forms.Label Label_Matricula;
        private System.Windows.Forms.Label Label_NumeroMatricula;
        private System.Windows.Forms.Button Btn_CadastrarTreino;
        private System.Windows.Forms.Button Btn_VoltarMedidas;
        private System.Windows.Forms.Button Btn_ExcluirTreino;
        private System.Windows.Forms.Button Btn_SalvarPdf;
        private System.Windows.Forms.SaveFileDialog Salvar_Xls;
        private System.Windows.Forms.SaveFileDialog Salvar_Pdf;
        private System.Windows.Forms.Button Btn_SalvarXls;
    }
}