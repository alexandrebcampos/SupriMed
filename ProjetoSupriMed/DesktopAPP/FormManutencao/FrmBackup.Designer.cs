namespace ProjetoSupriMed.DesktopAPP.FormManutencao
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.gBSelecionar = new System.Windows.Forms.GroupBox();
            this.cBDataBase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBBackup = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lbLocal = new System.Windows.Forms.Label();
            this.gBSelecionar.SuspendLayout();
            this.gBBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSelecionar
            // 
            this.gBSelecionar.Controls.Add(this.cBDataBase);
            this.gBSelecionar.Controls.Add(this.label1);
            this.gBSelecionar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSelecionar.Location = new System.Drawing.Point(12, 12);
            this.gBSelecionar.Name = "gBSelecionar";
            this.gBSelecionar.Size = new System.Drawing.Size(590, 75);
            this.gBSelecionar.TabIndex = 1;
            this.gBSelecionar.TabStop = false;
            this.gBSelecionar.Text = "Base de Dados";
            // 
            // cBDataBase
            // 
            this.cBDataBase.FormattingEnabled = true;
            this.cBDataBase.Location = new System.Drawing.Point(147, 28);
            this.cBDataBase.Name = "cBDataBase";
            this.cBDataBase.Size = new System.Drawing.Size(305, 26);
            this.cBDataBase.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Base de Dados:";
            // 
            // gBBackup
            // 
            this.gBBackup.Controls.Add(this.btnBackup);
            this.gBBackup.Controls.Add(this.txtLocal);
            this.gBBackup.Controls.Add(this.btnProcurar);
            this.gBBackup.Controls.Add(this.lbLocal);
            this.gBBackup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBBackup.Location = new System.Drawing.Point(12, 105);
            this.gBBackup.Name = "gBBackup";
            this.gBBackup.Size = new System.Drawing.Size(590, 114);
            this.gBBackup.TabIndex = 2;
            this.gBBackup.TabStop = false;
            this.gBBackup.Text = "Backup";
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(480, 67);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(102, 36);
            this.btnBackup.TabIndex = 9;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(147, 48);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(305, 27);
            this.txtLocal.TabIndex = 11;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(480, 15);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(102, 31);
            this.btnProcurar.TabIndex = 8;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocal.Location = new System.Drawing.Point(21, 53);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(48, 16);
            this.lbLocal.TabIndex = 10;
            this.lbLocal.Text = "Local:";
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(615, 243);
            this.Controls.Add(this.gBBackup);
            this.Controls.Add(this.gBSelecionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Backup ::";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.gBSelecionar.ResumeLayout(false);
            this.gBSelecionar.PerformLayout();
            this.gBBackup.ResumeLayout(false);
            this.gBBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.ComboBox cBDataBase;
    }
}