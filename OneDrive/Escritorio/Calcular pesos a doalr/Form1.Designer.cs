namespace Dolares_a_PesosMX
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
            this.btnPesosDolar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblConversion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.btnPesosDolar);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.lblConversion);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblPesos);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(104, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 298);
            this.panel1.TabIndex = 0;
            // 
            // btnPesosDolar
            // 
            this.btnPesosDolar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPesosDolar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnPesosDolar.Location = new System.Drawing.Point(31, 221);
            this.btnPesosDolar.Name = "btnPesosDolar";
            this.btnPesosDolar.Size = new System.Drawing.Size(136, 74);
            this.btnPesosDolar.TabIndex = 4;
            this.btnPesosDolar.Text = "Boton de conversion";
            this.btnPesosDolar.UseVisualStyleBackColor = false;
            this.btnPesosDolar.Click += new System.EventHandler(this.btnPesosDolar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(209, 116);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblConversion.Location = new System.Drawing.Point(28, 159);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(150, 19);
            this.lblConversion.TabIndex = 1;
            this.lblConversion.Text = "La Conversion es :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.Location = new System.Drawing.Point(28, 49);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(335, 19);
            this.lblPesos.TabIndex = 1;
            this.lblPesos.Text = "Ingrese la cantidad de pesos a convertir :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Conversiones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnPesosDolar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.TextBox textBox1;
    }
}

