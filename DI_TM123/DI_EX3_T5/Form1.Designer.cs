namespace DI_EX3_T5
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
            this.components = new System.ComponentModel.Container();
            this.reproductorMultimedia1 = new NuevosProgramas.ReproductorMultimedia(this.components);
            this.SuspendLayout();
            // 
            // reproductorMultimedia1
            // 
            this.reproductorMultimedia1.Location = new System.Drawing.Point(12, 12);
            this.reproductorMultimedia1.Name = "reproductorMultimedia1";
            this.reproductorMultimedia1.Size = new System.Drawing.Size(252, 96);
            this.reproductorMultimedia1.TabIndex = 0;
            this.reproductorMultimedia1.PlayClick += new System.EventHandler(this.reproductorMultimedia1_PlayClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reproductorMultimedia1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NuevosProgramas.ReproductorMultimedia reproductorMultimedia1;
    }
}

