namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmConsultaVisita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaVisita));
            this.dGVPesquisa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tSMenu = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.maskedtbCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPesquisa)).BeginInit();
            this.tSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVPesquisa
            // 
            this.dGVPesquisa.AllowUserToAddRows = false;
            this.dGVPesquisa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVPesquisa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVPesquisa.Location = new System.Drawing.Point(12, 99);
            this.dGVPesquisa.Name = "dGVPesquisa";
            this.dGVPesquisa.ReadOnly = true;
            this.dGVPesquisa.Size = new System.Drawing.Size(443, 210);
            this.dGVPesquisa.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CLI_CPF";
            this.Column1.HeaderText = "CPF";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "VEND_ID";
            this.Column2.HeaderText = "Vendedor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VIS_DATA";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Data";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "VIS_HORA";
            dataGridViewCellStyle6.Format = "T";
            dataGridViewCellStyle6.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Hora";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "VIS_DESCRICAO";
            this.Column5.HeaderText = "Descrição";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnProcurar.Location = new System.Drawing.Point(186, 57);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(119, 25);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Consultar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPF";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnLimpar.Location = new System.Drawing.Point(311, 58);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 25);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tSMenu
            // 
            this.tSMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVoltar});
            this.tSMenu.Location = new System.Drawing.Point(0, 0);
            this.tSMenu.Name = "tSMenu";
            this.tSMenu.Size = new System.Drawing.Size(466, 39);
            this.tSMenu.TabIndex = 14;
            this.tSMenu.Text = "Menu";
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
            // maskedtbCPF
            // 
            this.maskedtbCPF.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.maskedtbCPF.Location = new System.Drawing.Point(66, 58);
            this.maskedtbCPF.Mask = "999,999,999-99";
            this.maskedtbCPF.Name = "maskedtbCPF";
            this.maskedtbCPF.Size = new System.Drawing.Size(114, 23);
            this.maskedtbCPF.TabIndex = 0;
            this.maskedtbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedtbCPF.Leave += new System.EventHandler(this.maskedtbCPF_Leave);
            // 
            // FrmConsultaVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 319);
            this.Controls.Add(this.maskedtbCPF);
            this.Controls.Add(this.tSMenu);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dGVPesquisa);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Visitas";
            this.Load += new System.EventHandler(this.FrmConsultaVisita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPesquisa)).EndInit();
            this.tSMenu.ResumeLayout(false);
            this.tSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVPesquisa;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.ToolStrip tSMenu;
        public System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.MaskedTextBox maskedtbCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}