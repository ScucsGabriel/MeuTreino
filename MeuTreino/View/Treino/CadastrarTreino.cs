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

namespace MeuTreino.View.Treino
{
    public partial class FormCadastrarTreino : Form
    {
        public FormCadastrarTreino(int numeroMatricula)
        {
            InitializeComponent();
            Label_NumeroMatricula.Text = numeroMatricula.ToString();
        }

        private void Btn_SalvarTreino_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string treinoAtivo = "Sim";
            TreinoController inserirTreino = new TreinoController();
            inserirTreino.InserirTreino(Convert.ToInt32(Label_NumeroMatricula.Text), Combo_CadastroTreino.Text.Trim(), Txt_NomeTreino.Text.Trim(),
                Txt_Exercicio.Text.Trim(), Convert.ToInt32(Combo_Serie.Text.Trim()), Txt_Repeticao.Text.Trim(), Txt_Intervalo.Text.Trim(), 
                Txt_Metodo.Text.Trim(), Txt_Pse.Text.Trim(), Txt_VelocidadeExecucao.Text.Trim(), Date_DataTreino.Value, treinoAtivo);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Deseja incluir novo Treino?", "Continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                this.Close();
            else
                Limpar();
        }

        private void Limpar()
        {
            Combo_CadastroTreino.Text = "-- Selecione --";
            Txt_NomeTreino.Text = "";
            Txt_Exercicio.Text = "";
            Combo_Serie.Text = "-- Selecione --";
            Txt_Repeticao.Text = "";
            Txt_Intervalo.Text = "";
            Txt_Metodo.Text = "";
            Txt_Pse.Text = "";
            Txt_VelocidadeExecucao.Text = "";
        }

        private bool ValidarPreenchimento()
        {

            if (Combo_CadastroTreino.Text == "-- Selecione --")
            {
                MessageBox.Show("Selecione a sigla do treino.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeTreino.Text == "")
            {
                MessageBox.Show("Grupo muscular está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeTreino.Text.Length > 100)
            {
                MessageBox.Show("Grupo muscular está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Exercicio.Text == "")
            {
                MessageBox.Show("Exercício está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Exercicio.Text.Length > 100)
            {
                MessageBox.Show("Exercício está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Combo_Serie.Text == "-- Selecione --")
            {
                MessageBox.Show("Selecione a série.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Repeticao.Text == "")
            {
                MessageBox.Show("Repetição está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Repeticao.Text.Length > 100)
            {
                MessageBox.Show("Repetição está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Intervalo.Text == "")
            {
                MessageBox.Show("Intervalo está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Intervalo.Text.Length > 100)
            {
                MessageBox.Show("Intervalo está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Metodo.Text == "")
            {
                MessageBox.Show("Método está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Metodo.Text.Length > 100)
            {
                MessageBox.Show("Método está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Pse.Text == "")
            {
                MessageBox.Show("PSE está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Pse.Text.Length > 100)
            {
                MessageBox.Show("PSE está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_VelocidadeExecucao.Text == "")
            {
                MessageBox.Show("Velocidade de Execução está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_VelocidadeExecucao.Text.Length > 100)
            {
                MessageBox.Show("Velocidade de Execução está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Btn_CancelarTreino_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
    }
}
