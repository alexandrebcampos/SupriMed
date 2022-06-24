namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmCadVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadVendedor));
            this.tSMenu = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.sSRodape = new System.Windows.Forms.StatusStrip();
            this.lblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.gBPesquisa = new System.Windows.Forms.GroupBox();
            this.dGVExibirPesquisa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cBVendedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.tSMenu.SuspendLayout();
            this.sSRodape.SuspendLayout();
            this.gBPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVExibirPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // tSMenu
            // 
            this.tSMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.toolStripSeparator2,
            this.btnAtualizar,
            this.toolStripSeparator5,
            this.btnVoltar});
            this.tSMenu.Location = new System.Drawing.Point(0, 0);
            this.tSMenu.Name = "tSMenu";
            this.tSMenu.Size = new System.Drawing.Size(385, 39);
            this.tSMenu.TabIndex = 3;
            this.tSMenu.Text = "Menu";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 36);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
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
            this.btnVoltar.Size = new System.Drawing.Size(73, 36);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // sSRodape
            // 
            this.sSRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMensagem});
            this.sSRodape.Location = new System.Drawing.Point(0, 390);
            this.sSRodape.Name = "sSRodape";
            this.sSRodape.Size = new System.Drawing.Size(385, 22);
            this.sSRodape.SizingGrip = false;
            this.sSRodape.TabIndex = 2;
            this.sSRodape.Text = "statusStrip1";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // gBPesquisa
            // 
            this.gBPesquisa.Controls.Add(this.dGVExibirPesquisa);
            this.gBPesquisa.Controls.Add(this.btnPesquisar);
            this.gBPesquisa.Controls.Add(this.txtPesquisar);
            this.gBPesquisa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPesquisa.Location = new System.Drawing.Point(3, 111);
            this.gBPesquisa.Name = "gBPesquisa";
            this.gBPesquisa.Size = new System.Drawing.Size(378, 273);
            this.gBPesquisa.TabIndex = 19;
            this.gBPesquisa.TabStop = false;
            this.gBPesquisa.Text = "Pesquisar";
            // 
            // dGVExibirPesquisa
            // 
            this.dGVExibirPesquisa.AllowUserToAddRows = false;
            this.dGVExibirPesquisa.AllowUserToDeleteRows = false;
            this.dGVExibirPesquisa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVExibirPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVExibirPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dGVExibirPesquisa.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVExibirPesquisa.Location = new System.Drawing.Point(15, 107);
            this.dGVExibirPesquisa.Name = "dGVExibirPesquisa";
            this.dGVExibirPesquisa.ReadOnly = true;
            this.dGVExibirPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVExibirPesquisa.Size = new System.Drawing.Size(345, 160);
            this.dGVExibirPesquisa.TabIndex = 10;
            this.dGVExibirPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVExibirPesquisa_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FUNC_CPF";
            this.Column1.HeaderText = "CPF";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FUNC_NOME";
            this.Column3.HeaderText = "Vendedor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "VEND_COMISSAO";
            this.Column2.HeaderText = "Comissão";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(256, 40);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 34);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(15, 47);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(212, 23);
            this.txtPesquisar.TabIndex = 8;
            // 
            // cBVendedor
            // 
            this.cBVendedor.FormattingEnabled = true;
            this.cBVendedor.Location = new System.Drawing.Point(15, 69);
            this.cBVendedor.Name = "cBVendedor";
            this.cBVendedor.Size = new System.Drawing.Size(178, 21);
            this.cBVendedor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Comissão";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(225, 70);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(79, 20);
            this.txtComissao.TabIndex = 23;
            // 
            // FrmCadVendedor
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 412);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBVendedor);
            this.Controls.Add(this.gBPesquisa);
            this.Controls.Add(this.tSMenu);
            this.Controls.Add(this.sSRodape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.FrmCadVendedor_Load);
            this.tSMenu.ResumeLayout(false);
            this.tSMenu.PerformLayout();
            this.sSRodape.ResumeLayout(false);
            this.sSRodape.PerformLayout();
            this.gBPesquisa.ResumeLayout(false);
            this.gBPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVExibirPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tSMenu;
        public System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.StatusStrip sSRodape;
        private System.Windows.Forms.ToolStripStatusLabel lblMensagem;
        private System.Windows.Forms.GroupBox gBPesquisa;
        private System.Windows.Forms.DataGridView dGVExibirPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cBVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
