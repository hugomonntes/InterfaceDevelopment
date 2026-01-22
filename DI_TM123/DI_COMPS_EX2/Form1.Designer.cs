namespace DI_COMPS_EX2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etiquetaAviso1 = new NuevosProgramas.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorFinalGradiente = System.Drawing.Color.DeepSkyBlue;
            this.etiquetaAviso1.ColorInicioGradiente = System.Drawing.Color.LawnGreen;
            this.etiquetaAviso1.FondoGradiente = true;
            this.etiquetaAviso1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.etiquetaAviso1.ImagenMarca = ((System.Drawing.Image)(resources.GetObject("etiquetaAviso1.ImagenMarca")));
            this.etiquetaAviso1.Location = new System.Drawing.Point(12, 12);
            this.etiquetaAviso1.Marca = NuevosProgramas.EMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.etiquetaAviso1.Size = new System.Drawing.Size(104, 25);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_Click);
            this.etiquetaAviso1.Click += new System.EventHandler(this.etiquetaAviso1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NuevosProgramas.EtiquetaAviso etiquetaAviso1;
    }
}

