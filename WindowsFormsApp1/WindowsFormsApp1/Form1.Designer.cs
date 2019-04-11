namespace WindowsFormsApp1
{
    partial class ventanaPpll
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lISTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuObjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTADOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lISTADOSToolStripMenuItem
            // 
            this.lISTADOSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lISTADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuPersonas,
            this.btnMenuObjetos});
            this.lISTADOSToolStripMenuItem.Name = "lISTADOSToolStripMenuItem";
            this.lISTADOSToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.lISTADOSToolStripMenuItem.Text = "LISTADOS";
            // 
            // btnMenuPersonas
            // 
            this.btnMenuPersonas.Name = "btnMenuPersonas";
            this.btnMenuPersonas.Size = new System.Drawing.Size(180, 22);
            this.btnMenuPersonas.Text = "PERSONAS";
            this.btnMenuPersonas.Click += new System.EventHandler(this.btnMenuPersonas_Click);
            // 
            // btnMenuObjetos
            // 
            this.btnMenuObjetos.Name = "btnMenuObjetos";
            this.btnMenuObjetos.Size = new System.Drawing.Size(180, 22);
            this.btnMenuObjetos.Text = "OBJETOS";
            this.btnMenuObjetos.Click += new System.EventHandler(this.btnMenuObjetos_Click);
            // 
            // ventanaPpll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 682);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ventanaPpll";
            this.Text = "TP WFA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lISTADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuPersonas;
        private System.Windows.Forms.ToolStripMenuItem btnMenuObjetos;
    }
}

