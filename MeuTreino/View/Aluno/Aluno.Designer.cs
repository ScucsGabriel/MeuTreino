namespace MeuTreino
{
    partial class FormAluno
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
            this.Masked_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Txt_NomeAluno = new System.Windows.Forms.TextBox();
            this.Label_NomeAluno = new System.Windows.Forms.Label();
            this.Btn_SalvarAluno = new System.Windows.Forms.Button();
            this.Label_TelefoneAluno = new System.Windows.Forms.Label();
            this.Txt_EmailAluno = new System.Windows.Forms.TextBox();
            this.Label_EmailAluno = new System.Windows.Forms.Label();
            this.Label_EnderecoAluno = new System.Windows.Forms.Label();
            this.Txt_EnderecoAluno = new System.Windows.Forms.TextBox();
            this.Label_IdadeAluno = new System.Windows.Forms.Label();
            this.Txt_IdadeAluno = new System.Windows.Forms.TextBox();
            this.Btn_CancelarAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Masked_Telefone
            // 
            this.Masked_Telefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masked_Telefone.Location = new System.Drawing.Point(108, 120);
            this.Masked_Telefone.Mask = "(##) # ####-####";
            this.Masked_Telefone.Name = "Masked_Telefone";
            this.Masked_Telefone.Size = new System.Drawing.Size(106, 21);
            this.Masked_Telefone.TabIndex = 4;
            // 
            // Txt_NomeAluno
            // 
            this.Txt_NomeAluno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeAluno.Location = new System.Drawing.Point(108, 26);
            this.Txt_NomeAluno.Name = "Txt_NomeAluno";
            this.Txt_NomeAluno.Size = new System.Drawing.Size(339, 21);
            this.Txt_NomeAluno.TabIndex = 1;
            // 
            // Label_NomeAluno
            // 
            this.Label_NomeAluno.AutoSize = true;
            this.Label_NomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NomeAluno.Location = new System.Drawing.Point(61, 28);
            this.Label_NomeAluno.Name = "Label_NomeAluno";
            this.Label_NomeAluno.Size = new System.Drawing.Size(41, 15);
            this.Label_NomeAluno.TabIndex = 8;
            this.Label_NomeAluno.Text = "Nome";
            // 
            // Btn_SalvarAluno
            // 
            this.Btn_SalvarAluno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarAluno.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarAluno.Location = new System.Drawing.Point(45, 220);
            this.Btn_SalvarAluno.Name = "Btn_SalvarAluno";
            this.Btn_SalvarAluno.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarAluno.TabIndex = 6;
            this.Btn_SalvarAluno.Text = "Salvar";
            this.Btn_SalvarAluno.UseVisualStyleBackColor = false;
            this.Btn_SalvarAluno.Click += new System.EventHandler(this.Btn_SalvarAluno_Click);
            // 
            // Label_TelefoneAluno
            // 
            this.Label_TelefoneAluno.AutoSize = true;
            this.Label_TelefoneAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TelefoneAluno.Location = new System.Drawing.Point(47, 126);
            this.Label_TelefoneAluno.Name = "Label_TelefoneAluno";
            this.Label_TelefoneAluno.Size = new System.Drawing.Size(55, 15);
            this.Label_TelefoneAluno.TabIndex = 11;
            this.Label_TelefoneAluno.Text = "Telefone";
            // 
            // Txt_EmailAluno
            // 
            this.Txt_EmailAluno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailAluno.Location = new System.Drawing.Point(108, 87);
            this.Txt_EmailAluno.Name = "Txt_EmailAluno";
            this.Txt_EmailAluno.Size = new System.Drawing.Size(339, 21);
            this.Txt_EmailAluno.TabIndex = 3;
            // 
            // Label_EmailAluno
            // 
            this.Label_EmailAluno.AutoSize = true;
            this.Label_EmailAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EmailAluno.Location = new System.Drawing.Point(59, 92);
            this.Label_EmailAluno.Name = "Label_EmailAluno";
            this.Label_EmailAluno.Size = new System.Drawing.Size(43, 15);
            this.Label_EmailAluno.TabIndex = 10;
            this.Label_EmailAluno.Text = "E-mail";
            // 
            // Label_EnderecoAluno
            // 
            this.Label_EnderecoAluno.AutoSize = true;
            this.Label_EnderecoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EnderecoAluno.Location = new System.Drawing.Point(42, 163);
            this.Label_EnderecoAluno.Name = "Label_EnderecoAluno";
            this.Label_EnderecoAluno.Size = new System.Drawing.Size(60, 15);
            this.Label_EnderecoAluno.TabIndex = 12;
            this.Label_EnderecoAluno.Text = "Endereço";
            // 
            // Txt_EnderecoAluno
            // 
            this.Txt_EnderecoAluno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EnderecoAluno.Location = new System.Drawing.Point(108, 151);
            this.Txt_EnderecoAluno.Multiline = true;
            this.Txt_EnderecoAluno.Name = "Txt_EnderecoAluno";
            this.Txt_EnderecoAluno.Size = new System.Drawing.Size(339, 46);
            this.Txt_EnderecoAluno.TabIndex = 5;
            // 
            // Label_IdadeAluno
            // 
            this.Label_IdadeAluno.AutoSize = true;
            this.Label_IdadeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_IdadeAluno.Location = new System.Drawing.Point(64, 60);
            this.Label_IdadeAluno.Name = "Label_IdadeAluno";
            this.Label_IdadeAluno.Size = new System.Drawing.Size(38, 15);
            this.Label_IdadeAluno.TabIndex = 9;
            this.Label_IdadeAluno.Text = "Idade";
            // 
            // Txt_IdadeAluno
            // 
            this.Txt_IdadeAluno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdadeAluno.Location = new System.Drawing.Point(108, 58);
            this.Txt_IdadeAluno.Name = "Txt_IdadeAluno";
            this.Txt_IdadeAluno.Size = new System.Drawing.Size(56, 21);
            this.Txt_IdadeAluno.TabIndex = 2;
            // 
            // Btn_CancelarAluno
            // 
            this.Btn_CancelarAluno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_CancelarAluno.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_CancelarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CancelarAluno.Location = new System.Drawing.Point(326, 220);
            this.Btn_CancelarAluno.Name = "Btn_CancelarAluno";
            this.Btn_CancelarAluno.Size = new System.Drawing.Size(121, 39);
            this.Btn_CancelarAluno.TabIndex = 7;
            this.Btn_CancelarAluno.Text = "Cancelar";
            this.Btn_CancelarAluno.UseVisualStyleBackColor = false;
            this.Btn_CancelarAluno.Click += new System.EventHandler(this.Btn_CancelarAluno_Click);
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 285);
            this.Controls.Add(this.Btn_CancelarAluno);
            this.Controls.Add(this.Txt_IdadeAluno);
            this.Controls.Add(this.Label_IdadeAluno);
            this.Controls.Add(this.Txt_EnderecoAluno);
            this.Controls.Add(this.Label_EnderecoAluno);
            this.Controls.Add(this.Masked_Telefone);
            this.Controls.Add(this.Txt_NomeAluno);
            this.Controls.Add(this.Label_NomeAluno);
            this.Controls.Add(this.Btn_SalvarAluno);
            this.Controls.Add(this.Label_TelefoneAluno);
            this.Controls.Add(this.Txt_EmailAluno);
            this.Controls.Add(this.Label_EmailAluno);
            this.Name = "FormAluno";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Masked_Telefone;
        private System.Windows.Forms.TextBox Txt_NomeAluno;
        private System.Windows.Forms.Label Label_NomeAluno;
        private System.Windows.Forms.Button Btn_SalvarAluno;
        private System.Windows.Forms.Label Label_TelefoneAluno;
        private System.Windows.Forms.TextBox Txt_EmailAluno;
        private System.Windows.Forms.Label Label_EmailAluno;
        private System.Windows.Forms.Label Label_EnderecoAluno;
        private System.Windows.Forms.TextBox Txt_EnderecoAluno;
        private System.Windows.Forms.Label Label_IdadeAluno;
        private System.Windows.Forms.TextBox Txt_IdadeAluno;
        private System.Windows.Forms.Button Btn_CancelarAluno;
    }
}