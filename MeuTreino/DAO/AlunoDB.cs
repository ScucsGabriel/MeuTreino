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
    class AlunoDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Aluno InserirAluno(string nomeAluno, string emailAluno, string telefoneAluno, string enderecoAluno, int idadeAluno, string alunoAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Aluno(nomeAluno, emailAluno, telefoneAluno, enderecoAluno, idadeAluno, alunoAtivo)" +
                " VALUES (@nomeAluno, @emailAluno, @telefoneAluno, @enderecoAluno, @idadeAluno, @alunoAtivo)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@nomeAluno", nomeAluno));
            comando.Parameters.Add(new SqlParameter("@emailAluno", emailAluno));
            comando.Parameters.Add(new SqlParameter("@telefoneAluno", telefoneAluno));
            comando.Parameters.Add(new SqlParameter("@enderecoAluno", enderecoAluno));
            comando.Parameters.Add(new SqlParameter("@idadeAluno", idadeAluno));
            comando.Parameters.Add(new SqlParameter("@alunoAtivo", alunoAtivo));

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

        internal int ConsultarUltimoAlunoInserido()
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT TOP(1) * FROM Aluno";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            int idAluno = 0;

            while (dr.Read())
            {
                idAluno = Convert.ToInt32(dr["idAluno"].ToString());
            }
            conn.Close();

            return idAluno;
        }

        internal int ConsultarMedidaPorIdAlunoMedida(int idAlunoMedida)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno WHERE idAluno = " + idAlunoMedida;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            int idAluno = 0;

            while (dr.Read())
            {
                idAluno = Convert.ToInt32(dr["idAluno"].ToString());
            }
            conn.Close();

            return idAluno;
        }

        internal List<Aluno> ConsultarTodoAlunoAtivo()
        {
            List<Aluno> lstAluno = new List<Aluno>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno WHERE alunoAtivo = 'Sim' ORDER BY nomeAluno";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Aluno aluno = new Aluno();
                aluno.idAluno = Convert.ToInt32(dr["idAluno"].ToString());
                aluno.nomeAluno = dr["nomeAluno"].ToString();
                aluno.emailAluno = dr["emailAluno"].ToString();
                aluno.telefoneAluno = dr["telefoneAluno"].ToString();
                aluno.enderecoAluno = dr["enderecoAluno"].ToString();
                aluno.idadeAluno = Convert.ToInt32(dr["idadeAluno"].ToString());
                aluno.alunoAtivo = dr["alunoAtivo"].ToString();

                lstAluno.Add(aluno);
            }
            conn.Close();

            return lstAluno;
        }

        internal List<Aluno> ConsultarTodoAluno()
        {
            List<Aluno> lstAluno = new List<Aluno>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno ORDER BY nomeAluno";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Aluno aluno = new Aluno();
                aluno.idAluno = Convert.ToInt32(dr["idAluno"].ToString());
                aluno.nomeAluno = dr["nomeAluno"].ToString();
                aluno.emailAluno = dr["emailAluno"].ToString();
                aluno.telefoneAluno = dr["telefoneAluno"].ToString();
                aluno.enderecoAluno = dr["enderecoAluno"].ToString();
                aluno.idadeAluno = Convert.ToInt32(dr["idadeAluno"].ToString());
                aluno.alunoAtivo = dr["alunoAtivo"].ToString();

                lstAluno.Add(aluno);
            }
            conn.Close();

            return lstAluno;
        }

        internal List<Aluno> ConsultarAlunoPorId(int idAluno)
        {
            List<Aluno> lstAluno = new List<Aluno>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno WHERE idAluno = " + idAluno + "AND alunoAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Aluno aluno = new Aluno();
                aluno.idAluno = Convert.ToInt32(dr["idAluno"].ToString());
                aluno.nomeAluno = dr["nomeAluno"].ToString();
                aluno.emailAluno = dr["emailAluno"].ToString();
                aluno.telefoneAluno = dr["telefoneAluno"].ToString();
                aluno.enderecoAluno = dr["enderecoAluno"].ToString();
                aluno.idadeAluno = Convert.ToInt32(dr["idadeAluno"].ToString());
                aluno.alunoAtivo = dr["alunoAtivo"].ToString();

                lstAluno.Add(aluno);
            }
            conn.Close();

            return lstAluno;
        }

        internal string ConsultarNomeAlunoPorId(int idAluno)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno WHERE idAluno = " + idAluno + "AND alunoAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string aluno = "";

            while (dr.Read())
            {
               aluno = dr["nomeAluno"].ToString();
            }
            conn.Close();

            return aluno;
        }

        internal List<Aluno> ConsultarAlunoPorNome(string nomeAluno)
        {
            List<Aluno> lstAluno = new List<Aluno>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno WHERE alunoAtivo = 'Sim'" +
                               " AND (nomeAluno LIKE '%" + nomeAluno + "%')" +
                               " ORDER BY nomeAluno";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Aluno aluno = new Aluno();
                aluno.idAluno = Convert.ToInt32(dr["idAluno"].ToString());
                aluno.nomeAluno = dr["nomeAluno"].ToString();
                aluno.emailAluno = dr["emailAluno"].ToString();
                aluno.telefoneAluno = dr["telefoneAluno"].ToString();
                aluno.enderecoAluno = dr["enderecoAluno"].ToString();
                aluno.idadeAluno = Convert.ToInt32(dr["idadeAluno"].ToString());
                aluno.alunoAtivo = dr["alunoAtivo"].ToString();

                lstAluno.Add(aluno);
            }
            conn.Close();

            return lstAluno;
        }

        internal List<Aluno> ConsultarAlunoPorEmail(string emailAluno)
        {
            List<Aluno> lstAluno = new List<Aluno>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno WHERE emailAluno like '%" + emailAluno + "%' " +
                               " AND alunoAtivo = 'Sim' ORDER BY emailAluno";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Aluno aluno = new Aluno();
                aluno.idAluno = Convert.ToInt32(dr["idAluno"].ToString());
                aluno.nomeAluno = dr["nomeAluno"].ToString();
                aluno.emailAluno = dr["emailAluno"].ToString();
                aluno.telefoneAluno = dr["telefoneAluno"].ToString();
                aluno.enderecoAluno = dr["enderecoAluno"].ToString();
                aluno.idadeAluno = Convert.ToInt32(dr["idadeAluno"].ToString());
                aluno.alunoAtivo = dr["alunoAtivo"].ToString();

                lstAluno.Add(aluno);
            }
            conn.Close();

            return lstAluno;
        }
        internal List<Aluno> ConsultarAlunoPorTelefone(string telefoneAluno)
        {
            List<Aluno> lstAluno = new List<Aluno>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno WHERE telefoneAluno like '%" + telefoneAluno + "%' " +
                               " AND alunoAtivo = 'Sim' ORDER BY telefoneAluno";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Aluno aluno = new Aluno();
                aluno.idAluno = Convert.ToInt32(dr["idAluno"].ToString());
                aluno.nomeAluno = dr["nomeAluno"].ToString();
                aluno.emailAluno = dr["emailAluno"].ToString();
                aluno.telefoneAluno = dr["telefoneAluno"].ToString();
                aluno.enderecoAluno = dr["enderecoAluno"].ToString();
                aluno.idadeAluno = Convert.ToInt32(dr["idadeAluno"].ToString());
                aluno.alunoAtivo = dr["alunoAtivo"].ToString();

                lstAluno.Add(aluno);
            }
            conn.Close();

            return lstAluno;
        }

        internal List<Aluno> ConsultarAlunoPorEndereco(string enderecoAluno)
        {
            List<Aluno> lstAluno = new List<Aluno>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Aluno WHERE enderecoAluno like '%" + enderecoAluno + "%' " +
                               " AND alunoAtivo = 'Sim' ORDER BY nomeAluno";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Aluno aluno = new Aluno();
                aluno.idAluno = Convert.ToInt32(dr["idAluno"].ToString());
                aluno.nomeAluno = dr["nomeAluno"].ToString();
                aluno.emailAluno = dr["emailAluno"].ToString();
                aluno.telefoneAluno = dr["telefoneAluno"].ToString();
                aluno.enderecoAluno = dr["enderecoAluno"].ToString();
                aluno.idadeAluno = Convert.ToInt32(dr["idadeAluno"].ToString());
                aluno.alunoAtivo = dr["alunoAtivo"].ToString();

                lstAluno.Add(aluno);
            }
            conn.Close();

            return lstAluno;
        }

        internal Aluno ExcluirAluno(int idAluno)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Aluno SET alunoAtivo = 'Não'" +
                               " WHERE idAluno = " + idAluno;
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

        internal List<Aluno> EditarAluno(int idAluno, string nomeAluno, string emailAluno, string telefoneAluno, string enderecoAluno, int idadeAluno, string alunoAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Aluno SET nomeAluno = @nomeAluno, emailAluno = @emailAluno, telefoneAluno = @telefoneAluno, enderecoAluno = @enderecoAluno, idadeAluno = @idadeAluno, alunoAtivo = @alunoAtivo" +
                               " WHERE idAluno = " + idAluno;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@nomeAluno", nomeAluno));
            cmd.Parameters.Add(new SqlParameter("@emailAluno", emailAluno));
            cmd.Parameters.Add(new SqlParameter("@telefoneAluno", telefoneAluno));
            cmd.Parameters.Add(new SqlParameter("@enderecoAluno", enderecoAluno));
            cmd.Parameters.Add(new SqlParameter("@idadeAluno", idadeAluno));
            cmd.Parameters.Add(new SqlParameter("@alunoAtivo", alunoAtivo));

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
