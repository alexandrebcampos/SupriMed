namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.gpBPesquisa = new System.Windows.Forms.GroupBox();
            this.pesqcpf = new System.Windows.Forms.MaskedTextBox();
            this.bntPesquisa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgvPesquisa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSetId = new System.Windows.Forms.ComboBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbErro = new System.Windows.Forms.Label();
            this.lbeErro = new System.Windows.Forms.Label();
            this.lbErroEdn = new System.Windows.Forms.Label();
            this.lbBrErro = new System.Windows.Forms.Label();
            this.lbErroCit = new System.Windows.Forms.Label();
            this.lbSaErro = new System.Windows.Forms.Label();
            this.gpBPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(76, 198);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(138, 20);
            this.txttelefone.TabIndex = 9;
            // 
            // gpBPesquisa
            // 
            this.gpBPesquisa.Controls.Add(this.pesqcpf);
            this.gpBPesquisa.Controls.Add(this.bntPesquisa);
            this.gpBPesquisa.Controls.Add(this.label11);
            this.gpBPesquisa.Controls.Add(this.dtgvPesquisa);
            this.gpBPesquisa.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.gpBPesquisa.Location = new System.Drawing.Point(12, 240);
            this.gpBPesquisa.Name = "gpBPesquisa";
            this.gpBPesquisa.Size = new System.Drawing.Size(520, 265);
            this.gpBPesquisa.TabIndex = 79;
            this.gpBPesquisa.TabStop = false;
            this.gpBPesquisa.Text = "Pesquisa: ";
            // 
            // pesqcpf
            // 
            this.pesqcpf.Location = new System.Drawing.Point(19, 38);
            this.pesqcpf.Mask = "999,999,999-99";
            this.pesqcpf.Name = "pesqcpf";
            this.pesqcpf.Size = new System.Drawing.Size(124, 23);
            this.pesqcpf.TabIndex = 62;
            this.pesqcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bntPesquisa
            // 
            this.bntPesquisa.Location = new System.Drawing.Point(153, 38);
            this.bntPesquisa.Name = "bntPesquisa";
            this.bntPesquisa.Size = new System.Drawing.Size(75, 23);
            this.bntPesquisa.TabIndex = 61;
            this.bntPesquisa.Text = "Pesquisa";
            this.bntPesquisa.UseVisualStyleBackColor = true;
            this.bntPesquisa.Click += new System.EventHandler(this.bntPesquisa_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = "CPF:";
            // 
            // dtgvPesquisa
            // 
            this.dtgvPesquisa.AllowUserToAddRows = false;
            this.dtgvPesquisa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPesquisa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dtgvPesquisa.Location = new System.Drawing.Point(6, 79);
            this.dtgvPesquisa.Name = "dtgvPesquisa";
            this.dtgvPesquisa.Size = new System.Drawing.Size(508, 180);
            this.dtgvPesquisa.TabIndex = 55;
            this.dtgvPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPesquisa_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FUNC_CPF";
            this.Column1.HeaderText = "CPF";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FUNC_NOME";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FUNC_DATANASC";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Nascimento";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FUNC_EMAIL";
            this.Column4.HeaderText = "E-mail";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FUNC_ENDERECO";
            this.Column5.HeaderText = "Endereço";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FUNC_BAIRRO";
            this.Column6.HeaderText = "Bairro";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FUNC_CIDADE";
            this.Column7.HeaderText = "Cidade";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "FUNC_ESTADO";
            this.Column8.HeaderText = "UF";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "FUNC_TELEFONE";
            this.Column9.HeaderText = "Telefone";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SET_ID";
            this.Column10.HeaderText = "Setor";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "FUNC_SALARIO";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column11.HeaderText = "Salário";
            this.Column11.Name = "Column11";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(12, 72);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(77, 20);
            this.mtbCpf.TabIndex = 1;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCpf.TextChanged += new System.EventHandler(this.mtbCpf_TextChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.Enabled = false;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
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
            this.cbEstado.Location = new System.Drawing.Point(12, 197);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(56, 21);
            this.cbEstado.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(382, 198);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(83, 20);
            this.txtSalario.TabIndex = 11;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(248, 133);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(153, 20);
            this.txtBairro.TabIndex = 6;
            this.txtBairro.Validating += new System.ComponentModel.CancelEventHandler(this.txtBairro_Validating);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(409, 132);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(108, 20);
            this.txtCidade.TabIndex = 7;
            this.txtCidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtCidade_Validating);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(11, 133);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(229, 20);
            this.txtEndereco.TabIndex = 5;
            this.txtEndereco.Validating += new System.ComponentModel.CancelEventHandler(this.txtEndereco_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(354, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(379, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "Salario: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 69;
            this.label9.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 67;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Email:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(219, 176);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 16);
            this.label.TabIndex = 63;
            this.label.Text = "Setor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "CPF:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(248, 72);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(98, 20);
            this.dtpDataNascimento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nascimento:";
            // 
            // cbSetId
            // 
            this.cbSetId.Location = new System.Drawing.Point(222, 198);
            this.cbSetId.Name = "cbSetId";
            this.cbSetId.Size = new System.Drawing.Size(151, 21);
            this.cbSetId.TabIndex = 10;
            this.cbSetId.SelectedValueChanged += new System.EventHandler(this.cbSetId_SelectedValueChanged);
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(94, 49);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(50, 16);
            this.lbCPF.TabIndex = 58;
            this.lbCPF.Text = "Nome:";
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErro.ForeColor = System.Drawing.Color.Red;
            this.lbErro.Location = new System.Drawing.Point(94, 94);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(40, 16);
            this.lbErro.TabIndex = 83;
            this.lbErro.Text = "Erro:";
            this.lbErro.Visible = false;
            // 
            // lbeErro
            // 
            this.lbeErro.AutoSize = true;
            this.lbeErro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeErro.ForeColor = System.Drawing.Color.Red;
            this.lbeErro.Location = new System.Drawing.Point(354, 95);
            this.lbeErro.Name = "lbeErro";
            this.lbeErro.Size = new System.Drawing.Size(40, 16);
            this.lbeErro.TabIndex = 84;
            this.lbeErro.Text = "Erro:";
            this.lbeErro.Visible = false;
            // 
            // lbErroEdn
            // 
            this.lbErroEdn.AutoSize = true;
            this.lbErroEdn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErroEdn.ForeColor = System.Drawing.Color.Red;
            this.lbErroEdn.Location = new System.Drawing.Point(9, 155);
            this.lbErroEdn.Name = "lbErroEdn";
            this.lbErroEdn.Size = new System.Drawing.Size(40, 16);
            this.lbErroEdn.TabIndex = 85;
            this.lbErroEdn.Text = "Erro:";
            this.lbErroEdn.Visible = false;
            // 
            // lbBrErro
            // 
            this.lbBrErro.AutoSize = true;
            this.lbBrErro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrErro.ForeColor = System.Drawing.Color.Red;
            this.lbBrErro.Location = new System.Drawing.Point(245, 155);
            this.lbBrErro.Name = "lbBrErro";
            this.lbBrErro.Size = new System.Drawing.Size(40, 16);
            this.lbBrErro.TabIndex = 86;
            this.lbBrErro.Text = "Erro:";
            this.lbBrErro.Visible = false;
            // 
            // lbErroCit
            // 
            this.lbErroCit.AutoSize = true;
            this.lbErroCit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErroCit.ForeColor = System.Drawing.Color.Red;
            this.lbErroCit.Location = new System.Drawing.Point(407, 155);
            this.lbErroCit.Name = "lbErroCit";
            this.lbErroCit.Size = new System.Drawing.Size(40, 16);
            this.lbErroCit.TabIndex = 87;
            this.lbErroCit.Text = "Erro:";
            this.lbErroCit.Visible = false;
            // 
            // lbSaErro
            // 
            this.lbSaErro.AutoSize = true;
            this.lbSaErro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaErro.ForeColor = System.Drawing.Color.Red;
            this.lbSaErro.Location = new System.Drawing.Point(379, 221);
            this.lbSaErro.Name = "lbSaErro";
            this.lbSaErro.Size = new System.Drawing.Size(40, 16);
            this.lbSaErro.TabIndex = 88;
            this.lbSaErro.Text = "Erro:";
            this.lbSaErro.Visible = false;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 530);
            this.Controls.Add(this.lbSaErro);
            this.Controls.Add(this.lbErroCit);
            this.Controls.Add(this.lbBrErro);
            this.Controls.Add(this.lbErroEdn);
            this.Controls.Add(this.lbeErro);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.gpBPesquisa);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSetId);
            this.Controls.Add(this.lbCPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuncionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.Controls.SetChildIndex(this.lbCPF, 0);
            this.Controls.SetChildIndex(this.cbSetId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtpDataNascimento, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtEndereco, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtBairro, 0);
            this.Controls.SetChildIndex(this.txtSalario, 0);
            this.Controls.SetChildIndex(this.cbEstado, 0);
            this.Controls.SetChildIndex(this.mtbCpf, 0);
            this.Controls.SetChildIndex(this.gpBPesquisa, 0);
            this.Controls.SetChildIndex(this.txttelefone, 0);
            this.Controls.SetChildIndex(this.lbErro, 0);
            this.Controls.SetChildIndex(this.lbeErro, 0);
            this.Controls.SetChildIndex(this.lbErroEdn, 0);
            this.Controls.SetChildIndex(this.lbBrErro, 0);
            this.Controls.SetChildIndex(this.lbErroCit, 0);
            this.Controls.SetChildIndex(this.lbSaErro, 0);
            this.gpBPesquisa.ResumeLayout(false);
            this.gpBPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.GroupBox gpBPesquisa;
        private System.Windows.Forms.DataGridView dtgvPesquisa;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSetId;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbErro;
        private System.Windows.Forms.Label lbeErro;
        private System.Windows.Forms.Label lbErroEdn;
        private System.Windows.Forms.Label lbBrErro;
        private System.Windows.Forms.Label lbErroCit;
        private System.Windows.Forms.Label lbSaErro;
        private System.Windows.Forms.MaskedTextBox pesqcpf;
        private System.Windows.Forms.Button bntPesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}