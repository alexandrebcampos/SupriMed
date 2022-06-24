namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmCadSetores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadSetores));
            this.lbSetores = new System.Windows.Forms.Label();
            this.txtNomeSetor = new System.Windows.Forms.TextBox();
            this.gBPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dGVPesquisa = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSMenu = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.lbCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gBPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPesquisa)).BeginInit();
            this.tSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSetores
            // 
            this.lbSetores.AutoSize = true;
            this.lbSetores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetores.Location = new System.Drawing.Point(5, 56);
            this.lbSetores.Name = "lbSetores";
            this.lbSetores.Size = new System.Drawing.Size(50, 16);
            this.lbSetores.TabIndex = 2;
            this.lbSetores.Text = "Nome:";
            // 
            // txtNomeSetor
            // 
            this.txtNomeSetor.Location = new System.Drawing.Point(8, 75);
            this.txtNomeSetor.MaxLength = 100;
            this.txtNomeSetor.Name = "txtNomeSetor";
            this.txtNomeSetor.Size = new System.Drawing.Size(224, 20);
            this.txtNomeSetor.TabIndex = 3;
            // 
            // gBPesquisa
            // 
            this.gBPesquisa.Controls.Add(this.btnPesquisar);
            this.gBPesquisa.Controls.Add(this.txtPesquisar);
            this.gBPesquisa.Controls.Add(this.dGVPesquisa);
            this.gBPesquisa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPesquisa.Location = new System.Drawing.Point(8, 107);
            this.gBPesquisa.Name = "gBPesquisa";
            this.gBPesquisa.Size = new System.Drawing.Size(335, 190);
            this.gBPesquisa.TabIndex = 4;
            this.gBPesquisa.TabStop = false;
            this.gBPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(240, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(6, 33);
            this.txtPesquisar.MaxLength = 100;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(228, 23);
            this.txtPesquisar.TabIndex = 5;
            // 
            // dGVPesquisa
            // 
            this.dGVPesquisa.AllowUserToAddRows = false;
            this.dGVPesquisa.AllowUserToDeleteRows = false;
            this.dGVPesquisa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dGVPesquisa.Location = new System.Drawing.Point(6, 70);
            this.dGVPesquisa.Name = "dGVPesquisa";
            this.dGVPesquisa.ReadOnly = true;
            this.dGVPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPesquisa.Size = new System.Drawing.Size(316, 114);
            this.dGVPesquisa.TabIndex = 0;
            this.dGVPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPesquisa_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SET_ID";
            this.Column2.HeaderText = "Código";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SET_NOME";
            this.Column1.HeaderText = "Setor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 220;
            // 
            // tSMenu
            // 
            this.tSMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.toolStripSeparator2,
            this.btnVoltar,
            this.btnAtualizar});
            this.tSMenu.Location = new System.Drawing.Point(0, 0);
            this.tSMenu.Name = "tSMenu";
            this.tSMenu.Size = new System.Drawing.Size(348, 39);
            this.tSMenu.TabIndex = 7;
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
            // btnAtualizar
            // 
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(89, 36);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod.Location = new System.Drawing.Point(5, 56);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(58, 16);
            this.lbCod.TabIndex = 8;
            this.lbCod.Text = "Código:";
            this.lbCod.Visible = false;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(8, 75);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(45, 20);
            this.txtCod.TabIndex = 9;
            this.txtCod.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(348, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmCadSetores
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 336);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.tSMenu);
            this.Controls.Add(this.gBPesquisa);
            this.Controls.Add(this.txtNomeSetor);
            this.Controls.Add(this.lbSetores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadSetores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setores";
            this.Load += new System.EventHandler(this.FrmCadSetores_Load);
            this.gBPesquisa.ResumeLayout(false);
            this.gBPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPesquisa)).EndInit();
            this.tSMenu.ResumeLayout(false);
            this.tSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSetores;
        private System.Windows.Forms.TextBox txtNomeSetor;
        private System.Windows.Forms.GroupBox gBPesquisa;
        private System.Windows.Forms.DataGridView dGVPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.ToolStrip tSMenu;
        public System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
