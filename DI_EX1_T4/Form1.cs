using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX1_T4
{
    public partial class Form1 : Form
    {
        String originalTitle;
        public Form1()
        {
            InitializeComponent();
            originalTitle = this.Text;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Coordenadas X: {MousePosition.X}, Coordenadas Y: {MousePosition.Y}";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = originalTitle;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Left)
            {
                button1.BackColor = Color.Yellow;
            }
            else if (e.Button is MouseButtons.Right)
            {
                button2.BackColor = Color.Red;
            } else
            {
                button1.BackColor = Color.Azure;
                button2.BackColor = Color.Azure;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Empty;
            button2.BackColor = Color.Empty;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = e.KeyChar.ToString();
            if (e.KeyChar is (Char)Keys.Escape)
            {
                Text = originalTitle;
            }
        }
    }
}

//• Además si se pulsa alguna tecla, dicha tecla debe aparecer como título
//del formulario. Si se pulsa ESC, entonces se restaura el título del
//formulario.