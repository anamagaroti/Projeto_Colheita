namespace BBColheitas.Visao
{
    partial class Testes
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
            this.abaCadastro = new System.Windows.Forms.TabPage();
            this.abaPesquisa = new System.Windows.Forms.TabPage();
            this.abaAtualizacao = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.abaPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.abaCadastro);
            this.tabControl1.Controls.Add(this.abaPesquisa);
            this.tabControl1.Controls.Add(this.abaAtualizacao);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 343);
            this.tabControl1.TabIndex = 0;
            // 
            // abaCadastro
            // 
            this.abaCadastro.Location = new System.Drawing.Point(4, 29);
            this.abaCadastro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.abaCadastro.Name = "abaCadastro";
            this.abaCadastro.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.abaCadastro.Size = new System.Drawing.Size(913, 310);
            this.abaCadastro.TabIndex = 0;
            this.abaCadastro.Text = "CADASTRO";
            this.abaCadastro.UseVisualStyleBackColor = true;
            // 
            // abaPesquisa
            // 
            this.abaPesquisa.Controls.Add(this.dataGridView1);
            this.abaPesquisa.Controls.Add(this.maskedTextBox1);
            this.abaPesquisa.Controls.Add(this.button1);
            this.abaPesquisa.Controls.Add(this.groupBox1);
            this.abaPesquisa.Location = new System.Drawing.Point(4, 29);
            this.abaPesquisa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.abaPesquisa.Name = "abaPesquisa";
            this.abaPesquisa.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.abaPesquisa.Size = new System.Drawing.Size(913, 310);
            this.abaPesquisa.TabIndex = 1;
            this.abaPesquisa.Text = "PESQUISA";
            this.abaPesquisa.UseVisualStyleBackColor = true;
            // 
            // abaAtualizacao
            // 
            this.abaAtualizacao.Location = new System.Drawing.Point(4, 33);
            this.abaAtualizacao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.abaAtualizacao.Name = "abaAtualizacao";
            this.abaAtualizacao.Size = new System.Drawing.Size(1227, 489);
            this.abaAtualizacao.TabIndex = 2;
            this.abaAtualizacao.Text = "ATUALIZAÇÃO";
            this.abaAtualizacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Controls.Add(this.rbCPF);
            this.groupBox1.Location = new System.Drawing.Point(22, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PESQUISAR POR:";
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Checked = true;
            this.rbCPF.Location = new System.Drawing.Point(6, 31);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(58, 24);
            this.rbCPF.TabIndex = 0;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(132, 31);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(74, 24);
            this.rbNome.TabIndex = 1;
            this.rbNome.Text = "NOME";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(360, 44);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(333, 26);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 203);
            this.dataGridView1.TabIndex = 4;
            // 
            // Testes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 347);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Testes";
            this.Text = "Testes";
            this.tabControl1.ResumeLayout(false);
            this.abaPesquisa.ResumeLayout(false);
            this.abaPesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage abaCadastro;
        private System.Windows.Forms.TabPage abaPesquisa;
        private System.Windows.Forms.TabPage abaAtualizacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}