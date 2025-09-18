namespace DI_EX6
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
            this.txbDatos = new System.Windows.Forms.TextBox();
            this.btnIntro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbDatos
            // 
            this.txbDatos.Location = new System.Drawing.Point(304, 206);
            this.txbDatos.Name = "txbDatos";
            this.txbDatos.Size = new System.Drawing.Size(325, 20);
            this.txbDatos.TabIndex = 0;
            // 
            // btnIntro
            // 
            this.btnIntro.Location = new System.Drawing.Point(217, 206);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(81, 21);
            this.btnIntro.TabIndex = 1;
            this.btnIntro.Text = "button1";
            this.btnIntro.UseVisualStyleBackColor = true;
            this.btnIntro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 471);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.txbDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDatos;
        private System.Windows.Forms.Button btnIntro;
    }
}

