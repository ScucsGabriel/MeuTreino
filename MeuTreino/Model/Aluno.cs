using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTreino.Model
{
    public class Aluno
    {
        public int idAluno { get; set; }
        public string nomeAluno { get; set; }
        public string emailAluno { get; set; }
        public string telefoneAluno { get; set; }
        public string enderecoAluno { get; set; }
        public int idadeAluno { get; set; }
        public string alunoAtivo { get; set; }
    }
}
