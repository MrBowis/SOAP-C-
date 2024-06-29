namespace CalculadoraCliente
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
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.NumericUpDown();
            this.N2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.N1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).BeginInit();
            this.SuspendLayout();
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(566, 61);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(121, 23);
            this.suma.TabIndex = 0;
            this.suma.Text = "suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(566, 90);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(121, 23);
            this.resta.TabIndex = 3;
            this.resta.Text = "resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(566, 119);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(121, 23);
            this.multiplicacion.TabIndex = 4;
            this.multiplicacion.Text = "multiplicación";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(566, 148);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(121, 23);
            this.division.TabIndex = 5;
            this.division.Text = "división";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(241, 178);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(72, 16);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "Resultado:";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(336, 178);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 16);
            this.resultado.TabIndex = 7;
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(241, 64);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(68, 16);
            this.lblN1.TabIndex = 8;
            this.lblN1.Text = "Numero 1:";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(241, 122);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(68, 16);
            this.lblN2.TabIndex = 9;
            this.lblN2.Text = "Numero 2:";
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(339, 62);
            this.N1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(120, 22);
            this.N1.TabIndex = 10;
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(339, 120);
            this.N2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(120, 22);
            this.N2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.N1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.NumericUpDown N1;
        private System.Windows.Forms.NumericUpDown N2;
    }
}

