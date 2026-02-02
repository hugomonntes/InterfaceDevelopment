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
            this.labelTextBox1.Location = new System.Drawing.Point(32, 27);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = NuevosProgramas.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '·';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(156, 20);
            this.labelTextBox1.Subrayado = true;
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "bdskfalhfg";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.PosicionChanged += new System.EventHandler(this.labelTextBox1_PosicionChanged);
            this.labelTextBox1.SeparacionChanged += new System.EventHandler(this.labelTextBox1_SeparacionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 472);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.btnSeparar);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NuevosProgramas.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnSeparar;
        private System.Windows.Forms.Button btnJuntar;
    }
}

