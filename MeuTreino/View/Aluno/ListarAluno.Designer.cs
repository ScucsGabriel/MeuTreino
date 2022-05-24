namespace MeuTreino
{
    partial class FormListarAluno
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
            this.Btn_BuscarAlunos = new System.Windows.Forms.Button();
            this.Txt_EmailAlunoBusca = new System.Windows.Forms.TextBox();
            this.Label_BuscaEmailAluno = new System.Windows.Forms.Label();
            this.Btn_EditarAluno = new System.Windows.Forms.Button();
            this.Txt_NomeAlunoBusca = new System.Windows.Forms.TextBox();
            this.Label_BuscaNomeAluno = new System.Windows.Forms.Label();
            this.LstView_ListaAluno = new System.Windows.Forms.ListView();
            this.Label_CalculaQuantidadeAluno = new System.Windows.Forms.Label();
            this.Label_QuantidadeAlunos = new System.Windows.Forms.Label();
            this.Label_BuscaTelefoneAluno = new System.Windows.Forms.Label();
            this.Txt_EnderecoAlunoBusca = new System.Windows.Forms.TextBox();
            this.Label_BuscaEnderecoAluno = new System.Windows.Forms.Label();
            this.Btn_CadastrarAluno = new System.Windows.Forms.Button();
            this.Btn_ExcluirAluno = new System.Windows.Forms.Button();
            this.Btn_VoltarPrincipal = new System.Windows.Forms.Button();
            this.Btn_DetalhesAluno = new System.Windows.Forms.Button();
            this.Masked_TelefoneListaAluno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_BuscarAlunos
            // 
            this.Btn_BuscarAlunos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_BuscarAlunos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarAlunos.Location = new System.Drawing.Point(25, 80);
            this.Btn_BuscarAlunos.Name = "Btn_BuscarAlunos";
            this.Btn_BuscarAlunos.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarAlunos.TabIndex = 5;
            this.Btn_BuscarAlunos.Text = "Buscar";
            this.Btn_BuscarAlunos.UseVisualStyleBackColor = false;
            this.Btn_BuscarAlunos.Click += new System.EventHandler(this.Btn_BuscarAlunos_Click);
            // 
            // Txt_EmailAlunoBusca
            // 
            this.Txt_EmailAlunoBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailAlunoBusca.Location = new System.Drawing.Point(370, 12);
            this.Txt_EmailAlunoBusca.Name = "Txt_EmailAlunoBusca";
            this.Txt_EmailAlunoBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_EmailAlunoBusca.TabIndex = 2;
            // 
            // Label_BuscaEmailAluno
            // 
            this.Label_BuscaEmailAluno.AutoSize = true;
            this.Label_BuscaEmailAluno.Location = new System.Drawing.Point(329, 16);
            this.Label_BuscaEmailAluno.Name = "Label_BuscaEmailAluno";
            this.Label_BuscaEmailAluno.Size = new System.Drawing.Size(35, 13);
            this.Label_BuscaEmailAluno.TabIndex = 13;
            this.Label_BuscaEmailAluno.Text = "E-mail";
            // 
            // Btn_EditarAluno
            // 
            this.Btn_EditarAluno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarAluno.Location = new System.Drawing.Point(305, 80);
            this.Btn_EditarAluno.Name = "Btn_EditarAluno";
            this.Btn_EditarAluno.Size = new System.Drawing.Size(134, 34);
            this.Btn_EditarAluno.TabIndex = 7;
            this.Btn_EditarAluno.Text = "Editar";
            this.Btn_EditarAluno.UseVisualStyleBackColor = false;
            this.Btn_EditarAluno.Click += new System.EventHandler(this.Btn_EditarAluno_Click);
            // 
            // Txt_NomeAlunoBusca
            // 
            this.Txt_NomeAlunoBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeAlunoBusca.Location = new System.Drawing.Point(76, 12);
            this.Txt_NomeAlunoBusca.Name = "Txt_NomeAlunoBusca";
            this.Txt_NomeAlunoBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_NomeAlunoBusca.TabIndex = 1;
            // 
            // Label_BuscaNomeAluno
            // 
            this.Label_BuscaNomeAluno.AutoSize = true;
            this.Label_BuscaNomeAluno.Location = new System.Drawing.Point(35, 16);
            this.Label_BuscaNomeAluno.Name = "Label_BuscaNomeAluno";
            this.Label_BuscaNomeAluno.Size = new System.Drawing.Size(35, 13);
            this.Label_BuscaNomeAluno.TabIndex = 12;
            this.Label_BuscaNomeAluno.Text = "Nome";
            // 
            // LstView_ListaAluno
            // 
            this.LstView_ListaAluno.AllowColumnReorder = true;
            this.LstView_ListaAluno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaAluno.HideSelection = false;
            this.LstView_ListaAluno.Location = new System.Drawing.Point(25, 136);
            this.LstView_ListaAluno.Name = "LstView_ListaAluno";
            this.LstView_ListaAluno.Size = new System.Drawing.Size(1308, 499);
            this.LstView_ListaAluno.TabIndex = 11;
            this.LstView_ListaAluno.UseCompatibleStateImageBehavior = false;
            this.LstView_ListaAluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_ListaAluno_KeyDown);
            // 
            // Label_CalculaQuantidadeAluno
            // 
            this.Label_CalculaQuantidadeAluno.AutoSize = true;
            this.Label_CalculaQuantidadeAluno.Location = new System.Drawing.Point(22, 678);
            this.Label_CalculaQuantidadeAluno.Name = "Label_CalculaQuantidadeAluno";
            this.Label_CalculaQuantidadeAluno.Size = new System.Drawing.Size(13, 13);
            this.Label_CalculaQuantidadeAluno.TabIndex = 17;
            this.Label_CalculaQuantidadeAluno.Text = "0";
            // 
            // Label_QuantidadeAlunos
            // 
            this.Label_QuantidadeAlunos.AutoSize = true;
            this.Label_QuantidadeAlunos.Location = new System.Drawing.Point(22, 647);
            this.Label_QuantidadeAlunos.Name = "Label_QuantidadeAlunos";
            this.Label_QuantidadeAlunos.Size = new System.Drawing.Size(112, 13);
            this.Label_QuantidadeAlunos.TabIndex = 16;
            this.Label_QuantidadeAlunos.Text = "Quantidade de Alunos";
            // 
            // Label_BuscaTelefoneAluno
            // 
            this.Label_BuscaTelefoneAluno.AutoSize = true;
            this.Label_BuscaTelefoneAluno.Location = new System.Drawing.Point(22, 43);
            this.Label_BuscaTelefoneAluno.Name = "Label_BuscaTelefoneAluno";
            this.Label_BuscaTelefoneAluno.Size = new System.Drawing.Size(49, 13);
            this.Label_BuscaTelefoneAluno.TabIndex = 14;
            this.Label_BuscaTelefoneAluno.Text = "Telefone";
            // 
            // Txt_EnderecoAlunoBusca
            // 
            this.Txt_EnderecoAlunoBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EnderecoAlunoBusca.Location = new System.Drawing.Point(370, 39);
            this.Txt_EnderecoAlunoBusca.Name = "Txt_EnderecoAlunoBusca";
            this.Txt_EnderecoAlunoBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_EnderecoAlunoBusca.TabIndex = 4;
            // 
            // Label_BuscaEnderecoAluno
            // 
            this.Label_BuscaEnderecoAluno.AutoSize = true;
            this.Label_BuscaEnderecoAluno.Location = new System.Drawing.Point(316, 43);
            this.Label_BuscaEnderecoAluno.Name = "Label_BuscaEnderecoAluno";
            this.Label_BuscaEnderecoAluno.Size = new System.Drawing.Size(53, 13);
            this.Label_BuscaEnderecoAluno.TabIndex = 15;
            this.Label_BuscaEnderecoAluno.Text = "Endereço";
            // 
            // Btn_CadastrarAluno
            // 
            this.Btn_CadastrarAluno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_CadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CadastrarAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_CadastrarAluno.Location = new System.Drawing.Point(165, 80);
            this.Btn_CadastrarAluno.Name = "Btn_CadastrarAluno";
            this.Btn_CadastrarAluno.Size = new System.Drawing.Size(134, 34);
            this.Btn_CadastrarAluno.TabIndex = 6;
            this.Btn_CadastrarAluno.Text = "Cadastrar";
            this.Btn_CadastrarAluno.UseVisualStyleBackColor = false;
            this.Btn_CadastrarAluno.Click += new System.EventHandler(this.Btn_CadastrarAluno_Click);
            // 
            // Btn_ExcluirAluno
            // 
            this.Btn_ExcluirAluno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirAluno.Location = new System.Drawing.Point(445, 80);
            this.Btn_ExcluirAluno.Name = "Btn_ExcluirAluno";
            this.Btn_ExcluirAluno.Size = new System.Drawing.Size(134, 34);
            this.Btn_ExcluirAluno.TabIndex = 8;
            this.Btn_ExcluirAluno.Text = "Excluir";
            this.Btn_ExcluirAluno.UseVisualStyleBackColor = false;
            this.Btn_ExcluirAluno.Click += new System.EventHandler(this.Btn_ExcluirAluno_Click);
            // 
            // Btn_VoltarPrincipal
            // 
            this.Btn_VoltarPrincipal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarPrincipal.Location = new System.Drawing.Point(585, 80);
            this.Btn_VoltarPrincipal.Name = "Btn_VoltarPrincipal";
            this.Btn_VoltarPrincipal.Size = new System.Drawing.Size(134, 34);
            this.Btn_VoltarPrincipal.TabIndex = 9;
            this.Btn_VoltarPrincipal.Text = "Voltar";
            this.Btn_VoltarPrincipal.UseVisualStyleBackColor = false;
            this.Btn_VoltarPrincipal.Click += new System.EventHandler(this.Btn_VoltarPrincipal_Click);
            // 
            // Btn_DetalhesAluno
            // 
            this.Btn_DetalhesAluno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_DetalhesAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DetalhesAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_DetalhesAluno.Location = new System.Drawing.Point(1199, 81);
            this.Btn_DetalhesAluno.Name = "Btn_DetalhesAluno";
            this.Btn_DetalhesAluno.Size = new System.Drawing.Size(134, 33);
            this.Btn_DetalhesAluno.TabIndex = 10;
            this.Btn_DetalhesAluno.Text = "Detalhes";
            this.Btn_DetalhesAluno.UseVisualStyleBackColor = false;
            this.Btn_DetalhesAluno.Click += new System.EventHandler(this.Btn_DetalhesAluno_Click);
            // 
            // Masked_TelefoneListaAluno
            // 
            this.Masked_TelefoneListaAluno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masked_TelefoneListaAluno.Location = new System.Drawing.Point(76, 43);
            this.Masked_TelefoneListaAluno.Mask = "(##) # ####-####";
            this.Masked_TelefoneListaAluno.Name = "Masked_TelefoneListaAluno";
            this.Masked_TelefoneListaAluno.Size = new System.Drawing.Size(237, 21);
            this.Masked_TelefoneListaAluno.TabIndex = 3;
            // 
            // FormListarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 707);
            this.Controls.Add(this.Masked_TelefoneListaAluno);
            this.Controls.Add(this.Btn_DetalhesAluno);
            this.Controls.Add(this.Btn_VoltarPrincipal);
            this.Controls.Add(this.Btn_ExcluirAluno);
            this.Controls.Add(this.Btn_CadastrarAluno);
            this.Controls.Add(this.Txt_EnderecoAlunoBusca);
            this.Controls.Add(this.Label_BuscaEnderecoAluno);
            this.Controls.Add(this.Label_BuscaTelefoneAluno);
            this.Controls.Add(this.Label_CalculaQuantidadeAluno);
            this.Controls.Add(this.Label_QuantidadeAlunos);
            this.Controls.Add(this.Btn_BuscarAlunos);
            this.Controls.Add(this.Txt_EmailAlunoBusca);
            this.Controls.Add(this.Label_BuscaEmailAluno);
            this.Controls.Add(this.Btn_EditarAluno);
            this.Controls.Add(this.Txt_NomeAlunoBusca);
            this.Controls.Add(this.Label_BuscaNomeAluno);
            this.Controls.Add(this.LstView_ListaAluno);
            this.Name = "FormListarAluno";
            this.Text = "Listar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_BuscarAlunos;
        private System.Windows.Forms.TextBox Txt_EmailAlunoBusca;
        private System.Windows.Forms.Label Label_BuscaEmailAluno;
        private System.Windows.Forms.Button Btn_EditarAluno;
        private System.Windows.Forms.TextBox Txt_NomeAlunoBusca;
        private System.Windows.Forms.Label Label_BuscaNomeAluno;
        private System.Windows.Forms.ListView LstView_ListaAluno;
        private System.Windows.Forms.Label Label_CalculaQuantidadeAluno;
        private System.Windows.Forms.Label Label_QuantidadeAlunos;
        private System.Windows.Forms.Label Label_BuscaTelefoneAluno;
        private System.Windows.Forms.TextBox Txt_EnderecoAlunoBusca;
        private System.Windows.Forms.Label Label_BuscaEnderecoAluno;
        private System.Windows.Forms.Button Btn_CadastrarAluno;
        private System.Windows.Forms.Button Btn_ExcluirAluno;
        private System.Windows.Forms.Button Btn_VoltarPrincipal;
        private System.Windows.Forms.Button Btn_DetalhesAluno;
        private System.Windows.Forms.MaskedTextBox Masked_TelefoneListaAluno;
    }
}