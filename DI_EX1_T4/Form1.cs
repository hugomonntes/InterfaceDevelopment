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
            }
            else
            {
                button1.BackColor = Color.Orange;
                button2.BackColor = Color.Orange;
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
            if (e.KeyChar is (char)Keys.Escape)
            {
                Text = originalTitle;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int counter = 0;
            int counterLocationX = 150;
            int counterLocationY = 200;
            Button[,] buttonsGroup = new Button[4, 5];
            for (int i = 0; i < buttonsGroup.GetLength(0); i++)
            {
                for (int j = 0; j < buttonsGroup.GetLength(1); j++)
                {
                    buttonsGroup[i, j] = new Button();
                    buttonsGroup[i, j].Text = $"Boton{counter + 1}";
                    buttonsGroup[i, j].Size = new System.Drawing.Size(75, 23);
                    buttonsGroup[i, j].Location = new System.Drawing.Point(counterLocationX, counterLocationY);
                    counter++;

                    counterLocationX += 100;
                    if (counter % 5 == 0)
                    {
                        counterLocationX = 150;
                        counterLocationY += 50;
                    }

                    buttonsGroup[i, j].MouseDown += buttonGroup_Down;
                    buttonsGroup[i, j].MouseUp += buttonGroup_Up;
                    buttonsGroup[i, j].MouseMove += Form1_MouseMove;


                    Controls.Add(buttonsGroup[i, j]);
                }
            }
        }

        public void buttonGroup_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Red;
        }

        public void buttonGroup_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }
    }
}

//• Además si se pulsa alguna tecla, dicha tecla debe aparecer como título
//del formulario. Si se pulsa ESC, entonces se restaura el título del
//formulario.