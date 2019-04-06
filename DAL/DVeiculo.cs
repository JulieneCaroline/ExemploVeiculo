using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public static class DVeiculo
    {
        public static void Inserir(MVeiculo item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            //string RENAVAM = item.RENAVAM;
            //string Placa = item.Placa;
            //string Modelo = item.Modelo;
            //string AnoFabricacao = item.AnoFabricacao.ToString();
            //string AnoModelo = item.AnoModelo.ToString();
            //string PessoaCPF = item.PessoaCPF;

            //MessageBox.Show(RENAVAM);
            //MessageBox.Show(Placa);
            //MessageBox.Show(Modelo);
            //MessageBox.Show(AnoFabricacao);
            //MessageBox.Show(AnoModelo);
            //MessageBox.Show(PessoaCPF);

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
            "INSERT INTO TBVeiculo(RENAVAM, Placa, Modelo, AnoFabricacao, AnoModelo, PessoaCPF) " +
            "VALUES(@RENAVAM, @Placa, @Modelo, @AnoFabricacao, @AnoModelo, @PessoaCPF)";

            SqlParameter param = new SqlParameter("@RENAVAM", SqlDbType.Char);
            param.Value = item.RENAVAM;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Placa", SqlDbType.Char);
            param.Value = item.Placa;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Modelo", SqlDbType.Char);
            param.Value = item.Modelo;
            comando.Parameters.Add(param);

            param = new SqlParameter("@AnoFabricacao", SqlDbType.Int);
            int AnoFabricacaoBd = Convert.ToInt32(item.AnoFabricacao);
            param.Value = AnoFabricacaoBd;
            comando.Parameters.Add(param);

            param = new SqlParameter("@AnoModelo", SqlDbType.Int);
            int AnoModeloBd = item.AnoModelo;
            param.Value = AnoModeloBd;
            comando.Parameters.Add(param);

            param = new SqlParameter("@PessoaCPF", SqlDbType.Char);
            param.Value = item.PessoaCPF;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //throw new Exception("O comando não pode ser executado.");
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void Atualizar(MVeiculo item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
                "UPDATE TBVeiculo SET Placa = @Placa, Modelo = @Modelo, AnoFabricacao = @AnoFabricacao, AnoModelo = @AnoModelo " +
                " WHERE RENAVAM = @RENAVAM";

            SqlParameter param = new SqlParameter("@RENAVAM", SqlDbType.Char);
            param.Value = item.RENAVAM;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Placa", SqlDbType.VarChar);
            param.Value = item.Placa;
            comando.Parameters.Add(param);

            param = new SqlParameter("@Modelo", SqlDbType.Date);
            param.Value = item.Modelo;
            comando.Parameters.Add(param);

            param = new SqlParameter("@AnoFabricacao", SqlDbType.Date);
            param.Value = item.AnoFabricacao;
            comando.Parameters.Add(param);

            param = new SqlParameter("@AnoModelo", SqlDbType.Date);
            param.Value = item.AnoModelo;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("O comando não pode ser executado");
            }
            finally
            {
                conexao.Close();
            }

        }

        public static MVeiculo Obter(MVeiculo item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
                " SELECT RENAVAM, Placa, Modelo, AnoFabricacao, AnoModelo, PessoaCPF" +
                " FROM TBVeiculo" +
                " WHERE RENAVAM = @RENAVAM ";

            SqlParameter param = new SqlParameter("@RENAVAM", SqlDbType.Char);
            param.Value = item.RENAVAM;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            MVeiculo retorno = null;

            if (reader.Read())
            {
                retorno = new MVeiculo();

                retorno.RENAVAM = reader["RENAVAM"].ToString();
                retorno.Placa = reader["Placa"].ToString();
                retorno.Modelo = reader["Modelo"].ToString();
                retorno.AnoFabricacao = (int)reader["AnoFabricacao"];
                retorno.AnoModelo = (int)reader["AnoModelo"];
                retorno.PessoaCPF = reader["PessoaCPF"].ToString();
            }

            reader.Close();
            conexao.Close();

            return retorno;
        }


        public static void Excluir(MVeiculo item)
        {
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "DELETE FROM TBVeiculo where PessoaCPF = @PessoaCPF";

            SqlParameter param = new SqlParameter("@PessoaCPF", SqlDbType.Char);
            param.Value = item.PessoaCPF;
            comando.Parameters.Add(param);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static List<MVeiculo> Pesquisar(MVeiculo item)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
                ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "" +
                " SELECT RENAVAM, Placa, Modelo, AnoFabricacao, AnoModelo, PessoaCPF" +
                " FROM TBVeiculo" +
                " WHERE 1=1 ";

            //if (item.RENAVAM.Trim() != "")
            //{
            //    comando.CommandText += " AND RENAVAM = @RENAVAM ";

            //    SqlParameter param = new SqlParameter("@RENAVAM", SqlDbType.Char);
            //    param.Value = item.RENAVAM;
            //    comando.Parameters.Add(param);
            //}

            //if (item.Placa.Trim() != "")
            //{
            //    comando.CommandText += " AND Placa = @Placa ";

            //    SqlParameter param = new SqlParameter("@Placa", SqlDbType.Char);
            //    param.Value = item.Placa;
            //    comando.Parameters.Add(param);
            //}

            //if (item.Modelo.Trim() != "")
            //{
            //    comando.CommandText += " AND Modelo LIKE @Modelo ";

            //    SqlParameter param = new SqlParameter("@Modelo", SqlDbType.VarChar);
            //    param.Value = "%" + item.Modelo + "%";
            //    comando.Parameters.Add(param);
            //}

            //if (item.PessoaCPF.Trim() != "")
            //{
            //    comando.CommandText += " AND PessoaCPF = @PessoaCPF ";

            //    SqlParameter param = new SqlParameter("@Modelo", SqlDbType.VarChar);
            //    param.Value = "%" + item.PessoaCPF + "%";
            //    comando.Parameters.Add(param);
            //}

            //if (item.AnoModelo.Trim() != "")
            //{
            //    comando.CommandText += " AND AnoModelo = @AnoModelo ";

            //    SqlParameter param = new SqlParameter("@AnoModelo", SqlDbType.Char);
            //    param.Value = item.AnoModelo;
            //    comando.Parameters.Add(param);
            //}

            //if (item.AnoFabricacao.Trim() != "")
            //{
            //    comando.CommandText += " AND AnoFabricacao = @AnoFabricacao ";

            //    SqlParameter param = new SqlParameter("@AnoFabricacao", SqlDbType.Char);
            //    param.Value = item.AnoFabricacao;
            //    comando.Parameters.Add(param);
            //}


            SqlDataReader reader = comando.ExecuteReader();

            List<MVeiculo> retorno = null;

            while (reader.Read())
            {
                if (retorno == null)
                    retorno = new List<MVeiculo>();

                MVeiculo veiculo = new MVeiculo();

                veiculo.RENAVAM = reader["RENAVAM"].ToString();
                veiculo.Placa = reader["Placa"].ToString();
                veiculo.Modelo = reader["Modelo"].ToString();
                veiculo.AnoModelo = (int)reader["AnoModelo"];
                veiculo.AnoFabricacao = (int)reader["AnoFabricacao"];
                veiculo.PessoaCPF = reader["PessoaCPF"].ToString();

                retorno.Add(veiculo);
            }

            reader.Close();
            conexao.Close();

            return retorno;

        }
    }
}
