namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmPecas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPecas));
            this.sSRodape = new System.Windows.Forms.StatusStrip();
            this.lblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.txtfabricante = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPesquisaPeca = new System.Windows.Forms.GroupBox();
            this.dgvPesquisaPeca = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPeca = new System.Windows.Forms.RadioButton();
            this.rBCod = new System.Windows.Forms.RadioButton();
            this.btnPesquisaPeca = new System.Windows.Forms.Button();
            this.txtPesquisaPeca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSMenu = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeletar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.sSRodape.SuspendLayout();
            this.gbPesquisaPeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaPeca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sSRodape
            // 
            this.sSRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMensagem});
            this.sSRodape.Location = new System.Drawing.Point(0, 449);
            this.sSRodape.Name = "sSRodape";
            this.sSRodape.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sSRodape.Size = new System.Drawing.Size(494, 22);
            this.sSRodape.SizingGrip = false;
            this.sSRodape.TabIndex = 3;
            this.sSRodape.Text = "statusStrip1";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // txtnome
            // 
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(86, 79);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(216, 22);
            this.txtnome.TabIndex = 2;
            this.txtnome.Validating += new System.ComponentModel.CancelEventHandler(this.txtnome_Validating);
            // 
            // txtqtde
            // 
            this.txtqtde.Enabled = false;
            this.txtqtde.Location = new System.Drawing.Point(199, 127);
            this.txtqtde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(59, 22);
            this.txtqtde.TabIndex = 4;
            this.txtqtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtde_KeyPress);
            // 
            // txtfabricante
            // 
            this.txtfabricante.Enabled = false;
            this.txtfabricante.Location = new System.Drawing.Point(9, 127);
            this.txtfabricante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfabricante.Name = "txtfabricante";
            this.txtfabricante.Size = new System.Drawing.Size(177, 22);
            this.txtfabricante.TabIndex = 3;
            this.txtfabricante.Validating += new System.ComponentModel.CancelEventHandler(this.txtfabricante_Validating);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(83, 61);
            this.lbnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(43, 14);
            this.lbnome.TabIndex = 39;
            this.lbnome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 41;
            this.label3.Text = "Quantidade";
            // 
            // gbPesquisaPeca
            // 
            this.gbPesquisaPeca.Controls.Add(this.dgvPesquisaPeca);
            this.gbPesquisaPeca.Controls.Add(this.groupBox1);
            this.gbPesquisaPeca.Controls.Add(this.btnPesquisaPeca);
            this.gbPesquisaPeca.Controls.Add(this.txtPesquisaPeca);
            this.gbPesquisaPeca.Controls.Add(this.label6);
            this.gbPesquisaPeca.Controls.Add(this.label5);
            this.gbPesquisaPeca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisaPeca.Location = new System.Drawing.Point(10, 179);
            this.gbPesquisaPeca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPesquisaPeca.Name = "gbPesquisaPeca";
            this.gbPesquisaPeca.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPesquisaPeca.Size = new System.Drawing.Size(481, 267);
            this.gbPesquisaPeca.TabIndex = 43;
            this.gbPesquisaPeca.TabStop = false;
            this.gbPesquisaPeca.Text = "Pesquisar Peça";
            // 
            // dgvPesquisaPeca
            // 
            this.dgvPesquisaPeca.AllowUserToAddRows = false;
            this.dgvPesquisaPeca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPesquisaPeca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPesquisaPeca.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPesquisaPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaPeca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.fabricante,
            this.qntd});
            this.dgvPesquisaPeca.Location = new System.Drawing.Point(8, 113);
            this.dgvPesquisaPeca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPesquisaPeca.Name = "dgvPesquisaPeca";
            this.dgvPesquisaPeca.ReadOnly = true;
            this.dgvPesquisaPeca.Size = new System.Drawing.Size(448, 148);
            this.dgvPesquisaPeca.TabIndex = 44;
            this.dgvPesquisaPeca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisaPeca_CellClick);
            this.dgvPesquisaPeca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisaPeca_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "PEC_ID";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "PEC_NOME";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // fabricante
            // 
            this.fabricante.DataPropertyName = "PEC_FABRICANTE";
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.ReadOnly = true;
            // 
            // qntd
            // 
            this.qntd.DataPropertyName = "PEC_QUANTIDADE";
            this.qntd.HeaderText = "Quantidade";
            this.qntd.Name = "qntd";
            this.qntd.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPeca);
            this.groupBox1.Controls.Add(this.rBCod);
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 85);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // rbPeca
            // 
            this.rbPeca.AutoSize = true;
            this.rbPeca.Checked = true;
            this.rbPeca.Location = new System.Drawing.Point(7, 46);
            this.rbPeca.Name = "rbPeca";
            this.rbPeca.Size = new System.Drawing.Size(55, 18);
            this.rbPeca.TabIndex = 1;
            this.rbPeca.TabStop = true;
            this.rbPeca.Text = "Peça";
            this.rbPeca.UseVisualStyleBackColor = true;
            // 
            // rBCod
            // 
            this.rBCod.AutoSize = true;
            this.rBCod.Location = new System.Drawing.Point(7, 22);
            this.rBCod.Name = "rBCod";
            this.rBCod.Size = new System.Drawing.Size(69, 18);
            this.rBCod.TabIndex = 0;
            this.rBCod.Text = "Código";
            this.rBCod.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaPeca
            // 
            this.btnPesquisaPeca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaPeca.Location = new System.Drawing.Point(374, 34);
            this.btnPesquisaPeca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisaPeca.Name = "btnPesquisaPeca";
            this.btnPesquisaPeca.Size = new System.Drawing.Size(93, 25);
            this.btnPesquisaPeca.TabIndex = 5;
            this.btnPesquisaPeca.Text = "Pesquisar ";
            this.btnPesquisaPeca.UseVisualStyleBackColor = true;
            this.btnPesquisaPeca.Click += new System.EventHandler(this.btnPesquisaPeca_Click);
            // 
            // txtPesquisaPeca
            // 
            this.txtPesquisaPeca.Location = new System.Drawing.Point(172, 36);
            this.txtPesquisaPeca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisaPeca.Name = "txtPesquisaPeca";
            this.txtPesquisaPeca.Size = new System.Drawing.Size(181, 22);
            this.txtPesquisaPeca.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Faça sua Pesquisa aqui";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 0;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(7, 55);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(61, 18);
            this.rbNome.TabIndex = 2;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(7, 31);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(69, 18);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "PEC_VALOR";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // tSMenu
            // 
            this.tSMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator1,
            this.btnSalvar,
            this.toolStripSeparator2,
            this.btnDeletar,
            this.toolStripSeparator3,
            this.btnAtualizar,
            this.toolStripSeparator5,
            this.btnVoltar});
            this.tSMenu.Location = new System.Drawing.Point(0, 0);
            this.tSMenu.Name = "tSMenu";
            this.tSMenu.Size = new System.Drawing.Size(494, 39);
            this.tSMenu.TabIndex = 46;
            this.tSMenu.Text = "Menu";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(72, 36);
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 36);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(80, 36);
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(89, 36);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(74, 36);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cód";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 78);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(59, 22);
            this.txtCodigo.TabIndex = 47;
            // 
            // FrmPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.tSMenu);
            this.Controls.Add(this.gbPesquisaPeca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.txtfabricante);
            this.Controls.Add(this.txtqtde);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.sSRodape);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peças";
            this.Load += new System.EventHandler(this.FrmPecas_Load);
            this.sSRodape.ResumeLayout(false);
            this.sSRodape.PerformLayout();
            this.gbPesquisaPeca.ResumeLayout(false);
            this.gbPesquisaPeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaPeca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tSMenu.ResumeLayout(false);
            this.tSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip sSRodape;
        private System.Windows.Forms.ToolStripStatusLabel lblMensagem;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtqtde;
        private System.Windows.Forms.TextBox txtfabricante;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPesquisaPeca;
        private System.Windows.Forms.Button btnPesquisaPeca;
        private System.Windows.Forms.TextBox txtPesquisaPeca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPesquisaPeca;
        public System.Windows.Forms.ToolStrip tSMenu;
        public System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton btnDeletar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntd;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBCod;
        private System.Windows.Forms.RadioButton rbPeca;
    }
}