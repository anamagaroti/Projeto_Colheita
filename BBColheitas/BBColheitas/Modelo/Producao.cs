using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBColheitas.Modelo
{
    class Producao
    {
        private int codigo;
        private int quantidade;
        private DateTime data_completa;
        private long cpf_func;
        private int cod_tipo;

        public int GetCodigo()
        {
            return this.codigo;
        }
        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int GetQuantidade()
        {
            return this.quantidade;
        }
        public void Setquantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public DateTime GetData()
        {
            return this.data_completa;
        }
        public void SetData(DateTime data_completa)
        {
            this.data_completa = data_completa;
        }
        public long GetCpf_func()
        {
            return this.cpf_func;
        }
        public void SetCpf_func(long cpf_func)
        {
            this.cpf_func = cpf_func;
        }
        public int GetCodTipo()
        {
            return this.cod_tipo;
        }
        public void SetCodTipo(int cod_tipo)
        {
            this.cod_tipo = cod_tipo;
        }


    }
}
