namespace WindowsFormsApp1
{
    partial class ventanaObj
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
            this.listBoxIzq = new System.Windows.Forms.ListBox();
            this.listBoxDer = new System.Windows.Forms.ListBox();
            this.btnAllListaDer = new System.Windows.Forms.Button();
            this.btn1ListaDer = new System.Windows.Forms.Button();
            this.btn1ListaIzq = new System.Windows.Forms.Button();
            this.btnDelListaIzq = new System.Windows.Forms.Button();
            this.lblNombreObj = new System.Windows.Forms.Label();
            this.txtBoxNomObj = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIzq
            // 
            this.listBoxIzq.FormattingEnabled = true;
            this.listBoxIzq.Location = new System.Drawing.Point(12, 12);
            this.listBoxIzq.Name = "listBoxIzq";
            this.listBoxIzq.Size = new System.Drawing.Size(181, 277);
            this.listBoxIzq.TabIndex = 0;
            // 
            // listBoxDer
            // 
            this.listBoxDer.FormattingEnabled = true;
            this.listBoxDer.Location = new System.Drawing.Point(280, 12);
            this.listBoxDer.Name = "listBoxDer";
            this.listBoxDer.Size = new System.Drawing.Size(201, 277);
            this.listBoxDer.TabIndex = 1;
            // 
            // btnAllListaDer
            // 
            this.btnAllListaDer.Location = new System.Drawing.Point(199, 30);
            this.btnAllListaDer.Name = "btnAllListaDer";
            this.btnAllListaDer.Size = new System.Drawing.Size(75, 23);
            this.btnAllListaDer.TabIndex = 2;
            this.btnAllListaDer.Text = ">>";
            this.btnAllListaDer.UseVisualStyleBackColor = true;
            this.btnAllListaDer.Click += new System.EventHandler(this.btnAllListaDer_Click);
            // 
            // btn1ListaDer
            // 
            this.btn1ListaDer.Location = new System.Drawing.Point(199, 59);
            this.btn1ListaDer.Name = "btn1ListaDer";
            this.btn1ListaDer.Size = new System.Drawing.Size(75, 23);
            this.btn1ListaDer.TabIndex = 3;
            this.btn1ListaDer.Text = ">";
            this.btn1ListaDer.UseVisualStyleBackColor = true;
            this.btn1ListaDer.Click += new System.EventHandler(this.btn1ListaDer_Click);
            // 
            // btn1ListaIzq
            // 
            this.btn1ListaIzq.Location = new System.Drawing.Point(199, 88);
            this.btn1ListaIzq.Name = "btn1ListaIzq";
            this.btn1ListaIzq.Size = new System.Drawing.Size(75, 23);
            this.btn1ListaIzq.TabIndex = 4;
            this.btn1ListaIzq.Text = "<";
            this.btn1ListaIzq.UseVisualStyleBackColor = true;
            this.btn1ListaIzq.Click += new System.EventHandler(this.btn1ListaIzq_Click);
            // 
            // btnDelListaIzq
            // 
            this.btnDelListaIzq.Location = new System.Drawing.Point(199, 117);
            this.btnDelListaIzq.Name = "btnDelListaIzq";
            this.btnDelListaIzq.Size = new System.Drawing.Size(75, 23);
            this.btnDelListaIzq.TabIndex = 5;
            this.btnDelListaIzq.Text = "...";
            this.btnDelListaIzq.UseVisualStyleBackColor = true;
            this.btnDelListaIzq.Click += new System.EventHandler(this.btnDelListaIzq_Click);
            // 
            // lblNombreObj
            // 
            this.lblNombreObj.AutoSize = true;
            this.lblNombreObj.Location = new System.Drawing.Point(43, 325);
            this.lblNombreObj.Name = "lblNombreObj";
            this.lblNombreObj.Size = new System.Drawing.Size(81, 13);
            this.lblNombreObj.TabIndex = 6;
            this.lblNombreObj.Text = "Nombre Objeto:";
            // 
            // txtBoxNomObj
            // 
            this.txtBoxNomObj.Location = new System.Drawing.Point(130, 322);
            this.txtBoxNomObj.Name = "txtBoxNomObj";
            this.txtBoxNomObj.Size = new System.Drawing.Size(175, 20);
            this.txtBoxNomObj.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(312, 322);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ventanaObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 362);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBoxNomObj);
            this.Controls.Add(this.lblNombreObj);
            this.Controls.Add(this.btnDelListaIzq);
            this.Controls.Add(this.btn1ListaIzq);
            this.Controls.Add(this.btn1ListaDer);
            this.Controls.Add(this.btnAllListaDer);
            this.Controls.Add(this.listBoxDer);
            this.Controls.Add(this.listBoxIzq);
            this.Name = "ventanaObj";
            this.Text = "Objetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIzq;
        private System.Windows.Forms.ListBox listBoxDer;
        private System.Windows.Forms.Button btnAllListaDer;
        private System.Windows.Forms.Button btn1ListaDer;
        private System.Windows.Forms.Button btn1ListaIzq;
        private System.Windows.Forms.Button btnDelListaIzq;
        private System.Windows.Forms.Label lblNombreObj;
        private System.Windows.Forms.TextBox txtBoxNomObj;
        private System.Windows.Forms.Button btnAgregar;
    }
}