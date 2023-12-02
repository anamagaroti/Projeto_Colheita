using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BBColheitas.Modelo
{
    class ModeloFuncionario
    {
        private long cpf_func;
        private string nome;
        private string apelido;
        private string telefone;

        #region ENCAPSULAMENTO
        public long GetCpf_func()
        {
            return this.cpf_func;
        }
        public void SetCpf_func(long cpf_func)
        {
            this.cpf_func = cpf_func;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetApelido()
        {
            return this.apelido;
        }
        public void SetApelido(string apelido)
        {
            this.apelido = apelido;
        }
        public string GetTelefone()
        {
            return this.telefone;
        }
        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        #endregion
    }
}
