using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBColheitas.Modelo
{
    class Frequencia
    {
        private int codigo;
        private DateTime data;
        private long cpf_func;
        private int cod_status;

        public int GetCodigo()
        {
            return this.codigo;
        }
        public void SetCodig(int codigo)
        {
            this.codigo = codigo;
        }
        public DateTime GetData()
        {
            return this.data;
        }
        public void SetData(DateTime data)
        {
            this.data = data;
        }
        public long GetCpf_func()
        {
            return this.cpf_func;
        }
        public void SetCpf_func(long cpf_func)
        {
            this.cpf_func = cpf_func;
        }
        public int GetCod_status()
        {
            return this.cod_status;
        }
        public void SetCod_status(int cod_status)
        {
            this.cod_status = cod_status;
        }
    }
}
