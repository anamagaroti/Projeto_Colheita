using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace BBColheitas.Controle
{
    class ConexaoBD
    {
        //string contendo os dados para a conexão ao servidor e BD
        private static string ConnString =
        @"server = PC05_LAB03\SQLEXPRESS; 
        Database = BBColheitas_DB;
        integrated security = true;";//USAR AUTENTICAÇÃO WINDOWS

        //objeto responsável por realizar a conexão com o BD
        private static SqlConnection conn = null;


        //metodo de conexão ao banco de dados
        public SqlConnection Conectar()
        {
            conn = new SqlConnection(ConnString);
            try {                                       
                conn.Open();
                return conn;
            }
            catch (SqlException ex)                   
            {
                conn = null;
                return conn;
            }
        }

        public void Desconectar()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
