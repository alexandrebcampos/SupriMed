namespace ProjetoSupriMed.DesktopAPP
{
    partial class ConsultaVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.GBTipo = new System.Windows.Forms.GroupBox();
            this.RBProduto = new System.Windows.Forms.RadioButton();
            this.RBVendedor = new System.Windows.Forms.RadioButton();
            this.RBCliente = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.DataGridPesquisa = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(434, 24);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(86, 32);
            this.btPesquisar.TabIndex = 0;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // GBTipo
            // 
            this.GBTipo.Controls.Add(this.RBProduto);
            this.GBTipo.Controls.Add(this.RBVendedor);
            this.GBTipo.Controls.Add(this.RBCliente);
            this.GBTipo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTipo.Location = new System.Drawing.Point(12, 12);
            this.GBTipo.Name = "GBTipo";
            this.GBTipo.Size = new System.Drawing.Size(158, 102);
            this.GBTipo.TabIndex = 1;
            this.GBTipo.TabStop = false;
            this.GBTipo.Text = "Tipo de Pesquisa:";
            // 
            // RBProduto
            // 
            this.RBProduto.AutoSize = true;
            this.RBProduto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBProduto.Location = new System.Drawing.Point(11, 69);
            this.RBProduto.Name = "RBProduto";
            this.RBProduto.Size = new System.Drawing.Size(75, 18);
            this.RBProduto.TabIndex = 4;
            this.RBProduto.Text = "Produto";
            this.RBProduto.UseVisualStyleBackColor = true;
            // 
            // RBVendedor
            // 
            this.RBVendedor.AutoSize = true;
            this.RBVendedor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBVendedor.Location = new System.Drawing.Point(11, 45);
            this.RBVendedor.Name = "RBVendedor";
            this.RBVendedor.Size = new System.Drawing.Size(85, 18);
            this.RBVendedor.TabIndex = 3;
            this.RBVendedor.Text = "Vendedor";
            this.RBVendedor.UseVisualStyleBackColor = true;
            // 
            // RBCliente
            // 
            this.RBCliente.AutoSize = true;
            this.RBCliente.Checked = true;
            this.RBCliente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCliente.Location = new System.Drawing.Point(11, 21);
            this.RBCliente.Name = "RBCliente";
            this.RBCliente.Size = new System.Drawing.Size(69, 18);
            this.RBCliente.TabIndex = 2;
            this.RBCliente.TabStop = true;
            this.RBCliente.Text = "Cliente";
            this.RBCliente.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(176, 31);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // DataGridPesquisa
            // 
            this.DataGridPesquisa.AllowUserToAddRows = false;
            this.DataGridPesquisa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DataGridPesquisa.Location = new System.Drawing.Point(12, 120);
            this.DataGridPesquisa.Name = "DataGridPesquisa";
            this.DataGridPesquisa.ReadOnly = true;
            this.DataGridPesquisa.Size = new System.Drawing.Size(578, 218);
            this.DataGridPesquisa.TabIndex = 4;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "FUNC_NOME";
            this.Column9.HeaderText = "Vendedor";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CLI_PRIMNOME";
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PROD_NOME";
            this.Column2.HeaderText = "Produto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VENDA_ITENS_QTO";
            this.Column3.HeaderText = "Qnto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "VENDA_ITENS_TOTAL";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Valor Itens";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "VENDA_ITENS_VLUNIT";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Valor Unit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "VEN_DTEMISSAO";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Emitido Em";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "VEN_DESCONTO";
            dataGridViewCellStyle5.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "%";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 30;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "VEN_VALORPAGO";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column8.HeaderText = "Valor Pago";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // ConsultaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 346);
            this.Controls.Add(this.DataGridPesquisa);
            this.Controls.Add(this.GBTipo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btPesquisar);
            this.MaximizeBox = false;
            this.Name = "ConsultaVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaVendas";
            this.Load += new System.EventHandler(this.ConsultaVendas_Load);
            this.GBTipo.ResumeLayout(false);
            this.GBTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox GBTipo;
        private System.Windows.Forms.RadioButton RBProduto;
        private System.Windows.Forms.RadioButton RBVendedor;
        private System.Windows.Forms.RadioButton RBCliente;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView DataGridPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        //public System.Windows.Forms.ToolStripButton btnNovo;
        //public System.Windows.Forms.ToolStripButton btnSalvar;
        //public System.Windows.Forms.ToolStripButton btnDeletar;
        //public System.Windows.Forms.ToolStripButton btnVoltar;

        public System.Windows.Forms.StatusStrip statusStrip1 { get; set; }

        public System.Windows.Forms.ToolStripButton btnVoltar { get; set; }

        public System.Windows.Forms.ToolStripButton btnDeletar { get; set; }

        public System.Windows.Forms.ToolStripButton btnNovo { get; set; }

        public System.Windows.Forms.ToolStripButton btnSalvar { get; set; }
    }
}