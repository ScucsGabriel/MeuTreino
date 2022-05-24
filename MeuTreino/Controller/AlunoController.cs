using MeuTreino.DAO;
using MeuTreino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTreino.Controller
{
    public class AlunoController
    {
        public Aluno InserirAluno(string nomeAluno, string emailAluno, string telefoneAluno, string enderecoAluno, int idadeAluno, string alunoAtivo)
        {
            return new AlunoDB().InserirAluno(nomeAluno, emailAluno, telefoneAluno, enderecoAluno, idadeAluno, alunoAtivo);
        }

        public List<Aluno> ConsultarAlunoPorNome(string nomeAluno)
        {
            return new AlunoDB().ConsultarAlunoPorNome(nomeAluno);
        }

        public List<Aluno> ConsultarAlunoPorEmail(string emailAluno)
        {
            return new AlunoDB().ConsultarAlunoPorEmail(emailAluno);
        }
        public List<Aluno> ConsultarAlunoPorTelefone(string telefoneAluno)
        {
            return new AlunoDB().ConsultarAlunoPorTelefone(telefoneAluno);
        }
        public List<Aluno> ConsultarAlunoPorEndereco(string enderecoAluno)
        {
            return new AlunoDB().ConsultarAlunoPorEndereco(enderecoAluno);
        }
        public List<Aluno> ConsultarAlunoPorId(int idAluno)
        {
            return new AlunoDB().ConsultarAlunoPorId(idAluno);
        }
        public string ConsultarNomeAlunoPorId (int idAluno)
        {
            return new AlunoDB().ConsultarNomeAlunoPorId(idAluno);
        }
        public List<Aluno> ConsultarTodoAluno()
        {
            return new AlunoDB().ConsultarTodoAluno();
        }
        public List<Aluno> ConsultarTodoAlunoAtivo()
        {
            return new AlunoDB().ConsultarTodoAlunoAtivo();
        }
        public int ConsultarUltimoAlunoInserido()
        {
            return new AlunoDB().ConsultarUltimoAlunoInserido();
        }
        public int ConsultarMedidaPorIdAlunoMedida(int idAlunoMedida)
        {
            return new AlunoDB().ConsultarMedidaPorIdAlunoMedida(idAlunoMedida);
        }
        public Aluno ExcluirAluno(int idAluno)
        {
            return new AlunoDB().ExcluirAluno(idAluno);
        }

        public List<Aluno> EditarAluno(int idAluno, string nomeAluno, string emailAluno, string telefoneAluno, string enderecoAluno, int idadeAluno, string alunoAtivo)
        {
            return new AlunoDB().EditarAluno(idAluno, nomeAluno, emailAluno, telefoneAluno, enderecoAluno, idadeAluno, alunoAtivo);
        }
    }
}
