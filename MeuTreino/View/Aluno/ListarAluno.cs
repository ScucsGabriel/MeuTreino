using MeuTreino.Controller;
using MeuTreino.Model;
using MeuTreino.View.Medidas;
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
    public partial class FormListarAluno : Form
    {
        public FormListarAluno()
        {
            InitializeComponent();
        }

        private void Btn_CadastrarAluno_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.ShowDialog();
        }

        private void Btn_EditarAluno_Click(object sender, EventArgs e)
        {
            if (LstView_ListaAluno.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaAluno.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AlunoController listarAluno = new AlunoController();
            List<Aluno> alunosSelecionados = new List<Aluno>();
            int idAluno = Convert.ToInt32(LstView_ListaAluno.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarAluno.ConsultarAlunoPorId(idAluno))
            {
                Aluno aluno = new Aluno();
                aluno.idAluno = item.idAluno;
                aluno.nomeAluno = item.nomeAluno;
                aluno.emailAluno = item.emailAluno;
                aluno.telefoneAluno = item.telefoneAluno;
                aluno.enderecoAluno = item.enderecoAluno;
                aluno.idadeAluno = item.idadeAluno;
                aluno.alunoAtivo = item.alunoAtivo;

                alunosSelecionados.Add(aluno);
            }

            FormEditarAluno formEditarAluno = new FormEditarAluno(alunosSelecionados);
            formEditarAluno.ShowDialog();

            if ((Txt_NomeAlunoBusca.Text != "" && Txt_EmailAlunoBusca.Text != "") || (Txt_NomeAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "") ||
                (Txt_NomeAlunoBusca.Text != "" && Txt_EnderecoAlunoBusca.Text != "") || (Txt_EmailAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "") ||
                (Txt_EmailAlunoBusca.Text != "" && Txt_EnderecoAlunoBusca.Text != "") || (Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "" && Txt_EnderecoAlunoBusca.Text != "") ||
                (Txt_NomeAlunoBusca.Text != "" && Txt_EmailAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "") != "") ||
                (Txt_NomeAlunoBusca.Text != "" && Txt_EmailAlunoBusca.Text != "" && Txt_EnderecoAlunoBusca.Text != "") ||
                (Txt_EmailAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "" && Txt_EnderecoAlunoBusca.Text != "") ||
                (Txt_EmailAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "" && Txt_EnderecoAlunoBusca.Text != "") && Txt_EnderecoAlunoBusca.Text != "")
            {
                MessageBox.Show("Há mais de um campo preenchido. Preencha somente um campo para busca!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_NomeAlunoBusca.Text != "")
                PreencherListView_NomeAluno(Txt_NomeAlunoBusca.Text);
            else if (Txt_EmailAlunoBusca.Text != "")
                PreencherListView_EmailAluno(Txt_EmailAlunoBusca.Text);
            else if (Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "")
                PreencherListView_TelefoneAluno(Masked_TelefoneListaAluno.Text);
            else if (Txt_EnderecoAlunoBusca.Text != "")
                PreencherListView_EnderecoAluno(Txt_EnderecoAlunoBusca.Text);
            else
                PreencherListView_TodosAlunos();

            LstView_ListaAluno.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_NomeAluno(string nomeAluno)
        {
            LimparFormLista();
            PreencherColumnHeader();
            AlunoController listarAluno = new AlunoController();
            int resultadoBusca = listarAluno.ConsultarAlunoPorNome(nomeAluno).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este aluno!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarAluno.ConsultarAlunoPorNome(nomeAluno))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idAluno.ToString(), item.nomeAluno.ToString(), item.emailAluno.ToString(), item.telefoneAluno.ToString(), item.enderecoAluno.ToString(),
                item.idadeAluno.ToString()});
                    LstView_ListaAluno.Items.Add(listViewItem);
                    Label_CalculaQuantidadeAluno.Text = Convert.ToString(LstView_ListaAluno.Items.Count);
                }
            }
        }

        private void PreencherListView_EmailAluno(string emailAluno)
        {
            LimparFormLista();
            PreencherColumnHeader();
            AlunoController listarAluno = new AlunoController();
            int resultadoBusca = listarAluno.ConsultarAlunoPorEmail(emailAluno).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este aluno!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarAluno.ConsultarAlunoPorEmail(emailAluno))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idAluno.ToString(), item.nomeAluno.ToString(), item.emailAluno.ToString(), item.telefoneAluno.ToString(), item.enderecoAluno.ToString(),
                item.idadeAluno.ToString()});
                    LstView_ListaAluno.Items.Add(listViewItem);
                    Label_CalculaQuantidadeAluno.Text = Convert.ToString(LstView_ListaAluno.Items.Count);
                }
            }
        }

        private void PreencherListView_TelefoneAluno(string telefoneAluno)
        {
            LimparFormLista();
            PreencherColumnHeader();
            AlunoController listarAluno = new AlunoController();
            int resultadoBusca = listarAluno.ConsultarAlunoPorTelefone(telefoneAluno).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este aluno!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarAluno.ConsultarAlunoPorTelefone(telefoneAluno))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idAluno.ToString(), item.nomeAluno.ToString(), item.emailAluno.ToString(), item.telefoneAluno.ToString(), item.enderecoAluno.ToString(),
                item.idadeAluno.ToString()});
                    LstView_ListaAluno.Items.Add(listViewItem);
                    Label_CalculaQuantidadeAluno.Text = Convert.ToString(LstView_ListaAluno.Items.Count);
                }
            }
        }

        private void PreencherListView_EnderecoAluno(string enderecoAluno)
        {
            LimparFormLista();
            PreencherColumnHeader();
            AlunoController listarAluno = new AlunoController();
            int resultadoBusca = listarAluno.ConsultarAlunoPorEndereco(enderecoAluno).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este aluno!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarAluno.ConsultarAlunoPorEndereco(enderecoAluno))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idAluno.ToString(), item.nomeAluno.ToString(), item.emailAluno.ToString(), item.telefoneAluno.ToString(), item.enderecoAluno.ToString(),
                item.idadeAluno.ToString()});
                    LstView_ListaAluno.Items.Add(listViewItem);
                    Label_CalculaQuantidadeAluno.Text = Convert.ToString(LstView_ListaAluno.Items.Count);
                }
            }
        }

        private void PreencherListView_TodosAlunos()
        {
            LimparFormLista();
            PreencherColumnHeader();
            AlunoController listarAluno = new AlunoController();
            int resultadoBusca = listarAluno.ConsultarTodoAlunoAtivo().Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros de alunos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarAluno.ConsultarTodoAlunoAtivo())
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idAluno.ToString(), item.nomeAluno.ToString(), item.emailAluno.ToString(), item.telefoneAluno.ToString(), item.enderecoAluno.ToString(),
                item.idadeAluno.ToString()});
                    LstView_ListaAluno.Items.Add(listViewItem);
                    Label_CalculaQuantidadeAluno.Text = Convert.ToString(LstView_ListaAluno.Items.Count);
                }
            }
        }

        private void LimparFormLista()
        {
            LstView_ListaAluno.Columns.Clear();
            LstView_ListaAluno.Items.Clear();
        }

        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();
            ColumnHeader columnHeader6 = new ColumnHeader();

            columnHeader1.Text = "Matrícula";
            columnHeader2.Text = "Nome";
            columnHeader3.Text = "E-mail";
            columnHeader4.Text = "Telefone";
            columnHeader5.Text = "Endereço";
            columnHeader6.Text = "Idade";

            LstView_ListaAluno.Columns.Add(columnHeader1);
            LstView_ListaAluno.Columns.Add(columnHeader2);
            LstView_ListaAluno.Columns.Add(columnHeader3);
            LstView_ListaAluno.Columns.Add(columnHeader4);
            LstView_ListaAluno.Columns.Add(columnHeader5);
            LstView_ListaAluno.Columns.Add(columnHeader6);

            LstView_ListaAluno.GridLines = true;
        }

        private void Btn_VoltarPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_BuscarAlunos_Click(object sender, EventArgs e)
        {
            if ((Txt_NomeAlunoBusca.Text != "" && Txt_EmailAlunoBusca.Text != "") || (Txt_NomeAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "") ||
                (Txt_NomeAlunoBusca.Text != "" && Txt_EnderecoAlunoBusca.Text != "") || (Txt_EmailAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "") ||
                (Txt_EmailAlunoBusca.Text != "" && Txt_EnderecoAlunoBusca.Text != "") || (Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "" && Txt_EnderecoAlunoBusca.Text != "") ||
                (Txt_NomeAlunoBusca.Text != "" && Txt_EmailAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "") ||
                (Txt_NomeAlunoBusca.Text != "" && Txt_EmailAlunoBusca.Text != "" && Txt_EnderecoAlunoBusca.Text != "") ||
                (Txt_EmailAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "" && Txt_EnderecoAlunoBusca.Text != "") ||
                (Txt_EmailAlunoBusca.Text != "" && Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "" && Txt_EnderecoAlunoBusca.Text != "") && Txt_EnderecoAlunoBusca.Text != "")
            {
                MessageBox.Show("Há mais de um campo preenchido. Preencha somente um campo para busca!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_NomeAlunoBusca.Text != "")
                PreencherListView_NomeAluno(Txt_NomeAlunoBusca.Text);
            else if (Txt_EmailAlunoBusca.Text != "")
                PreencherListView_EmailAluno(Txt_EmailAlunoBusca.Text);
            else if (Masked_TelefoneListaAluno.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "")
                PreencherListView_TelefoneAluno(Masked_TelefoneListaAluno.Text);
            else if (Txt_EnderecoAlunoBusca.Text != "")
                PreencherListView_EnderecoAluno(Txt_EnderecoAlunoBusca.Text);
            else
                PreencherListView_TodosAlunos();

            LstView_ListaAluno.View = System.Windows.Forms.View.Details;
        }

        private void FormListarAluno_Load(object sender, EventArgs e)
        {
            LimparFormLista();
            LstView_ListaAluno.FullRowSelect = true;
        }

        private void Btn_ExcluirAluno_Click(object sender, EventArgs e)
        {
            if (LstView_ListaAluno.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaAluno.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    AlunoController listaAluno = new AlunoController();
                    int idAluno = Convert.ToInt32(LstView_ListaAluno.SelectedItems[0].SubItems[0].Text);
                    listaAluno.ExcluirAluno(idAluno);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaAluno.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaAluno.SelectedItems[i];
                        LstView_ListaAluno.Items.Remove(lstRemove);
                    }
                    LstView_ListaAluno.Refresh();

                    Label_CalculaQuantidadeAluno.Text = Convert.ToString(LstView_ListaAluno.Items.Count);
                }
            }

            else
                return;
        }

        private void LstView_ListaAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LstView_ListaAluno.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (e.KeyCode == Keys.Delete && LstView_ListaAluno.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (e.KeyCode == Keys.Delete && MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    AlunoController listarAluno = new AlunoController();
                    int idAluno = Convert.ToInt32(LstView_ListaAluno.SelectedItems[0].SubItems[0].Text);
                    listarAluno.ExcluirAluno(idAluno);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaAluno.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaAluno.SelectedItems[i];
                        LstView_ListaAluno.Items.Remove(lstRemove);
                    }
                    LstView_ListaAluno.Refresh();

                    Label_CalculaQuantidadeAluno.Text = Convert.ToString(LstView_ListaAluno.Items.Count);
                }
            }

            else
                return;
        }

        private void Btn_DetalhesAluno_Click(object sender, EventArgs e)
        {
            if (LstView_ListaAluno.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_ListaAluno.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AlunoController listarAluno = new AlunoController();
            int alunosSelecionados = 0;
            int idAlunoMedida = Convert.ToInt32(LstView_ListaAluno.SelectedItems[0].SubItems[0].Text);

            alunosSelecionados = listarAluno.ConsultarMedidaPorIdAlunoMedida(idAlunoMedida);

            FormMedidas formMedidas = new FormMedidas(alunosSelecionados);
            formMedidas.ShowDialog();
        }
    }
}
