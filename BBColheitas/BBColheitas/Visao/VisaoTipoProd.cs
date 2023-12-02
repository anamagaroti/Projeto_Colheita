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
    public partial class VisaoTipoProd : Form
    {
        public VisaoTipoProd()
        {
            InitializeComponent();
        }

        ModeloTipoProducao mTipoProd = new ModeloTipoProducao();
        ControleTipoProducao cTipoProd = new ControleTipoProducao();


        private void cadastraTipoProd(object sender, EventArgs e)
        {
            mTipoProd.SetNome_tipo(txbNome.Text);
            mTipoProd.SetValor(decimal.Parse(txbValor.Text));

            string res = cTipoProd.CadastraTipoProducao(mTipoProd);

            MessageBox.Show(res);
        }

        private void pesquisaTipoProd(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            mTipoProd.SetNome_tipo(maskPesquisa.Text+"%");

            ConsultaTipoProd();
        }




        //---------------------------MÉTODOS------------------------------//
        private void ConsultaTipoProd()
        {
            // executa o metodo de consulta e armazena os dados no SqlDataReader
            SqlDataReader dados = cTipoProd.PesquisaTipoProducao(mTipoProd);

            //preencher os dados na DataGridView
            dataGridView1.Columns.Clear();
            //contar a quant. de colunas do comando SELECT 
            int col = dados.FieldCount;

            //define o número de colunas da DataGrid igual a consulta do banco
            dataGridView1.ColumnCount = col;

            //define o nome do cabeçalho de cada coluna
            dataGridView1.Columns[0].Name = "TIPO DE FRUTA";
            dataGridView1.Columns[1].Name = "VALOR";
            
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

        private void carregaAtualizacao(object sender, DataGridViewCellEventArgs e)
        {
            
            DialogResult botao;

           
            botao = MessageBox.Show("Atualizar registo?", "Deseja atualizar este cadastro?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (botao == DialogResult.Yes)
            {
                txbCod_atu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txbTipo_atu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txbValor_atu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                tabControl1.SelectedTab = AbaAtualizacao;
            }

        }

        private void btnLimpar_atu_Click(object sender, EventArgs e)
        {

        }

        private void atualizaTipo(object sender, EventArgs e)
        {
            //enviar os dados do Form para os atributos (Modelo)
            mTipoProd.SetCodigo(int.Parse(txbCod_atu.Text));
            mTipoProd.SetNome_tipo(txbTipo_atu.Text);
            mTipoProd.SetValor(decimal.Parse(txbValor_atu.Text));

            //executa o método de cadastro e salva o resultado em res
            string res = cTipoProd.AtualizaTipoProducao(mTipoProd); 

            //exibe mensagem retornada pelo método de cadastro
            MessageBox.Show(res);
        }
    }
}
