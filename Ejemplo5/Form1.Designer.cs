namespace Ejemplo5
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listbArreglo = new System.Windows.Forms.ListBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalculo4 = new System.Windows.Forms.Button();
            this.btnCalculo3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCalculo1 = new System.Windows.Forms.Button();
            this.txtCalculo4 = new System.Windows.Forms.TextBox();
            this.txtCalculo3 = new System.Windows.Forms.TextBox();
            this.txtCalculo2 = new System.Windows.Forms.TextBox();
            this.txtCalculo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Lime;
            this.btnIngresar.Location = new System.Drawing.Point(468, 37);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(139, 41);
            this.btnIngresar.TabIndex = 18;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ingrese un valor al arreglo";
            // 
            // listbArreglo
            // 
            this.listbArreglo.FormattingEnabled = true;
            this.listbArreglo.ItemHeight = 16;
            this.listbArreglo.Location = new System.Drawing.Point(43, 198);
            this.listbArreglo.Name = "listbArreglo";
            this.listbArreglo.Size = new System.Drawing.Size(202, 324);
            this.listbArreglo.TabIndex = 16;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(276, 46);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(143, 22);
            this.txbNumero.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculo4);
            this.groupBox2.Controls.Add(this.txtCalculo1);
            this.groupBox2.Controls.Add(this.btnCalculo3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCalculo1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCalculo4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCalculo3);
            this.groupBox2.Controls.Add(this.txtCalculo2);
            this.groupBox2.Location = new System.Drawing.Point(321, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 400);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPERACIONES CON ARREGLO";
            // 
            // btnCalculo4
            // 
            this.btnCalculo4.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculo4.Location = new System.Drawing.Point(555, 281);
            this.btnCalculo4.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculo4.Name = "btnCalculo4";
            this.btnCalculo4.Size = new System.Drawing.Size(100, 28);
            this.btnCalculo4.TabIndex = 30;
            this.btnCalculo4.Text = "Mostrar";
            this.btnCalculo4.UseVisualStyleBackColor = false;
            this.btnCalculo4.Click += new System.EventHandler(this.btnCalculo4_Click);
            // 
            // btnCalculo3
            // 
            this.btnCalculo3.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculo3.Location = new System.Drawing.Point(555, 221);
            this.btnCalculo3.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculo3.Name = "btnCalculo3";
            this.btnCalculo3.Size = new System.Drawing.Size(100, 28);
            this.btnCalculo3.TabIndex = 29;
            this.btnCalculo3.Text = "Mostrar";
            this.btnCalculo3.UseVisualStyleBackColor = false;
            this.btnCalculo3.Click += new System.EventHandler(this.btnCalculo3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(555, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 28;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCalculo1
            // 
            this.btnCalculo1.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculo1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculo1.Location = new System.Drawing.Point(555, 91);
            this.btnCalculo1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculo1.Name = "btnCalculo1";
            this.btnCalculo1.Size = new System.Drawing.Size(100, 28);
            this.btnCalculo1.TabIndex = 27;
            this.btnCalculo1.Text = "Mostrar";
            this.btnCalculo1.UseVisualStyleBackColor = false;
            this.btnCalculo1.Click += new System.EventHandler(this.btnCalculo1_Click);
            // 
            // txtCalculo4
            // 
            this.txtCalculo4.Location = new System.Drawing.Point(300, 281);
            this.txtCalculo4.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalculo4.Name = "txtCalculo4";
            this.txtCalculo4.ReadOnly = true;
            this.txtCalculo4.Size = new System.Drawing.Size(230, 22);
            this.txtCalculo4.TabIndex = 26;
            // 
            // txtCalculo3
            // 
            this.txtCalculo3.Location = new System.Drawing.Point(300, 221);
            this.txtCalculo3.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalculo3.Name = "txtCalculo3";
            this.txtCalculo3.ReadOnly = true;
            this.txtCalculo3.Size = new System.Drawing.Size(230, 22);
            this.txtCalculo3.TabIndex = 25;
            // 
            // txtCalculo2
            // 
            this.txtCalculo2.Location = new System.Drawing.Point(300, 154);
            this.txtCalculo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalculo2.Name = "txtCalculo2";
            this.txtCalculo2.ReadOnly = true;
            this.txtCalculo2.Size = new System.Drawing.Size(230, 22);
            this.txtCalculo2.TabIndex = 24;
            // 
            // txtCalculo1
            // 
            this.txtCalculo1.Location = new System.Drawing.Point(300, 90);
            this.txtCalculo1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalculo1.Name = "txtCalculo1";
            this.txtCalculo1.ReadOnly = true;
            this.txtCalculo1.Size = new System.Drawing.Size(230, 22);
            this.txtCalculo1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mayor de los pares positivos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Promedio de impares positivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Porcentaje de ceros en el arreglo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Numeros Mayores de pares negativos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 609);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listbArreglo);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listbArreglo;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalculo4;
        private System.Windows.Forms.TextBox txtCalculo1;
        private System.Windows.Forms.Button btnCalculo3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalculo4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalculo3;
        private System.Windows.Forms.TextBox txtCalculo2;
    }
}

