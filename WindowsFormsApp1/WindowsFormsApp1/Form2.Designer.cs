namespace WindowsFormsApp1
{
    partial class ventanaPersonas
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
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.grpBoxSex = new System.Windows.Forms.GroupBox();
            this.radBtnMasc = new System.Windows.Forms.RadioButton();
            this.radBtnFem = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.radBtnOtro = new System.Windows.Forms.RadioButton();
            this.grpBoxGen = new System.Windows.Forms.GroupBox();
            this.chkBoxJazz = new System.Windows.Forms.CheckBox();
            this.chkBoxCountry = new System.Windows.Forms.CheckBox();
            this.chkBoxPop = new System.Windows.Forms.CheckBox();
            this.chkBoxRock = new System.Windows.Forms.CheckBox();
            this.combBoxColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.grpBoxSex.SuspendLayout();
            this.grpBoxGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(280, 24);
            this.txtBoxNombre.MaxLength = 30;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 0;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(280, 50);
            this.txtBoxApellido.MaxLength = 30;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(626, 57);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad :";
            // 
            // grpBoxSex
            // 
            this.grpBoxSex.Controls.Add(this.radBtnOtro);
            this.grpBoxSex.Controls.Add(this.radBtnFem);
            this.grpBoxSex.Controls.Add(this.radBtnMasc);
            this.grpBoxSex.Location = new System.Drawing.Point(247, 85);
            this.grpBoxSex.Name = "grpBoxSex";
            this.grpBoxSex.Size = new System.Drawing.Size(218, 64);
            this.grpBoxSex.TabIndex = 4;
            this.grpBoxSex.TabStop = false;
            this.grpBoxSex.Text = "Sexo";
            // 
            // radBtnMasc
            // 
            this.radBtnMasc.AutoSize = true;
            this.radBtnMasc.Location = new System.Drawing.Point(15, 19);
            this.radBtnMasc.Name = "radBtnMasc";
            this.radBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.radBtnMasc.TabIndex = 0;
            this.radBtnMasc.TabStop = true;
            this.radBtnMasc.Text = "Masculino";
            this.radBtnMasc.UseVisualStyleBackColor = true;
            // 
            // radBtnFem
            // 
            this.radBtnFem.AutoSize = true;
            this.radBtnFem.Location = new System.Drawing.Point(107, 19);
            this.radBtnFem.Name = "radBtnFem";
            this.radBtnFem.Size = new System.Drawing.Size(71, 17);
            this.radBtnFem.TabIndex = 1;
            this.radBtnFem.TabStop = true;
            this.radBtnFem.Text = "Femenino";
            this.radBtnFem.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(227, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(227, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // radBtnOtro
            // 
            this.radBtnOtro.AutoSize = true;
            this.radBtnOtro.Location = new System.Drawing.Point(15, 42);
            this.radBtnOtro.Name = "radBtnOtro";
            this.radBtnOtro.Size = new System.Drawing.Size(45, 17);
            this.radBtnOtro.TabIndex = 2;
            this.radBtnOtro.TabStop = true;
            this.radBtnOtro.Text = "Otro";
            this.radBtnOtro.UseVisualStyleBackColor = true;
            // 
            // grpBoxGen
            // 
            this.grpBoxGen.Controls.Add(this.chkBoxRock);
            this.grpBoxGen.Controls.Add(this.chkBoxPop);
            this.grpBoxGen.Controls.Add(this.chkBoxCountry);
            this.grpBoxGen.Controls.Add(this.chkBoxJazz);
            this.grpBoxGen.Location = new System.Drawing.Point(474, 85);
            this.grpBoxGen.Name = "grpBoxGen";
            this.grpBoxGen.Size = new System.Drawing.Size(222, 64);
            this.grpBoxGen.TabIndex = 7;
            this.grpBoxGen.TabStop = false;
            this.grpBoxGen.Text = "Generos Musicales";
            // 
            // chkBoxJazz
            // 
            this.chkBoxJazz.AutoSize = true;
            this.chkBoxJazz.Location = new System.Drawing.Point(7, 19);
            this.chkBoxJazz.Name = "chkBoxJazz";
            this.chkBoxJazz.Size = new System.Drawing.Size(47, 17);
            this.chkBoxJazz.TabIndex = 0;
            this.chkBoxJazz.Text = "Jazz";
            this.chkBoxJazz.UseVisualStyleBackColor = true;
            // 
            // chkBoxCountry
            // 
            this.chkBoxCountry.AutoSize = true;
            this.chkBoxCountry.Location = new System.Drawing.Point(94, 20);
            this.chkBoxCountry.Name = "chkBoxCountry";
            this.chkBoxCountry.Size = new System.Drawing.Size(62, 17);
            this.chkBoxCountry.TabIndex = 1;
            this.chkBoxCountry.Text = "Country";
            this.chkBoxCountry.UseVisualStyleBackColor = true;
            // 
            // chkBoxPop
            // 
            this.chkBoxPop.AutoSize = true;
            this.chkBoxPop.Location = new System.Drawing.Point(7, 42);
            this.chkBoxPop.Name = "chkBoxPop";
            this.chkBoxPop.Size = new System.Drawing.Size(45, 17);
            this.chkBoxPop.TabIndex = 2;
            this.chkBoxPop.Text = "Pop";
            this.chkBoxPop.UseVisualStyleBackColor = true;
            // 
            // chkBoxRock
            // 
            this.chkBoxRock.AutoSize = true;
            this.chkBoxRock.Location = new System.Drawing.Point(94, 42);
            this.chkBoxRock.Name = "chkBoxRock";
            this.chkBoxRock.Size = new System.Drawing.Size(52, 17);
            this.chkBoxRock.TabIndex = 3;
            this.chkBoxRock.Text = "Rock";
            this.chkBoxRock.UseVisualStyleBackColor = true;
            // 
            // combBoxColor
            // 
            this.combBoxColor.FormattingEnabled = true;
            this.combBoxColor.Location = new System.Drawing.Point(262, 183);
            this.combBoxColor.Name = "combBoxColor";
            this.combBoxColor.Size = new System.Drawing.Size(203, 21);
            this.combBoxColor.TabIndex = 8;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(262, 164);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color Favorito";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(45, 232);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(826, 235);
            this.dgvPersonas.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(492, 183);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(580, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(382, 492);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 13;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnElim
            // 
            this.btnElim.Location = new System.Drawing.Point(463, 492);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(75, 23);
            this.btnElim.TabIndex = 14;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(417, 31);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNac.TabIndex = 15;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // ventanaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 527);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.combBoxColor);
            this.Controls.Add(this.grpBoxGen);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.grpBoxSex);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "ventanaPersonas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.ventanaPersonas_Load);
            this.grpBoxSex.ResumeLayout(false);
            this.grpBoxSex.PerformLayout();
            this.grpBoxGen.ResumeLayout(false);
            this.grpBoxGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox grpBoxSex;
        private System.Windows.Forms.RadioButton radBtnOtro;
        private System.Windows.Forms.RadioButton radBtnFem;
        private System.Windows.Forms.RadioButton radBtnMasc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox grpBoxGen;
        private System.Windows.Forms.CheckBox chkBoxRock;
        private System.Windows.Forms.CheckBox chkBoxPop;
        private System.Windows.Forms.CheckBox chkBoxCountry;
        private System.Windows.Forms.CheckBox chkBoxJazz;
        private System.Windows.Forms.ComboBox combBoxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Label lblFechaNac;
    }
}