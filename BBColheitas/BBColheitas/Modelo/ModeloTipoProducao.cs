using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBColheitas.Modelo
{
    class ModeloTipoProducao
    {
        private int codigo;
        private string nome_tipo;
        private decimal valor;

        public int GetCodigo()
        {
            return this.codigo;
        }
        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public string Getnome_tipo()
        {
            return this.nome_tipo;
        }
        public void SetNome_tipo(string nome_tipo)
        {
            this.nome_tipo = nome_tipo;
        }
        public decimal GetValor()
        {
            return this.valor;
        }
        public void SetValor(decimal valor)
        {
            this.valor = valor;
        }
    }
}
