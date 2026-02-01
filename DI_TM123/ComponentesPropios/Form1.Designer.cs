using NuevosProgramas;

namespace ComponentesPropios
{
    partial class Form1
    {/// <summary>
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
            this.btnSeparacionMas = new System.Windows.Forms.Button();
            this.btnSeparacionMenos = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btn_pintar = new System.Windows.Forms.Button();
            this.labelTextBox1 = new LabelTextBox.LabelTextBox();
            this.SuspendLayout();
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(713, 332);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(75, 23);
            this.btnPosicion.TabIndex = 1;
            this.btnPosicion.Text = "Posicion";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnSeparacionMas
            // 
            this.btnSeparacionMas.Location = new System.Drawing.Point(713, 361);
            this.btnSeparacionMas.Name = "btnSeparacionMas";
            this.btnSeparacionMas.Size = new System.Drawing.Size(75, 23);
            this.btnSeparacionMas.TabIndex = 2;
            this.btnSeparacionMas.Text = "Separacion+";
            this.btnSeparacionMas.UseVisualStyleBackColor = true;
            this.btnSeparacionMas.Click += new System.EventHandler(this.btnSeparacionMas_Click);
            // 
            // btnSeparacionMenos
            // 
            this.btnSeparacionMenos.Location = new System.Drawing.Point(713, 390);
            this.btnSeparacionMenos.Name = "btnSeparacionMenos";
            this.btnSeparacionMenos.Size = new System.Drawing.Size(75, 23);
            this.btnSeparacionMenos.TabIndex = 3;
            this.btnSeparacionMenos.Text = "Separacion-";
            this.btnSeparacionMenos.UseVisualStyleBackColor = true;
            this.btnSeparacionMenos.Click += new System.EventHandler(this.btnSeparacionMenos_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(713, 420);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 4;
            this.btnPrueba.Text = "Prueba Label";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btn_pintar
            // 
            this.btn_pintar.Location = new System.Drawing.Point(713, 42);
            this.btn_pintar.Name = "btn_pintar";
            this.btn_pintar.Size = new System.Drawing.Size(75, 23);
            this.btn_pintar.TabIndex = 6;
            this.btn_pintar.Text = "Pintar";
            this.btn_pintar.UseVisualStyleBackColor = true;
            this.btn_pintar.Click += new System.EventHandler(this.btn_pintar_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.ColorSubrayado = System.Drawing.Color.RosyBrown;
            this.labelTextBox1.Location = new System.Drawing.Point(212, 307);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '\0';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(181, 20);
            this.labelTextBox1.Subrayado = true;
            this.labelTextBox1.TabIndex = 5;
            this.labelTextBox1.TextLbl = "label1";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.PosicionChanged += new System.EventHandler(this.labelTextBox1_PosicionChanged);
            this.labelTextBox1.SeparacionChanged += new System.EventHandler(this.labelTextBox1_SeparacionChanged);
            this.labelTextBox1.TxtTextChanged += new System.EventHandler(this.labelTextBox1_TxtTextChanged);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // Formulario_LabelTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pintar);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnSeparacionMenos);
            this.Controls.Add(this.btnSeparacionMas);
            this.Controls.Add(this.btnPosicion);
            this.Name = "Formulario_LabelTextBox";
            this.Text = "Pruebas";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Formulario_LabelTextBox_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnSeparacionMas;
        private System.Windows.Forms.Button btnSeparacionMenos;
        private System.Windows.Forms.Button btnPrueba;
        private LabelTextBox.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button btn_pintar;
    }
}

