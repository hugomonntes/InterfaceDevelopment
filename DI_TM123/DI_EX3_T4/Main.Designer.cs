namespace DI_EX3_T4
{
    partial class Main
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
            this.newImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cbModal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // newImage
            // 
            this.newImage.Location = new System.Drawing.Point(12, 12);
            this.newImage.Name = "newImage";
            this.newImage.Size = new System.Drawing.Size(170, 23);
            this.newImage.TabIndex = 0;
            this.newImage.Text = "Nueva Imagen";
            this.newImage.UseVisualStyleBackColor = true;
            this.newImage.Click += new System.EventHandler(this.newImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "*.jpg|*.png";
            // 
            // cbModal
            // 
            this.cbModal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbModal.AutoSize = true;
            this.cbModal.Location = new System.Drawing.Point(188, 16);
            this.cbModal.Name = "cbModal";
            this.cbModal.Size = new System.Drawing.Size(55, 17);
            this.cbModal.TabIndex = 1;
            this.cbModal.Text = "Modal";
            this.cbModal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbModal);
            this.Controls.Add(this.newImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox cbModal;
    }
}

