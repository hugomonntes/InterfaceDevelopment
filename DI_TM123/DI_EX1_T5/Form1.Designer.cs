namespace DI_EX1_T5
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
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnSeparar = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.labelTextBox1 = new NuevosProgramas.LabelTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(156, 73);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(118, 23);
            this.btnPosicion.TabIndex = 1;
            this.btnPosicion.Text = "Cambio de posición";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnSeparar
            // 
            this.btnSeparar.Location = new System.Drawing.Point(32, 73);
            this.btnSeparar.Name = "btnSeparar";
            this.btnSeparar.Size = new System.Drawing.Size(118, 23);
            this.btnSeparar.TabIndex = 2;
            this.btnSeparar.Text = "Separar";
            this.btnSeparar.UseVisualStyleBackColor = true;
            this.btnSeparar.Click += new System.EventHandler(this.btnSeparar_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(280, 73);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(118, 23);
            this.btnJuntar.TabIndex = 3;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.ColorSubrayado = System.Drawing.Color.Black;
            this.labelTextBox1.Location = new System.Drawing.Point(32, 35);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = NuevosProgramas.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '*';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(279, 20);
            this.labelTextBox1.Subrayado = true;
            this.labelTextBox1.TabIndex = 4;
            this.labelTextBox1.TextLbl = "label1354453457357657336556734";
            this.labelTextBox1.TextTxt = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.btnSeparar);
            this.Controls.Add(this.btnPosicion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnSeparar;
        private System.Windows.Forms.Button btnJuntar;
        private NuevosProgramas.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

