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
    public partial class FormEditarTreino : Form
    {
        public FormEditarTreino(List<MeuTreino.Model.Treino> treinoSelecionado)
        {
            InitializeComponent();
            foreach (var item in treinoSelecionado)
            {
                Label_NumeroCodigoTreino.Text = item.idTreino.ToString();
                Label_NumeroMatriculaEditar.Text = item.idAlunoTreino.ToString();
                Combo_CadastroTreinoEditar.ValueMember = item.siglaTreino.ToString();
                Combo_CadastroTreinoEditar.Text = item.siglaTreino.ToString();
                Txt_NomeTreinoEditar.Text = item.nomeTreino.ToString();
                Txt_ExercicioEditar.Text = item.exercicio.ToString();
                Combo_SerieEditar.ValueMember = item.serie.ToString();
                Combo_SerieEditar.Text = item.serie.ToString();
                Txt_RepeticaoEditar.Text = item.repeticao.ToString();
                Txt_IntervaloEditar.Text = item.intervalo.ToString();
                Txt_MetodoEditar.Text = item.metodo.ToString();
                Txt_PseEditar.Text = item.pse.ToString();
                Txt_VelocidadeExecucaoEditar.Text = item.velocidadeExecucao.ToString();
                Date_DataTreinoEditar.Value = item.dataTreino;
            }           
        }

        private void FormEditarTreino_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarPreenchimento()
        {

            if (Combo_CadastroTreinoEditar.Text == "-- Selecione --")
            {
                MessageBox.Show("Selecione a sigla do treino.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeTreinoEditar.Text == "")
            {
                MessageBox.Show("Grupo muscular está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeTreinoEditar.Text.Length > 100)
            {
                MessageBox.Show("Grupo muscular está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_ExercicioEditar.Text == "")
            {
                MessageBox.Show("Exercício está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_ExercicioEditar.Text.Length > 100)
            {
                MessageBox.Show("Exercício está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Combo_SerieEditar.Text == "-- Selecione --")
            {
                MessageBox.Show("Selecione a série.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_RepeticaoEditar.Text == "")
            {
                MessageBox.Show("Repetição está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_RepeticaoEditar.Text.Length > 100)
            {
                MessageBox.Show("Repetição está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IntervaloEditar.Text == "")
            {
                MessageBox.Show("Intervalo está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IntervaloEditar.Text.Length > 100)
            {
                MessageBox.Show("Intervalo está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_MetodoEditar.Text == "")
            {
                MessageBox.Show("Método está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_MetodoEditar.Text.Length > 100)
            {
                MessageBox.Show("Método está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_PseEditar.Text == "")
            {
                MessageBox.Show("PSE está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_PseEditar.Text.Length > 100)
            {
                MessageBox.Show("PSE está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_VelocidadeExecucaoEditar.Text == "")
            {
                MessageBox.Show("Velocidade de Execução está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_VelocidadeExecucaoEditar.Text.Length > 100)
            {
                MessageBox.Show("Velocidade de Execução está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Btn_CancelarTreinoEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void Btn_SalvarTreinoEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string treinoAtivo = "Sim";
            TreinoController atualizarTreino = new TreinoController();
            atualizarTreino.AtualizarTreino(Convert.ToInt32(Label_NumeroCodigoTreino.Text), Convert.ToInt32(Label_NumeroMatriculaEditar.Text), Combo_CadastroTreinoEditar.Text.Trim(), Txt_NomeTreinoEditar.Text.Trim(),
                Txt_ExercicioEditar.Text.Trim(), Convert.ToInt32(Combo_SerieEditar.Text.Trim()), Txt_RepeticaoEditar.Text.Trim(), Txt_IntervaloEditar.Text.Trim(),
                Txt_MetodoEditar.Text.Trim(), Txt_PseEditar.Text.Trim(), Txt_VelocidadeExecucaoEditar.Text.Trim(), Date_DataTreinoEditar.Value, treinoAtivo);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
