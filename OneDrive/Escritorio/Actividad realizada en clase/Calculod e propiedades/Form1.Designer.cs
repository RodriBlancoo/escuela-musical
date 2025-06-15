namespace Calcular_propiedades
{
    partial class FmrSistemadeNotas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrSistemadeNotas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblerror = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.lblRegistroNotas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblPromedioObtenido = new System.Windows.Forms.Label();
            this.lblPromedios = new System.Windows.Forms.Label();
            this.tlpAyeda = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblerror);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblnota3);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnPromedio);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.lblnota2);
            this.panel1.Controls.Add(this.lblnota1);
            this.panel1.Controls.Add(this.lblRegistroNotas);
            this.panel1.Location = new System.Drawing.Point(35, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 254);
            this.panel1.TabIndex = 0;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.IndianRed;
            this.lblerror.Location = new System.Drawing.Point(43, 223);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(51, 13);
            this.lblerror.TabIndex = 11;
            this.lblerror.Text = "ERROR";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 7;
            this.tlpAyeda.SetToolTip(this.textBox1, "Ingrese un valor entre 0 y 10\r\n");
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota3.Location = new System.Drawing.Point(33, 158);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(56, 16);
            this.lblnota3.TabIndex = 6;
            this.lblnota3.Text = "Nota 3:";
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota2.Location = new System.Drawing.Point(33, 98);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(56, 16);
            this.lblnota2.TabIndex = 2;
            this.lblnota2.Text = "Nota 2:";
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota1.Location = new System.Drawing.Point(33, 51);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(56, 16);
            this.lblnota1.TabIndex = 1;
            this.lblnota1.Text = "Nota 1:";
            // 
            // lblRegistroNotas
            // 
            this.lblRegistroNotas.AutoSize = true;
            this.lblRegistroNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroNotas.Location = new System.Drawing.Point(3, 0);
            this.lblRegistroNotas.Name = "lblRegistroNotas";
            this.lblRegistroNotas.Size = new System.Drawing.Size(111, 16);
            this.lblRegistroNotas.TabIndex = 0;
            this.lblRegistroNotas.Text = "Registro Notas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.lblPromedioObtenido);
            this.panel2.Controls.Add(this.lblPromedios);
            this.panel2.Location = new System.Drawing.Point(41, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 104);
            this.panel2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(163, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(271, 20);
            this.textBox4.TabIndex = 2;
            // 
            // lblPromedioObtenido
            // 
            this.lblPromedioObtenido.AutoSize = true;
            this.lblPromedioObtenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioObtenido.Location = new System.Drawing.Point(18, 46);
            this.lblPromedioObtenido.Name = "lblPromedioObtenido";
            this.lblPromedioObtenido.Size = new System.Drawing.Size(139, 15);
            this.lblPromedioObtenido.TabIndex = 1;
            this.lblPromedioObtenido.Text = "Promedio Obtenido :";
            // 
            // lblPromedios
            // 
            this.lblPromedios.AutoSize = true;
            this.lblPromedios.Location = new System.Drawing.Point(0, 0);
            this.lblPromedios.Name = "lblPromedios";
            this.lblPromedios.Size = new System.Drawing.Size(51, 13);
            this.lblPromedios.TabIndex = 0;
            this.lblPromedios.Text = "Promedio";
            // 
            // tlpAyeda
            // 
            this.tlpAyeda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyeda.ToolTipTitle = "Mensage de Ayuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calcular_propiedades.Properties.Resources.user_icon_icons_com_57997;
            this.pictureBox1.Location = new System.Drawing.Point(364, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Calcular_propiedades.Properties.Resources.letterx_83737;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(465, 160);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(131, 46);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Image = global::Calcular_propiedades.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.btnPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromedio.Location = new System.Drawing.Point(465, 99);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(131, 51);
            this.btnPromedio.TabIndex = 4;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Calcular_propiedades.Properties.Resources.icons8_clean_32;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(470, 26);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 67);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FmrSistemadeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmrSistemadeNotas";
            this.Text = "Sistema de Notas ITR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.Label lblRegistroNotas;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblPromedioObtenido;
        private System.Windows.Forms.Label lblPromedios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.ToolTip tlpAyeda;
    }
}

