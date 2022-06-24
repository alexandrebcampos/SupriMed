namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmCadLogin
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
            this.cBCPF = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.cBPrivilegio = new System.Windows.Forms.ComboBox();
            this.lbPrivilegio = new System.Windows.Forms.Label();
            this.dTPDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.lbAtualizadoEm = new System.Windows.Forms.Label();
            this.dTPAtualizacaoCad = new System.Windows.Forms.DateTimePicker();
            this.gBPesquisa = new System.Windows.Forms.GroupBox();
            this.dGVExibirPesquisa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gBTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rBUsuario = new System.Windows.Forms.RadioButton();
            this.rBCPF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gBPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVExibirPesquisa)).BeginInit();
            this.gBTipoPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBCPF
            // 
            this.cBCPF.Location = new System.Drawing.Point(16, 72);
            this.cBCPF.Name = "cBCPF";
            this.cBCPF.Size = new System.Drawing.Size(189, 21);
            this.cBCPF.TabIndex = 3;
            this.cBCPF.SelectedValueChanged += new System.EventHandler(this.cBCPF_SelectedValueChanged);
            this.cBCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBCPF_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(213, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(210, 53);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(62, 16);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuário:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(409, 72);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(106, 20);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(407, 53);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(55, 16);
            this.lbSenha.TabIndex = 8;
            this.lbSenha.Text = "Senha:";
            // 
            // cBPrivilegio
            // 
            this.cBPrivilegio.FormattingEnabled = true;
            this.cBPrivilegio.Location = new System.Drawing.Point(16, 117);
            this.cBPrivilegio.Name = "cBPrivilegio";
            this.cBPrivilegio.Size = new System.Drawing.Size(164, 21);
            this.cBPrivilegio.TabIndex = 13;
            this.cBPrivilegio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBPrivilegio_KeyPress);
            // 
            // lbPrivilegio
            // 
            this.lbPrivilegio.AutoSize = true;
            this.lbPrivilegio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrivilegio.Location = new System.Drawing.Point(13, 97);
            this.lbPrivilegio.Name = "lbPrivilegio";
            this.lbPrivilegio.Size = new System.Drawing.Size(71, 16);
            this.lbPrivilegio.TabIndex = 12;
            this.lbPrivilegio.Text = "Privilegio:";
            // 
            // dTPDataCadastro
            // 
            this.dTPDataCadastro.Enabled = false;
            this.dTPDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDataCadastro.Location = new System.Drawing.Point(189, 117);
            this.dTPDataCadastro.Name = "dTPDataCadastro";
            this.dTPDataCadastro.Size = new System.Drawing.Size(110, 20);
            this.dTPDataCadastro.TabIndex = 14;
            this.dTPDataCadastro.Value = new System.DateTime(2015, 11, 5, 0, 0, 0, 0);
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadastro.Location = new System.Drawing.Point(186, 97);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(130, 16);
            this.lbDataCadastro.TabIndex = 15;
            this.lbDataCadastro.Text = "Data do Cadastro:";
            // 
            // lbAtualizadoEm
            // 
            this.lbAtualizadoEm.AutoSize = true;
            this.lbAtualizadoEm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtualizadoEm.Location = new System.Drawing.Point(322, 97);
            this.lbAtualizadoEm.Name = "lbAtualizadoEm";
            this.lbAtualizadoEm.Size = new System.Drawing.Size(175, 16);
            this.lbAtualizadoEm.TabIndex = 17;
            this.lbAtualizadoEm.Text = "Atualização do Cadastro:";
            // 
            // dTPAtualizacaoCad
            // 
            this.dTPAtualizacaoCad.Enabled = false;
            this.dTPAtualizacaoCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPAtualizacaoCad.Location = new System.Drawing.Point(325, 117);
            this.dTPAtualizacaoCad.Name = "dTPAtualizacaoCad";
            this.dTPAtualizacaoCad.Size = new System.Drawing.Size(110, 20);
            this.dTPAtualizacaoCad.TabIndex = 16;
            this.dTPAtualizacaoCad.Value = new System.DateTime(2015, 11, 5, 0, 0, 0, 0);
            // 
            // gBPesquisa
            // 
            this.gBPesquisa.Controls.Add(this.dGVExibirPesquisa);
            this.gBPesquisa.Controls.Add(this.btnPesquisar);
            this.gBPesquisa.Controls.Add(this.txtPesquisar);
            this.gBPesquisa.Controls.Add(this.lblDescricao);
            this.gBPesquisa.Controls.Add(this.gBTipoPesquisa);
            this.gBPesquisa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPesquisa.Location = new System.Drawing.Point(12, 153);
            this.gBPesquisa.Name = "gBPesquisa";
            this.gBPesquisa.Size = new System.Drawing.Size(609, 361);
            this.gBPesquisa.TabIndex = 18;
            this.gBPesquisa.TabStop = false;
            this.gBPesquisa.Text = "Pesquisar";
            // 
            // dGVExibirPesquisa
            // 
            this.dGVExibirPesquisa.AllowUserToAddRows = false;
            this.dGVExibirPesquisa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVExibirPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVExibirPesquisa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVExibirPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVExibirPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVExibirPesquisa.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVExibirPesquisa.Location = new System.Drawing.Point(8, 123);
            this.dGVExibirPesquisa.Name = "dGVExibirPesquisa";
            this.dGVExibirPesquisa.ReadOnly = true;
            this.dGVExibirPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVExibirPesquisa.Size = new System.Drawing.Size(548, 227);
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
            // Column2
            // 
            this.Column2.DataPropertyName = "LOG_USUARIO";
            this.Column2.HeaderText = "Usuário";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LOG_SENHA";
            this.Column3.HeaderText = "Senha";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LOG_PRIVILEGIO";
            this.Column4.HeaderText = "Privilégio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LOG_ATUALIZADOEM";
            this.Column5.HeaderText = "Atualizado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(504, 43);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 34);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(201, 44);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(283, 26);
            this.txtPesquisar.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(198, 26);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(346, 18);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Digite o texto a ser pesquisado e tecle ENTER";
            // 
            // gBTipoPesquisa
            // 
            this.gBTipoPesquisa.Controls.Add(this.rBUsuario);
            this.gBTipoPesquisa.Controls.Add(this.rBCPF);
            this.gBTipoPesquisa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTipoPesquisa.Location = new System.Drawing.Point(8, 26);
            this.gBTipoPesquisa.Name = "gBTipoPesquisa";
            this.gBTipoPesquisa.Size = new System.Drawing.Size(182, 91);
            this.gBTipoPesquisa.TabIndex = 6;
            this.gBTipoPesquisa.TabStop = false;
            this.gBTipoPesquisa.Text = "Tipo de Pesquisa";
            // 
            // rBUsuario
            // 
            this.rBUsuario.AutoSize = true;
            this.rBUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBUsuario.Location = new System.Drawing.Point(19, 60);
            this.rBUsuario.Name = "rBUsuario";
            this.rBUsuario.Size = new System.Drawing.Size(74, 20);
            this.rBUsuario.TabIndex = 1;
            this.rBUsuario.Text = "Usuário";
            this.rBUsuario.UseVisualStyleBackColor = true;
            // 
            // rBCPF
            // 
            this.rBCPF.AutoSize = true;
            this.rBCPF.Checked = true;
            this.rBCPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBCPF.Location = new System.Drawing.Point(19, 34);
            this.rBCPF.Name = "rBCPF";
            this.rBCPF.Size = new System.Drawing.Size(51, 20);
            this.rBCPF.TabIndex = 0;
            this.rBCPF.TabStop = true;
            this.rBCPF.Text = "CPF";
            this.rBCPF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Funcionário:";
            // 
            // FrmCadLogin
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBPesquisa);
            this.Controls.Add(this.lbAtualizadoEm);
            this.Controls.Add(this.dTPAtualizacaoCad);
            this.Controls.Add(this.lbDataCadastro);
            this.Controls.Add(this.dTPDataCadastro);
            this.Controls.Add(this.cBPrivilegio);
            this.Controls.Add(this.lbPrivilegio);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.cBCPF);
            this.Name = "FrmCadLogin";
            this.Text = "Cadastro de Usuarios";
            this.Load += new System.EventHandler(this.FrmCadLogin_Load);
            this.Controls.SetChildIndex(this.cBCPF, 0);
            this.Controls.SetChildIndex(this.lbUsuario, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.lbSenha, 0);
            this.Controls.SetChildIndex(this.txtSenha, 0);
            this.Controls.SetChildIndex(this.lbPrivilegio, 0);
            this.Controls.SetChildIndex(this.cBPrivilegio, 0);
            this.Controls.SetChildIndex(this.dTPDataCadastro, 0);
            this.Controls.SetChildIndex(this.lbDataCadastro, 0);
            this.Controls.SetChildIndex(this.dTPAtualizacaoCad, 0);
            this.Controls.SetChildIndex(this.lbAtualizadoEm, 0);
            this.Controls.SetChildIndex(this.gBPesquisa, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.gBPesquisa.ResumeLayout(false);
            this.gBPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVExibirPesquisa)).EndInit();
            this.gBTipoPesquisa.ResumeLayout(false);
            this.gBTipoPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBCPF;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.ComboBox cBPrivilegio;
        private System.Windows.Forms.Label lbPrivilegio;
        private System.Windows.Forms.DateTimePicker dTPDataCadastro;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.Label lbAtualizadoEm;
        private System.Windows.Forms.DateTimePicker dTPAtualizacaoCad;
        private System.Windows.Forms.GroupBox gBPesquisa;
        private System.Windows.Forms.DataGridView dGVExibirPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gBTipoPesquisa;
        private System.Windows.Forms.RadioButton rBUsuario;
        private System.Windows.Forms.RadioButton rBCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
