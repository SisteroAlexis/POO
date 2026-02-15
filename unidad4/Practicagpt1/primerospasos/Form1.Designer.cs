namespace primerospasos
{
    partial class Form1
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblEsperando = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.chbBlack = new System.Windows.Forms.CheckBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(12, 23);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(86, 39);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEsperando
            // 
            this.lblEsperando.AutoSize = true;
            this.lblEsperando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperando.Location = new System.Drawing.Point(285, 37);
            this.lblEsperando.Name = "lblEsperando";
            this.lblEsperando.Size = new System.Drawing.Size(116, 25);
            this.lblEsperando.TabIndex = 1;
            this.lblEsperando.Text = "Esperando";
            this.lblEsperando.Click += new System.EventHandler(this.lblEsperando_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(134, 97);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(111, 54);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 113);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(61, 22);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(290, 113);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(61, 22);
            this.txt2.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(142, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // chbBlack
            // 
            this.chbBlack.AutoSize = true;
            this.chbBlack.Location = new System.Drawing.Point(12, 190);
            this.chbBlack.Name = "chbBlack";
            this.chbBlack.Size = new System.Drawing.Size(95, 20);
            this.chbBlack.TabIndex = 7;
            this.chbBlack.Text = "checkBox1";
            this.chbBlack.UseVisualStyleBackColor = true;
            this.chbBlack.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(787, 37);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 84);
            this.lb1.TabIndex = 8;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(681, 69);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 22);
            this.txt3.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(579, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 31);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(455, 69);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 22);
            this.txt4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.chbBlack);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEsperando);
            this.Controls.Add(this.btnSaludar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label lblEsperando;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckBox chbBlack;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label1;
    }
}

