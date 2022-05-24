using MeuTreino.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MeuTreino.Model
{
    public class Medidas
    {
        public int idAlunoMedida { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public double ombro { get; set; }
        public double cintura { get; set; }
        public double abdomen { get; set; }
        public double coxaDireita { get; set; }
        public double panturrilhaDireita { get; set; }
        public double bracoRelaxadoDireito { get; set; }
        public double bracoContraidoDireito { get; set; }
        public double antebracoDireito { get; set; }
        public double abdominal { get; set; }
        public double triceps { get; set; }
        public double suprailiaca { get; set; }
        public double axilarMedia { get; set; }
        public double subescapular { get; set; }
        public double torax { get; set; }
        public double coxa { get; set; }
        public double imc { get; set; }
        public double percentualMassaGorda { get; set; }
        public double percentualMassaMagra { get; set; }
        public double pesoMassaGorda { get; set; }
        public double pesoMassaMagra { get; set; }
        public double somaDobras { get; set; }
        public double areaMuscularBraco { get; set; }
        public double areaGorduraBraco { get; set; }
        public DateTime dataAvaliacao { get; set; }
        public Aluno aluno { get; set; }
        public List<Aluno> listaAlunos { get; set; }
        public Medidas()
        {
            this.aluno = new Aluno();
        }
    }
}
