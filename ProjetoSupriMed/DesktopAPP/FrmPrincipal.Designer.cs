namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tSMenuTopo = new System.Windows.Forms.ToolStrip();
            this.tSDDBCadastros = new System.Windows.Forms.ToolStripDropDownButton();
            this.setoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kkkkToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSDDBAgendamentos = new System.Windows.Forms.ToolStripDropDownButton();
            this.agendarVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSDDBVendas = new System.Windows.Forms.ToolStripDropDownButton();
            this.realizarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTSBLogout = new System.Windows.Forms.ToolStripButton();
            this.btnTSBSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSRodape = new System.Windows.Forms.StatusStrip();
            this.tSSLBemvindo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLExibiData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSSLExibirHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tSMenuTopo.SuspendLayout();
            this.sSRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSMenuTopo
            // 
            this.tSMenuTopo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSMenuTopo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSMenuTopo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSDDBCadastros,
            this.toolStripSeparator1,
            this.tSDDBAgendamentos,
            this.toolStripSeparator2,
            this.tSDDBVendas,
            this.toolStripSeparator3,
            this.btnTSBLogout,
            this.btnTSBSair,
            this.toolStripDropDownButton1});
            this.tSMenuTopo.Location = new System.Drawing.Point(0, 0);
            this.tSMenuTopo.Name = "tSMenuTopo";
            this.tSMenuTopo.Size = new System.Drawing.Size(1155, 39);
            this.tSMenuTopo.TabIndex = 0;
            this.tSMenuTopo.Text = "toolStrip1";
            // 
            // tSDDBCadastros
            // 
            this.tSDDBCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setoresToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.peçasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.kkkkToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.tSDDBCadastros.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSDDBCadastros.Image = global::ProjetoSupriMed.Properties.Resources.Register_Icon;
            this.tSDDBCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSDDBCadastros.Name = "tSDDBCadastros";
            this.tSDDBCadastros.Size = new System.Drawing.Size(87, 36);
            this.tSDDBCadastros.Text = "Cadastros";
            this.tSDDBCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // setoresToolStripMenuItem
            // 
            this.setoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setoresToolStripMenuItem.Image")));
            this.setoresToolStripMenuItem.Name = "setoresToolStripMenuItem";
            this.setoresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.setoresToolStripMenuItem.Text = "- Setores";
            this.setoresToolStripMenuItem.Click += new System.EventHandler(this.setoresToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.business_people_01;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.funcionariosToolStripMenuItem.Text = "- Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vendedoresToolStripMenuItem.Image")));
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.vendedoresToolStripMenuItem.Text = "- Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.user;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.clientesToolStripMenuItem.Text = "- Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.stethoscope;
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            this.peçasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.peçasToolStripMenuItem.Text = "- Peças";
            this.peçasToolStripMenuItem.Click += new System.EventHandler(this.peçasToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.diagram_v2_17;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.produtosToolStripMenuItem.Text = "- Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.user_group_new;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.loginToolStripMenuItem.Text = "- Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // kkkkToolStripMenuItem
            // 
            this.kkkkToolStripMenuItem.Name = "kkkkToolStripMenuItem";
            this.kkkkToolStripMenuItem.Size = new System.Drawing.Size(167, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.application_exit;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.logoutToolStripMenuItem.Text = "- Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.exit;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sairToolStripMenuItem.Text = "- Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tSDDBAgendamentos
            // 
            this.tSDDBAgendamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarVisitasToolStripMenuItem,
            this.consultarVisitasToolStripMenuItem});
            this.tSDDBAgendamentos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSDDBAgendamentos.Image = global::ProjetoSupriMed.Properties.Resources.agenda_1;
            this.tSDDBAgendamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSDDBAgendamentos.Name = "tSDDBAgendamentos";
            this.tSDDBAgendamentos.Size = new System.Drawing.Size(118, 36);
            this.tSDDBAgendamentos.Text = "Agendamentos";
            this.tSDDBAgendamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSDDBAgendamentos.Click += new System.EventHandler(this.tSDDBAgendamentos_Click);
            // 
            // agendarVisitasToolStripMenuItem
            // 
            this.agendarVisitasToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.date;
            this.agendarVisitasToolStripMenuItem.Name = "agendarVisitasToolStripMenuItem";
            this.agendarVisitasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.agendarVisitasToolStripMenuItem.Text = "- Agendar Visitas";
            this.agendarVisitasToolStripMenuItem.Click += new System.EventHandler(this.agendarVisitasToolStripMenuItem_Click);
            // 
            // consultarVisitasToolStripMenuItem
            // 
            this.consultarVisitasToolStripMenuItem.Image = global::ProjetoSupriMed.Properties.Resources.event_search_48;
            this.consultarVisitasToolStripMenuItem.Name = "consultarVisitasToolStripMenuItem";
            this.consultarVisitasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.consultarVisitasToolStripMenuItem.Text = "- Consultar Visitas";
            this.consultarVisitasToolStripMenuItem.Click += new System.EventHandler(this.consultarVisitasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tSDDBVendas
            // 
            this.tSDDBVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVendasToolStripMenuItem,
            this.consultarVendasToolStripMenuItem});
            this.tSDDBVendas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSDDBVendas.Image = global::ProjetoSupriMed.Properties.Resources.currency_dollar_blue;
            this.tSDDBVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSDDBVendas.Name = "tSDDBVendas";
            this.tSDDBVendas.Size = new System.Drawing.Size(68, 36);
            this.tSDDBVendas.Text = "Vendas";
            this.tSDDBVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSDDBVendas.ToolTipText = "Vendas";
            this.tSDDBVendas.Click += new System.EventHandler(this.tSDDBVendas_Click);
            // 
            // realizarVendasToolStripMenuItem
            // 
            this.realizarVendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("realizarVendasToolStripMenuItem.Image")));
            this.realizarVendasToolStripMenuItem.Name = "realizarVendasToolStripMenuItem";
            this.realizarVendasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.realizarVendasToolStripMenuItem.Text = "- Realizar Vendas";
            this.realizarVendasToolStripMenuItem.Click += new System.EventHandler(this.realizarVendasToolStripMenuItem_Click);
            // 
            // consultarVendasToolStripMenuItem
            // 
            this.consultarVendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarVendasToolStripMenuItem.Image")));
            this.consultarVendasToolStripMenuItem.Name = "consultarVendasToolStripMenuItem";
            this.consultarVendasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consultarVendasToolStripMenuItem.Text = "- Consultar Vendas";
            this.consultarVendasToolStripMenuItem.Click += new System.EventHandler(this.consultarVendasToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnTSBLogout
            // 
            this.btnTSBLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTSBLogout.Image = global::ProjetoSupriMed.Properties.Resources.application_exit;
            this.btnTSBLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTSBLogout.Name = "btnTSBLogout";
            this.btnTSBLogout.Size = new System.Drawing.Size(53, 36);
            this.btnTSBLogout.Text = "Logoff";
            this.btnTSBLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTSBLogout.Click += new System.EventHandler(this.btnTSBLogout_Click);
            // 
            // btnTSBSair
            // 
            this.btnTSBSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTSBSair.Image = global::ProjetoSupriMed.Properties.Resources.exit;
            this.btnTSBSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTSBSair.Name = "btnTSBSair";
            this.btnTSBSair.Size = new System.Drawing.Size(37, 36);
            this.btnTSBSair.Text = "Sair";
            this.btnTSBSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTSBSair.Click += new System.EventHandler(this.btnTSBSair_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(102, 36);
            this.toolStripDropDownButton1.Text = "Manutenção";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backupToolStripMenuItem.Image")));
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.backupToolStripMenuItem.Text = "- Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // sSRodape
            // 
            this.sSRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLBemvindo,
            this.tSSLUsuarioLogado,
            this.tSSLData,
            this.tSSLExibiData,
            this.tSSLHora,
            this.tSSSLExibirHora});
            this.sSRodape.Location = new System.Drawing.Point(0, 619);
            this.sSRodape.Name = "sSRodape";
            this.sSRodape.Size = new System.Drawing.Size(1155, 22);
            this.sSRodape.SizingGrip = false;
            this.sSRodape.TabIndex = 1;
            this.sSRodape.Text = "statusStrip1";
            this.sSRodape.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sSRodape_ItemClicked);
            // 
            // tSSLBemvindo
            // 
            this.tSSLBemvindo.Name = "tSSLBemvindo";
            this.tSSLBemvindo.Size = new System.Drawing.Size(67, 17);
            this.tSSLBemvindo.Text = "Bem-Vindo";
            // 
            // tSSLUsuarioLogado
            // 
            this.tSSLUsuarioLogado.Name = "tSSLUsuarioLogado";
            this.tSSLUsuarioLogado.Size = new System.Drawing.Size(0, 17);
            // 
            // tSSLData
            // 
            this.tSSLData.Name = "tSSLData";
            this.tSSLData.Size = new System.Drawing.Size(37, 17);
            this.tSSLData.Text = "Data.:";
            // 
            // tSSLExibiData
            // 
            this.tSSLExibiData.Name = "tSSLExibiData";
            this.tSSLExibiData.Size = new System.Drawing.Size(0, 17);
            // 
            // tSSLHora
            // 
            this.tSSLHora.Name = "tSSLHora";
            this.tSSLHora.Size = new System.Drawing.Size(47, 17);
            this.tSSLHora.Text = "- Hora.:";
            // 
            // tSSSLExibirHora
            // 
            this.tSSSLExibirHora.Name = "tSSSLExibirHora";
            this.tSSSLExibirHora.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoSupriMed.Properties.Resources.background_principal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 580);
            this.panel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1155, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sSRodape);
            this.Controls.Add(this.tSMenuTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::. Loja de Suprimentos Médicos ::.";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Click += new System.EventHandler(this.FrmPrincipal_Click);
            this.tSMenuTopo.ResumeLayout(false);
            this.tSMenuTopo.PerformLayout();
            this.sSRodape.ResumeLayout(false);
            this.sSRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmPrincipal_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ToolStrip tSMenuTopo;
        private System.Windows.Forms.StatusStrip sSRodape;
        private System.Windows.Forms.ToolStripStatusLabel tSSLBemvindo;
        private System.Windows.Forms.ToolStripStatusLabel tSSLUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel tSSLData;
        private System.Windows.Forms.ToolStripStatusLabel tSSLExibiData;
        private System.Windows.Forms.ToolStripDropDownButton tSDDBCadastros;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tSDDBAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem agendarVisitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVisitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tSDDBVendas;
        private System.Windows.Forms.ToolStripMenuItem realizarVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator kkkkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnTSBLogout;
        private System.Windows.Forms.ToolStripButton btnTSBSair;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tSSSLExibirHora;
        private System.Windows.Forms.ToolStripStatusLabel tSSLHora;
        private System.Windows.Forms.Timer timer1;
    }
}