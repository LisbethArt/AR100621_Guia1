namespace Ejemplo3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbrecibido = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbrecibido
            // 
            this.lbrecibido.AutoSize = true;
            this.lbrecibido.Location = new System.Drawing.Point(97, 81);
            this.lbrecibido.Name = "lbrecibido";
            this.lbrecibido.Size = new System.Drawing.Size(44, 16);
            this.lbrecibido.TabIndex = 0;
            this.lbrecibido.Text = "label1";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(178, 134);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 1;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 251);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.lbrecibido);
            this.Name = "Form2";
            this.Text = "Ventana 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbrecibido;
        private System.Windows.Forms.Button btnregresar;
    }
}