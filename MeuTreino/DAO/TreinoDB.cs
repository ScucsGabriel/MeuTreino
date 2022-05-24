using MeuTreino.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTreino.DAO
{
    class TreinoDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Treino InserirTreino(int numeroMatricula, string siglaTreino, string nomeTreino, string exercicio, int serie, string repeticao, string intervalo,
            string metodo, string pse, string velocidadeExecucao, DateTime dataTreino, string treinoAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Treino(idAlunoTreino, siglaTreino, nomeTreino, exercicio, serie, repeticao, intervalo, metodo, pse, velocidadeExecucao, dataTreino, treinoAtivo)" +
                " VALUES (@idAlunoTreino, @siglaTreino, @nomeTreino, @exercicio, @serie, @repeticao, @intervalo, @metodo, @pse, @velocidadeExecucao, @dataTreino, @treinoAtivo)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@idAlunoTreino", numeroMatricula));
            comando.Parameters.Add(new SqlParameter("@siglaTreino", siglaTreino));
            comando.Parameters.Add(new SqlParameter("@nomeTreino", nomeTreino));
            comando.Parameters.Add(new SqlParameter("@exercicio", exercicio));
            comando.Parameters.Add(new SqlParameter("@serie", serie));
            comando.Parameters.Add(new SqlParameter("@repeticao", repeticao));
            comando.Parameters.Add(new SqlParameter("@intervalo", intervalo));
            comando.Parameters.Add(new SqlParameter("@metodo", metodo));
            comando.Parameters.Add(new SqlParameter("@pse", pse));
            comando.Parameters.Add(new SqlParameter("@velocidadeExecucao", velocidadeExecucao));
            comando.Parameters.Add(new SqlParameter("@dataTreino", dataTreino));
            comando.Parameters.Add(new SqlParameter("@treinoAtivo", treinoAtivo));

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
        internal List<Treino> ConsultarTreinoPorSigla(string treinoAluno)
        {
            List<Treino> lstTreino = new List<Treino>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Treino WHERE treinoAtivo = 'Sim'" +
                               " AND (siglaTreino = '" + treinoAluno + "')" +
                               " ORDER BY nomeTreino";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Treino treino = new Treino();
                treino.idTreino = Convert.ToInt32(dr["idTreino"].ToString());
                treino.idAlunoTreino = Convert.ToInt32(dr["idAlunoTreino"].ToString());
                treino.siglaTreino = dr["siglaTreino"].ToString();
                treino.nomeTreino = dr["nomeTreino"].ToString();
                treino.exercicio = dr["exercicio"].ToString();
                treino.serie = Convert.ToInt32(dr["serie"].ToString());
                treino.repeticao = dr["repeticao"].ToString();
                treino.intervalo = dr["intervalo"].ToString();
                treino.metodo = dr["metodo"].ToString();
                treino.pse = dr["pse"].ToString();
                treino.velocidadeExecucao = dr["velocidadeExecucao"].ToString();
                treino.dataTreino = Convert.ToDateTime(dr["dataTreino"].ToString());
                treino.treinoAtivo = dr["treinoAtivo"].ToString();

                lstTreino.Add(treino);
            }
            conn.Close();

            return lstTreino;
        }

        internal Treino ExcluirTreino(int idTreino, int idAlunoTreino)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Treino SET treinoAtivo = 'Não'" +
                               " WHERE idAlunoTreino = " + idAlunoTreino + "AND idTreino = " + idTreino;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na exclusão: " + e);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        internal List<Treino> AtualizarTreino(int idTreino, int numeroMatricula, string siglaTreino, string nomeTreino, string exercicio, int serie, string repeticao, string intervalo,
            string metodo, string pse, string velocidadeExecucao, DateTime dataTreino, string treinoAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Treino SET siglaTreino = @siglaTreino, nomeTreino = @nomeTreino, exercicio = @exercicio, serie = @serie, repeticao = @repeticao, " +
                "intervalo = @intervalo, metodo = @metodo, pse = @pse, velocidadeExecucao = @velocidadeExecucao, dataTreino = @dataTreino, treinoAtivo = @treinoAtivo" +
                " WHERE idAlunoTreino = " + numeroMatricula + "AND idTreino = " + idTreino;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@siglaTreino", siglaTreino));
            cmd.Parameters.Add(new SqlParameter("@nomeTreino", nomeTreino));
            cmd.Parameters.Add(new SqlParameter("@exercicio", exercicio));
            cmd.Parameters.Add(new SqlParameter("@serie", serie));
            cmd.Parameters.Add(new SqlParameter("@repeticao", repeticao));
            cmd.Parameters.Add(new SqlParameter("@intervalo", intervalo));
            cmd.Parameters.Add(new SqlParameter("@metodo", metodo));
            cmd.Parameters.Add(new SqlParameter("@pse", pse));
            cmd.Parameters.Add(new SqlParameter("@velocidadeExecucao", velocidadeExecucao));
            cmd.Parameters.Add(new SqlParameter("@dataTreino", dataTreino));
            cmd.Parameters.Add(new SqlParameter("@treinoAtivo", treinoAtivo));

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
