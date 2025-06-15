namespace WindowsFormsApp1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblCosenoAngulo = new System.Windows.Forms.Label();
            this.lblSenoAngulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCalcularCoseno = new System.Windows.Forms.Label();
            this.lblCalcularSeno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAngulo);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Location = new System.Drawing.Point(55, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 90);
            this.panel1.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt3);
            this.panel3.Controls.Add(this.txt2);
            this.panel3.Controls.Add(this.lblCosenoAngulo);
            this.panel3.Controls.Add(this.lblSenoAngulo);
            this.panel3.Location = new System.Drawing.Point(55, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 103);
            this.panel3.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seno del Angulo :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCalcularSeno);
            this.groupBox1.Controls.Add(this.lblCalcularCoseno);
            this.groupBox1.Location = new System.Drawing.Point(591, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 302);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblCalcularCoseno
            // 
            this.lblCalcularCoseno.AutoSize = true;
            this.lblCalcularCoseno.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCalcularCoseno.Location = new System.Drawing.Point(54, 42);
            this.lblCalcularCoseno.Name = "lblCalcularCoseno";
            this.lblCalcularCoseno.Size = new System.Drawing.Size(84, 13);
            this.lblCalcularCoseno.TabIndex = 0;
            this.lblCalcularCoseno.Text = "Calcular Coseno";
            // 
            // lblCalcularSeno
            // 
            this.lblCalcularSeno.AutoSize = true;
            this.lblCalcularSeno.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCalcularSeno.Location = new System.Drawing.Point(54, 88);
            this.lblCalcularSeno.Name = "lblCalcularSeno";
            this.lblCalcularSeno.Size = new System.Drawing.Size(73, 13);
            this.lblCalcularSeno.TabIndex = 1;
            this.lblCalcularSeno.Text = "Calcular Seno";
            this.lblCalcularSeno.Click += new System.EventHandler(this.lblCalcularSeno_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(48, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(48, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblCosenoAngulo;
        private System.Windows.Forms.Label lblSenoAngulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCalcularSeno;
        private System.Windows.Forms.Label lblCalcularCoseno;
        private System.Windows.Forms.Label label5;
    }
}

