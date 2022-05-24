using MeuTreino.DAO;
using MeuTreino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTreino.Controller
{
    public class MedidasController
    {
        public Medidas InserirMedidas(int ultimoAlunoInserido, double peso, double altura, double ombro, double cintura, double abdomen, double coxaDireita,
            double panturrilhaDireita, double bracoRelaxadoDireito, double bracoContraidoDireito, double antebracoDireito, double abdominal, double triceps,
            double suprailiaca, double axilarMedia, double subescapular, double torax, double coxa, double imc, double percentualMassaGorda, double percentualMassaMagra,
            double pesoMassaGorda, double pesoMassaMagra, double somaDobras, double areaMuscularBraco, double areaGorduraBraco, DateTime dataAvaliacao)
        {
            return new MedidasDB().InserirMedidas(ultimoAlunoInserido, peso, altura, ombro, cintura, abdomen, coxaDireita, panturrilhaDireita, bracoRelaxadoDireito,
                bracoContraidoDireito, antebracoDireito, abdominal, triceps, suprailiaca, axilarMedia, subescapular, torax, coxa, imc, percentualMassaGorda,
                percentualMassaMagra, pesoMassaGorda, pesoMassaMagra, somaDobras, areaMuscularBraco, areaGorduraBraco, dataAvaliacao);
        }
        
         public List<Medidas> ConsultarMedidaPorIdAlunoMedida(int idAlunoMedida)
        {
            return new MedidasDB().ConsultarMedidaPorIdAlunoMedida(idAlunoMedida);
        }

        public List<Medidas> AtualizarMedidas(int idAlunoMedida, double peso, double altura, double ombro, double cintura, double abdomen, double coxaDireita,
            double panturrilhaDireita, double bracoRelaxadoDireito, double bracoContraidoDireito, double antebracoDireito, double abdominal, double triceps,
            double suprailiaca, double axilarMedia, double subescapular, double torax, double coxa, double imc, double percentualMassaGorda, double percentualMassaMagra,
            double pesoMassaGorda, double pesoMassaMagra, double somaDobras, double areaMuscularBraco, double areaGorduraBraco, DateTime dataAvaliacao)
        {
            return new MedidasDB().AtualizarMedidas(idAlunoMedida, peso, altura, ombro, cintura, abdomen, coxaDireita, panturrilhaDireita, bracoRelaxadoDireito,
                bracoContraidoDireito, antebracoDireito, abdominal, triceps, suprailiaca, axilarMedia, subescapular, torax, coxa, imc, percentualMassaGorda,
                percentualMassaMagra, pesoMassaGorda, pesoMassaMagra, somaDobras, areaMuscularBraco, areaGorduraBraco, dataAvaliacao);
        }
    }
}
