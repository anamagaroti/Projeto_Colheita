using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBColheitas.Modelo
{
    class Status
    {
        private int codigo;
        private string status;

        public int GetCodigo()
        {
            return this.codigo;
        }
        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public string GetStatus()
        {
            return this.status;
        }
        public void SetStatus(string status)
        {
            this.status = status;
        }
    }

}
