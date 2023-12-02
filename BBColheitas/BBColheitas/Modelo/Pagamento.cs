using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBColheitas.Modelo
{
    class Pagamento
    {
        #region ATRIBUTOS

        private int codigo;
        private int total_producao;
        private decimal valor_total;
        private DateTime data_pgto;
        private long cpf_func;

        #endregion

        #region ENCAP CODIGO
        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        #endregion

        #region ENCAP TOTAL_PROD
        public int getTotal_prod()

        {
            return this.total_producao;
        }
        public void SetTotal_prod(int total_producao)
        {
            this.total_producao = total_producao;
        }
        #endregion

        #region ENCAP VALOR_TOTAL
        public decimal GetValor_total()
        {
            return this.valor_total;
        }
        public void SetValor_total(decimal valor_total)
        {
            this.valor_total = valor_total;
        }
        #endregion

        #region ENCAP DATA_PGTO
        public DateTime GetData_pgto()
        {
            return this.data_pgto;
        }
        public void SetData_pgto(DateTime data_pgto)
        {
            this.data_pgto = data_pgto;
        }
        #endregion

        #region ENCAP CPF_FUNC
        public long GetCpf_func()
        {
            return this.cpf_func;
        }
        public void SetCpf_func(long cpf_func)
        {
            this.cpf_func = cpf_func;
        }
        #endregion        

    }

}
