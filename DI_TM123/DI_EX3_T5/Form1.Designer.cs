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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.reproductorMultimedia1 = new NuevosProgramas.ReproductorMultimedia(this.components);
            this.timerPresentacion = new System.Windows.Forms.Timer(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(450, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // reproductorMultimedia1
            // 
            this.reproductorMultimedia1.Location = new System.Drawing.Point(12, 12);
            this.reproductorMultimedia1.Minutos = 0;
            this.reproductorMultimedia1.Name = "reproductorMultimedia1";
            this.reproductorMultimedia1.Segundos = 0;
            this.reproductorMultimedia1.Size = new System.Drawing.Size(170, 56);
            this.reproductorMultimedia1.TabIndex = 0;
            this.reproductorMultimedia1.PlayClick += new System.EventHandler(this.reproductorMultimedia1_PlayClick);
            this.reproductorMultimedia1.DesbordaTiempo += new System.EventHandler(this.reproductorMultimedia1_DesbordaTiempo);
            // 
            // timerPresentacion
            // 
            this.timerPresentacion.Interval = 1000;
            this.timerPresentacion.Tick += new System.EventHandler(this.TimerPresentacion_Tick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(145, 25);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(299, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Seleccionar Directiorio";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSeleccionarDirectorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reproductorMultimedia1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ICONO Y TITULO CAMBIADO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NuevosProgramas.ReproductorMultimedia reproductorMultimedia1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timerPresentacion;
        private System.Windows.Forms.Button btnSelect;
    }
}