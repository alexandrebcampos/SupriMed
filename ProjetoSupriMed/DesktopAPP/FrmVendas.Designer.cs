namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmVendas
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
            this.gBNovaVenda = new System.Windows.Forms.GroupBox();
            this.btnDetalhe = new System.Windows.Forms.Button();
            this.lbVendedor = new System.Windows.Forms.Label();
            this.cBCodVendedorVenda = new System.Windows.Forms.ComboBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.txtValorPagoVenda = new System.Windows.Forms.TextBox();
            this.btnFinalizaPedido = new System.Windows.Forms.Button();
            this.lbValorPago = new System.Windows.Forms.Label();
            this.txtDescontoVenda = new System.Windows.Forms.TextBox();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lbValorVend = new System.Windows.Forms.Label();
            this.dTPDataEmissaoVenda = new System.Windows.Forms.DateTimePicker();
            this.lbDataEmissao = new System.Windows.Forms.Label();
            this.dGVendasItens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.txtValorUnitItem = new System.Windows.Forms.TextBox();
            this.lbValorUnit = new System.Windows.Forms.Label();
            this.txtQuantidadeItem = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.cBProdutoItem = new System.Windows.Forms.ComboBox();
            this.lbCodVenda = new System.Windows.Forms.Label();
            this.cBClienteVenda = new System.Windows.Forms.ComboBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.gBNovaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVendasItens)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBNovaVenda
            // 
            this.gBNovaVenda.Controls.Add(this.btnDetalhe);
            this.gBNovaVenda.Controls.Add(this.lbVendedor);
            this.gBNovaVenda.Controls.Add(this.cBCodVendedorVenda);
            this.gBNovaVenda.Controls.Add(this.lbTotal);
            this.gBNovaVenda.Controls.Add(this.lbProduto);
            this.gBNovaVenda.Controls.Add(this.txtCodItem);
            this.gBNovaVenda.Controls.Add(this.txtTotal);
            this.gBNovaVenda.Controls.Add(this.btnFinalizarVenda);
            this.gBNovaVenda.Controls.Add(this.txtValorPagoVenda);
            this.gBNovaVenda.Controls.Add(this.btnFinalizaPedido);
            this.gBNovaVenda.Controls.Add(this.lbValorPago);
            this.gBNovaVenda.Controls.Add(this.txtDescontoVenda);
            this.gBNovaVenda.Controls.Add(this.lbDesconto);
            this.gBNovaVenda.Controls.Add(this.txtValorVenda);
            this.gBNovaVenda.Controls.Add(this.lbValorVend);
            this.gBNovaVenda.Controls.Add(this.dTPDataEmissaoVenda);
            this.gBNovaVenda.Controls.Add(this.lbDataEmissao);
            this.gBNovaVenda.Controls.Add(this.dGVendasItens);
            this.gBNovaVenda.Controls.Add(this.btnNovoItem);
            this.gBNovaVenda.Controls.Add(this.txtValorUnitItem);
            this.gBNovaVenda.Controls.Add(this.lbValorUnit);
            this.gBNovaVenda.Controls.Add(this.txtQuantidadeItem);
            this.gBNovaVenda.Controls.Add(this.lbQuantidade);
            this.gBNovaVenda.Controls.Add(this.cBProdutoItem);
            this.gBNovaVenda.Controls.Add(this.lbCodVenda);
            this.gBNovaVenda.Enabled = false;
            this.gBNovaVenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBNovaVenda.Location = new System.Drawing.Point(12, 68);
            this.gBNovaVenda.Name = "gBNovaVenda";
            this.gBNovaVenda.Size = new System.Drawing.Size(462, 477);
            this.gBNovaVenda.TabIndex = 0;
            this.gBNovaVenda.TabStop = false;
            this.gBNovaVenda.Text = "Nova Venda";
            // 
            // btnDetalhe
            // 
            this.btnDetalhe.Enabled = false;
            this.btnDetalhe.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhe.Location = new System.Drawing.Point(306, 439);
            this.btnDetalhe.Name = "btnDetalhe";
            this.btnDetalhe.Size = new System.Drawing.Size(120, 23);
            this.btnDetalhe.TabIndex = 32;
            this.btnDetalhe.Text = "Detalhes";
            this.btnDetalhe.UseVisualStyleBackColor = true;
            this.btnDetalhe.Click += new System.EventHandler(this.btnDetalhe_Click);
            // 
            // lbVendedor
            // 
            this.lbVendedor.AutoSize = true;
            this.lbVendedor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendedor.Location = new System.Drawing.Point(25, 55);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(75, 16);
            this.lbVendedor.TabIndex = 31;
            this.lbVendedor.Text = "Vendedor:";
            // 
            // cBCodVendedorVenda
            // 
            this.cBCodVendedorVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCodVendedorVenda.FormattingEnabled = true;
            this.cBCodVendedorVenda.Location = new System.Drawing.Point(110, 52);
            this.cBCodVendedorVenda.Name = "cBCodVendedorVenda";
            this.cBCodVendedorVenda.Size = new System.Drawing.Size(177, 24);
            this.cBCodVendedorVenda.TabIndex = 30;
            this.cBCodVendedorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBCodVendedorVenda_KeyPress);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(175, 146);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(78, 16);
            this.lbTotal.TabIndex = 29;
            this.lbTotal.Text = "TOTAL R$:";
            this.lbTotal.Visible = false;
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.Location = new System.Drawing.Point(35, 87);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(65, 16);
            this.lbProduto.TabIndex = 28;
            this.lbProduto.Text = "Produto:";
            // 
            // txtCodItem
            // 
            this.txtCodItem.Enabled = false;
            this.txtCodItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodItem.Location = new System.Drawing.Point(110, 20);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.Size = new System.Drawing.Size(59, 23);
            this.txtCodItem.TabIndex = 27;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(253, 143);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(61, 23);
            this.txtTotal.TabIndex = 25;
            this.txtTotal.Visible = false;
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Enabled = false;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(306, 410);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(120, 23);
            this.btnFinalizarVenda.TabIndex = 7;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // txtValorPagoVenda
            // 
            this.txtValorPagoVenda.Enabled = false;
            this.txtValorPagoVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagoVenda.Location = new System.Drawing.Point(110, 438);
            this.txtValorPagoVenda.Name = "txtValorPagoVenda";
            this.txtValorPagoVenda.Size = new System.Drawing.Size(59, 23);
            this.txtValorPagoVenda.TabIndex = 21;
            this.txtValorPagoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagoVenda_KeyPress);
            // 
            // btnFinalizaPedido
            // 
            this.btnFinalizaPedido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizaPedido.Location = new System.Drawing.Point(306, 380);
            this.btnFinalizaPedido.Name = "btnFinalizaPedido";
            this.btnFinalizaPedido.Size = new System.Drawing.Size(120, 23);
            this.btnFinalizaPedido.TabIndex = 6;
            this.btnFinalizaPedido.Text = "Finalizar Pedido";
            this.btnFinalizaPedido.UseVisualStyleBackColor = true;
            this.btnFinalizaPedido.Click += new System.EventHandler(this.btnFinalizaPedido_Click);
            // 
            // lbValorPago
            // 
            this.lbValorPago.AutoSize = true;
            this.lbValorPago.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorPago.Location = new System.Drawing.Point(29, 441);
            this.lbValorPago.Name = "lbValorPago";
            this.lbValorPago.Size = new System.Drawing.Size(67, 16);
            this.lbValorPago.TabIndex = 22;
            this.lbValorPago.Text = "Pago R$:";
            // 
            // txtDescontoVenda
            // 
            this.txtDescontoVenda.Enabled = false;
            this.txtDescontoVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoVenda.Location = new System.Drawing.Point(110, 409);
            this.txtDescontoVenda.Name = "txtDescontoVenda";
            this.txtDescontoVenda.Size = new System.Drawing.Size(59, 23);
            this.txtDescontoVenda.TabIndex = 18;
            this.txtDescontoVenda.TextChanged += new System.EventHandler(this.txtDescontoVenda_TextChanged);
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesconto.Location = new System.Drawing.Point(2, 412);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(94, 16);
            this.lbDesconto.TabIndex = 20;
            this.lbDesconto.Text = "Desconto %:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Enabled = false;
            this.txtValorVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(110, 349);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(74, 23);
            this.txtValorVenda.TabIndex = 17;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            // 
            // lbValorVend
            // 
            this.lbValorVend.AutoSize = true;
            this.lbValorVend.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorVend.Location = new System.Drawing.Point(30, 352);
            this.lbValorVend.Name = "lbValorVend";
            this.lbValorVend.Size = new System.Drawing.Size(67, 16);
            this.lbValorVend.TabIndex = 19;
            this.lbValorVend.Text = "Valor R$:";
            // 
            // dTPDataEmissaoVenda
            // 
            this.dTPDataEmissaoVenda.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPDataEmissaoVenda.Enabled = false;
            this.dTPDataEmissaoVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPDataEmissaoVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDataEmissaoVenda.Location = new System.Drawing.Point(110, 380);
            this.dTPDataEmissaoVenda.Name = "dTPDataEmissaoVenda";
            this.dTPDataEmissaoVenda.Size = new System.Drawing.Size(121, 23);
            this.dTPDataEmissaoVenda.TabIndex = 16;
            this.dTPDataEmissaoVenda.Value = new System.DateTime(2015, 11, 21, 0, 0, 0, 0);
            // 
            // lbDataEmissao
            // 
            this.lbDataEmissao.AutoSize = true;
            this.lbDataEmissao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataEmissao.Location = new System.Drawing.Point(30, 380);
            this.lbDataEmissao.Name = "lbDataEmissao";
            this.lbDataEmissao.Size = new System.Drawing.Size(66, 16);
            this.lbDataEmissao.TabIndex = 15;
            this.lbDataEmissao.Text = "Emissão:";
            // 
            // dGVendasItens
            // 
            this.dGVendasItens.AllowUserToAddRows = false;
            this.dGVendasItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVendasItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVendasItens.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVendasItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVendasItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dGVendasItens.Location = new System.Drawing.Point(11, 182);
            this.dGVendasItens.Name = "dGVendasItens";
            this.dGVendasItens.ReadOnly = true;
            this.dGVendasItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVendasItens.Size = new System.Drawing.Size(442, 161);
            this.dGVendasItens.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PROD_ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Produto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "VENDA_ITENS_QTO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Quantidade";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VENDA_ITENS_VLUNIT";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Valor Unit R$";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "VENDA_ITENS_TOTAL";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Total R$";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoItem.Location = new System.Drawing.Point(320, 141);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(106, 23);
            this.btnNovoItem.TabIndex = 5;
            this.btnNovoItem.Text = "Add Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // txtValorUnitItem
            // 
            this.txtValorUnitItem.Enabled = false;
            this.txtValorUnitItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitItem.Location = new System.Drawing.Point(110, 143);
            this.txtValorUnitItem.Name = "txtValorUnitItem";
            this.txtValorUnitItem.Size = new System.Drawing.Size(59, 23);
            this.txtValorUnitItem.TabIndex = 5;
            this.txtValorUnitItem.Enter += new System.EventHandler(this.txtValorUnitItem_Enter);
            this.txtValorUnitItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorUnitItem_KeyDown);
            this.txtValorUnitItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitItem_KeyPress);
            // 
            // lbValorUnit
            // 
            this.lbValorUnit.AutoSize = true;
            this.lbValorUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorUnit.Location = new System.Drawing.Point(8, 145);
            this.lbValorUnit.Name = "lbValorUnit";
            this.lbValorUnit.Size = new System.Drawing.Size(98, 16);
            this.lbValorUnit.TabIndex = 9;
            this.lbValorUnit.Text = "Valor Unit R$:";
            // 
            // txtQuantidadeItem
            // 
            this.txtQuantidadeItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeItem.Location = new System.Drawing.Point(110, 114);
            this.txtQuantidadeItem.Name = "txtQuantidadeItem";
            this.txtQuantidadeItem.Size = new System.Drawing.Size(59, 23);
            this.txtQuantidadeItem.TabIndex = 4;
            this.txtQuantidadeItem.TextChanged += new System.EventHandler(this.txtQuantidadeItem_TextChanged);
            this.txtQuantidadeItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeItem_KeyPress);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(15, 117);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(89, 16);
            this.lbQuantidade.TabIndex = 7;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // cBProdutoItem
            // 
            this.cBProdutoItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBProdutoItem.FormattingEnabled = true;
            this.cBProdutoItem.Location = new System.Drawing.Point(110, 84);
            this.cBProdutoItem.Name = "cBProdutoItem";
            this.cBProdutoItem.Size = new System.Drawing.Size(177, 24);
            this.cBProdutoItem.TabIndex = 3;
            this.cBProdutoItem.SelectedValueChanged += new System.EventHandler(this.cBProdutoItem_SelectedValueChanged);
            this.cBProdutoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBProdutoItem_KeyPress);
            // 
            // lbCodVenda
            // 
            this.lbCodVenda.AutoSize = true;
            this.lbCodVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodVenda.Location = new System.Drawing.Point(46, 27);
            this.lbCodVenda.Name = "lbCodVenda";
            this.lbCodVenda.Size = new System.Drawing.Size(54, 16);
            this.lbCodVenda.TabIndex = 0;
            this.lbCodVenda.Text = "Venda:";
            // 
            // cBClienteVenda
            // 
            this.cBClienteVenda.FormattingEnabled = true;
            this.cBClienteVenda.Location = new System.Drawing.Point(122, 26);
            this.cBClienteVenda.Name = "cBClienteVenda";
            this.cBClienteVenda.Size = new System.Drawing.Size(177, 21);
            this.cBClienteVenda.TabIndex = 1;
            this.cBClienteVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBClienteVenda_KeyPress);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(51, 25);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(65, 18);
            this.lbCliente.TabIndex = 2;
            this.lbCliente.Text = "Cliente:";
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(332, 26);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(106, 23);
            this.btnNovaVenda.TabIndex = 3;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMensagem
            // 
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.cBClienteVenda);
            this.Controls.Add(this.gBNovaVenda);
            this.MaximizeBox = false;
            this.Name = "FrmVendas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.gBNovaVenda.ResumeLayout(false);
            this.gBNovaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVendasItens)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBNovaVenda;
        private System.Windows.Forms.DataGridView dGVendasItens;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.TextBox txtValorUnitItem;
        private System.Windows.Forms.Label lbValorUnit;
        private System.Windows.Forms.TextBox txtQuantidadeItem;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.ComboBox cBProdutoItem;
        private System.Windows.Forms.Label lbCodVenda;
        private System.Windows.Forms.ComboBox cBClienteVenda;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtDescontoVenda;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lbValorVend;
        private System.Windows.Forms.DateTimePicker dTPDataEmissaoVenda;
        private System.Windows.Forms.Label lbDataEmissao;
        private System.Windows.Forms.TextBox txtValorPagoVenda;
        private System.Windows.Forms.Label lbValorPago;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnFinalizaPedido;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.ToolStripStatusLabel lbMensagem;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Label lbVendedor;
        private System.Windows.Forms.ComboBox cBCodVendedorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnDetalhe;
    }
}