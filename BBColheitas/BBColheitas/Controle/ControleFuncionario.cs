using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BBColheitas.Modelo;
using System.Data.SqlClient;

namespace BBColheitas.Controle
{
    class ControleFuncionario
    {
        
        #region CADASTRO
        public string CadastraFuncionario(ModeloFuncionario mFunc)
        {
            string sql = "insert into funcionario(cpf, nome, apelido, telefone) " +
                "values(@cpf, @nome, @apelido,@telefone); ";

            ConexaoBD con = new ConexaoBD();
            SqlConnection conn = con.Conectar();
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpf", mFunc.GetCpf_func());
                comm.Parameters.AddWithValue("@nome", mFunc.GetNome());
                comm.Parameters.AddWithValue("@apelido", mFunc.GetApelido());
                comm.Parameters.AddWithValue("@telefone", mFunc.GetTelefone());

                comm.ExecuteNonQuery();
                return "Funcionário cadastrado com sucesso!";
            }
            catch(SqlException ex)
            {
                return "Erro ao cadastrar!";
            }
        }
        #endregion

        #region PESQUISA
        public SqlDataReader PesquisaFuncionario(ModeloFuncionario mFunc)
        {
            string sql = "select * from funcionario where cpf = @cpf or nome like @nome";
            
            //armazena o resultado da consulta SQL
            SqlDataReader dados;

            ConexaoBD con = new ConexaoBD();
            SqlConnection conn = con.Conectar();
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpf", mFunc.GetCpf_func());
                comm.Parameters.AddWithValue("@nome", mFunc.GetNome());
                
                dados = comm.ExecuteReader();
                
                return dados;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
        #endregion

        #region ATUALIZACAO
        public string AtualizaFuncionario(ModeloFuncionario mFunc)
        {
            string sql = "update funcionario set nome= @nome, apelido = @apelido, " +
                "telefone = @telefone where cpf = @cpf; ";

            ConexaoBD con = new ConexaoBD();
            SqlConnection conn = con.Conectar();
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpf", mFunc.GetCpf_func());
                comm.Parameters.AddWithValue("@nome", mFunc.GetNome());
                comm.Parameters.AddWithValue("@apelido", mFunc.GetApelido());
                comm.Parameters.AddWithValue("@telefone", mFunc.GetTelefone());

                comm.ExecuteNonQuery();
                return "Funcionário atualizado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Erro ao atualizar!";
            }
        }
        #endregion
    }
}
