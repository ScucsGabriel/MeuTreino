using iTextSharp.text;
using iTextSharp.text.pdf;
using MeuTreino.Controller;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuTreino.View.Treino
{
    public partial class FormTreino : Form
    {
        public FormTreino(int numeroMatricula)
        {
            InitializeComponent();
            Label_NumeroMatricula.Text = numeroMatricula.ToString();
        }

        private void FormTreino_Load(object sender, EventArgs e)
        {
            LimparFormLista();            
            Label_DataTreino.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            LstView_ListaTreino.FullRowSelect = true;
        }

        private void Btn_VoltarMedidas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_BuscarTreino_Click(object sender, EventArgs e)
        {
            if (Combo_Treino.Text.Equals("-- Selecione --"))
            {
                MessageBox.Show("Nenhum treino selecionado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                PreencherListView_TreinoAluno(Combo_Treino.Text);
            }
        }

        private void PreencherListView_TreinoAluno(string treinoAluno)
        {
            LimparFormLista();
            PreencherColumnHeader();
            TreinoController listarTreino = new TreinoController();
            int resultadoBusca = listarTreino.ConsultarTreinoPorSigla(treinoAluno).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este treino!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarTreino.ConsultarTreinoPorSigla(treinoAluno))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idTreino.ToString(), item.siglaTreino.ToString(), item.nomeTreino.ToString(), item.exercicio.ToString(), item.serie.ToString(), item.repeticao.ToString(),
                item.intervalo.ToString(), item.metodo.ToString(), item.pse.ToString(), item.velocidadeExecucao.ToString(), item.dataTreino.ToString()});
                    LstView_ListaTreino.Items.Add(listViewItem);
                    Label_DataTreino.Text = item.dataTreino.ToString("dd/MM/yyyy");
                }
            }

            LstView_ListaTreino.View = System.Windows.Forms.View.Details;
        }

        private void LimparFormLista()
        {
            LstView_ListaTreino.Columns.Clear();
            LstView_ListaTreino.Items.Clear();
        }

        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();
            ColumnHeader columnHeader6 = new ColumnHeader();
            ColumnHeader columnHeader7 = new ColumnHeader();
            ColumnHeader columnHeader8 = new ColumnHeader();
            ColumnHeader columnHeader9 = new ColumnHeader();
            ColumnHeader columnHeader10 = new ColumnHeader();
            ColumnHeader columnHeader11 = new ColumnHeader();

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Sigla";
            columnHeader3.Text = "Grupo Muscular";
            columnHeader4.Text = "Exercício";
            columnHeader5.Text = "Série";
            columnHeader6.Text = "Repetição";
            columnHeader7.Text = "Intervalo";
            columnHeader8.Text = "Método";
            columnHeader9.Text = "PSE";
            columnHeader10.Text = "Velocidade de Execução";
            columnHeader11.Text = "Data do Treino";

            LstView_ListaTreino.Columns.Add(columnHeader1);
            LstView_ListaTreino.Columns.Add(columnHeader2);
            LstView_ListaTreino.Columns.Add(columnHeader3);
            LstView_ListaTreino.Columns.Add(columnHeader4);
            LstView_ListaTreino.Columns.Add(columnHeader5);
            LstView_ListaTreino.Columns.Add(columnHeader6);
            LstView_ListaTreino.Columns.Add(columnHeader7);
            LstView_ListaTreino.Columns.Add(columnHeader8);
            LstView_ListaTreino.Columns.Add(columnHeader9);
            LstView_ListaTreino.Columns.Add(columnHeader10);
            LstView_ListaTreino.Columns.Add(columnHeader11);

            LstView_ListaTreino.GridLines = true;
        }

        private void Btn_CadastrarTreino_Click(object sender, EventArgs e)
        {
            FormCadastrarTreino formCadastrarTreino = new FormCadastrarTreino(Convert.ToInt32(Label_NumeroMatricula.Text));
            formCadastrarTreino.ShowDialog();
        }

        private void Btn_EditarTreino_Click(object sender, EventArgs e)
        {
            TreinoController listarTreino = new TreinoController();
            List<MeuTreino.Model.Treino> treinoSelecionado = new List<MeuTreino.Model.Treino>();
            MeuTreino.Model.Treino treino = new MeuTreino.Model.Treino();

            int idTreino = Convert.ToInt32(LstView_ListaTreino.Items[0].SubItems[0].Text);
            int idNumeroMatricula = Convert.ToInt32(Label_NumeroMatricula.Text);
            string siglaTreino = LstView_ListaTreino.Items[0].SubItems[1].Text;
            string nomeTreino = LstView_ListaTreino.Items[0].SubItems[2].Text;
            string exercicio = LstView_ListaTreino.Items[0].SubItems[3].Text;
            int serie = Convert.ToInt32(LstView_ListaTreino.Items[0].SubItems[4].Text);
            string repeticao = LstView_ListaTreino.Items[0].SubItems[5].Text;
            string intervalo = LstView_ListaTreino.Items[0].SubItems[6].Text;
            string metodo = LstView_ListaTreino.Items[0].SubItems[7].Text;
            string pse = LstView_ListaTreino.Items[0].SubItems[8].Text;
            string velocidadeExecucao = LstView_ListaTreino.Items[0].SubItems[9].Text;
            string dataTreino = LstView_ListaTreino.Items[0].SubItems[10].Text;

            treino.idTreino = idTreino;
            treino.idAlunoTreino = idNumeroMatricula;
            treino.siglaTreino = siglaTreino;
            treino.nomeTreino = nomeTreino;
            treino.exercicio = exercicio;
            treino.serie = serie;
            treino.repeticao = repeticao;
            treino.intervalo = intervalo;
            treino.metodo = metodo;
            treino.pse = pse;
            treino.velocidadeExecucao = velocidadeExecucao;
            treino.dataTreino = Convert.ToDateTime(dataTreino);

            treinoSelecionado.Add(treino);

            FormEditarTreino formEditarTreino = new FormEditarTreino(treinoSelecionado);
            formEditarTreino.ShowDialog();
        }
        private void Btn_ExcluirTreino_Click(object sender, EventArgs e)
        {
            if (LstView_ListaTreino.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaTreino.SelectedItems.Count > 1)
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
                    TreinoController listaTreino = new TreinoController();
                    int idTreino = Convert.ToInt32(LstView_ListaTreino.Items[0].SubItems[0].Text);
                    int idAlunoTreino = Convert.ToInt32(Label_NumeroMatricula.Text);
                    listaTreino.ExcluirTreino(idTreino, idAlunoTreino);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaTreino.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaTreino.SelectedItems[i];
                        LstView_ListaTreino.Items.Remove(lstRemove);
                    }
                    LstView_ListaTreino.Refresh();
                }
            }

            else
                return;
        }

        private void LstView_ListaTreino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LstView_ListaTreino.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (e.KeyCode == Keys.Delete && LstView_ListaTreino.SelectedItems.Count > 1)
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
                    TreinoController listarTreino = new TreinoController();
                    int idTreino = Convert.ToInt32(LstView_ListaTreino.Items[0].SubItems[0].Text);
                    int idAlunoTreino = Convert.ToInt32(Label_NumeroMatricula.Text);
                    listarTreino.ExcluirTreino(idTreino, idAlunoTreino);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaTreino.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaTreino.SelectedItems[i];
                        LstView_ListaTreino.Items.Remove(lstRemove);
                    }
                    LstView_ListaTreino.Refresh();
                }
            }

            else
                return;
        }

        private void Btn_SalvarPdf_Click(object sender, EventArgs e)
        {
            if (LstView_ListaTreino.Items.Count == 0)
            {
                MessageBox.Show("Necessário gerar dados para salvar em PDF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!GerarPdf())
                return;
            }
        }

        private bool GerarPdf()
        {
            DateTime dataTreino = Convert.ToDateTime(LstView_ListaTreino.Items[0].SubItems[10].Text);
            Salvar_Pdf.Title = "Salvar Relatório";
            Salvar_Pdf.Filter = "PDF file (*.pdf)|*.pdf";
            Salvar_Pdf.FileName = "Treino - " + dataTreino.Date.Month.ToString() + "-" + dataTreino.Date.Year.ToString() + " - " + LstView_ListaTreino.Items[0].SubItems[2].Text;
            Salvar_Pdf.DefaultExt = ".pdf";
            Salvar_Pdf.InitialDirectory = @"C:\";
            Salvar_Pdf.RestoreDirectory = true;
            DialogResult resultado = Salvar_Pdf.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                Document documento = new Document(PageSize.A4);
                documento.SetMargins(40, 40, 40, 80);
                documento.AddCreationDate();
                string caminho = Salvar_Pdf.FileName;

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));
                    documento.Open();

                    iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(BaseFont.HELVETICA, 20, Convert.ToInt32(FontStyle.Bold));
                    iTextSharp.text.Font fonteSubTitulos = FontFactory.GetFont(BaseFont.HELVETICA, 10, Convert.ToInt32(FontStyle.Bold));

                    Paragraph titulo = new Paragraph();
                    Paragraph espacamento = new Paragraph();
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font = fonteTitulo;
                    titulo.Add("Treino " + LstView_ListaTreino.Items[0].SubItems[1].Text + " - " + LstView_ListaTreino.Items[0].SubItems[2].Text);
                    espacamento.Add(" ");
                    documento.Add(titulo);
                    documento.Add(espacamento);

                    PdfPTable tabela = new PdfPTable(7);
                    Paragraph coluna1 = new Paragraph("Exercício");
                    Paragraph coluna2 = new Paragraph("Série");
                    Paragraph coluna3 = new Paragraph("Repetição");
                    Paragraph coluna4 = new Paragraph("Intervalo");
                    Paragraph coluna5 = new Paragraph("Método");
                    Paragraph coluna6 = new Paragraph("PSE");
                    Paragraph coluna7 = new Paragraph("Execução");

                    coluna1.Alignment = Element.ALIGN_CENTER;
                    coluna2.Alignment = Element.ALIGN_CENTER;
                    coluna3.Alignment = Element.ALIGN_CENTER;
                    coluna4.Alignment = Element.ALIGN_CENTER;
                    coluna5.Alignment = Element.ALIGN_CENTER;
                    coluna6.Alignment = Element.ALIGN_CENTER;
                    coluna7.Alignment = Element.ALIGN_CENTER;

                    coluna1.Font = fonteSubTitulos;
                    coluna2.Font = fonteSubTitulos;
                    coluna3.Font = fonteSubTitulos;
                    coluna4.Font = fonteSubTitulos;
                    coluna5.Font = fonteSubTitulos;
                    coluna6.Font = fonteSubTitulos;
                    coluna7.Font = fonteSubTitulos;

                    var cel1 = new PdfPCell();
                    var cel2 = new PdfPCell();
                    var cel3 = new PdfPCell();
                    var cel4 = new PdfPCell();
                    var cel5 = new PdfPCell();
                    var cel6 = new PdfPCell();
                    var cel7 = new PdfPCell();
                         
                    cel1.AddElement(coluna1);
                    cel2.AddElement(coluna2);
                    cel3.AddElement(coluna3);
                    cel4.AddElement(coluna4);
                    cel5.AddElement(coluna5);
                    cel6.AddElement(coluna6);
                    cel7.AddElement(coluna7);

                    tabela.AddCell(cel1);
                    tabela.AddCell(cel2);
                    tabela.AddCell(cel3);
                    tabela.AddCell(cel4);
                    tabela.AddCell(cel5);
                    tabela.AddCell(cel6);
                    tabela.AddCell(cel7);

                    for (int i = 0; i < LstView_ListaTreino.Items.Count; i++)
                    {
                        tabela.AddCell(LstView_ListaTreino.Items[i].SubItems[3].Text);
                        tabela.AddCell(LstView_ListaTreino.Items[i].SubItems[4].Text);
                        tabela.AddCell(LstView_ListaTreino.Items[i].SubItems[5].Text);
                        tabela.AddCell(LstView_ListaTreino.Items[i].SubItems[6].Text);
                        tabela.AddCell(LstView_ListaTreino.Items[i].SubItems[7].Text);
                        tabela.AddCell(LstView_ListaTreino.Items[i].SubItems[8].Text);
                        tabela.AddCell(LstView_ListaTreino.Items[i].SubItems[9].Text);
                    }

                    documento.Add(tabela);
                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_Pdf.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    documento.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Btn_SalvarXls_Click(object sender, EventArgs e)
        {
            if (LstView_ListaTreino.Items.Count == 0)
            {
                MessageBox.Show("Necessário gerar dados para salvar em XLS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               if (!GerarXls())
               return;
            }
        }

        private bool GerarXls()
        {
            DateTime dataTreino = Convert.ToDateTime(LstView_ListaTreino.Items[0].SubItems[10].Text);
            Salvar_Xls.Title = "Salvar Treino";
            Salvar_Xls.Filter = "XLS file (*.xlsx)|*.xlsx";
            Salvar_Xls.FileName = "Treino - " + dataTreino.Date.Month.ToString() + "-" + dataTreino.Date.Year.ToString() + " - " + LstView_ListaTreino.Items[0].SubItems[2].Text;
            Salvar_Xls.DefaultExt = ".xlsx";
            Salvar_Xls.InitialDirectory = @"C:\";
            Salvar_Xls.RestoreDirectory = true;
            DialogResult resultado = Salvar_Xls.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel não está instalado!");
                    return false;
                }
                string caminho = Salvar_Xls.FileName;

                try
                {
                    Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

                    int row = 1;
                    xlWorksheet.Cells[row, 1] = "Exercício";
                    xlWorksheet.Cells[row, 2] = "Série";
                    xlWorksheet.Cells[row, 3] = "Repetição";
                    xlWorksheet.Cells[row, 4] = "Intervalo";
                    xlWorksheet.Cells[row, 5] = "Método";
                    xlWorksheet.Cells[row, 6] = "PSE";
                    xlWorksheet.Cells[row, 7] = "Execução";

                    xlWorksheet.get_Range("A1", "G1").Font.Bold = true;
                    xlWorksheet.get_Range("A1", "G1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    xlWorksheet.get_Range("A1", "G1").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                    for (int i = 0; i < LstView_ListaTreino.Items.Count; i++)
                    {
                        row++;
                        int col = 1;
                        xlWorksheet.Cells[row, col] = LstView_ListaTreino.Items[i].SubItems[3].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_ListaTreino.Items[i].SubItems[4].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_ListaTreino.Items[i].SubItems[5].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_ListaTreino.Items[i].SubItems[6].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_ListaTreino.Items[i].SubItems[7].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = "'" + LstView_ListaTreino.Items[i].SubItems[8].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_ListaTreino.Items[i].SubItems[9].Text;
                        xlWorksheet.get_Range("A" + row, "G" + row).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;                        
                    }

                    xlWorkbook.SaveAs(Salvar_Xls.FileName, XlFileFormat.xlOpenXMLWorkbook);
                    xlWorkbook.Close();

                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_Xls.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    xlApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }


}
