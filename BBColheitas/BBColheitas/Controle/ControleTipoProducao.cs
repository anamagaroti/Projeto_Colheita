using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BBColheitas.Modelo;

namespace BBColheitas.Controle
{
    class ControleTipoProducao
    {
        #region CADASTRO
        public string CadastraTipoProducao(ModeloTipoProducao mTipoProd)
        {
            string sql = "insert into tipo_producao(nome_tipo, valor) " +
                "values(@nome_tipo, @valor); ";

            ConexaoBD con = new ConexaoBD();
            SqlConnection conn = con.Conectar();
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nome_tipo", mTipoProd.Getnome_tipo());
                comm.Parameters.AddWithValue("@valor", mTipoProd.GetValor());               

                comm.ExecuteNonQuery();
                return "Funcionário cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Erro ao cadastrar!";
            }
        }
        #endregion

        #region PESQUISA
        public SqlDataReader PesquisaTipoProducao(ModeloTipoProducao mTipoProd)
        {
            string sql = "select * from tipo_producao where nome_tipo like @nome_tipo";

            //armazena o resultado da consulta SQL
            SqlDataReader dados;

            ConexaoBD con = new ConexaoBD();
            SqlConnection conn = con.Conectar();
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nome_tipo", mTipoProd.Getnome_tipo());
                dados = comm.ExecuteReader();

                return dados;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
        #endregion

        #region ATUALIZAÇÃO
        public string AtualizaTipoProducao(ModeloTipoProducao mTipoProd)
        {
            string sql = "update tipo_producao set  nome_tipo = @nome_tipo, valor = @valor where codigo= @codigo; ";

            ConexaoBD con = new ConexaoBD();
            SqlConnection conn = con.Conectar();
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@codigo", mTipoProd.GetCodigo());
                comm.Parameters.AddWithValue("@nome_tipo", mTipoProd.Getnome_tipo());
                comm.Parameters.AddWithValue("@valor", mTipoProd.GetValor());

                comm.ExecuteNonQuery();
                return "Funcionário cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Erro ao cadastrar!";
            }
        }
        #endregion
    }
}
