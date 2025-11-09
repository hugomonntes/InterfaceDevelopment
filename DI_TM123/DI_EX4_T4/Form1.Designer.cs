namespace DI_EX4_T4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EliminarList1 = new System.Windows.Forms.RadioButton();
            this.EliminarList2 = new System.Windows.Forms.RadioButton();
            this.rbIntercambio1 = new System.Windows.Forms.RadioButton();
            this.rbIntercambio2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 82);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(138, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 82);
            this.listBox2.TabIndex = 1;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(274, 12);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(274, 41);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Location = new System.Drawing.Point(274, 70);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(75, 23);
            this.btnTraspasar.TabIndex = 4;
            this.btnTraspasar.Text = "Traspasar";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 81);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // EliminarList1
            // 
            this.EliminarList1.AutoSize = true;
            this.EliminarList1.Location = new System.Drawing.Point(552, 12);
            this.EliminarList1.Name = "EliminarList1";
            this.EliminarList1.Size = new System.Drawing.Size(89, 17);
            this.EliminarList1.TabIndex = 8;
            this.EliminarList1.TabStop = true;
            this.EliminarList1.Text = "Eliminar List 1";
            this.EliminarList1.UseVisualStyleBackColor = true;
            this.EliminarList1.CheckedChanged += new System.EventHandler(this.EliminarList1_CheckedChanged);
            // 
            // EliminarList2
            // 
            this.EliminarList2.AutoSize = true;
            this.EliminarList2.Location = new System.Drawing.Point(552, 35);
            this.EliminarList2.Name = "EliminarList2";
            this.EliminarList2.Size = new System.Drawing.Size(89, 17);
            this.EliminarList2.TabIndex = 9;
            this.EliminarList2.TabStop = true;
            this.EliminarList2.Text = "Eliminar List 2";
            this.EliminarList2.UseVisualStyleBackColor = true;
            // 
            // rbIntercambio1
            // 
            this.rbIntercambio1.AutoSize = true;
            this.rbIntercambio1.Location = new System.Drawing.Point(552, 58);
            this.rbIntercambio1.Name = "rbIntercambio1";
            this.rbIntercambio1.Size = new System.Drawing.Size(89, 17);
            this.rbIntercambio1.TabIndex = 10;
            this.rbIntercambio1.TabStop = true;
            this.rbIntercambio1.Text = "Intercambio 1";
            this.rbIntercambio1.UseVisualStyleBackColor = true;
            // 
            // rbIntercambio2
            // 
            this.rbIntercambio2.AutoSize = true;
            this.rbIntercambio2.Location = new System.Drawing.Point(552, 81);
            this.rbIntercambio2.Name = "rbIntercambio2";
            this.rbIntercambio2.Size = new System.Drawing.Size(89, 17);
            this.rbIntercambio2.TabIndex = 11;
            this.rbIntercambio2.TabStop = true;
            this.rbIntercambio2.Text = "Intercambio 2";
            this.rbIntercambio2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbIntercambio2);
            this.Controls.Add(this.rbIntercambio1);
            this.Controls.Add(this.EliminarList2);
            this.Controls.Add(this.EliminarList1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton EliminarList1;
        private System.Windows.Forms.RadioButton EliminarList2;
        private System.Windows.Forms.RadioButton rbIntercambio1;
        private System.Windows.Forms.RadioButton rbIntercambio2;
    }
}

