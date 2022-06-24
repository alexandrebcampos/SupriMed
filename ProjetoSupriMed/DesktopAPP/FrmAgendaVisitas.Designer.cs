namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmAgendaVisitas
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
            this.lbCPF = new System.Windows.Forms.Label();
            this.cBCliente = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gBClientes = new System.Windows.Forms.GroupBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.gBVendedor = new System.Windows.Forms.GroupBox();
            this.cBVendedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gBAgendamento = new System.Windows.Forms.GroupBox();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.dTPHora = new System.Windows.Forms.DateTimePicker();
            this.dTPData = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBVendedor = new System.Windows.Forms.RadioButton();
            this.rBCliente = new System.Windows.Forms.RadioButton();
            this.gBClientes.SuspendLayout();
            this.gBVendedor.SuspendLayout();
            this.gBAgendamento.SuspendLayout();
            this.gBPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVExibirPesquisa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(10, 28);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(59, 16);
            this.lbCPF.TabIndex = 8;
            this.lbCPF.Text = "Cliente:";
            // 
            // cBCliente
            // 
            this.cBCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCliente.Location = new System.Drawing.Point(9, 47);
            this.cBCliente.Name = "cBCliente";
            this.cBCliente.Size = new System.Drawing.Size(208, 24);
            this.cBCliente.TabIndex = 7;
            this.cBCliente.SelectedValueChanged += new System.EventHandler(this.cBCPFCliente_SelectedValueChanged);
            this.cBCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBCPFCliente_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(223, 47);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(236, 23);
            this.txtEndereco.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Endereço:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(9, 94);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(119, 23);
            this.txtBairro.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "UF:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(189, 94);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(136, 23);
            this.txtTelefone.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefone:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(331, 94);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(79, 23);
            this.txtNumero.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Número:";
            // 
            // gBClientes
            // 
            this.gBClientes.Controls.Add(this.txtUF);
            this.gBClientes.Controls.Add(this.label6);
            this.gBClientes.Controls.Add(this.txtCidade);
            this.gBClientes.Controls.Add(this.cBCliente);
            this.gBClientes.Controls.Add(this.txtNumero);
            this.gBClientes.Controls.Add(this.lbCPF);
            this.gBClientes.Controls.Add(this.label5);
            this.gBClientes.Controls.Add(this.txtTelefone);
            this.gBClientes.Controls.Add(this.label1);
            this.gBClientes.Controls.Add(this.label4);
            this.gBClientes.Controls.Add(this.txtEndereco);
            this.gBClientes.Controls.Add(this.label3);
            this.gBClientes.Controls.Add(this.label2);
            this.gBClientes.Controls.Add(this.txtBairro);
            this.gBClientes.Enabled = false;
            this.gBClientes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBClientes.Location = new System.Drawing.Point(12, 53);
            this.gBClientes.Name = "gBClientes";
            this.gBClientes.Size = new System.Drawing.Size(725, 137);
            this.gBClientes.TabIndex = 21;
            this.gBClientes.TabStop = false;
            this.gBClientes.Text = "Informações do Cliente";
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(132, 94);
            this.txtUF.Name = "txtUF";
            this.txtUF.ReadOnly = true;
            this.txtUF.Size = new System.Drawing.Size(51, 23);
            this.txtUF.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(465, 47);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(162, 23);
            this.txtCidade.TabIndex = 22;
            // 
            // gBVendedor
            // 
            this.gBVendedor.Controls.Add(this.cBVendedor);
            this.gBVendedor.Controls.Add(this.label8);
            this.gBVendedor.Enabled = false;
            this.gBVendedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBVendedor.Location = new System.Drawing.Point(12, 195);
            this.gBVendedor.Name = "gBVendedor";
            this.gBVendedor.Size = new System.Drawing.Size(270, 83);
            this.gBVendedor.TabIndex = 22;
            this.gBVendedor.TabStop = false;
            this.gBVendedor.Text = "Informações do Vendedor";
            // 
            // cBVendedor
            // 
            this.cBVendedor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBVendedor.Location = new System.Drawing.Point(9, 42);
            this.cBVendedor.Name = "cBVendedor";
            this.cBVendedor.Size = new System.Drawing.Size(222, 24);
            this.cBVendedor.TabIndex = 11;
            this.cBVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBVendedor_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vendedor:";
            // 
            // gBAgendamento
            // 
            this.gBAgendamento.Controls.Add(this.txtDescrição);
            this.gBAgendamento.Controls.Add(this.dTPHora);
            this.gBAgendamento.Controls.Add(this.dTPData);
            this.gBAgendamento.Controls.Add(this.label12);
            this.gBAgendamento.Controls.Add(this.label11);
            this.gBAgendamento.Controls.Add(this.label10);
            this.gBAgendamento.Enabled = false;
            this.gBAgendamento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBAgendamento.Location = new System.Drawing.Point(12, 284);
            this.gBAgendamento.Name = "gBAgendamento";
            this.gBAgendamento.Size = new System.Drawing.Size(270, 192);
            this.gBAgendamento.TabIndex = 23;
            this.gBAgendamento.TabStop = false;
            this.gBAgendamento.Text = "Informações do Agendamento";
            // 
            // txtDescrição
            // 
            this.txtDescrição.Location = new System.Drawing.Point(13, 99);
            this.txtDescrição.MaxLength = 200;
            this.txtDescrição.Multiline = true;
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(246, 85);
            this.txtDescrição.TabIndex = 5;
            // 
            // dTPHora
            // 
            this.dTPHora.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPHora.Location = new System.Drawing.Point(139, 50);
            this.dTPHora.Name = "dTPHora";
            this.dTPHora.Size = new System.Drawing.Size(120, 23);
            this.dTPHora.TabIndex = 4;
            this.dTPHora.Value = new System.DateTime(2015, 11, 13, 22, 1, 0, 0);
            // 
            // dTPData
            // 
            this.dTPData.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPData.Location = new System.Drawing.Point(13, 50);
            this.dTPData.Name = "dTPData";
            this.dTPData.Size = new System.Drawing.Size(120, 23);
            this.dTPData.TabIndex = 3;
            this.dTPData.Value = new System.DateTime(2015, 11, 13, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(136, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Hora:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Descrição:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data:";
            // 
            // gBPesquisa
            // 
            this.gBPesquisa.Controls.Add(this.dGVExibirPesquisa);
            this.gBPesquisa.Controls.Add(this.btnPesquisar);
            this.gBPesquisa.Controls.Add(this.txtPesquisar);
            this.gBPesquisa.Controls.Add(this.lblDescricao);
            this.gBPesquisa.Controls.Add(this.groupBox1);
            this.gBPesquisa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPesquisa.Location = new System.Drawing.Point(289, 197);
            this.gBPesquisa.Name = "gBPesquisa";
            this.gBPesquisa.Size = new System.Drawing.Size(448, 279);
            this.gBPesquisa.TabIndex = 24;
            this.gBPesquisa.TabStop = false;
            this.gBPesquisa.Text = "Pesquisa";
            // 
            // dGVExibirPesquisa
            // 
            this.dGVExibirPesquisa.AllowUserToAddRows = false;
            this.dGVExibirPesquisa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVExibirPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVExibirPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVExibirPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVExibirPesquisa.Location = new System.Drawing.Point(6, 110);
            this.dGVExibirPesquisa.Name = "dGVExibirPesquisa";
            this.dGVExibirPesquisa.ReadOnly = true;
            this.dGVExibirPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVExibirPesquisa.Size = new System.Drawing.Size(436, 158);
            this.dGVExibirPesquisa.TabIndex = 13;
            this.dGVExibirPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVExibirPesquisa_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CLI_CPF";
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "VEND_ID";
            this.Column2.HeaderText = "Vendedor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VIS_DATA";
            this.Column3.HeaderText = "Data";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "VIS_HORA";
            this.Column4.HeaderText = "Hora";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "VIS_DESCRICAO";
            this.Column5.HeaderText = "Descrição";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(350, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 34);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(148, 47);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(193, 26);
            this.txtPesquisar.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(148, 27);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(295, 14);
            this.lblDescricao.TabIndex = 10;
            this.lblDescricao.Text = "Digite o texto a ser pesquisado e tecle ENTER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBVendedor);
            this.groupBox1.Controls.Add(this.rBCliente);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo da Pesquisa";
            // 
            // rBVendedor
            // 
            this.rBVendedor.AutoSize = true;
            this.rBVendedor.Location = new System.Drawing.Point(6, 47);
            this.rBVendedor.Name = "rBVendedor";
            this.rBVendedor.Size = new System.Drawing.Size(112, 20);
            this.rBVendedor.TabIndex = 1;
            this.rBVendedor.TabStop = true;
            this.rBVendedor.Text = "CodVendedor";
            this.rBVendedor.UseVisualStyleBackColor = true;
            // 
            // rBCliente
            // 
            this.rBCliente.AutoSize = true;
            this.rBCliente.Checked = true;
            this.rBCliente.Location = new System.Drawing.Point(7, 23);
            this.rBCliente.Name = "rBCliente";
            this.rBCliente.Size = new System.Drawing.Size(71, 20);
            this.rBCliente.TabIndex = 0;
            this.rBCliente.TabStop = true;
            this.rBCliente.Text = "Cliente";
            this.rBCliente.UseVisualStyleBackColor = true;
            // 
            // FrmAgendaVisitas
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(737, 503);
            this.Controls.Add(this.gBPesquisa);
            this.Controls.Add(this.gBAgendamento);
            this.Controls.Add(this.gBVendedor);
            this.Controls.Add(this.gBClientes);
            this.Name = "FrmAgendaVisitas";
            this.Text = "Agendamentos";
            this.Load += new System.EventHandler(this.FrmAgendaVisitas_Load);
            this.Controls.SetChildIndex(this.gBClientes, 0);
            this.Controls.SetChildIndex(this.gBVendedor, 0);
            this.Controls.SetChildIndex(this.gBAgendamento, 0);
            this.Controls.SetChildIndex(this.gBPesquisa, 0);
            this.gBClientes.ResumeLayout(false);
            this.gBClientes.PerformLayout();
            this.gBVendedor.ResumeLayout(false);
            this.gBVendedor.PerformLayout();
            this.gBAgendamento.ResumeLayout(false);
            this.gBAgendamento.PerformLayout();
            this.gBPesquisa.ResumeLayout(false);
            this.gBPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVExibirPesquisa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.ComboBox cBCliente;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gBClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox gBVendedor;
        private System.Windows.Forms.ComboBox cBVendedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gBAgendamento;
        private System.Windows.Forms.DateTimePicker dTPHora;
        private System.Windows.Forms.DateTimePicker dTPData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescrição;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.GroupBox gBPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBVendedor;
        private System.Windows.Forms.RadioButton rBCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DataGridView dGVExibirPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
