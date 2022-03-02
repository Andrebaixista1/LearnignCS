namespace SysAnd
{
    partial class frmUser
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
            this.mstrTop = new System.Windows.Forms.MenuStrip();
            this.dataEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garantiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLoggin = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.mstrTop.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrTop
            // 
            this.mstrTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEntradaToolStripMenuItem,
            this.garantiaToolStripMenuItem,
            this.peçasToolStripMenuItem});
            this.mstrTop.Location = new System.Drawing.Point(0, 0);
            this.mstrTop.Name = "mstrTop";
            this.mstrTop.Size = new System.Drawing.Size(1475, 24);
            this.mstrTop.TabIndex = 6;
            this.mstrTop.Text = "menuStrip1Top";
            // 
            // dataEntradaToolStripMenuItem
            // 
            this.dataEntradaToolStripMenuItem.Name = "dataEntradaToolStripMenuItem";
            this.dataEntradaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.dataEntradaToolStripMenuItem.Text = "Comprar";
            // 
            // garantiaToolStripMenuItem
            // 
            this.garantiaToolStripMenuItem.Name = "garantiaToolStripMenuItem";
            this.garantiaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.garantiaToolStripMenuItem.Text = "Venda";
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            this.peçasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.peçasToolStripMenuItem.Text = "Inventário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sistema de Vendas - C#";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 63);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(84, 24);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Usuario: ";
            // 
            // lblLoggin
            // 
            this.lblLoggin.AutoSize = true;
            this.lblLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggin.Location = new System.Drawing.Point(102, 69);
            this.lblLoggin.Name = "lblLoggin";
            this.lblLoggin.Size = new System.Drawing.Size(146, 18);
            this.lblLoggin.TabIndex = 7;
            this.lblLoggin.Text = "andrbter@gmail.com";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 617);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1475, 30);
            this.pnlFooter.TabIndex = 5;
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
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 647);
            this.Controls.Add(this.mstrTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggin);
            this.Controls.Add(this.pnlFooter);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Loggin";
            this.mstrTop.ResumeLayout(false);
            this.mstrTop.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrTop;
        private System.Windows.Forms.ToolStripMenuItem dataEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garantiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoggin;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
    }
}