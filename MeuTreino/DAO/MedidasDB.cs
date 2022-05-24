using MeuTreino.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTreino.DAO
{
    class MedidasDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Medidas InserirMedidas(int ultimoAlunoInserido, double peso, double altura, double ombro, double cintura, double abdomen, double coxaDireita,
            double panturrilhaDireita, double bracoRelaxadoDireito, double bracoContraidoDireito, double antebracoDireito, double abdominal, double triceps,
            double suprailiaca, double axilarMedia, double subescapular, double torax, double coxa, double imc, double percentualMassaGorda, double percentualMassaMagra,
            double pesoMassaGorda, double pesoMassaMagra, double somaDobras, double areaMuscularBraco, double areaGorduraBraco, DateTime dataAvaliacao)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Medidas(idAlunoMedida, peso, altura, ombro, cintura, abdomen, coxaDireita, panturrilhaDireita," +
                " bracoRelaxadoDireito, bracoContraidoDireito, antebracoDireito, abdominal, triceps, suprailiaca, axilarMedia, subescapular, torax," +
                " coxa, imc, percentualMassaGorda, percentualMassaMagra, pesoMassaGorda, pesoMassaMagra, somaDobras, areaMuscularBraco, areaGorduraBraco, dataAvaliacao)" +
                " VALUES (@idAlunoMedida, @peso, @altura, @ombro, @cintura, @abdomen, @coxaDireita, @panturrilhaDireita, @bracoRelaxadoDireito," +
                " @bracoContraidoDireito, @antebracoDireito, @abdominal, @triceps, @suprailiaca, @axilarMedia, @subescapular, @torax, @coxa, @imc," +
                " @percentualMassaGorda, @percentualMassaMagra, @pesoMassaGorda, @pesoMassaMagra, @somaDobras, @areaMuscularBraco, @areaGorduraBraco, @dataAvaliacao)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@idAlunoMedida", ultimoAlunoInserido));
            comando.Parameters.Add(new SqlParameter("@peso", peso));
            comando.Parameters.Add(new SqlParameter("@altura", altura));
            comando.Parameters.Add(new SqlParameter("@ombro", ombro));
            comando.Parameters.Add(new SqlParameter("@cintura", cintura));
            comando.Parameters.Add(new SqlParameter("@abdomen", abdomen));
            comando.Parameters.Add(new SqlParameter("@coxaDireita", coxaDireita));
            comando.Parameters.Add(new SqlParameter("@panturrilhaDireita", panturrilhaDireita));
            comando.Parameters.Add(new SqlParameter("@bracoRelaxadoDireito", bracoRelaxadoDireito));
            comando.Parameters.Add(new SqlParameter("@bracoContraidoDireito", bracoContraidoDireito));
            comando.Parameters.Add(new SqlParameter("@antebracoDireito", antebracoDireito));
            comando.Parameters.Add(new SqlParameter("@abdominal", abdominal));
            comando.Parameters.Add(new SqlParameter("@triceps", triceps));
            comando.Parameters.Add(new SqlParameter("@suprailiaca", suprailiaca));
            comando.Parameters.Add(new SqlParameter("@axilarMedia", axilarMedia));
            comando.Parameters.Add(new SqlParameter("@subescapular", subescapular));
            comando.Parameters.Add(new SqlParameter("@torax", torax));
            comando.Parameters.Add(new SqlParameter("@coxa", coxa));
            comando.Parameters.Add(new SqlParameter("@imc", imc));
            comando.Parameters.Add(new SqlParameter("@percentualMassaGorda", percentualMassaGorda));
            comando.Parameters.Add(new SqlParameter("@percentualMassaMagra", percentualMassaMagra));
            comando.Parameters.Add(new SqlParameter("@pesoMassaGorda", pesoMassaGorda));
            comando.Parameters.Add(new SqlParameter("@pesoMassaMagra", pesoMassaMagra));
            comando.Parameters.Add(new SqlParameter("@somaDobras", somaDobras));
            comando.Parameters.Add(new SqlParameter("@areaMuscularBraco", areaMuscularBraco));
            comando.Parameters.Add(new SqlParameter("@areaGorduraBraco", areaGorduraBraco));
            comando.Parameters.Add(new SqlParameter("@dataAvaliacao", dataAvaliacao));

            try
            {
                conn.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na gravação de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
        
        internal List<Medidas> ConsultarMedidaPorIdAlunoMedida(int idAlunoMedida)
        {
            List<Medidas> lstMedidas = new List<Medidas>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Medidas WHERE idAlunoMedida = " + idAlunoMedida;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Medidas medidas = new Medidas();
                medidas.peso = Convert.ToDouble(dr["peso"].ToString());
                medidas.altura = Convert.ToDouble(dr["altura"].ToString());
                medidas.ombro = Convert.ToDouble(dr["ombro"].ToString());
                medidas.cintura = Convert.ToDouble(dr["cintura"].ToString());
                medidas.abdomen = Convert.ToDouble(dr["abdomen"].ToString());
                medidas.coxaDireita = Convert.ToDouble(dr["coxaDireita"].ToString());
                medidas.panturrilhaDireita = Convert.ToDouble(dr["panturrilhaDireita"].ToString());
                medidas.bracoRelaxadoDireito = Convert.ToDouble(dr["bracoRelaxadoDireito"].ToString());
                medidas.bracoContraidoDireito = Convert.ToDouble(dr["bracoContraidoDireito"].ToString());
                medidas.antebracoDireito = Convert.ToDouble(dr["antebracoDireito"].ToString());
                medidas.abdominal = Convert.ToDouble(dr["abdominal"].ToString());
                medidas.triceps = Convert.ToDouble(dr["triceps"].ToString());
                medidas.suprailiaca = Convert.ToDouble(dr["suprailiaca"].ToString());
                medidas.axilarMedia = Convert.ToDouble(dr["axilarMedia"].ToString());
                medidas.subescapular = Convert.ToDouble(dr["subescapular"].ToString());
                medidas.torax = Convert.ToDouble(dr["torax"].ToString());
                medidas.coxa = Convert.ToDouble(dr["coxa"].ToString());
                medidas.imc = Convert.ToDouble(dr["imc"].ToString());
                medidas.percentualMassaGorda = Convert.ToDouble(dr["percentualMassaGorda"].ToString());
                medidas.percentualMassaMagra = Convert.ToDouble(dr["percentualMassaMagra"].ToString());
                medidas.pesoMassaGorda = Convert.ToDouble(dr["pesoMassaGorda"].ToString());
                medidas.pesoMassaMagra = Convert.ToDouble(dr["pesoMassaMagra"].ToString());
                medidas.somaDobras = Convert.ToDouble(dr["somaDobras"].ToString());
                medidas.areaMuscularBraco = Convert.ToDouble(dr["areaMuscularBraco"].ToString());
                medidas.areaGorduraBraco = Convert.ToDouble(dr["cintura"].ToString());
                medidas.cintura = Convert.ToDouble(dr["areaGorduraBraco"].ToString());
                medidas.dataAvaliacao = Convert.ToDateTime(dr["dataAvaliacao"].ToString());

                lstMedidas.Add(medidas);
            }
            conn.Close();

            return lstMedidas;
        }

        internal List<Medidas> AtualizarMedidas(int idAlunoMedida, double peso, double altura, double ombro, double cintura, double abdomen, double coxaDireita,
            double panturrilhaDireita, double bracoRelaxadoDireito, double bracoContraidoDireito, double antebracoDireito, double abdominal, double triceps,
            double suprailiaca, double axilarMedia, double subescapular, double torax, double coxa, double imc, double percentualMassaGorda, double percentualMassaMagra,
            double pesoMassaGorda, double pesoMassaMagra, double somaDobras, double areaMuscularBraco, double areaGorduraBraco, DateTime dataAvaliacao)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Medidas SET idAlunoMedida = @idAlunoMedida, peso = @peso, altura = @altura, ombro = @ombro, cintura = @cintura, abdomen = @abdomen, " +
                "coxaDireita = @coxaDireita, panturrilhaDireita = @panturrilhaDireita, bracoRelaxadoDireito = @bracoRelaxadoDireito, bracoContraidoDireito = @bracoContraidoDireito, " +
                "antebracoDireito = @antebracoDireito, abdominal = @abdominal, triceps = @triceps, suprailiaca = @suprailiaca, axilarMedia = @axilarMedia, subescapular = @subescapular," +
                "torax = @torax, coxa = @coxa, imc = @imc, percentualMassaGorda = @percentualMassaGorda, percentualMassaMagra = @percentualMassaMagra, " +
                "pesoMassaGorda = @pesoMassaGorda, pesoMassaMagra = @pesoMassaMagra, somaDobras = @somaDobras, areaMuscularBraco = @areaMuscularBraco, areaGorduraBraco = @areaGorduraBraco, dataAvaliacao = @dataAvaliacao" +
                " WHERE idAlunoMedida = " + idAlunoMedida;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@idAlunoMedida", idAlunoMedida));
            cmd.Parameters.Add(new SqlParameter("@peso", peso.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@altura", altura.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@ombro", ombro.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@cintura", cintura.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@abdomen", abdomen.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@coxaDireita", coxaDireita.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@panturrilhaDireita", panturrilhaDireita.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@bracoRelaxadoDireito", bracoRelaxadoDireito.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@bracoContraidoDireito", bracoContraidoDireito.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@antebracoDireito", antebracoDireito.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@abdominal", abdominal.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@triceps", triceps.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@suprailiaca", suprailiaca.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@axilarMedia", axilarMedia.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@subescapular", subescapular.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@torax", torax.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@coxa", coxa.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@imc", imc.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@percentualMassaGorda", percentualMassaGorda.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@percentualMassaMagra", percentualMassaMagra.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@pesoMassaGorda", pesoMassaGorda.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@pesoMassaMagra", pesoMassaMagra.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@somaDobras", somaDobras.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@areaMuscularBraco", areaMuscularBraco.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@areaGorduraBraco", areaGorduraBraco.ToString(CultureInfo.InvariantCulture)));
            cmd.Parameters.Add(new SqlParameter("@dataAvaliacao", dataAvaliacao));

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na edição de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
