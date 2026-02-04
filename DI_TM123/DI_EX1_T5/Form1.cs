using NuevosProgramas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX1_T5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag = true;
        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Text = "Aumento";
            }
            else
            {
                this.Text = "Disminución";
            }
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == EPosicion.IZQUIERDA)
            {
                labelTextBox1.Posicion = EPosicion.DERECHA;
            }
            else
            {
                labelTextBox1.Posicion = EPosicion.IZQUIERDA;
            }
        }

        private void btnSeparar_Click(object sender, EventArgs e)
        {
            flag = true;
            labelTextBox1.Separacion += 2;
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Separacion > 0)
            {
                flag = false;
                labelTextBox1.Separacion -= 2;
            }
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = "KeyUp usado";
        }
    }
}
