namespace Encendido___Apagado
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
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEncender = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(12, 76);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(132, 83);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEncender
            // 
            this.btnEncender.BackColor = System.Drawing.Color.Lime;
            this.btnEncender.Location = new System.Drawing.Point(228, 76);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(132, 83);
            this.btnEncender.TabIndex = 1;
            this.btnEncender.Text = "ENCENDER";
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 211);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.btnApagar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.TextBox textBox1;
    }
}

