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

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = labelTextBox1.TextLbl;
            Console.WriteLine(texto);
            labelTextBox1.Posicion = labelTextBox1.Posicion == NuevosProgramas.EPosicion.IZQUIERDA ? NuevosProgramas.EPosicion.DERECHA : NuevosProgramas.EPosicion.IZQUIERDA;
        }

        private void labelTextBox1_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("Estoy paint del Label Text Box");
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("cambia posicion");
        }
    }
}
