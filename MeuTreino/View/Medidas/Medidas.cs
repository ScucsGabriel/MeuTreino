using iTextSharp.text;
using iTextSharp.text.pdf;
using MeuTreino.Controller;
using MeuTreino.Model;
using MeuTreino.View.Treino;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuTreino.View.Medidas
{
    public partial class FormMedidas : Form
    {
        public FormMedidas(int idAlunoMedida)
        {
            InitializeComponent();
            Label_NumeroMatricula.Text = idAlunoMedida.ToString();
        }

        private void Btn_EditarMedidas_Click(object sender, EventArgs e)
        {
            HabilitarCampos();            
        }

        private void HabilitarCampos() 
        {
            //Medidas
            Txt_PesoAluno.ReadOnly = false;
            Txt_PesoAluno.Enabled = true;
            Txt_AlturaAluno.ReadOnly = false;
            Txt_AlturaAluno.Enabled = true;

            //Circunferências
            Txt_Cintura.ReadOnly = false;
            Txt_Cintura.Enabled = true;
            Txt_Ombro.ReadOnly = false;
            Txt_Ombro.Enabled = true;
            Txt_Abdomen.ReadOnly = false;
            Txt_Abdomen.Enabled = true;
            Txt_BracoRelaxadoDireito.ReadOnly = false;
            Txt_BracoRelaxadoDireito.Enabled = true;
            Txt_CoxaDireita.ReadOnly = false;
            Txt_CoxaDireita.Enabled = true;
            Txt_BracoContraidoDireito.ReadOnly = false;
            Txt_BracoContraidoDireito.Enabled = true;
            Txt_PanturrilhaDireita.ReadOnly = false;
            Txt_PanturrilhaDireita.Enabled = true;
            Txt_AntebracoDireito.ReadOnly = false;
            Txt_AntebracoDireito.Enabled = true;

            //Dobras Cutâneas
            Txt_Abdominal.ReadOnly = false;
            Txt_Abdominal.Enabled = true;
            Txt_Triceps.ReadOnly = false;
            Txt_Triceps.Enabled = true;
            Txt_Suprailiaca.ReadOnly = false;
            Txt_Suprailiaca.Enabled = true;
            Txt_AxilarMedia.ReadOnly = false;
            Txt_AxilarMedia.Enabled = true;
            Txt_Subescapular.ReadOnly = false;
            Txt_Subescapular.Enabled = true;
            Txt_Torax.ReadOnly = false;
            Txt_Torax.Enabled = true;
            Txt_Coxa.ReadOnly = false;
            Txt_Coxa.Enabled = true;

            //Resultados
            Txt_Imc.ReadOnly = false;
            Txt_Imc.Enabled = true;
            Txt_PercMassaGorda.ReadOnly = false;
            Txt_PercMassaGorda.Enabled = true;
            Txt_PercMassaMagra.ReadOnly = false;
            Txt_PercMassaMagra.Enabled = true;
            Txt_MassaGorda.ReadOnly = false;
            Txt_MassaGorda.Enabled = true;
            Txt_MassaMagra.ReadOnly = false;
            Txt_MassaMagra.Enabled = true;
            Txt_SomaDobras.ReadOnly = false;
            Txt_SomaDobras.Enabled = true;
            Txt_AreaMuscularBraco.ReadOnly = false;
            Txt_AreaMuscularBraco.Enabled = true;
            Txt_AreaGorduraBraco.ReadOnly = false;
            Txt_AreaGorduraBraco.Enabled = true;
        }

        private void Btn_TreinoAluno_Click(object sender, EventArgs e)
        {
            FormTreino formTreino = new FormTreino(Convert.ToInt32(Label_NumeroMatricula.Text));
            formTreino.ShowDialog();
        }

        private void Btn_SalvarMedidas_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            DateTime dataAvaliacao = DateTime.Now.Date;

            MedidasController atualizarMedidas = new MedidasController();
            atualizarMedidas.AtualizarMedidas(Convert.ToInt32(Label_NumeroMatricula.Text), Convert.ToDouble(Txt_PesoAluno.Text.Replace("kg", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_AlturaAluno.Text.Replace("m", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_Ombro.Text.Replace("cm", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_Cintura.Text.Replace("cm", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_Abdomen.Text.Replace("cm", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_CoxaDireita.Text.Replace("cm", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_PanturrilhaDireita.Text.Replace("cm", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_BracoRelaxadoDireito.Text.Replace("cm", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_BracoContraidoDireito.Text.Replace("cm", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_AntebracoDireito.Text.Replace("cm", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_Abdominal.Text.Replace("mm", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_Triceps.Text.Replace("mm", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_Suprailiaca.Text.Replace("mm", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_AxilarMedia.Text.Replace("mm", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_Subescapular.Text.Replace("mm", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_Torax.Text.Replace("mm", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_Coxa.Text.Replace("mm", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_Imc.Text.Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_PercMassaGorda.Text.Replace("%", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_PercMassaMagra.Text.Replace("%", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_MassaGorda.Text.Replace("kg", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_MassaMagra.Text.Replace("kg", "").Replace(",", "."), CultureInfo.InvariantCulture),
                Convert.ToDouble(Txt_SomaDobras.Text.Replace("mm", "").Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_AreaMuscularBraco.Text.Replace(",", "."), CultureInfo.InvariantCulture), Convert.ToDouble(Txt_AreaGorduraBraco.Text.Replace(",", "."), CultureInfo.InvariantCulture), dataAvaliacao);

            MessageBox.Show("Medidas atualizadas com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MedidasController carregarMedidas = new MedidasController();

            foreach (var item in carregarMedidas.ConsultarMedidaPorIdAlunoMedida(Convert.ToInt32(Label_NumeroMatricula.Text)))
            {
                //Medidas
                if (item.peso == 0)
                    Txt_PesoAluno.Text = "";
                else
                    Txt_PesoAluno.Text = item.peso.ToString() + "kg";
                if (item.altura == 0)
                    Txt_AlturaAluno.Text = "";
                else
                    Txt_AlturaAluno.Text = item.altura.ToString() + "m";

                //Circunferências
                if (item.ombro == 0)
                    Txt_Ombro.Text = "";
                else
                    Txt_Ombro.Text = item.ombro.ToString() + "cm";
                if (item.cintura == 0)
                    Txt_Cintura.Text = "";
                else
                    Txt_Cintura.Text = item.cintura.ToString() + "cm";
                if (item.abdomen == 0)
                    Txt_Abdomen.Text = "";
                else
                    Txt_Abdomen.Text = item.abdomen.ToString() + "cm";
                if (item.coxaDireita == 0)
                    Txt_CoxaDireita.Text = "";
                else
                    Txt_CoxaDireita.Text = item.coxaDireita.ToString() + "cm";
                if (item.panturrilhaDireita == 0)
                    Txt_PanturrilhaDireita.Text = "";
                else
                    Txt_PanturrilhaDireita.Text = item.panturrilhaDireita.ToString() + "cm";
                if (item.bracoRelaxadoDireito == 0)
                    Txt_BracoRelaxadoDireito.Text = "";
                else
                    Txt_BracoRelaxadoDireito.Text = item.bracoRelaxadoDireito.ToString() + "cm";
                if (item.bracoContraidoDireito == 0)
                    Txt_BracoContraidoDireito.Text = "";
                else
                    Txt_BracoContraidoDireito.Text = item.bracoContraidoDireito.ToString() + "cm";
                if (item.antebracoDireito == 0)
                    Txt_AntebracoDireito.Text = "";
                else
                    Txt_AntebracoDireito.Text = item.antebracoDireito.ToString() + "cm";

                //Dobras Cutâneas
                if (item.abdominal == 0)
                    Txt_Abdominal.Text = "";
                else
                    Txt_Abdominal.Text = item.abdominal.ToString() + "mm";
                if (item.triceps == 0)
                    Txt_Triceps.Text = "";
                else
                    Txt_Triceps.Text = item.triceps.ToString() + "mm";
                if (item.suprailiaca == 0)
                    Txt_Suprailiaca.Text = "";
                else
                    Txt_Suprailiaca.Text = item.suprailiaca.ToString() + "mm";
                if (item.axilarMedia == 0)
                    Txt_AxilarMedia.Text = "";
                else
                    Txt_AxilarMedia.Text = item.axilarMedia.ToString() + "mm";
                if (item.subescapular == 0)
                    Txt_Subescapular.Text = "";
                else
                    Txt_Subescapular.Text = item.subescapular.ToString() + "mm";
                if (item.torax == 0)
                    Txt_Torax.Text = "";
                else
                    Txt_Torax.Text = item.torax.ToString() + "mm";
                if (item.coxa == 0)
                    Txt_Coxa.Text = "";
                else
                    Txt_Coxa.Text = item.coxa.ToString() + "mm";

                //Resultados
                if (item.imc == 0)
                    Txt_Imc.Text = "";
                else
                    Txt_Imc.Text = item.imc.ToString();
                if (item.percentualMassaGorda == 0)
                    Txt_PercMassaGorda.Text = "";
                else
                    Txt_PercMassaGorda.Text = item.percentualMassaGorda.ToString() + "%";
                if (item.percentualMassaMagra == 0)
                    Txt_PercMassaMagra.Text = "";
                else
                    Txt_PercMassaMagra.Text = item.percentualMassaMagra.ToString() + "%";
                if (item.pesoMassaGorda == 0)
                    Txt_MassaGorda.Text = "";
                else
                    Txt_MassaGorda.Text = item.pesoMassaGorda.ToString() + "kg";
                if (item.pesoMassaMagra == 0)
                    Txt_MassaMagra.Text = "";
                else
                    Txt_MassaMagra.Text = item.pesoMassaMagra.ToString() + "kg";
                if (item.somaDobras == 0)
                    Txt_SomaDobras.Text = "";
                else
                    Txt_SomaDobras.Text = item.somaDobras.ToString() + "mm";
                if (item.areaMuscularBraco == 0)
                    Txt_AreaMuscularBraco.Text = "";
                else
                    Txt_AreaMuscularBraco.Text = item.areaMuscularBraco.ToString();
                if (item.areaGorduraBraco == 0)
                    Txt_AreaGorduraBraco.Text = "";
                else
                    Txt_AreaGorduraBraco.Text = item.areaGorduraBraco.ToString();
            }
        }

        private bool ValidarPreenchimento()
        {

            if (Txt_PesoAluno.Text == "")
            {
                MessageBox.Show("Peso do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_PesoAluno.Text.Replace(",", ".").Replace("kg", "").Trim()) == false)
            {
                MessageBox.Show("Peso do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_AlturaAluno.Text == "")
            {
                MessageBox.Show("Altura do aluno está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_AlturaAluno.Text.Replace(",", ".").Replace("m", "").Trim()) == false)
            {
                MessageBox.Show("Altura do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Ombro.Text == "")
            {
                MessageBox.Show("Ombro do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Ombro.Text.Replace(",", ".").Replace("cm", "").Trim()) == false)
            {
                MessageBox.Show("Ombro do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Cintura.Text == "")
            {
                MessageBox.Show("Cintura do aluno está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Cintura.Text.Replace(",", ".").Replace("cm", "").Trim()) == false)
            {
                MessageBox.Show("Cintura do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Abdomen.Text == "")
            {
                MessageBox.Show("Abdômen do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Abdomen.Text.Replace(",", ".").Replace("cm", "").Trim()) == false)
            {
                MessageBox.Show("Abdômen do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_CoxaDireita.Text == "")
            {
                MessageBox.Show("Coxa Direita do aluno está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_CoxaDireita.Text.Replace(",", ".").Replace("cm", "").Trim()) == false)
            {
                MessageBox.Show("Coxa Direita do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_PanturrilhaDireita.Text == "")
            {
                MessageBox.Show("Panturrilha Direita do aluno está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_PanturrilhaDireita.Text.Replace(",", ".").Replace("cm", "").Trim()) == false)
            {
                MessageBox.Show("Panturrilha Direita do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_BracoRelaxadoDireito.Text == "")
            {
                MessageBox.Show("Braço Relaxado Direito do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_BracoRelaxadoDireito.Text.Replace(",", ".").Replace("cm", "").Trim()) == false)
            {
                MessageBox.Show("Braço Relaxado Direito do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_BracoContraidoDireito.Text == "")
            {
                MessageBox.Show("Braço Contraído Direito do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_BracoContraidoDireito.Text.Replace(",", ".").Replace("cm", "").Trim()) == false)
            {
                MessageBox.Show("Braço Contraído Direito do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_AntebracoDireito.Text == "")
            {
                MessageBox.Show("Antebraço Direito do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_AntebracoDireito.Text.Replace(",", ".").Replace("cm", "").Trim()) == false)
            {
                MessageBox.Show("Antebraço Direito do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Abdominal.Text == "")
            {
                MessageBox.Show("Abdominal do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Abdominal.Text.Replace(",", ".").Replace("mm", "").Trim()) == false)
            {
                MessageBox.Show("Abdominal do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Triceps.Text == "")
            {
                MessageBox.Show("Tríceps do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Triceps.Text.Replace(",", ".").Replace("mm", "").Trim()) == false)
            {
                MessageBox.Show("Tríceps do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Suprailiaca.Text == "")
            {
                MessageBox.Show("Suprailíaca do aluno está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Suprailiaca.Text.Replace(",", ".").Replace("mm", "").Trim()) == false)
            {
                MessageBox.Show("Suprailíaca do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_AxilarMedia.Text == "")
            {
                MessageBox.Show("Axilar Média do aluno está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_AxilarMedia.Text.Replace(",", ".").Replace("mm", "").Trim()) == false)
            {
                MessageBox.Show("Axilar Média do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Subescapular.Text == "")
            {
                MessageBox.Show("Subescapular do aluno está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Subescapular.Text.Replace(",", ".").Replace("mm", "").Trim()) == false)
            {
                MessageBox.Show("Subescapular do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Torax.Text == "")
            {
                MessageBox.Show("Tórax do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Torax.Text.Replace(",", ".").Replace("mm", "").Trim()) == false)
            {
                MessageBox.Show("Tórax do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Coxa.Text == "")
            {
                MessageBox.Show("Coxa do aluno está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Coxa.Text.Replace(",", ".").Replace("mm", "").Trim()) == false)
            {
                MessageBox.Show("Coxa do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Imc.Text == "")
            {
                MessageBox.Show("IMC do aluno está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_Imc.Text.Replace(",", ".")) == false)
            {
                MessageBox.Show("IMC do aluno não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_PercMassaGorda.Text == "")
            {
                MessageBox.Show("% Massa Gorda está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_PercMassaGorda.Text.Replace(",", ".").Replace("%", "").Trim()) == false)
            {
                MessageBox.Show("% Massa Gorda não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_PercMassaMagra.Text == "")
            {
                MessageBox.Show("% Massa Magra está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_PercMassaMagra.Text.Replace(",", ".").Replace("%", "").Trim()) == false)
            {
                MessageBox.Show("% Massa Magra não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_MassaGorda.Text == "")
            {
                MessageBox.Show("Massa Gorda está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_MassaGorda.Text.Replace(",", ".").Replace("kg", "").Trim()) == false)
            {
                MessageBox.Show("Massa Gorda não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_MassaMagra.Text == "")
            {
                MessageBox.Show("Massa Magra está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_MassaMagra.Text.Replace(",", ".").Replace("kg", "").Trim()) == false)
            {
                MessageBox.Show("Massa Magra não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_SomaDobras.Text == "")
            {
                MessageBox.Show("Soma de Dobras está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_SomaDobras.Text.Replace(",", ".").Replace("mm", "").Trim()) == false)
            {
                MessageBox.Show("Soma de Dobras não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_AreaMuscularBraco.Text == "")
            {
                MessageBox.Show("Área Muscular do Braço está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_AreaMuscularBraco.Text.Replace(",", ".")) == false)
            {
                MessageBox.Show("Área Muscular do Braço não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_AreaGorduraBraco.Text == "")
            {
                MessageBox.Show("Área de Gordura do Braço está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(Txt_AreaGorduraBraco.Text.Replace(",", ".")) == false)
            {
                MessageBox.Show("Área de Gordura do Braço não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool IsNumber(string medida)
        {
            if(double.TryParse(medida, out double numero))
                return true;                
            else
                return false;
        }

        private void FormMedidas_Load(object sender, EventArgs e)
        {
            MedidasController carregarMedidas = new MedidasController();
            int idAlunoMedida = Convert.ToInt32(Label_NumeroMatricula.Text);

            foreach (var item in carregarMedidas.ConsultarMedidaPorIdAlunoMedida(idAlunoMedida))
            {                
                //Medidas
                if (item.peso == 0)
                    Txt_PesoAluno.Text = "";
                else
                    Txt_PesoAluno.Text = item.peso.ToString() + "kg";
                if (item.altura == 0)
                    Txt_AlturaAluno.Text = "";
                else
                    Txt_AlturaAluno.Text = item.altura.ToString() + "m";

                //Circunferências
                if (item.ombro == 0)
                    Txt_Ombro.Text = "";
                else
                    Txt_Ombro.Text = item.ombro.ToString() + "cm";
                if (item.cintura == 0)
                    Txt_Cintura.Text = "";
                else
                    Txt_Cintura.Text = item.cintura.ToString() + "cm";
                if (item.abdomen == 0)
                    Txt_Abdomen.Text = "";
                else
                    Txt_Abdomen.Text = item.abdomen.ToString() + "cm";
                if (item.coxaDireita == 0)
                    Txt_CoxaDireita.Text = "";
                else
                    Txt_CoxaDireita.Text = item.coxaDireita.ToString() + "cm";
                if (item.panturrilhaDireita == 0)
                    Txt_PanturrilhaDireita.Text = "";
                else
                    Txt_PanturrilhaDireita.Text = item.panturrilhaDireita.ToString() + "cm";
                if (item.bracoRelaxadoDireito == 0)
                    Txt_BracoRelaxadoDireito.Text = "";
                else
                    Txt_BracoRelaxadoDireito.Text = item.bracoRelaxadoDireito.ToString() + "cm";
                if (item.bracoContraidoDireito == 0)
                    Txt_BracoContraidoDireito.Text = "";
                else
                    Txt_BracoContraidoDireito.Text = item.bracoContraidoDireito.ToString() + "cm";
                if (item.antebracoDireito == 0)
                    Txt_AntebracoDireito.Text = "";
                else
                    Txt_AntebracoDireito.Text = item.antebracoDireito.ToString() + "cm";

                //Dobras Cutâneas
                if (item.abdominal == 0)
                    Txt_Abdominal.Text = "";
                else
                    Txt_Abdominal.Text = item.abdominal.ToString() + "mm";
                if (item.triceps == 0)
                    Txt_Triceps.Text = "";
                else
                    Txt_Triceps.Text = item.triceps.ToString() + "mm";
                if (item.suprailiaca == 0)
                    Txt_Suprailiaca.Text = "";
                else
                    Txt_Suprailiaca.Text = item.suprailiaca.ToString() + "mm";
                if (item.axilarMedia == 0)
                    Txt_AxilarMedia.Text = "";
                else
                    Txt_AxilarMedia.Text = item.axilarMedia.ToString() + "mm";
                if (item.subescapular == 0)
                    Txt_Subescapular.Text = "";
                else
                    Txt_Subescapular.Text = item.subescapular.ToString() + "mm";
                if (item.torax == 0)
                    Txt_Torax.Text = "";
                else
                    Txt_Torax.Text = item.torax.ToString() + "mm";
                if (item.coxa == 0)
                    Txt_Coxa.Text = "";
                else
                    Txt_Coxa.Text = item.coxa.ToString() + "mm";

                //Resultados
                if (item.imc == 0)
                    Txt_Imc.Text = "";
                else
                    Txt_Imc.Text = item.imc.ToString();
                if (item.percentualMassaGorda == 0)
                    Txt_PercMassaGorda.Text = "";
                else
                    Txt_PercMassaGorda.Text = item.percentualMassaGorda.ToString() + "%";
                if (item.percentualMassaMagra == 0)
                    Txt_PercMassaMagra.Text = "";
                else
                    Txt_PercMassaMagra.Text = item.percentualMassaMagra.ToString() + "%";
                if (item.pesoMassaGorda == 0)
                    Txt_MassaGorda.Text = "";
                else
                    Txt_MassaGorda.Text = item.pesoMassaGorda.ToString() + "kg";
                if (item.pesoMassaMagra == 0)
                    Txt_MassaMagra.Text = "";
                else
                    Txt_MassaMagra.Text = item.pesoMassaMagra.ToString() + "kg";
                if (item.somaDobras == 0)
                    Txt_SomaDobras.Text = "";
                else
                    Txt_SomaDobras.Text = item.somaDobras.ToString() + "mm";
                if (item.areaMuscularBraco == 0)
                    Txt_AreaMuscularBraco.Text = "";
                else
                    Txt_AreaMuscularBraco.Text = item.areaMuscularBraco.ToString();
                if (item.areaGorduraBraco == 0)
                    Txt_AreaGorduraBraco.Text = "";
                else
                    Txt_AreaGorduraBraco.Text = item.areaGorduraBraco.ToString();

                Label_DataAvaliacao.Text = item.dataAvaliacao.ToString("dd/MM/yyyy");

            }

        }

        private void Btn_SalvarPdf_Click(object sender, EventArgs e)
        {
            if (!GerarPdf(Convert.ToInt32(Label_NumeroMatricula.Text)))
                return;
        }

        private bool GerarPdf(int numeroMatricula)
        {
            AlunoController listaAluno = new AlunoController();
            string aluno = listaAluno.ConsultarNomeAlunoPorId(numeroMatricula);
            DateTime dataAvaliacao = Convert.ToDateTime(Label_DataAvaliacao.Text);
            Salvar_Pdf.Title = "Salvar Relatório";
            Salvar_Pdf.Filter = "PDF file (*.pdf)|*.pdf";
            Salvar_Pdf.FileName = "Avaliação - " + aluno + " - " + dataAvaliacao.Date.Month.ToString() + "-" + dataAvaliacao.Date.Year.ToString();
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
                    titulo.Add("Avaliação Física\n\n" + aluno + "\n\nData: " + dataAvaliacao.ToString("dd / MM / yyyy") + "\n\n-----------------------------------------------------------------------------");
                    documento.Add(titulo);
                    espacamento.Add(" ");                    
                    documento.Add(espacamento);

                    PdfPTable tabela = new PdfPTable(1);
                    Paragraph coluna1 = new Paragraph("Medidas");
                    PdfPTable tabela2 = new PdfPTable(2);
                    Paragraph coluna2 = new Paragraph("Peso - " + Txt_PesoAluno.Text);
                    Paragraph coluna3 = new Paragraph("Altura - " + Txt_AlturaAluno.Text);
                    PdfPTable tabela3 = new PdfPTable(1);
                    Paragraph coluna4 = new Paragraph("Circunferências");
                    PdfPTable tabela4 = new PdfPTable(8);
                    Paragraph coluna5 = new Paragraph("Ombro - " + Txt_Ombro.Text);
                    Paragraph coluna6 = new Paragraph("Abdômen - " + Txt_Abdomen.Text);
                    Paragraph coluna7 = new Paragraph("Panturrilha Direita - " + Txt_PanturrilhaDireita.Text);
                    Paragraph coluna8 = new Paragraph("Cintura - " + Txt_Cintura.Text);
                    Paragraph coluna9 = new Paragraph("Coxa Direita - " + Txt_CoxaDireita.Text);
                    Paragraph coluna10 = new Paragraph("Braço Relaxado Direito - " + Txt_BracoRelaxadoDireito.Text);
                    Paragraph coluna11 = new Paragraph("Braço Contraído Direito - " + Txt_BracoContraidoDireito.Text);
                    Paragraph coluna12 = new Paragraph("Antebraço Direito - " + Txt_AntebracoDireito.Text);
                    PdfPTable tabela6 = new PdfPTable(1);
                    Paragraph coluna13 = new Paragraph("Dobras Cutâneas");
                    PdfPTable tabela7 = new PdfPTable(7);
                    Paragraph coluna14 = new Paragraph("Abdominal - " + Txt_Abdominal.Text);
                    Paragraph coluna15 = new Paragraph("Tríceps - " + Txt_Triceps.Text);
                    Paragraph coluna16 = new Paragraph("Suprailíaca - " + Txt_Suprailiaca.Text);
                    Paragraph coluna17 = new Paragraph("Axilar Média - " + Txt_AxilarMedia.Text);
                    Paragraph coluna18 = new Paragraph("Subescapular - " + Txt_Subescapular.Text);
                    Paragraph coluna19 = new Paragraph("Tórax - " + Txt_Torax.Text);
                    Paragraph coluna20 = new Paragraph("Coxa - " + Txt_Coxa.Text);
                    PdfPTable tabela8 = new PdfPTable(1);
                    Paragraph coluna21 = new Paragraph("Resultados");
                    PdfPTable tabela9 = new PdfPTable(8);
                    Paragraph coluna22 = new Paragraph("IMC - " + Txt_Imc.Text);
                    Paragraph coluna23 = new Paragraph("% Massa Gorda - " + Txt_PercMassaGorda.Text);
                    Paragraph coluna24 = new Paragraph("% Massa Magra - " + Txt_PercMassaMagra.Text);
                    Paragraph coluna25 = new Paragraph("Massa Gorda - " + Txt_MassaGorda.Text);
                    Paragraph coluna26 = new Paragraph("Massa Magra - " + Txt_MassaMagra.Text);
                    Paragraph coluna27 = new Paragraph("Soma de Dobras - " + Txt_SomaDobras.Text);
                    Paragraph coluna28 = new Paragraph("Área Muscular do Braço (AMB) - " + Txt_AreaMuscularBraco.Text);
                    Paragraph coluna29 = new Paragraph("Área de Gordura do Braço (AGB) - " + Txt_AreaGorduraBraco.Text);


                    coluna1.Alignment = Element.ALIGN_CENTER;
                    coluna2.Alignment = Element.ALIGN_LEFT;
                    coluna3.Alignment = Element.ALIGN_LEFT;
                    coluna4.Alignment = Element.ALIGN_CENTER;
                    coluna5.Alignment = Element.ALIGN_LEFT;
                    coluna6.Alignment = Element.ALIGN_LEFT;
                    coluna7.Alignment = Element.ALIGN_LEFT;
                    coluna8.Alignment = Element.ALIGN_LEFT;
                    coluna9.Alignment = Element.ALIGN_LEFT;
                    coluna10.Alignment = Element.ALIGN_LEFT;
                    coluna11.Alignment = Element.ALIGN_LEFT;
                    coluna12.Alignment = Element.ALIGN_LEFT;
                    coluna13.Alignment = Element.ALIGN_CENTER;
                    coluna14.Alignment = Element.ALIGN_LEFT;
                    coluna15.Alignment = Element.ALIGN_LEFT;
                    coluna16.Alignment = Element.ALIGN_LEFT;
                    coluna17.Alignment = Element.ALIGN_LEFT;
                    coluna18.Alignment = Element.ALIGN_LEFT;
                    coluna19.Alignment = Element.ALIGN_LEFT;
                    coluna20.Alignment = Element.ALIGN_LEFT;
                    coluna21.Alignment = Element.ALIGN_CENTER;
                    coluna22.Alignment = Element.ALIGN_LEFT;
                    coluna23.Alignment = Element.ALIGN_LEFT;
                    coluna24.Alignment = Element.ALIGN_LEFT;
                    coluna25.Alignment = Element.ALIGN_LEFT;
                    coluna26.Alignment = Element.ALIGN_LEFT;
                    coluna27.Alignment = Element.ALIGN_LEFT;
                    coluna28.Alignment = Element.ALIGN_LEFT;
                    coluna29.Alignment = Element.ALIGN_LEFT;

                    coluna1.Font = fonteSubTitulos;
                    coluna2.Font = fonteSubTitulos;
                    coluna3.Font = fonteSubTitulos;
                    coluna4.Font = fonteSubTitulos;
                    coluna5.Font = fonteSubTitulos;
                    coluna6.Font = fonteSubTitulos;
                    coluna7.Font = fonteSubTitulos;
                    coluna8.Font = fonteSubTitulos;
                    coluna9.Font = fonteSubTitulos;
                    coluna10.Font = fonteSubTitulos;
                    coluna11.Font = fonteSubTitulos;
                    coluna12.Font = fonteSubTitulos;
                    coluna13.Font = fonteSubTitulos;
                    coluna14.Font = fonteSubTitulos;
                    coluna15.Font = fonteSubTitulos;
                    coluna16.Font = fonteSubTitulos;
                    coluna17.Font = fonteSubTitulos;
                    coluna18.Font = fonteSubTitulos;
                    coluna19.Font = fonteSubTitulos;
                    coluna20.Font = fonteSubTitulos;
                    coluna21.Font = fonteSubTitulos;
                    coluna22.Font = fonteSubTitulos;
                    coluna23.Font = fonteSubTitulos;
                    coluna24.Font = fonteSubTitulos;
                    coluna25.Font = fonteSubTitulos;
                    coluna26.Font = fonteSubTitulos;
                    coluna27.Font = fonteSubTitulos;
                    coluna28.Font = fonteSubTitulos;
                    coluna29.Font = fonteSubTitulos;

                    var cel1 = new PdfPCell();
                    var cel2 = new PdfPCell();
                    var cel3 = new PdfPCell();
                    var cel4 = new PdfPCell();
                    var cel5 = new PdfPCell();
                    var cel6 = new PdfPCell();
                    var cel7 = new PdfPCell();
                    var cel8 = new PdfPCell();
                    var cel9 = new PdfPCell();
                    var cel10 = new PdfPCell();
                    var cel11 = new PdfPCell();
                    var cel12 = new PdfPCell();
                    var cel13 = new PdfPCell();
                    var cel14 = new PdfPCell();
                    var cel15 = new PdfPCell();
                    var cel16 = new PdfPCell();
                    var cel17 = new PdfPCell();
                    var cel18 = new PdfPCell();
                    var cel19 = new PdfPCell();
                    var cel20 = new PdfPCell();
                    var cel21 = new PdfPCell();
                    var cel22 = new PdfPCell();
                    var cel23 = new PdfPCell();
                    var cel24 = new PdfPCell();
                    var cel25 = new PdfPCell();
                    var cel26 = new PdfPCell();
                    var cel27 = new PdfPCell();
                    var cel28 = new PdfPCell();
                    var cel29 = new PdfPCell();

                    cel1.AddElement(coluna1);
                    cel2.AddElement(coluna2);
                    cel3.AddElement(coluna3);
                    cel4.AddElement(coluna4);
                    cel5.AddElement(coluna5);
                    cel6.AddElement(coluna6);
                    cel7.AddElement(coluna7);
                    cel8.AddElement(coluna8);
                    cel9.AddElement(coluna9);
                    cel10.AddElement(coluna10);
                    cel11.AddElement(coluna11);
                    cel12.AddElement(coluna12);
                    cel13.AddElement(coluna13);
                    cel14.AddElement(coluna14);
                    cel15.AddElement(coluna15);
                    cel16.AddElement(coluna16);
                    cel17.AddElement(coluna17);
                    cel18.AddElement(coluna18);
                    cel19.AddElement(coluna19);
                    cel20.AddElement(coluna20);
                    cel21.AddElement(coluna21);
                    cel22.AddElement(coluna22);
                    cel23.AddElement(coluna23);
                    cel24.AddElement(coluna24);
                    cel25.AddElement(coluna25);
                    cel26.AddElement(coluna26);
                    cel27.AddElement(coluna27);
                    cel28.AddElement(coluna28);
                    cel29.AddElement(coluna29);

                    tabela.AddCell(cel1);
                    tabela.AddCell(cel2);
                    tabela.AddCell(cel3);
                    tabela.AddCell(cel4);
                    tabela.AddCell(cel5);
                    tabela.AddCell(cel6);
                    tabela.AddCell(cel7);
                    tabela.AddCell(cel8);
                    tabela.AddCell(cel9);
                    tabela.AddCell(cel10);
                    tabela.AddCell(cel11);
                    tabela.AddCell(cel12);
                    tabela.AddCell(cel13);
                    tabela.AddCell(cel14);
                    tabela.AddCell(cel15);
                    tabela.AddCell(cel16);
                    tabela.AddCell(cel17);
                    tabela.AddCell(cel18);
                    tabela.AddCell(cel19);
                    tabela.AddCell(cel20);
                    tabela.AddCell(cel21);
                    tabela.AddCell(cel22);
                    tabela.AddCell(cel23);
                    tabela.AddCell(cel24);
                    tabela.AddCell(cel25);
                    tabela.AddCell(cel26);
                    tabela.AddCell(cel27);
                    tabela.AddCell(cel28);
                    tabela.AddCell(cel29);

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
    }
}
