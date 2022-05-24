namespace MeuTreino.View.Treino
{
    partial class FormCadastrarTreino
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
            this.Label_SiglaTreino = new System.Windows.Forms.Label();
            this.Combo_CadastroTreino = new System.Windows.Forms.ComboBox();
            this.Label_NomeTreino = new System.Windows.Forms.Label();
            this.Txt_NomeTreino = new System.Windows.Forms.TextBox();
            this.Label_Exercicio = new System.Windows.Forms.Label();
            this.Txt_Exercicio = new System.Windows.Forms.TextBox();
            this.Label_NumeroMatricula = new System.Windows.Forms.Label();
            this.Label_Matricula = new System.Windows.Forms.Label();
            this.Label_Serie = new System.Windows.Forms.Label();
            this.Combo_Serie = new System.Windows.Forms.ComboBox();
            this.Label_Repeticao = new System.Windows.Forms.Label();
            this.Txt_Repeticao = new System.Windows.Forms.TextBox();
            this.Txt_Intervalo = new System.Windows.Forms.TextBox();
            this.Label_Intervalo = new System.Windows.Forms.Label();
            this.Txt_Metodo = new System.Windows.Forms.TextBox();
            this.Label_Metodo = new System.Windows.Forms.Label();
            this.Txt_Pse = new System.Windows.Forms.TextBox();
            this.Label_Pse = new System.Windows.Forms.Label();
            this.Txt_VelocidadeExecucao = new System.Windows.Forms.TextBox();
            this.Label_VelocidadeExecucao = new System.Windows.Forms.Label();
            this.Label_DataTreino = new System.Windows.Forms.Label();
            this.Date_DataTreino = new System.Windows.Forms.DateTimePicker();
            this.Btn_CancelarTreino = new System.Windows.Forms.Button();
            this.Btn_SalvarTreino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_SiglaTreino
            // 
            this.Label_SiglaTreino.AutoSize = true;
            this.Label_SiglaTreino.Location = new System.Drawing.Point(104, 37);
            this.Label_SiglaTreino.Name = "Label_SiglaTreino";
            this.Label_SiglaTreino.Size = new System.Drawing.Size(30, 13);
            this.Label_SiglaTreino.TabIndex = 0;
            this.Label_SiglaTreino.Text = "Sigla";
            // 
            // Combo_CadastroTreino
            // 
            this.Combo_CadastroTreino.FormattingEnabled = true;
            this.Combo_CadastroTreino.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.Combo_CadastroTreino.Location = new System.Drawing.Point(140, 29);
            this.Combo_CadastroTreino.Name = "Combo_CadastroTreino";
            this.Combo_CadastroTreino.Size = new System.Drawing.Size(137, 21);
            this.Combo_CadastroTreino.TabIndex = 1;
            this.Combo_CadastroTreino.Text = "-- Selecione --";
            // 
            // Label_NomeTreino
            // 
            this.Label_NomeTreino.AutoSize = true;
            this.Label_NomeTreino.Location = new System.Drawing.Point(52, 63);
            this.Label_NomeTreino.Name = "Label_NomeTreino";
            this.Label_NomeTreino.Size = new System.Drawing.Size(82, 13);
            this.Label_NomeTreino.TabIndex = 2;
            this.Label_NomeTreino.Text = "Grupo Muscular";
            // 
            // Txt_NomeTreino
            // 
            this.Txt_NomeTreino.Location = new System.Drawing.Point(140, 56);
            this.Txt_NomeTreino.Name = "Txt_NomeTreino";
            this.Txt_NomeTreino.Size = new System.Drawing.Size(137, 20);
            this.Txt_NomeTreino.TabIndex = 3;
            // 
            // Label_Exercicio
            // 
            this.Label_Exercicio.AutoSize = true;
            this.Label_Exercicio.Location = new System.Drawing.Point(82, 89);
            this.Label_Exercicio.Name = "Label_Exercicio";
            this.Label_Exercicio.Size = new System.Drawing.Size(52, 13);
            this.Label_Exercicio.TabIndex = 4;
            this.Label_Exercicio.Text = "Exercício";
            // 
            // Txt_Exercicio
            // 
            this.Txt_Exercicio.Location = new System.Drawing.Point(140, 82);
            this.Txt_Exercicio.Name = "Txt_Exercicio";
            this.Txt_Exercicio.Size = new System.Drawing.Size(137, 20);
            this.Txt_Exercicio.TabIndex = 5;
            // 
            // Label_NumeroMatricula
            // 
            this.Label_NumeroMatricula.AutoSize = true;
            this.Label_NumeroMatricula.Location = new System.Drawing.Point(70, 19);
            this.Label_NumeroMatricula.Name = "Label_NumeroMatricula";
            this.Label_NumeroMatricula.Size = new System.Drawing.Size(13, 13);
            this.Label_NumeroMatricula.TabIndex = 73;
            this.Label_NumeroMatricula.Text = "0";
            this.Label_NumeroMatricula.Visible = false;
            // 
            // Label_Matricula
            // 
            this.Label_Matricula.AutoSize = true;
            this.Label_Matricula.Location = new System.Drawing.Point(12, 19);
            this.Label_Matricula.Name = "Label_Matricula";
            this.Label_Matricula.Size = new System.Drawing.Size(52, 13);
            this.Label_Matricula.TabIndex = 72;
            this.Label_Matricula.Text = "Matrícula";
            this.Label_Matricula.Visible = false;
            // 
            // Label_Serie
            // 
            this.Label_Serie.AutoSize = true;
            this.Label_Serie.Location = new System.Drawing.Point(103, 113);
            this.Label_Serie.Name = "Label_Serie";
            this.Label_Serie.Size = new System.Drawing.Size(31, 13);
            this.Label_Serie.TabIndex = 74;
            this.Label_Serie.Text = "Série";
            // 
            // Combo_Serie
            // 
            this.Combo_Serie.FormattingEnabled = true;
            this.Combo_Serie.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.Combo_Serie.Location = new System.Drawing.Point(140, 110);
            this.Combo_Serie.Name = "Combo_Serie";
            this.Combo_Serie.Size = new System.Drawing.Size(137, 21);
            this.Combo_Serie.TabIndex = 75;
            this.Combo_Serie.Text = "-- Selecione --";
            // 
            // Label_Repeticao
            // 
            this.Label_Repeticao.AutoSize = true;
            this.Label_Repeticao.Location = new System.Drawing.Point(78, 140);
            this.Label_Repeticao.Name = "Label_Repeticao";
            this.Label_Repeticao.Size = new System.Drawing.Size(56, 13);
            this.Label_Repeticao.TabIndex = 76;
            this.Label_Repeticao.Text = "Repetição";
            // 
            // Txt_Repeticao
            // 
            this.Txt_Repeticao.Location = new System.Drawing.Point(140, 137);
            this.Txt_Repeticao.Name = "Txt_Repeticao";
            this.Txt_Repeticao.Size = new System.Drawing.Size(137, 20);
            this.Txt_Repeticao.TabIndex = 77;
            // 
            // Txt_Intervalo
            // 
            this.Txt_Intervalo.Location = new System.Drawing.Point(140, 163);
            this.Txt_Intervalo.Name = "Txt_Intervalo";
            this.Txt_Intervalo.Size = new System.Drawing.Size(137, 20);
            this.Txt_Intervalo.TabIndex = 79;
            // 
            // Label_Intervalo
            // 
            this.Label_Intervalo.AutoSize = true;
            this.Label_Intervalo.Location = new System.Drawing.Point(86, 166);
            this.Label_Intervalo.Name = "Label_Intervalo";
            this.Label_Intervalo.Size = new System.Drawing.Size(48, 13);
            this.Label_Intervalo.TabIndex = 78;
            this.Label_Intervalo.Text = "Intervalo";
            // 
            // Txt_Metodo
            // 
            this.Txt_Metodo.Location = new System.Drawing.Point(140, 189);
            this.Txt_Metodo.Name = "Txt_Metodo";
            this.Txt_Metodo.Size = new System.Drawing.Size(137, 20);
            this.Txt_Metodo.TabIndex = 81;
            // 
            // Label_Metodo
            // 
            this.Label_Metodo.AutoSize = true;
            this.Label_Metodo.Location = new System.Drawing.Point(91, 192);
            this.Label_Metodo.Name = "Label_Metodo";
            this.Label_Metodo.Size = new System.Drawing.Size(43, 13);
            this.Label_Metodo.TabIndex = 80;
            this.Label_Metodo.Text = "Método";
            // 
            // Txt_Pse
            // 
            this.Txt_Pse.Location = new System.Drawing.Point(140, 215);
            this.Txt_Pse.Name = "Txt_Pse";
            this.Txt_Pse.Size = new System.Drawing.Size(137, 20);
            this.Txt_Pse.TabIndex = 83;
            // 
            // Label_Pse
            // 
            this.Label_Pse.AutoSize = true;
            this.Label_Pse.Location = new System.Drawing.Point(106, 218);
            this.Label_Pse.Name = "Label_Pse";
            this.Label_Pse.Size = new System.Drawing.Size(28, 13);
            this.Label_Pse.TabIndex = 82;
            this.Label_Pse.Text = "PSE";
            // 
            // Txt_VelocidadeExecucao
            // 
            this.Txt_VelocidadeExecucao.Location = new System.Drawing.Point(140, 241);
            this.Txt_VelocidadeExecucao.Name = "Txt_VelocidadeExecucao";
            this.Txt_VelocidadeExecucao.Size = new System.Drawing.Size(137, 20);
            this.Txt_VelocidadeExecucao.TabIndex = 85;
            // 
            // Label_VelocidadeExecucao
            // 
            this.Label_VelocidadeExecucao.AutoSize = true;
            this.Label_VelocidadeExecucao.Location = new System.Drawing.Point(8, 244);
            this.Label_VelocidadeExecucao.Name = "Label_VelocidadeExecucao";
            this.Label_VelocidadeExecucao.Size = new System.Drawing.Size(126, 13);
            this.Label_VelocidadeExecucao.TabIndex = 84;
            this.Label_VelocidadeExecucao.Text = "Velocidade de Execução";
            // 
            // Label_DataTreino
            // 
            this.Label_DataTreino.AutoSize = true;
            this.Label_DataTreino.Location = new System.Drawing.Point(56, 269);
            this.Label_DataTreino.Name = "Label_DataTreino";
            this.Label_DataTreino.Size = new System.Drawing.Size(78, 13);
            this.Label_DataTreino.TabIndex = 86;
            this.Label_DataTreino.Text = "Data do Treino";
            // 
            // Date_DataTreino
            // 
            this.Date_DataTreino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataTreino.Location = new System.Drawing.Point(140, 269);
            this.Date_DataTreino.Name = "Date_DataTreino";
            this.Date_DataTreino.Size = new System.Drawing.Size(137, 20);
            this.Date_DataTreino.TabIndex = 87;
            // 
            // Btn_CancelarTreino
            // 
            this.Btn_CancelarTreino.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_CancelarTreino.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_CancelarTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CancelarTreino.Location = new System.Drawing.Point(156, 308);
            this.Btn_CancelarTreino.Name = "Btn_CancelarTreino";
            this.Btn_CancelarTreino.Size = new System.Drawing.Size(121, 39);
            this.Btn_CancelarTreino.TabIndex = 89;
            this.Btn_CancelarTreino.Text = "Cancelar";
            this.Btn_CancelarTreino.UseVisualStyleBackColor = false;
            this.Btn_CancelarTreino.Click += new System.EventHandler(this.Btn_CancelarTreino_Click);
            // 
            // Btn_SalvarTreino
            // 
            this.Btn_SalvarTreino.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarTreino.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarTreino.Location = new System.Drawing.Point(15, 308);
            this.Btn_SalvarTreino.Name = "Btn_SalvarTreino";
            this.Btn_SalvarTreino.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarTreino.TabIndex = 88;
            this.Btn_SalvarTreino.Text = "Salvar";
            this.Btn_SalvarTreino.UseVisualStyleBackColor = false;
            this.Btn_SalvarTreino.Click += new System.EventHandler(this.Btn_SalvarTreino_Click);
            // 
            // FormCadastrarTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 370);
            this.Controls.Add(this.Btn_CancelarTreino);
            this.Controls.Add(this.Btn_SalvarTreino);
            this.Controls.Add(this.Date_DataTreino);
            this.Controls.Add(this.Label_DataTreino);
            this.Controls.Add(this.Txt_VelocidadeExecucao);
            this.Controls.Add(this.Label_VelocidadeExecucao);
            this.Controls.Add(this.Txt_Pse);
            this.Controls.Add(this.Label_Pse);
            this.Controls.Add(this.Txt_Metodo);
            this.Controls.Add(this.Label_Metodo);
            this.Controls.Add(this.Txt_Intervalo);
            this.Controls.Add(this.Label_Intervalo);
            this.Controls.Add(this.Txt_Repeticao);
            this.Controls.Add(this.Label_Repeticao);
            this.Controls.Add(this.Combo_Serie);
            this.Controls.Add(this.Label_Serie);
            this.Controls.Add(this.Label_NumeroMatricula);
            this.Controls.Add(this.Label_Matricula);
            this.Controls.Add(this.Txt_Exercicio);
            this.Controls.Add(this.Label_Exercicio);
            this.Controls.Add(this.Txt_NomeTreino);
            this.Controls.Add(this.Label_NomeTreino);
            this.Controls.Add(this.Combo_CadastroTreino);
            this.Controls.Add(this.Label_SiglaTreino);
            this.Name = "FormCadastrarTreino";
            this.Text = "Novo Treino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SiglaTreino;
        private System.Windows.Forms.ComboBox Combo_CadastroTreino;
        private System.Windows.Forms.Label Label_NomeTreino;
        private System.Windows.Forms.TextBox Txt_NomeTreino;
        private System.Windows.Forms.Label Label_Exercicio;
        private System.Windows.Forms.TextBox Txt_Exercicio;
        private System.Windows.Forms.Label Label_NumeroMatricula;
        private System.Windows.Forms.Label Label_Matricula;
        private System.Windows.Forms.Label Label_Serie;
        private System.Windows.Forms.ComboBox Combo_Serie;
        private System.Windows.Forms.Label Label_Repeticao;
        private System.Windows.Forms.TextBox Txt_Repeticao;
        private System.Windows.Forms.TextBox Txt_Intervalo;
        private System.Windows.Forms.Label Label_Intervalo;
        private System.Windows.Forms.TextBox Txt_Metodo;
        private System.Windows.Forms.Label Label_Metodo;
        private System.Windows.Forms.TextBox Txt_Pse;
        private System.Windows.Forms.Label Label_Pse;
        private System.Windows.Forms.TextBox Txt_VelocidadeExecucao;
        private System.Windows.Forms.Label Label_VelocidadeExecucao;
        private System.Windows.Forms.Label Label_DataTreino;
        private System.Windows.Forms.DateTimePicker Date_DataTreino;
        private System.Windows.Forms.Button Btn_CancelarTreino;
        private System.Windows.Forms.Button Btn_SalvarTreino;
    }
}