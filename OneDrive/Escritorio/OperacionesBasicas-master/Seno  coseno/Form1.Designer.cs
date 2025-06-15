namespace Seno_y_coseno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularSeno = new System.Windows.Forms.Button();
            this.btnCalcularCoseno = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblCosenoAngulo = new System.Windows.Forms.Label();
            this.lblSenoAngulo = new System.Windows.Forms.Label();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAngulo);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Location = new System.Drawing.Point(47, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 90);
            this.panel1.TabIndex = 0;
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAngulo.Location = new System.Drawing.Point(23, 35);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(143, 16);
            this.lblAngulo.TabIndex = 1;
            this.lblAngulo.Text = "Angulo (en Radianes) :";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(194, 35);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(176, 20);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos de entrada";
            // 
            // btnCalcularSeno
            // 
            this.btnCalcularSeno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcularSeno.Location = new System.Drawing.Point(0, 0);
            this.btnCalcularSeno.Name = "btnCalcularSeno";
            this.btnCalcularSeno.Size = new System.Drawing.Size(154, 73);
            this.btnCalcularSeno.TabIndex = 2;
            this.btnCalcularSeno.Text = "Calcular Seno";
            this.btnCalcularSeno.UseVisualStyleBackColor = true;
            this.btnCalcularSeno.Click += new System.EventHandler(this.btnCalcularSeno_Click);
            // 
            // btnCalcularCoseno
            // 
            this.btnCalcularCoseno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcularCoseno.Location = new System.Drawing.Point(0, 73);
            this.btnCalcularCoseno.Name = "btnCalcularCoseno";
            this.btnCalcularCoseno.Size = new System.Drawing.Size(154, 65);
            this.btnCalcularCoseno.TabIndex = 3;
            this.btnCalcularCoseno.Text = "Calcular Coseno";
            this.btnCalcularCoseno.UseVisualStyleBackColor = true;
            this.btnCalcularCoseno.Click += new System.EventHandler(this.btnCalcularCoseno_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevo.Location = new System.Drawing.Point(0, 138);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(154, 74);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.Location = new System.Drawing.Point(0, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 76);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnCalcularCoseno);
            this.panel2.Controls.Add(this.btnCalcularSeno);
            this.panel2.Location = new System.Drawing.Point(628, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 288);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt3);
            this.panel3.Controls.Add(this.txt2);
            this.panel3.Controls.Add(this.lblCosenoAngulo);
            this.panel3.Controls.Add(this.lblSenoAngulo);
            this.panel3.Location = new System.Drawing.Point(51, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 103);
            this.panel3.TabIndex = 7;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(175, 51);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(188, 20);
            this.txt3.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(173, 20);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(191, 20);
            this.txt2.TabIndex = 2;
            // 
            // lblCosenoAngulo
            // 
            this.lblCosenoAngulo.AutoSize = true;
            this.lblCosenoAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCosenoAngulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCosenoAngulo.Location = new System.Drawing.Point(19, 56);
            this.lblCosenoAngulo.Name = "lblCosenoAngulo";
            this.lblCosenoAngulo.Size = new System.Drawing.Size(127, 16);
            this.lblCosenoAngulo.TabIndex = 1;
            this.lblCosenoAngulo.Text = "Coseno del Angulo :";
            this.lblCosenoAngulo.Click += new System.EventHandler(this.lblCosenoAngulo_Click);
            // 
            // lblSenoAngulo
            // 
            this.lblSenoAngulo.AutoSize = true;
            this.lblSenoAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSenoAngulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSenoAngulo.Location = new System.Drawing.Point(18, 23);
            this.lblSenoAngulo.Name = "lblSenoAngulo";
            this.lblSenoAngulo.Size = new System.Drawing.Size(112, 16);
            this.lblSenoAngulo.TabIndex = 0;
            this.lblSenoAngulo.Text = "Seno del Angulo :";
            // 
            // lblFunciones
            // 
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFunciones.Location = new System.Drawing.Point(44, 169);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(189, 16);
            this.lblFunciones.TabIndex = 8;
            this.lblFunciones.Text = "Funciones trigonometricas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFunciones);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.Button btnCalcularSeno;
        private System.Windows.Forms.Button btnCalcularCoseno;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblCosenoAngulo;
        private System.Windows.Forms.Label lblSenoAngulo;
        private System.Windows.Forms.Label lblFunciones;
    }
}

