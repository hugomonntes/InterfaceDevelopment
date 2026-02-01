using NuevosProgramas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesPropios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool flagSeparacion = true;

        private void labelTextBox1_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("estoy en el paint del txtbox");
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == LabelTextBox)
            {
                labelTextBox1.Posicion = LabelTextBox.EPosicion.IZQUIERDA;
            }
            else
            {
                labelTextBox1.Posicion = LabelTextBox.EPosicion.DERECHA;
            }
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }

        private void btnSeparacionMas_Click(object sender, EventArgs e)
        {
            flagSeparacion = true;
            labelTextBox1.Separacion += 5;
        }

        private void btnSeparacionMenos_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Separacion >= 5)
            {
                flagSeparacion = false;
                labelTextBox1.Separacion -= 5;
            }
        }

        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            if (flagSeparacion)
            {
                this.Text = "La separacion aumentó";
            }
            else
            {
                this.Text = "La separación disminuyó";
            }
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            labelTextBox1.TextLbl = "Tecla:" + e.KeyValue.ToString();
        }

        private void labelTextBox1_TxtTextChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.TextTxt.ToString();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            labelTextBox1.TextLbl = "Prueba de si va bien el ancho del componente";
        }

        private void Formulario_LabelTextBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Aquamarine, 5, 10, 130, 50);
            e.Graphics.DrawString("Prueba de escritura", this.Font, Brushes.BlueViolet, 20, 25);
        }

        private void btn_pintar_Click(object sender, EventArgs e)
        {
            pintar = !pintar;
            this.Refresh();
            this.Text = pintar.ToString();
        }
        bool pintar = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            if (pintar)
            {
                base.OnPaint(e);
                e.Graphics.DrawString("Prueba de escritura 2", this.Font, Brushes.BlueViolet, 20, 70);

            }
        }
    }
}
