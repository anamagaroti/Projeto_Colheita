using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//adicionado para acessar os arquivos em outra pasta:
using BBColheitas.Controle;
using BBColheitas.Visao;


namespace BBColheitas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        //evento do menu Funcionario que exibe o form de cadastro
        private void frmFuncionario(object sender, EventArgs e)
        {
            //criar um objeto da classe VisaoFuncionario
            VisaoFuncionario frm = new VisaoFuncionario();
            frm.ShowDialog();
            
        }












        private void btn_frmFuncionario(object sender, EventArgs e)
        {
            VisaoFuncionario frm = new VisaoFuncionario();
            frm.ShowDialog();
        }

        private void btn_frmTipoProducao(object sender, EventArgs e)
        {
            VisaoTipoProd frm = new VisaoTipoProd();
            frm.ShowDialog();

        }
    }
}
