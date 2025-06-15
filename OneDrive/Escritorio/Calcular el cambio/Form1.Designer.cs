namespace Calcular_el_cambio
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
            this.lblRespuestavuelto = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCambio = new System.Windows.Forms.Button();
            this.lblCoste = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.lblRespuestavuelto);
            this.panel1.Controls.Add(this.lblRespuesta);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCambio);
            this.panel1.Controls.Add(this.lblCoste);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtDinero);
            this.panel1.Controls.Add(this.lblDinero);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(75, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 321);
            this.panel1.TabIndex = 0;
            // 
            // lblRespuestavuelto
            // 
            this.lblRespuestavuelto.AutoSize = true;
            this.lblRespuestavuelto.Location = new System.Drawing.Point(184, 168);
            this.lblRespuestavuelto.Name = "lblRespuestavuelto";
            this.lblRespuestavuelto.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestavuelto.TabIndex = 9;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(138, 210);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(100, 13);
            this.lblRespuesta.TabIndex = 8;
            this.lblRespuesta.Text = "El vuelto es de :";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSalir.Location = new System.Drawing.Point(119, 281);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnLimpiar.Location = new System.Drawing.Point(399, 281);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCambio
            // 
            this.btnCambio.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCambio.Location = new System.Drawing.Point(262, 272);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(98, 32);
            this.btnCambio.TabIndex = 5;
            this.btnCambio.Text = "Calcular cambio";
            this.btnCambio.UseVisualStyleBackColor = false;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoste.Location = new System.Drawing.Point(238, 114);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(153, 13);
            this.lblCoste.TabIndex = 4;
            this.lblCoste.Text = "Ingre el dinero del costo :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(229, 60);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(170, 20);
            this.txtDinero.TabIndex = 2;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.Location = new System.Drawing.Point(238, 29);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(142, 13);
            this.lblDinero.TabIndex = 1;
            this.lblDinero.Text = "Ingrese el dinero dado :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Cambio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Label lblRespuestavuelto;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblNombre;
    }
}

