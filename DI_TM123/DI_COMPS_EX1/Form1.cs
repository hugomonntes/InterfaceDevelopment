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

namespace DI_COMPS_EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnPosición_Click(object sender, EventArgs e)
        {
            labelTextBox1.Posicion = labelTextBox1.Posicion == NuevosProgramas.EPosicion.IZQUIERDA ? NuevosProgramas.EPosicion.DERECHA : NuevosProgramas.EPosicion.IZQUIERDA;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion += 10;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion -= 10; // Controlar excepcion de rangos
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("Evento KeyUp Lanzado");
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Texto cambiado");
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }
    }
}
