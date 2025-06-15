namespace Perimetro_de_un_cuadrado
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
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblRespuesta);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.btnCalcularPerimetro);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblLado);
            this.panel1.Controls.Add(this.lblPerimetro);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(217, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 398);
            this.panel1.TabIndex = 0;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(162, 149);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
            this.lblRespuesta.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblResultado.Location = new System.Drawing.Point(305, 207);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(57, 15);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado :";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnCalcularPerimetro
            // 
            this.btnCalcularPerimetro.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalcularPerimetro.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPerimetro.Location = new System.Drawing.Point(287, 277);
            this.btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            this.btnCalcularPerimetro.Size = new System.Drawing.Size(104, 52);
            this.btnCalcularPerimetro.TabIndex = 3;
            this.btnCalcularPerimetro.Text = "Calcular el Perímetro";
            this.btnCalcularPerimetro.UseVisualStyleBackColor = false;
            this.btnCalcularPerimetro.Click += new System.EventHandler(this.btnCalcularPerimetro_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.BackColor = System.Drawing.Color.SeaGreen;
            this.lblLado.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblLado.Location = new System.Drawing.Point(274, 107);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(130, 15);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Escribe la medida del lado ";
            this.lblLado.Click += new System.EventHandler(this.lblLado_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(12, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(51, 13);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perimetro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 565);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcularPerimetro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLado;
    }
}

