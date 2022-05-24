using MeuTreino.Controller;
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
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        private void Btn_SalvarAluno_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string alunoAtivo = "Sim";
            AlunoController inserirAluno = new AlunoController();
            inserirAluno.InserirAluno(Txt_NomeAluno.Text.Trim(), Txt_EmailAluno.Text.Trim(), Masked_Telefone.Text.Trim(),
                 Txt_EnderecoAluno.Text.Trim(), Convert.ToInt32(Txt_IdadeAluno.Text.Trim()), alunoAtivo);

            int ultimoAlunoInserido = inserirAluno.ConsultarUltimoAlunoInserido();

            float peso = 0, altura = 0, ombro = 0, cintura = 0, abdomen = 0, coxaDireita = 0, panturrilhaDireita = 0,
                  bracoRelaxadoDireito = 0, bracoContraidoDireito = 0, antebracoDireito = 0, abdominal = 0, triceps = 0, suprailiaca = 0,
                  axilarMedia = 0, subescapular = 0, torax = 0, coxa = 0, imc = 0, percentualMassaGorda = 0, percentualMassaMagra = 0,
                  pesoMassaGorda = 0, pesoMassaMagra = 0, somaDobras = 0, areaMuscularBraco = 0, areaGorduraBraco = 0;


            DateTime dataAvaliacao = DateTime.Now.Date;

            MedidasController inserirMedidas = new MedidasController();
            inserirMedidas.InserirMedidas(ultimoAlunoInserido, peso, altura, ombro, cintura, abdomen, coxaDireita, panturrilhaDireita, bracoRelaxadoDireito,
                bracoContraidoDireito, antebracoDireito, abdominal, triceps, suprailiaca, axilarMedia, subescapular, torax, coxa, imc, percentualMassaGorda, 
                percentualMassaMagra, pesoMassaGorda, pesoMassaMagra, somaDobras, areaMuscularBraco, areaGorduraBraco, dataAvaliacao);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void Limpar()
        {
            Txt_NomeAluno.Text = "";
            Txt_EmailAluno.Text = "";
            Masked_Telefone.Text = "";
            Txt_EnderecoAluno.Text = "";
            Txt_IdadeAluno.Text = "";
        }

        private bool ValidarPreenchimento()
        {

            if (Txt_NomeAluno.Text == "")
            {
                MessageBox.Show("Nome do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeAluno.Text) == false)
            {
                MessageBox.Show("Nome do aluno não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeAluno.Text.Length > 100)
            {
                MessageBox.Show("Nome do aluno está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IdadeAluno.Text == "")
            {
                MessageBox.Show("Idade está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_IdadeAluno.Text) == false)
            {
                MessageBox.Show("Idade não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IdadeAluno.Text.Length > 3)
            {
                MessageBox.Show("Idade está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailAluno.Text == "")
            {
                MessageBox.Show("E-mail está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmail(Txt_EmailAluno.Text) == false)
            {
                MessageBox.Show("E-mail não está num formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailAluno.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EnderecoAluno.Text == "")
            {
                MessageBox.Show("Endereço está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EnderecoAluno.Text.Length > 150)
            {
                MessageBox.Show("Endereço está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Masked_Telefone.MaskFull)
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

        private void Btn_CancelarAluno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
    }
}
