using MeuTreino.DAO;
using MeuTreino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTreino.Controller
{
    public class TreinoController
    {

        public Treino InserirTreino(int numeroMatricula, string siglaTreino, string nomeTreino, string exercicio, int serie, string repeticao, string intervalo, 
            string metodo, string pse, string velocidadeExecucao, DateTime dataTreino, string treinoAtivo)
        {
            return new TreinoDB().InserirTreino(numeroMatricula, siglaTreino, nomeTreino, exercicio, serie, repeticao, intervalo, metodo, pse, velocidadeExecucao,
                dataTreino, treinoAtivo);
        }
        public List<Treino> ConsultarTreinoPorSigla(string treinoAluno)
        {
            return new TreinoDB().ConsultarTreinoPorSigla(treinoAluno);
        }

        public Treino ExcluirTreino(int idTreino, int idAlunoTreino)
        {
            return new TreinoDB().ExcluirTreino(idTreino, idAlunoTreino);
        }

        public List<Treino> AtualizarTreino(int idTreino, int numeroMatricula, string siglaTreino, string nomeTreino, string exercicio, int serie, string repeticao, string intervalo,
            string metodo, string pse, string velocidadeExecucao, DateTime dataTreino, string treinoAtivo)
        {
            return new TreinoDB().AtualizarTreino(idTreino, numeroMatricula, siglaTreino, nomeTreino, exercicio, serie, repeticao, intervalo, metodo, pse, velocidadeExecucao,
                dataTreino, treinoAtivo);
        }
    }
}
