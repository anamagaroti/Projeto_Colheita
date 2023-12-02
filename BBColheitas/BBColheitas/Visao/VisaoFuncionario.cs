using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BBColheitas.Modelo;
using BBColheitas.Controle;
using System.Data.SqlClient;

namespace BBColheitas.Visao
{
    public partial class VisaoFuncionario : Form
    {
        public VisaoFuncionario()
        {
            InitializeComponent();
            maskPesquisa.Mask = "000,000,000-00";
        }
        //objetos de acesso as classes de Modelo e Controle
        ModeloFuncionario mFuncionario = new ModeloFuncionario();
        ControleFuncionario cFuncionario = new ControleFuncionario();

        //-----------INICIO EVENTOS --------------------------//
        #region EVENTOS

        private void Cadastrar(object sender, EventArgs e)
        {
            //enviar os dados do Form para os atributos (Modelo)
            mFuncionario.SetCpf_func(long.Parse(maskCPF_cad.Text));
            mFuncionario.SetNome(txbNome_cad.Text);
            mFuncionario.SetApelido(txbApelido_cad.Text);
            mFuncionario.SetTelefone(maskTel_cad.Text);

            //executa o método de cadastro e salva o resultado em res
            string res = cFuncionario.CadastraFuncionario(mFuncionario);

            //exibe mensagem retornada pelo método de cadastro
            MessageBox.Show(res);
        }

        private void PesquisaFunc(object sender, EventArgs e)
        {
            //remover as linhas da dataGridView
            dataGridView1.Rows.Clear();
            
            //verifica qual parâmetro o usuário selecionou
            if (rbCPF.Checked)
            {
                if (!String.IsNullOrEmpty(maskPesquisa.Text))
                {
                    mFuncionario.SetCpf_func(long.Parse(maskPesquisa.Text));
                    mFuncionario.SetNome(maskPesquisa.Text);
                    ConsultaFunc();
                }
                else
                {
                    MessageBox.Show("O campo está em branco!");
                }
            }


            if(rbNome.Checked)
            {
                if (!String.IsNullOrEmpty(maskPesquisa.Text))
                {
                    mFuncionario.SetNome(maskPesquisa.Text + "%");
                    ConsultaFunc();
                }
                else
                {
                    MessageBox.Show("O campo está em branco!");
                }
            }           
        }

        private void rbCPF_Click(object sender, EventArgs e)
        {
            maskPesquisa.Mask = "000,000,000-00";            
        }

        private void rbNome_click(object sender, EventArgs e)
        {
            maskPesquisa.Mask = null;            
        }

        private void CarregaUpdate(object sender, DataGridViewCellEventArgs e)
        {
            //DialogResult -> tipo de dado usado pra armazenar o botão clicado
            //em uma MessageBox
            DialogResult botao;

            /*
            MessageBox.Show("texto do cabeçalho", "texto da msg", 
                MessageBoxButtons.tipo_botao, MessageBoxIcon.tipo_icone);
            */
            botao  = MessageBox.Show("Atualizar registo?", "Deseja atualizar este cadastro?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //comando que carrega os dados da grid para a aba de atualização
            if(botao == DialogResult.Yes)
            {
                //comando que lê o valor de uma coluna da DataGridView
                //campo.text     = nomeGrid.linhaSelecionada.Coluna[n].Value.ToString();
                maskCPF_atu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txbNome_atu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txbApelido_atu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                maskTel_atu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                //mudar o foco do form para a aba de atualização
                

            }   


        }
        #endregion

        private void atualizaFuncionario(object sender, EventArgs e)
        {
            //enviar os dados do Form para os atributos (Modelo)
            mFuncionario.SetCpf_func(long.Parse(maskCPF_atu.Text));
            mFuncionario.SetNome(txbNome_atu.Text);
            mFuncionario.SetApelido(txbApelido_atu.Text);
            mFuncionario.SetTelefone(maskTel_atu.Text);

            //executa o método de cadastro e salva o resultado em res
            string res = cFuncionario.AtualizaFuncionario(mFuncionario);

            //exibe mensagem retornada pelo método de cadastro
            MessageBox.Show(res);
        }


        #region METODOS

        private void ConsultaFunc()
        {
            // executa o metodo de consulta e armazena os dados no SqlDataReader
            SqlDataReader dados = cFuncionario.PesquisaFuncionario(mFuncionario);

            //preencher os dados na DataGridView
            dataGridView1.Columns.Clear();
            //contar a quant. de colunas do comando SELECT 
            int col = dados.FieldCount;

            //define o número de colunas da DataGrid igual a consulta do banco
            dataGridView1.ColumnCount = col;

            //define o nome do cabeçalho de cada coluna
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "NOME";
            dataGridView1.Columns[2].Name = "APELIDO";
            dataGridView1.Columns[3].Name = "TELEFONE";

            //armazenar 1 registro da consulta que será exibido na Grid
            string[] linha = new string[col];

            //percorre os registros da consulta 
            while (dados.Read())
            {
                for (int i = 0; i < col; i++)
                {
                    linha[i] = dados.GetValue(i).ToString();
                }
                dataGridView1.Rows.Add(linha);
            }
        }


        #endregion

    }
}
