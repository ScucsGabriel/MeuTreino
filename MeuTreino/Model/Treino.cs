using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTreino.Model
{
    public class Treino
    {
        public int idTreino { get; set; }
        public int idAlunoTreino { get; set; }
        public string siglaTreino { get; set; }
        public string nomeTreino { get; set; }
        public string exercicio { get; set; }
        public int serie { get; set; }
        public string repeticao { get; set; }
        public string intervalo { get; set; }
        public string metodo { get; set; }
        public string pse { get; set; }
        public string velocidadeExecucao { get; set; }
        public DateTime dataTreino { get; set; }
        public string treinoAtivo { get; set; }
        public Aluno aluno { get; set; }
        public Treino()
        {
            this.aluno = new Aluno();
        }
    }
}
