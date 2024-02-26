namespace Ejercicio3
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.rdPeso = new System.Windows.Forms.RadioButton();
            this.rdLongitud = new System.Windows.Forms.RadioButton();
            this.rdTemperatura = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(294, 321);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(172, 37);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // rdPeso
            // 
            this.rdPeso.AutoSize = true;
            this.rdPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPeso.Location = new System.Drawing.Point(327, 252);
            this.rdPeso.Margin = new System.Windows.Forms.Padding(4);
            this.rdPeso.Name = "rdPeso";
            this.rdPeso.Size = new System.Drawing.Size(74, 28);
            this.rdPeso.TabIndex = 8;
            this.rdPeso.TabStop = true;
            this.rdPeso.Text = "Peso";
            this.rdPeso.UseVisualStyleBackColor = true;
            // 
            // rdLongitud
            // 
            this.rdLongitud.AutoSize = true;
            this.rdLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLongitud.Location = new System.Drawing.Point(327, 199);
            this.rdLongitud.Margin = new System.Windows.Forms.Padding(4);
            this.rdLongitud.Name = "rdLongitud";
            this.rdLongitud.Size = new System.Drawing.Size(104, 28);
            this.rdLongitud.TabIndex = 7;
            this.rdLongitud.TabStop = true;
            this.rdLongitud.Text = "Longitud";
            this.rdLongitud.UseVisualStyleBackColor = true;
            // 
            // rdTemperatura
            // 
            this.rdTemperatura.AutoSize = true;
            this.rdTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTemperatura.Location = new System.Drawing.Point(327, 147);
            this.rdTemperatura.Margin = new System.Windows.Forms.Padding(4);
            this.rdTemperatura.Name = "rdTemperatura";
            this.rdTemperatura.Size = new System.Drawing.Size(139, 28);
            this.rdTemperatura.TabIndex = 6;
            this.rdTemperatura.TabStop = true;
            this.rdTemperatura.Text = "Temperatura";
            this.rdTemperatura.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione la conversión:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.rdPeso);
            this.Controls.Add(this.rdLongitud);
            this.Controls.Add(this.rdTemperatura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.RadioButton rdPeso;
        private System.Windows.Forms.RadioButton rdLongitud;
        private System.Windows.Forms.RadioButton rdTemperatura;
        private System.Windows.Forms.Label label1;
    }
}

