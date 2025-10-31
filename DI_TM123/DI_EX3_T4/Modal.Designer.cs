namespace DI_EX3_T4
{
    partial class Modal
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
            this.pbModal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbModal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbModal
            // 
            this.pbModal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbModal.Location = new System.Drawing.Point(0, 0);
            this.pbModal.Name = "pbModal";
            this.pbModal.Size = new System.Drawing.Size(800, 450);
            this.pbModal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModal.TabIndex = 0;
            this.pbModal.TabStop = false;
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbModal);
            this.Name = "Modal";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbModal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbModal;
    }
}