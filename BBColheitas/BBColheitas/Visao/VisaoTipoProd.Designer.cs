namespace BBColheitas.Visao
{
    partial class VisaoTipoProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AbaCadastro = new System.Windows.Forms.TabPage();
            this.txbValor = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar_cad = new System.Windows.Forms.Button();
            this.btnLimpar_cad = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AbaPesquisa = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.AbaAtualizacao = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCod_atu = new System.Windows.Forms.TextBox();
            this.txbValor_atu = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTipo_atu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar_atu = new System.Windows.Forms.Button();
            this.btnLimpar_atu = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AbaCadastro.SuspendLayout();
            this.AbaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AbaAtualizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AbaCadastro);
            this.tabControl1.Controls.Add(this.AbaPesquisa);
            this.tabControl1.Controls.Add(this.AbaAtualizacao);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 388);
            this.tabControl1.TabIndex = 1;
            // 
            // AbaCadastro
            // 
            this.AbaCadastro.Controls.Add(this.txbValor);
            this.AbaCadastro.Controls.Add(this.btnCancelar_cad);
            this.AbaCadastro.Controls.Add(this.btnLimpar_cad);
            this.AbaCadastro.Controls.Add(this.btnCadastro);
            this.AbaCadastro.Controls.Add(this.label1);
            this.AbaCadastro.Controls.Add(this.txbNome);
            this.AbaCadastro.Controls.Add(this.label2);
            this.AbaCadastro.Location = new System.Drawing.Point(4, 29);
            this.AbaCadastro.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AbaCadastro.Name = "AbaCadastro";
            this.AbaCadastro.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AbaCadastro.Size = new System.Drawing.Size(732, 355);
            this.AbaCadastro.TabIndex = 0;
            this.AbaCadastro.Text = "CADASTRO";
            this.AbaCadastro.UseVisualStyleBackColor = true;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(509, 22);
            this.txbValor.Mask = "00.00";
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(178, 26);
            this.txbValor.TabIndex = 29;
            // 
            // btnCancelar_cad
            // 
            this.btnCancelar_cad.Location = new System.Drawing.Point(510, 108);
            this.btnCancelar_cad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar_cad.Name = "btnCancelar_cad";
            this.btnCancelar_cad.Size = new System.Drawing.Size(178, 60);
            this.btnCancelar_cad.TabIndex = 28;
            this.btnCancelar_cad.Text = "CANCELAR";
            this.btnCancelar_cad.UseVisualStyleBackColor = true;
            // 
            // btnLimpar_cad
            // 
            this.btnLimpar_cad.Location = new System.Drawing.Point(264, 108);
            this.btnLimpar_cad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar_cad.Name = "btnLimpar_cad";
            this.btnLimpar_cad.Size = new System.Drawing.Size(178, 60);
            this.btnLimpar_cad.TabIndex = 27;
            this.btnLimpar_cad.Text = "LIMPAR";
            this.btnLimpar_cad.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(30, 108);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(178, 60);
            this.btnCadastro.TabIndex = 26;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.cadastraTipoProd);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "VALOR";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(168, 22);
            this.txbNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(244, 26);
            this.txbNome.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "TIPO DE FRUTA";
            // 
            // AbaPesquisa
            // 
            this.AbaPesquisa.Controls.Add(this.label3);
            this.AbaPesquisa.Controls.Add(this.dataGridView1);
            this.AbaPesquisa.Controls.Add(this.maskPesquisa);
            this.AbaPesquisa.Controls.Add(this.btnPesquisar);
            this.AbaPesquisa.Location = new System.Drawing.Point(4, 29);
            this.AbaPesquisa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AbaPesquisa.Name = "AbaPesquisa";
            this.AbaPesquisa.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AbaPesquisa.Size = new System.Drawing.Size(732, 355);
            this.AbaPesquisa.TabIndex = 1;
            this.AbaPesquisa.Text = "PESQUISA";
            this.AbaPesquisa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TIPO DE FRUTA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 191);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carregaAtualizacao);
            // 
            // maskPesquisa
            // 
            this.maskPesquisa.Location = new System.Drawing.Point(161, 37);
            this.maskPesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskPesquisa.Name = "maskPesquisa";
            this.maskPesquisa.Size = new System.Drawing.Size(323, 26);
            this.maskPesquisa.TabIndex = 4;
            this.maskPesquisa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(492, 28);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(204, 44);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.pesquisaTipoProd);
            // 
            // AbaAtualizacao
            // 
            this.AbaAtualizacao.Controls.Add(this.label6);
            this.AbaAtualizacao.Controls.Add(this.txbCod_atu);
            this.AbaAtualizacao.Controls.Add(this.txbValor_atu);
            this.AbaAtualizacao.Controls.Add(this.label4);
            this.AbaAtualizacao.Controls.Add(this.txbTipo_atu);
            this.AbaAtualizacao.Controls.Add(this.label5);
            this.AbaAtualizacao.Controls.Add(this.btnCancelar_atu);
            this.AbaAtualizacao.Controls.Add(this.btnLimpar_atu);
            this.AbaAtualizacao.Controls.Add(this.btnAtualizar);
            this.AbaAtualizacao.Location = new System.Drawing.Point(4, 29);
            this.AbaAtualizacao.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AbaAtualizacao.Name = "AbaAtualizacao";
            this.AbaAtualizacao.Size = new System.Drawing.Size(732, 355);
            this.AbaAtualizacao.TabIndex = 2;
            this.AbaAtualizacao.Text = "ATUALIZAÇÃO";
            this.AbaAtualizacao.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "CODIGO";
            // 
            // txbCod_atu
            // 
            this.txbCod_atu.Enabled = false;
            this.txbCod_atu.Location = new System.Drawing.Point(132, 21);
            this.txbCod_atu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCod_atu.Name = "txbCod_atu";
            this.txbCod_atu.Size = new System.Drawing.Size(67, 26);
            this.txbCod_atu.TabIndex = 34;
            // 
            // txbValor_atu
            // 
            this.txbValor_atu.Location = new System.Drawing.Point(513, 75);
            this.txbValor_atu.Mask = "00.00";
            this.txbValor_atu.Name = "txbValor_atu";
            this.txbValor_atu.Size = new System.Drawing.Size(167, 26);
            this.txbValor_atu.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "VALOR";
            // 
            // txbTipo_atu
            // 
            this.txbTipo_atu.Location = new System.Drawing.Point(171, 72);
            this.txbTipo_atu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTipo_atu.Name = "txbTipo_atu";
            this.txbTipo_atu.Size = new System.Drawing.Size(233, 26);
            this.txbTipo_atu.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "TIPO DE FRUTA";
            // 
            // btnCancelar_atu
            // 
            this.btnCancelar_atu.Location = new System.Drawing.Point(502, 163);
            this.btnCancelar_atu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar_atu.Name = "btnCancelar_atu";
            this.btnCancelar_atu.Size = new System.Drawing.Size(178, 60);
            this.btnCancelar_atu.TabIndex = 21;
            this.btnCancelar_atu.Text = "CANCELAR";
            this.btnCancelar_atu.UseVisualStyleBackColor = true;
            // 
            // btnLimpar_atu
            // 
            this.btnLimpar_atu.Location = new System.Drawing.Point(252, 163);
            this.btnLimpar_atu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar_atu.Name = "btnLimpar_atu";
            this.btnLimpar_atu.Size = new System.Drawing.Size(178, 60);
            this.btnLimpar_atu.TabIndex = 20;
            this.btnLimpar_atu.Text = "LIMPAR";
            this.btnLimpar_atu.UseVisualStyleBackColor = true;
            this.btnLimpar_atu.Click += new System.EventHandler(this.btnLimpar_atu_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(21, 163);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(178, 60);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.atualizaTipo);
            // 
            // VisaoTipoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 392);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VisaoTipoProd";
            this.Text = "VisaoTipoProd";
            this.tabControl1.ResumeLayout(false);
            this.AbaCadastro.ResumeLayout(false);
            this.AbaCadastro.PerformLayout();
            this.AbaPesquisa.ResumeLayout(false);
            this.AbaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AbaAtualizacao.ResumeLayout(false);
            this.AbaAtualizacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AbaCadastro;
        private System.Windows.Forms.Button btnCancelar_cad;
        private System.Windows.Forms.Button btnLimpar_cad;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage AbaPesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabPage AbaAtualizacao;
        private System.Windows.Forms.Button btnCancelar_atu;
        private System.Windows.Forms.Button btnLimpar_atu;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txbValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCod_atu;
        private System.Windows.Forms.MaskedTextBox txbValor_atu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTipo_atu;
        private System.Windows.Forms.Label label5;
    }
}