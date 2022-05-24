using MeuTreino.Controller;
using MeuTreino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuTreino
{
    public partial class FormEditarAluno : Form
    {
        public FormEditarAluno(List<Aluno> listaAluno)
        {
            InitializeComponent();
            foreach (var item in listaAluno)
            {
                Label_CodigoAluno.Text = item.idAluno.ToString();
                Txt_NomeAlunoEdit.Text = item.nomeAluno;
                Txt_EmailAlunoEdit.Text = item.emailAluno;
                Txt_EnderecoAlunoEdit.Text = item.enderecoAluno;
                Txt_IdadeAlunoEdit.Text = item.idadeAluno.ToString();
                Masked_TelefoneEdit.Text = item.telefoneAluno;
            }
        }

        private void Btn_SalvarAlunoEdit_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string alunoAtivo = "Sim";
            AlunoController editarAluno = new AlunoController();
            editarAluno.EditarAluno(Convert.ToInt32(Label_CodigoAluno.Text), Txt_NomeAlunoEdit.Text.Trim(), Txt_EmailAlunoEdit.Text.Trim(),
                Masked_TelefoneEdit.Text.Trim(), Txt_EnderecoAlunoEdit.Text.Trim(), Convert.ToInt32(Txt_IdadeAlunoEdit.Text.Trim()), alunoAtivo);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Limpar()
        {
            Txt_NomeAlunoEdit.Text = "";
            Txt_EmailAlunoEdit.Text = "";
            Masked_TelefoneEdit.Text = "";
            Txt_EnderecoAlunoEdit.Text = "";
            Txt_IdadeAlunoEdit.Text = "";
        }

        private bool ValidarPreenchimento()
        {

            if (Txt_NomeAlunoEdit.Text == "")
            {
                MessageBox.Show("Nome do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeAlunoEdit.Text) == false)
            {
                MessageBox.Show("Nome do aluno não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeAlunoEdit.Text.Length > 100)
            {
                MessageBox.Show("Nome do aluno está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IdadeAlunoEdit.Text == "")
            {
                MessageBox.Show("Idade está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_IdadeAlunoEdit.Text) == false)
            {
                MessageBox.Show("Idade não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IdadeAlunoEdit.Text.Length > 3)
            {
                MessageBox.Show("Idade está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailAlunoEdit.Text == "")
            {
                MessageBox.Show("E-mail está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmail(Txt_EmailAlunoEdit.Text) == false)
            {
                MessageBox.Show("E-mail não está num formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailAlunoEdit.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EnderecoAlunoEdit.Text == "")
            {
                MessageBox.Show("Endereço está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EnderecoAlunoEdit.Text.Length > 150)
            {
                MessageBox.Show("Endereço está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Masked_TelefoneEdit.MaskFull)
            {
                MessageBox.Show("Telefone está vazio ou incompleto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool IsNome(string strNome)
        {
            for (int i = 0; i < strNome.Length; i++)
            {
                if (!Char.IsLetter(strNome, i) && !Char.IsWhiteSpace(strNome, i))
                    return false;
            }
            return true;
        }
        public static bool IsNumber(string intIdade)
        {
            string strModelo = "[0-9]";
            if (System.Text.RegularExpressions.Regex.IsMatch(intIdade, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Btn_CancelarAlunoEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
    }
}
