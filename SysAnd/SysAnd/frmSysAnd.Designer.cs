namespace SysAnd
{
    partial class frmSysAnd
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.mstrTop = new System.Windows.Forms.MenuStrip();
            this.dataEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garantiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoggin = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.mstrTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 534);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1472, 30);
            this.pnlFooter.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(573, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(363, 13);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "SysAnd v0.1 - Todos os direitos reservador - Desenvolvido por André Felipe";
            // 
            // mstrTop
            // 
            this.mstrTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEntradaToolStripMenuItem,
            this.garantiaToolStripMenuItem,
            this.peçasToolStripMenuItem,
            this.faturaToolStripMenuItem,
            this.transaçõesToolStripMenuItem});
            this.mstrTop.Location = new System.Drawing.Point(0, 0);
            this.mstrTop.Name = "mstrTop";
            this.mstrTop.Size = new System.Drawing.Size(1472, 24);
            this.mstrTop.TabIndex = 1;
            this.mstrTop.Text = "menuStrip1";
            // 
            // dataEntradaToolStripMenuItem
            // 
            this.dataEntradaToolStripMenuItem.Name = "dataEntradaToolStripMenuItem";
            this.dataEntradaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.dataEntradaToolStripMenuItem.Text = "Usuarios";
            this.dataEntradaToolStripMenuItem.Click += new System.EventHandler(this.dataEntradaToolStripMenuItem_Click);
            // 
            // garantiaToolStripMenuItem
            // 
            this.garantiaToolStripMenuItem.Name = "garantiaToolStripMenuItem";
            this.garantiaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.garantiaToolStripMenuItem.Text = "Categoria";
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            this.peçasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.peçasToolStripMenuItem.Text = "Produtos";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.faturaToolStripMenuItem.Text = "Inventario";
            // 
            // transaçõesToolStripMenuItem
            // 
            this.transaçõesToolStripMenuItem.Name = "transaçõesToolStripMenuItem";
            this.transaçõesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.transaçõesToolStripMenuItem.Text = "Transações";
            // 
            // lblLoggin
            // 
            this.lblLoggin.AutoSize = true;
            this.lblLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggin.Location = new System.Drawing.Point(102, 69);
            this.lblLoggin.Name = "lblLoggin";
            this.lblLoggin.Size = new System.Drawing.Size(146, 18);
            this.lblLoggin.TabIndex = 2;
            this.lblLoggin.Text = "andrbter@gmail.com";
            this.lblLoggin.Click += new System.EventHandler(this.lblLoggin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 63);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(84, 24);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Vendas - C#";
            // 
            // frmSysAnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggin);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.mstrTop);
            this.MainMenuStrip = this.mstrTop;
            this.Name = "frmSysAnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysAnd v0.1 - Painel Administrativo";
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.mstrTop.ResumeLayout(false);
            this.mstrTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.MenuStrip mstrTop;
        private System.Windows.Forms.ToolStripMenuItem dataEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garantiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaçõesToolStripMenuItem;
        private System.Windows.Forms.Label lblLoggin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
    }
}

