namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescricaoproduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecoCusto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprecoVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dGVPesquisaProduto = new System.Windows.Forms.DataGridView();
            this.gbPesquisaProduto = new System.Windows.Forms.GroupBox();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbdescricaoProduto = new System.Windows.Forms.RadioButton();
            this.rbcodigo = new System.Windows.Forms.RadioButton();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.codigoproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPesquisaProduto)).BeginInit();
            this.gbPesquisaProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição do Produto";
            // 
            // txtdescricaoproduto
            // 
            this.txtdescricaoproduto.Location = new System.Drawing.Point(20, 132);
            this.txtdescricaoproduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdescricaoproduto.Name = "txtdescricaoproduto";
            this.txtdescricaoproduto.Size = new System.Drawing.Size(212, 22);
            this.txtdescricaoproduto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço de Custo";
            // 
            // txtprecoCusto
            // 
            this.txtprecoCusto.Location = new System.Drawing.Point(20, 189);
            this.txtprecoCusto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtprecoCusto.Name = "txtprecoCusto";
            this.txtprecoCusto.Size = new System.Drawing.Size(99, 22);
            this.txtprecoCusto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço de Venda";
            // 
            // txtprecoVenda
            // 
            this.txtprecoVenda.Location = new System.Drawing.Point(131, 190);
            this.txtprecoVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtprecoVenda.Name = "txtprecoVenda";
            this.txtprecoVenda.Size = new System.Drawing.Size(101, 22);
            this.txtprecoVenda.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 8;
            // 
            // dGVPesquisaProduto
            // 
            this.dGVPesquisaProduto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVPesquisaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPesquisaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproduto,
            this.codigopeca,
            this.nomeproduto,
            this.categoria,
            this.descricao,
            this.estoque,
            this.valorunit});
            this.dGVPesquisaProduto.Location = new System.Drawing.Point(8, 110);
            this.dGVPesquisaProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dGVPesquisaProduto.Name = "dGVPesquisaProduto";
            this.dGVPesquisaProduto.Size = new System.Drawing.Size(531, 138);
            this.dGVPesquisaProduto.TabIndex = 11;
            // 
            // gbPesquisaProduto
            // 
            this.gbPesquisaProduto.Controls.Add(this.btnPesquisaProduto);
            this.gbPesquisaProduto.Controls.Add(this.txtPesquisaProduto);
            this.gbPesquisaProduto.Controls.Add(this.label7);
            this.gbPesquisaProduto.Controls.Add(this.label6);
            this.gbPesquisaProduto.Controls.Add(this.rbdescricaoProduto);
            this.gbPesquisaProduto.Controls.Add(this.dGVPesquisaProduto);
            this.gbPesquisaProduto.Controls.Add(this.rbcodigo);
            this.gbPesquisaProduto.Location = new System.Drawing.Point(19, 223);
            this.gbPesquisaProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPesquisaProduto.Name = "gbPesquisaProduto";
            this.gbPesquisaProduto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPesquisaProduto.Size = new System.Drawing.Size(547, 254);
            this.gbPesquisaProduto.TabIndex = 12;
            this.gbPesquisaProduto.TabStop = false;
            this.gbPesquisaProduto.Text = "Pesquisar Produto";
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.Location = new System.Drawing.Point(432, 41);
            this.btnPesquisaProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(97, 25);
            this.btnPesquisaProduto.TabIndex = 5;
            this.btnPesquisaProduto.Text = "Pesquisar";
            this.btnPesquisaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.btnPesquisaProduto_Click);
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(176, 44);
            this.txtPesquisaProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(235, 22);
            this.txtPesquisaProduto.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "Escolha uma opção de Pesquisa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 2;
            // 
            // rbdescricaoProduto
            // 
            this.rbdescricaoProduto.AutoSize = true;
            this.rbdescricaoProduto.Location = new System.Drawing.Point(23, 61);
            this.rbdescricaoProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbdescricaoProduto.Name = "rbdescricaoProduto";
            this.rbdescricaoProduto.Size = new System.Drawing.Size(85, 18);
            this.rbdescricaoProduto.TabIndex = 1;
            this.rbdescricaoProduto.TabStop = true;
            this.rbdescricaoProduto.Text = "Descrição";
            this.rbdescricaoProduto.UseVisualStyleBackColor = true;
            // 
            // rbcodigo
            // 
            this.rbcodigo.AutoSize = true;
            this.rbcodigo.Location = new System.Drawing.Point(23, 34);
            this.rbcodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbcodigo.Name = "rbcodigo";
            this.rbcodigo.Size = new System.Drawing.Size(69, 18);
            this.rbcodigo.TabIndex = 0;
            this.rbcodigo.TabStop = true;
            this.rbcodigo.Text = "Código";
            this.rbcodigo.UseVisualStyleBackColor = true;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(20, 68);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(177, 22);
            this.txtNomeProduto.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Produto";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(210, 68);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(177, 22);
            this.txtCategoria.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categoria";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(280, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "Lista de Pecas";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(439, 120);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 97);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 14);
            this.label10.TabIndex = 24;
            this.label10.Text = "Pecas Add";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // codigoproduto
            // 
            this.codigoproduto.DataPropertyName = "PROD_ID";
            this.codigoproduto.HeaderText = "Código Produto";
            this.codigoproduto.Name = "codigoproduto";
            // 
            // codigopeca
            // 
            this.codigopeca.DataPropertyName = "PEC_ID";
            this.codigopeca.HeaderText = "Código Peça";
            this.codigopeca.Name = "codigopeca";
            // 
            // nomeproduto
            // 
            this.nomeproduto.DataPropertyName = "PROD_NOME";
            this.nomeproduto.HeaderText = "Nome ";
            this.nomeproduto.Name = "nomeproduto";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "PROD_CATEGORIA";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "PROD_DESCRICAO";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // estoque
            // 
            this.estoque.DataPropertyName = "PROD_ESTOQUE";
            this.estoque.HeaderText = "Estoque";
            this.estoque.Name = "estoque";
            // 
            // valorunit
            // 
            this.valorunit.DataPropertyName = "PROD_VLUNIT";
            this.valorunit.HeaderText = "Valor Unitário";
            this.valorunit.Name = "valorunit";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbPesquisaProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprecoVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprecoCusto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdescricaoproduto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmProduto";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtdescricaoproduto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtprecoCusto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtprecoVenda, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.gbPesquisaProduto, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtNomeProduto, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCategoria, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.listView2, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPesquisaProduto)).EndInit();
            this.gbPesquisaProduto.ResumeLayout(false);
            this.gbPesquisaProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescricaoproduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecoCusto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprecoVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVPesquisaProduto;
        private System.Windows.Forms.GroupBox gbPesquisaProduto;
        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbdescricaoProduto;
        private System.Windows.Forms.RadioButton rbcodigo;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorunit;

        public System.EventHandler txtPesquisaProduto_TextChanged { get; set; }
    }
}