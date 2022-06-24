namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.sSRodape = new System.Windows.Forms.StatusStrip();
            this.lblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtpdatanasc = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.gbPesquisaCliente = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPesquisaCliente = new System.Windows.Forms.DataGridView();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.rbnome = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.lbErroNome = new System.Windows.Forms.Label();
            this.lbErroSobre = new System.Windows.Forms.Label();
            this.lbErroEnd = new System.Windows.Forms.Label();
            this.lbErroCidade = new System.Windows.Forms.Label();
            this.lbErroNum = new System.Windows.Forms.Label();
            this.lbErroBairro = new System.Windows.Forms.Label();
            this.cBSexo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.tSMenu.SuspendLayout();
            this.sSRodape.SuspendLayout();
            this.gbPesquisaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaCliente)).BeginInit();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
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
            this.tSMenu.Size = new System.Drawing.Size(720, 39);
            this.tSMenu.TabIndex = 2;
            this.tSMenu.Text = "Menu";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(72, 36);
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
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
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
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
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(89, 36);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.ToolTipText = "Alterar";
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
            this.sSRodape.Location = new System.Drawing.Point(0, 541);
            this.sSRodape.Name = "sSRodape";
            this.sSRodape.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sSRodape.Size = new System.Drawing.Size(720, 22);
            this.sSRodape.SizingGrip = false;
            this.sSRodape.TabIndex = 3;
            this.sSRodape.Text = "statusStrip1";
            this.sSRodape.UseWaitCursor = true;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // dtpdatanasc
            // 
            this.dtpdatanasc.Enabled = false;
            this.dtpdatanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatanasc.Location = new System.Drawing.Point(576, 72);
            this.dtpdatanasc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpdatanasc.Name = "dtpdatanasc";
            this.dtpdatanasc.Size = new System.Drawing.Size(119, 22);
            this.dtpdatanasc.TabIndex = 4;
            this.dtpdatanasc.Value = new System.DateTime(2015, 11, 10, 0, 0, 0, 0);
            // 
            // txtemail
            // 
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(177, 186);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(216, 22);
            this.txtemail.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 14);
            this.label10.TabIndex = 45;
            this.label10.Text = "E-mail";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 14);
            this.label9.TabIndex = 44;
            this.label9.Text = "Telefone";
            this.label9.UseWaitCursor = true;
            // 
            // cbuf
            // 
            this.cbuf.Enabled = false;
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PR",
            "PB",
            "PA",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbuf.Location = new System.Drawing.Point(15, 186);
            this.cbuf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(47, 22);
            this.cbuf.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 14);
            this.label8.TabIndex = 42;
            this.label8.Text = "UF";
            this.label8.UseWaitCursor = true;
            // 
            // txtcidade
            // 
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcidade.Enabled = false;
            this.txtcidade.Location = new System.Drawing.Point(526, 126);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(169, 22);
            this.txtcidade.TabIndex = 8;
            this.txtcidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtcidade_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 40;
            this.label7.Text = "Cidade";
            this.label7.UseWaitCursor = true;
            // 
            // txtbairro
            // 
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbairro.Enabled = false;
            this.txtbairro.Location = new System.Drawing.Point(352, 126);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(165, 22);
            this.txtbairro.TabIndex = 7;
            this.txtbairro.Validating += new System.ComponentModel.CancelEventHandler(this.txtbairro_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 38;
            this.label6.Text = "Bairro";
            this.label6.UseWaitCursor = true;
            // 
            // txtendereco
            // 
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendereco.Enabled = false;
            this.txtendereco.Location = new System.Drawing.Point(15, 125);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(230, 22);
            this.txtendereco.TabIndex = 5;
            this.txtendereco.Validating += new System.ComponentModel.CancelEventHandler(this.txtendereco_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Endereço";
            this.label5.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 30;
            this.label1.Text = "CPF";
            this.label1.UseWaitCursor = true;
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsobrenome.Enabled = false;
            this.txtsobrenome.Location = new System.Drawing.Point(352, 72);
            this.txtsobrenome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(165, 22);
            this.txtsobrenome.TabIndex = 3;
            this.txtsobrenome.Validating += new System.ComponentModel.CancelEventHandler(this.txtsobrenome_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "Data de Nascimento";
            this.label4.UseWaitCursor = true;
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(131, 72);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(216, 22);
            this.txtnome.TabIndex = 2;
            this.txtnome.Validating += new System.ComponentModel.CancelEventHandler(this.txtnome_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sobrenome";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome";
            this.label2.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 14);
            this.label11.TabIndex = 46;
            this.label11.Text = "Nº";
            this.label11.UseWaitCursor = true;
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(253, 125);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(93, 22);
            this.txtnumero.TabIndex = 6;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // gbPesquisaCliente
            // 
            this.gbPesquisaCliente.Controls.Add(this.btnPesquisa);
            this.gbPesquisaCliente.Controls.Add(this.txtpesquisa);
            this.gbPesquisaCliente.Controls.Add(this.label12);
            this.gbPesquisaCliente.Controls.Add(this.dgvPesquisaCliente);
            this.gbPesquisaCliente.Controls.Add(this.gbPesquisa);
            this.gbPesquisaCliente.Location = new System.Drawing.Point(12, 225);
            this.gbPesquisaCliente.Name = "gbPesquisaCliente";
            this.gbPesquisaCliente.Size = new System.Drawing.Size(704, 310);
            this.gbPesquisaCliente.TabIndex = 48;
            this.gbPesquisaCliente.TabStop = false;
            this.gbPesquisaCliente.Text = "Pesquisa";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(573, 37);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(117, 23);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(191, 38);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(360, 22);
            this.txtpesquisa.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 14);
            this.label12.TabIndex = 2;
            this.label12.Text = "Digite o texto a ser pesquisado";
            // 
            // dgvPesquisaCliente
            // 
            this.dgvPesquisaCliente.AllowUserToAddRows = false;
            this.dgvPesquisaCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPesquisaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPesquisaCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPesquisaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPF,
            this.NOME,
            this.sobrenome,
            this.data_nascimento,
            this.email,
            this.endereco,
            this.bairro,
            this.cidade,
            this.ESTADO,
            this.Telefone,
            this.sexo,
            this.numero});
            this.dgvPesquisaCliente.Location = new System.Drawing.Point(6, 110);
            this.dgvPesquisaCliente.Name = "dgvPesquisaCliente";
            this.dgvPesquisaCliente.ReadOnly = true;
            this.dgvPesquisaCliente.Size = new System.Drawing.Size(684, 186);
            this.dgvPesquisaCliente.TabIndex = 1;
            this.dgvPesquisaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisaCliente_CellClick);
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CLI_CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "CLI_PRIMNOME";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // sobrenome
            // 
            this.sobrenome.DataPropertyName = "CLI_ULTNOME";
            this.sobrenome.HeaderText = "Sobrenome";
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.ReadOnly = true;
            // 
            // data_nascimento
            // 
            this.data_nascimento.DataPropertyName = "CLI_DATANASC";
            this.data_nascimento.HeaderText = "Data Nascimento";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "CLI_EMAIL";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "CLI_ENDERECO";
            this.endereco.HeaderText = "Endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "CLI_BAIRRO";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "CLI_CIDADE";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "CLI_ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 50;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "CLI_TELEFONE";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "CLI_SEXO";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 50;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "CLI_CASANUMERO";
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.rbnome);
            this.gbPesquisa.Controls.Add(this.rbCPF);
            this.gbPesquisa.Location = new System.Drawing.Point(6, 21);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(148, 83);
            this.gbPesquisa.TabIndex = 0;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Tipo de Pesquisa";
            // 
            // rbnome
            // 
            this.rbnome.AutoSize = true;
            this.rbnome.Checked = true;
            this.rbnome.Location = new System.Drawing.Point(7, 46);
            this.rbnome.Name = "rbnome";
            this.rbnome.Size = new System.Drawing.Size(61, 18);
            this.rbnome.TabIndex = 1;
            this.rbnome.TabStop = true;
            this.rbnome.Text = "Nome";
            this.rbnome.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(7, 22);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(49, 18);
            this.rbCPF.TabIndex = 0;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // txtcpf
            // 
            this.txtcpf.Enabled = false;
            this.txtcpf.Location = new System.Drawing.Point(16, 72);
            this.txtcpf.Mask = "999,999,999-99";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(108, 22);
            this.txtcpf.TabIndex = 0;
            this.txtcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtcpf.TextChanged += new System.EventHandler(this.txtcpf_TextChanged);
            // 
            // lbErroNome
            // 
            this.lbErroNome.AutoSize = true;
            this.lbErroNome.ForeColor = System.Drawing.Color.Red;
            this.lbErroNome.Location = new System.Drawing.Point(128, 94);
            this.lbErroNome.Name = "lbErroNome";
            this.lbErroNome.Size = new System.Drawing.Size(38, 14);
            this.lbErroNome.TabIndex = 49;
            this.lbErroNome.Text = "Erro:";
            this.lbErroNome.Visible = false;
            // 
            // lbErroSobre
            // 
            this.lbErroSobre.AutoSize = true;
            this.lbErroSobre.ForeColor = System.Drawing.Color.Red;
            this.lbErroSobre.Location = new System.Drawing.Point(349, 95);
            this.lbErroSobre.Name = "lbErroSobre";
            this.lbErroSobre.Size = new System.Drawing.Size(38, 14);
            this.lbErroSobre.TabIndex = 50;
            this.lbErroSobre.Text = "Erro:";
            this.lbErroSobre.Visible = false;
            // 
            // lbErroEnd
            // 
            this.lbErroEnd.AutoSize = true;
            this.lbErroEnd.ForeColor = System.Drawing.Color.Red;
            this.lbErroEnd.Location = new System.Drawing.Point(16, 148);
            this.lbErroEnd.Name = "lbErroEnd";
            this.lbErroEnd.Size = new System.Drawing.Size(38, 14);
            this.lbErroEnd.TabIndex = 51;
            this.lbErroEnd.Text = "Erro:";
            this.lbErroEnd.Visible = false;
            // 
            // lbErroCidade
            // 
            this.lbErroCidade.AutoSize = true;
            this.lbErroCidade.ForeColor = System.Drawing.Color.Red;
            this.lbErroCidade.Location = new System.Drawing.Point(526, 150);
            this.lbErroCidade.Name = "lbErroCidade";
            this.lbErroCidade.Size = new System.Drawing.Size(38, 14);
            this.lbErroCidade.TabIndex = 52;
            this.lbErroCidade.Text = "Erro:";
            this.lbErroCidade.Visible = false;
            // 
            // lbErroNum
            // 
            this.lbErroNum.AutoSize = true;
            this.lbErroNum.ForeColor = System.Drawing.Color.Red;
            this.lbErroNum.Location = new System.Drawing.Point(256, 148);
            this.lbErroNum.Name = "lbErroNum";
            this.lbErroNum.Size = new System.Drawing.Size(38, 14);
            this.lbErroNum.TabIndex = 53;
            this.lbErroNum.Text = "Erro:";
            this.lbErroNum.Visible = false;
            // 
            // lbErroBairro
            // 
            this.lbErroBairro.AutoSize = true;
            this.lbErroBairro.ForeColor = System.Drawing.Color.Red;
            this.lbErroBairro.Location = new System.Drawing.Point(352, 149);
            this.lbErroBairro.Name = "lbErroBairro";
            this.lbErroBairro.Size = new System.Drawing.Size(38, 14);
            this.lbErroBairro.TabIndex = 54;
            this.lbErroBairro.Text = "Erro:";
            this.lbErroBairro.Visible = false;
            // 
            // cBSexo
            // 
            this.cBSexo.Enabled = false;
            this.cBSexo.FormattingEnabled = true;
            this.cBSexo.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PR",
            "PB",
            "PA",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cBSexo.Location = new System.Drawing.Point(522, 71);
            this.cBSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBSexo.Name = "cBSexo";
            this.cBSexo.Size = new System.Drawing.Size(47, 22);
            this.cBSexo.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(520, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 14);
            this.label13.TabIndex = 56;
            this.label13.Text = "Sexo";
            this.label13.UseWaitCursor = true;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(67, 186);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(104, 22);
            this.txttelefone.TabIndex = 10;
            this.txttelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 563);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.cBSexo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbErroBairro);
            this.Controls.Add(this.lbErroNum);
            this.Controls.Add(this.lbErroCidade);
            this.Controls.Add(this.lbErroEnd);
            this.Controls.Add(this.lbErroSobre);
            this.Controls.Add(this.lbErroNome);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.gbPesquisaCliente);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpdatanasc);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbuf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sSRodape);
            this.Controls.Add(this.tSMenu);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tSMenu.ResumeLayout(false);
            this.tSMenu.PerformLayout();
            this.sSRodape.ResumeLayout(false);
            this.sSRodape.PerformLayout();
            this.gbPesquisaCliente.ResumeLayout(false);
            this.gbPesquisaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaCliente)).EndInit();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.StatusStrip sSRodape;
        private System.Windows.Forms.ToolStripStatusLabel lblMensagem;
        private System.Windows.Forms.DateTimePicker dtpdatanasc;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.GroupBox gbPesquisaCliente;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.DataGridView dgvPesquisaCliente;
        private System.Windows.Forms.RadioButton rbnome;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Label lbErroNome;
        private System.Windows.Forms.Label lbErroSobre;
        private System.Windows.Forms.Label lbErroEnd;
        private System.Windows.Forms.Label lbErroCidade;
        private System.Windows.Forms.Label lbErroNum;
        private System.Windows.Forms.Label lbErroBairro;
        private System.Windows.Forms.ComboBox cBSexo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txttelefone;
    }
}